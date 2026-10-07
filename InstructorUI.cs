using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace SMART
{
    public partial class InstructorUI : Form
    {
        private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
        private static readonly Color SidebarColor = Color.FromArgb(22, 33, 62);
        private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
        private static readonly Color HoverColor = Color.FromArgb(30, 42, 69);
        private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
        private readonly Panel content = new() { Dock = DockStyle.Fill, BackColor = BgColor, Padding = new Padding(32) };
        private readonly FlowLayoutPanel courseCards = new() { Dock = DockStyle.Fill, AutoScroll = true, WrapContents = true, BackColor = BgColor, Padding = new Padding(0, 12, 12, 12) };
        private Panel? avatarPanel;
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
            LoadInstructorDashboard();
        }

        private void BuildLayout()
        {
            var shell = new Panel { Dock = DockStyle.Fill, BackColor = BgColor };
            var sidebar = new Panel { Dock = DockStyle.Left, Width = 200, BackColor = SidebarColor, Padding = new Padding(14) };
            var avatar = new Panel { Size = new Size(70, 70), BackColor = AccentColor, Location = new Point(65, 10) };
            avatarPanel = avatar;
            avatar.Paint += (_, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using var brush = new SolidBrush(AccentColor);
                e.Graphics.FillEllipse(brush, 0, 0, avatar.Width - 1, avatar.Height - 1);
                string initials = Initials(instructorName);
                TextRenderer.DrawText(e.Graphics, initials, new Font("Segoe UI", 17, FontStyle.Bold), avatar.ClientRectangle, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
            var profile = new Panel { Dock = DockStyle.Top, Height = 130, BackColor = SidebarColor };
            profile.Controls.Add(avatar);
            var name = new Label { Name = "instructorNameLabel", Text = instructorName, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), Width = 170, Height = 34, Location = new Point(0, 86), TextAlign = ContentAlignment.MiddleCenter, AutoEllipsis = true };
            profileNameLabel = name;
            profile.Controls.Add(name);
            var divider = new Panel { Dock = DockStyle.Top, Height = 1, BackColor = Color.FromArgb(65, 75, 100), Margin = new Padding(0, 4, 0, 16) };
            var dashboard = new Button { Text = "📊  Dashboard", Dock = DockStyle.Top, Height = 42, FlatStyle = FlatStyle.Flat, BackColor = AccentColor, ForeColor = Color.White, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(8, 0, 0, 0), Cursor = Cursors.Hand };
            dashboard.FlatAppearance.BorderSize = 0;
            var signOut = new Button { Text = "Sign Out", Dock = DockStyle.Bottom, Height = 42, FlatStyle = FlatStyle.Flat, ForeColor = AccentColor, BackColor = SidebarColor, Cursor = Cursors.Hand };
            signOut.FlatAppearance.BorderSize = 0;
            signOut.Click += (_, _) => { Session.CurrentUser = null; Close(); };
            sidebar.Controls.Add(signOut);
            sidebar.Controls.Add(dashboard);
            sidebar.Controls.Add(divider);
            sidebar.Controls.Add(profile);
            shell.Controls.Add(content);
            shell.Controls.Add(sidebar);
            Controls.Add(shell);
        }

        private void LoadInstructorDashboard()
        {
            try
            {
                CourseRepository.Initialize();
                using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
                DatabaseConnection.Open(connection);
                using (var command = new SqlCommand("SELECT TOP (1) EmployeeID, FullName FROM dbo.Instructors WHERE Username = @username AND IsActive = 1", connection))
                {
                    command.Parameters.Add("@username", SqlDbType.NVarChar, 30).Value = Session.CurrentUser?.Username ?? "";
                    using var reader = command.ExecuteReader();
                    if (!reader.Read())
                    {
                        ShowSetupMessage("Your instructor profile is not available.", "Ask an administrator to enable or recreate your instructor account.");
                        return;
                    }
                    instructorEmployeeId = reader.GetString(0);
                    instructorName = reader.GetString(1);
                }

                UpdateProfileName();
                ShowCourseCards(connection);
            }
            catch (SqlException ex)
            {
                ShowSetupMessage("The instructor dashboard could not load its data.", ex.Message);
            }
        }

        private void UpdateProfileName()
        {
            if (profileNameLabel != null) profileNameLabel.Text = instructorName;
            avatarPanel?.Invalidate();
        }

        private void ShowCourseCards(SqlConnection connection)
        {
            content.Controls.Clear();
            var heading = new Label { Text = $"Welcome, {instructorName}!", Dock = DockStyle.Top, Height = 48, ForeColor = Color.White, Font = new Font("Segoe UI", 22, FontStyle.Bold) };
            var subtitle = new Label { Text = "Here are your current courses.", Dock = DockStyle.Top, Height = 30, ForeColor = TextGray, Font = new Font("Segoe UI", 11) };
            courseCards.Controls.Clear();
            content.Controls.Add(courseCards);
            content.Controls.Add(subtitle);
            content.Controls.Add(heading);

            const string sql = @"SELECT c.CourseRecordID, c.CourseCode, c.CourseName, N'' AS Section, c.Program,
                                       (SELECT COUNT(*) FROM dbo.Enrollments e WHERE e.CourseId = c.CourseRecordID) AS StudentCount
                                FROM dbo.Courses c WHERE c.InstructorEmployeeID = @employeeId ORDER BY c.CourseCode";
            using var command = new SqlCommand(sql, connection);
            command.Parameters.Add("@employeeId", SqlDbType.NVarChar, 50).Value = instructorEmployeeId;
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string code = reader.GetString(1);
                string title = reader.GetString(2);
                string section = reader.GetString(3);
                string program = reader.IsDBNull(4) ? "All Programs" : reader.GetString(4);
                int count = reader.GetInt32(5);
                courseCards.Controls.Add(CreateCourseCard(id, code, title, section, program, count));
            }
            if (courseCards.Controls.Count == 0)
                courseCards.Controls.Add(new Label { Text = "No courses are assigned to you yet.", AutoSize = true, ForeColor = TextGray, Font = new Font("Segoe UI", 12), Margin = new Padding(4, 20, 0, 0) });
        }

        private Panel CreateCourseCard(int id, string code, string title, string section, string program, int count)
        {
            var card = new Panel { Size = new Size(220, 180), BackColor = SidebarColor, Margin = new Padding(0, 4, 18, 18), Cursor = Cursors.Hand, Padding = new Padding(14) };
            card.Paint += (_, e) => { using var pen = new Pen(AccentColor, 2); e.Graphics.DrawRectangle(pen, 1, 1, card.Width - 3, card.Height - 3); };
            var codeLabel = CardLabel(code, AccentColor, 18, true, 30);
            var titleLabel = CardLabel(title, Color.White, 12, false, 38);
            var sectionLabel = CardLabel("Section " + section, TextGray, 10, false, 24);
            var countLabel = CardLabel($"👥 {count} Students", TextGray, 10, false, 25);
            var openLabel = CardLabel("Click to open →", AccentColor, 9, false, 20);
            card.Controls.Add(openLabel); card.Controls.Add(countLabel); card.Controls.Add(sectionLabel); card.Controls.Add(titleLabel); card.Controls.Add(codeLabel);
            card.MouseEnter += (_, _) => card.BackColor = HoverColor;
            card.MouseLeave += (_, _) => card.BackColor = SidebarColor;
            void Open(object? _, EventArgs __) => ShowCourseView(id, code, title, program, section);
            WireCardClick(card, Open);
            return card;
        }

        private static Label CardLabel(string text, Color color, float size, bool bold, int height) => new() { Text = text, Dock = DockStyle.Top, Height = height, ForeColor = color, Font = new Font("Segoe UI", size, bold ? FontStyle.Bold : FontStyle.Regular), AutoEllipsis = true, TextAlign = ContentAlignment.MiddleLeft };
        private static void WireCardClick(Control control, EventHandler handler) { control.Click += handler; foreach (Control child in control.Controls) WireCardClick(child, handler); }

        private void ShowCourseView(int courseId, string code, string courseName, string program, string section)
        {
            content.Controls.Clear();
            var back = new Button { Text = "← Back to Dashboard", Dock = DockStyle.Top, Height = 34, FlatStyle = FlatStyle.Flat, ForeColor = TextGray, BackColor = BgColor, TextAlign = ContentAlignment.MiddleLeft, Cursor = Cursors.Hand };
            back.FlatAppearance.BorderSize = 0;
            back.Click += (_, _) => LoadInstructorDashboard();
            var subtitle = new Label { Text = $"Program: {program}   |   Section: {section}   |   Teacher: {instructorName}", Dock = DockStyle.Top, Height = 28, ForeColor = TextGray, Font = new Font("Segoe UI", 10) };
            var title = new Label { Text = code + "  " + courseName, Dock = DockStyle.Top, Height = 42, ForeColor = Color.White, Font = new Font("Segoe UI", 20, FontStyle.Bold) };
            var tabs = new TabControl { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 10) };
            foreach (string tabName in new[] { "👥 Students", "📋 Attendance", "📝 Quizzes", "📄 Exams", "📊 Performance" })
            {
                var page = new TabPage(tabName) { BackColor = BgColor, ForeColor = Color.White };
                page.Controls.Add(new Label { Text = "Course data will appear here when the course database tables are configured.", Dock = DockStyle.Fill, ForeColor = TextGray, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 11) });
                tabs.TabPages.Add(page);
            }
            content.Controls.Add(tabs); content.Controls.Add(subtitle); content.Controls.Add(title); content.Controls.Add(back);
        }

        private void ShowSetupMessage(string title, string details)
        {
            content.Controls.Clear();
            var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(12) };
            panel.Controls.Add(new Label { Text = details, Dock = DockStyle.Top, Height = 90, ForeColor = TextGray, Font = new Font("Segoe UI", 11) });
            panel.Controls.Add(new Label { Text = title, Dock = DockStyle.Top, Height = 42, ForeColor = Color.White, Font = new Font("Segoe UI", 18, FontStyle.Bold) });
            content.Controls.Add(panel);
        }

        private static string Initials(string fullName)
        {
            string[] parts = (fullName ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "?";
            return parts.Length == 1 ? parts[0][..1].ToUpperInvariant() : (parts[0][..1] + parts[^1][..1]).ToUpperInvariant();
        }

        private void flpSignOutInstructor_Paint(object sender, PaintEventArgs e) { }
    }
}
