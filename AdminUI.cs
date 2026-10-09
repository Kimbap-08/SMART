namespace SMART
{
    public partial class AdminUI : Form
    {
        // The fill color of the selected menu row.
        private static readonly Color ActiveRowColor = Color.FromArgb(233, 69, 96);

        private RoundedFlowLayoutPanel[] menuRows;
        private Bitmap? embeddedBackground;
        private Rectangle cachedPanelBounds;
        private Size cachedClientSize;
        private RoundedFlowLayoutPanel? activeRow;
        private bool navigating;

        public AdminUI()
        {
            InitializeComponent();
            DoubleBuffered = true;
            WindowState = FormWindowState.Maximized;

            SetupMenu();
            mainPanelAdmin.SizeChanged += (_, _) => UpdateEmbeddedBackground();
            SizeChanged += (_, _) => UpdateEmbeddedBackground();
            Disposed += (_, _) => embeddedBackground?.Dispose();
           

            // Clicking anything in the Sign Out row signs the user out
            WireClicks(flpSignOutAdmin, (s, e) => SignOut());
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Runs immediately after AdminUI renders and maximizes on screen
            SelectRow(flpDashboardAdmin);
        }



        private void SetupMenu()
        {
            menuRows = new[]
            {
                flpDashboardAdmin, flpStudentsAdmin, flpTeachersAdmin,
                flpCoursesAdmin, flpEnrollmentAdmin, flpAnnouncementsAdmin
            };

            foreach (RoundedFlowLayoutPanel row in menuRows)
            {
                RoundedFlowLayoutPanel current = row;   // each handler remembers its own row
                WireClicks(row, (s, e) => SelectRow(current));
            }

            // The initial dashboard is loaded once, after the shell is shown.
        }

        private void SelectRow(RoundedFlowLayoutPanel selected)
        {
            if (navigating || activeRow == selected) return;
            navigating = true;
            try
            {
                if (selected == flpAnnouncementsAdmin)
                {
                    LoadAnnouncementsPage();
                }
                else
                {
                    Form childForm = selected == flpDashboardAdmin ? new AdminDashboard()
                        : selected == flpStudentsAdmin ? new AdminStudents()
                        : selected == flpTeachersAdmin ? new AdminInstructors()
                        : selected == flpCoursesAdmin ? new AdminCourses()
                        : new AdminEnrollment();
                    LoadForm(childForm);
                }
                activeRow = selected;
                foreach (RoundedFlowLayoutPanel row in menuRows)
                {
                    row.BackColor = row == selected ? Color.FromArgb(110, ActiveRowColor) : Color.Transparent;
                    row.BorderColor = row == selected ? Color.FromArgb(190, ActiveRowColor) : Color.Transparent;
                    row.BorderSize = row == selected ? 1 : 0;
                    foreach (Control child in row.Controls)
                    {
                        child.BackColor = Color.Transparent;
                        if (child is Label) child.ForeColor = Color.White;
                    }
                }
            }
            finally { navigating = false; }
        }

        private void LoadAnnouncementsPage()
        {
            var oldPages = mainPanelAdmin.Controls.Cast<Control>().ToArray();
            var page = new AnnouncementsAdmin
            {
                Dock = DockStyle.Fill,
                BackgroundImage = embeddedBackground,
                BackgroundImageLayout = ImageLayout.None
            };
            mainPanelAdmin.SuspendLayout();
            try
            {
                mainPanelAdmin.Controls.Add(page);
                UpdateEmbeddedBackground();
                page.BringToFront();
                mainPanelAdmin.Tag = page;
                foreach (Control oldPage in oldPages) oldPage.Dispose();
            }
            catch
            {
                page.Dispose();
                throw;
            }
            finally { mainPanelAdmin.ResumeLayout(true); }
        }

        // Helper method to embed a Form inside mainPanelAdmin
        private void LoadForm(Form childForm)
        {
            var oldForms = mainPanelAdmin.Controls.Cast<Control>().ToArray();
            mainPanelAdmin.SuspendLayout();
            try
            {
                childForm.WindowState = FormWindowState.Normal;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.Bounds = mainPanelAdmin.ClientRectangle;
                mainPanelAdmin.Controls.Add(childForm);
                UpdateEmbeddedBackground(childForm);
                childForm.Show();
                childForm.BringToFront();
                mainPanelAdmin.Tag = childForm;
                foreach (Control oldForm in oldForms) oldForm.Dispose();
            }
            catch
            {
                childForm.Dispose();
                throw;
            }
            finally { mainPanelAdmin.ResumeLayout(true); }
        }

        private void UpdateEmbeddedBackground(Form? target = null)
        {
            if (BackgroundImage == null || mainPanelAdmin.Width <= 0 || mainPanelAdmin.Height <= 0) return;
            if (embeddedBackground == null || cachedPanelBounds != mainPanelAdmin.Bounds || cachedClientSize != ClientSize)
            {
                var background = new Bitmap(mainPanelAdmin.Width, mainPanelAdmin.Height);
                using (var graphics = Graphics.FromImage(background))
                {
                    graphics.DrawImage(BackgroundImage,
                        new Rectangle(-mainPanelAdmin.Left, -mainPanelAdmin.Top, ClientSize.Width, ClientSize.Height));
                }
                var oldBackground = embeddedBackground;
                embeddedBackground = background;
                cachedPanelBounds = mainPanelAdmin.Bounds;
                cachedClientSize = ClientSize;
                foreach (Control child in mainPanelAdmin.Controls)
                {
                    child.BackgroundImage = background;
                    child.BackgroundImageLayout = ImageLayout.None;
                }
                oldBackground?.Dispose();
            }
            if (target != null)
            {
                target.BackgroundImage = embeddedBackground;
                target.BackgroundImageLayout = ImageLayout.None;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parameters = base.CreateParams;
                // Compose the child windows together to prevent blank flashes during navigation.
                parameters.ExStyle |= 0x02000000;
                return parameters;
            }
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
