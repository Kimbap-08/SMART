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
    public partial class Students : Form
    {

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

            listDept.DataSource = allDepartments;
            listDept.Visible = false; // Initially hide the list
            listDept.Click += listDept_Click;
            listDept.MouseMove += listDept_MouseMove;

        }

        private void rTbDepartment_TextChanged(object sender, EventArgs e)
        {
            string filter = rTbDepartment.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(filter))
            {
                listDept.Visible = false;
            }
            else
            {
                var matches = allDepartments
                    .Where(d => d.ToLower().Contains(filter))
                    .ToList();

                if (matches.Count > 0)
                {
                    listDept.DataSource = matches;

                    // Position list directly underneath
                    listDept.Left = pnlDept.Left;
                    listDept.Top = pnlDept.Bottom + 2;

                    // Calculate the width of the longest string + buffer for the scrollbar
                    int maxTextWidth = matches.Max(m => TextRenderer.MeasureText(m, listDept.Font).Width);
                    listDept.Width = Math.Max(pnlDept.Width, maxTextWidth + 35); // 35px padding for scrollbar

                    listDept.Height = 130;

                    listDept.Visible = true;
                    listDept.BringToFront();
                }
                else
                {
                    listDept.Visible = false;
                }

                if (string.IsNullOrWhiteSpace(rTbDepartment.Text))
                {
                    // Reset to initial standard width when text box is cleared
                    pnlDept.Width = 220;
                    rTbDepartment.Width = 220;
                    listDept.Visible = false;
                }

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

        private void pnlSearchSort_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void cPnlAddStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listDept_Click(object sender, EventArgs e)
        {
            if (listDept.SelectedItem != null)
            {
                string selectedDept = listDept.SelectedItem.ToString();

                // 1. Assign the selected text to the department textbox
                rTbDepartment.Text = selectedDept;

                // 2. Measure the exact pixel width of the text using the textbox's font
                int textWidth = TextRenderer.MeasureText(selectedDept, rTbDepartment.Font).Width;

                // 3. Add padding for rounded corners and internal margins (e.g., 30px)
                int padding = 30;
                int newWidth = textWidth + padding;

                // 4. Set a minimum width so short texts don't make the textbox look too small
                int minWidth = 220; // Default design width
                int finalWidth = Math.Max(newWidth, minWidth);

                // 5. Apply the calculated width to both the panel container and the textbox
                pnlDept.Width = finalWidth;
                rTbDepartment.Width = finalWidth;

                // 6. Hide the dropdown list
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

    }
}
