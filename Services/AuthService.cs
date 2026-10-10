using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using SMART.NewFolder;

namespace SMART
{
    public static class AuthService
    {
        private const string DefaultAdminUsername = "admin";
        private const string DefaultAdminEmail = "admin@smart.local";
        private const string DefaultAdminPassword = "admin12345";

        private static readonly string DbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "SMART", "smart.db");

        private static readonly string ConnectionString = "Data Source=" + DbPath;
        private static bool initialized;

        // ── Private: opens a raw connection ──────────────────────────
        private static SqliteConnection Open()
        {
            var conn = new SqliteConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        // ── Public: used by every DAO class in the project ───────────
        public static SqliteConnection GetConnection()
        {
            Initialize();
            return Open();
        }

        // ── Creates all tables and the default admin account ──────────
        public static void Initialize()
        {
            if (initialized) return;

            Directory.CreateDirectory(Path.GetDirectoryName(DbPath));

            using (var conn = Open())
            {
                // ── Users ─────────────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username     TEXT NOT NULL UNIQUE COLLATE NOCASE,
                        Email        TEXT NOT NULL UNIQUE COLLATE NOCASE,
                        PasswordHash TEXT NOT NULL,
                        Role         TEXT NOT NULL,
                        CreatedAt    TEXT NOT NULL
                    );");

                // ── Students ──────────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS Students (
                        StudentId     INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentNumber TEXT NOT NULL UNIQUE,
                        FullName      TEXT NOT NULL,
                        YearLevel     TEXT NOT NULL,
                        Program       TEXT NOT NULL,
                        Section       TEXT NOT NULL,
                        Status        TEXT NOT NULL DEFAULT 'ACTIVE'
                    );");

                // ── Instructors ───────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS Instructors (
                        InstructorId   INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId         INTEGER NOT NULL,
                        EmployeeNumber TEXT NOT NULL UNIQUE,
                        FullName       TEXT NOT NULL,
                        Email          TEXT,
                        FOREIGN KEY (UserId) REFERENCES Users(Id)
                    );");

                // ── Courses ───────────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseId       INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseCode     TEXT NOT NULL,
                        CourseName     TEXT NOT NULL,
                        Section        TEXT NOT NULL,
                        Program        TEXT NOT NULL DEFAULT 'All Programs',
                        InstructorId   INTEGER,
                        EnrollmentCode TEXT NOT NULL UNIQUE,
                        FOREIGN KEY (InstructorId) REFERENCES Instructors(InstructorId)
                    );");

                // ── Enrollments ───────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS Enrollments (
                        EnrollmentId INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId    INTEGER NOT NULL,
                        CourseId     INTEGER NOT NULL,
                        EnrolledAt   TEXT NOT NULL,
                        FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
                        FOREIGN KEY (CourseId)  REFERENCES Courses(CourseId)
                    );");

                // ── Attendance ────────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS Attendance (
                        AttendanceId INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId    INTEGER NOT NULL,
                        CourseId     INTEGER NOT NULL,
                        Date         TEXT NOT NULL,
                        Status       TEXT NOT NULL DEFAULT 'PRESENT',
                        FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
                        FOREIGN KEY (CourseId)  REFERENCES Courses(CourseId)
                    );");

                // ── Quizzes ───────────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS Quizzes (
                        QuizId     INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseId   INTEGER NOT NULL,
                        Title      TEXT NOT NULL,
                        TotalScore REAL NOT NULL,
                        Date       TEXT,
                        FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
                    );");

                // ── Quiz Scores ───────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS QuizScores (
                        ScoreId   INTEGER PRIMARY KEY AUTOINCREMENT,
                        QuizId    INTEGER NOT NULL,
                        StudentId INTEGER NOT NULL,
                        Score     REAL NOT NULL DEFAULT 0,
                        FOREIGN KEY (QuizId)    REFERENCES Quizzes(QuizId),
                        FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
                    );");

                // ── Exams ─────────────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS Exams (
                        ExamId     INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseId   INTEGER NOT NULL,
                        Title      TEXT NOT NULL,
                        TotalScore REAL NOT NULL,
                        Date       TEXT,
                        FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
                    );");

                // ── Exam Scores ───────────────────────────────────────
                Exec(conn, @"
                    CREATE TABLE IF NOT EXISTS ExamScores (
                        ScoreId   INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamId    INTEGER NOT NULL,
                        StudentId INTEGER NOT NULL,
                        Score     REAL NOT NULL DEFAULT 0,
                        FOREIGN KEY (ExamId)    REFERENCES Exams(ExamId),
                        FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
                    );");

                // ── Seed default admin if none exists ─────────────────
                long admins;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Role = 'Admin'";
                    admins = Convert.ToInt64(cmd.ExecuteScalar());
                }

                if (admins == 0)
                    Insert(conn, DefaultAdminUsername,
                                 DefaultAdminEmail,
                                 DefaultAdminPassword,
                                 UserRole.Admin);
            }

            initialized = true;
        }

        // ── Shortcut so Initialize() stays readable ───────────────────
        private static void Exec(SqliteConnection conn, string sql)
        {
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }

        // ── Login ─────────────────────────────────────────────────────
        public static User Login(string username, string password)
        {
            Initialize();
            username = (username ?? "").Trim();
            password ??= "";

            using (var conn = Open())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText =
                    "SELECT Id, Username, Email, PasswordHash, Role " +
                    "FROM Users WHERE Username = @u AND Role = 'Admin' LIMIT 1";
                cmd.Parameters.AddWithValue("@u", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHash = reader.GetString(3);
                        if (!PasswordHasher.Verify(password, storedHash)) return null;

                        return new User
                        {
                            Id = (int)reader.GetInt64(0),
                            Username = reader.GetString(1),
                            Email = reader.GetString(2),
                            Role = UserRole.Admin
                        };
                    }
                }
            }

            using (var connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                DatabaseConnection.Open(connection);
                InstructorAccountSchema.Initialize(connection);
                using var command = new SqlCommand(@"SELECT Email, PasswordHash, IsActive
                    FROM dbo.Instructors WHERE Username = @Username", connection);
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = username;
                using var reader = command.ExecuteReader();
                if (!reader.Read()) return null;
                if (!reader.GetBoolean(2)) throw new AccountDisabledException();
                if (!PasswordHasher.Verify(password, reader.GetString(1))) return null;
                return new User
                {
                    Id = 0,
                    Username = username,
                    Email = reader.IsDBNull(0) ? "" : reader.GetString(0),
                    Role = UserRole.Instructor
                };
            }
        }

        // ── Private helpers ───────────────────────────────────────────
        private static void Insert(SqliteConnection conn, string username,
                                    string email, string password, UserRole role)
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

    public sealed class AccountDisabledException : Exception
    {
        public AccountDisabledException() : base("Your account was disabled.") { }
    }
}
