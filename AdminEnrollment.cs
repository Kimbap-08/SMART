using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace SMART
{
    public partial class AdminEnrollment : Form
    {
        private static readonly Color TextGray = Color.FromArgb(150, 150, 170);

        private readonly List<CourseChoice> courses = new();
        private int selectedCourseId = -1;
        private string selectedProgram = "All Programs";
        private string studentViewStatus = "";
        private bool loadingStudentPrograms;
        private const string EligibleStudentSql = @"(s.Status IS NULL OR NULLIF(LTRIM(RTRIM(s.Status)), N'') IS NULL
            OR UPPER(LTRIM(RTRIM(s.Status))) = N'ACTIVE')
            AND (UPPER(LEFT(LTRIM(RTRIM(c.CourseTitle)),
                PATINDEX(N'%[^A-Za-z]%', LTRIM(RTRIM(c.CourseTitle)) + N'0') - 1)) <> N'CEE'
                OR UPPER(LTRIM(RTRIM(s.Department))) IN
                    (N'COLLEGE OF ENGINEERING EDUCATION', N'COLLEGE OF ENGINEERING EDUCATION (CEE)'))
            AND (UPPER(LEFT(LTRIM(RTRIM(c.CourseTitle)),
                PATINDEX(N'%[^A-Za-z]%', LTRIM(RTRIM(c.CourseTitle)) + N'0') - 1)) <> N'CPE'
                OR UPPER(LTRIM(RTRIM(s.Program))) = N'BS IN COMPUTER ENGINEERING')";

        public AdminEnrollment()
        {
            InitializeComponent();
            cboStudentProgram.SelectedIndex = 0;
            ArrangeEnrollmentSelectors();
        }

        private void Top_SizeChanged(object? sender, EventArgs e) => ArrangeEnrollmentSelectors();

        private void ArrangeEnrollmentSelectors()
        {
            const int inset = 24;
            const int gap = 24;
            int width = Math.Max(240, top.ClientSize.Width - inset * 2);
            int fieldWidth = (width - gap) / 2;
            int secondLeft = inset + fieldWidth + gap;
            courseLabel.SetBounds(inset, 16, fieldWidth, 24);
            cboCourse.SetBounds(inset, 42, fieldWidth, cboCourse.Height);
            studentProgramLabel.SetBounds(secondLeft, 16, fieldWidth, 24);
            cboStudentProgram.SetBounds(secondLeft, 42, fieldWidth, cboStudentProgram.Height);
            programLabel.SetBounds(inset, 84, width, 24);
            // Keep the code list proportional while retaining space for its scrollbar.
            listPrograms.SetBounds(inset, 110, width, 32);
            lblStatus.SetBounds(inset, 152, width, 46);
        }

        private void Enrollment_Load(object? sender, EventArgs e) => LoadCourses();

        private void CboCourse_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (sender is not ComboBox combo) return;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color background = isSelected ? Color.FromArgb(233, 69, 96) : combo.BackColor;
            using var brush = new SolidBrush(background);
            e.Graphics.FillRectangle(brush, e.Bounds);
            object? item = e.Index >= 0 && e.Index < combo.Items.Count ? combo.Items[e.Index] : combo.SelectedItem;
            if (item != null)
            {
                string text = combo.GetItemText(item) ?? "";
                var bounds = new Rectangle(e.Bounds.X + 6, e.Bounds.Y,
                    Math.Max(0, e.Bounds.Width - 12), e.Bounds.Height);
                TextRenderer.DrawText(e.Graphics, text, e.Font ?? combo.Font, bounds,
                    combo.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                    TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis);
            }
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
                    courses.Add(course);
                }
                cboCourse.Items.AddRange(courses.Cast<object>().ToArray());
                if (cboCourse.Items.Count > 0) cboCourse.SelectedIndex = 0;
                else
                {
                    selectedCourseId = -1;
                    listPrograms.Items.Clear();
                    gridAll.DataSource = null;
                    gridEnrolled.DataSource = null;
                    lblEnrolledCount.Text = "Enrolled Students (0)";
                    studentViewStatus = "";
                    ResetStudentPrograms();
                    ShowStatus("No courses available.", TextGray);
                }
            }
            catch (Exception ex) { ShowStatus("Could not load courses: " + ex.Message, Color.OrangeRed); }
        }

        private void CboCourse_Changed(object? sender, EventArgs e)
        {
            if (cboCourse.SelectedItem is not CourseChoice course) return;
            selectedCourseId = course.Id;
            DisplayCoursePrograms(course);
            studentViewStatus = "";
            try
            {
                LoadStudentProgramChoices();
                LoadAllStudents(); LoadEnrolledStudents();
            }
            catch (Exception ex) { ShowStatus("Could not load enrollment data: " + ex.Message, Color.OrangeRed); }
        }

        private static readonly string[] CoursePrograms = { "ME", "CES", "COE", "BSN", "IT", "GEO", "ECE", "ACC" };

        private static string CourseTitlePrefix(string title) =>
            new string(title.Trim().ToUpperInvariant().TakeWhile(c => c >= 'A' && c <= 'Z').ToArray());

        private static string[] ProgramsForCourse(string title, string assignedProgram) => CourseTitlePrefix(title) switch
        {
            "CEE" => new[] { "CES", "ME", "COE", "ECE" },
            "CPE" => new[] { "COE" },
            "GE" or "NSTP" or "PAHF" => CoursePrograms.ToArray(),
            _ => string.IsNullOrWhiteSpace(assignedProgram) ? Array.Empty<string>() :
                new[] { assignedProgram.Trim().ToUpperInvariant() }
        };

        private void DisplayCoursePrograms(CourseChoice course)
        {
            listPrograms.BeginUpdate();
            try
            {
                listPrograms.Items.Clear();
                listPrograms.Items.AddRange(ProgramsForCourse(course.Title, course.Program));
                listPrograms.ClearSelected();
            }
            finally { listPrograms.EndUpdate(); }
        }

        private void ResetStudentPrograms()
        {
            loadingStudentPrograms = true;
            try
            {
                cboStudentProgram.Items.Clear();
                cboStudentProgram.Items.Add("All Programs");
                cboStudentProgram.SelectedIndex = 0;
                selectedProgram = "All Programs";
            }
            finally { loadingStudentPrograms = false; }
        }

        private void LoadStudentProgramChoices()
        {
            ResetStudentPrograms();
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT DISTINCT LTRIM(RTRIM(s.Program)) AS Program
                FROM dbo.Students s JOIN dbo.Courses c ON c.CourseRecordID = @courseId
                WHERE " + EligibleStudentSql + @" AND NULLIF(LTRIM(RTRIM(s.Program)), N'') IS NOT NULL
                ORDER BY Program", connection);
            command.Parameters.Add("@courseId", SqlDbType.Int).Value = selectedCourseId;
            using var reader = command.ExecuteReader();
            while (reader.Read()) cboStudentProgram.Items.Add(reader.GetString(0));
        }

        private void CboStudentProgram_Changed(object? sender, EventArgs e)
        {
            if (loadingStudentPrograms || cboStudentProgram.SelectedItem is not string program) return;
            selectedProgram = program;
            try { LoadAllStudents(); }
            catch (Exception ex) { ShowStatus("Could not filter students: " + ex.Message, Color.OrangeRed); }
        }

        private void ListPrograms_DrawItem(object? sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            using var brush = new SolidBrush(selected ? Color.FromArgb(233, 69, 96) : listPrograms.BackColor);
            e.Graphics.FillRectangle(brush, e.Bounds);
            TextRenderer.DrawText(e.Graphics, Convert.ToString(listPrograms.Items[e.Index]) ?? "",
                e.Font ?? listPrograms.Font, e.Bounds, Color.White,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPrefix);
            e.DrawFocusRectangle();
        }

        private static string StudentProgramStatus(IEnumerable<string> programs, string filter)
        {
            string[] values = programs.Select(p => p.Trim()).Where(p => p.Length > 0)
                .Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(p => p).ToArray();
            if (values.Length == 1) return "Showing students for: " + values[0];
            if (values.Length > 1)
                return "Showing students for: All programs. Programs: " + string.Join("; ", values);
            return "Showing students for: " + (filter == "All Programs" ? "All programs" : filter) + " (no available students).";
        }

        private void LoadAllStudents()
        {
            if (selectedCourseId < 0) return;
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT s.StudentID AS StudentNumber, s.StudentName AS FullName, s.Program, s.StudentID AS StudentId
                FROM dbo.Students s JOIN dbo.Courses c ON c.CourseRecordID = @courseId
                WHERE " + EligibleStudentSql + @"
                AND (@program = N'All Programs' OR UPPER(LTRIM(RTRIM(s.Program))) = UPPER(LTRIM(RTRIM(@program))))
                AND NOT EXISTS (SELECT 1 FROM dbo.Enrollments e WHERE e.StudentID = s.StudentID AND e.CourseId = @courseId)
                ORDER BY s.StudentName", connection);
            command.Parameters.Add("@program", SqlDbType.NVarChar, 150).Value = selectedProgram;
            command.Parameters.Add("@courseId", SqlDbType.Int).Value = selectedCourseId;
            var table = new DataTable(); using var adapter = new SqlDataAdapter(command); adapter.Fill(table); gridAll.DataSource = table;
            if (gridAll.Columns.Contains("StudentId")) gridAll.Columns["StudentId"].Visible = false;
            gridAll.ClearSelection(); gridAll.CurrentCell = null;
            string status = StudentProgramStatus(table.AsEnumerable().Select(r => Convert.ToString(r["Program"]) ?? ""), selectedProgram);
            if (cboCourse.SelectedItem is CourseChoice course && CourseTitlePrefix(course.Title) == "CEE")
                status += " CEE: College of Engineering Education students only.";
            else if (cboCourse.SelectedItem is CourseChoice cpeCourse && CourseTitlePrefix(cpeCourse.Title) == "CPE")
                status += " CPE: BS in Computer Engineering students only.";
            studentViewStatus = status;
            ShowStatus(status, TextGray);
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
                using var command = new SqlCommand(@"INSERT INTO dbo.Enrollments (StudentID, CourseId)
                    SELECT s.StudentID, c.CourseRecordID FROM dbo.Students s
                    JOIN dbo.Courses c ON c.CourseRecordID = @cid
                    WHERE s.StudentID = @sid AND " + EligibleStudentSql + @"
                    AND NOT EXISTS (SELECT 1 FROM dbo.Enrollments WHERE StudentID = @sid AND CourseId = @cid)", connection);
                command.Parameters.Add("@sid", SqlDbType.VarChar, 10).Value = studentId;
                command.Parameters.Add("@cid", SqlDbType.Int).Value = selectedCourseId;
                if (command.ExecuteNonQuery() == 0)
                {
                    LoadAllStudents();
                    ShowStatus("Student is already enrolled or no longer eligible for this course.", Color.DarkOrange);
                    return;
                }
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

        private void ShowStatus(string message, Color color)
        {
            lblStatus.Text = studentViewStatus.Length > 0 && message != studentViewStatus
                ? message + Environment.NewLine + studentViewStatus : message;
            lblStatus.ForeColor = color;
        }

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
