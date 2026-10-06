using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SMART
{
    public class Courses : UserControl
    {
        // ── Colors matching your app theme ────────────────────────────
        private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
        private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
        private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
        private static readonly Color TextColor = Color.White;
        private static readonly Color GrayText = Color.FromArgb(150, 150, 170);

        private static readonly string[] Programs =
        {
            "All Programs",
            "BS Computer Engineering",
            "BS Civil Engineering",
            "BS Electrical Engineering",
            "BS Mechanical Engineering",
            "BS Electronics Engineering",
            "BS Chemical Engineering",
            "BS Information Technology",
            "BS Computer Science",
            "BS Architecture",
            "BS Nursing",
            "BS Education",
            "BS Business Administration"
        };

        // ── Controls ─────────────────────────────────────────────────
        private TextBox txtCode, txtName, txtSection, txtEnrollCode;
        private ComboBox cboProgram, cboInstructor;
        private Button btnSave, btnCancel;
        private Label lblFormTitle, lblMsg, lblTotal;
        private DataGridView grid;

        // ── State ─────────────────────────────────────────────────────
        private List<CourseRow> _courses = new List<CourseRow>();
        private List<InstructorItem> _instructors = new List<InstructorItem>();
        private int _editingId = -1;

        // Simple data holders
        private class CourseRow
        {
            public int Id { get; set; }
            public string CourseCode { get; set; }
            public string CourseName { get; set; }
            public string Section { get; set; }
            public string Program { get; set; }
            public int InstructorId { get; set; }
            public string InstructorName { get; set; }
            public string EnrollmentCode { get; set; }
        }

        private class InstructorItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }

        // ─────────────────────────────────────────────────────────────
        public Courses()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = BgColor;
            BuildUI();
        }

        // ── Build UI in code ──────────────────────────────────────────
        private void BuildUI()
        {
            // Page title
            var lblTitle = Lbl("Course Management", 20, 20,
                new Font("Segoe UI", 20, FontStyle.Bold), TextColor);
            var lblSub = Lbl("Add courses and assign instructors  —  click a row to edit",
                22, 58, new Font("Segoe UI", 10), GrayText);

            // ── Form card ─────────────────────────────────────────────
            var card = new Panel
            {
                BackColor = CardColor,
                Location = new Point(20, 90),
                Size = new Size(1100, 190),
            };

            // Row 1 inputs
            int y1 = 14;
            AddField(card, "Course Code", out txtCode, 12, y1, 140);
            AddField(card, "Course Name", out txtName, 170, y1, 260);
            AddField(card, "Section", out txtSection, 448, y1, 140);
            AddField(card, "Enrollment Code", out txtEnrollCode, 606, y1, 160);

            // Row 2
            int y2 = 88;
            card.Controls.Add(Lbl("Program", 12, y2, new Font("Segoe UI", 9), GrayText));
            cboProgram = new ComboBox
            {
                Location = new Point(12, y2 + 20),
                Size = new Size(280, 30),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = BgColor,
                ForeColor = TextColor,
                FlatStyle = FlatStyle.Flat
            };
            cboProgram.Items.AddRange(Programs);
            cboProgram.SelectedIndex = 0;
            card.Controls.Add(cboProgram);

            card.Controls.Add(Lbl("Assign Instructor", 310, y2, new Font("Segoe UI", 9), GrayText));
            cboInstructor = new ComboBox
            {
                Location = new Point(310, y2 + 20),
                Size = new Size(260, 30),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = BgColor,
                ForeColor = TextColor,
                FlatStyle = FlatStyle.Flat
            };
            card.Controls.Add(cboInstructor);

            // Save button
            btnSave = Btn("SAVE COURSE", AccentColor, 590, y2 + 18);
            btnSave.Click += BtnSave_Click;
            card.Controls.Add(btnSave);

            // Cancel button
            btnCancel = Btn("CANCEL", Color.FromArgb(60, 60, 80), 730, y2 + 18);
            btnCancel.Click += (s, e) => ResetForm();
            card.Controls.Add(btnCancel);

            // Form title label (changes to show editing state)
            lblFormTitle = Lbl("➕  New Course", 12, 8,
                new Font("Segoe UI", 10, FontStyle.Bold), AccentColor);
            card.Controls.Add(lblFormTitle);

            // Message label
            lblMsg = new Label
            {
                Location = new Point(12, 162),
                Size = new Size(800, 22),
                ForeColor = Color.LimeGreen,
                Font = new Font("Segoe UI", 9),
                Text = ""
            };
            card.Controls.Add(lblMsg);

            // ── Total count ───────────────────────────────────────────
            lblTotal = Lbl("Total courses: 0", 22, 292,
                new Font("Segoe UI", 10), GrayText);

            // ── Grid ──────────────────────────────────────────────────
            grid = new DataGridView
            {
                Location = new Point(20, 316),
                Size = new Size(1100, 400),
                BackgroundColor = CardColor,
                ForeColor = TextColor,
                GridColor = Color.FromArgb(35, 45, 70),
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(10, 15, 35),
                    ForeColor = TextColor,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Padding = new Padding(6, 4, 0, 4)
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = CardColor,
                    ForeColor = TextColor,
                    SelectionBackColor = Color.FromArgb(233, 69, 96),
                    SelectionForeColor = TextColor,
                    Padding = new Padding(4, 3, 0, 3)
                },
                RowTemplate = { Height = 36 }
            };
            grid.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Code", HeaderText = "Code", FillWeight = 12 });
            grid.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Name", HeaderText = "Course Name", FillWeight = 25 });
            grid.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Section", HeaderText = "Section", FillWeight = 12 });
            grid.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Program", HeaderText = "Program", FillWeight = 25 });
            grid.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Instr", HeaderText = "Instructor", FillWeight = 18 });
            grid.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Enroll", HeaderText = "Enrollment Code", FillWeight = 18 });

            grid.SelectionChanged += Grid_SelectionChanged;

            // ── Add everything to the UserControl ─────────────────────
            this.Controls.AddRange(new Control[]
            {
                lblTitle, lblSub, card, lblTotal, grid
            });

            // ── Load data ─────────────────────────────────────────────
            LoadInstructors();
            LoadCourses();
        }

        // ── Helpers ───────────────────────────────────────────────────
        private void AddField(Panel parent, string labelText,
                               out TextBox box, int x, int y, int width)
        {
            parent.Controls.Add(Lbl(labelText, x, y + 20,
                new Font("Segoe UI", 8), GrayText));
            box = new TextBox
            {
                Location = new Point(x, y + 38),
                Size = new Size(width, 32),
                BackColor = BgColor,
                ForeColor = TextColor,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10)
            };
            parent.Controls.Add(box);
        }

        private static Label Lbl(string text, int x, int y, Font font, Color color)
            => new Label
            {
                Text = text,
                Location = new Point(x, y),
                AutoSize = true,
                Font = font,
                ForeColor = color
            };

        private static Button Btn(string text, Color bg, int x, int y)
        {
            var b = new Button
            {
                Text = text,
                BackColor = bg,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(x, y),
                Size = new Size(130, 36),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }

        // ── Load instructors into dropdown ────────────────────────────
        private void LoadInstructors()
        {
            cboInstructor.Items.Clear();
            _instructors.Clear();
            string sql = "SELECT InstructorId, FullName FROM Instructors ORDER BY FullName";
            try
            {
                using (var conn = AuthService.GetConnection())
                using (var cmd = new SqliteCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        var item = new InstructorItem
                        {
                            Id = r.GetInt32(0),
                            Name = r.GetString(1)
                        };
                        _instructors.Add(item);
                        cboInstructor.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMsg("Could not load instructors: " + ex.Message, false);
            }
        }

        // ── Load courses into grid ────────────────────────────────────
        private void LoadCourses()
        {
            grid.Rows.Clear();
            _courses.Clear();

            string sql = @"
                SELECT c.CourseId, c.CourseCode, c.CourseName,
                       c.Section, c.Program, c.InstructorId,
                       COALESCE(i.FullName,'Unassigned') as InstrName,
                       c.EnrollmentCode
                FROM Courses c
                LEFT JOIN Instructors i ON c.InstructorId = i.InstructorId
                ORDER BY c.CourseCode";
            try
            {
                using (var conn = AuthService.GetConnection())
                using (var cmd = new SqliteCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        var row = new CourseRow
                        {
                            Id = r.GetInt32(0),
                            CourseCode = r.GetString(1),
                            CourseName = r.GetString(2),
                            Section = r.GetString(3),
                            Program = r.GetString(4),
                            InstructorId = r.IsDBNull(5) ? 0 : r.GetInt32(5),
                            InstructorName = r.GetString(6),
                            EnrollmentCode = r.GetString(7)
                        };
                        _courses.Add(row);
                        grid.Rows.Add(row.CourseCode, row.CourseName, row.Section,
                                      row.Program, row.InstructorName, row.EnrollmentCode);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMsg("Error loading courses: " + ex.Message, false);
            }

            lblTotal.Text = $"Total courses: {_courses.Count}";
        }

        // ── Row click → fill form ─────────────────────────────────────
        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0) return;
            int idx = grid.SelectedRows[0].Index;
            if (idx < 0 || idx >= _courses.Count) return;

            var c = _courses[idx];
            _editingId = c.Id;

            txtCode.Text = c.CourseCode;
            txtName.Text = c.CourseName;
            txtSection.Text = c.Section;
            txtEnrollCode.Text = c.EnrollmentCode;
            txtEnrollCode.Enabled = false; // Cannot change enrollment code

            // Set program combo
            for (int i = 0; i < cboProgram.Items.Count; i++)
                if (cboProgram.Items[i].ToString() == c.Program)
                { cboProgram.SelectedIndex = i; break; }

            // Set instructor combo
            cboInstructor.SelectedIndex = -1;
            foreach (InstructorItem item in cboInstructor.Items)
                if (item.Id == c.InstructorId)
                { cboInstructor.SelectedItem = item; break; }

            lblFormTitle.Text = $"✏️  Editing: {c.CourseCode} — {c.CourseName}";
            btnSave.Text = "UPDATE COURSE";
            btnSave.BackColor = Color.FromArgb(0, 140, 200);
            ShowMsg("Edit the fields then click UPDATE COURSE.", true);
        }

        // ── Save (Add or Update) ──────────────────────────────────────
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validate
            if (txtCode.Text.Trim().Length == 0)
            { ShowMsg("Course code is required.", false); return; }
            if (txtName.Text.Trim().Length == 0)
            { ShowMsg("Course name is required.", false); return; }
            if (txtSection.Text.Trim().Length == 0)
            { ShowMsg("Section is required.", false); return; }
            if (txtEnrollCode.Text.Trim().Length == 0)
            { ShowMsg("Enrollment code is required.", false); return; }
            if (cboInstructor.SelectedItem == null)
            { ShowMsg("Please select an instructor.", false); return; }

            var instr = (InstructorItem)cboInstructor.SelectedItem;
            string program = cboProgram.SelectedItem?.ToString() ?? "All Programs";

            if (_editingId < 0)
            {
                // ADD new course
                bool ok = AddCourse(txtCode.Text.Trim(), txtName.Text.Trim(),
                                     txtSection.Text.Trim(), program,
                                     instr.Id, txtEnrollCode.Text.Trim());
                ShowMsg(ok ? "✅ Course added successfully!"
                           : "❌ Enrollment code already exists.", ok);
                if (ok) { ResetForm(); LoadCourses(); }
            }
            else
            {
                // UPDATE existing course
                bool ok = UpdateCourse(_editingId, txtCode.Text.Trim(),
                                        txtName.Text.Trim(), txtSection.Text.Trim(),
                                        program, instr.Id);
                ShowMsg(ok ? "✅ Course updated successfully!"
                           : "❌ Error updating course.", ok);
                if (ok) { ResetForm(); LoadCourses(); }
            }
        }

        // ── Database operations ───────────────────────────────────────
        private bool AddCourse(string code, string name, string section,
                                string program, int instructorId, string enrollCode)
        {
            string sql = @"
                INSERT INTO Courses
                    (CourseCode, CourseName, Section, Program, InstructorId, EnrollmentCode)
                VALUES
                    (@code, @name, @section, @program, @iid, @enroll)";
            try
            {
                using (var conn = AuthService.GetConnection())
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.Parameters.AddWithValue("@program", program);
                    cmd.Parameters.AddWithValue("@iid", instructorId);
                    cmd.Parameters.AddWithValue("@enroll", enrollCode);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        private bool UpdateCourse(int id, string code, string name,
                                   string section, string program, int instructorId)
        {
            string sql = @"
                UPDATE Courses
                SET CourseCode=@code, CourseName=@name,
                    Section=@section, Program=@program, InstructorId=@iid
                WHERE CourseId=@id";
            try
            {
                using (var conn = AuthService.GetConnection())
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.Parameters.AddWithValue("@program", program);
                    cmd.Parameters.AddWithValue("@iid", instructorId);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        // ── Reset form to Add mode ────────────────────────────────────
        private void ResetForm()
        {
            _editingId = -1;
            txtCode.Text = txtName.Text = txtSection.Text = txtEnrollCode.Text = "";
            txtEnrollCode.Enabled = true;
            cboProgram.SelectedIndex = 0;
            cboInstructor.SelectedIndex = -1;
            lblFormTitle.Text = "➕  New Course";
            btnSave.Text = "SAVE COURSE";
            btnSave.BackColor = AccentColor;
            lblMsg.Text = "";
            grid.ClearSelection();
        }

        private void ShowMsg(string text, bool success)
        {
            lblMsg.Text = text;
            lblMsg.ForeColor = success ? Color.LimeGreen : Color.FromArgb(233, 69, 96);
        }
    }
}