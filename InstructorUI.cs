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
    private readonly CustomPanel content = new() { Dock = DockStyle.Fill, BackColor = BgColor, Padding = new Padding(32), BorderWidth = 0, CornerRadius = 1 };
    private readonly RoundedFlowLayoutPanel courseCards = new() { Dock = DockStyle.Fill, AutoScroll = true, WrapContents = true, BackColor = BgColor, Padding = new Padding(0, 12, 12, 12), BorderSize = 0, BorderRadius = 0 };
    private PictureBox? pbProfile;
    private Label? profileNameLabel;
    private string instructorEmployeeId = "";
    private string instructorName = "Instructor";

    public InstructorUI()
    {
        InitializeComponent();
        SuspendLayout();
        Controls.Clear();
        BackColor = BgColor;
        FormBorderStyle = FormBorderStyle.Sizable;
        MinimumSize = new Size(900, 600);
        WindowState = FormWindowState.Maximized;
        BuildLayout();
        ResumeLayout(true);
        Load += (_, _) => LoadInstructorDashboard();
    }

    private void BuildLayout()
    {
        var shell = new CustomPanel { Dock = DockStyle.Fill, BackColor = BgColor, BorderWidth = 0, CornerRadius = 1 };
        var sidebar = new CustomPanel { Dock = DockStyle.Left, Width = 205, BackColor = SidebarColor, Padding = new Padding(14), BorderWidth = 0, CornerRadius = 1 };

        var logo = new CustomPanel { Dock = DockStyle.Top, Height = 66, BackColor = SidebarColor, BorderWidth = 0, CornerRadius = 1 };
        logo.Controls.Add(new Label { Text = "S.M.A.R.T", Dock = DockStyle.Top, Height = 34, ForeColor = AccentColor, Font = new Font("Segoe UI", 18F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft });
        logo.Controls.Add(new Label { Text = "Instructor Panel", Dock = DockStyle.Top, Height = 22, ForeColor = Color.FromArgb(170, 170, 185), Font = new Font("Segoe UI", 9F), TextAlign = ContentAlignment.MiddleLeft });

        var profile = new CustomPanel { Dock = DockStyle.Top, Height = 50, BackColor = SidebarColor, BorderWidth = 0, CornerRadius = 1, Padding = new Padding(8) };
        pbProfile = new PictureBox { Name = "pbProfile", Size = new Size(40, 40), BackColor = SidebarColor, SizeMode = PictureBoxSizeMode.Zoom, Location = new Point(8, 5) };
        pbProfile.Paint += (_, e) =>
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var pen = new Pen(AccentColor, 2);
            e.Graphics.DrawEllipse(pen, 1, 1, pbProfile.Width - 3, pbProfile.Height - 3);
        };
        PhotoHelper.MakeCircular(pbProfile);
        profileNameLabel = new Label { Text = instructorName, ForeColor = Color.White, Font = new Font("Segoe UI", 10F, FontStyle.Bold), AutoEllipsis = true, TextAlign = ContentAlignment.MiddleLeft, Location = new Point(52, 8), Size = new Size(120, 42) };
        profile.Controls.Add(pbProfile);
        profile.Controls.Add(profileNameLabel);

        var topDivider = Divider();
        var bottomDivider = Divider();
        var dashboard = MakeNavButton("📊  Dashboard", true);
        dashboard.Click += (_, _) => LoadInstructorDashboard();
        var signOut = MakeNavButton("Sign Out", false);
        signOut.Dock = DockStyle.Bottom;
        signOut.ForeColor = AccentColor;
        signOut.BackColor = SidebarColor;
        signOut.Click += (_, _) => SignOut();
        var spacer = new CustomPanel { Dock = DockStyle.Fill, BackColor = SidebarColor, BorderWidth = 0, CornerRadius = 1 };

        sidebar.Controls.Add(spacer);
        sidebar.Controls.Add(signOut);
        sidebar.Controls.Add(dashboard);
        sidebar.Controls.Add(bottomDivider);
        sidebar.Controls.Add(profile);
        sidebar.Controls.Add(topDivider);
        sidebar.Controls.Add(logo);
        shell.Controls.Add(content);
        shell.Controls.Add(sidebar);
        Controls.Add(shell);
    }

    private static CustomPanel Divider() => new()
    {
        Dock = DockStyle.Top, Height = 1, BackColor = Color.FromArgb(65, 75, 100),
        BorderWidth = 0, CornerRadius = 1, Margin = new Padding(0, 4, 0, 12)
    };

    private static CustomButton MakeNavButton(string text, bool active) => new()
    {
        Text = text, Dock = DockStyle.Top, Height = 42, FlatStyle = FlatStyle.Flat,
        BackColor = active ? AccentColor : SidebarColor,
        ForeColor = Color.White, TextAlign = ContentAlignment.MiddleLeft,
        Padding = new Padding(8, 0, 0, 0), Cursor = Cursors.Hand,
        BorderRadius = 6, BorderSize = 0, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
    };

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
        }
        catch (SqlException ex)
        {
            ShowSetupMessage("The instructor dashboard could not load its data.", ex.Message);
        }
    }

    private static void EnsureMissingTables()
    {
        string[] statements =
        {
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

    private void UpdateProfileName()
    {
        if (profileNameLabel != null) profileNameLabel.Text = instructorName;
        pbProfile?.Invalidate();
    }

    private void ShowCourseCards(SqlConnection connection)
    {
        content.Controls.Clear();
        courseCards.Controls.Clear();
        var heading = new Label { Text = $"Welcome, {instructorName}!", Dock = DockStyle.Top, Height = 48, ForeColor = Color.White, Font = new Font("Segoe UI", 22F, FontStyle.Bold) };
        var subtitle = new Label { Text = "Here are your current courses.", Dock = DockStyle.Top, Height = 30, ForeColor = TextGray, Font = new Font("Segoe UI", 11F) };
        content.Controls.Add(courseCards);
        content.Controls.Add(subtitle);
        content.Controls.Add(heading);

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
        card.MouseEnter += (_, _) => card.BackColor = HoverColor;
        card.MouseLeave += (_, _) => card.BackColor = SidebarColor;
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
    }

    private void flpSignOutInstructor_Paint(object sender, PaintEventArgs e) { }
}
