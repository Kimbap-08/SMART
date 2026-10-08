namespace SMART
{
    partial class InstructorDisplaySettings
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
            pnlHeaderInstructor = new Panel();
            lblSettingsTitle = new Label();
            btnBack = new Button();
            lblBreadcrumbSeparator = new Label();
            btnBreadcrumbSettings = new Button();
            lblBreadcrumbSectionSeparator = new Label();
            lblBreadcrumbCurrent = new Label();
            btnSwitchSection = new Button();

            pnlSettingsContent = new Panel();
            lblDisplayMode = new Label();
            cmbDisplayMode = new ComboBox();

            pnlHeaderInstructor.SuspendLayout();
            pnlSettingsContent.SuspendLayout();

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
            lblBreadcrumbCurrent.Text = "Display";
            lblBreadcrumbCurrent.Location = new Point(258, 12);
            lblBreadcrumbCurrent.Size = new Size(100, 30);
            lblBreadcrumbCurrent.ForeColor = Color.White;
            lblBreadcrumbCurrent.TextAlign = ContentAlignment.MiddleLeft;
            pnlHeaderInstructor.Controls.Add(lblBreadcrumbCurrent);
            btnSwitchSection.Name = "btnSwitchSection";
            btnSwitchSection.Text = "Profile Settings →";
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
            lblSettingsTitle.Text = "Display Settings";
            lblSettingsTitle.Location = new Point(24, 48);
            lblSettingsTitle.Size = new Size(650, 40);
            lblSettingsTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSettingsTitle.ForeColor = Color.White;
            pnlSettingsContent.Name = "pnlSettingsContent";
            pnlSettingsContent.Dock = DockStyle.Fill;
            pnlSettingsContent.AutoScroll = true;
            pnlSettingsContent.BackColor = Color.FromArgb(13, 17, 38);
            pnlSettingsContent.Controls.Add(lblDisplayMode);
            pnlSettingsContent.Controls.Add(cmbDisplayMode);

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
            cmbDisplayMode.Font = new Font("Segoe UI Emoji", 11F);
            cmbDisplayMode.Items.AddRange(new object[] { "🌙 Dark", "☀ Light" });
            cmbDisplayMode.SelectedIndexChanged += DisplayMode_Changed;

            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(13, 17, 38);
            ClientSize = new Size(1540, 845);
            MinimumSize = new Size(800, 500);
            Controls.Add(pnlSettingsContent);
            Controls.Add(pnlHeaderInstructor);
            Name = "InstructorDisplaySettings";
            Text = "Display Settings";
            WindowState = FormWindowState.Maximized;
            pnlHeaderInstructor.ResumeLayout(false);
            pnlSettingsContent.ResumeLayout(false);

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
        private Label lblDisplayMode;
        private ComboBox cmbDisplayMode;

    }
}