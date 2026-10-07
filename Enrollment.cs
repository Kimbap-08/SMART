using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace SMART
{
    public partial class Enrollment : Form
    {
        private static readonly Color TextGray = Color.FromArgb(150, 150, 170);

        private readonly List<CourseChoice> courses = new();
        private int selectedCourseId = -1;
        private string selectedProgram = "All Programs";
        private string studentViewStatus = "";
        private bool loadingStudentPrograms;
        private const string EligibleStudentSql = @"(s.Status IS NULL OR NULLIF(LTRIM(RTRIM(s.Status)), N'') IS NULL
            OR UPPER(LTRIM(RTRIM(s.Status))) = N'ACTIVE')
            AND (UPPER(LTRIM(RTRIM(c.CourseTitle))) <> N'CEE'
                OR UPPER(LTRIM(RTRIM(s.Department))) IN
                    (N'COLLEGE OF ENGINEERING EDUCATION', N'COLLEGE OF ENGINEERING EDUCATION (CEE)'))";

        public Enrollment()
        {
            InitializeComponent();
            listPrograms.SelectedIndex = 0;
            cboStudentProgram.SelectedIndex = 0;
        }

        private void Enrollment_Load(object? sender, EventArgs e) => LoadCourses();

        private void CboCourse_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (sender is not ComboBox combo) return;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color background = isSelected ? Color.FromArgb(233, 69, 96) : combo.BackColor;
            using var brush = new SolidBrush(background);
            e.Graphics.FillRectangle(brush, e.Bounds);
            if (e.Index >= 0)
            {
                string text = combo.GetItemText(combo.Items[e.Index]) ?? "";
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
                ApplyCourseProgramFilter();
            }
            catch (Exception ex) { ShowStatus("Could not load courses: " + ex.Message, Color.OrangeRed); }
        }

        private void CboCourse_Changed(object? sender, EventArgs e)
        {
            if (cboCourse.SelectedItem is not CourseChoice course) return;
            selectedCourseId = course.Id;
            studentViewStatus = "";
            try
            {
                LoadStudentProgramChoices();
                LoadAllStudents(); LoadEnrolledStudents();
            }
            catch (Exception ex) { ShowStatus("Could not load enrollment data: " + ex.Message, Color.OrangeRed); }
        }

        private void ListPrograms_Changed(object? sender, EventArgs e) => ApplyCourseProgramFilter();

        private void ApplyCourseProgramFilter()
        {
            int previousCourseId = selectedCourseId;
            string category = Convert.ToString(listPrograms.SelectedItem) ?? "All course programs";
            var matches = courses.Where(c => category == "All course programs" ||
                c.Program.Trim().Equals(category, StringComparison.OrdinalIgnoreCase)).ToArray();
            cboCourse.BeginUpdate();
            try
            {
                cboCourse.Items.Clear();
                cboCourse.Items.AddRange(matches);
                if (matches.Length > 0)
                {
                    int index = Array.FindIndex(matches, c => c.Id == previousCourseId);
                    cboCourse.SelectedIndex = index < 0 ? 0 : index;
                }
                else
                {
                    selectedCourseId = -1;
                    gridAll.DataSource = null;
                    gridEnrolled.DataSource = null;
                    lblEnrolledCount.Text = "Enrolled Students (0)";
                    studentViewStatus = "";
                    ResetStudentPrograms();
                    ShowStatus("No courses assigned to course program: " + category, TextGray);
                }
            }
            finally { cboCourse.EndUpdate(); }
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
            if (cboCourse.SelectedItem is CourseChoice course && course.Title.Trim().Equals("CEE", StringComparison.OrdinalIgnoreCase))
                status += " CEE: College of Engineering Education students only.";
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
                if (command.ExecuteNonQuery() == 0) { LoadAllStudents(); ShowStatus("Student is already enrolled or no longer eligible. CEE courses require College of Engineering Education students.", Color.DarkOrange); return; }
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
