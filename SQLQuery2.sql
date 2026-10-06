-- SMARTdb setup for SQL Server LocalDB
-- Matches the connection string used by Students.cs and AdminDashboard.cs:
--   Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;
-- Safe to run more than once: it only creates what is missing.

IF DB_ID(N'SMARTdb') IS NULL
BEGIN
    CREATE DATABASE SMARTdb;
END
GO

USE SMARTdb;
GO

IF OBJECT_ID(N'dbo.Students', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Students
    (
        StudentID    VARCHAR(10)    NOT NULL CONSTRAINT PK_Students PRIMARY KEY,  -- the 6-digit ID typed in the form
        StudentName  NVARCHAR(100)  NOT NULL,
        Program      NVARCHAR(150)  NOT NULL,
        Department   NVARCHAR(150)  NOT NULL,
        YearLevel    NVARCHAR(20)   NOT NULL,                                     -- "1st Year" ... "5th Year"
        Status       NVARCHAR(20)   NULL,                                         -- the app inserts NULL for now
        CreatedAt    DATETIME2      NOT NULL CONSTRAINT DF_Students_CreatedAt DEFAULT SYSDATETIME()
    );
END
GO

-- Optional: uncomment to add two sample rows for testing
-- INSERT INTO dbo.Students (StudentID, StudentName, Program, Department, YearLevel)
-- VALUES ('123456', N'Juan D. Dela Cruz', N'BS in Computer Science', N'College of Computing Education (CCE)', N'2nd Year'),
--        ('654321', N'Maria L. Santos',   N'BS in Nursing',          N'College of Health Sciences Education (CHSE)', N'1st Year');
-- GO

SELECT COUNT(*) AS StudentCount FROM dbo.Students;
GO

-- Instructor management records. Email stays blank for now.
IF OBJECT_ID(N'dbo.Instructors', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Instructors
    (
        EmployeeID NVARCHAR(50) NOT NULL CONSTRAINT PK_Instructors PRIMARY KEY,
        FullName NVARCHAR(100) NOT NULL,
        Program NVARCHAR(150) NOT NULL,
        Department NVARCHAR(150) NOT NULL,
        Email NVARCHAR(254) NOT NULL CONSTRAINT DF_Instructors_Email DEFAULT N''
    );
END
GO
