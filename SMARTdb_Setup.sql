-- S.M.A.R.T. submission database setup for SQL Server LocalDB.
-- Connection string used by the application:
-- Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;
-- Safe to run repeatedly. Existing records are preserved.

USE master;
GO

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
GO

IF OBJECT_ID(N'dbo.Enrollments', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Enrollments
    (
        EnrollmentId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Enrollments PRIMARY KEY,
        StudentID    VARCHAR(10) NOT NULL,
        CourseId     INT NOT NULL,
        EnrolledAt   DATETIME NOT NULL CONSTRAINT DF_Enrollments_EnrolledAt DEFAULT GETDATE(),
        IsFrozen     BIT NOT NULL CONSTRAINT DF_Enrollments_IsFrozen DEFAULT (0),
        CONSTRAINT FK_Enrollments_Students FOREIGN KEY (StudentID) REFERENCES dbo.Students(StudentID),
        CONSTRAINT FK_Enrollments_Courses FOREIGN KEY (CourseId) REFERENCES dbo.Courses(CourseRecordID),
        CONSTRAINT UQ_Enrollments_Student_Course UNIQUE (StudentID, CourseId)
    );
END;
GO
IF COL_LENGTH(N'dbo.Enrollments', N'IsFrozen') IS NULL
    ALTER TABLE dbo.Enrollments ADD IsFrozen BIT NOT NULL CONSTRAINT DF_Enrollments_IsFrozen DEFAULT (0);
GO

IF OBJECT_ID(N'dbo.Attendance', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Attendance
    (
        AttendanceId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Attendance PRIMARY KEY,
        StudentID    VARCHAR(10) NOT NULL REFERENCES dbo.Students(StudentID),
        CourseId     INT NOT NULL REFERENCES dbo.Courses(CourseRecordID),
        Date         DATE NOT NULL,
        Status       NVARCHAR(20) NOT NULL CONSTRAINT DF_Attendance_Status DEFAULT N'PRESENT'
    );
END;
GO

IF OBJECT_ID(N'dbo.Quizzes', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Quizzes
    (
        QuizId     INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Quizzes PRIMARY KEY,
        CourseId   INT NOT NULL REFERENCES dbo.Courses(CourseRecordID),
        Title      NVARCHAR(100) NOT NULL,
        TotalScore FLOAT NOT NULL,
        Date       DATE NULL
    );
END;
GO

IF OBJECT_ID(N'dbo.QuizScores', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.QuizScores
    (
        ScoreId   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_QuizScores PRIMARY KEY,
        QuizId    INT NOT NULL REFERENCES dbo.Quizzes(QuizId),
        StudentID VARCHAR(10) NOT NULL REFERENCES dbo.Students(StudentID),
        Score     FLOAT NOT NULL CONSTRAINT DF_QuizScores_Score DEFAULT (0),
        CONSTRAINT UQ_QuizScores_Quiz_Student UNIQUE (QuizId, StudentID)
    );
END;
GO

IF OBJECT_ID(N'dbo.Exams', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Exams
    (
        ExamId       INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Exams PRIMARY KEY,
        CourseId     INT NOT NULL REFERENCES dbo.Courses(CourseRecordID),
        Title        NVARCHAR(100) NOT NULL,
        TotalScore   FLOAT NOT NULL CONSTRAINT DF_Exams_TotalScore DEFAULT (0),
        TotalItems   INT NOT NULL CONSTRAINT DF_Exams_TotalItems DEFAULT (0),
        WeightPercent DECIMAL(5,2) NOT NULL CONSTRAINT DF_Exams_WeightPercent DEFAULT (0),
        ExamType     NVARCHAR(30) NOT NULL CONSTRAINT DF_Exams_ExamType DEFAULT N'Exam',
        GradingPeriod NVARCHAR(30) NOT NULL CONSTRAINT DF_Exams_GradingPeriod DEFAULT N'Term',
        Date         DATE NULL,
        Status       NVARCHAR(20) NOT NULL CONSTRAINT DF_Exams_Status DEFAULT N'Not entered'
    );
END;
GO

IF COL_LENGTH(N'dbo.Exams', N'TotalItems') IS NULL
    ALTER TABLE dbo.Exams ADD TotalItems INT NULL;
GO
IF COL_LENGTH(N'dbo.Exams', N'WeightPercent') IS NULL
    ALTER TABLE dbo.Exams ADD WeightPercent DECIMAL(5,2) NULL;
GO
IF COL_LENGTH(N'dbo.Exams', N'ExamType') IS NULL
    ALTER TABLE dbo.Exams ADD ExamType NVARCHAR(30) NULL;
GO
IF COL_LENGTH(N'dbo.Exams', N'GradingPeriod') IS NULL
    ALTER TABLE dbo.Exams ADD GradingPeriod NVARCHAR(30) NULL;
GO
IF COL_LENGTH(N'dbo.Exams', N'Status') IS NULL
    ALTER TABLE dbo.Exams ADD Status NVARCHAR(20) NOT NULL CONSTRAINT DF_Exams_Status DEFAULT N'Not entered';
GO
UPDATE e SET
    TotalItems = COALESCE(e.TotalItems, TRY_CONVERT(INT, e.TotalScore), 0),
    WeightPercent = COALESCE(e.WeightPercent, 0),
    GradingPeriod = COALESCE(NULLIF(e.GradingPeriod, N''),
        CASE WHEN UPPER(c.Term) IN (N'SEM', N'SEMESTER') THEN N'Semester'
             WHEN UPPER(c.Term) = N'SUMMER' THEN N'Summer' ELSE N'Term' END),
    ExamType = COALESCE(NULLIF(e.ExamType, N''),
        CASE WHEN e.Title IN (N'Final Exam', N'Final') THEN N'Final'
             WHEN e.Title IN (N'Prelim', N'Midterm') THEN e.Title ELSE N'Exam' END)
FROM dbo.Exams e LEFT JOIN dbo.Courses c ON c.CourseRecordID = e.CourseId;
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes
    WHERE object_id = OBJECT_ID(N'dbo.Exams') AND name = N'UX_Exams_Course_Period_Title')
AND NOT EXISTS (SELECT CourseId, GradingPeriod, Title FROM dbo.Exams
    GROUP BY CourseId, GradingPeriod, Title HAVING COUNT(*) > 1)
    CREATE UNIQUE INDEX UX_Exams_Course_Period_Title ON dbo.Exams(CourseId, GradingPeriod, Title);
GO

IF OBJECT_ID(N'dbo.ExamScores', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.ExamScores
    (
        ScoreId   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_ExamScores PRIMARY KEY,
        ExamId    INT NOT NULL REFERENCES dbo.Exams(ExamId),
        StudentID VARCHAR(10) NOT NULL REFERENCES dbo.Students(StudentID),
        Score     FLOAT NOT NULL CONSTRAINT DF_ExamScores_Score DEFAULT (0),
        CONSTRAINT UQ_ExamScores_Exam_Student UNIQUE (ExamId, StudentID)
    );
END;
GO

IF NOT EXISTS
(
    SELECT 1 FROM sys.indexes
    WHERE object_id = OBJECT_ID(N'dbo.Attendance') AND name = N'UX_Attendance_Student_Course_Date'
)
AND NOT EXISTS
(
    SELECT StudentID, CourseId, Date FROM dbo.Attendance
    GROUP BY StudentID, CourseId, Date HAVING COUNT(*) > 1
)
    CREATE UNIQUE INDEX UX_Attendance_Student_Course_Date
        ON dbo.Attendance(StudentID, CourseId, Date);
GO


-- Instructor and messaging features.
IF OBJECT_ID(N'dbo.Announcements', N'U') IS NULL
              CREATE TABLE dbo.Announcements (
                AnnouncementId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Announcements PRIMARY KEY,
                Title NVARCHAR(200) NOT NULL,
                Message NVARCHAR(MAX) NOT NULL,
                PostedBy NVARCHAR(100) NOT NULL CONSTRAINT DF_Announcements_PostedBy DEFAULT N'System Administrator',
                PostedAt DATETIME NOT NULL CONSTRAINT DF_Announcements_PostedAt DEFAULT GETDATE(),
                IsActive BIT NOT NULL CONSTRAINT DF_Announcements_IsActive DEFAULT (1),
                Priority NVARCHAR(20) NOT NULL CONSTRAINT DF_Announcements_Priority DEFAULT N'Normal',
                TargetProgram NVARCHAR(150) NOT NULL CONSTRAINT DF_Announcements_TargetProgram DEFAULT N'All Instructors'
              );
GO

IF COL_LENGTH(N'dbo.Announcements', N'TargetProgram') IS NULL
              ALTER TABLE dbo.Announcements ADD TargetProgram NVARCHAR(150) NOT NULL
                CONSTRAINT DF_Announcements_TargetProgram DEFAULT N'All Instructors' WITH VALUES;
GO
IF COL_LENGTH(N'dbo.Announcements', N'IsFrozen') IS NULL
    ALTER TABLE dbo.Announcements ADD IsFrozen BIT NOT NULL
        CONSTRAINT DF_Announcements_IsFrozen DEFAULT (0);
GO

IF OBJECT_ID(N'dbo.InstructorAnnouncementReads', N'U') IS NULL
              CREATE TABLE dbo.InstructorAnnouncementReads (
                AnnouncementId INT NOT NULL REFERENCES dbo.Announcements(AnnouncementId),
                Username NVARCHAR(30) NOT NULL,
                ReadAt DATETIME NOT NULL CONSTRAINT DF_InstructorAnnouncementReads_ReadAt DEFAULT GETDATE(),
                CONSTRAINT PK_InstructorAnnouncementReads PRIMARY KEY (AnnouncementId, Username)
              );
GO

IF OBJECT_ID(N'dbo.Events', N'U') IS NULL
              CREATE TABLE dbo.Events (
                EventId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Events PRIMARY KEY,
                Title NVARCHAR(200) NOT NULL,
                Description NVARCHAR(500) NULL,
                EventDate DATE NOT NULL,
                EventType NVARCHAR(50) NOT NULL CONSTRAINT DF_Events_EventType DEFAULT N'Event',
                CourseId INT NULL REFERENCES dbo.Courses(CourseRecordID),
                InstructorEmployeeID NVARCHAR(50) NULL REFERENCES dbo.Instructors(EmployeeID),
                IsAutoGenerated BIT NOT NULL CONSTRAINT DF_Events_IsAutoGenerated DEFAULT (0),
                IsFrozen BIT NOT NULL CONSTRAINT DF_Events_IsFrozen DEFAULT (0),
                CreatedAt DATETIME NOT NULL CONSTRAINT DF_Events_CreatedAt DEFAULT GETDATE()
              );
GO
IF COL_LENGTH(N'dbo.Events', N'IsFrozen') IS NULL
    ALTER TABLE dbo.Events ADD IsFrozen BIT NOT NULL CONSTRAINT DF_Events_IsFrozen DEFAULT (0);
GO

IF OBJECT_ID(N'dbo.Notes', N'U') IS NULL
              CREATE TABLE dbo.Notes (
                NoteId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Notes PRIMARY KEY,
                InstructorEmployeeID NVARCHAR(50) NOT NULL REFERENCES dbo.Instructors(EmployeeID),
                Title NVARCHAR(200) NOT NULL,
                Content NVARCHAR(MAX) NOT NULL,
                CreatedAt DATETIME NOT NULL CONSTRAINT DF_Notes_CreatedAt DEFAULT GETDATE(),
                UpdatedAt DATETIME NOT NULL CONSTRAINT DF_Notes_UpdatedAt DEFAULT GETDATE(),
                Color NVARCHAR(20) NOT NULL CONSTRAINT DF_Notes_Color DEFAULT N'Default',
                IsFrozen BIT NOT NULL CONSTRAINT DF_Notes_IsFrozen DEFAULT (0)
              );
GO
IF COL_LENGTH(N'dbo.Notes', N'IsFrozen') IS NULL
    ALTER TABLE dbo.Notes ADD IsFrozen BIT NOT NULL CONSTRAINT DF_Notes_IsFrozen DEFAULT (0);
GO

IF OBJECT_ID(N'dbo.AssistMessages', N'U') IS NULL
              CREATE TABLE dbo.AssistMessages (
                MessageId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_AssistMessages PRIMARY KEY,
                InstructorEmployeeID NVARCHAR(50) NOT NULL REFERENCES dbo.Instructors(EmployeeID),
                InstructorName NVARCHAR(100) NOT NULL,
                Subject NVARCHAR(200) NOT NULL,
                Message NVARCHAR(MAX) NOT NULL,
                SentAt DATETIME NOT NULL CONSTRAINT DF_AssistMessages_SentAt DEFAULT GETDATE(),
                IsRead BIT NOT NULL CONSTRAINT DF_AssistMessages_IsRead DEFAULT (0),
                IsResolved BIT NOT NULL CONSTRAINT DF_AssistMessages_IsResolved DEFAULT (0),
                AdminReply NVARCHAR(MAX) NULL,
                RepliedAt DATETIME NULL
              );
GO

IF COL_LENGTH(N'dbo.Instructors', N'Photo') IS NULL
              ALTER TABLE dbo.Instructors ADD Photo VARBINARY(MAX) NULL;
GO

SELECT N'SMARTdb is ready.' AS [Database Status];
GO
