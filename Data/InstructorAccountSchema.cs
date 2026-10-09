using System.Data.SqlClient;

namespace SMART
{
    internal static class InstructorAccountSchema
    {
        internal static void Initialize(SqlConnection connection)
        {
            Execute(connection, @"IF OBJECT_ID(N'dbo.Instructors', N'U') IS NULL
                CREATE TABLE dbo.Instructors (
                    EmployeeID NVARCHAR(50) NOT NULL CONSTRAINT PK_Instructors PRIMARY KEY,
                    FullName NVARCHAR(100) NOT NULL,
                    Program NVARCHAR(150) NOT NULL,
                    Department NVARCHAR(150) NOT NULL,
                    Email NVARCHAR(254) NOT NULL CONSTRAINT DF_Instructors_Email DEFAULT N'',
                    Username NVARCHAR(30) NULL,
                    PasswordHash NVARCHAR(200) NULL,
                    IsActive BIT NOT NULL CONSTRAINT DF_Instructors_IsActive DEFAULT (1)
                );");

            // Run each ALTER in its own batch so SQL Server refreshes the table
            // metadata before later commands refer to the new columns.
            Execute(connection, @"IF COL_LENGTH(N'dbo.Instructors', N'Email') IS NULL
                ALTER TABLE dbo.Instructors ADD Email NVARCHAR(254) NOT NULL
                    CONSTRAINT DF_Instructors_Email DEFAULT N'';");
            Execute(connection, @"IF COL_LENGTH(N'dbo.Instructors', N'Username') IS NULL
                ALTER TABLE dbo.Instructors ADD Username NVARCHAR(30) NULL;");
            Execute(connection, @"IF COL_LENGTH(N'dbo.Instructors', N'PasswordHash') IS NULL
                ALTER TABLE dbo.Instructors ADD PasswordHash NVARCHAR(200) NULL;");
            Execute(connection, @"IF COL_LENGTH(N'dbo.Instructors', N'IsActive') IS NULL
                ALTER TABLE dbo.Instructors ADD IsActive BIT NOT NULL CONSTRAINT DF_Instructors_IsActive DEFAULT (1);");
            Execute(connection, @"IF NOT EXISTS (SELECT 1 FROM sys.indexes
                    WHERE object_id = OBJECT_ID(N'dbo.Instructors') AND name = N'UX_Instructors_Username')
                CREATE UNIQUE INDEX UX_Instructors_Username ON dbo.Instructors(Username)
                WHERE Username IS NOT NULL;");
        }

        private static void Execute(SqlConnection connection, string sql)
        {
            using var command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
