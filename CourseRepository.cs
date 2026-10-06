using System.Data;
using System.Data.SqlClient;

namespace SMART
{
    internal static class CourseRepository
    {
        internal const string Schema = @"
            IF OBJECT_ID(N'dbo.Instructors', N'U') IS NULL
            BEGIN
                CREATE TABLE dbo.Instructors (
                    EmployeeID NVARCHAR(50) NOT NULL CONSTRAINT PK_Instructors PRIMARY KEY,
                    FullName NVARCHAR(100) NOT NULL,
                    Program NVARCHAR(150) NOT NULL,
                    Department NVARCHAR(150) NOT NULL,
                    Email NVARCHAR(254) NOT NULL CONSTRAINT DF_Instructors_Email DEFAULT N''
                );
            END;
            IF OBJECT_ID(N'dbo.Courses', N'U') IS NULL
            BEGIN
                CREATE TABLE dbo.Courses (
                    CourseRecordID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Courses PRIMARY KEY,
                    CourseTitle NVARCHAR(100) NOT NULL,
                    CourseName NVARCHAR(200) NOT NULL,
                    CourseCode NVARCHAR(50) NOT NULL,
                    Program NVARCHAR(150) NOT NULL,
                    InstructorEmployeeID NVARCHAR(50) NULL,
                    RoomNumber NVARCHAR(100) NOT NULL,
                    Day NVARCHAR(50) NOT NULL,
                    Time NVARCHAR(100) NOT NULL,
                    Term NVARCHAR(50) NOT NULL,
                    CONSTRAINT FK_Courses_Instructors FOREIGN KEY (InstructorEmployeeID)
                        REFERENCES dbo.Instructors(EmployeeID) ON UPDATE CASCADE ON DELETE SET NULL
                );
            END;
            UPDATE dbo.Courses SET Term = N'Term' WHERE Term = N'Tern';
            IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.Courses')
                AND name = N'UX_Courses_CourseCode')
                AND NOT EXISTS (SELECT CourseCode FROM dbo.Courses GROUP BY CourseCode HAVING COUNT(*) > 1)
            BEGIN
                CREATE UNIQUE INDEX UX_Courses_CourseCode ON dbo.Courses(CourseCode);
            END;";

        internal static void Initialize()
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(Schema, connection);
            command.ExecuteNonQuery();
        }

        internal static DataTable LoadCourses()
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"
                SELECT c.CourseRecordID, c.CourseTitle AS [Course Title], c.CourseName AS [Course Name],
                    c.CourseCode AS [Course Code], c.Program,
                    COALESCE(i.FullName, N'Unassigned') AS Instructor,
                    c.RoomNumber AS [Room Number], c.Day, c.Time, c.Term, c.InstructorEmployeeID
                FROM dbo.Courses c LEFT JOIN dbo.Instructors i ON i.EmployeeID = c.InstructorEmployeeID
                ORDER BY c.CourseRecordID", connection);
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal static List<InstructorChoice> LoadInstructors()
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand("SELECT EmployeeID, FullName FROM dbo.Instructors ORDER BY FullName, EmployeeID", connection);
            using var reader = command.ExecuteReader();
            var instructors = new List<InstructorChoice>();
            while (reader.Read()) instructors.Add(new InstructorChoice(reader.GetString(0), reader.GetString(1)));
            return instructors;
        }

        internal static bool CourseCodeExists(string code, int? recordId)
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT COUNT(*) FROM dbo.Courses
                WHERE CourseCode = @Code AND (@RecordID IS NULL OR CourseRecordID <> @RecordID)", connection);
            command.Parameters.Add("@Code", SqlDbType.NVarChar, 50).Value = code;
            command.Parameters.Add("@RecordID", SqlDbType.Int).Value = (object?)recordId ?? DBNull.Value;
            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }

        internal static int Save(int? recordId, string[] values, string employeeId)
        {
            using var connection = OpenConnection();
            using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
            const string duplicateCheck = @"
                IF EXISTS (SELECT 1 FROM dbo.Courses WITH (UPDLOCK, HOLDLOCK)
                    WHERE CourseCode = @Code AND (@RecordID IS NULL OR CourseRecordID <> @RecordID))
                    THROW 51001, 'Course Code already exists.', 1;";
            using var command = new SqlCommand(duplicateCheck + (recordId.HasValue ? @"
                UPDATE dbo.Courses SET CourseTitle = @Title, CourseName = @Name, CourseCode = @Code,
                    Program = @Program, InstructorEmployeeID = @Instructor, RoomNumber = @Room,
                    Day = @Day, Time = @Time, Term = @Term WHERE CourseRecordID = @RecordID;
                SELECT @@ROWCOUNT;" : @"
                INSERT INTO dbo.Courses (CourseTitle, CourseName, CourseCode, Program, InstructorEmployeeID,
                    RoomNumber, Day, Time, Term)
                VALUES (@Title, @Name, @Code, @Program, @Instructor, @Room, @Day, @Time, @Term);
                SELECT CAST(SCOPE_IDENTITY() AS INT);"), connection, transaction);
            command.Parameters.Add("@Title", SqlDbType.NVarChar, 100).Value = values[0];
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = values[1];
            command.Parameters.Add("@Code", SqlDbType.NVarChar, 50).Value = values[2];
            command.Parameters.Add("@Program", SqlDbType.NVarChar, 150).Value = values[3];
            command.Parameters.Add("@Instructor", SqlDbType.NVarChar, 50).Value = employeeId;
            command.Parameters.Add("@Room", SqlDbType.NVarChar, 100).Value = values[5];
            command.Parameters.Add("@Day", SqlDbType.NVarChar, 50).Value = values[6];
            command.Parameters.Add("@Time", SqlDbType.NVarChar, 100).Value = values[7];
            command.Parameters.Add("@Term", SqlDbType.NVarChar, 50).Value = values[8];
            command.Parameters.Add("@RecordID", SqlDbType.Int).Value = (object?)recordId ?? DBNull.Value;
            int result = Convert.ToInt32(command.ExecuteScalar());
            transaction.Commit();
            return result;
        }

        internal static int Delete(int recordId)
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand("DELETE FROM dbo.Courses WHERE CourseRecordID = @RecordID", connection);
            command.Parameters.Add("@RecordID", SqlDbType.Int).Value = recordId;
            return command.ExecuteNonQuery();
        }

        private static SqlConnection OpenConnection()
        {
            var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            try { DatabaseConnection.Open(connection); return connection; }
            catch { connection.Dispose(); throw; }
        }
    }

    internal sealed record InstructorChoice(string EmployeeId, string FullName)
    {
        public override string ToString() => FullName;
    }
}
