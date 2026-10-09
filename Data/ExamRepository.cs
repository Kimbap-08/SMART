using System.Data;
using System.Data.SqlClient;

namespace SMART;

internal static class ExamRepository
{
    internal sealed record ExamTemplate(string Title, string ExamType, decimal WeightPercent);

    internal static string NormalizePeriod(string? value) => value?.Trim().ToUpperInvariant() switch
    {
        "SEM" or "SEMESTER" => "Semester",
        "TERM" => "Term",
        "SUMMER" => "Summer",
        _ => ""
    };

    internal static void Initialize(SqlConnection connection)
    {
        Execute(connection, @"IF OBJECT_ID(N'dbo.Exams', N'U') IS NULL
            CREATE TABLE dbo.Exams (
                ExamId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Exams PRIMARY KEY,
                CourseId INT NOT NULL REFERENCES dbo.Courses(CourseRecordID),
                Title NVARCHAR(100) NOT NULL,
                TotalScore FLOAT NOT NULL CONSTRAINT DF_Exams_TotalScore DEFAULT (0),
                TotalItems INT NOT NULL CONSTRAINT DF_Exams_TotalItems DEFAULT (0),
                WeightPercent DECIMAL(5,2) NOT NULL CONSTRAINT DF_Exams_WeightPercent DEFAULT (0),
                ExamType NVARCHAR(30) NOT NULL CONSTRAINT DF_Exams_ExamType DEFAULT N'Exam',
                GradingPeriod NVARCHAR(30) NOT NULL CONSTRAINT DF_Exams_GradingPeriod DEFAULT N'Term',
                Date DATE NULL,
                Status NVARCHAR(20) NOT NULL CONSTRAINT DF_Exams_Status DEFAULT N'Not entered'
            );");

        Execute(connection, @"IF COL_LENGTH(N'dbo.Exams', N'TotalItems') IS NULL
            ALTER TABLE dbo.Exams ADD TotalItems INT NULL;");
        Execute(connection, @"IF COL_LENGTH(N'dbo.Exams', N'WeightPercent') IS NULL
            ALTER TABLE dbo.Exams ADD WeightPercent DECIMAL(5,2) NULL;");
        Execute(connection, @"IF COL_LENGTH(N'dbo.Exams', N'ExamType') IS NULL
            ALTER TABLE dbo.Exams ADD ExamType NVARCHAR(30) NULL;");
        Execute(connection, @"IF COL_LENGTH(N'dbo.Exams', N'GradingPeriod') IS NULL
            ALTER TABLE dbo.Exams ADD GradingPeriod NVARCHAR(30) NULL;");
        Execute(connection, @"IF COL_LENGTH(N'dbo.Exams', N'Status') IS NULL
            ALTER TABLE dbo.Exams ADD Status NVARCHAR(20) NOT NULL
                CONSTRAINT DF_Exams_Status DEFAULT N'Not entered';");
        Execute(connection, @"UPDATE e SET
                TotalItems = COALESCE(e.TotalItems, TRY_CONVERT(INT, e.TotalScore), 0),
                WeightPercent = COALESCE(e.WeightPercent, 0),
                GradingPeriod = COALESCE(NULLIF(e.GradingPeriod, N''),
                    CASE WHEN UPPER(c.Term) IN (N'SEM', N'SEMESTER') THEN N'Semester'
                         WHEN UPPER(c.Term) = N'SUMMER' THEN N'Summer' ELSE N'Term' END),
                ExamType = COALESCE(NULLIF(e.ExamType, N''),
                    CASE WHEN e.Title IN (N'Final Exam', N'Final') THEN N'Final'
                         WHEN e.Title IN (N'Prelim', N'Midterm') THEN e.Title ELSE N'Exam' END)
            FROM dbo.Exams e LEFT JOIN dbo.Courses c ON c.CourseRecordID = e.CourseId;");
        Execute(connection, @"IF NOT EXISTS (SELECT 1 FROM sys.indexes
                WHERE object_id = OBJECT_ID(N'dbo.Exams') AND name = N'UX_Exams_Course_Period_Title')
            AND NOT EXISTS (SELECT CourseId, GradingPeriod, Title FROM dbo.Exams
                GROUP BY CourseId, GradingPeriod, Title HAVING COUNT(*) > 1)
            CREATE UNIQUE INDEX UX_Exams_Course_Period_Title
                ON dbo.Exams(CourseId, GradingPeriod, Title);");
    }

    internal static void EnsureForAllCourses(SqlConnection connection)
    {
        var courses = new List<(int Id, string Period)>();
        using (var command = new SqlCommand("SELECT CourseRecordID, Term FROM dbo.Courses", connection))
        using (var reader = command.ExecuteReader())
            while (reader.Read()) courses.Add((reader.GetInt32(0), reader.GetString(1)));

        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        try
        {
            foreach (var course in courses)
                EnsureForCourse(connection, transaction, course.Id, course.Period);
            transaction.Commit();
        }
        catch { transaction.Rollback(); throw; }
    }

    internal static void EnsureForCourse(SqlConnection connection, SqlTransaction? transaction, int courseId, string? periodValue)
    {
        string period = NormalizePeriod(periodValue);
        if (period.Length == 0) return;
        foreach (ExamTemplate exam in TemplatesFor(period))
        {
            using var command = new SqlCommand(@"IF EXISTS (SELECT 1 FROM dbo.Exams WITH (UPDLOCK, HOLDLOCK)
                    WHERE CourseId = @CourseId AND GradingPeriod = @Period AND Title = @Title)
                UPDATE dbo.Exams SET ExamType = @ExamType,
                    WeightPercent = CASE WHEN @Period = N'Summer' THEN WeightPercent ELSE @Weight END
                WHERE CourseId = @CourseId AND GradingPeriod = @Period AND Title = @Title;
            ELSE
                INSERT INTO dbo.Exams (CourseId, Title, TotalScore, TotalItems, WeightPercent, ExamType, GradingPeriod, Date, Status)
                VALUES (@CourseId, @Title, 0, 0, @Weight, @ExamType, @Period, NULL, N'Not entered');", connection, transaction);
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@Period", SqlDbType.NVarChar, 30).Value = period;
            command.Parameters.Add("@Title", SqlDbType.NVarChar, 100).Value = exam.Title;
            command.Parameters.Add("@ExamType", SqlDbType.NVarChar, 30).Value = exam.ExamType;
            command.Parameters.Add("@Weight", SqlDbType.Decimal).Value = exam.WeightPercent;
            command.Parameters["@Weight"].Precision = 5;
            command.Parameters["@Weight"].Scale = 2;
            command.ExecuteNonQuery();
        }
    }

    internal static IReadOnlyList<ExamTemplate> TemplatesFor(string periodValue)
    {
        return NormalizePeriod(periodValue) switch
        {
            "Semester" => Enumerable.Range(1, 7)
                .Select(i => new ExamTemplate($"Exam {i}", "Exam", 5m))
                .Append(new ExamTemplate("Final Exam", "Final", 35m)).ToArray(),
            "Term" => Enumerable.Range(1, 3)
                .Select(i => new ExamTemplate($"Exam {i}", "Exam", 10m))
                .Append(new ExamTemplate("Final Exam", "Final", 40m)).ToArray(),
            "Summer" => new[]
            {
                new ExamTemplate("Prelim", "Prelim", 0m),
                new ExamTemplate("Midterm", "Midterm", 0m),
                new ExamTemplate("Final", "Final", 0m)
            },
            _ => Array.Empty<ExamTemplate>()
        };
    }

    private static void Execute(SqlConnection connection, string sql)
    {
        using var command = new SqlCommand(sql, connection);
        command.ExecuteNonQuery();
    }
}
