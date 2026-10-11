using System.Data;
using System.Data.SqlClient;

namespace SMART
{
    public sealed class AdminArchive : Form
    {
        private readonly DataGridView studentsGrid = new();
        private readonly DataGridView instructorsGrid = new();
        private readonly TabControl archiveTabs = new();
        private readonly Label statusLabel = new();

        public event EventHandler? BackToStudentsRequested;

        public AdminArchive()
        {
            Text = "Admin Archive";
            BackColor = Color.FromArgb(22, 33, 62);
            ForeColor = Color.White;
            Padding = new Padding(24);
            BuildInterface();
            Shown += (_, _) => LoadArchivedRecords();
        }

        private void BuildInterface()
        {
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(0)
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Controls.Add(layout);

            var header = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                ColumnCount = 3,
                RowCount = 1,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            header.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            var backToStudents = new RoundedButton
            {
                Text = "← Students",
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                BackColor = Color.FromArgb(55, 62, 86),
                ForeColor = Color.White,
                BorderColor = Color.White,
                BorderRadius = 5,
                FlatStyle = FlatStyle.Flat
            };
            backToStudents.Click += (_, _) => BackToStudentsRequested?.Invoke(this, EventArgs.Empty);
            var title = new Label
            {
                Text = "Archive",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Bahnschrift", 22F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(16, 0, 0, 0)
            };
            var refresh = new RoundedButton
            {
                Text = "Refresh",
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 0),
                BackColor = Color.FromArgb(233, 69, 96),
                ForeColor = Color.White,
                BorderColor = Color.White,
                BorderRadius = 5,
                FlatStyle = FlatStyle.Flat
            };
            refresh.Click += (_, _) => LoadArchivedRecords();
            header.Controls.Add(backToStudents, 0, 0);
            header.Controls.Add(title, 1, 0);
            header.Controls.Add(refresh, 2, 0);
            layout.Controls.Add(header, 0, 0);

            statusLabel.Text = "Frozen student and instructor records are retained here.";
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.ForeColor = Color.FromArgb(200, 205, 218);
            statusLabel.Font = new Font("Bahnschrift Light", 10F);
            layout.Controls.Add(statusLabel, 0, 1);

            archiveTabs.Dock = DockStyle.Fill;
            archiveTabs.Font = new Font("Bahnschrift", 11F);
            archiveTabs.BackColor = Color.FromArgb(22, 33, 62);
            var studentPage = new TabPage("Students") { BackColor = Color.FromArgb(22, 33, 62), Padding = new Padding(8) };
            var instructorPage = new TabPage("Instructors") { BackColor = Color.FromArgb(22, 33, 62), Padding = new Padding(8) };
            ConfigureGrid(studentsGrid);
            ConfigureGrid(instructorsGrid);
            studentPage.Controls.Add(studentsGrid);
            instructorPage.Controls.Add(instructorsGrid);
            archiveTabs.TabPages.Add(studentPage);
            archiveTabs.TabPages.Add(instructorPage);
            layout.Controls.Add(archiveTabs, 0, 2);
        }

        private static void ConfigureGrid(DataGridView grid)
        {
            grid.Dock = DockStyle.Fill;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.FromArgb(22, 33, 62);
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(40, 52, 85);
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersHeight = 38;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 10F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 23, 42);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10F);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(75, 79, 91);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            grid.RowTemplate.Height = 36;
            grid.DataBindingComplete += (_, _) => { grid.ClearSelection(); grid.CurrentCell = null; };
        }

        private void LoadArchivedRecords()
        {
            try
            {
                using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
                DatabaseConnection.Open(connection);
                using (var schema = new SqlCommand(@"IF COL_LENGTH(N'dbo.Students', N'IsFrozen') IS NULL
                    ALTER TABLE dbo.Students ADD IsFrozen BIT NOT NULL CONSTRAINT DF_Students_IsFrozen DEFAULT (0);
                    IF COL_LENGTH(N'dbo.Instructors', N'IsFrozen') IS NULL
                    ALTER TABLE dbo.Instructors ADD IsFrozen BIT NOT NULL CONSTRAINT DF_Instructors_IsFrozen DEFAULT (0);", connection))
                    schema.ExecuteNonQuery();

                using var students = new SqlDataAdapter(@"SELECT StudentID AS [Student ID], StudentName AS [Full Name],
                    Program, Department, YearLevel AS [Year Level]
                    FROM dbo.Students WHERE IsFrozen=1 ORDER BY StudentName", connection);
                var archivedStudents = new DataTable();
                students.Fill(archivedStudents);
                studentsGrid.DataSource = archivedStudents;

                using var instructors = new SqlDataAdapter(@"SELECT EmployeeID AS [Employee ID], FullName AS [Full Name],
                    Program, Department, Username AS [Login Username], Email
                    FROM dbo.Instructors WHERE IsFrozen=1 ORDER BY FullName", connection);
                var archivedInstructors = new DataTable();
                instructors.Fill(archivedInstructors);
                instructorsGrid.DataSource = archivedInstructors;
                statusLabel.Text = $"Archived records: {archivedStudents.Rows.Count} student(s), {archivedInstructors.Rows.Count} instructor(s). Frozen records are retained here.";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, $"Could not load archived records: {ex.Message}", "Archive Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
