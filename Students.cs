using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private string selectedStudentId = "";
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=SMARTdb;Trusted_Connection=True;";

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
            "College of Teacher Education (CTE)"
        };

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

        public Students()
        {
            InitializeComponent();

           
            rTbDepartment.MouseUp += rTbDepartment_MouseUp;

            // 1. Placeholder Text Setup
            rTbDepartment.PlaceholderText = "Type or select department...";
            rTbProgram.PlaceholderText = "Type or select program...";

            // 2. Re-parent ListBoxes to Form root
            listDept.Parent = this;
            listProgram.Parent = this;

            // 3. Custom Dark Themes
            StyleDataGridView();
            StyleComboBox();
            StyleListBox(listDept);
            StyleListBox(listProgram);

            // 4. Align Search and Sort Bar Elements
            AlignSearchSortBar();
            this.Shown += (s, e) => AlignSearchSortBar();

            // 5. ComboBox Options
            cmbYear.Items.Clear();
            cmbYear.Items.AddRange(new string[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });

            // 6. Department & Program Field Events
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

            // 7. Input Validation (6-digit ID enforcement)
            rTbStudentName.KeyPress += rTbStudentName_KeyPress;
            rTbStudentID.KeyPress += rTbStudentID_KeyPress;
            rTbStudentID.TextChanged += rTbStudentID_TextChanged;

            // 8. Grid Selection, Update, and Delete Events
            dgvStudents.CellClick -= dgvStudents_CellClick;
            dgvStudents.CellClick += dgvStudents_CellClick;

            rBtnUpdate.Click -= rBtnUpdate_Click;
            rBtnUpdate.Click += rBtnUpdate_Click;

            rBtnDelete.Click -= rBtnDelete_Click;
            rBtnDelete.Click += rBtnDelete_Click;

            rTbDepartment.Enter += rTbDepartment_Enter;

            // 9. Load Initial Database Data
            LoadStudentData();
        }

        private void ShowDeptList()
        {
            string filter = rTbDepartment.Text.ToLower().Trim();

            var matches = string.IsNullOrWhiteSpace(filter)
                ? allDepartments.OrderBy(d => d).ToList()
                : allDepartments.Where(d => d.ToLower().Contains(filter)).OrderBy(d => d).ToList();

            if (matches.Count > 0)
            {
                listDept.DataSource = null;
                listDept.DataSource = matches;

                Point ptOnScreen = pnlDept.PointToScreen(new Point(0, pnlDept.Height + 2));
                Point ptOnForm = this.PointToClient(ptOnScreen);

                listDept.Left = ptOnForm.X;
                listDept.Top = ptOnForm.Y;

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

        private void listDept_Click(object sender, EventArgs e)
        {
            if (listDept.SelectedItem == null) return;

            string selectedDept = listDept.SelectedItem.ToString();
            rTbDepartment.Text = selectedDept;
            rTbProgram.Text = string.Empty;

            ShowProgramList(); // <-- THIS IS THE UPDATED ADDITION

            listDept.Visible = false;
        }

        private void listDept_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listDept.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && index != listDept.SelectedIndex)
            {
                listDept.SelectedIndex = index;
            }
        }

        private void ShowProgramList()
        {
            string selectedDept = rTbDepartment.Text.Trim();
            if (string.IsNullOrWhiteSpace(selectedDept) || !deptProgramsMap.ContainsKey(selectedDept))
            {
                listProgram.DataSource = null; // Clears old program items when department changes
                listProgram.Visible = false;
                return;
            }

            string filter = rTbProgram.Text.ToLower().Trim();
            var availablePrograms = deptProgramsMap[selectedDept];

            var matches = string.IsNullOrWhiteSpace(filter)
                ? availablePrograms.OrderBy(p => p).ToList()
                : availablePrograms.Where(p => p.ToLower().Contains(filter)).OrderBy(p => p).ToList();

            if (matches.Count > 0)
            {
                listProgram.DataSource = null;
                listProgram.DataSource = matches;

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
                listProgram.DataSource = null;
                listProgram.Visible = false;
            }
        }

        private void rTbDepartment_TextChanged(object sender, EventArgs e)
        {
            rTbProgram.Text = string.Empty;
            ShowDeptList();

            // 1. Clear the current program selection
            rTbProgram.Text = string.Empty;

            // 2. Reload or filter the program list based on the new department
            ShowProgramList();
        }

        private void rTbProgram_TextChanged(object sender, EventArgs e) => ShowProgramList();

        private void listProgram_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listProgram.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && index != listProgram.SelectedIndex)
            {
                listProgram.SelectedIndex = index;
            }
        }

        private void listProgram_Click(object sender, EventArgs e)
        {
            if (listProgram.SelectedItem != null)
            {
                string selectedProg = listProgram.SelectedItem.ToString();
                rTbProgram.Text = selectedProg;

                int textWidth = TextRenderer.MeasureText(selectedProg, rTbProgram.Font).Width;
                int finalWidth = Math.Max(textWidth + 30, 220);

                pnlProgram.Width = finalWidth;
                rTbProgram.Width = finalWidth;

                listProgram.Visible = false;
            }
        }

        private void rBtnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rTbStudentID.Text) || string.IsNullOrWhiteSpace(rTbStudentName.Text))
            {
                MessageBox.Show("Please fill in Student ID and Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            selectedStudentId = ""; // FIXED: Reset selected ID variable
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

                    dgvStudents.DataSource = dt;
                    dgvStudents.BringToFront();
                    dgvStudents.Visible = true;
                    dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvStudents.RowHeadersVisible = false;

                    if (dgvStudents.Columns["ID No."] != null) dgvStudents.Columns["ID No."].FillWeight = 12;
                    if (dgvStudents.Columns["Student Name"] != null) dgvStudents.Columns["Student Name"].FillWeight = 22;
                    if (dgvStudents.Columns["Program"] != null) dgvStudents.Columns["Program"].FillWeight = 23;
                    if (dgvStudents.Columns["Department"] != null) dgvStudents.Columns["Department"].FillWeight = 28;
                    if (dgvStudents.Columns["Year Level"] != null) dgvStudents.Columns["Year Level"].FillWeight = 10;
                    if (dgvStudents.Columns["Status"] != null) dgvStudents.Columns["Status"].FillWeight = 10;

                    dgvStudents.ClearSelection();
                    dgvStudents.CurrentCell = null;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error loading student data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rBtnName_Click(object sender, EventArgs e) => ExecuteSort(rBtnSortName, "Name", ref isNameAscending, "Student Name");
        private void rBtnSortID_Click(object sender, EventArgs e) => ExecuteSort(rBtnSortID, "ID No.", ref isIdAscending, "ID No.");
        private void rBtnSortYear_Click(object sender, EventArgs e) => ExecuteSort(rBtnSortYear, "Year", ref isYearAscending, "Year Level");

        private void ResetSortButtons()
        {
            Color defaultColor = Color.Transparent;

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

        private void ExecuteSort(Control activeButton, string baseText, ref bool isAscending, string columnName)
        {
            if (dgvStudents.DataSource is DataTable dt)
            {
                string direction = isAscending ? "ASC" : "DESC";
                string arrow = isAscending ? " ▲" : " ▼";

                dt.DefaultView.Sort = $"[{columnName}] {direction}";
                ResetSortButtons();

                activeButton.Text = baseText + arrow;
                activeButton.Size = expandedButtonSize;
                activeButton.BackColor = Color.FromArgb(233, 69, 96);

                isAscending = !isAscending;
            }
        }

        private void rBtnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudentData();
            ResetSortButtons();

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
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rTbStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsDigit(e.KeyChar) || rTbStudentID.Text.Length >= 6)
            {
                e.Handled = true;
            }
        }

        private void rTbStudentID_TextChanged(object sender, EventArgs e)
        {
            if (rTbStudentID.Text.Length > 6)
            {
                rTbStudentID.Text = rTbStudentID.Text.Substring(0, 6);
            }
        }

        private void StyleDataGridView()
        {
            dgvStudents.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudents.GridColor = Color.FromArgb(40, 52, 85);
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.RowHeadersVisible = false;

            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudents.ColumnHeadersHeight = 38;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvStudents.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            dgvStudents.DefaultCellStyle.ForeColor = Color.White;
            dgvStudents.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10.5F);
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvStudents.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

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

        private void cmbYear_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

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

            rBtnSearch.Left = currentX;
            rBtnSearch.Top = rTbSearchStudents.Top;
            currentX += rBtnSearch.Width + spacing;

            rBtnRefresh.Left = currentX;
            rBtnRefresh.Top = rTbSearchStudents.Top;
            currentX += rBtnRefresh.Width + 14;

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

            Font sortFont = new Font("Bahnschrift", 10F, FontStyle.Regular);
            int sortWidth = TextRenderer.MeasureText("Sort by:", sortFont).Width + 8;

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

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                // FIXED: Capture the selected student's ID for updates/deletes
                selectedStudentId = row.Cells[0].Value?.ToString();

                rTbStudentID.Text = selectedStudentId;
                rTbStudentName.Text = row.Cells[1].Value?.ToString();
                cmbYear.SelectedItem = row.Cells[4].Value?.ToString();

                rTbDepartment.Text = row.Cells[3].Value?.ToString();
                rTbProgram.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void rBtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedStudentId))
            {
                MessageBox.Show("Please select a student from the table to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStudentId = rTbStudentID.Text.Trim();
            string name = rTbStudentName.Text.Trim();
            string dept = rTbDepartment.Text.Trim();
            string program = rTbProgram.Text.Trim();
            string year = cmbYear.Text.Trim();

            if (string.IsNullOrWhiteSpace(newStudentId) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Student ID and Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"UPDATE Students 
                     SET StudentID = @NewStudentID,
                         StudentName = @StudentName, 
                         Program = @Program, 
                         Department = @Department, 
                         YearLevel = @YearLevel 
                     WHERE StudentID = @OldStudentID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewStudentID", newStudentId);
                    cmd.Parameters.AddWithValue("@OldStudentID", selectedStudentId);
                    cmd.Parameters.AddWithValue("@StudentName", name);
                    cmd.Parameters.AddWithValue("@Program", program);
                    cmd.Parameters.AddWithValue("@Department", dept);
                    cmd.Parameters.AddWithValue("@YearLevel", year);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("No matching student record found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rBtnDelete_Click(object sender, EventArgs e)
        {
            string studentId = rTbStudentID.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Please select a student from the table or enter a Student ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete student ID {studentId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            string query = "DELETE FROM Students WHERE StudentID = @StudentID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("No student record was found with that ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool needsSelectAll = false;

        private void rTbDepartment_Enter(object sender, EventArgs e)
        {
            // 1. Open the department list first
            ShowDeptList();

            // 2. Delay SelectAll until all mouse and list events finish
            this.BeginInvoke((MethodInvoker)delegate
            {
                rTbDepartment.SelectAll();
            });
        }

        private void rTbDepartment_MouseUp(object sender, MouseEventArgs e)
        {
            if (needsSelectAll)
            {
                rTbDepartment.SelectAll();
                needsSelectAll = false; // Prevents re-selecting every time you click inside
            }
        }


    }
}