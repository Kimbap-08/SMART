namespace SMART
{
    public partial class AdminUI : Form
    {
        // The fill color of the selected menu row.
        private static readonly Color ActiveRowColor = Color.FromArgb(233, 69, 96);

        private RoundedFlowLayoutPanel[] menuRows;

        public AdminUI()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            SetupMenu();
           

            // Clicking anything in the Sign Out row signs the user out
            WireClicks(flpSignOutAdmin, (s, e) => SignOut());
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Runs immediately after AdminUI renders and maximizes on screen
            LoadForm(new AdminDashboard());
            flpDashboardAdmin.BackColor = ActiveRowColor;
        }



        private void SetupMenu()
        {
            menuRows = new[]
            {
                flpDashboardAdmin, flpStudentsAdmin, flpTeachersAdmin,
                flpCoursesAdmin, flpEnrollmentAdmin
            };

            foreach (RoundedFlowLayoutPanel row in menuRows)
            {
                RoundedFlowLayoutPanel current = row;   // each handler remembers its own row
                WireClicks(row, (s, e) => SelectRow(current));
            }

            SelectRow(flpDashboardAdmin);   // start on Dashboard.
        }

        private void SelectRow(RoundedFlowLayoutPanel selected)
        {
            foreach (RoundedFlowLayoutPanel row in menuRows)
            {
                // The selected row gets the color, the others take the sidebar's color
                row.BackColor = (row == selected) ? ActiveRowColor : row.Parent.BackColor;
            }

            // Switch views in mainPanelAdmin
            if (selected == flpDashboardAdmin)
            {
                LoadForm(new AdminDashboard());
            }
            else if (selected == flpStudentsAdmin)
            {
                LoadForm(new Students());
            }
            else if (selected == flpTeachersAdmin)
            {
                // LoadForm(new Teachers());
            }
            else if (selected == flpCoursesAdmin)
            {
                LoadForm(new AdminCourses());
            }
            else if (selected == flpEnrollmentAdmin)
            {
                // LoadForm(new Enrollment());
            }
        }

        // Helper method to embed a Form inside mainPanelAdmin
        private void LoadForm(Form childForm)
        {
            mainPanelAdmin.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanelAdmin.Controls.Add(childForm);
            mainPanelAdmin.Tag = childForm;
            childForm.Show();
        }

        // Makes a control, and everything inside it (icon, text, inner panels), react to clicks
        private static void WireClicks(Control control, EventHandler handler)
        {
            control.Cursor = Cursors.Hand;
            control.Click += handler;

            foreach (Control child in control.Controls)
                WireClicks(child, handler);
        }

        private void SignOut()
        {
            Session.CurrentUser = null;
            Close();
        }

        private void flpSignOutAdmin_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
