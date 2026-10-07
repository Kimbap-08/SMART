using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMART
{
    public partial class AdminDashboard : Form
    {
        // Replace with your actual database connection string
        private string connectionString = DatabaseConnection.ConnectionString;

        public AdminDashboard()
        {
            InitializeComponent();
            LoadTotalStudentsCount();
            LoadActiveStudentsCount();
            LoadTotalInstructorsCount();
            LoadTotalCoursesCount();
        }

        private void LoadTotalCoursesCount()
        {
            // AdminCourses creates its table on the first visit.
            const string query = @"
                IF OBJECT_ID(N'dbo.Courses', N'U') IS NULL
                    SELECT 0;
                ELSE
                    SELECT COUNT(*) FROM dbo.Courses;";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);
            try
            {
                DatabaseConnection.Open(connection);
                lblTotalCoursesCount.Text = Convert.ToInt32(command.ExecuteScalar()).ToString();
            }
            catch (SqlException ex)
            {
                lblTotalCoursesCount.Text = "—";
                MessageBox.Show($"Error loading course count: {ex.Message}\n\nStartup diagnostics: {DatabaseConnection.DiagnosticPath}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalInstructorsCount()
        {
            // The instructor form creates this table on its first visit.
            const string query = @"
                IF OBJECT_ID(N'dbo.Instructors', N'U') IS NULL
                    SELECT 0;
                ELSE
                    SELECT COUNT(*) FROM dbo.Instructors;";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);
            try
            {
                DatabaseConnection.Open(connection);
                int totalCount = Convert.ToInt32(command.ExecuteScalar());
                lblTotalInstructorsCount.Text = totalCount.ToString();
            }
            catch (SqlException ex)
            {
                lblTotalInstructorsCount.Text = "—";
                MessageBox.Show($"Error loading instructor count: {ex.Message}\n\nStartup diagnostics: {DatabaseConnection.DiagnosticPath}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalStudentsCount()
        {
            string query = "SELECT COUNT(*) FROM Students";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DatabaseConnection.Open(conn);
                    int totalCount = Convert.ToInt32(cmd.ExecuteScalar());
                    lblTotalStudentsCount.Text = totalCount.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error loading student count: {ex.Message}\n\nStartup diagnostics: {DatabaseConnection.DiagnosticPath}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadActiveStudentsCount()
        {
            const string query = @"
                SELECT COUNT(*) FROM dbo.Students
                WHERE Status IS NULL
                    OR NULLIF(LTRIM(RTRIM(Status)), N'') IS NULL
                    OR UPPER(LTRIM(RTRIM(Status))) = N'ACTIVE';";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);
            try
            {
                DatabaseConnection.Open(connection);
                lblActiveStudentsCount.Text = Convert.ToInt32(command.ExecuteScalar()).ToString();
            }
            catch (SqlException ex)
            {
                lblActiveStudentsCount.Text = "—";
                MessageBox.Show($"Error loading active student count: {ex.Message}\n\nStartup diagnostics: {DatabaseConnection.DiagnosticPath}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
