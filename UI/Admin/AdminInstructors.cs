using System.Data;
using System.Data.SqlClient;
using System.IO;
using SMART.NewFolder;

namespace SMART
{
    public partial class AdminInstructors : Form
    {
        private const string ConnectionString = DatabaseConnection.ConnectionString;
        private string? selectedEmployeeId;
        private string? selectedInstructorUsername;
        private string sortColumn = "Employee ID";
        private bool ascending = true;
        private bool refreshing;
        private bool selectingProgram;
        private bool resizingFields;
        private bool formattingEmployeeId;
        private readonly Label sortSeparator = new Label();
        private readonly Label lblFormTitle = new();
        private byte[]? _photoBytes;
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


        public AdminInstructors()
        {
            InitializeComponent();
            PhotoHelper.DrawDefaultProfile(pbPreview);
            rTbProgramInstructor.Multiline = true;
            rTbDepartmentInstructor.Multiline = true;
            rTbStudentID.PlaceholderText = "1234-56789";
            var employeeIdInput = rTbStudentID.Controls.OfType<TextBox>().Single();
            employeeIdInput.TextChanged += EmployeeIdInput_TextChanged;
            employeeIdInput.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && (e.KeyChar < '0' || e.KeyChar > '9'))
                    e.Handled = true;
            };
            employeeIdInput.KeyDown += (s, e) =>
            {
                // Backspace after the automatic separator removes the fourth digit too.
                if (e.KeyCode == Keys.Back && employeeIdInput.SelectionLength == 0 &&
                    employeeIdInput.SelectionStart == 5 && employeeIdInput.Text.Length >= 5 &&
                    employeeIdInput.Text[4] == '-')
                {
                    employeeIdInput.Select(3, 2);
                }
            };
            pnlSearchSortInstructor.Controls.Add(sortSeparator);
            AlignSearchSortBar();
            Shown += (s, e) => AlignSearchSortBar();
            SizeChanged += (s, e) => AlignSearchSortBar();
            StyleDataGridView();
            rTbSearchInstructor.PlaceholderText = "Search by Name, ID, Program, Department";
            rTbDepartmentInstructor.ReadOnly = true;
            rTbDepartmentInstructor.TabStop = false;
            rTbDepartmentInstructor.PlaceholderText = "Department is set by program";
            listDeptInstructor.Visible = false;
            listProgramInstructor.Visible = false;
            listProgramInstructor.Parent = this;
            StyleListBox(listDeptInstructor);
            StyleListBox(listProgramInstructor);
            listDeptInstructor.MouseMove += InstructorListBox_MouseMove;
            listProgramInstructor.MouseMove += InstructorListBox_MouseMove;
            rTbProgramInstructor.Enter += (s, e) => ShowPrograms();
            rTbProgramInstructor.TextChanged += (s, e) =>
            {
                rTbDepartmentInstructor.Text = DepartmentFor(rTbProgramInstructor.Text);
                ResizeProgramAndDepartment();
                if (!selectingProgram) ShowPrograms();
            };
            rTbDepartmentInstructor.TextChanged += (s, e) => ResizeProgramAndDepartment();
            rTbProgramInstructor.FontChanged += (s, e) => ResizeProgramAndDepartment();
            rTbDepartmentInstructor.FontChanged += (s, e) => ResizeProgramAndDepartment();
            cPnlAddInstructor.SizeChanged += (s, e) => ResizeProgramAndDepartment();
            Shown += (s, e) => ResizeProgramAndDepartment();
            ResizeProgramAndDepartment();
            rTbProgramInstructor.Leave += (s, e) => BeginInvoke((MethodInvoker)(() =>
            {
                if (!listProgramInstructor.ContainsFocus) listProgramInstructor.Visible = false;
            }));
            listProgramInstructor.Leave += (s, e) => listProgramInstructor.Visible = false;
            listProgramInstructor.MouseClick += ListProgramInstructor_MouseClick;
            listProgramInstructor.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { SelectProgram(); e.SuppressKeyPress = true; }
                if (e.KeyCode == Keys.Escape) { listProgramInstructor.Visible = false; e.SuppressKeyPress = true; }
            };
            rBtnAddInstructor.Click += (s, e) => SaveInstructor(false);
            rBtnUpdateInstructor.Click += (s, e) => SaveInstructor(true);
            rBtnDeleteInstructor.Click += (s, e) => DeleteInstructor();
            rBtnCancelInstructor.Click += (s, e) => RestoreSelection();
            rBtnSearchInstructor.Click += (s, e) => LoadInstructorData();
            rTbSearchInstructor.TextChanged += (s, e) => { if (!refreshing) LoadInstructorData(); };
            rTbSearchInstructor.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { LoadInstructorData(); e.SuppressKeyPress = true; }
            };
            rBtnRefreshInstructor.Click += (s, e) =>
            {
                refreshing = true;
                rTbSearchInstructor.Text = "";
                refreshing = false;
                sortColumn = "Employee ID";
                ascending = true;
                ResetSortButtons();
                LoadInstructorData();
            };
            rBtnSortNameInstructor.Click += (s, e) => Sort("Full Name", rBtnSortNameInstructor, "Name");
            rBtnSortIDInstructor.Click += (s, e) => Sort("Employee ID", rBtnSortIDInstructor, "ID No.");
            rBtnSortProgramInstructor.Click += (s, e) => Sort("Program", rBtnSortProgramInstructor, "Program");
            rBtnSortDeptInstructor.Click += (s, e) => Sort("Department", rBtnSortDeptInstructor, "Dept");
            dgvInstructors.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                selectedEmployeeId = Convert.ToString(dgvInstructors.Rows[e.RowIndex].Cells["Employee ID"].Value);
                RestoreSelection();
            };
            dgvInstructors.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvInstructors.IsCurrentCellDirty && dgvInstructors.CurrentCell is DataGridViewCheckBoxCell)
                    dgvInstructors.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            dgvInstructors.CellValueChanged += InstructorLoginEnabledChanged;
            Load += (s, e) => InitializeData();
        }

        private void EmployeeIdInput_TextChanged(object? sender, EventArgs e)
        {
            if (formattingEmployeeId || sender is not TextBox input || !input.Focused) return;

            string original = input.Text;
            int digitsBeforeCaret = original.Take(input.SelectionStart)
                .Count(c => c >= '0' && c <= '9');
            string digits = new string(original.Where(c => c >= '0' && c <= '9').Take(9).ToArray());
            string formatted = digits.Length >= 4 ? digits.Insert(4, "-") : digits;
            if (original == formatted) return;

            formattingEmployeeId = true;
            try
            {
                input.Text = formatted;
                int caret = Math.Min(digitsBeforeCaret, digits.Length);
                if (caret >= 4) caret++;
                input.Select(Math.Min(caret, formatted.Length), 0);
            }
            finally { formattingEmployeeId = false; }
        }

        private void InitializeData()
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                DatabaseConnection.Open(connection);
                InstructorAccountSchema.Initialize(connection);
                using (var photoSchema = new SqlCommand(@"IF COL_LENGTH(N'dbo.Instructors', N'Photo') IS NULL
                    ALTER TABLE dbo.Instructors ADD Photo VARBINARY(MAX) NULL;", connection))
                    photoSchema.ExecuteNonQuery();
                LoadInstructorData();
            }
            catch (SqlException ex) { DatabaseError(ex); }
        }

        private void PbPreview_Paint(object? sender, PaintEventArgs e)
        {
            using var pen = new Pen(Color.FromArgb(233, 69, 96), 2);
            e.Graphics.DrawRectangle(pen, 1, 1, pbPreview.Width - 3, pbPreview.Height - 3);
        }

        private string DepartmentFor(string program) => deptProgramsMap.FirstOrDefault(
            pair => pair.Value.Contains(program.Trim(), StringComparer.OrdinalIgnoreCase)).Key ?? "";

        private void ConfigureCompactLayout()
        {
            cPnlAddInstructor.Controls.Remove(instructorFieldsLayout);
            foreach (var control in new Control[]
            {
                lblInstructorName, rTbInstructorName, lblEmployeeNumber, rTbStudentID,
                lblProgramInstructor, rTbProgramInstructor, lblDepartmentInstructor, rTbDepartmentInstructor,
                lblLoginUsername, txtLoginUsername, lblLoginPassword, txtLoginPassword,
                lblInstructorEmail, txtInstructorEmail
            })
            {
                control.Parent?.Controls.Remove(control);
                control.Dock = DockStyle.None;
                cPnlAddInstructor.Controls.Add(control);
            }

            instructorActions.Parent?.Controls.Remove(instructorActions);
            foreach (var button in new[] { rBtnAddInstructor, rBtnUpdateInstructor, rBtnDeleteInstructor, rBtnCancelInstructor })
            {
                instructorActions.Controls.Remove(button);
                button.Dock = DockStyle.None;
                button.Margin = Padding.Empty;
                button.Height = 36;
                button.Font = new Font("Segoe UI", 9F);
                Controls.Add(button);
            }
            rBtnAddInstructor.SetBounds(15, 0, 140, 36);
            rBtnAddInstructor.BackColor = Color.FromArgb(0, 170, 0);
            rBtnUpdateInstructor.SetBounds(165, 0, 100, 36);
            rBtnUpdateInstructor.BackColor = Color.FromArgb(0, 140, 200);
            rBtnDeleteInstructor.SetBounds(275, 0, 100, 36);
            rBtnDeleteInstructor.BackColor = Color.FromArgb(233, 69, 96);
            rBtnCancelInstructor.SetBounds(385, 0, 100, 36);
            rBtnCancelInstructor.BackColor = Color.FromArgb(60, 60, 80);

            lblFormTitle.Text = "+ Add New Instructor";
            lblFormTitle.Location = new Point(105, 6);
            lblFormTitle.AutoSize = true;
            lblFormTitle.BackColor = Color.Transparent;
            lblFormTitle.ForeColor = Color.FromArgb(233, 69, 96);
            lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cPnlAddInstructor.Controls.Add(lblFormTitle);

            DrawPhotoInitials();

            foreach (var label in new[] { lblInstructorName, lblEmployeeNumber, lblProgramInstructor,
                lblDepartmentInstructor, lblLoginUsername, lblLoginPassword, lblInstructorEmail })
            {
                label.Dock = DockStyle.None;
                label.AutoSize = true;
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.FromArgb(150, 150, 170);
                label.Font = new Font("Segoe UI", 8F);
            }
            lblInstructorName.Text = "Full Name";
            lblEmployeeNumber.Text = "Employee ID";
            lblProgramInstructor.Text = "Program";
            lblDepartmentInstructor.Text = "Department";
            lblLoginUsername.Text = "Username";
            lblLoginPassword.Text = "Password";

            PlaceField(lblInstructorName, rTbInstructorName, 105, 26, 105, 42, 390);
            PlaceField(lblEmployeeNumber, rTbStudentID, 510, 26, 510, 42, 200);
            PlaceField(lblProgramInstructor, rTbProgramInstructor, 105, 82, 105, 98, 280);
            PlaceField(lblDepartmentInstructor, rTbDepartmentInstructor, 400, 82, 400, 98, 310);
            PlaceField(lblLoginUsername, txtLoginUsername, 105, 138, 105, 154, 155);
            PlaceField(lblLoginPassword, txtLoginPassword, 275, 138, 275, 154, 155);
            PlaceField(lblInstructorEmail, txtInstructorEmail, 445, 138, 445, 154, 265);

            rTbInstructorName.PlaceholderText = "First Name, M.I., Surname";
            rTbStudentID.PlaceholderText = "0000-00000";
            rTbDepartmentInstructor.PlaceholderText = "Set by program";
            rTbDepartmentInstructor.ReadOnly = true;
            rTbDepartmentInstructor.TabStop = false;
            rTbProgramInstructor.PlaceholderText = "Select Program";
            txtInstructorEmail.PlaceholderText = "email@domain.com";
            txtLoginPassword.UseSystemPasswordChar = true;
            cPnlAddInstructor.Padding = Padding.Empty;
            cPnlAddInstructor.BackColor = Color.FromArgb(22, 33, 62);
            cPnlAddInstructor.Height = 215;
        }

        private void DrawPhotoInitials() => PhotoHelper.DrawDefaultProfile(pbPreview);

        private static void PlaceField(Label label, Control field, int labelX, int labelY,
            int fieldX, int fieldY, int width)
        {
            label.Location = new Point(labelX, labelY);
            field.Location = new Point(fieldX, fieldY);
            field.Size = new Size(width, 32);
        }

        private void ShowPrograms()
        {
            if (!rTbProgramInstructor.ContainsFocus) { listProgramInstructor.Visible = false; return; }
            var matches = deptProgramsMap.Values.SelectMany(p => p)
                .Where(p => p.Contains(rTbProgramInstructor.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                .OrderBy(p => p).ToList();
            listProgramInstructor.DataSource = matches;
            listProgramInstructor.SelectedIndex = -1;
            listProgramInstructor.Location = PointToClient(rTbProgramInstructor.PointToScreen(new Point(0, rTbProgramInstructor.Height + 2)));
            listProgramInstructor.Width = Math.Max(rTbProgramInstructor.Width,
                matches.Count == 0 ? 0 : matches.Max(p => TextRenderer.MeasureText(p, listProgramInstructor.Font).Width) + 35);
            listProgramInstructor.Height = 130;
            listProgramInstructor.Visible = matches.Count > 0;
            listProgramInstructor.BringToFront();
        }

        private void SelectProgram()
        {
            if (listProgramInstructor.SelectedItem is not string program) return;
            selectingProgram = true;
            rTbProgramInstructor.Text = program;
            selectingProgram = false;
            ResizeProgramAndDepartment();
            listProgramInstructor.Visible = false;
        }

        private void ResizeProgramAndDepartment()
        {
            if (resizingFields) return;
            resizingFields = true;
            try
            {
                cPnlAddInstructor.SetBounds(12, pnlSearchSortInstructor.Bottom + 6,
                    Math.Max(300, ClientSize.Width - 24), cPnlAddInstructor.Height);
                instructorFieldsLayout.PerformLayout();
                int programHeight = rTbProgramInstructor.GetWrappedHeight(rTbProgramInstructor.Width);
                int departmentHeight = rTbDepartmentInstructor.GetWrappedHeight(rTbDepartmentInstructor.Width);
                rTbProgramInstructor.Height = programHeight;
                rTbDepartmentInstructor.Height = departmentHeight;
                int academicRowHeight = Math.Max(programHeight, departmentHeight) + 42;
                instructorFieldsLayout.RowStyles[2].Height = academicRowHeight;
                cPnlAddInstructor.Height = instructorFieldsLayout.Padding.Vertical +
                    (int)Math.Ceiling(instructorFieldsLayout.RowStyles.Cast<RowStyle>().Sum(row => row.Height));
                int tableTop = cPnlAddInstructor.Bottom + 9;
                dgvInstructors.SetBounds(cPnlAddInstructor.Left, tableTop, cPnlAddInstructor.Width,
                    Math.Max(0, ClientSize.Height - tableTop - 15));
                if (listProgramInstructor.Visible) ShowPrograms();
            }
            finally { resizingFields = false; }
        }
        private void InstructorListBox_MouseMove(object? sender, MouseEventArgs e)
        {
            if (sender is not ListBox listBox) return;
            int index = listBox.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches || index == listBox.SelectedIndex ||
                !listBox.GetItemRectangle(index).Contains(e.Location)) return;

            int topIndex = listBox.TopIndex;
            listBox.SelectedIndex = index;
            listBox.TopIndex = topIndex;
        }

        private void ListProgramInstructor_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            int index = listProgramInstructor.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches ||
                !listProgramInstructor.GetItemRectangle(index).Contains(e.Location)) return;

            listProgramInstructor.SelectedIndex = index;
            SelectProgram();
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
            listBox.DrawItem += InstructorListBox_DrawItem;
        }

        private void InstructorListBox_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (sender is not ListBox listBox || e.Index < 0 || e.Index >= listBox.Items.Count) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            Color background = selected ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62);
            using var backgroundBrush = new SolidBrush(background);
            using var textBrush = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            e.Graphics.DrawString(Convert.ToString(listBox.Items[e.Index]) ?? "",
                listBox.Font, textBrush, e.Bounds.X + 8, e.Bounds.Y + 4);
        }

        private void LoadInstructorData()
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                using var command = new SqlCommand(@"SELECT EmployeeID AS [Employee ID], FullName AS [Full Name],
                    Program, Department, Username AS [Login Username], IsActive AS [Login Enabled],
                    Email FROM dbo.Instructors
                    WHERE @Filter = N'' OR EmployeeID LIKE @Pattern OR FullName LIKE @Pattern
                        OR Program LIKE @Pattern OR Department LIKE @Pattern OR Username LIKE @Pattern OR Email LIKE @Pattern", connection);
                command.Parameters.AddWithValue("@Filter", rTbSearchInstructor.Text.Trim());
                command.Parameters.AddWithValue("@Pattern", "%" + rTbSearchInstructor.Text.Trim() + "%");
                using var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                DatabaseConnection.Open(connection);
                adapter.Fill(table);
                table.DefaultView.Sort = $"[{sortColumn}] {(ascending ? "ASC" : "DESC")}";
                dgvInstructors.DataSource = table;
                float[] weights = { 12, 20, 20, 24, 15, 10, 18 };
                for (int i = 0; i < dgvInstructors.Columns.Count; i++)
                {
                    dgvInstructors.Columns[i].FillWeight = weights[i];
                    dgvInstructors.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvInstructors.Columns[i].ReadOnly = true;
                }
                dgvInstructors.ReadOnly = false;
                dgvInstructors.Columns["Login Enabled"].ReadOnly = false;
                ClearForm();
            }
            catch (SqlException ex) { DatabaseError(ex); }
        }

        private void InstructorLoginEnabledChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                dgvInstructors.Columns[e.ColumnIndex].Name != "Login Enabled") return;

            string employeeId = Convert.ToString(dgvInstructors.Rows[e.RowIndex].Cells["Employee ID"].Value) ?? "";
            bool isActive = Convert.ToBoolean(dgvInstructors.Rows[e.RowIndex].Cells["Login Enabled"].Value);
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                using var command = new SqlCommand(
                    "UPDATE dbo.Instructors SET IsActive = @IsActive WHERE EmployeeID = @EmployeeID", connection);
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;
                command.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 50).Value = employeeId;
                DatabaseConnection.Open(connection);
                if (command.ExecuteNonQuery() == 0)
                    throw new InvalidOperationException("The instructor record could not be found.");

                MessageBox.Show(isActive
                    ? "Instructor login enabled."
                    : "Instructor login disabled. The instructor can no longer sign in.",
                    "Instructor Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not update instructor login status: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadInstructorData();
            }
        }

        private void SaveInstructor(bool updating)
        {
            if (updating && string.IsNullOrEmpty(selectedEmployeeId))
            {
                MessageBox.Show("Select an instructor from the table to update.", "Validation");
                return;
            }
            string id = rTbStudentID.Text.Trim();
            string name = rTbInstructorName.Text.Trim();
            string program = rTbProgramInstructor.Text.Trim();
            string department = DepartmentFor(program);
            if (id.Length == 0 || name.Length == 0 || department.Length == 0)
            {
                MessageBox.Show("Enter an Employee ID and Full Name, and select a valid Program.", "Validation");
                return;
            }
            if (id.Length != 10 || id[4] != '-' ||
                id.Where((c, index) => index != 4).Any(c => c < '0' || c > '9'))
            {
                MessageBox.Show("Employee ID must contain 4 digits, a hyphen, and 5 digits (e.g. 1234-56789).", "Validation");
                return;
            }
            if (name.Length > 100)
            {
                MessageBox.Show("Full Name must be at most 100 characters.", "Validation");
                return;
            }
            try
            {
                if (EmployeeIdExists(id, updating ? selectedEmployeeId : null))
                {
                    MessageBox.Show("That Employee ID already exists. Use a unique Employee ID.", "Duplicate Employee ID");
                    return;
                }
            }
            catch (SqlException ex) { DatabaseError(ex); return; }
            string username = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text;
            string email = txtInstructorEmail.Text.Trim();
            bool passwordRequired = !updating || string.IsNullOrWhiteSpace(selectedInstructorUsername);
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[A-Za-z0-9_.]{3,30}$") ||
                username.Equals("admin", StringComparison.OrdinalIgnoreCase) ||
                username.Equals("administrator", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Enter a unique username (3–30 letters, numbers, dots, or underscores).", "Invalid username");
                txtLoginUsername.Focus();
                return;
            }
            if (passwordRequired && password.Length < 8 || password.Length > 0 && password.Length < 8)
            {
                MessageBox.Show("Enter a password of at least 8 characters.", "Invalid password");
                txtLoginPassword.Focus();
                return;
            }
            if (email.Length == 0 || email.Length > 254 || !System.Text.RegularExpressions.Regex.IsMatch(email,
                @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
            {
                MessageBox.Show("Enter a valid email address.", "Invalid email");
                txtInstructorEmail.Focus();
                return;
            }
            string passwordHash = password.Length == 0 ? "" : PasswordHasher.Hash(password);
            string query = updating
                ? @"UPDATE dbo.Instructors SET EmployeeID = @ID, FullName = @Name,
                    Program = @Program, Department = @Department, Email = @Email, Username = @Username,
                    PasswordHash = CASE WHEN @PasswordHash = N'' THEN PasswordHash ELSE @PasswordHash END
                    WHERE EmployeeID = @OriginalID"
                : @"INSERT INTO dbo.Instructors
                    (EmployeeID, FullName, Program, Department, Email, Username, PasswordHash, IsActive)
                    VALUES (@ID, @Name, @Program, @Department, @Email, @Username, @PasswordHash, 1)";
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                using var command = new SqlCommand(query, connection);
                command.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = name;
                command.Parameters.Add("@Program", SqlDbType.NVarChar, 150).Value = program;
                command.Parameters.Add("@Department", SqlDbType.NVarChar, 150).Value = department;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 254).Value = email;
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = username;
                command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 200).Value = passwordHash;
                if (updating) command.Parameters.Add("@OriginalID", SqlDbType.NVarChar, 50).Value = selectedEmployeeId!;
                DatabaseConnection.Open(connection);
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("The instructor record could not be found. Refresh and try again.", "Record Not Found");
                    return;
                }
                LoadInstructorData();
                string message = updating ? "Instructor updated." : "Instructor account created.";
                message += $"\n\nUsername: {username}";
                if (password.Length > 0) message += $"\nPassword: {password}";
                MessageBox.Show(message, "Instructor Login Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show("That Employee ID or login username already exists. Choose a unique value.", "Duplicate Instructor");
            }
            catch (SqlException ex) { DatabaseError(ex); }
        }

        private static bool EmployeeIdExists(string employeeId, string? originalId)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = new SqlCommand(@"SELECT COUNT(*) FROM dbo.Instructors
                WHERE EmployeeID = @ID AND (@OriginalID IS NULL OR EmployeeID <> @OriginalID)", connection);
            command.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = employeeId;
            command.Parameters.Add("@OriginalID", SqlDbType.NVarChar, 50).Value = (object?)originalId ?? DBNull.Value;
            DatabaseConnection.Open(connection);
            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }

        private void DeleteInstructor()
        {
            string id = selectedEmployeeId ?? rTbStudentID.Text.Trim();
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Select an instructor or enter an Employee ID to delete.", "Validation");
                return;
            }
            if (MessageBox.Show($"Delete instructor with Employee ID {id}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            ExecuteChange("DELETE FROM dbo.Instructors WHERE EmployeeID = @ID",
                command => command.Parameters.AddWithValue("@ID", id), "Instructor deleted successfully.");
        }

        private void ExecuteChange(string query, Action<SqlCommand> parameters, string message)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                using var command = new SqlCommand(query, connection);
                parameters(command);
                DatabaseConnection.Open(connection);
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("The instructor record could not be found. Refresh and try again.", "Record Not Found");
                    return;
                }
                LoadInstructorData();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show("That Employee ID already exists. Use a unique Employee ID.", "Duplicate Employee ID");
            }
            catch (SqlException ex) { DatabaseError(ex); }
        }

        private void RestoreSelection()
        {
            var row = dgvInstructors.Rows.Cast<DataGridViewRow>().FirstOrDefault(r =>
                Convert.ToString(r.Cells["Employee ID"].Value) == selectedEmployeeId);
            if (row == null) { ClearForm(); return; }
            rTbStudentID.Text = Convert.ToString(row.Cells["Employee ID"].Value) ?? "";
            rTbInstructorName.Text = Convert.ToString(row.Cells["Full Name"].Value) ?? "";
            rTbProgramInstructor.Text = Convert.ToString(row.Cells["Program"].Value) ?? "";
            rTbDepartmentInstructor.Text = Convert.ToString(row.Cells["Department"].Value) ?? "";
            selectedInstructorUsername = Convert.ToString(row.Cells["Login Username"].Value);
            txtLoginUsername.Text = selectedInstructorUsername ?? "";
            txtInstructorEmail.Text = Convert.ToString(row.Cells["Email"].Value) ?? "";
            txtLoginPassword.Text = "";
            LoadSelectedInstructorPhoto(selectedEmployeeId!, rTbInstructorName.Text);
            listProgramInstructor.Visible = false;
        }

        private void LoadSelectedInstructorPhoto(string employeeId, string fullName)
        {
            _photoBytes = null;
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                using var command = new SqlCommand("SELECT Photo FROM dbo.Instructors WHERE EmployeeID = @id", connection);
                command.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = employeeId;
                DatabaseConnection.Open(connection);
                var value = command.ExecuteScalar();
                _photoBytes = value == null || value == DBNull.Value ? null : (byte[])value;
                PhotoHelper.LoadPhoto(pbPreview, _photoBytes, fullName);
            }
            catch (SqlException ex) { DatabaseError(ex); }
        }

        private void ClearForm()
        {
            _photoBytes = null;
            PhotoHelper.DrawDefaultProfile(pbPreview);
            selectedEmployeeId = null;
            selectedInstructorUsername = null;
            txtLoginUsername.Text = "";
            txtLoginPassword.Text = "";
            txtInstructorEmail.Text = "";
            rTbStudentID.Text = "";
            rTbInstructorName.Text = "";
            rTbProgramInstructor.Text = "";
            rTbDepartmentInstructor.Text = "";
            listProgramInstructor.Visible = false;
            dgvInstructors.ClearSelection();
            dgvInstructors.CurrentCell = null;
        }

        private void AlignSearchSortBar()
        {
            AdminPanelLayout.ArrangeToolbar(this, pnlHeaderInstructorMgt, pnlSearchSortInstructor,
                rTbSearchInstructor, sortSeparator, lblSortInstructor,
                rTbSearchInstructor, rBtnSearchInstructor, rBtnRefreshInstructor, sortSeparator, lblSortInstructor, rBtnSortNameInstructor, rBtnSortIDInstructor, rBtnSortDeptInstructor, rBtnSortProgramInstructor);
            ResizeProgramAndDepartment();
        }
        private void ResetSortButtons()
        {
            rBtnSortNameInstructor.Text = "Name";
            rBtnSortIDInstructor.Text = "ID No.";
            rBtnSortProgramInstructor.Text = "Program";
            rBtnSortDeptInstructor.Text = "Dept";
            rBtnSortNameInstructor.Size = new Size(74, 40);
            rBtnSortIDInstructor.Size = new Size(74, 40);
            rBtnSortDeptInstructor.Size = new Size(74, 40);
            rBtnSortProgramInstructor.Size = new Size(90, 40);
            foreach (RoundedButton sortButton in new[] { rBtnSortNameInstructor, rBtnSortIDInstructor,
                rBtnSortDeptInstructor, rBtnSortProgramInstructor })
            {
                sortButton.Width = Math.Max(sortButton.Width, TextRenderer.MeasureText(sortButton.Text,
                    sortButton.Font, Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix).Width + 30);
                sortButton.BackColor = Color.FromArgb(22, 33, 62);
                sortButton.HoverColor = Color.Empty;
                sortButton.PressedColor = Color.Empty;
            }
            AlignSearchSortBar();
        }

        private void Sort(string column, Button button, string label)
        {
            ascending = sortColumn != column || !ascending;
            sortColumn = column;
            if (dgvInstructors.DataSource is DataTable table)
                table.DefaultView.Sort = $"[{column}] {(ascending ? "ASC" : "DESC")}";
            ResetSortButtons();
            button.Text = label + (ascending ? " ▲" : " ▼");
            button.Size = new Size(Math.Max(95, TextRenderer.MeasureText(button.Text, button.Font,
                Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix).Width + 30), 40);
            button.BackColor = Color.FromArgb(233, 69, 96);
            if (button is RoundedButton roundedButton)
            {
                roundedButton.HoverColor = button.BackColor;
                roundedButton.PressedColor = button.BackColor;
            }
            AlignSearchSortBar();
            ClearForm();
        }

        private static void DatabaseError(SqlException ex) => MessageBox.Show(
            $"Database Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void StyleDataGridView()
        {
            // 1. Interaction & Edit Restrictions
            dgvInstructors.ReadOnly = true;
            dgvInstructors.AllowUserToAddRows = false;
            dgvInstructors.AllowUserToDeleteRows = false;
            dgvInstructors.AllowUserToResizeRows = false;
            dgvInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInstructors.MultiSelect = false;

            // 2. Table Colors & Border Styles
            dgvInstructors.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvInstructors.BorderStyle = BorderStyle.None;
            dgvInstructors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInstructors.GridColor = Color.FromArgb(40, 52, 85);
            dgvInstructors.EnableHeadersVisualStyles = false;
            dgvInstructors.RowHeadersVisible = false;

            // 3. Column Header Styles
            dgvInstructors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInstructors.ColumnHeadersHeight = 38;
            dgvInstructors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvInstructors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInstructors.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dgvInstructors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvInstructors.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvInstructors.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dgvInstructors.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // 4. Default Cell Styles
            dgvInstructors.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            dgvInstructors.DefaultCellStyle.ForeColor = Color.White;
            dgvInstructors.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10.5F);
            dgvInstructors.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvInstructors.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvInstructors.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            // 5. Alternating Row Styles
            dgvInstructors.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            dgvInstructors.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvInstructors.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvInstructors.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvInstructors.RowTemplate.Height = 36;

            // Automatically unhighlight rows every time data finishes binding
            dgvInstructors.DataBindingComplete -= DgvInstructors_DataBindingComplete;
            dgvInstructors.DataBindingComplete += DgvInstructors_DataBindingComplete;
            dgvInstructors.CellPainting -= DgvInstructors_CellPainting;
            dgvInstructors.CellPainting += DgvInstructors_CellPainting;
        }

        private void DgvInstructors_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                dgvInstructors.Columns[e.ColumnIndex].Name != "Login Enabled") return;

            e.Paint(e.ClipBounds, e.PaintParts & ~DataGridViewPaintParts.ContentForeground);
            float scale = dgvInstructors.DeviceDpi / 96F;
            int size = (int)Math.Round(16 * scale);
            var box = new Rectangle(e.CellBounds.Left + (e.CellBounds.Width - size) / 2,
                e.CellBounds.Top + (e.CellBounds.Height - size) / 2, size, size);
            Color accent = Color.FromArgb(233, 69, 96);
            bool isChecked = e.FormattedValue is true || e.FormattedValue is CheckState.Checked;
            var state = e.Graphics.Save();
            try
            {
                e.Graphics.SetClip(e.ClipBounds, System.Drawing.Drawing2D.CombineMode.Intersect);
                if (isChecked)
                {
                    using var fill = new SolidBrush(accent);
                    e.Graphics.FillRectangle(fill, box);
                }
                using var border = new Pen(accent, Math.Max(1F, scale));
                e.Graphics.DrawRectangle(border, box.X, box.Y, box.Width - 1, box.Height - 1);
                if (isChecked)
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using var check = new Pen(Color.White, 2F * scale);
                    e.Graphics.DrawLines(check, new[]
                    {
                        new PointF(box.Left + size * .22F, box.Top + size * .52F),
                        new PointF(box.Left + size * .43F, box.Top + size * .72F),
                        new PointF(box.Left + size * .79F, box.Top + size * .28F)
                    });
                }
            }
            finally { e.Graphics.Restore(state); }
            e.Handled = true;
        }


        private void DgvInstructors_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvInstructors.Columns.Contains("Login Enabled"))
            {
                var column = dgvInstructors.Columns["Login Enabled"];
                column.MinimumWidth = TextRenderer.MeasureText(column.HeaderText,
                    dgvInstructors.ColumnHeadersDefaultCellStyle.Font, Size.Empty,
                    TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix).Width + 24;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Padding = Padding.Empty;
            }
            dgvInstructors.ClearSelection();
            dgvInstructors.CurrentCell = null;
        }

    }
}
