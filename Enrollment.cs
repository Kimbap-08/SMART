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

        public Enrollment()
        {
            InitializeComponent();
        }

        private void Enrollment_Load(object? sender, EventArgs e) => LoadCourses();

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
