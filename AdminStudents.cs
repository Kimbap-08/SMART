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
    public partial class AdminStudents : Form
    {
        private readonly Size defaultButtonSize = new Size(74, 40);
        private readonly Size expandedButtonSize = new Size(95, 40);

        private bool isNameAscending = true;
        private bool isIdAscending = true;
        private bool isYearAscending = true;
        private bool resizingFields;

        private string selectedStudentId = "";
        private string connectionString = DatabaseConnection.ConnectionString;

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

        public AdminStudents()
        {
            InitializeComponent();
            rTbProgram.Multiline = true;
            rTbDepartment.Multiline = true;

            // Load items in constructor so cmbYear is never empty at runtime
            cmbYear.Items.Clear();
            cmbYear.Items.AddRange(new string[] { "1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year" });

            rTbDepartment.PlaceholderText = "Department is set by program";
            rTbDepartment.ReadOnly = true;
            rTbDepartment.TabStop = false;
            rTbProgram.PlaceholderText = "Type or select program...";
            rTbProgram.TextChanged += (s, e) => ResizeProgramAndDepartment();
            rTbDepartment.TextChanged += (s, e) => ResizeProgramAndDepartment();
            rTbProgram.FontChanged += (s, e) => ResizeProgramAndDepartment();
            rTbDepartment.FontChanged += (s, e) => ResizeProgramAndDepartment();
            cPnlAddStudent.SizeChanged += (s, e) => ResizeProgramAndDepartment();
            Shown += (s, e) => ResizeProgramAndDepartment();
            ResizeProgramAndDepartment();

            listDept.Parent = this;
            listProgram.Parent = this;

            StyleDataGridView();
            StyleComboBox();
            StyleListBox(listDept);
            StyleListBox(listProgram);

            AlignSearchSortBar();
            this.Shown += (s, e) => AlignSearchSortBar();
            SizeChanged += (s, e) => AlignSearchSortBar();

            listDept.Visible = false;

            rTbProgram.Click += (s, e) => ShowProgramList();
            rTbProgram.Enter += (s, e) =>
            {
                ShowProgramList();
                this.BeginInvoke((MethodInvoker)(() => rTbProgram.SelectAll()));
            };

            rTbStudentID.Enter += (s, e) => this.BeginInvoke((MethodInvoker)(() => rTbStudentID.SelectAll()));
            rTbStudentName.Enter += (s, e) => this.BeginInvoke((MethodInvoker)(() => rTbStudentName.SelectAll()));

            listProgram.MouseMove += listProgram_MouseMove;
            listProgram.Click += listProgram_Click;

            rTbStudentName.KeyPress += rTbStudentName_KeyPress;
            rTbStudentID.KeyPress += rTbStudentID_KeyPress;
            rTbStudentID.TextChanged += rTbStudentID_TextChanged;

            // Wire up Search functionality
            rBtnSearch.Click += rBtnSearch_Click;
            rTbSearchStudents.TextChanged += rTbSearchStudents_TextChanged;
            rTbSearchStudents.KeyDown += rTbSearchStudents_KeyDown;

            dgvStudents.CellClick -= dgvStudents_CellClick;
            dgvStudents.CellClick += dgvStudents_CellClick;

            rBtnUpdate.Click -= rBtnUpdate_Click;
            rBtnUpdate.Click += rBtnUpdate_Click;

            rBtnDelete.Click -= rBtnDelete_Click;
            rBtnDelete.Click += rBtnDelete_Click;

            LoadStudentData();
        }

        private bool IsStudentIdExists(string studentId)
        {
            string query = "SELECT COUNT(1) FROM Students WHERE StudentID = @StudentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                try
                {
                    DatabaseConnection.Open(conn);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database Error during ID check: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private string GetDepartmentForProgram(string program)
        {
            if (string.IsNullOrWhiteSpace(program)) return string.Empty;

            foreach (var departmentPrograms in deptProgramsMap)
            {
                if (departmentPrograms.Value.Contains(program.Trim(), StringComparer.OrdinalIgnoreCase))
                    return departmentPrograms.Key;
            }

            return string.Empty;
        }

        private void ShowProgramList()
        {
            // ContainsFocus checks if either RoundedTextBox or its inner TextBox has focus
            if (!rTbProgram.ContainsFocus)
            {
                listProgram.Visible = false;
                return;
            }

            string filter = rTbProgram.Text.ToLower().Trim();
            var availablePrograms = deptProgramsMap.Values.SelectMany(programs => programs).Distinct(StringComparer.OrdinalIgnoreCase);

            var matches = string.IsNullOrWhiteSpace(filter)
                ? availablePrograms.OrderBy(p => p, StringComparer.CurrentCultureIgnoreCase).ToList()
                : availablePrograms
                    .Where(p => p.Contains(filter, StringComparison.CurrentCultureIgnoreCase))
                    .OrderBy(p => p, StringComparer.CurrentCultureIgnoreCase)
                    .ToList();

            if (matches.Count > 0)
            {
                listProgram.DataSource = null;
                listProgram.DataSource = matches;
                listProgram.SelectedIndex = -1; // Prevents initial red highlight on the first item

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

        private void rTbDepartment_TextChanged(object sender, EventArgs e) => listDept.Visible = false;

        private void rTbProgram_TextChanged(object sender, EventArgs e)
        {
            rTbDepartment.Text = GetDepartmentForProgram(rTbProgram.Text);
            ShowProgramList();
        }

        private void listProgram_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listProgram.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && index != listProgram.SelectedIndex)
            {
                // Check if the cursor itself is over the item rectangle
                if (listProgram.GetItemRectangle(index).Contains(e.Location))
                {
                    int top = listProgram.TopIndex;
                    listProgram.SelectedIndex = index;
                    listProgram.TopIndex = top; // Lock scroll position in place
                }
            }
        }

        private void listProgram_Click(object sender, EventArgs e)
        {
            if (listProgram.SelectedItem != null)
            {
                string selectedProg = listProgram.SelectedItem.ToString();
                rTbProgram.Text = selectedProg;

                ResizeProgramAndDepartment();

                listProgram.Visible = false;
            }
        }

        private void ResizeProgramAndDepartment()
        {
            if (resizingFields) return;
            resizingFields = true;
            try
            {
                cPnlAddStudent.SetBounds(12, pnlSearchSort.Bottom + 6,
                    Math.Max(300, ClientSize.Width - 24), cPnlAddStudent.Height);
                lblAddNewStudent.Location = new Point(12, 12);
                const int programWidth = 340;
                const int departmentWidth = 340;
                int rightEdge = cPnlAddStudent.ClientSize.Width - 20;
                int programLeft = 695;
                int fieldTop = 94;
                // Only the available window width can move this pair to another row.
                if (programLeft + programWidth + 64 + departmentWidth > rightEdge)
                {
                    programLeft = 10;
                    fieldTop = 154;
                }
                cPnlAddStudent.AutoScrollPosition = Point.Empty;
                int programHeight = rTbProgram.GetWrappedHeight(programWidth);
                int departmentHeight = rTbDepartment.GetWrappedHeight(departmentWidth);
                pnlProgram.SetBounds(programLeft, fieldTop, programWidth, programHeight + 6);
                rTbProgram.SetBounds(0, 3, programWidth, programHeight);
                lblProgram.Location = new Point(programLeft, fieldTop - 26);
                int departmentLeft = programLeft + programWidth + 64;
                pnlDept.SetBounds(departmentLeft, fieldTop, departmentWidth, departmentHeight + 6);
                rTbDepartment.SetBounds(0, 3, departmentWidth, departmentHeight);
                lblDepartment.Location = new Point(departmentLeft, fieldTop - 26);

                int buttonTop = Math.Max(221, Math.Max(pnlProgram.Bottom, pnlDept.Bottom) + 24);
                int buttonLeft = 10;
                RoundedButton[] buttons = { rBtnAddStudent, rBtnUpdate,
                    rBtnDelete, rBtnCancel, rBtnSetActive,
                    rBtnSetInactive, rBtnSetDropped };
                for (int index = 0; index < buttons.Length; index++)
                {
                    RoundedButton button = buttons[index];
                    int width = Math.Max(82, TextRenderer.MeasureText(button.Text, button.Font,
                        Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix).Width + 30);
                    if (index == 4) buttonLeft += 24;
                    if (buttonLeft > 10 && buttonLeft + width > rightEdge)
                    {
                        buttonLeft = 10;
                        buttonTop += 48;
                    }
                    button.SetBounds(buttonLeft, buttonTop, width, 40);
                    buttonLeft += width + 8;
                }
                // Very narrow windows can scroll the pair horizontally without
                // moving Department onto a separate line or clipping its text.
                int contentWidth = departmentLeft + departmentWidth + 20;
                bool needsScroll = contentWidth > cPnlAddStudent.ClientSize.Width;
                cPnlAddStudent.AutoScroll = needsScroll;
                cPnlAddStudent.AutoScrollMinSize = needsScroll ? new Size(contentWidth, 0) : Size.Empty;
                cPnlAddStudent.Height = buttonTop + 60 + (needsScroll ? SystemInformation.HorizontalScrollBarHeight : 0);
                int tableTop = cPnlAddStudent.Bottom + 9;
                dgvStudents.SetBounds(cPnlAddStudent.Left, tableTop, cPnlAddStudent.Width,
                    Math.Max(0, ClientSize.Height - tableTop - 15));
                if (listProgram.Visible) ShowProgramList();
            }
            finally { resizingFields = false; }
        }
        private void rBtnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rTbStudentID.Text) ||
                string.IsNullOrWhiteSpace(rTbStudentName.Text) ||
                string.IsNullOrWhiteSpace(rTbDepartment.Text) ||
                string.IsNullOrWhiteSpace(rTbProgram.Text) ||
                string.IsNullOrWhiteSpace(cmbYear.Text))
            {
                MessageBox.Show("Please fill in all fields (Student ID, Name, Department, Program, and Year Level) before adding a student.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentId = rTbStudentID.Text.Trim();

            if (IsStudentIdExists(studentId))
            {
                MessageBox.Show($"Student ID '{studentId}' already exists.", "Duplicate Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO Students (StudentID, StudentName, Program, Department, YearLevel, Status) 
                    VALUES (@StudentID, @StudentName, @Program, @Department, @YearLevel, @Status)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@StudentName", rTbStudentName.Text.Trim());
                cmd.Parameters.AddWithValue("@Program", rTbProgram.Text.Trim());
                cmd.Parameters.AddWithValue("@Department", rTbDepartment.Text.Trim());
                cmd.Parameters.AddWithValue("@YearLevel", cmbYear.Text.Trim());
                cmd.Parameters.AddWithValue("@Status", "Active");

                try
                {
                    DatabaseConnection.Open(conn);
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

        private void ClearForm()
        {
            rTbStudentID.Text = "";
            rTbStudentName.Text = "";
            rTbDepartment.Text = "";
            rTbProgram.Text = "";
            cmbYear.SelectedIndex = -1;
            selectedStudentId = "";

            listDept.Visible = false;
            listProgram.Visible = false;

            dgvStudents.ClearSelection();
            dgvStudents.CurrentCell = null;
        }

        private void LoadStudentData(string filter = "")
        {
            string query = @"SELECT StudentID AS [ID No.], StudentName AS [Student Name], Program, Department, YearLevel AS [Year Level], Status 
                     FROM Students";

            if (!string.IsNullOrWhiteSpace(filter))
            {
                query += @" WHERE StudentID LIKE @Filter 
                     OR StudentName LIKE @Filter 
                     OR Program LIKE @Filter 
                     OR Department LIKE @Filter 
                     OR YearLevel LIKE @Filter";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(filter))
                    {
                        cmd.Parameters.AddWithValue("@Filter", "%" + filter.Trim() + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    DatabaseConnection.Open(conn);
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

                    foreach (DataGridViewColumn col in dgvStudents.Columns)
                    {
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error loading student data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Search Event Handlers
        private void rBtnSearch_Click(object sender, EventArgs e)
        {
            LoadStudentData(rTbSearchStudents.Text);
        }

        private void rTbSearchStudents_TextChanged(object sender, EventArgs e)
        {
            LoadStudentData(rTbSearchStudents.Text);
        }

        private void rTbSearchStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent default Windows beep sound
                LoadStudentData(rTbSearchStudents.Text);
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

            AlignSearchSortBar();
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
                AlignSearchSortBar();
            }
        }

        private void rBtnRefresh_Click(object sender, EventArgs e)
        {
            rTbSearchStudents.Text = string.Empty;
            LoadStudentData();
            ResetSortButtons();

            isNameAscending = true;
            isIdAscending = true;
            isYearAscending = true;
        }

        private void Students_Load(object sender, EventArgs e)
        {
            cmbYear.Items.Clear();
            cmbYear.Items.AddRange(new string[] { "1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year" });

            ClearForm();
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
            // 1. Interaction & Edit Restrictions
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AllowUserToResizeRows = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;

            // 2. Table Colors & Border Styles
            dgvStudents.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudents.GridColor = Color.FromArgb(40, 52, 85);
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.RowHeadersVisible = false;

            // 3. Column Header Styles
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudents.ColumnHeadersHeight = 38;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStudents.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dgvStudents.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // 4. Default Cell Styles
            dgvStudents.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            dgvStudents.DefaultCellStyle.ForeColor = Color.White;
            dgvStudents.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10.5F);
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvStudents.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            // 5. Alternating Row Styles
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            dgvStudents.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvStudents.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvStudents.RowTemplate.Height = 36;

            // Automatically unhighlight rows every time data finishes binding
            dgvStudents.DataBindingComplete -= DgvStudents_DataBindingComplete;
            dgvStudents.DataBindingComplete += DgvStudents_DataBindingComplete;
            dgvStudents.CellFormatting -= DgvStudents_CellFormatting;
            dgvStudents.CellFormatting += DgvStudents_CellFormatting;
        }

        private void DgvStudents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dgvStudents.Columns[e.ColumnIndex].Name != "Status") return;

            string status = Convert.ToString(e.Value)?.Trim();
            if (string.IsNullOrWhiteSpace(status)) status = "Active";

            Color statusColor;
            switch (status)
            {
                case "Inactive":
                    statusColor = Color.DarkOrange;
                    break;
                case "Dropped":
                    statusColor = Color.Firebrick;
                    break;
                default:
                    status = "Active";
                    statusColor = Color.LimeGreen;
                    break;
            }

            e.Value = "● " + status;
            e.CellStyle.ForeColor = statusColor;
            e.CellStyle.SelectionForeColor = statusColor;
            e.FormattingApplied = true;
        }

        private void DgvStudents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStudents.ClearSelection();
            dgvStudents.CurrentCell = null;
        }

        private void StyleComboBox()
        {
            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.BackColor = Color.FromArgb(22, 33, 62);
            cmbYear.ForeColor = Color.White;
            cmbYear.Font = new Font("Bahnschrift Light", 10F);
            cmbYear.DrawMode = DrawMode.OwnerDrawFixed;
            cmbYear.ItemHeight = 24;

            cmbYear.DrawItem -= cmbYear_DrawItem;
            cmbYear.DrawItem += cmbYear_DrawItem;
        }

        private void cmbYear_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color bgColor = isSelected ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62);

            using (SolidBrush bgBrush = new SolidBrush(bgColor))
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);

                string itemText = cmbYear.Items[e.Index]?.ToString() ?? string.Empty;
                Font font = e.Font ?? cmbYear.Font;

                Size textSize = TextRenderer.MeasureText(itemText, font);
                int y = e.Bounds.Y + Math.Max(0, (e.Bounds.Height - textSize.Height) / 2);

                e.Graphics.DrawString(itemText, font, textBrush, new PointF(e.Bounds.X + 6, y));
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
            AdminPanelLayout.ArrangeToolbar(this, pnlHeaderInstructor, pnlSearchSort,
                rTbSearchStudents, lblSlash, lblSort,
                rTbSearchStudents, rBtnSearch, rBtnRefresh, lblSlash, lblSort, rBtnSortName, rBtnSortID, rBtnSortYear);
            ResizeProgramAndDepartment();
        }
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                selectedStudentId = row.Cells[0].Value?.ToString();

                rTbStudentID.Text = selectedStudentId;
                rTbStudentName.Text = row.Cells[1].Value?.ToString();

                // Set Department FIRST, then Program SECOND
                rTbDepartment.Text = row.Cells[3].Value?.ToString();
                rTbProgram.Text = row.Cells[2].Value?.ToString();

                // 1. Convert DB value ("Second") into standard string ("2nd Year")
                string rawYear = row.Cells[4].Value?.ToString() ?? "";
                string normalizedYear = NormalizeYearLevel(rawYear);

                // 2. Locate index in cmbYear items and select it directly
                int matchedIndex = cmbYear.FindStringExact(normalizedYear);
                if (matchedIndex >= 0)
                {
                    cmbYear.SelectedIndex = matchedIndex;
                }
                else
                {
                    cmbYear.SelectedIndex = cmbYear.FindString(normalizedYear);
                }
            }
        }

        private string NormalizeYearLevel(string rawYear)
        {
            if (string.IsNullOrWhiteSpace(rawYear)) return "1st Year";

            if (rawYear.Contains("1") || rawYear.IndexOf("First", StringComparison.OrdinalIgnoreCase) >= 0) return "1st Year";
            if (rawYear.Contains("2") || rawYear.IndexOf("Second", StringComparison.OrdinalIgnoreCase) >= 0) return "2nd Year";
            if (rawYear.Contains("3") || rawYear.IndexOf("Third", StringComparison.OrdinalIgnoreCase) >= 0) return "3rd Year";
            if (rawYear.Contains("4") || rawYear.IndexOf("Fourth", StringComparison.OrdinalIgnoreCase) >= 0) return "4th Year";
            if (rawYear.Contains("5") || rawYear.IndexOf("Fifth", StringComparison.OrdinalIgnoreCase) >= 0) return "5th Year";

            return rawYear;
        }


        private void rBtnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Ensure a student is selected
            if (string.IsNullOrWhiteSpace(selectedStudentId) || dgvStudents.CurrentRow == null || dgvStudents.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a student from the table to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Read current inputs from controls
            string newStudentId = rTbStudentID.Text.Trim();
            string name = rTbStudentName.Text.Trim();
            string dept = rTbDepartment.Text.Trim();
            string program = rTbProgram.Text.Trim();
            string year = cmbYear.Text.Trim();

            // 3. Validation Check - ensure no required fields are left blank
            if (string.IsNullOrWhiteSpace(newStudentId) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(dept) ||
                string.IsNullOrWhiteSpace(program) ||
                string.IsNullOrWhiteSpace(year))
            {
                MessageBox.Show("All student details (ID, Name, Department, Program, and Year Level) are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Extract original values to check if any changes were made
            DataGridViewRow row = dgvStudents.CurrentRow;
            string originalId = row.Cells["ID No."].Value?.ToString().Trim() ?? "";
            string originalName = row.Cells["Student Name"].Value?.ToString().Trim() ?? "";
            string originalProgram = row.Cells["Program"].Value?.ToString().Trim() ?? "";
            string originalDept = row.Cells["Department"].Value?.ToString().Trim() ?? "";
            string originalYear = NormalizeYearLevel(row.Cells["Year Level"].Value?.ToString() ?? "");

            if (newStudentId == originalId &&
                name == originalName &&
                dept == originalDept &&
                program == originalProgram &&
                year == originalYear)
            {
                MessageBox.Show("No changes were made to the student record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 5. Run SQL Update query
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

                    DatabaseConnection.Open(conn);
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

                    DatabaseConnection.Open(conn);
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

        private void ResetInputFieldsToSelectedRow()
        {
            if (dgvStudents.CurrentRow != null && dgvStudents.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvStudents.CurrentRow;

                rTbStudentName.Text = row.Cells["Student Name"].Value?.ToString() ?? "";
                rTbStudentID.Text = row.Cells["ID No."].Value?.ToString() ?? "";
                cmbYear.Text = row.Cells["Year Level"].Value?.ToString() ?? "";
                rTbDepartment.Text = row.Cells["Department"].Value?.ToString() ?? "";
                rTbProgram.Text = row.Cells["Program"].Value?.ToString() ?? "";
            }
            else
            {
                ClearInputFields();
            }
        }

        private void ClearInputFields()
        {
            rTbStudentName.Text = "";
            rTbStudentID.Text = "";
            cmbYear.SelectedIndex = -1; // Clears selection for ComboBox
            rTbDepartment.Text = "";
            rTbProgram.Text = "";
        }

        private void rBtnCancel_Click(object sender, EventArgs e)
        {
            ResetInputFieldsToSelectedRow();
        }

        private void rBtnSetActive_Click(object sender, EventArgs e)
        {
            SetSelectedStudentStatus("Active");
        }

        private void rBtnSetInactive_Click(object sender, EventArgs e)
        {
            SetSelectedStudentStatus("Inactive");
        }

        private void rBtnSetDropped_Click(object sender, EventArgs e)
        {
            SetSelectedStudentStatus("Dropped");
        }

        private void SetSelectedStudentStatus(string status)
        {
            DataGridViewRow row = dgvStudents.CurrentRow;
            string studentId = row?.Cells["ID No."].Value?.ToString()?.Trim() ?? selectedStudentId;
            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Select a student row first.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            const string query = "UPDATE Students SET Status = @Status WHERE StudentID = @StudentID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    DatabaseConnection.Open(conn);
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("The selected student could not be found.", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                LoadStudentData(rTbSearchStudents.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database Error while updating status: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
