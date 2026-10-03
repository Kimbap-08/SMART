using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMART
{



    public partial class Students : Form
    {

        private readonly Size defaultButtonSize = new Size(74, 40);
        private readonly Size expandedButtonSize = new Size(95, 40); // Expanded width to fit arrows

        private bool isNameAscending = true;
        private bool isIdAscending = true;
        private bool isYearAscending = true;

        // 1. CLASS-LEVEL DATA (UM Main Colleges)
        private List<string> allDepartments = new List<string>
        {
            "College of Accounting Education (CAE)",
            "College of Architecture and Fine Arts Education (CAFAE)",
            "College of Arts and Sciences Education (CASE)",
            "College of Business Administration Education (CBAE)",
            "College of Computing Education (CCE)",
            "College of Criminal Justice Education (CCJE)",
            "College of Engineering Education (CEE)",
            "College of Health Sciences Education (CHSE)",
            "College of Hospitality Education (CHE)",
            "College of Legal Education (CLE)",
            "College of Teacher Education (CTE)"
        };

        public Students()
        {
            InitializeComponent();

            // 1. Re-parent ListBoxes to Form root (prevents panel clipping)
            listDept.Parent = this;
            listProgram.Parent = this;

            // 2. Custom Dark Themes
            StyleDataGridView();
            StyleComboBox();
            StyleListBox(listDept);
            StyleListBox(listProgram);

            // 3. Align Search and Sort Bar Elements
            AlignSearchSortBar();
            this.Shown += (s, e) => AlignSearchSortBar(); // Re-runs alignment after initial layout render

            // 4. ComboBox Options
            cmbYear.Items.Clear();
            cmbYear.Items.AddRange(new string[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });

            // 5. Department & Program Field Events
            listDept.DataSource = allDepartments.OrderBy(d => d).ToList();
            listDept.Visible = false;
            listDept.Click += listDept_Click;
            listDept.MouseMove += listDept_MouseMove;
            rTbDepartment.TextChanged += rTbDepartment_TextChanged;
            rTbDepartment.Click += (s, e) => ShowDeptList();
            rTbDepartment.Enter += (s, e) => ShowDeptList();

            rTbProgram.TextChanged += rTbProgram_TextChanged;
            rTbProgram.Click += (s, e) => ShowProgramList();
            rTbProgram.Enter += (s, e) => ShowProgramList();
            listProgram.MouseMove += listProgram_MouseMove;
            listProgram.Click += listProgram_Click;

            // 6. Input Validation (Letters for Name, Max 5 Digits for ID)
            rTbStudentName.KeyPress += rTbStudentName_KeyPress;
            rTbStudentID.KeyPress += rTbStudentID_KeyPress;
            rTbStudentID.TextChanged += rTbStudentID_TextChanged;

            // 7. Data Load
            LoadStudentData();

        }

        private void ShowDeptList()
        {
            string filter = rTbDepartment.Text.ToLower().Trim();

            // Always sort alphabetically (full list when empty, filtered list when typing)
            var matches = string.IsNullOrWhiteSpace(filter)
                ? allDepartments.OrderBy(d => d).ToList()
                : allDepartments.Where(d => d.ToLower().Contains(filter)).OrderBy(d => d).ToList();

            if (matches.Count > 0)
            {
                listDept.DataSource = null;
                listDept.DataSource = matches;

                // Map location relative to the main Form so cPnlAddStudent won't clip it
                Point ptOnScreen = pnlDept.PointToScreen(new Point(0, pnlDept.Height + 2));
                Point ptOnForm = this.PointToClient(ptOnScreen);

                listDept.Left = ptOnForm.X;
                listDept.Top = ptOnForm.Y;

                // Fit long department names & fixed 130px height (~5 visible rows + scrollbar)
                int maxTextWidth = matches.Max(m => TextRenderer.MeasureText(m, listDept.Font).Width);
                listDept.Width = Math.Max(pnlDept.Width, maxTextWidth + 35);
                listDept.Height = 130;

                listDept.Visible = true;
                listDept.BringToFront();
            }
            else
            {
                listDept.Visible = false;
            }
        }


        private void listDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDept.SelectedItem != null)
            {
                rTbDepartment.Text = listDept.SelectedItem.ToString();
                listDept.Visible = false; // Hide dropdown after selection
            }
        }

        private void listDept_Click(object sender, EventArgs e)
        {
            if (listDept.SelectedItem != null)
            {
                string selectedDept = listDept.SelectedItem.ToString();
                rTbDepartment.Text = selectedDept;

                // Measure text pixel width
                int textWidth = TextRenderer.MeasureText(selectedDept, rTbDepartment.Font).Width;

                // Calculate max allowed width before colliding with pnlProgram (leaves a 20px gap)
                int minWidth = 340;
                int maxWidth = pnlProgram.Left - pnlDept.Left - 20;
                int finalWidth = Math.Clamp(textWidth + 30, minWidth, maxWidth);

                // Apply bounded width
                pnlDept.Width = finalWidth;
                rTbDepartment.Width = finalWidth;

                listDept.Visible = false;
            }


        }

        private void listDept_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the item index directly under the mouse coordinates
            int index = listDept.IndexFromPoint(e.Location);

            // If the mouse is over a valid item and it isn't currently highlighted
            if (index != ListBox.NoMatches && index != listDept.SelectedIndex)
            {
                listDept.SelectedIndex = index;
            }
        }

        private Dictionary<string, List<string>> deptProgramsMap = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
{
    {
        "College of Accounting Education (CAE)", new List<string> {
            "BS in Accountancy",
            "BS in Accounting Information System",
            "BS in Management Accounting"
        }
    },
    {
        "College of Architecture and Fine Arts Education (CAFAE)", new List<string> {
            "BS in Architecture",
            "Bachelor of Fine Arts and Design (Painting)",
            "BS in Interior Design"
        }
    },
    {
        "College of Arts and Sciences Education (CASE)", new List<string> {
            "BA in Communication",
            "BA in English Language",
            "BA in Political Science",
            "BS in Agroforestry",
            "BS in Biology (Ecology)",
            "BS in Environmental Science",
            "BS in Forestry",
            "BS in Psychology",
            "BS in Social Work"
        }
    },
    {
        "College of Business Administration Education (CBAE)", new List<string> {
            "BSBA - Major in Business Economics",
            "BSBA - Major in Financial Management",
            "BSBA - Major in Human Resource Management",
            "BSBA - Major in Marketing Management",
            "BS in Customs Administration",
            "BS in Entrepreneurship",
            "BS in Legal Management",
            "BS in Real Estate Management"
        }
    },
    {
        "College of Computing Education (CCE)", new List<string> {
            "BS in Computer Science",
            "BS in Information Technology",
            "BS in Entertainment and Multimedia Computing",
            "Bachelor of Multimedia Arts",
            "Bachelor of Library and Information Science"
        }
    },
    {
        "College of Criminal Justice Education (CCJE)", new List<string> {
            "BS in Criminology"
        }
    },
    {
        "College of Engineering Education (CEE)", new List<string> {
            "BS in Chemical Engineering",
            "BS in Civil Engineering",
            "BS in Computer Engineering",
            "BS in Electrical Engineering",
            "BS in Electronics Engineering",
            "BS in Materials Engineering",
            "BS in Mechanical Engineering"
        }
    },
    {
        "College of Health Sciences Education (CHSE)", new List<string> {
            "BS in Medical Technology",
            "BS in Nursing",
            "BS in Nutrition and Dietetics",
            "BS in Pharmacy"
        }
    },
    {
        "College of Hospitality Education (CHE)", new List<string> {
            "BS in Hospitality Management",
            "BS in Tourism Management"
        }
    },
    {
        "College of Teacher Education (CTE)", new List<string> {
            "Bachelor of Elementary Education",
            "Bachelor of Physical Education",
            "BSEd - Major in English",
            "BSEd - Major in Filipino",
            "BSEd - Major in Mathematics",
            "BSEd - Major in Science",
            "BSEd - Major in Social Studies",
            "Bachelor of Special Needs Education"
        }
    }
};
        private void ShowProgramList()
        {
            string selectedDept = rTbDepartment.Text.Trim();
            if (string.IsNullOrWhiteSpace(selectedDept) || !deptProgramsMap.ContainsKey(selectedDept))
            {
                listProgram.Visible = false;
                return;
            }

            string filter = rTbProgram.Text.ToLower().Trim();
            var availablePrograms = deptProgramsMap[selectedDept];

            // Always sort alphabetically
            var matches = string.IsNullOrWhiteSpace(filter)
                ? availablePrograms.OrderBy(p => p).ToList()
                : availablePrograms.Where(p => p.ToLower().Contains(filter)).OrderBy(p => p).ToList();

            if (matches.Count > 0)
            {
                listProgram.DataSource = null;
                listProgram.DataSource = matches;

                // Map location relative to the main Form
                Point ptOnScreen = pnlProgram.PointToScreen(new Point(0, pnlProgram.Height + 2));
                Point ptOnForm = this.PointToClient(ptOnScreen);

                listProgram.Left = ptOnForm.X;
                listProgram.Top = ptOnForm.Y;

                int maxTextWidth = matches.Max(m => TextRenderer.MeasureText(m, listProgram.Font).Width);
                listProgram.Width = Math.Max(pnlProgram.Width, maxTextWidth + 35);
                listProgram.Height = 130;

                listProgram.Visible = true;
                listProgram.BringToFront();
            }
            else
            {
                listProgram.Visible = false;
            }
        }

        private void rTbDepartment_TextChanged(object sender, EventArgs e) => ShowDeptList();
        private void rTbProgram_TextChanged(object sender, EventArgs e) => ShowProgramList();

        private void listProgram_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listProgram.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && index != listProgram.SelectedIndex)
            {
                listProgram.SelectedIndex = index;
            }
        }

        // Click selection feature
        private void listProgram_Click(object sender, EventArgs e)
        {
            if (listProgram.SelectedItem != null)
            {
                string selectedProg = listProgram.SelectedItem.ToString();
                rTbProgram.Text = selectedProg;

                // Dynamically resize text box & container panel
                int textWidth = TextRenderer.MeasureText(selectedProg, rTbProgram.Font).Width;
                int finalWidth = Math.Max(textWidth + 30, 220);

                pnlProgram.Width = finalWidth;
                rTbProgram.Width = finalWidth;

                listProgram.Visible = false;
            }
        }

        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;";

        private void rBtnAddStudent_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(rTbStudentID.Text) || string.IsNullOrWhiteSpace(rTbStudentName.Text))
            {
                MessageBox.Show("Please fill in Student ID and Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // UPDATED: Added YearLevel to both the column list and VALUES list
            string query = @"INSERT INTO Students (StudentID, StudentName, Program, Department, YearLevel, Status) 
                    VALUES (@StudentID, @StudentName, @Program, @Department, @YearLevel, @Status)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", rTbStudentID.Text.Trim());
                    cmd.Parameters.AddWithValue("@StudentName", rTbStudentName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Program", rTbProgram.Text.Trim());
                    cmd.Parameters.AddWithValue("@Department", rTbDepartment.Text.Trim());
                    cmd.Parameters.AddWithValue("@YearLevel", cmbYear.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", DBNull.Value);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadStudentData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearForm()
        {
            rTbStudentID.Text = "";
            rTbStudentName.Text = "";
            rTbDepartment.Text = "";
            rTbProgram.Text = "";
            cmbYear.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadStudentData()
        {
            string query = "SELECT StudentID AS [ID No.], StudentName AS [Student Name], Program, Department, YearLevel AS [Year Level], Status FROM Students";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 1. Assign Data Source
                    dgvStudents.DataSource = dt;

                    // 2. Prevent grid hiding/layering issues
                    dgvStudents.BringToFront();
                    dgvStudents.Visible = true;

                    // 3. Enable full panel width layout & hide left indicator column
                    dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvStudents.RowHeadersVisible = false;

                    // 4. Set proportional FillWeights for balanced column width
                    if (dgvStudents.Columns["ID No."] != null)
                        dgvStudents.Columns["ID No."].FillWeight = 12;

                    if (dgvStudents.Columns["Student Name"] != null)
                        dgvStudents.Columns["Student Name"].FillWeight = 22;

                    if (dgvStudents.Columns["Program"] != null)
                        dgvStudents.Columns["Program"].FillWeight = 23;

                    if (dgvStudents.Columns["Department"] != null)
                        dgvStudents.Columns["Department"].FillWeight = 28;

                    if (dgvStudents.Columns["Year Level"] != null)
                        dgvStudents.Columns["Year Level"].FillWeight = 10;

                    if (dgvStudents.Columns["Status"] != null)
                        dgvStudents.Columns["Status"].FillWeight = 10;

                    dgvStudents.ClearSelection();
                    dgvStudents.CurrentCell = null;
                }
            
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error loading student data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rBtnName_Click(object sender, EventArgs e)
        {
            ExecuteSort(rBtnSortName, "Name", ref isNameAscending, "Student Name");
        }

        private void rBtnSortID_Click(object sender, EventArgs e)
        {
            ExecuteSort(rBtnSortID, "ID No.", ref isIdAscending, "ID No.");

        }

        private void rBtnSortYear_Click(object sender, EventArgs e)
        {
            ExecuteSort(rBtnSortYear, "Year", ref isYearAscending, "Year Level");
        }

        private void HighlightActiveSortButton(Control activeButton)
        {
            Color activeColor = Color.FromArgb(233, 69, 96);
            Color defaultColor = Color.Transparent;
            // Reset all sort buttons to transparent/default
            rBtnSortName.BackColor = defaultColor;
            rBtnSortID.BackColor = defaultColor;
            rBtnSortYear.BackColor = defaultColor;

            // Fill the active button with the accent color
            activeButton.BackColor = activeColor;
        }

        private void ResetSortButtons()
        {
            Color defaultColor = Color.Transparent; // Or Color.FromArgb(27, 34, 56) depending on your container background

            rBtnSortName.Text = "Name";
            rBtnSortName.Size = defaultButtonSize;
            rBtnSortName.BackColor = defaultColor;

            rBtnSortID.Text = "ID No.";
            rBtnSortID.Size = defaultButtonSize;
            rBtnSortID.BackColor = defaultColor;

            rBtnSortYear.Text = "Year";
            rBtnSortYear.Size = defaultButtonSize;
            rBtnSortYear.BackColor = defaultColor;
        }

        // Applies sorting, expands the active button, and toggles direction
        private void ExecuteSort(Control activeButton, string baseText, ref bool isAscending, string columnName)
        {
            if (dgvStudents.DataSource is DataTable dt)
            {
                string direction = isAscending ? "ASC" : "DESC";
                string arrow = isAscending ? " ▲" : " ▼";

                // Sort the DataGridView's DataTable
                dt.DefaultView.Sort = $"[{columnName}] {direction}";

                // Clear active states on all sort buttons
                ResetSortButtons();

                // Highlight and expand the clicked button with its arrow
                activeButton.Text = baseText + arrow;
                activeButton.Size = expandedButtonSize;
                activeButton.BackColor = Color.FromArgb(233, 69, 96);

                // Toggle state for the next click
                isAscending = !isAscending;
            }
        }

        private void rBtnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudentData();
            ResetSortButtons();

            // Reset toggle directions to default ascending
            isNameAscending = true;
            isIdAscending = true;
            isYearAscending = true;
        }

        private void Students_Load(object sender, EventArgs e)
        {
            cmbYear.Items.Clear();
            cmbYear.Items.AddRange(new string[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });

            StyleDataGridView();
            StyleComboBox();
        }

        private void rTbStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Reject digits (allows letters, spaces, hyphens, backspace, etc.)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Blocks the keypress
            }
        }

        // 2. Prevents non-digits & enforces 5-character limit for Student ID
        private void rTbStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (like Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Reject anything that is not a digit (letters, symbols, spaces)
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Limit maximum length to 5 characters
            if (rTbStudentID.Text.Length >= 5)
            {
                e.Handled = true;
            }
        }

        // 3. Safeguard against pasting text longer than 5 digits into Student ID
        private void rTbStudentID_TextChanged(object sender, EventArgs e)
        {
            if (rTbStudentID.Text.Length > 5)
            {
                rTbStudentID.Text = rTbStudentID.Text.Substring(0, 5);
            }
        }

        private void StyleDataGridView()
        {
            // General Table Appearance
            dgvStudents.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudents.GridColor = Color.FromArgb(40, 52, 85);
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.RowHeadersVisible = false;

            // Header Row Styling (Dark Navy Header Bar)
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudents.ColumnHeadersHeight = 38;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Default Row Styling
            dgvStudents.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            dgvStudents.DefaultCellStyle.ForeColor = Color.White;
            dgvStudents.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10.5F);
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96); // Accent pink selection
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvStudents.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            // Alternating Row Color (Dark Zebra Pattern)
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            dgvStudents.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvStudents.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvStudents.RowTemplate.Height = 36;
        }

        private void StyleComboBox()
        {
            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.BackColor = Color.FromArgb(22, 33, 62);
            cmbYear.ForeColor = Color.White;
            cmbYear.Font = new Font("Bahnschrift Light", 10F);
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.DrawMode = DrawMode.OwnerDrawFixed;
            cmbYear.ItemHeight = 24;

            cmbYear.DrawItem -= cmbYear_DrawItem;
            cmbYear.DrawItem += cmbYear_DrawItem;
        }

        // Custom owner-draw method for dark dropdown items
        private void cmbYear_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Check if the current item is hovered or focused
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color backColor = isSelected ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62);
            Color textColor = Color.White;

            using (SolidBrush bgBrush = new SolidBrush(backColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
                string text = cmbYear.Items[e.Index].ToString();
                e.Graphics.DrawString(text, cmbYear.Font, textBrush, e.Bounds.X + 6, e.Bounds.Y + 2);
            }
        }

        private void StyleListBox(ListBox listBox)
        {
            listBox.BackColor = Color.FromArgb(22, 33, 62);
            listBox.ForeColor = Color.White;
            listBox.BorderStyle = BorderStyle.FixedSingle;
            listBox.DrawMode = DrawMode.OwnerDrawFixed;

            // Allows custom exact heights without snap bugs
            listBox.IntegralHeight = false;
            listBox.ItemHeight = 26;
            listBox.Font = new Font("Bahnschrift Light", 10F);

            listBox.DrawItem -= ListBox_DrawItem;
            listBox.DrawItem += ListBox_DrawItem;
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            ListBox lb = (ListBox)sender;

            // Highlight hovered/selected items in accent pink
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color backColor = isSelected ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62);
            Color textColor = Color.White;

            using (SolidBrush bgBrush = new SolidBrush(backColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
                string text = lb.Items[e.Index].ToString();
                e.Graphics.DrawString(text, lb.Font, textBrush, e.Bounds.X + 8, e.Bounds.Y + 4);
            }
        }

        private void AlignSearchSortBar()
        {
            int spacing = 8;
            int currentX = rTbSearchStudents.Left + rTbSearchStudents.Width + 12;

            // 1. Search Button
            rBtnSearch.Left = currentX;
            rBtnSearch.Top = rTbSearchStudents.Top;
            currentX += rBtnSearch.Width + spacing;

            // 2. Refresh Button
            rBtnRefresh.Left = currentX;
            rBtnRefresh.Top = rTbSearchStudents.Top;
            currentX += rBtnRefresh.Width + 14;

            // 3. Separator Label (|)
            int pipeWidth = 14;
            lblSlash.AutoSize = false;
            lblSlash.Text = "|";
            lblSlash.Font = new Font("Bahnschrift", 11F, FontStyle.Regular);
            lblSlash.ForeColor = Color.DarkGray;
            lblSlash.BackColor = Color.Transparent;
            lblSlash.Size = new Size(pipeWidth, rBtnRefresh.Height);
            lblSlash.TextAlign = ContentAlignment.MiddleCenter;
            lblSlash.Left = currentX;
            lblSlash.Top = rBtnRefresh.Top;

            currentX += pipeWidth + 10;

            // 4. "Sort by:" Label (Explicit width calculation prevents 0px overlap)
            Font sortFont = new Font("Bahnschrift", 10F, FontStyle.Regular);
            int sortWidth = TextRenderer.MeasureText("Sort by:", sortFont).Width + 8; // ~58px

            lblSort.AutoSize = false;
            lblSort.Text = "Sort by:";
            lblSort.Font = sortFont;
            lblSort.ForeColor = Color.White;
            lblSort.BackColor = Color.Transparent;
            lblSort.Size = new Size(sortWidth, rBtnRefresh.Height);
            lblSort.TextAlign = ContentAlignment.MiddleCenter;
            lblSort.Left = currentX;
            lblSort.Top = rBtnRefresh.Top;

            currentX += sortWidth + 12;

            // 5. Sort Buttons (Name, ID No., Year)
            rBtnSortName.Left = currentX;
            rBtnSortName.Top = rBtnRefresh.Top;
            rBtnSortName.BringToFront();
            currentX += rBtnSortName.Width + spacing;

            rBtnSortID.Left = currentX;
            rBtnSortID.Top = rBtnRefresh.Top;
            rBtnSortID.BringToFront();
            currentX += rBtnSortID.Width + spacing;

            rBtnSortYear.Left = currentX;
            rBtnSortYear.Top = rBtnRefresh.Top;
            rBtnSortYear.BringToFront();
        }

    }
}
