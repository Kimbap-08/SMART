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
    private static readonly Color YellowColor = Color.FromArgb(255, 170, 0);
    private static readonly Color DarkGray = Color.FromArgb(85, 85, 119);
    private readonly CustomPanel announcementsSection = new()
    {
        Dock = DockStyle.Bottom, Height = 300, BackColor = BgColor,
        BorderWidth = 0, CornerRadius = 1, Padding = new Padding(0, 4, 0, 0)
    };
    private readonly RoundedFlowLayoutPanel announcementCards = new()
    {
        Dock = DockStyle.Fill, AutoScroll = true, WrapContents = false,
        FlowDirection = FlowDirection.TopDown, BackColor = BgColor,
        BorderSize = 0, BorderRadius = 0, Padding = new Padding(0, 4, 10, 4)
    };
    private readonly Label announcementsHeading = new()
    {
        Text = "📢 Announcements from Administration", Dock = DockStyle.Fill,
        ForeColor = Color.White, Font = new Font("Segoe UI", 13F, FontStyle.Bold),
        TextAlign = ContentAlignment.MiddleLeft
    };
    private readonly CustomButton refreshAnnouncements = new()
    {
        Text = "🔄 Refresh", Size = new Size(100, 30), BorderRadius = 5,
        BorderSize = 0, BackColor = Color.FromArgb(48, 63, 93),
        ForeColor = Color.White, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
    };
    private RoundedFlowLayoutPanel flpAnnouncementsInstructor = null!;
    private Label lblAnnouncementDot = null!;
    private string instructorEmployeeId = "";
    private string instructorName = "Instructor";
    private bool arrangingProfile;

    public InstructorUI()
    {
        InitializeComponent();
        BuildAnnouncementsNavigation();
        BuildAnnouncementsSection();
        PhotoHelper.MakeCircular(pbProfile);
        PhotoHelper.DrawDefaultProfile(pbProfile);
        LayoutProfileName();
        InstructorTheme.LoadPreference();
        InstructorTheme.Apply(this);
        Load += (_, _) => LoadInstructorDashboard();
    }

    private void Dashboard_Click(object? sender, EventArgs e)
    {
        SetNavigationRow(flpDashboardInstructor, true);
        SetNavigationRow(flpAnnouncementsInstructor, false);
        LoadInstructorDashboard();
    }

    private void Announcements_Click(object? sender, EventArgs e)
    {
        SetNavigationRow(flpDashboardInstructor, false);
        SetNavigationRow(flpAnnouncementsInstructor, true);
        content.Controls.Clear();
        content.Controls.Add(new InstructorAnnouncementsPage(
            Session.CurrentUser?.Username ?? "", RefreshAnnouncementIndicator) { Dock = DockStyle.Fill });
    }
    private void Settings_Click(object? sender, EventArgs e)
    {
        SetNavigationRow(flpDashboardInstructor, false);
        SetNavigationRow(flpAnnouncementsInstructor, false);
        SetNavigationRow(flpSettingsInstructor, true);
        using var settings = new InstructorSettings();
        try { settings.ShowDialog(this); }
        finally
        {
            InstructorTheme.Apply(this);
            SetNavigationRow(flpDashboardInstructor, true);
            SetNavigationRow(flpAnnouncementsInstructor, false);
            SetNavigationRow(flpSettingsInstructor, false);
        }
        LoadInstructorDashboard();
        InstructorTheme.Apply(this);
        SetNavigationRow(flpDashboardInstructor, true);
        SetNavigationRow(flpAnnouncementsInstructor, false);
        SetNavigationRow(flpSettingsInstructor, false);
    }
    private void SetNavigationRow(Control row, bool selected)
    {
        row.BackColor = selected ? AccentColor : InstructorTheme.Surface;
        foreach (Control child in row.Controls)
        {
            child.BackColor = row.BackColor;
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
            LoadAnnouncements();
            InstructorTheme.Apply(this);
        }
        catch (SqlException ex)
        {
            ShowSetupMessage("The instructor dashboard could not load its data.", ex.Message);
        }
    }

    private void BuildAnnouncementsNavigation()
    {
        flpAnnouncementsInstructor = new RoundedFlowLayoutPanel
        {
            Name = "flpAnnouncementsInstructor", Dock = DockStyle.Top,
            Size = new Size(177, 40), Margin = new Padding(0, 5, 0, 0),
            Padding = new Padding(4, 0, 0, 0), BackColor = InstructorTheme.Surface,
            BorderColor = Color.Transparent, BorderRadius = 5, BorderSize = 1,
            Cursor = Cursors.Hand, WrapContents = false
        };
        var label = new Label
        {
            Name = "lblAnnouncementsInstructor", Text = "📢  Announcements",
            Location = new Point(8, 6), Size = new Size(142, 28),
            ForeColor = InstructorTheme.Text, Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleLeft, BackColor = Color.Transparent,
            Cursor = Cursors.Hand
        };
        lblAnnouncementDot = new Label
        {
            Name = "lblAnnouncementDot", Text = "●", Location = new Point(151, 7),
            Size = new Size(14, 26), ForeColor = AccentColor,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter,
            BackColor = Color.Transparent, Visible = false, Cursor = Cursors.Hand
        };
        flpAnnouncementsInstructor.Controls.Add(label);
        flpAnnouncementsInstructor.Controls.Add(lblAnnouncementDot);
        WireNavigationClicks(flpAnnouncementsInstructor);
        cPanelSideBarInstructor.Controls.Add(flpAnnouncementsInstructor);
        cPanelSideBarInstructor.Controls.SetChildIndex(flpAnnouncementsInstructor,
            cPanelSideBarInstructor.Controls.GetChildIndex(flpDashboardInstructor) + 1);
    }

    private void WireNavigationClicks(Control control)
    {
        control.Click += Announcements_Click;
        foreach (Control child in control.Controls) WireNavigationClicks(child);
    }

    private void RefreshAnnouncementIndicator()
    {
        try
        {
            string username = Session.CurrentUser?.Username ?? "";
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT CASE WHEN EXISTS (
                SELECT 1 FROM dbo.Announcements a
                WHERE a.IsActive = 1 AND NOT EXISTS (
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
                Priority NVARCHAR(20) NOT NULL CONSTRAINT DF_Announcements_Priority DEFAULT N'Normal'
              );",
            @"IF OBJECT_ID(N'dbo.InstructorAnnouncementReads', N'U') IS NULL
              CREATE TABLE dbo.InstructorAnnouncementReads (
                AnnouncementId INT NOT NULL REFERENCES dbo.Announcements(AnnouncementId),
                Username NVARCHAR(30) NOT NULL,
                ReadAt DATETIME NOT NULL CONSTRAINT DF_InstructorAnnouncementReads_ReadAt DEFAULT GETDATE(),
                CONSTRAINT PK_InstructorAnnouncementReads PRIMARY KEY (AnnouncementId, Username)
              );",
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
        content.Controls.Clear();
        foreach (Control oldCard in courseCards.Controls.Cast<Control>().ToArray()) oldCard.Dispose();
        courseCards.Controls.Clear();
        lblWelcomeInstructor.Text = $"Welcome, {instructorName}!";
        content.Controls.Add(courseCards);
        content.Controls.Add(announcementsSection);
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

    private void BuildAnnouncementsSection()
    {
        var header = new CustomPanel
        {
            Dock = DockStyle.Top, Height = 42, BackColor = BgColor,
            BorderWidth = 0, CornerRadius = 1
        };
        refreshAnnouncements.Location = new Point(Math.Max(0, content.Width - 112), 6);
        refreshAnnouncements.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        refreshAnnouncements.Click += (_, _) => LoadAnnouncements();
        header.Controls.Add(announcementsHeading);
        header.Controls.Add(refreshAnnouncements);
        announcementsSection.Controls.Add(announcementCards);
        announcementsSection.Controls.Add(header);
        announcementCards.SizeChanged += (_, _) => ResizeAnnouncementCards();
        announcementsSection.SizeChanged += (_, _) =>
            refreshAnnouncements.Left = Math.Max(0, announcementsSection.ClientSize.Width - refreshAnnouncements.Width - 8);
    }

    private void LoadAnnouncements()
    {
        try
        {
            using var connection = OpenConnection();
            const string sql = @"SELECT TOP (5) a.AnnouncementId, a.Title, a.Message,
                    a.Priority, a.PostedAt,
                    CASE WHEN r.AnnouncementId IS NULL THEN 1 ELSE 0 END AS IsUnread
                FROM dbo.Announcements a
                LEFT JOIN dbo.InstructorAnnouncementReads r
                    ON r.AnnouncementId = a.AnnouncementId AND r.Username = @Username
                WHERE a.IsActive = 1
                ORDER BY CASE a.Priority WHEN N'Urgent' THEN 1 WHEN N'Important' THEN 2 ELSE 3 END,
                    a.PostedAt DESC";
            using var command = new SqlCommand(sql, connection);
            command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = Session.CurrentUser?.Username ?? "";
            using var reader = command.ExecuteReader();
            foreach (Control oldCard in announcementCards.Controls.Cast<Control>().ToArray()) oldCard.Dispose();
            announcementCards.Controls.Clear();
            if (!reader.HasRows)
            {
                announcementCards.Controls.Add(new Label
                {
                    Text = "No announcements at this time.", AutoSize = false,
                    Width = Math.Max(300, announcementCards.ClientSize.Width - 20), Height = 70,
                    ForeColor = TextGray, Font = new Font("Segoe UI", 10F),
                    TextAlign = ContentAlignment.MiddleCenter, Margin = Padding.Empty
                });
                return;
            }
            while (reader.Read())
            {
                announcementCards.Controls.Add(CreateAnnouncementCard(
                    reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetDateTime(4), reader.GetInt32(5) == 1));
            }
            ResizeAnnouncementCards();
        }
        catch (SqlException ex)
        {
            foreach (Control oldCard in announcementCards.Controls.Cast<Control>().ToArray()) oldCard.Dispose();
            announcementCards.Controls.Clear();
            announcementCards.Controls.Add(new Label
            {
                Text = "Announcements could not be loaded: " + ex.Message,
                AutoSize = false, Width = Math.Max(300, announcementCards.ClientSize.Width - 20),
                Height = 70, ForeColor = TextGray, Font = new Font("Segoe UI", 9F),
                TextAlign = ContentAlignment.MiddleLeft
            });
        }
    }

    private CustomPanel CreateAnnouncementCard(int id, string title, string message,
        string priority, DateTime postedAt, bool unread)
    {
        Color priorityColor = priority switch
        {
            "Urgent" => AccentColor,
            "Important" => YellowColor,
            _ => DarkGray
        };
        string badge = priority switch
        {
            "Urgent" => "🔴 URGENT",
            "Important" => "🟡 IMPORTANT",
            _ => "⚪ NORMAL"
        };
        int width = Math.Max(360, announcementCards.ClientSize.Width - 28);
        var card = new CustomPanel
        {
            Name = "announcement_" + id, Size = new Size(width, 92), Margin = new Padding(0, 0, 0, 8),
            Padding = new Padding(12), BackColor = unread ? Color.FromArgb(31, 45, 75) : SidebarColor,
            BorderColor = priority == "Normal" ? Color.FromArgb(52, 63, 88) : priorityColor,
            BorderWidth = priority == "Normal" ? 1 : 2, CornerRadius = 8,
            Cursor = Cursors.Hand
        };
        var priorityLabel = new Label
        {
            Text = unread ? badge + "  • NEW" : badge, Location = new Point(12, 7), Size = new Size(125, 20),
            ForeColor = priorityColor, Font = new Font("Segoe UI", 8F, FontStyle.Bold),
            BackColor = Color.Transparent, AutoEllipsis = true
        };
        var titleLabel = new Label
        {
            Text = title, Location = new Point(142, 5), Size = new Size(Math.Max(160, width - 165), 23),
            ForeColor = Color.White, Font = new Font("Segoe UI", 11F, unread ? FontStyle.Bold : FontStyle.Regular),
            BackColor = Color.Transparent, AutoEllipsis = true
        };
        string preview = message.Length > 120 ? message[..120] + "…" : message;
        var messageLabel = new Label
        {
            Text = preview, Location = new Point(12, 31), Size = new Size(width - 28, 27),
            ForeColor = Color.FromArgb(170, 170, 185), Font = new Font("Segoe UI", 9F),
            BackColor = Color.Transparent, AutoEllipsis = true
        };
        var dateLabel = new Label
        {
            Text = postedAt.ToString("MMM dd, yyyy  h:mm tt"),
            Location = new Point(width - 205, 64), Size = new Size(190, 16),
            ForeColor = DarkGray, Font = new Font("Segoe UI", 8F),
            BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleRight
        };
        card.Controls.Add(priorityLabel);
        card.Controls.Add(titleLabel);
        card.Controls.Add(messageLabel);
        card.Controls.Add(dateLabel);
        WireCardClick(card, (_, _) => MarkAnnouncementRead(id));
        return card;
    }

    private void MarkAnnouncementRead(int announcementId)
    {
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"IF NOT EXISTS (SELECT 1 FROM dbo.InstructorAnnouncementReads
                    WHERE AnnouncementId=@AnnouncementId AND Username=@Username)
                INSERT INTO dbo.InstructorAnnouncementReads (AnnouncementId, Username)
                VALUES (@AnnouncementId, @Username)", connection);
            command.Parameters.Add("@AnnouncementId", SqlDbType.Int).Value = announcementId;
            command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = Session.CurrentUser?.Username ?? "";
            command.ExecuteNonQuery();
            LoadAnnouncements();
        }
        catch (SqlException ex) { ShowSetupMessage("Could not mark announcement as read.", ex.Message); }
    }

    private void ResizeAnnouncementCards()
    {
        int width = Math.Max(360, announcementCards.ClientSize.Width - 28);
        foreach (Control card in announcementCards.Controls)
        {
            if (card is CustomPanel) card.Width = width;
            else if (card is Label) card.Width = Math.Max(300, announcementCards.ClientSize.Width - 20);
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
            using var form = new CourseViewForm(id, title, name, instructorName);
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
        content.Controls.Clear();
        content.Controls.Add(new Label
        {
            Text = title + Environment.NewLine + details, Dock = DockStyle.Fill, ForeColor = TextGray,
            Font = new Font("Segoe UI", 12F), TextAlign = ContentAlignment.MiddleCenter
        });
        InstructorTheme.Apply(this);
    }


}
