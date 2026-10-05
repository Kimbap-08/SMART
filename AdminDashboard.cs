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

    }
}
