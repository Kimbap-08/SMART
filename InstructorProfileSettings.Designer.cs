namespace SMART
{
    partial class InstructorProfileSettings
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing) { pbProfileSettings.Image?.Dispose(); components?.Dispose(); }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlHeaderInstructor = new Panel();
            lblSettingsTitle = new Label();
            btnBack = new Button();
            lblBreadcrumbSeparator = new Label();
            btnBreadcrumbSettings = new Button();
            lblBreadcrumbSectionSeparator = new Label();
            lblBreadcrumbCurrent = new Label();
            btnSwitchSection = new Button();

            pnlSettingsContent = new Panel();
            pbProfileSettings = new PictureBox();
            lblProfileName = new Label();
            btnImportPhoto = new Button();
            lblPhotoHint = new Label();
            lblProfileStatus = new Label();

            pnlHeaderInstructor.SuspendLayout();
            pnlSettingsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfileSettings).BeginInit();
            SuspendLayout();
            pnlHeaderInstructor.Name = "pnlHeaderInstructor";
            pnlHeaderInstructor.Dock = DockStyle.Top;
            pnlHeaderInstructor.Height = 100;
            pnlHeaderInstructor.BackColor = Color.FromArgb(22, 33, 62);
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
            btnBack.Click += Dashboard_Click;
            lblBreadcrumbSeparator.Name = "lblBreadcrumbSeparator";
            lblBreadcrumbSeparator.Text = "›";
            lblBreadcrumbSeparator.Location = new Point(128, 12);
            lblBreadcrumbSeparator.Size = new Size(20, 30);
            lblBreadcrumbSeparator.ForeColor = Color.FromArgb(150, 150, 170);
            lblBreadcrumbSeparator.TextAlign = ContentAlignment.MiddleCenter;
            pnlHeaderInstructor.Controls.Add(lblBreadcrumbSeparator);
            btnBreadcrumbSettings.Name = "btnBreadcrumbSettings";
            btnBreadcrumbSettings.Text = "Settings";
            btnBreadcrumbSettings.Location = new Point(148, 12);
            btnBreadcrumbSettings.Size = new Size(90, 30);
            btnBreadcrumbSettings.BackColor = Color.FromArgb(22, 33, 62);
            btnBreadcrumbSettings.ForeColor = Color.White;
            btnBreadcrumbSettings.FlatStyle = FlatStyle.Flat;
            btnBreadcrumbSettings.FlatAppearance.BorderSize = 0;
            btnBreadcrumbSettings.Cursor = Cursors.Hand;
            btnBreadcrumbSettings.Click += Back_Click;
            pnlHeaderInstructor.Controls.Add(btnBreadcrumbSettings);
            lblBreadcrumbSectionSeparator.Name = "lblBreadcrumbSectionSeparator";
            lblBreadcrumbSectionSeparator.Text = "›";
            lblBreadcrumbSectionSeparator.Location = new Point(238, 12);
            lblBreadcrumbSectionSeparator.Size = new Size(20, 30);
            lblBreadcrumbSectionSeparator.ForeColor = Color.FromArgb(150, 150, 170);
            lblBreadcrumbSectionSeparator.TextAlign = ContentAlignment.MiddleCenter;
            pnlHeaderInstructor.Controls.Add(lblBreadcrumbSectionSeparator);
            lblBreadcrumbCurrent.Name = "lblBreadcrumbCurrent";
            lblBreadcrumbCurrent.Text = "Profile";
            lblBreadcrumbCurrent.Location = new Point(258, 12);
            lblBreadcrumbCurrent.Size = new Size(100, 30);
            lblBreadcrumbCurrent.ForeColor = Color.White;
            lblBreadcrumbCurrent.TextAlign = ContentAlignment.MiddleLeft;
            pnlHeaderInstructor.Controls.Add(lblBreadcrumbCurrent);
            btnSwitchSection.Name = "btnSwitchSection";
            btnSwitchSection.Text = "Display Settings →";
            btnSwitchSection.Location = new Point(1298, 12);
            btnSwitchSection.Size = new Size(210, 30);
            btnSwitchSection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSwitchSection.BackColor = Color.FromArgb(22, 33, 62);
            btnSwitchSection.ForeColor = Color.White;
            btnSwitchSection.FlatStyle = FlatStyle.Flat;
            btnSwitchSection.FlatAppearance.BorderSize = 0;
            btnSwitchSection.Cursor = Cursors.Hand;
            btnSwitchSection.Click += SwitchSection_Click;
            pnlHeaderInstructor.Controls.Add(btnSwitchSection);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Text = "Profile Settings";
            lblSettingsTitle.Location = new Point(24, 48);
            lblSettingsTitle.Size = new Size(650, 40);
            lblSettingsTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSettingsTitle.ForeColor = Color.White;
            pnlSettingsContent.Name = "pnlSettingsContent";
            pnlSettingsContent.Dock = DockStyle.Fill;
            pnlSettingsContent.AutoScroll = true;
            pnlSettingsContent.BackColor = Color.FromArgb(13, 17, 38);
            pnlSettingsContent.Controls.Add(pbProfileSettings);
            pnlSettingsContent.Controls.Add(lblProfileName);
            pnlSettingsContent.Controls.Add(btnImportPhoto);
            pnlSettingsContent.Controls.Add(lblPhotoHint);
            pnlSettingsContent.Controls.Add(lblProfileStatus);

            pbProfileSettings.Name = "pbProfileSettings";
            pbProfileSettings.Location = new Point(32, 32);
            pbProfileSettings.Size = new Size(120, 120);
            pbProfileSettings.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfileSettings.BackColor = Color.FromArgb(22, 33, 62);
            pbProfileSettings.TabStop = false;
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Text = "Instructor";
            lblProfileName.Location = new Point(176, 36);
            lblProfileName.Size = new Size(500, 40);
            lblProfileName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProfileName.ForeColor = Color.White;
            btnImportPhoto.Name = "btnImportPhoto";
            btnImportPhoto.Text = "Import Photo";
            btnImportPhoto.Location = new Point(176, 88);
            btnImportPhoto.Size = new Size(160, 40);
            btnImportPhoto.BackColor = Color.FromArgb(233, 69, 96);
            btnImportPhoto.ForeColor = Color.White;
            btnImportPhoto.FlatStyle = FlatStyle.Flat;
            btnImportPhoto.Click += ImportPhoto_Click;
            lblPhotoHint.Name = "lblPhotoHint";
            lblPhotoHint.Text = "JPG, PNG, BMP or GIF · Maximum 5 MB";
            lblPhotoHint.Location = new Point(32, 180);
            lblPhotoHint.Size = new Size(600, 30);
            lblPhotoHint.ForeColor = Color.FromArgb(150, 150, 170);
            lblProfileStatus.Name = "lblProfileStatus";
            lblProfileStatus.Location = new Point(32, 220);
            lblProfileStatus.Size = new Size(700, 60);
            lblProfileStatus.ForeColor = Color.FromArgb(150, 150, 170);

            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(13, 17, 38);
            ClientSize = new Size(1540, 845);
            MinimumSize = new Size(800, 500);
            Controls.Add(pnlSettingsContent);
            Controls.Add(pnlHeaderInstructor);
            Name = "InstructorProfileSettings";
            Text = "Profile Settings";
            WindowState = FormWindowState.Maximized;
            pnlHeaderInstructor.ResumeLayout(false);
            pnlSettingsContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfileSettings).EndInit();
            Load += InstructorProfileSettings_Load;
            ResumeLayout(false);
        }
        #endregion
        private Panel pnlHeaderInstructor;
        private Label lblSettingsTitle;
        private Button btnBack;
        private Label lblBreadcrumbSeparator;
        private Button btnBreadcrumbSettings;
        private Label lblBreadcrumbSectionSeparator;
        private Label lblBreadcrumbCurrent;
        private Button btnSwitchSection;

        private Panel pnlSettingsContent;
        private PictureBox pbProfileSettings;
        private Label lblProfileName;
        private Button btnImportPhoto;
        private Label lblPhotoHint;
        private Label lblProfileStatus;

    }
}