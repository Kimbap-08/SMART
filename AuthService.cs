using System;
using System.IO;
using System.Text.RegularExpressions;
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

        // ── Register a new Instructor account ─────────────────────────
        public static bool Register(string username, string email,
                                     string password, out string error)
        {
            error = null;
            username = (username ?? "").Trim();
            email = (email ?? "").Trim();
            password = password ?? "";

            if (!Regex.IsMatch(username, @"^[A-Za-z0-9_.]{3,30}$"))
            {
                error = "Username must be 3–30 characters: letters, numbers, dots or underscores.";
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
                { error = "That username is already taken."; return false; }

                if (Exists(conn, "SELECT 1 FROM Users WHERE Email = @v LIMIT 1", email))
                { error = "That email is already registered."; return false; }

                Insert(conn, username, email, password, UserRole.Instructor);
            }

            return true;
        }

        // ── Login ─────────────────────────────────────────────────────
        public static User Login(string username, string password)
        {
            Initialize();

            using (var conn = Open())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText =
                    "SELECT Id, Username, Email, PasswordHash, Role " +
                    "FROM Users WHERE Username = @u LIMIT 1";
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

        // ── Private helpers ───────────────────────────────────────────
        private static bool Exists(SqliteConnection conn, string sql, string value)
        {
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@v", value);
                return cmd.ExecuteScalar() != null;
            }
        }

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
}