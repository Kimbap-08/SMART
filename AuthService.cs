using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SMART
{
    /// <summary>
    /// All the account logic lives here: creating the database, registering
    /// instructors, and checking logins. If you later move to SQL Server or MySQL,
    /// this is the only file that needs to change.
    /// </summary>
    public static class AuthService
    {
        // The first-run admin account. CHANGE THE PASSWORD before you use this for real.
        private const string DefaultAdminUsername = "admin";
        private const string DefaultAdminEmail = "admin@smart.local";
        private const string DefaultAdminPassword = "Admin@12345";

        private static readonly string DbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "SMART", "smart.db");

        private static readonly string ConnectionString = "Data Source=" + DbPath;
        private static bool initialized;

        private static SqliteConnection Open()
        {
            var conn = new SqliteConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Creates the database and the first admin account if they don't exist yet.
        /// Safe to call more than once.
        /// </summary>
        public static void Initialize()
        {
            if (initialized) return;

            Directory.CreateDirectory(Path.GetDirectoryName(DbPath));

            using (var conn = Open())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"CREATE TABLE IF NOT EXISTS Users (
                            Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username     TEXT NOT NULL UNIQUE COLLATE NOCASE,
                            Email        TEXT NOT NULL UNIQUE COLLATE NOCASE,
                            PasswordHash TEXT NOT NULL,
                            Role         TEXT NOT NULL,
                            CreatedAt    TEXT NOT NULL
                          );";
                    cmd.ExecuteNonQuery();
                }

                long admins;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Role = 'Admin'";
                    admins = Convert.ToInt64(cmd.ExecuteScalar());
                }

                if (admins == 0)
                    Insert(conn, DefaultAdminUsername, DefaultAdminEmail, DefaultAdminPassword, UserRole.Admin);
            }

            initialized = true;
        }

        /// <summary>
        /// Creates an INSTRUCTOR account. Sign-up can never create an admin.
        /// Returns false and sets error if something is wrong with the input.
        /// </summary>
        public static bool Register(string username, string email, string password, out string error)
        {
            error = null;
            username = (username ?? "").Trim();
            email = (email ?? "").Trim();
            password = password ?? "";

            if (!Regex.IsMatch(username, @"^[A-Za-z0-9_.]{3,30}$"))
            {
                error = "Username must be 3 to 30 characters: letters, numbers, dots or underscores.";
                return false;
            }

            if (username.Equals(DefaultAdminUsername, StringComparison.OrdinalIgnoreCase) ||
                username.Equals("administrator", StringComparison.OrdinalIgnoreCase))
            {
                error = "That username is reserved. Please choose another.";
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                error = "Please enter a valid email address.";
                return false;
            }

            if (password.Length < 8)
            {
                error = "Password must be at least 8 characters.";
                return false;
            }

            Initialize();

            using (var conn = Open())
            {
                if (Exists(conn, "SELECT 1 FROM Users WHERE Username = @v LIMIT 1", username))
                {
                    error = "That username is already taken.";
                    return false;
                }

                if (Exists(conn, "SELECT 1 FROM Users WHERE Email = @v LIMIT 1", email))
                {
                    error = "That email is already registered.";
                    return false;
                }

                Insert(conn, username, email, password, UserRole.Instructor);
            }

            return true;
        }

        /// <summary>
        /// Returns the user if the username and password are correct, otherwise null.
        /// </summary>
        public static User Login(string username, string password)
        {
            Initialize();

            using (var conn = Open())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText =
                    "SELECT Id, Username, Email, PasswordHash, Role FROM Users WHERE Username = @u LIMIT 1";
                cmd.Parameters.AddWithValue("@u", (username ?? "").Trim());

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return null;

                    string storedHash = reader.GetString(3);
                    if (!PasswordHasher.Verify(password ?? "", storedHash)) return null;

                    return new User
                    {
                        Id = (int)reader.GetInt64(0),
                        Username = reader.GetString(1),
                        Email = reader.GetString(2),
                        Role = (UserRole)Enum.Parse(typeof(UserRole), reader.GetString(4))
                    };
                }
            }
        }

        private static bool Exists(SqliteConnection conn, string sql, string value)
        {
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@v", value);
                return cmd.ExecuteScalar() != null;
            }
        }

        private static void Insert(SqliteConnection conn, string username, string email, string password, UserRole role)
        {
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText =
                    @"INSERT INTO Users (Username, Email, PasswordHash, Role, CreatedAt)
                      VALUES (@u, @e, @p, @r, @c)";
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@p", PasswordHasher.Hash(password));
                cmd.Parameters.AddWithValue("@r", role.ToString());
                cmd.Parameters.AddWithValue("@c", DateTime.UtcNow.ToString("o"));
                cmd.ExecuteNonQuery();
            }
        }
    }
}