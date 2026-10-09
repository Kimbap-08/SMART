using System.Data;
using System.Data.SqlClient;

namespace SMART;

public partial class InstructorUI : Form
{
    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color SidebarColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color HoverColor = Color.FromArgb(30, 42, 69);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private string instructorEmployeeId = "";
    private string instructorName = "Instructor";
    private bool arrangingProfile;
    private Bitmap? contentBackground;

    private void UpdateContentBackground()
    {
        if (BackgroundImage == null || content.Width <= 0 || content.Height <= 0) return;
        var bitmap = new Bitmap(content.Width, content.Height);
        Point origin = PointToClient(content.PointToScreen(Point.Empty));
        using (var graphics = Graphics.FromImage(bitmap))
            graphics.DrawImage(BackgroundImage, new Rectangle(-origin.X, -origin.Y, ClientSize.Width, ClientSize.Height));
        var previous = contentBackground;
        contentBackground = bitmap;
        content.BackgroundImage = bitmap;
        content.BackgroundImageLayout = ImageLayout.None;
        foreach (Control child in content.Controls)
        {
            if (child is not Form && child is not UserControl) continue;
            child.BackgroundImage = bitmap;
            child.BackgroundImageLayout = ImageLayout.None;
            InstructorTheme.Apply(child);
        }
        previous?.Dispose();
        content.Invalidate(true);
    }

    public InstructorUI()
    {
        InitializeComponent();
        content.ControlAdded += (_, _) => UpdateContentBackground();
        content.SizeChanged += (_, _) => UpdateContentBackground();
        Disposed += (_, _) => contentBackground?.Dispose();
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;
        PhotoHelper.MakeCircular(pbProfile);
        PhotoHelper.DrawDefaultProfile(pbProfile);
        LayoutProfileName();
        InstructorTheme.LoadPreference();
        InstructorTheme.Apply(this);
        Load += (_, _) => LoadInstructorDashboard();
        flpDashboardInstructor.LocationChanged += (_, _) => PositionScheduleNavigation();
        flpDashboardInstructor.LocationChanged += (_, _) => PositionAnnouncementsNavigation();
        flpDashboardInstructor.LocationChanged += (_, _) => PositionCalendarNavigation();
        flpDashboardInstructor.LocationChanged += (_, _) => PositionNotesNavigation();
        flpDashboardInstructor.LocationChanged += (_, _) => PositionAssistNavigation();
        cPanelSideBarInstructor.SizeChanged += (_, _) => PositionScheduleNavigation();
        cPanelSideBarInstructor.SizeChanged += (_, _) => PositionAnnouncementsNavigation();
        cPanelSideBarInstructor.SizeChanged += (_, _) => PositionCalendarNavigation();
        cPanelSideBarInstructor.SizeChanged += (_, _) => PositionNotesNavigation();
        cPanelSideBarInstructor.SizeChanged += (_, _) => PositionAssistNavigation();
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        cPanelSideBarInstructor.PerformLayout();
        PositionScheduleNavigation();
        PositionAnnouncementsNavigation();
        PositionCalendarNavigation();
        PositionNotesNavigation();
        PositionAssistNavigation();
        flpAnnouncementsInstructor.BringToFront();
        flpScheduleInstructor.BringToFront();
        flpCalendarInstructor.BringToFront();
        flpNotesInstructor.BringToFront();
        flpAssistInstructor.BringToFront();
    }

    private void Dashboard_Click(object? sender, EventArgs e)
    {
        SetNavigationRow(flpDashboardInstructor, true);
        SetNavigationRow(flpAnnouncementsInstructor, false);
        SetNavigationRow(flpCalendarInstructor, false);
        SetNavigationRow(flpNotesInstructor, false);
        SetNavigationRow(flpAssistInstructor, false);
        SetNavigationRow(flpScheduleInstructor, false);
        LoadInstructorDashboard();
    }

    private void Announcements_Click(object? sender, EventArgs e)
    {
        SetNavigationRow(flpDashboardInstructor, false);
        SetNavigationRow(flpAnnouncementsInstructor, true);
        SetNavigationRow(flpCalendarInstructor, false);
        SetNavigationRow(flpNotesInstructor, false);
        SetNavigationRow(flpAssistInstructor, false);
        SetNavigationRow(flpScheduleInstructor, false);
        ClearContentControls();
        var page = new InstructorAnnouncements(
            Session.CurrentUser?.Username ?? "", RefreshAnnouncementIndicator)
        {
            TopLevel = false,
            FormBorderStyle = FormBorderStyle.None,
            ShowInTaskbar = false,
            WindowState = FormWindowState.Normal,
            Dock = DockStyle.Fill
        };
        content.Controls.Add(page);
        page.Show();
    }

    private void Calendar_Click(object? sender, EventArgs e)
    {
        SetNavigationRow(flpDashboardInstructor, false);
        SetNavigationRow(flpAnnouncementsInstructor, false);
        SetNavigationRow(flpCalendarInstructor, true);
        SetNavigationRow(flpNotesInstructor, false);
        SetNavigationRow(flpAssistInstructor, false);
        SetNavigationRow(flpScheduleInstructor, false);
        ClearContentControls();
        var calendar = new InstructorCalendar(instructorEmployeeId, instructorName, GetInstructorCourses())
        {
            Dock = DockStyle.Fill
        };
        content.Controls.Add(calendar);
    }

    private void Schedule_Click(object? sender, EventArgs e)
    {
        SetInstructorNavigation(flpScheduleInstructor);
        ClearContentControls();
        content.Controls.Add(new InstructorSchedule(instructorEmployeeId) { Dock = DockStyle.Fill });
    }

    private void Notes_Click(object? sender, EventArgs e)
    {
        SetInstructorNavigation(flpNotesInstructor);
        ClearContentControls();
        content.Controls.Add(new InstructorNotes(instructorEmployeeId) { Dock = DockStyle.Fill });
    }

    private void Assist_Click(object? sender, EventArgs e)
    {
        SetInstructorNavigation(flpAssistInstructor);
        ClearContentControls();
        content.Controls.Add(new InstructorAssist(instructorEmployeeId, instructorName) { Dock = DockStyle.Fill });
    }

    private void SetInstructorNavigation(Control active)
    {
        SetNavigationRow(flpDashboardInstructor, active == flpDashboardInstructor);
        SetNavigationRow(flpAnnouncementsInstructor, active == flpAnnouncementsInstructor);
        SetNavigationRow(flpCalendarInstructor, active == flpCalendarInstructor);
        SetNavigationRow(flpNotesInstructor, active == flpNotesInstructor);
        SetNavigationRow(flpAssistInstructor, active == flpAssistInstructor);
        SetNavigationRow(flpScheduleInstructor, active == flpScheduleInstructor);
    }
    private void Settings_Click(object? sender, EventArgs e)
    {
        SetNavigationRow(flpDashboardInstructor, false);
        SetNavigationRow(flpAnnouncementsInstructor, false);
        SetNavigationRow(flpCalendarInstructor, false);
        SetNavigationRow(flpNotesInstructor, false);
        SetNavigationRow(flpAssistInstructor, false);
        SetNavigationRow(flpScheduleInstructor, false);
        SetNavigationRow(flpSettingsInstructor, true);
        using var settings = new InstructorSettings();
        try { settings.ShowDialog(this); }
        finally
        {
            InstructorTheme.Apply(this);
            SetNavigationRow(flpDashboardInstructor, true);
            SetNavigationRow(flpAnnouncementsInstructor, false);
            SetNavigationRow(flpCalendarInstructor, false);
            SetNavigationRow(flpNotesInstructor, false);
            SetNavigationRow(flpAssistInstructor, false);
            SetNavigationRow(flpScheduleInstructor, false);
            SetNavigationRow(flpSettingsInstructor, false);
        }
        LoadInstructorDashboard();
        InstructorTheme.Apply(this);
        SetNavigationRow(flpDashboardInstructor, true);
        SetNavigationRow(flpAnnouncementsInstructor, false);
        SetNavigationRow(flpCalendarInstructor, false);
        SetNavigationRow(flpNotesInstructor, false);
        SetNavigationRow(flpAssistInstructor, false);
        SetNavigationRow(flpScheduleInstructor, false);
        SetNavigationRow(flpSettingsInstructor, false);
    }
    private void SetNavigationRow(Control row, bool selected)
    {
        row.BackColor = selected ? AccentColor : Color.Transparent;
        foreach (Control child in row.Controls)
        {
            child.BackColor = Color.Transparent;
            child.ForeColor = selected ? Color.White : InstructorTheme.Text;
            if (child is PictureBox icon) InstructorTheme.RefreshNavigationIcon(icon);
            if (child == lblAnnouncementDot) child.ForeColor = AccentColor;
        }
        row.Invalidate(true);
    }
    private void SignOut_Click(object? sender, EventArgs e) => SignOut();
    private void Profile_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using var pen = new Pen(AccentColor, 2);
        e.Graphics.DrawEllipse(pen, 1, 1, pbProfile.Width - 3, pbProfile.Height - 3);
    }

    private void SignOut()
    {
        Session.CurrentUser = null;
        Close();
    }

    private void LoadInstructorDashboard()
    {
        try
        {
            CourseRepository.Initialize();
            EnsureMissingTables();
            RefreshAnnouncementIndicator();
            using var connection = OpenConnection();
            using (var command = new SqlCommand(@"SELECT TOP (1) EmployeeID, FullName, Photo
                    FROM dbo.Instructors WHERE Username = @Username AND IsActive = 1", connection))
            {
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = Session.CurrentUser?.Username ?? "";
                using var reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    ShowSetupMessage("Your instructor profile is not available.", "Ask an administrator to enable or recreate your instructor account.");
                    return;
                }
                instructorEmployeeId = reader.GetString(0);
                instructorName = reader.GetString(1);
                byte[]? photoBytes = reader.IsDBNull(2) ? null : (byte[])reader[2];
                PhotoHelper.LoadPhoto(pbProfile!, photoBytes, instructorName);
            }
            UpdateProfileName();
            ShowCourseCards(connection);
            InstructorTheme.Apply(this);
        }
        catch (SqlException ex)
        {
            ShowSetupMessage("The instructor dashboard could not load its data.", ex.Message);
        }
    }

    private List<(int Id, string Title)> GetInstructorCourses()
    {
        var courses = new List<(int Id, string Title)>();
        using var connection = OpenConnection();
        using var command = new SqlCommand(@"SELECT CourseRecordID,
                CONCAT(CourseTitle, N' — ', CourseCode) AS Title
            FROM dbo.Courses WHERE InstructorEmployeeID = @EmployeeID
            ORDER BY CourseTitle", connection);
        command.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 50).Value = instructorEmployeeId;
        using var reader = command.ExecuteReader();
        while (reader.Read()) courses.Add((reader.GetInt32(0), reader.GetString(1)));
        return courses;
    }

    private void PositionScheduleNavigation()
    {
        if (flpScheduleInstructor == null || flpDashboardInstructor == null) return;
        flpScheduleInstructor.Width = flpDashboardInstructor.Width;
        flpScheduleInstructor.Location = new Point(flpDashboardInstructor.Left, flpDashboardInstructor.Bottom + 5);
        flpScheduleInstructor.Controls[1].Width = Math.Max(80, flpScheduleInstructor.ClientSize.Width - 50);
    }

    private void PositionCalendarNavigation()
    {
        if (flpCalendarInstructor == null || flpAnnouncementsInstructor == null) return;
        flpCalendarInstructor.Width = flpDashboardInstructor.Width;
        flpCalendarInstructor.Location = new Point(flpAnnouncementsInstructor.Left,
            flpAnnouncementsInstructor.Bottom + 5);
        lblCalendarText.Width = Math.Max(80,
            flpCalendarInstructor.ClientSize.Width - lblCalendarText.Left - 12);
    }

    private void PositionNotesNavigation()
    {
        if (flpNotesInstructor == null || flpCalendarInstructor == null) return;
        flpNotesInstructor.Width = flpDashboardInstructor.Width;
        flpNotesInstructor.Location = new Point(flpCalendarInstructor.Left, flpCalendarInstructor.Bottom + 5);
        flpNotesInstructor.Controls[1].Width = Math.Max(80, flpNotesInstructor.ClientSize.Width - 50);
    }

    private void PositionAssistNavigation()
    {
        if (flpAssistInstructor == null || flpNotesInstructor == null) return;
        flpAssistInstructor.Width = flpDashboardInstructor.Width;
        flpAssistInstructor.Location = new Point(flpNotesInstructor.Left, flpNotesInstructor.Bottom + 5);
        flpAssistInstructor.Controls[1].Width = Math.Max(80, flpAssistInstructor.ClientSize.Width - 50);
    }

    private void PositionAnnouncementsNavigation()
    {
        if (flpAnnouncementsInstructor == null || flpDashboardInstructor == null) return;
        flpAnnouncementsInstructor.Width = flpDashboardInstructor.Width;
        flpAnnouncementsInstructor.Location = new Point(
            flpScheduleInstructor.Left, flpScheduleInstructor.Bottom + 5);
        lblAnnouncementsText.Width = Math.Max(80,
            flpAnnouncementsInstructor.ClientSize.Width - lblAnnouncementsText.Left - 28);
        lblAnnouncementDot.Left = flpAnnouncementsInstructor.ClientSize.Width - lblAnnouncementDot.Width - 8;
    }

    private void WireNavigationClicks(Control control, EventHandler? handler = null)
    {
        control.Click += handler ?? Announcements_Click;
        foreach (Control child in control.Controls) WireNavigationClicks(child, handler);
    }

    private void RefreshAnnouncementIndicator()
    {
        try
        {
            string username = Session.CurrentUser?.Username ?? "";
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT CASE WHEN EXISTS (
                SELECT 1 FROM dbo.Announcements a
                INNER JOIN dbo.Instructors i ON i.Username = @Username
                WHERE a.IsActive = 1
                  AND (a.TargetProgram = N'All Instructors' OR a.TargetProgram = i.Program)
                  AND NOT EXISTS (
                    SELECT 1 FROM dbo.InstructorAnnouncementReads r
                    WHERE r.AnnouncementId = a.AnnouncementId AND r.Username = @Username))
                THEN 1 ELSE 0 END", connection);
            command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = username;
            lblAnnouncementDot.Visible = Convert.ToInt32(command.ExecuteScalar()) == 1;
        }
        catch (SqlException) { if (lblAnnouncementDot != null) lblAnnouncementDot.Visible = false; }
    }

    private static void EnsureMissingTables()
    {
        string[] statements =
        {
            @"IF OBJECT_ID(N'dbo.Announcements', N'U') IS NULL
              CREATE TABLE dbo.Announcements (
                AnnouncementId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Announcements PRIMARY KEY,
                Title NVARCHAR(200) NOT NULL,
                Message NVARCHAR(MAX) NOT NULL,
                PostedBy NVARCHAR(100) NOT NULL CONSTRAINT DF_Announcements_PostedBy DEFAULT N'System Administrator',
                PostedAt DATETIME NOT NULL CONSTRAINT DF_Announcements_PostedAt DEFAULT GETDATE(),
                IsActive BIT NOT NULL CONSTRAINT DF_Announcements_IsActive DEFAULT (1),
                Priority NVARCHAR(20) NOT NULL CONSTRAINT DF_Announcements_Priority DEFAULT N'Normal',
                TargetProgram NVARCHAR(150) NOT NULL CONSTRAINT DF_Announcements_TargetProgram DEFAULT N'All Instructors'
              );",
            @"IF COL_LENGTH(N'dbo.Announcements', N'TargetProgram') IS NULL
              ALTER TABLE dbo.Announcements ADD TargetProgram NVARCHAR(150) NOT NULL
                CONSTRAINT DF_Announcements_TargetProgram DEFAULT N'All Instructors' WITH VALUES;",
            @"IF OBJECT_ID(N'dbo.InstructorAnnouncementReads', N'U') IS NULL
              CREATE TABLE dbo.InstructorAnnouncementReads (
                AnnouncementId INT NOT NULL REFERENCES dbo.Announcements(AnnouncementId),
                Username NVARCHAR(30) NOT NULL,
                ReadAt DATETIME NOT NULL CONSTRAINT DF_InstructorAnnouncementReads_ReadAt DEFAULT GETDATE(),
                CONSTRAINT PK_InstructorAnnouncementReads PRIMARY KEY (AnnouncementId, Username)
              );",
            @"IF OBJECT_ID(N'dbo.Events', N'U') IS NULL
              CREATE TABLE dbo.Events (
                EventId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Events PRIMARY KEY,
                Title NVARCHAR(200) NOT NULL,
                Description NVARCHAR(500) NULL,
                EventDate DATE NOT NULL,
                EventType NVARCHAR(50) NOT NULL CONSTRAINT DF_Events_EventType DEFAULT N'Event',
                CourseId INT NULL REFERENCES dbo.Courses(CourseRecordID),
                InstructorEmployeeID NVARCHAR(50) NULL REFERENCES dbo.Instructors(EmployeeID),
                IsAutoGenerated BIT NOT NULL CONSTRAINT DF_Events_IsAutoGenerated DEFAULT (0),
                CreatedAt DATETIME NOT NULL CONSTRAINT DF_Events_CreatedAt DEFAULT GETDATE()
              );",
            @"IF OBJECT_ID(N'dbo.Notes', N'U') IS NULL
              CREATE TABLE dbo.Notes (
                NoteId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Notes PRIMARY KEY,
                InstructorEmployeeID NVARCHAR(50) NOT NULL REFERENCES dbo.Instructors(EmployeeID),
                Title NVARCHAR(200) NOT NULL,
                Content NVARCHAR(MAX) NOT NULL,
                CreatedAt DATETIME NOT NULL CONSTRAINT DF_Notes_CreatedAt DEFAULT GETDATE(),
                UpdatedAt DATETIME NOT NULL CONSTRAINT DF_Notes_UpdatedAt DEFAULT GETDATE(),
                Color NVARCHAR(20) NOT NULL CONSTRAINT DF_Notes_Color DEFAULT N'Default'
              );",
            @"IF OBJECT_ID(N'dbo.AssistMessages', N'U') IS NULL
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
              );",
            @"INSERT INTO dbo.Events (Title, EventDate, EventType, IsAutoGenerated)
              SELECT h.Title, h.EventDate, N'Holiday', 1
              FROM (VALUES
                (N'New Year''s Day', CONVERT(date, '2026-01-01')),
                (N'Chinese New Year', CONVERT(date, '2026-02-17')),
                (N'EDSA Revolution', CONVERT(date, '2026-02-25')),
                (N'Maundy Thursday', CONVERT(date, '2026-04-02')),
                (N'Good Friday', CONVERT(date, '2026-04-03')),
                (N'Black Saturday', CONVERT(date, '2026-04-04')),
                (N'Araw ng Kagitingan', CONVERT(date, '2026-04-09')),
                (N'Labor Day', CONVERT(date, '2026-05-01')),
                (N'Independence Day', CONVERT(date, '2026-06-12')),
                (N'Ninoy Aquino Day', CONVERT(date, '2026-08-21')),
                (N'National Heroes Day', CONVERT(date, '2026-08-31')),
                (N'All Saints Day', CONVERT(date, '2026-11-01')),
                (N'All Souls Day', CONVERT(date, '2026-11-02')),
                (N'Bonifacio Day', CONVERT(date, '2026-11-30')),
                (N'Feast of Immaculate Conception', CONVERT(date, '2026-12-08')),
                (N'Christmas Day', CONVERT(date, '2026-12-25')),
                (N'Rizal Day', CONVERT(date, '2026-12-30')),
                (N'Last Day of Year', CONVERT(date, '2026-12-31')),
                (N'Eid al-Fitr', CONVERT(date, '2026-03-20')),
                (N'Eid al-Adha', CONVERT(date, '2026-05-27'))
              ) AS h(Title, EventDate)
              WHERE NOT EXISTS (SELECT 1 FROM dbo.Events e
                  WHERE e.EventType = N'Holiday' AND e.EventDate = h.EventDate);",
            @"IF COL_LENGTH(N'dbo.Instructors', N'Photo') IS NULL
              ALTER TABLE dbo.Instructors ADD Photo VARBINARY(MAX) NULL;",
            @"IF OBJECT_ID(N'dbo.Attendance', N'U') IS NULL
              CREATE TABLE dbo.Attendance (
                AttendanceId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Attendance PRIMARY KEY,
                StudentID VARCHAR(10) NOT NULL REFERENCES dbo.Students(StudentID),
                CourseId INT NOT NULL REFERENCES dbo.Courses(CourseRecordID),
                Date DATE NOT NULL,
                Status NVARCHAR(20) NOT NULL CONSTRAINT DF_Attendance_Status DEFAULT N'PRESENT'
              );",
            @"IF OBJECT_ID(N'dbo.Quizzes', N'U') IS NULL
              CREATE TABLE dbo.Quizzes (
                QuizId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Quizzes PRIMARY KEY,
                CourseId INT NOT NULL REFERENCES dbo.Courses(CourseRecordID),
                Title NVARCHAR(100) NOT NULL,
                TotalScore FLOAT NOT NULL,
                Date DATE NULL
              );",
            @"IF OBJECT_ID(N'dbo.QuizScores', N'U') IS NULL
              CREATE TABLE dbo.QuizScores (
                ScoreId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_QuizScores PRIMARY KEY,
                QuizId INT NOT NULL REFERENCES dbo.Quizzes(QuizId),
                StudentID VARCHAR(10) NOT NULL REFERENCES dbo.Students(StudentID),
                Score FLOAT NOT NULL CONSTRAINT DF_QuizScores_Score DEFAULT (0),
                CONSTRAINT UQ_QuizScores_Quiz_Student UNIQUE (QuizId, StudentID)
              );",
            @"IF OBJECT_ID(N'dbo.Exams', N'U') IS NULL
              CREATE TABLE dbo.Exams (
                ExamId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Exams PRIMARY KEY,
                CourseId INT NOT NULL REFERENCES dbo.Courses(CourseRecordID),
                Title NVARCHAR(100) NOT NULL,
                TotalScore FLOAT NOT NULL,
                TotalItems INT NOT NULL CONSTRAINT DF_Exams_TotalItems DEFAULT (0),
                WeightPercent DECIMAL(5,2) NOT NULL CONSTRAINT DF_Exams_WeightPercent DEFAULT (0),
                ExamType NVARCHAR(30) NOT NULL CONSTRAINT DF_Exams_ExamType DEFAULT N'Exam',
                GradingPeriod NVARCHAR(30) NOT NULL CONSTRAINT DF_Exams_GradingPeriod DEFAULT N'Term',
                Date DATE NULL,
                Status NVARCHAR(20) NOT NULL CONSTRAINT DF_Exams_Status DEFAULT N'Not entered'
              );",
            @"IF OBJECT_ID(N'dbo.ExamScores', N'U') IS NULL
              CREATE TABLE dbo.ExamScores (
                ScoreId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_ExamScores PRIMARY KEY,
                ExamId INT NOT NULL REFERENCES dbo.Exams(ExamId),
                StudentID VARCHAR(10) NOT NULL REFERENCES dbo.Students(StudentID),
                Score FLOAT NOT NULL CONSTRAINT DF_ExamScores_Score DEFAULT (0),
                CONSTRAINT UQ_ExamScores_Exam_Student UNIQUE (ExamId, StudentID)
              );",
            @"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.Attendance') AND name = N'UX_Attendance_Student_Course_Date')
              AND NOT EXISTS (SELECT StudentID, CourseId, Date FROM dbo.Attendance GROUP BY StudentID, CourseId, Date HAVING COUNT(*) > 1)
              CREATE UNIQUE INDEX UX_Attendance_Student_Course_Date ON dbo.Attendance(StudentID, CourseId, Date);"
        };
        using var connection = OpenConnection();
        foreach (string sql in statements)
        {
            using var command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }

    private static SqlConnection OpenConnection()
    {
        var connection = new SqlConnection(DatabaseConnection.ConnectionString);
        try { DatabaseConnection.Open(connection); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private void ProfileLayout_Changed(object? sender, EventArgs e) => LayoutProfileName();

    private void LayoutProfileName()
    {
        if (arrangingProfile || profile.ClientSize.Width <= 0) return;
        arrangingProfile = true;
        try
        {
            int pictureLeft = profile.Padding.Left;
            int textLeft = pictureLeft + pbProfile.Width + 8;
            int textWidth = Math.Max(1, profile.ClientSize.Width - textLeft - profile.Padding.Right);
            var textSize = TextRenderer.MeasureText(profileNameLabel.Text, profileNameLabel.Font,
                new Size(textWidth, int.MaxValue),
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl | TextFormatFlags.NoPrefix);
            int textHeight = Math.Max(profileNameLabel.Font.Height, textSize.Height);
            int rowHeight = Math.Max(50, Math.Max(pbProfile.Height, textHeight) + 10);
            profile.Height = rowHeight;
            pbProfile.Location = new Point(pictureLeft, (rowHeight - pbProfile.Height) / 2);
            profileNameLabel.SetBounds(textLeft, (rowHeight - textHeight) / 2, textWidth, textHeight);
        }
        finally { arrangingProfile = false; }
    }

    private void UpdateProfileName()
    {
        if (profileNameLabel != null) profileNameLabel.Text = instructorName;
        pbProfile?.Invalidate();
    }

    private void ShowCourseCards(SqlConnection connection)
    {
        ClearContentControls();
        foreach (Control oldCard in courseCards.Controls.Cast<Control>().ToArray()) oldCard.Dispose();
        courseCards.Controls.Clear();
        lblWelcomeInstructor.Text = $"Welcome, {instructorName}!";
        content.Controls.Add(courseCards);
        content.Controls.Add(lblCurr);
        content.Controls.Add(lblWelcomeInstructor);

        const string sql = @"SELECT c.CourseRecordID, c.CourseTitle, c.CourseName, c.CourseCode,
                    c.Program, c.RoomNumber, c.Day, c.Time, c.Term,
                    (SELECT COUNT(*) FROM dbo.Enrollments e WHERE e.CourseId = c.CourseRecordID) AS StudentCount
                FROM dbo.Courses c
                WHERE c.InstructorEmployeeID = @EmployeeID
                ORDER BY c.CourseTitle";
        using var command = new SqlCommand(sql, connection);
        command.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 50).Value = instructorEmployeeId;
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            courseCards.Controls.Add(CreateCourseCard(
                reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7),
                reader.GetString(8), reader.GetInt32(9)));
        }
        if (courseCards.Controls.Count == 0)
        {
            courseCards.Controls.Add(new Label
            {
                Text = "No courses are assigned to you yet.", AutoSize = true, ForeColor = TextGray,
                Font = new Font("Segoe UI", 12F), Margin = new Padding(4, 20, 0, 0)
            });
        }
    }

    private CustomPanel CreateCourseCard(int id, string title, string name, string code,
        string program, string room, string day, string time, string term, int count)
    {
        var card = new CustomPanel
        {
            Size = new Size(220, 200), BackColor = SidebarColor, BorderColor = AccentColor,
            BorderWidth = 2, CornerRadius = 12, Margin = new Padding(0, 4, 18, 18),
            Cursor = Cursors.Hand, Padding = new Padding(14)
        };
        var details = new Label
        {
            Dock = DockStyle.Top, Height = 52, ForeColor = TextGray, Font = new Font("Segoe UI", 9F),
            AutoEllipsis = true, Text = $"{time} | {day}\n{room} · {term} · {program}"
        };
        var students = CardLabel($"👥 {count} Students", TextGray, 10F, false, 25);
        var open = CardLabel("Click to open →", AccentColor, 9F, false, 20);
        var courseCode = CardLabel("Code: " + code, TextGray, 9F, false, 22);
        var courseNameLabel = CardLabel(name, Color.White, 11F, false, 38);
        var courseTitleLabel = CardLabel(title, AccentColor, 17F, true, 30);
        card.Controls.Add(open);
        card.Controls.Add(students);
        card.Controls.Add(details);
        card.Controls.Add(courseCode);
        card.Controls.Add(courseNameLabel);
        card.Controls.Add(courseTitleLabel);
        card.MouseEnter += (_, _) => card.BackColor = InstructorTheme.Hover;
        card.MouseLeave += (_, _) => card.BackColor = InstructorTheme.Surface;
        void Open(object? _, EventArgs __)
        {
            using var form = new InstructorCourses(id, title, name, instructorName, instructorEmployeeId);
            form.ShowDialog(this);
        }
        WireCardClick(card, Open);
        return card;
    }

    private static Label CardLabel(string text, Color color, float size, bool bold, int height) => new()
    {
        Text = text, Dock = DockStyle.Top, Height = height, ForeColor = color,
        Font = new Font("Segoe UI", size, bold ? FontStyle.Bold : FontStyle.Regular),
        AutoEllipsis = true, TextAlign = ContentAlignment.MiddleLeft
    };

    private static void WireCardClick(Control control, EventHandler handler)
    {
        control.Click += handler;
        foreach (Control child in control.Controls) WireCardClick(child, handler);
    }

    private void ShowSetupMessage(string title, string details)
    {
        ClearContentControls();
        content.Controls.Add(new Label
        {
            Text = title + Environment.NewLine + details, Dock = DockStyle.Fill, ForeColor = TextGray,
            Font = new Font("Segoe UI", 12F), TextAlign = ContentAlignment.MiddleCenter
        });
        InstructorTheme.Apply(this);
    }

    private void ClearContentControls()
    {
        var announcementForms = content.Controls.OfType<InstructorAnnouncements>().ToArray();
        var calendars = content.Controls.OfType<InstructorCalendar>().ToArray();
        content.Controls.Clear();
        foreach (var page in announcementForms) page.Dispose();
        foreach (var calendar in calendars) calendar.Dispose();
    }


}
