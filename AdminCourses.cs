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
        private readonly DataTable courses = new DataTable();
        private DataRow? selectedCourse;
        private List<InstructorChoice> instructorChoices = new List<InstructorChoice>();
        private string? selectedInstructorId;
        private bool selectingInstructor;
        private string? courseSortColumn;
        private bool courseSortAscending = true;

        public AdminCourses()
        {
            InitializeComponent();
            StyleDataGridView();
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
            listBoxAssignInstructor.MouseMove += CourseListBox_MouseMove;
            foreach (ListBox list in new[] { listProgramCourses, listBoxAssignInstructor })
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
            rTbProgramCourses.Leave += (s, e) => BeginInvoke((MethodInvoker)(() =>
            {
                if (!listProgramCourses.ContainsFocus) listProgramCourses.Visible = false;
            }));
            listProgramCourses.Leave += (s, e) => listProgramCourses.Visible = false;
            listBoxAssignInstructor.MouseClick += CourseListBox_MouseClick;
            listBoxAssignInstructor.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { SelectInstructor(); e.SuppressKeyPress = true; }
                if (e.KeyCode == Keys.Escape) { listBoxAssignInstructor.Visible = false; e.SuppressKeyPress = true; }
            };
            listBoxAssignInstructor.Parent = this;
            listBoxAssignInstructor.BorderStyle = BorderStyle.FixedSingle;
            listBoxAssignInstructor.IntegralHeight = false;
            rTbAssignInstructor.Enter += (s, e) =>
            {
                try { instructorChoices = CourseRepository.LoadInstructors(); ShowInstructorChoices(); }
                catch (SqlException ex) { CourseDatabaseError(ex); }
            };
            rTbAssignInstructor.TextChanged += (s, e) =>
            {
                if (selectingInstructor) return;
                selectedInstructorId = null;
                ShowInstructorChoices();
            };
            rTbAssignInstructor.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Down && listBoxAssignInstructor.Visible)
                {
                    listBoxAssignInstructor.Focus();
                    if (listBoxAssignInstructor.Items.Count > 0) listBoxAssignInstructor.SelectedIndex = 0;
                    e.SuppressKeyPress = true;
                }
            };
            rTbAssignInstructor.Leave += (s, e) => BeginInvoke((MethodInvoker)(() =>
            {
                if (!listBoxAssignInstructor.ContainsFocus) listBoxAssignInstructor.Visible = false;
            }));
            listBoxAssignInstructor.Leave += (s, e) => listBoxAssignInstructor.Visible = false;
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
            listBoxAssignInstructor.Visible = false;
            foreach (RoundedTextBox field in new[] { rTbCourseTitle, rTbCourseName, rTbCourseID,
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
            else SelectInstructor();
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
                instructorChoices = CourseRepository.LoadInstructors();
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

        private void ShowInstructorChoices()
        {
            if (!rTbAssignInstructor.ContainsFocus) { listBoxAssignInstructor.Visible = false; return; }
            string filter = rTbAssignInstructor.Text.Trim();
            listBoxAssignInstructor.DataSource = instructorChoices
                .Where(i => i.FullName.Contains(filter, StringComparison.CurrentCultureIgnoreCase)).ToList();
            listBoxAssignInstructor.SelectedIndex = -1;
            PositionInstructorChoices();
            listBoxAssignInstructor.Visible = listBoxAssignInstructor.Items.Count > 0;
            listBoxAssignInstructor.BringToFront();
        }

        private void PositionInstructorChoices()
        {
            Point point = PointToClient(pnlAssignInstructor.PointToScreen(new Point(0, pnlAssignInstructor.Height + 2)));
            listBoxAssignInstructor.SetBounds(point.X, point.Y, pnlAssignInstructor.Width, 130);
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

        private void SelectInstructor()
        {
            if (listBoxAssignInstructor.SelectedItem is not InstructorChoice instructor) return;
            selectingInstructor = true;
            try
            {
                selectedInstructorId = instructor.EmployeeId;
                rTbAssignInstructor.Text = instructor.FullName;
            }
            finally { selectingInstructor = false; }
            listBoxAssignInstructor.Visible = false;
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

        private void SaveCourse(bool updating)
        {
            if (updating && selectedCourse == null)
            {
                MessageBox.Show("Select a course from the table to update.", "Validation");
                return;
            }
            string[] values = ReadCourseInputs();
            if (values.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Complete all course fields and select a Day and Term.", "Validation");
                return;
            }
            if (selectedInstructorId == null)
            {
                MessageBox.Show("Select an instructor from the assignment list.", "Validation");
                return;
            }
            int[] limits = { 100, 200, 50, 150, 100, 100, 50, 100, 50 };
            for (int index = 0; index < values.Length; index++)
            {
                if (values[index].Length <= limits[index]) continue;
                MessageBox.Show($"{dgvCourses.Columns[index].HeaderText} must be at most {limits[index]} characters.", "Validation");
                return;
            }
            try
            {
                int? recordId = updating ? Convert.ToInt32(selectedCourse!["CourseRecordID"]) : null;
                if (CourseRepository.Save(recordId, values, selectedInstructorId) == 0)
                    MessageBox.Show("The course no longer exists. Refresh the table and try again.", "Record Not Found");
                LoadSavedCourses();
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
            listBoxAssignInstructor.Visible = false;
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
            listBoxAssignInstructor.Visible = false;
            listProgramCourses.Visible = false;
            listProgramCourses.ClearSelected();
            listBoxAssignInstructor.ClearSelected();
            foreach (RoundedTextBox field in new[] { rTbCourseTitle, rTbCourseName, rTbCourseID,
                rTbProgramCourses, rTbAssignInstructor, rTbRoomNum, rTbCourseTime })
                field.Text = "";
            cmbCourseDay.SelectedIndex = -1;
            cmbCourseTerm.SelectedIndex = -1;
            dgvCourses.ClearSelection();
            dgvCourses.CurrentCell = null;
        }

        private static int TextWidth(Control control, string text) => TextRenderer.MeasureText(
            text, control.Font, Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix).Width;

        private static int FieldWidth(RoundedTextBox field, int minimum) =>
            Math.Max(minimum, Math.Max(TextWidth(field, field.PlaceholderText), TextWidth(field, field.Text)) + 32);

        private void ArrangeCourses()
        {
            if (arrangingCourses) return;
            arrangingCourses = true;
            SuspendLayout();
            try
            {
                int width = Math.Max(300, ClientSize.Width - 24);
                pnlSearchSortCourses.SetBounds(12, pnlHeaderInstructorC.Bottom + 6, width, 82);
                int x = 12, y = 16;
                Control[] toolbar = { rTbSearchCourses, rBtnSearchCourses, rBtnRefreshCourses,
                    lblSlashCourses, lblSortCourses, rBtnSortNameCourses, rBtnCourseTitle,
                    rBtnSortIDCourses, rBtnSortTimeCourses, rTbDay };
                lblSortCourses.AutoSize = false;
                lblSlashCourses.AutoSize = false;
                foreach (Control control in toolbar)
                {
                    int itemWidth = control == rTbSearchCourses ? Math.Min(375, width - 24)
                        : control == lblSlashCourses ? TextWidth(control, control.Text) + 4 : TextWidth(control, control.Text) + 28;
                    // Keep the separator, caption and first sort button together.
                    int requiredWidth = control == lblSlashCourses
                        ? itemWidth + TextWidth(lblSortCourses, lblSortCourses.Text) + 28 +
                            TextWidth(rBtnSortNameCourses, rBtnSortNameCourses.Text) + 28 + 16
                        : itemWidth;
                    if (x > 12 && x + requiredWidth > width - 12) { x = 12; y += 50; }
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    control.SetBounds(x, y, itemWidth, 40);
                    x += itemWidth + 8;
                }
                pnlSearchSortCourses.Height = y + 52;
                cPnlAddCourses.SetBounds(12, pnlSearchSortCourses.Bottom + 6, width, cPnlAddCourses.Height);

                int detailsWidth = Math.Max(700, FieldWidth(rTbCourseTitle, 150) +
                    FieldWidth(rTbCourseName, 350) + FieldWidth(rTbCourseID, 130) + 24);
                int assignmentWidth = FieldWidth(rTbAssignInstructor, 300) + FieldWidth(rTbProgramCourses, 350) + 12;
                bool sideBySide = detailsWidth + assignmentWidth + 48 <= width;
                int sectionWidth = sideBySide ? detailsWidth : width - 24;
                lblAddNewCourse.SetBounds(12, 12, sectionWidth, 30);
                int detailsBottom = ArrangeFields(12, 62, sectionWidth, new[] {
                    (lblCourseTitle, (Control)rTbCourseTitle, FieldWidth(rTbCourseTitle, 150)),
                    (lblCourseName, (Control)rTbCourseName, FieldWidth(rTbCourseName, 350)),
                    (lblCourseID, (Control)rTbCourseID, FieldWidth(rTbCourseID, 130)),
                    (lblRoomNum, (Control)rTbRoomNum, FieldWidth(rTbRoomNum, 150)),
                    (lblCourseTime, (Control)rTbCourseTime, FieldWidth(rTbCourseTime, 190)),
                    (lblDay, (Control)cmbCourseDay, 145),
                    (lblTerm, (Control)cmbCourseTerm, 145)
                });
                int assignmentLeft = sideBySide ? detailsWidth + 36 : 12;
                int assignmentTop = sideBySide ? 12 : detailsBottom + 20;
                int assignmentAvailable = width - assignmentLeft - 12;
                lblInstructorAssignment.SetBounds(assignmentLeft, assignmentTop, assignmentAvailable, 30);
                int assignmentBottom = ArrangeFields(assignmentLeft, assignmentTop + 50, assignmentAvailable, new[] {
                    (lblAssignInstructor, (Control)pnlAssignInstructor, FieldWidth(rTbAssignInstructor, 300)),
                    (lblProgramCourses, (Control)pnlProgramCourses, FieldWidth(rTbProgramCourses, 350))
                });
                rTbAssignInstructor.SetBounds(0, 0, pnlAssignInstructor.Width, 40);
                rTbProgramCourses.SetBounds(0, 0, pnlProgramCourses.Width, 40);
                PositionInstructorChoices();
                PositionProgramChoices();

                x = 12;
                y = Math.Max(detailsBottom, assignmentBottom) + 24;
                foreach (Button button in new[] { rBtnAddCourse, rBtnUpdateCourses, rBtnDeleteCourses, rBtnCancelCourses })
                {
                    int buttonWidth = TextWidth(button, button.Text) + 28;
                    if (x > 12 && x + buttonWidth > width - 12) { x = 12; y += 50; }
                    button.SetBounds(x, y, buttonWidth, 40);
                    x += buttonWidth + 8;
                }
                cPnlAddCourses.Height = y + 56;
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

        private static int ArrangeFields(int left, int top, int width,
            (Label Label, Control Input, int Width)[] fields)
        {
            int x = left, y = top, rowHeight = 0;
            foreach (var field in fields)
            {
                int fieldWidth = Math.Min(field.Width, width);
                if (x > left && x + fieldWidth > left + width)
                {
                    x = left;
                    y += rowHeight + 16;
                    rowHeight = 0;
                }
                field.Label.SetBounds(x, y, fieldWidth, 23);
                int inputHeight = field.Input is ListBox ? 100 : 40;
                if (field.Input is ListBox list) list.IntegralHeight = false;
                field.Input.SetBounds(x, y + 26, fieldWidth, inputHeight);
                rowHeight = Math.Max(rowHeight, inputHeight + 26);
                x += fieldWidth + 12;
            }
            return y + rowHeight;
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
