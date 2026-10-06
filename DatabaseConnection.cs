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
            if (RunLocalDb("info MSSQLLocalDB", out string output))
            {
                // Match the value itself so this also works with localized CLI labels.
                var match = Regex.Match(output, @"np:\\\\.\\pipe\\LOCALDB#[A-Za-z0-9]+\\tsql\\query", RegexOptions.IgnoreCase);
                if (match.Success) return match.Value;
                Log("LocalDB info did not contain a pipe: " + output.Replace("\0", "<NUL>"));
            }
            // Visual Studio can start SQL Server while LocalDB's instance metadata
            // still reports Stopped. The instance's own server log identifies its pipe.
            return FindPipeFromServerLog();
        }

        private static string? FindPipeFromServerLog()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Microsoft", "Microsoft SQL Server Local DB", "Instances", "MSSQLLocalDB", "error.log");
            try
            {
                using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
                using var reader = new StreamReader(stream);
                string serverLog = reader.ReadToEnd();
                if (!TryReadServerPipe(serverLog, out string pipe, out int processId)) return null;
                using var process = Process.GetProcessById(processId);
                if (process.HasExited || !process.ProcessName.Equals("sqlservr", StringComparison.OrdinalIgnoreCase)) return null;
                Log($"Discovered running LocalDB process {processId} from its server log.");
                return pipe;
            }
            catch (IOException) { return null; }
            catch (UnauthorizedAccessException) { return null; }
            catch (ArgumentException) { return null; }
            catch (InvalidOperationException) { return null; }
            catch (Win32Exception) { return null; }
        }

        internal static bool TryReadServerPipe(string serverLog, out string pipe, out int processId)
        {
            pipe = "";
            processId = 0;
            var starts = Regex.Matches(serverLog, @"Server process ID is (\d+)\.", RegexOptions.IgnoreCase);
            if (starts.Count == 0) return false;
            var latestStart = starts[starts.Count - 1];
            if (!int.TryParse(latestStart.Groups[1].Value, out processId)) return false;
            var match = Regex.Match(serverLog.Substring(latestStart.Index),
                @"Server local connection provider is ready to accept connection on\s*\[\s*(\\\\\.\\pipe\\LOCALDB#[A-Za-z0-9]+\\tsql\\query)\s*\]",
                RegexOptions.IgnoreCase);
            if (!match.Success) return false;
            pipe = "np:" + match.Groups[1].Value;
            return true;
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
