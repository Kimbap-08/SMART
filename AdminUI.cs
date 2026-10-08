namespace SMART
{
    public partial class AdminUI : Form
    {
        // The fill color of the selected menu row.
        private static readonly Color ActiveRowColor = Color.FromArgb(233, 69, 96);

        private RoundedFlowLayoutPanel[] menuRows;
        private Bitmap? embeddedBackground;

        public AdminUI()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            SetupMenu();
            mainPanelAdmin.SizeChanged += (_, _) => UpdateEmbeddedBackground();
            SizeChanged += (_, _) => { UpdateEmbeddedBackground(); Invalidate(true); };
            Disposed += (_, _) => embeddedBackground?.Dispose();
           

            // Clicking anything in the Sign Out row signs the user out
            WireClicks(flpSignOutAdmin, (s, e) => SignOut());
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Runs immediately after AdminUI renders and maximizes on screen
            LoadForm(new AdminDashboard());
            flpDashboardAdmin.BackColor = Color.Transparent;
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
                row.BackColor = Color.Transparent;
                row.BorderColor = row == selected ? ActiveRowColor : Color.Transparent;
                foreach (Control child in row.Controls)
                {
                    child.BackColor = Color.Transparent;
                    if (child is Label) child.ForeColor = row == selected ? ActiveRowColor : Color.White;
                }
            }

            // Switch views in mainPanelAdmin
            if (selected == flpDashboardAdmin)
            {
                LoadForm(new AdminDashboard());
            }
            else if (selected == flpStudentsAdmin)
            {
                LoadForm(new AdminStudents());
            }
            else if (selected == flpTeachersAdmin)
            {
                LoadForm(new AdminInstructors());
            }
            else if (selected == flpCoursesAdmin)
            {
                LoadForm(new AdminCourses());
            }
            else if (selected == flpEnrollmentAdmin)
            {
                LoadForm(new AdminEnrollment());
            }
        }

        // Helper method to embed a Form inside mainPanelAdmin
        private void LoadForm(Form childForm)
        {
            foreach (Control oldForm in mainPanelAdmin.Controls.Cast<Control>().ToArray()) oldForm.Dispose();
            mainPanelAdmin.Controls.Clear();
            // Embedded forms must use the content panel's bounds, not the screen's.
            childForm.WindowState = FormWindowState.Normal;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            mainPanelAdmin.Controls.Add(childForm);
            mainPanelAdmin.Tag = childForm;
            UpdateEmbeddedBackground();
            childForm.Show();
        }

        private void UpdateEmbeddedBackground()
        {
            if (BackgroundImage == null || mainPanelAdmin.Width <= 0 || mainPanelAdmin.Height <= 0 ||
                mainPanelAdmin.Controls.Count == 0) return;
            var background = new Bitmap(mainPanelAdmin.Width, mainPanelAdmin.Height);
            using (var graphics = Graphics.FromImage(background))
            {
                graphics.DrawImage(BackgroundImage,
                    new Rectangle(-mainPanelAdmin.Left, -mainPanelAdmin.Top, ClientSize.Width, ClientSize.Height));
            }
            var oldBackground = embeddedBackground;
            embeddedBackground = background;
            mainPanelAdmin.Controls[0].BackgroundImage = background;
            mainPanelAdmin.Controls[0].BackgroundImageLayout = ImageLayout.None;
            mainPanelAdmin.Controls[0].Invalidate(true);
            oldBackground?.Dispose();
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
