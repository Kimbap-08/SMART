using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SMART
{
    internal static class DatabaseConnection
    {
        internal const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;";
        private static string? currentPipe;
        internal static string DiagnosticPath => Path.Combine(AppContext.BaseDirectory, "database-connection.log");

        internal static void Open(SqlConnection connection)
        {
            // Use the instance's current pipe first when it is already running.
            // This avoids invoking SQL Client's LocalDB startup API unnecessarily.
            currentPipe ??= FindRunningPipe();
            if (currentPipe != null)
                UsePipe(connection, currentPipe);
            try
            {
                connection.Open();
            }
            catch (SqlException ex) when (currentPipe != null || IsLocalDbStartupError(ex))
            {
                Log($"Connection failed: {ex.Message}");
                // Discover the running instance before trying to start it. Some
                // environments fail in the LocalDB startup API even while SQL runs.
                string? pipe = FindRunningPipe();
                if (pipe == null)
                {
                    RunLocalDb("start MSSQLLocalDB", out _);
                    pipe = FindRunningPipe();
                }
                if (pipe == null)
                {
                    Log("Recovery could not discover a running instance pipe.");
                    throw;
                }
                SqlConnection.ClearPool(connection);
                UsePipe(connection, pipe);
                connection.Open();
                currentPipe = pipe;
            }
        }

        private static void UsePipe(SqlConnection connection, string pipe)
        {
            var builder = new SqlConnectionStringBuilder(connection.ConnectionString)
            {
                DataSource = pipe
            };
            connection.ConnectionString = builder.ConnectionString;
        }

        private static bool IsLocalDbStartupError(SqlException exception) =>
            exception.Message.Contains("LocalDB", StringComparison.OrdinalIgnoreCase) ||
            exception.Message.Contains("Local Database Runtime", StringComparison.OrdinalIgnoreCase);

        private static string? FindRunningPipe()
        {
            if (!RunLocalDb("info MSSQLLocalDB", out string output)) return null;
            // Match the value itself so this also works with localized CLI labels.
            var match = Regex.Match(output, @"np:\\\\.\\pipe\\LOCALDB#[A-Za-z0-9]+\\tsql\\query", RegexOptions.IgnoreCase);
            if (!match.Success) Log("LocalDB info did not contain a pipe: " + output.Replace("\0", "<NUL>"));
            return match.Success ? match.Value : null;
        }

        private static bool RunLocalDb(string arguments, out string output)
        {
            output = "";
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = "SqlLocalDB.exe",
                    Arguments = arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };
                using var process = Process.Start(startInfo);
                if (process == null) return false;
                var standardOutput = process.StandardOutput.ReadToEndAsync();
                var standardError = process.StandardError.ReadToEndAsync();
                if (!process.WaitForExit(15000))
                {
                    process.Kill();
                    Log($"SqlLocalDB {arguments}: timed out after 15 seconds.");
                    return false;
                }
                Task.WhenAll(standardOutput, standardError).GetAwaiter().GetResult();
                output = standardOutput.Result;
                if (process.ExitCode != 0)
                    Log($"SqlLocalDB {arguments}: exit {process.ExitCode}; {output}; {standardError.Result}");
                return process.ExitCode == 0;
            }
            catch (Win32Exception ex) { Log($"SqlLocalDB {arguments}: {ex.Message}"); return false; }
            catch (InvalidOperationException ex) { Log($"SqlLocalDB {arguments}: {ex.Message}"); return false; }
        }

        private static void Log(string message)
        {
            try
            {
                File.AppendAllText(DiagnosticPath,
                    $"{DateTimeOffset.Now:O} [{Environment.UserDomainName}\\{Environment.UserName}; " +
                    $"{System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}] {message}{Environment.NewLine}");
            }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
        }
    }
}
