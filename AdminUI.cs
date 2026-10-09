using System.Data;
using System.Data.SqlClient;

namespace SMART
{
    public partial class AdminUI : Form
    {
        // The fill color of the selected menu row.
        private static readonly Color ActiveRowColor = Color.FromArgb(233, 69, 96);

        private RoundedFlowLayoutPanel[] menuRows;
        private RoundedFlowLayoutPanel flpAnnouncementsAdmin;
        private RoundedFlowLayoutPanel flpInboxAdmin;
        private Label lblInboxBadge;
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

            AddAnnouncementsMenuRow();
            AddInboxMenuRow();
            SetupMenu();
            InitializeAssistInbox();
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
                flpCoursesAdmin, flpEnrollmentAdmin, flpAnnouncementsAdmin, flpInboxAdmin
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
                else if (selected == flpInboxAdmin)
                {
                    LoadInboxPage();
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
                        child.BackColor = child == lblInboxBadge && lblInboxBadge.Visible
                            ? Color.FromArgb(180, 35, 55) : Color.Transparent;
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

        private void AddAnnouncementsMenuRow()
        {
            flpAnnouncementsAdmin = new RoundedFlowLayoutPanel
            {
                Name = "flpAnnouncementsAdmin",
                Location = new Point(9, flpEnrollmentAdmin.Bottom + 5),
                Size = new Size(200, 40),
                Padding = new Padding(4, 0, 0, 0),
                BackColor = cPanelSideBarAdmin.BackColor,
                BorderColor = Color.Transparent,
                BorderRadius = 5,
                Cursor = Cursors.Hand
            };
            flpAnnouncementsAdmin.Controls.Add(new Label
            {
                Text = "📢  Announcements",
                Location = new Point(7, 6),
                Size = new Size(175, 28),
                ForeColor = Color.White,
                Font = new Font("Bahnschrift", 10F),
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent
            });
            cPanelSideBarAdmin.Controls.Add(flpAnnouncementsAdmin);
            flpAnnouncementsAdmin.BringToFront();
        }

        private void AddInboxMenuRow()
        {
            flpInboxAdmin = new RoundedFlowLayoutPanel
            {
                Name = "flpInboxAdmin",
                Location = new Point(9, flpAnnouncementsAdmin.Bottom + 5),
                Size = new Size(200, 40),
                Padding = new Padding(4, 0, 0, 0),
                BackColor = cPanelSideBarAdmin.BackColor,
                BorderColor = Color.Transparent,
                BorderRadius = 5,
                Cursor = Cursors.Hand,
                WrapContents = false
            };
            flpInboxAdmin.Controls.Add(new Label
            {
                Text = "📬  Inbox", Location = new Point(7, 6), Size = new Size(145, 28),
                ForeColor = Color.White, Font = new Font("Bahnschrift", 10F),
                TextAlign = ContentAlignment.MiddleLeft, BackColor = Color.Transparent,
                Cursor = Cursors.Hand
            });
            lblInboxBadge = new Label
            {
                Text = "0", Location = new Point(158, 8), Size = new Size(30, 23),
                ForeColor = Color.White, BackColor = Color.FromArgb(180, 35, 55),
                Font = new Font("Segoe UI", 8F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter,
                Visible = false, Cursor = Cursors.Hand
            };
            flpInboxAdmin.Controls.Add(lblInboxBadge);
            cPanelSideBarAdmin.Controls.Add(flpInboxAdmin);
            flpInboxAdmin.BringToFront();
        }

        private void InitializeAssistInbox()
        {
            try
            {
                using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
                DatabaseConnection.Open(connection);
                using (var create = new SqlCommand(@"IF OBJECT_ID(N'dbo.AssistMessages', N'U') IS NULL
                    CREATE TABLE dbo.AssistMessages (
                        MessageId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_AssistMessages PRIMARY KEY,
                        InstructorEmployeeID NVARCHAR(50) NOT NULL REFERENCES dbo.Instructors(EmployeeID),
                        InstructorName NVARCHAR(100) NOT NULL,
                        Subject NVARCHAR(200) NOT NULL,
                        Message NVARCHAR(MAX) NOT NULL,
                        SentAt DATETIME NOT NULL CONSTRAINT DF_AssistMessages_SentAt DEFAULT GETDATE(),
                        IsRead BIT NOT NULL CONSTRAINT DF_AssistMessages_IsRead DEFAULT (0),
                        IsResolved BIT NOT NULL CONSTRAINT DF_AssistMessages_IsResolved DEFAULT (0),
                        AdminReply NVARCHAR(MAX) NULL,
                        RepliedAt DATETIME NULL
                    );", connection))
                    create.ExecuteNonQuery();
                RefreshInboxBadge(connection);
            }
            catch (SqlException)
            {
                lblInboxBadge.Visible = false;
            }
        }

        private void RefreshInboxBadge(SqlConnection? existingConnection = null)
        {
            try
            {
                if (existingConnection == null)
                {
                    using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
                    DatabaseConnection.Open(connection);
                    SetInboxBadge(connection);
                }
                else SetInboxBadge(existingConnection);
            }
            catch (SqlException) { lblInboxBadge.Visible = false; }
        }

        private void SetInboxBadge(SqlConnection connection)
        {
            using var command = new SqlCommand("SELECT COUNT(*) FROM dbo.AssistMessages WHERE IsRead = 0", connection);
            int unread = Convert.ToInt32(command.ExecuteScalar());
            lblInboxBadge.Text = unread > 99 ? "99+" : unread.ToString();
            lblInboxBadge.Visible = unread > 0;
        }

        private void LoadInboxPage()
        {
            var oldPages = mainPanelAdmin.Controls.Cast<Control>().ToArray();
            var page = new InboxControl { Dock = DockStyle.Fill };
            page.UnreadCountChanged += (_, _) => RefreshInboxBadge();
            page.BackColor = Color.FromArgb(13, 17, 38);
            page.BackgroundImage = embeddedBackground;
            page.BackgroundImageLayout = ImageLayout.None;
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
