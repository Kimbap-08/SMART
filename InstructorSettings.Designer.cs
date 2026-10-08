namespace SMART
{
    partial class InstructorSettings
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
            btnBackDashboard = new Button();
            settingsTabs = new TabControl();
            profileTab = new TabPage();
            displayTab = new TabPage();
            pbProfileSettings = new PictureBox();
            lblProfileName = new Label();
            btnImportPhoto = new Button();
            lblProfileStatus = new Label();
            lblPhotoHint = new Label();
            lblDisplayMode = new Label();
            cmbDisplayMode = new ComboBox();
            pnlHeaderInstructor.SuspendLayout();
            settingsTabs.SuspendLayout();
            profileTab.SuspendLayout();
            displayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfileSettings).BeginInit();
            SuspendLayout();
            pnlHeaderInstructor.Name = "pnlHeaderInstructor";
            pnlHeaderInstructor.Dock = DockStyle.Top;
            pnlHeaderInstructor.Height = 100;
            pnlHeaderInstructor.BackColor = Color.FromArgb(22, 33, 62);
            pnlHeaderInstructor.Controls.Add(lblSettingsTitle);
            pnlHeaderInstructor.Controls.Add(btnBackDashboard);
            btnBackDashboard.Name = "btnBackDashboard";
            btnBackDashboard.Text = "← Back to Dashboard";
            btnBackDashboard.Location = new Point(24, 12);
            btnBackDashboard.Size = new Size(200, 30);
            btnBackDashboard.BackColor = Color.FromArgb(22, 33, 62);
            btnBackDashboard.ForeColor = Color.White;
            btnBackDashboard.FlatStyle = FlatStyle.Flat;
            btnBackDashboard.FlatAppearance.BorderSize = 0;
            btnBackDashboard.Click += Back_Click;
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Text = "Instructor Settings";
            lblSettingsTitle.Location = new Point(24, 48);
            lblSettingsTitle.Size = new Size(500, 40);
            lblSettingsTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSettingsTitle.ForeColor = Color.White;
            settingsTabs.Name = "settingsTabs";
            settingsTabs.Dock = DockStyle.Fill;
            settingsTabs.Font = new Font("Segoe UI", 11F);
            settingsTabs.Controls.Add(profileTab);
            settingsTabs.Controls.Add(displayTab);
            profileTab.Name = "profileTab";
            profileTab.Text = "Profile";
            profileTab.BackColor = Color.FromArgb(13, 17, 38);
            profileTab.Controls.Add(pbProfileSettings);
            profileTab.Controls.Add(lblProfileName);
            profileTab.Controls.Add(btnImportPhoto);
            profileTab.Controls.Add(lblPhotoHint);
            profileTab.Controls.Add(lblProfileStatus);
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
            displayTab.Name = "displayTab";
            displayTab.Text = "Display";
            displayTab.BackColor = Color.FromArgb(13, 17, 38);
            displayTab.Controls.Add(lblDisplayMode);
            displayTab.Controls.Add(cmbDisplayMode);
            lblDisplayMode.Name = "lblDisplayMode";
            lblDisplayMode.Text = "Appearance";
            lblDisplayMode.Location = new Point(32, 32);
            lblDisplayMode.Size = new Size(250, 40);
            lblDisplayMode.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDisplayMode.ForeColor = Color.White;
            cmbDisplayMode.Name = "cmbDisplayMode";
            cmbDisplayMode.Location = new Point(32, 88);
            cmbDisplayMode.Size = new Size(240, 32);
            cmbDisplayMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisplayMode.Items.AddRange(new object[] { "Dark", "Light" });
            cmbDisplayMode.SelectedIndexChanged += DisplayMode_Changed;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(13, 17, 38);
            ClientSize = new Size(1540, 845);
            MinimumSize = new Size(800, 500);
            Controls.Add(settingsTabs);
            Controls.Add(pnlHeaderInstructor);
            Name = "InstructorSettings";
            Text = "Instructor Settings";
            WindowState = FormWindowState.Maximized;
            pnlHeaderInstructor.ResumeLayout(false);
            settingsTabs.ResumeLayout(false);
            profileTab.ResumeLayout(false);
            displayTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfileSettings).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private Panel pnlHeaderInstructor;
        private Label lblSettingsTitle;
        private Button btnBackDashboard;
        private TabControl settingsTabs;
        private TabPage profileTab;
        private TabPage displayTab;
        private PictureBox pbProfileSettings;
        private Label lblProfileName;
        private Button btnImportPhoto;
        private Label lblPhotoHint;
        private Label lblProfileStatus;
        private Label lblDisplayMode;
        private ComboBox cmbDisplayMode;
    }
}