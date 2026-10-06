using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public AdminCourses()
        {
            InitializeComponent();
            StyleDataGridView();
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
                    (lblDay, (Control)listDay, 145),
                    (lblTerm, (Control)listBoxTerm, 145)
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
                listBoxAssignInstructor.SetBounds(pnlAssignInstructor.Left, pnlAssignInstructor.Bottom + 2,
                    pnlAssignInstructor.Width, listBoxAssignInstructor.Height);
                listProgramCourses.SetBounds(pnlProgramCourses.Left, pnlProgramCourses.Bottom + 2,
                    pnlProgramCourses.Width, listProgramCourses.Height);

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
