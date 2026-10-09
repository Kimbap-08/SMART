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
    public partial class AdminCourses : Form
    {
        private bool arrangingCourses;
        private bool formattingCourseCode;
        private readonly DataTable courses = new DataTable();
        private DataRow? selectedCourse;
        private List<InstructorChoice> instructorChoices = new List<InstructorChoice>();
        private string? selectedInstructorId;
        private bool selectingInstructor;
        private string? courseSortColumn;
        private bool courseSortAscending = true;

        private void ProgramCourses_Leave(object? sender, EventArgs e)
        {
            if (Disposing || IsDisposed || !IsHandleCreated) return;

            BeginInvoke((MethodInvoker)(() =>
            {
                if (Disposing || IsDisposed || !IsHandleCreated ||
                    listProgramCourses.Disposing || listProgramCourses.IsDisposed) return;

                if (!listProgramCourses.ContainsFocus)
                    listProgramCourses.Visible = false;
            }));
        }

        public AdminCourses()
        {
            InitializeComponent();
            rTbCourseID.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && (e.KeyChar < '0' || e.KeyChar > '9'))
                    e.Handled = true;
            };
            var courseCodeInput = rTbCourseID.Controls.OfType<TextBox>().Single();
            courseCodeInput.TextChanged += CourseCodeInput_TextChanged;
            StyleDataGridView();
            StyleCourseComboBoxes();
            InitializeCourseTable();
            rTbSearchCourses.PlaceholderText = "Search courses...";
            rBtnSearchCourses.Click += (s, e) => ApplyCourseView();
            rTbSearchCourses.TextChanged += (s, e) => ApplyCourseView();
            rTbSearchCourses.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { ApplyCourseView(); e.SuppressKeyPress = true; }
            };
            rBtnSortNameCourses.Click += (s, e) => SortCourses("Course Name", rBtnSortNameCourses);
            rBtnCourseTitle.Click += (s, e) => SortCourses("Course Title", rBtnCourseTitle);
            rBtnSortIDCourses.Click += (s, e) => SortCourses("Course Code", rBtnSortIDCourses);
            rBtnSortTimeCourses.Click += (s, e) => SortCourses("Time", rBtnSortTimeCourses);
            rTbDay.Click += (s, e) => SortCourses("Day", rTbDay);
            listProgramCourses.MouseMove += CourseListBox_MouseMove;
            listProgramCourses.MouseMove += CourseListBox_MouseMove;
            foreach (ListBox list in new[] { listProgramCourses })
            {
                list.DrawMode = DrawMode.OwnerDrawFixed;
                list.ItemHeight = 26;
                list.DrawItem += CourseListBox_DrawItem;
            }
            rBtnAddCourse.Click += (s, e) => SaveCourse(false);
            rBtnUpdateCourses.Click += (s, e) => SaveCourse(true);
            rBtnDeleteCourses.Click += (s, e) => DeleteCourse();
            rBtnCancelCourses.Click += (s, e) => ClearCourseInputs();
            dgvCourses.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && dgvCourses.Rows[e.RowIndex].DataBoundItem is DataRowView row)
                    SelectCourse(row.Row);
            };
            listProgramCourses.Parent = this;
            listProgramCourses.BorderStyle = BorderStyle.FixedSingle;
            listProgramCourses.IntegralHeight = false;
            listProgramCourses.MouseClick += CourseListBox_MouseClick;
            listProgramCourses.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { SelectCourseProgram(); e.SuppressKeyPress = true; }
                if (e.KeyCode == Keys.Escape) { listProgramCourses.Visible = false; e.SuppressKeyPress = true; }
            };
            rTbProgramCourses.Enter += (s, e) =>
            {
                PositionProgramChoices();
                listProgramCourses.SelectedIndex = -1;
                listProgramCourses.Visible = true;
                listProgramCourses.BringToFront();
            };
            rTbProgramCourses.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Down && listProgramCourses.Visible)
                {
                    listProgramCourses.Focus();
                    listProgramCourses.SelectedIndex = 0;
                    e.SuppressKeyPress = true;
                }
            };
            rTbProgramCourses.Leave += ProgramCourses_Leave;
            listProgramCourses.Leave += (s, e) => listProgramCourses.Visible = false;
            rTbAssignInstructor.Enter += (s, e) =>
            {
                try { LoadInstructorChoices(); }
                catch (SqlException ex) { CourseDatabaseError(ex); }
            };
            rTbAssignInstructor.TextChanged += (s, e) =>
            {
                if (selectingInstructor) return;
                selectedInstructorId = instructorChoices.FirstOrDefault(i =>
                    string.Equals(i.FullName, rTbAssignInstructor.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))?.EmployeeId;
            };
            rTbAssignInstructor.SelectedIndexChanged += (s, e) =>
            {
                if (rTbAssignInstructor.SelectedItem is InstructorChoice instructor)
                    selectedInstructorId = instructor.EmployeeId;
            };
            Load += (s, e) => InitializeCourseDatabase();
            rBtnRefreshCourses.Click += (s, e) =>
            {
                courseSortColumn = null;
                courseSortAscending = true;
                rTbSearchCourses.Text = "";
                ResetCourseSortButtons();
                InitializeCourseDatabase();
            };
            lblSlashCourses.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dgvCourses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listProgramCourses.Visible = false;
            foreach (Control field in new Control[] { rTbCourseTitle, rTbCourseName, rTbCourseID,
                rTbRoomNum, rTbCourseTime, rTbAssignInstructor, rTbProgramCourses })
            {
                field.TextChanged += (s, e) => ArrangeCourses();
                field.FontChanged += (s, e) => ArrangeCourses();
            }
            SizeChanged += (s, e) => ArrangeCourses();
            Shown += (s, e) => ArrangeCourses();
            ArrangeCourses();
            ClearCourseInputs();
        }

        private void InitializeCourseTable()
        {
            string[] headers = { "Course Title", "Course Name", "Course Code", "Program", "Instructor",
                "Room Number", "Day", "Time", "Term" };
            float[] weights = { 12, 24, 12, 22, 20, 12, 10, 14, 10 };
            dgvCourses.AutoGenerateColumns = false;
            dgvCourses.AllowUserToOrderColumns = false;
            dgvCourses.Columns.Clear();
            for (int index = 0; index < headers.Length; index++)
            {
                string header = headers[index];
                courses.Columns.Add(header, typeof(string));
                dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = header,
                    HeaderText = header,
                    DataPropertyName = header,
                    FillWeight = weights[index],
                    MinimumWidth = Math.Max(90, TextWidth(dgvCourses, header) + 30),
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });
            }
            dgvCourses.DataSource = courses;
            dgvCourses.DataBindingComplete += (s, e) =>
            {
                if (selectedCourse == null)
                {
                    dgvCourses.ClearSelection();
                    dgvCourses.CurrentCell = null;
                }
            };
        }

        private void ApplyCourseView()
        {
            ClearCourseInputs();
            courses.DefaultView.RowFilter = BuildCourseFilter(rTbSearchCourses.Text.Trim());
            courses.DefaultView.Sort = courseSortColumn == null ? ""
                : $"[{courseSortColumn}] {(courseSortAscending ? "ASC" : "DESC")}";
        }

        internal static string BuildCourseFilter(string search)
        {
            if (search.Length == 0) return "";
            // Treat quotes and LIKE wildcard characters as literal search text.
            string escaped = string.Concat(search.Select(c => c switch
            {
                '\'' => "''", '[' => "[[]", ']' => "[]]", '%' => "[%]", '*' => "[*]", _ => c.ToString()
            }));
            string[] columns = { "Course Title", "Course Name", "Course Code", "Program", "Instructor",
                "Room Number", "Day", "Time", "Term" };
            return string.Join(" OR ", columns.Select(column => $"[{column}] LIKE '%{escaped}%'"));
        }

        private (RoundedButton Button, string Column)[] CourseSortButtons() => new[]
        {
            (rBtnSortNameCourses, "Course Name"), (rBtnCourseTitle, "Course Title"),
            (rBtnSortIDCourses, "Course Code"), (rBtnSortTimeCourses, "Time"), (rTbDay, "Day")
        };

        private void ResetCourseSortButtons()
        {
            foreach (var item in CourseSortButtons())
            {
                item.Button.Text = item.Column;
                item.Button.BackColor = Color.FromArgb(22, 33, 62);
                item.Button.HoverColor = Color.Empty;
                item.Button.PressedColor = Color.Empty;
            }
            ArrangeCourses();
        }

        private void SortCourses(string column, RoundedButton button)
        {
            courseSortAscending = courseSortColumn != column || !courseSortAscending;
            courseSortColumn = column;
            ResetCourseSortButtons();
            button.Text = column + (courseSortAscending ? " ▲" : " ▼");
            button.BackColor = Color.FromArgb(233, 69, 96);
            button.HoverColor = button.BackColor;
            button.PressedColor = button.BackColor;
            ApplyCourseView();
            ArrangeCourses();
        }

        private void CourseListBox_MouseMove(object? sender, MouseEventArgs e)
        {
            if (sender is not ListBox list) return;
            int index = list.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches || index == list.SelectedIndex ||
                !list.GetItemRectangle(index).Contains(e.Location)) return;
            int topIndex = list.TopIndex;
            list.SelectedIndex = index;
            list.TopIndex = topIndex;
        }

        private void CourseListBox_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || sender is not ListBox list) return;
            int index = list.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches || !list.GetItemRectangle(index).Contains(e.Location)) return;
            list.SelectedIndex = index;
            if (list == listProgramCourses) SelectCourseProgram();
        }

        private void CourseListBox_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (sender is not ListBox list || e.Index < 0 || e.Index >= list.Items.Count) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            using var background = new SolidBrush(selected ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62));
            using var foreground = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(background, e.Bounds);
            e.Graphics.DrawString(Convert.ToString(list.Items[e.Index]) ?? "", list.Font,
                foreground, e.Bounds.X + 8, e.Bounds.Y + 4);
        }

        private void InitializeCourseDatabase()
        {
            try
            {
                CourseRepository.Initialize();
                LoadInstructorChoices();
                LoadSavedCourses();
            }
            catch (SqlException ex) { CourseDatabaseError(ex); }
        }

        private void LoadSavedCourses()
        {
            using var saved = CourseRepository.LoadCourses();
            selectedCourse = null;
            courses.Clear();
            courses.Merge(saved, false, MissingSchemaAction.Add);
            ApplyCourseView();
        }

        private void LoadInstructorChoices()
        {
            string currentText = rTbAssignInstructor.Text;
            instructorChoices = CourseRepository.LoadInstructors();
            selectingInstructor = true;
            try
            {
                rTbAssignInstructor.BeginUpdate();
                rTbAssignInstructor.Items.Clear();
                rTbAssignInstructor.Items.AddRange(instructorChoices.Cast<object>().ToArray());
                rTbAssignInstructor.Text = currentText;
            }
            finally
            {
                rTbAssignInstructor.EndUpdate();
                selectingInstructor = false;
            }
        }

        private void PositionProgramChoices()
        {
            Point point = PointToClient(pnlProgramCourses.PointToScreen(new Point(0, pnlProgramCourses.Height + 2)));
            listProgramCourses.SetBounds(point.X, point.Y, pnlProgramCourses.Width,
                listProgramCourses.Items.Count * listProgramCourses.ItemHeight + 4);
        }

        private void SelectCourseProgram()
        {
            if (listProgramCourses.SelectedItem is not string program) return;
            rTbProgramCourses.Text = program;
            listProgramCourses.Visible = false;
        }

        private static void CourseDatabaseError(SqlException ex) => MessageBox.Show(
            $"Could not access course data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private string[] ReadCourseInputs() => new[]
        {
            rTbCourseTitle.Text.Trim(), rTbCourseName.Text.Trim(), rTbCourseID.Text.Trim(),
            rTbProgramCourses.Text.Trim(), rTbAssignInstructor.Text.Trim(), rTbRoomNum.Text.Trim(),
            Convert.ToString(cmbCourseDay.SelectedItem)?.Trim() ?? "", rTbCourseTime.Text.Trim(),
            Convert.ToString(cmbCourseTerm.SelectedItem)?.Trim() ?? ""
        };

        private void CourseCodeInput_TextChanged(object? sender, EventArgs e)
        {
            if (formattingCourseCode || sender is not TextBox input || !input.Focused) return;
            string digits = new string(input.Text.Where(c => c >= '0' && c <= '9').Take(5).ToArray());
            if (input.Text == digits) return;
            int caret = input.Text.Take(input.SelectionStart).Count(c => c >= '0' && c <= '9');
            formattingCourseCode = true;
            try
            {
                input.Text = digits;
                input.SelectionStart = Math.Min(caret, digits.Length);
            }
            finally { formattingCourseCode = false; }
        }

        private static bool IsValidCourseCode(string code) =>
            code.Length >= 1 && code.Length <= 5 && code.All(c => c >= '0' && c <= '9');

        private void SaveCourse(bool updating)
        {
            if (updating && selectedCourse == null)
            {
                MessageBox.Show("Select a course from the table to update.", "Validation");
                return;
            }
            string[] values = ReadCourseInputs();
            if (!IsValidCourseCode(values[2]))
            {
                MessageBox.Show("Course Code must contain 1 to 5 digits (0-9) only.", "Validation");
                rTbCourseID.Focus();
                return;
            }
            if (values.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Complete all course fields and select a Day and Term.", "Validation");
                return;
            }
            if (selectedInstructorId == null)
            {
                MessageBox.Show("Select an instructor from the dropdown or enter an existing instructor name exactly.", "Validation");
                return;
            }
            int[] limits = { 100, 200, 5, 150, 100, 100, 50, 100, 50 };
            for (int index = 0; index < values.Length; index++)
            {
                if (values[index].Length <= limits[index]) continue;
                MessageBox.Show($"{dgvCourses.Columns[index].HeaderText} must be at most {limits[index]} characters.", "Validation");
                return;
            }
            try
            {
                int? recordId = updating ? Convert.ToInt32(selectedCourse!["CourseRecordID"]) : null;
                if (recordId.HasValue)
                {
                    string oldPeriod = Convert.ToString(selectedCourse!["Term"]) ?? "";
                    if (ExamRepository.NormalizePeriod(oldPeriod) != ExamRepository.NormalizePeriod(values[8]))
                    {
                        DialogResult choice = MessageBox.Show(
                            $"Changing the grading period from {oldPeriod} to {values[8]} changes the expected exam structure. Existing exams and scores will be preserved; the new period's exams will be added. Continue?",
                            "Change Grading Period", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (choice != DialogResult.Yes) return;
                    }
                }
                if (CourseRepository.CourseCodeExists(values[2], recordId))
                {
                    MessageBox.Show("That Course Code already exists. Use a unique Course Code.", "Duplicate Course Code");
                    return;
                }
                if (CourseRepository.Save(recordId, values, selectedInstructorId) == 0)
                    MessageBox.Show("The course no longer exists. Refresh the table and try again.", "Record Not Found");
                LoadSavedCourses();
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627 || ex.Number == 51001)
            {
                MessageBox.Show("That Course Code already exists. Use a unique Course Code.", "Duplicate Course Code");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("The selected instructor no longer exists. Select an instructor again.", "Validation");
            }
            catch (SqlException ex) { CourseDatabaseError(ex); }
        }

        private void SelectCourse(DataRow row)
        {
            selectedCourse = row;
            rTbCourseTitle.Text = (string)row["Course Title"];
            rTbCourseName.Text = (string)row["Course Name"];
            rTbCourseID.Text = (string)row["Course Code"];
            rTbProgramCourses.Text = (string)row["Program"];
            selectingInstructor = true;
            try
            {
                selectedInstructorId = row.IsNull("InstructorEmployeeID") ? null : (string)row["InstructorEmployeeID"];
                rTbAssignInstructor.Text = selectedInstructorId == null ? "" : (string)row["Instructor"];
            }
            finally { selectingInstructor = false; }
            rTbRoomNum.Text = (string)row["Room Number"];
            cmbCourseDay.SelectedItem = row["Day"];
            rTbCourseTime.Text = (string)row["Time"];
            cmbCourseTerm.SelectedItem = row["Term"];
        }

        private void DeleteCourse()
        {
            if (selectedCourse == null)
            {
                MessageBox.Show("Select a course from the table to delete.", "Validation");
                return;
            }
            try
            {
                if (CourseRepository.Delete(Convert.ToInt32(selectedCourse["CourseRecordID"])) == 0)
                    MessageBox.Show("The course no longer exists. Refresh the table and try again.", "Record Not Found");
                LoadSavedCourses();
            }
            catch (SqlException ex) { CourseDatabaseError(ex); }
        }

        private void ClearCourseInputs()
        {
            selectedCourse = null;
            selectedInstructorId = null;
            listProgramCourses.Visible = false;
            listProgramCourses.ClearSelected();
            foreach (Control field in new Control[] { rTbCourseTitle, rTbCourseName, rTbCourseID,
                rTbProgramCourses, rTbAssignInstructor, rTbRoomNum, rTbCourseTime })
                field.Text = "";
            rTbAssignInstructor.SelectedIndex = -1;
            cmbCourseDay.SelectedIndex = -1;
            cmbCourseTerm.SelectedIndex = -1;
            dgvCourses.ClearSelection();
            dgvCourses.CurrentCell = null;
        }

        private static int TextWidth(Control control, string text) => TextRenderer.MeasureText(
            text, control.Font, Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix).Width;

        private void ArrangeCourses()
        {
            if (arrangingCourses) return;
            arrangingCourses = true;
            SuspendLayout();
            try
            {
                int width = Math.Max(300, ClientSize.Width - 24);
                pnlSearchSortCourses.SetBounds(12, pnlHeaderInstructorC.Bottom + 6, width, 82);
                AdminPanelLayout.ArrangeToolbar(this, pnlHeaderInstructorC, pnlSearchSortCourses,
                    rTbSearchCourses, lblSlashCourses, lblSortCourses,
                    rTbSearchCourses, rBtnSearchCourses, rBtnRefreshCourses, lblSlashCourses,
                    lblSortCourses, rBtnSortNameCourses, rBtnCourseTitle, rBtnSortIDCourses,
                    rBtnSortTimeCourses, rTbDay);
                int x, y;
                cPnlAddCourses.SetBounds(12, pnlSearchSortCourses.Bottom + 6, width, cPnlAddCourses.Height);

                const int inset = 24;
                const int gap = 20;
                int available = Math.Max(240, width - inset * 2);
                lblAddNewCourse.SetBounds(inset, 16, available, 30);
                int shortWidth = Math.Max(100, (available - gap * 2) / 5);
                int nameWidth = available - shortWidth * 2 - gap * 2;
                PlaceCourseField(lblCourseTitle, rTbCourseTitle, inset, 62, shortWidth);
                PlaceCourseField(lblCourseName, rTbCourseName, inset + shortWidth + gap, 62, nameWidth);
                PlaceCourseField(lblCourseID, rTbCourseID, inset + available - shortWidth, 62, shortWidth);

                int scheduleWidth = (available - gap * 3) / 4;
                PlaceCourseField(lblRoomNum, rTbRoomNum, inset, 144, scheduleWidth);
                PlaceCourseField(lblCourseTime, rTbCourseTime, inset + scheduleWidth + gap, 144, scheduleWidth);
                PlaceCourseField(lblDay, cmbCourseDay, inset + (scheduleWidth + gap) * 2, 144, scheduleWidth);
                PlaceCourseField(lblTerm, cmbCourseTerm, inset + (scheduleWidth + gap) * 3, 144,
                    available - (scheduleWidth + gap) * 3);

                lblInstructorAssignment.SetBounds(inset, 226, available, 30);
                int assignmentWidth = (available - gap) / 2;
                PlaceCourseField(lblAssignInstructor, pnlAssignInstructor, inset, 268, assignmentWidth);
                PlaceCourseField(lblProgramCourses, pnlProgramCourses, inset + assignmentWidth + gap, 268,
                    available - assignmentWidth - gap);
                rTbAssignInstructor.SetBounds(0, 0, pnlAssignInstructor.Width, 40);
                rTbProgramCourses.SetBounds(0, 0, pnlProgramCourses.Width, 40);
                PositionProgramChoices();

                x = inset;
                y = 358;
                foreach (Button button in new[] { rBtnAddCourse, rBtnUpdateCourses, rBtnDeleteCourses, rBtnCancelCourses })
                {
                    int buttonWidth = Math.Max(100, TextWidth(button, button.Text) + 36);
                    if (x > inset && x + buttonWidth > width - inset) { x = inset; y += 52; }
                    button.SetBounds(x, y, buttonWidth, 40);
                    x += buttonWidth + 12;
                }
                cPnlAddCourses.Height = y + 64;
                int gridTop = cPnlAddCourses.Bottom + 9;
                dgvCourses.SetBounds(cPnlAddCourses.Left, gridTop, cPnlAddCourses.Width,
                    Math.Max(0, ClientSize.Height - gridTop - 15));
            }
            finally
            {
                ResumeLayout(false);
                arrangingCourses = false;
            }
        }

        private static void PlaceCourseField(Label label, Control input, int left, int top, int width)
        {
            label.SetBounds(left, top, width, 23);
            input.SetBounds(left, top + 26, width, 40);
        }

        private void StyleCourseComboBoxes()
        {
            foreach (ComboBox combo in new[] { cmbCourseDay, cmbCourseTerm })
            {
                combo.FlatStyle = FlatStyle.Flat;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
                combo.BackColor = Color.FromArgb(22, 33, 62);
                combo.ForeColor = Color.White;
                combo.Font = new Font("Bahnschrift Light", 10F);
                combo.DrawMode = DrawMode.OwnerDrawFixed;
                combo.ItemHeight = 24;
                combo.DrawItem += CourseComboBox_DrawItem;
            }
        }

        private void CourseComboBox_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (sender is not ComboBox combo || e.Index < 0 || e.Index >= combo.Items.Count) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            using var background = new SolidBrush(selected ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62));
            using var foreground = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(background, e.Bounds);
            string text = Convert.ToString(combo.Items[e.Index]) ?? "";
            Font font = e.Font ?? combo.Font;
            Size size = TextRenderer.MeasureText(text, font);
            int y = e.Bounds.Y + Math.Max(0, (e.Bounds.Height - size.Height) / 2);
            e.Graphics.DrawString(text, font, foreground, new PointF(e.Bounds.X + 6, y));
        }

        private void StyleDataGridView()
        {
            // 1. Interaction & Edit Restrictions
            dgvCourses.ReadOnly = true;
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AllowUserToResizeRows = false;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.MultiSelect = false;

            // 2. Table Colors & Border Styles
            dgvCourses.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvCourses.BorderStyle = BorderStyle.None;
            dgvCourses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCourses.GridColor = Color.FromArgb(40, 52, 85);
            dgvCourses.EnableHeadersVisualStyles = false;
            dgvCourses.RowHeadersVisible = false;

            // 3. Column Header Styles
            dgvCourses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCourses.ColumnHeadersHeight = 38;
            dgvCourses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvCourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCourses.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dgvCourses.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCourses.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dgvCourses.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // 4. Default Cell Styles
            dgvCourses.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            dgvCourses.DefaultCellStyle.ForeColor = Color.White;
            dgvCourses.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10.5F);
            dgvCourses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvCourses.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCourses.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            // 5. Alternating Row Styles
            dgvCourses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            dgvCourses.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvCourses.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvCourses.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvCourses.RowTemplate.Height = 36;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
