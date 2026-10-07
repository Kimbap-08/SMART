using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace SMART
{
    public sealed class Enrollment : UserControl
    {
        private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
        private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
        private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
        private static readonly Color TextGray = Color.FromArgb(150, 150, 170);

        private readonly ComboBox cboCourse = new();
        private readonly DataGridView gridAll = new();
        private readonly DataGridView gridEnrolled = new();
        private readonly CustomButton btnEnroll = new();
        private readonly CustomButton btnRemove = new();
        private readonly Label lblStatus = new();
        private readonly Label lblEnrolledCount = new();
        private readonly List<CourseChoice> courses = new();
        private int selectedCourseId = -1;
        private string selectedProgram = "All Programs";

        public Enrollment()
        {
            Dock = DockStyle.Fill;
            BackColor = BgColor;
            BuildUI();
            Load += (s, e) => LoadCourses();
        }

        private void BuildUI()
        {
            var header = new Panel { Dock = DockStyle.Top, Height = 112, BackColor = CardColor, Padding = new Padding(26, 16, 20, 12) };
            var title = new Label { Text = "Enrollment Management", Dock = DockStyle.Top, Height = 44, ForeColor = Color.White, Font = new Font("Segoe UI", 20, FontStyle.Bold) };
            var subtitle = new Label { Text = "Enroll students into courses", Dock = DockStyle.Top, Height = 28, ForeColor = TextGray, Font = new Font("Segoe UI", 10) };
            header.Controls.Add(subtitle);
            header.Controls.Add(title);
            var body = new TableLayoutPanel { Dock = DockStyle.Fill, BackColor = BgColor, Padding = new Padding(24, 16, 24, 20), ColumnCount = 3, RowCount = 1 };
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            var top = new Panel { Dock = DockStyle.Top, Height = 84, BackColor = BgColor };
            var courseLabel = new Label { Text = "Select Course:", ForeColor = Color.White, Font = new Font("Segoe UI", 10), AutoSize = true, Location = new Point(0, 9) };
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.BackColor = CardColor; cboCourse.ForeColor = Color.White; cboCourse.FlatStyle = FlatStyle.Flat;
            cboCourse.Font = new Font("Segoe UI", 10); cboCourse.SetBounds(116, 4, 460, 32); cboCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cboCourse.SelectedIndexChanged += CboCourse_Changed;
            lblStatus.Text = "Select a course to view students."; lblStatus.ForeColor = TextGray; lblStatus.Font = new Font("Segoe UI", 9); lblStatus.AutoEllipsis = true;
            lblStatus.SetBounds(0, 47, 500, 24); lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top.Controls.Add(courseLabel); top.Controls.Add(cboCourse); top.Controls.Add(lblStatus);

            var left = CreateSection(gridAll);
            var right = CreateSection(gridEnrolled);
            lblEnrolledCount.Text = "Enrolled Students (0)";
            // The section title follows the count, which is refreshed whenever the right grid changes.
            right.Controls.Clear();
            var rightLayout = new TableLayoutPanel { Dock = DockStyle.Fill, BackColor = CardColor, Padding = new Padding(12), RowCount = 3, ColumnCount = 1 };
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28)); rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            lblEnrolledCount.ForeColor = Color.White; lblEnrolledCount.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnRemove.Text = "− Remove Selected Student"; btnRemove.BackColor = Color.FromArgb(60, 60, 80); btnRemove.ForeColor = AccentColor; btnRemove.Dock = DockStyle.Fill; btnRemove.Font = new Font("Segoe UI", 10, FontStyle.Bold); btnRemove.Click += BtnRemove_Click;
            rightLayout.Controls.Add(lblEnrolledCount, 0, 0); rightLayout.Controls.Add(gridEnrolled, 0, 1); rightLayout.Controls.Add(btnRemove, 0, 2); right.Controls.Add(rightLayout);

            var leftLayout = new TableLayoutPanel { Dock = DockStyle.Fill, BackColor = CardColor, Padding = new Padding(12), RowCount = 3, ColumnCount = 1 };
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28)); leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            var leftTitle = new Label { Text = "All Students", ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            btnEnroll.Text = "+ Enroll Selected Student"; btnEnroll.BackColor = AccentColor; btnEnroll.ForeColor = Color.White; btnEnroll.Dock = DockStyle.Fill; btnEnroll.Font = new Font("Segoe UI", 10, FontStyle.Bold); btnEnroll.Click += BtnEnroll_Click;
            leftLayout.Controls.Add(leftTitle, 0, 0); leftLayout.Controls.Add(gridAll, 0, 1); leftLayout.Controls.Add(btnEnroll, 0, 2);
            left.Controls.Clear(); left.Controls.Add(leftLayout);

            var middle = new Panel { Dock = DockStyle.Fill, BackColor = BgColor };
            var arrow = new Label { Text = "→", ForeColor = AccentColor, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 18, FontStyle.Bold) };
            middle.Controls.Add(arrow);
            body.Controls.Add(left, 0, 0); body.Controls.Add(middle, 1, 0); body.Controls.Add(right, 2, 0);

            StyleGrid(gridAll); StyleGrid(gridEnrolled);
            gridAll.Columns.Clear(); gridEnrolled.Columns.Clear();
            AddColumns(gridAll); AddColumns(gridEnrolled);
            top.Dock = DockStyle.Top;
            // Add docked controls from fill to top so the header and course selector reserve space.
            Controls.Add(body);
            Controls.Add(top);
            Controls.Add(header);
        }

        private static CustomPanel CreateSection(DataGridView grid)
        {
            var section = new CustomPanel { Dock = DockStyle.Fill, BackColor = CardColor, BorderColor = Color.FromArgb(40, 48, 72), BorderWidth = 0, CornerRadius = 10, Padding = new Padding(8) };
            section.Controls.Add(grid);
            return section;
        }

        private static void AddColumns(DataGridView grid)
        {
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentNumber", HeaderText = "Student No.", DataPropertyName = "StudentNumber", FillWeight = 28 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", HeaderText = "Full Name", DataPropertyName = "FullName", FillWeight = 45 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Program", HeaderText = "Program", DataPropertyName = "Program", FillWeight = 32 });
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.Dock = DockStyle.Fill; grid.BackgroundColor = CardColor; grid.ForeColor = Color.White; grid.GridColor = Color.FromArgb(40, 40, 60);
            grid.BorderStyle = BorderStyle.None; grid.RowHeadersVisible = false; grid.AllowUserToAddRows = false; grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; grid.MultiSelect = false; grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.EnableHeadersVisualStyles = false; grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 15, 35); grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold); grid.DefaultCellStyle.BackColor = CardColor; grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = AccentColor; grid.DefaultCellStyle.SelectionForeColor = Color.White; grid.RowTemplate.Height = 36;
        }

        private void LoadCourses()
        {
            try
            {
                using var connection = OpenConnection();
                using var command = new SqlCommand("SELECT CourseRecordID, CourseTitle, CourseName, Program FROM dbo.Courses ORDER BY CourseCode", connection);
                using var reader = command.ExecuteReader();
                courses.Clear(); cboCourse.Items.Clear();
                while (reader.Read())
                {
                    var course = new CourseChoice(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    courses.Add(course); cboCourse.Items.Add(course);
                }
                if (cboCourse.Items.Count > 0) cboCourse.SelectedIndex = 0;
            }
            catch (Exception ex) { ShowStatus("Could not load courses: " + ex.Message, Color.OrangeRed); }
        }

        private void CboCourse_Changed(object? sender, EventArgs e)
        {
            if (cboCourse.SelectedItem is not CourseChoice course) return;
            selectedCourseId = course.Id; selectedProgram = StudentProgramFor(course.Program);
            try
            {
                LoadAllStudents(); LoadEnrolledStudents();
                ShowStatus("Showing students for: " + selectedProgram, TextGray);
            }
            catch (Exception ex) { ShowStatus("Could not load enrollment data: " + ex.Message, Color.OrangeRed); }
        }

        private static string StudentProgramFor(string courseProgram) => courseProgram.Trim().ToUpperInvariant() switch
        {
            "ME" => "BS in Mechanical Engineering",
            "CES" => "BS in Civil Engineering",
            "COE" => "BS in Computer Engineering",
            "BSN" => "BS in Nursing",
            "IT" => "BS in Information Technology",
            "ECE" => "BS in Electronics Engineering",
            "ACC" => "BS in Accountancy",
            _ => courseProgram.Trim()
        };

        private void LoadAllStudents()
        {
            if (selectedCourseId < 0) return;
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT s.StudentID AS StudentNumber, s.StudentName AS FullName, s.Program, s.StudentID AS StudentId
                FROM dbo.Students s WHERE (s.Status IS NULL OR NULLIF(LTRIM(RTRIM(s.Status)), N'') IS NULL
                    OR UPPER(LTRIM(RTRIM(s.Status))) = N'ACTIVE')
                AND (@program = N'All Programs' OR UPPER(LTRIM(RTRIM(s.Program))) = UPPER(LTRIM(RTRIM(@program))))
                AND NOT EXISTS (SELECT 1 FROM dbo.Enrollments e WHERE e.StudentID = s.StudentID AND e.CourseId = @courseId)
                ORDER BY s.StudentName", connection);
            command.Parameters.Add("@program", SqlDbType.NVarChar, 150).Value = selectedProgram;
            command.Parameters.Add("@courseId", SqlDbType.Int).Value = selectedCourseId;
            var table = new DataTable(); using var adapter = new SqlDataAdapter(command); adapter.Fill(table); gridAll.DataSource = table;
            if (gridAll.Columns.Contains("StudentId")) gridAll.Columns["StudentId"].Visible = false;
            gridAll.ClearSelection(); gridAll.CurrentCell = null;
        }

        private void LoadEnrolledStudents()
        {
            if (selectedCourseId < 0) return;
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT s.StudentID AS StudentNumber, s.StudentName AS FullName, s.Program, s.StudentID AS StudentId
                FROM dbo.Students s JOIN dbo.Enrollments e ON e.StudentID = s.StudentID
                WHERE e.CourseId = @courseId ORDER BY s.StudentName", connection);
            command.Parameters.Add("@courseId", SqlDbType.Int).Value = selectedCourseId;
            var table = new DataTable(); using var adapter = new SqlDataAdapter(command); adapter.Fill(table); gridEnrolled.DataSource = table;
            if (gridEnrolled.Columns.Contains("StudentId")) gridEnrolled.Columns["StudentId"].Visible = false;
            gridEnrolled.ClearSelection(); gridEnrolled.CurrentCell = null;
            lblEnrolledCount.Text = $"Enrolled Students ({table.Rows.Count})";
        }

        private void BtnEnroll_Click(object? sender, EventArgs e)
        {
            if (selectedCourseId < 0) { ShowStatus("Please select a course first.", Color.OrangeRed); return; }
            if (gridAll.SelectedRows.Count == 0 || gridAll.CurrentRow?.DataBoundItem is not DataRowView row) { ShowStatus("Please select a student.", Color.OrangeRed); return; }
            string studentId = Convert.ToString(row["StudentId"]) ?? "";
            string name = Convert.ToString(row["FullName"]) ?? "student";
            try
            {
                using var connection = OpenConnection();
                using var command = new SqlCommand("INSERT INTO dbo.Enrollments (StudentID, CourseId) SELECT @sid, @cid WHERE NOT EXISTS (SELECT 1 FROM dbo.Enrollments WHERE StudentID = @sid AND CourseId = @cid)", connection);
                command.Parameters.Add("@sid", SqlDbType.VarChar, 10).Value = studentId;
                command.Parameters.Add("@cid", SqlDbType.Int).Value = selectedCourseId;
                if (command.ExecuteNonQuery() == 0) { ShowStatus("Already enrolled!", Color.DarkOrange); return; }
                LoadAllStudents(); LoadEnrolledStudents(); ShowStatus($"{name} enrolled successfully.", Color.LightGreen);
            }
            catch (Exception ex) { ShowStatus("Could not enroll student: " + ex.Message, Color.OrangeRed); }
        }

        private void BtnRemove_Click(object? sender, EventArgs e)
        {
            if (selectedCourseId < 0) { ShowStatus("Please select a course first.", Color.OrangeRed); return; }
            if (gridEnrolled.SelectedRows.Count == 0 || gridEnrolled.CurrentRow?.DataBoundItem is not DataRowView row) { ShowStatus("Please select a student.", Color.OrangeRed); return; }
            string studentId = Convert.ToString(row["StudentId"]) ?? "";
            string name = Convert.ToString(row["FullName"]) ?? "student";
            try
            {
                using var connection = OpenConnection();
                using var command = new SqlCommand("DELETE FROM dbo.Enrollments WHERE StudentID = @sid AND CourseId = @cid", connection);
                command.Parameters.Add("@sid", SqlDbType.VarChar, 10).Value = studentId;
                command.Parameters.Add("@cid", SqlDbType.Int).Value = selectedCourseId;
                command.ExecuteNonQuery(); LoadEnrolledStudents(); LoadAllStudents(); ShowStatus($"{name} removed successfully.", Color.LightGreen);
            }
            catch (Exception ex) { ShowStatus("Could not remove student: " + ex.Message, Color.OrangeRed); }
        }

        private void ShowStatus(string message, Color color) { lblStatus.Text = message; lblStatus.ForeColor = color; }

        private static SqlConnection OpenConnection()
        {
            var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            try
            {
                DatabaseConnection.Open(connection);
                using var command = new SqlCommand(@"IF OBJECT_ID(N'dbo.Enrollments', N'U') IS NULL
                    CREATE TABLE dbo.Enrollments (
                        EnrollmentId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                        StudentID VARCHAR(10) NOT NULL,
                        CourseId INT NOT NULL,
                        EnrolledAt DATETIME NOT NULL CONSTRAINT DF_Enrollments_EnrolledAt DEFAULT GETDATE(),
                        CONSTRAINT FK_Enrollments_Students FOREIGN KEY (StudentID) REFERENCES dbo.Students(StudentID),
                        CONSTRAINT FK_Enrollments_Courses FOREIGN KEY (CourseId) REFERENCES dbo.Courses(CourseRecordID),
                        CONSTRAINT UQ_Enrollments_Student_Course UNIQUE (StudentID, CourseId)
                    );", connection);
                command.ExecuteNonQuery();
                return connection;
            }
            catch { connection.Dispose(); throw; }
        }

        private sealed record CourseChoice(int Id, string Title, string Name, string Program)
        {
            public override string ToString() => $"{Title} - {Name}";
        }
    }
}
