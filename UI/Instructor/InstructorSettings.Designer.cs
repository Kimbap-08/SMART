using System.Drawing;
using System.Windows.Forms;
namespace SMART
{
    partial class InstructorSettings
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing) {  components?.Dispose(); }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorSettings));
            pnlHeaderInstructor = new Panel();
            lblSettingsTitle = new Label();
            btnBack = new Button();
            lblBreadcrumbSeparator = new Label();
            lblBreadcrumbCurrent = new Label();
            lblBreadcrumbSection = new Label();

            pnlSettingsContent = new Panel();
            pnlSettingsSidebar = new TranslucentSidebarPanel();
            flpProfileSettings = new RoundedFlowLayoutPanel();
            picProfileSettings = new PictureBox();
            lblProfileSettings = new Label();
            flpDisplaySettings = new RoundedFlowLayoutPanel();
            picDisplaySettings = new PictureBox();
            lblDisplaySettings = new Label();

            pnlHeaderInstructor.SuspendLayout();
            pnlSettingsContent.SuspendLayout();
            pnlSettingsSidebar.SuspendLayout();
            flpProfileSettings.SuspendLayout();
            flpDisplaySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfileSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDisplaySettings).BeginInit();

            SuspendLayout();
            pnlHeaderInstructor.Name = "pnlHeaderInstructor";
            pnlHeaderInstructor.Dock = DockStyle.Top;
            pnlHeaderInstructor.Height = 100;
            pnlHeaderInstructor.BackColor = Color.FromArgb(178, 22, 33, 62);
            pnlHeaderInstructor.Controls.Add(lblSettingsTitle);
            pnlHeaderInstructor.Controls.Add(btnBack);
            btnBack.Name = "btnBack";
            btnBack.Text = "Dashboard";
            btnBack.Location = new Point(24, 12);
            btnBack.Size = new Size(104, 30);
            btnBack.BackColor = Color.FromArgb(22, 33, 62);
            btnBack.ForeColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Click += Back_Click;
            lblBreadcrumbSeparator.Name = "lblBreadcrumbSeparator";
            lblBreadcrumbSeparator.Text = "›";
            lblBreadcrumbSeparator.Location = new Point(128, 12);
            lblBreadcrumbSeparator.Size = new Size(20, 30);
            lblBreadcrumbSeparator.ForeColor = Color.FromArgb(150, 150, 170);
            lblBreadcrumbSeparator.TextAlign = ContentAlignment.MiddleCenter;
            pnlHeaderInstructor.Controls.Add(lblBreadcrumbSeparator);
            lblBreadcrumbCurrent.Name = "lblBreadcrumbCurrent";
            lblBreadcrumbCurrent.Text = "Settings";
            lblBreadcrumbCurrent.Location = new Point(148, 12);
            lblBreadcrumbCurrent.Size = new Size(100, 30);
            lblBreadcrumbCurrent.ForeColor = Color.White;
            lblBreadcrumbCurrent.TextAlign = ContentAlignment.MiddleLeft;
            lblBreadcrumbCurrent.Cursor = Cursors.Hand;
            lblBreadcrumbCurrent.Click += SettingsCheckpoint_Click;
            pnlHeaderInstructor.Controls.Add(lblBreadcrumbCurrent);
            lblBreadcrumbSection.Name = "lblBreadcrumbSection";
            lblBreadcrumbSection.Location = new Point(248, 12);
            lblBreadcrumbSection.Size = new Size(150, 30);
            lblBreadcrumbSection.ForeColor = Color.White;
            lblBreadcrumbSection.TextAlign = ContentAlignment.MiddleLeft;
            pnlHeaderInstructor.Controls.Add(lblBreadcrumbSection);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Text = "Instructor Settings";
            lblSettingsTitle.Location = new Point(24, 48);
            lblSettingsTitle.Size = new Size(650, 40);
            lblSettingsTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSettingsTitle.ForeColor = Color.White;
            pnlSettingsContent.Name = "pnlSettingsContent";
            pnlSettingsContent.Dock = DockStyle.Fill;
            pnlSettingsContent.AutoScroll = true;
            pnlSettingsContent.BackColor = Color.Transparent;


            // pnlSettingsSidebar
            pnlSettingsSidebar.Name = "pnlSettingsSidebar";
            pnlSettingsSidebar.Dock = DockStyle.Left;
            pnlSettingsSidebar.Size = new Size(226, 745);
            pnlSettingsSidebar.BackColor = Color.FromArgb(22, 33, 62);
            pnlSettingsSidebar.Controls.Add(flpProfileSettings);
            pnlSettingsSidebar.Controls.Add(flpDisplaySettings);
            // flpProfileSettings
            flpProfileSettings.Name = "flpProfileSettings";
            flpProfileSettings.BorderColor = Color.Transparent;
            flpProfileSettings.BorderRadius = 5;
            flpProfileSettings.BorderSize = 1;
            flpProfileSettings.Location = new Point(12, 24);
            flpProfileSettings.Size = new Size(200, 40);
            flpProfileSettings.Padding = new Padding(4, 0, 0, 0);
            flpProfileSettings.WrapContents = false;
            flpProfileSettings.Cursor = Cursors.Hand;
            flpProfileSettings.Controls.Add(picProfileSettings);
            flpProfileSettings.Controls.Add(lblProfileSettings);
            flpProfileSettings.Click += BtnProfileSettings_Click;
            // picProfileSettings
            picProfileSettings.Name = "picProfileSettings";
            picProfileSettings.BackgroundImage = (Image)resources.GetObject("picProfileSettings.BackgroundImage" );
            picProfileSettings.BackgroundImageLayout = ImageLayout.Zoom;
            picProfileSettings.Location = new Point(7, 3);
            picProfileSettings.Size = new Size(30, 30);
            picProfileSettings.TabStop = false;
            picProfileSettings.Cursor = Cursors.Hand;
            picProfileSettings.Click += BtnProfileSettings_Click;
            // lblProfileSettings
            lblProfileSettings.Name = "lblProfileSettings";
            lblProfileSettings.Text = "Profile";
            lblProfileSettings.Anchor = AnchorStyles.None;
            lblProfileSettings.Font = new Font("Bahnschrift", 10F);
            lblProfileSettings.ForeColor = Color.White;
            lblProfileSettings.Location = new Point(43, 6);
            lblProfileSettings.Size = new Size(135, 23);
            lblProfileSettings.TextAlign = ContentAlignment.MiddleLeft;
            lblProfileSettings.Cursor = Cursors.Hand;
            lblProfileSettings.Click += BtnProfileSettings_Click;

            // flpDisplaySettings
            flpDisplaySettings.Name = "flpDisplaySettings";
            flpDisplaySettings.BorderColor = Color.Transparent;
            flpDisplaySettings.BorderRadius = 5;
            flpDisplaySettings.BorderSize = 1;
            flpDisplaySettings.Location = new Point(12, 69);
            flpDisplaySettings.Size = new Size(200, 40);
            flpDisplaySettings.Padding = new Padding(4, 0, 0, 0);
            flpDisplaySettings.WrapContents = false;
            flpDisplaySettings.Cursor = Cursors.Hand;
            flpDisplaySettings.Controls.Add(picDisplaySettings);
            flpDisplaySettings.Controls.Add(lblDisplaySettings);
            flpDisplaySettings.Click += BtnDisplaySettings_Click;
            // picDisplaySettings
            picDisplaySettings.Name = "picDisplaySettings";
            picDisplaySettings.BackgroundImage = (Image)resources.GetObject("picDisplaySettings.BackgroundImage" );
            picDisplaySettings.BackgroundImageLayout = ImageLayout.Zoom;
            picDisplaySettings.Location = new Point(7, 3);
            picDisplaySettings.Size = new Size(30, 30);
            picDisplaySettings.TabStop = false;
            picDisplaySettings.Cursor = Cursors.Hand;
            picDisplaySettings.Click += BtnDisplaySettings_Click;
            // lblDisplaySettings
            lblDisplaySettings.Name = "lblDisplaySettings";
            lblDisplaySettings.Text = "Display";
            lblDisplaySettings.Anchor = AnchorStyles.None;
            lblDisplaySettings.Font = new Font("Bahnschrift", 10F);
            lblDisplaySettings.ForeColor = Color.White;
            lblDisplaySettings.Location = new Point(43, 6);
            lblDisplaySettings.Size = new Size(135, 23);
            lblDisplaySettings.TextAlign = ContentAlignment.MiddleLeft;
            lblDisplaySettings.Cursor = Cursors.Hand;
            lblDisplaySettings.Click += BtnDisplaySettings_Click;

            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(13, 17, 38);
            ClientSize = new Size(1540, 845);
            MinimumSize = new Size(800, 500);
            BackgroundImage = (Image)resources.GetObject("SettingsBackground.Image");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pnlSettingsContent);
            Controls.Add(pnlSettingsSidebar);
            Controls.Add(pnlHeaderInstructor);
            Name = "InstructorSettings";
            Text = "Instructor Settings";
            WindowState = FormWindowState.Maximized;
            pnlHeaderInstructor.ResumeLayout(false);
            pnlSettingsContent.ResumeLayout(false);
            pnlSettingsSidebar.ResumeLayout(false);
            flpProfileSettings.ResumeLayout(false);
            flpDisplaySettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProfileSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDisplaySettings).EndInit();

            ResumeLayout(false);
        }
        #endregion
        private Panel pnlHeaderInstructor;
        private Label lblSettingsTitle;
        private Button btnBack;
        private Label lblBreadcrumbSeparator;
        private Label lblBreadcrumbCurrent;
        private Label lblBreadcrumbSection;

        private Panel pnlSettingsContent;
        private TranslucentSidebarPanel pnlSettingsSidebar;
        private RoundedFlowLayoutPanel flpProfileSettings;
        private PictureBox picProfileSettings;
        private Label lblProfileSettings;
        private RoundedFlowLayoutPanel flpDisplaySettings;
        private PictureBox picDisplaySettings;
        private Label lblDisplaySettings;

    }
}