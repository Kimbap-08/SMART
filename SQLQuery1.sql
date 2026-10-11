-- SMART Admin Panel database setup for SQL Server LocalDB.
-- Connection string used by the application:
-- Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;
-- Safe to run repeatedly. Existing records are preserved.

IF DB_ID(N'SMARTdb') IS NULL
    CREATE DATABASE SMARTdb;
GO

USE SMARTdb;
GO

IF OBJECT_ID(N'dbo.Students', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Students
    (
        StudentID   VARCHAR(10)   NOT NULL CONSTRAINT PK_Students PRIMARY KEY,
        StudentName NVARCHAR(100) NOT NULL,
        Program     NVARCHAR(150) NOT NULL,
        Department  NVARCHAR(150) NOT NULL,
        YearLevel   NVARCHAR(20)  NOT NULL,
        Status      NVARCHAR(20)  NULL,
        IsFrozen    BIT           NOT NULL CONSTRAINT DF_Students_IsFrozen DEFAULT (0),
        CreatedAt   DATETIME2     NOT NULL CONSTRAINT DF_Students_CreatedAt DEFAULT SYSDATETIME()
    );
END;
GO

IF OBJECT_ID(N'dbo.Instructors', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Instructors
    (
        EmployeeID   NVARCHAR(50)  NOT NULL CONSTRAINT PK_Instructors PRIMARY KEY,
        FullName     NVARCHAR(100) NOT NULL,
        Program      NVARCHAR(150) NOT NULL,
        Department   NVARCHAR(150) NOT NULL,
        Email        NVARCHAR(254) NOT NULL CONSTRAINT DF_Instructors_Email DEFAULT N'',
        Username     NVARCHAR(30)  NULL,
        PasswordHash NVARCHAR(200) NULL,
        IsActive     BIT           NOT NULL CONSTRAINT DF_Instructors_IsActive DEFAULT (1),
        IsFrozen     BIT           NOT NULL CONSTRAINT DF_Instructors_IsFrozen DEFAULT (0)
    );
END;
GO

-- Migrate older instructor tables. Each ALTER is separated by GO so later
-- batches can safely compile queries that use the new columns.
IF COL_LENGTH(N'dbo.Instructors', N'Email') IS NULL
    ALTER TABLE dbo.Instructors ADD Email NVARCHAR(254) NOT NULL
        CONSTRAINT DF_Instructors_Email DEFAULT N'';
GO
IF COL_LENGTH(N'dbo.Instructors', N'Username') IS NULL
    ALTER TABLE dbo.Instructors ADD Username NVARCHAR(30) NULL;
GO
IF COL_LENGTH(N'dbo.Instructors', N'PasswordHash') IS NULL
    ALTER TABLE dbo.Instructors ADD PasswordHash NVARCHAR(200) NULL;
GO
IF COL_LENGTH(N'dbo.Instructors', N'IsActive') IS NULL
    ALTER TABLE dbo.Instructors ADD IsActive BIT NOT NULL
        CONSTRAINT DF_Instructors_IsActive DEFAULT (1);
GO
IF COL_LENGTH(N'dbo.Instructors', N'IsFrozen') IS NULL
    ALTER TABLE dbo.Instructors ADD IsFrozen BIT NOT NULL
        CONSTRAINT DF_Instructors_IsFrozen DEFAULT (0);
GO
IF NOT EXISTS
(
    SELECT 1 FROM sys.indexes
    WHERE object_id = OBJECT_ID(N'dbo.Instructors') AND name = N'UX_Instructors_Username'
)
    CREATE UNIQUE INDEX UX_Instructors_Username ON dbo.Instructors(Username)
        WHERE Username IS NOT NULL;
GO

IF OBJECT_ID(N'dbo.Courses', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Courses
    (
        CourseRecordID       INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Courses PRIMARY KEY,
        CourseTitle          NVARCHAR(100) NOT NULL,
        CourseName           NVARCHAR(200) NOT NULL,
        CourseCode           NVARCHAR(50)  NOT NULL,
        Program              NVARCHAR(150) NOT NULL,
        InstructorEmployeeID NVARCHAR(50)  NULL,
        RoomNumber           NVARCHAR(100) NOT NULL,
        Day                  NVARCHAR(50)  NOT NULL,
        Time                 NVARCHAR(100) NOT NULL,
        Term                 NVARCHAR(50)  NOT NULL,
        IsFrozen             BIT           NOT NULL CONSTRAINT DF_Courses_IsFrozen DEFAULT (0),
        CONSTRAINT FK_Courses_Instructors FOREIGN KEY (InstructorEmployeeID)
            REFERENCES dbo.Instructors(EmployeeID) ON UPDATE CASCADE ON DELETE SET NULL
    );
END;
GO

UPDATE dbo.Courses SET Term = N'Term' WHERE Term = N'Tern';
GO
IF NOT EXISTS
(
    SELECT 1 FROM sys.indexes
    WHERE object_id = OBJECT_ID(N'dbo.Courses') AND name = N'UX_Courses_CourseCode'
)
AND NOT EXISTS
(
    SELECT CourseCode FROM dbo.Courses GROUP BY CourseCode HAVING COUNT(*) > 1
)
    CREATE UNIQUE INDEX UX_Courses_CourseCode ON dbo.Courses(CourseCode);
... (225 lines left)
