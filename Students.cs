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
            rTbProgram.TextChanged += rTbProgram_TextChanged;
            listProgram.MouseMove += listProgram_MouseMove;
            listProgram.Click += listProgram_Click;

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

        private void rTbProgram_TextChanged(object sender, EventArgs e)
        {
            string selectedDept = rTbDepartment.Text.Trim();

            // 1. Ensure user has chosen a valid Department first
            if (string.IsNullOrWhiteSpace(selectedDept) || !deptProgramsMap.ContainsKey(selectedDept))
            {
                listProgram.Visible = false;
                return;
            }

            string filter = rTbProgram.Text.ToLower().Trim();
            var availablePrograms = deptProgramsMap[selectedDept];

            // 2. Filter programs belonging ONLY to the chosen department
            var matches = availablePrograms
                .Where(p => p.ToLower().Contains(filter))
                .ToList();

            if (matches.Count > 0 && !string.IsNullOrWhiteSpace(filter))
            {
                listProgram.DataSource = matches;

                // Position directly under pnlProgram
                listProgram.Left = pnlProgram.Left;
                listProgram.Top = pnlProgram.Bottom + 2;

                // Dynamic width calculation
                int maxTextWidth = matches.Max(m => TextRenderer.MeasureText(m, listProgram.Font).Width);
                listProgram.Width = Math.Max(pnlProgram.Width, maxTextWidth + 35);
                listProgram.Height = 120;

                listProgram.Visible = true;
                listProgram.BringToFront();
            }
            else
            {
                listProgram.Visible = false;
            }
        }

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

    }
}
