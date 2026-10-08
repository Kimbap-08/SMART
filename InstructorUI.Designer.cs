namespace SMART
{
    partial class InstructorUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorUI));
            flpSettingsInstructor = new RoundedFlowLayoutPanel();
            picSettingsInstructor = new PictureBox();
            lblSettingsInstructor = new Label();
            shell = new CustomPanel();
            cPanelSideBarInstructor = new CustomPanel();
            flpLogoInstructor = new CustomPanel();
            profile = new CustomPanel();
            pbProfile = new PictureBox();
            profileNameLabel = new Label();
            spacer = new CustomPanel();
            content = new CustomPanel();
            courseCards = new RoundedFlowLayoutPanel();
            lblSMARTInstructor = new Label();
            lblInstructorPanel = new Label();
            topDivider = new CustomPanel();
            bottomDivider = new CustomPanel();
            flpDashboardInstructor = new RoundedFlowLayoutPanel();
            picDashboardInstructor = new PictureBox();
            lblDashboardInstructor = new Label();
            flpSignOutInstructor = new RoundedFlowLayoutPanel();
            picSignOutInstructor = new PictureBox();
            lblSignOutInstructor = new Label();
            lblWelcomeInstructor = new Label();
            lblCurr = new Label();
            cPnlCourseHolder = new CustomPanel();
            lblCourse = new Label();
            lblCourseName = new Label();
            lblCourseCode = new Label();
            lblCourseDetails = new Label();
            lblCourseStudents = new Label();
            lblCourseOpen = new Label();

            shell.SuspendLayout();
            cPanelSideBarInstructor.SuspendLayout();
            flpLogoInstructor.SuspendLayout();
            profile.SuspendLayout();
            content.SuspendLayout();
            courseCards.SuspendLayout();
            cPnlCourseHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            flpDashboardInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDashboardInstructor).BeginInit();
            flpSignOutInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSignOutInstructor).BeginInit();
            flpSettingsInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSettingsInstructor).BeginInit();
            SuspendLayout();
            // shell
            shell.Name = "shell";
            shell.Dock = DockStyle.Fill;
            shell.BackColor = Color.FromArgb(13, 17, 38);
            shell.BorderWidth = 0;
            shell.CornerRadius = 1;
            // cPanelSideBarInstructor
            cPanelSideBarInstructor.Name = "cPanelSideBarInstructor";
            cPanelSideBarInstructor.Dock = DockStyle.Left;
            cPanelSideBarInstructor.Size = new Size(205, 845);
            cPanelSideBarInstructor.BackColor = Color.FromArgb(22, 33, 62);
            cPanelSideBarInstructor.Padding = new Padding(14);
            cPanelSideBarInstructor.BorderWidth = 0;
            cPanelSideBarInstructor.CornerRadius = 1;
            // flpLogoInstructor
            flpLogoInstructor.Name = "flpLogoInstructor";
            flpLogoInstructor.Dock = DockStyle.Top;
            flpLogoInstructor.Height = 66;
            flpLogoInstructor.BackColor = Color.FromArgb(22, 33, 62);
            flpLogoInstructor.BorderWidth = 0;
            flpLogoInstructor.CornerRadius = 1;
            // profile
            profile.Name = "profile";
            profile.Dock = DockStyle.Top;
            profile.Height = 50;
            profile.BackColor = Color.FromArgb(22, 33, 62);
            profile.BorderWidth = 0;
            profile.CornerRadius = 1;
            profile.Padding = new Padding(8);
            // pbProfile
            pbProfile.Name = "pbProfile";
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(40, 40);
            pbProfile.BackColor = Color.FromArgb(22, 33, 62);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.Location = new Point(8, 5);
            // profileNameLabel
            profileNameLabel.Name = "profileNameLabel";
            profileNameLabel.Text = "Instructor";
            profileNameLabel.ForeColor = Color.White;
            profileNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            profileNameLabel.AutoEllipsis = true;
            profileNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            profileNameLabel.Location = new Point(52, 8);
            profileNameLabel.Size = new Size(120, 42);
            // spacer
            spacer.Name = "spacer";
            spacer.Dock = DockStyle.Fill;
            spacer.BackColor = Color.FromArgb(22, 33, 62);
            spacer.BorderWidth = 0;
            spacer.CornerRadius = 1;
            // content
            content.Name = "content";
            content.Dock = DockStyle.Fill;
            content.BackColor = Color.FromArgb(13, 17, 38);
            content.Padding = new Padding(32);
            content.BorderWidth = 0;
            content.CornerRadius = 1;
            // courseCards
            courseCards.Name = "courseCards";
            courseCards.Dock = DockStyle.Fill;
            courseCards.AutoScroll = true;
            courseCards.WrapContents = true;
            courseCards.BackColor = Color.FromArgb(13, 17, 38);
            courseCards.Padding = new Padding(0, 12, 12, 12);
            courseCards.BorderSize = 0;
            courseCards.BorderRadius = 0;
            // lblSMARTInstructor
            lblSMARTInstructor.Name = "lblSMARTInstructor";
            lblSMARTInstructor.Text = "S.M.A.R.T";
            lblSMARTInstructor.Dock = DockStyle.Top;
            lblSMARTInstructor.Height = 34;
            lblSMARTInstructor.ForeColor = Color.FromArgb(233, 69, 96);
            lblSMARTInstructor.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSMARTInstructor.TextAlign = ContentAlignment.MiddleLeft;
            // lblInstructorPanel
            lblInstructorPanel.Name = "lblInstructorPanel";
            lblInstructorPanel.Text = "Instructor Panel";
            lblInstructorPanel.Dock = DockStyle.Top;
            lblInstructorPanel.Height = 22;
            lblInstructorPanel.ForeColor = Color.FromArgb(170, 170, 185);
            lblInstructorPanel.Font = new Font("Segoe UI", 9F);
            lblInstructorPanel.TextAlign = ContentAlignment.MiddleLeft;
            // topDivider
            topDivider.Name = "topDivider";
            topDivider.Dock = DockStyle.Top;
            topDivider.Height = 1;
            topDivider.BackColor = Color.FromArgb(65, 75, 100);
            topDivider.BorderWidth = 0;
            topDivider.CornerRadius = 1;
            topDivider.Margin = new Padding(0, 4, 0, 12);
            // bottomDivider
            bottomDivider.Name = "bottomDivider";
            bottomDivider.Dock = DockStyle.Top;
            bottomDivider.Height = 1;
            bottomDivider.BackColor = Color.FromArgb(65, 75, 100);
            bottomDivider.BorderWidth = 0;
            bottomDivider.CornerRadius = 1;
            bottomDivider.Margin = new Padding(0, 4, 0, 12);
            // flpDashboardInstructor
            // 
            flpDashboardInstructor.BorderColor = Color.Transparent;
            flpDashboardInstructor.BorderRadius = 5;
            flpDashboardInstructor.BorderSize = 1;
            flpDashboardInstructor.Controls.Add(picDashboardInstructor);
            flpDashboardInstructor.Controls.Add(lblDashboardInstructor);
            flpDashboardInstructor.Dock = DockStyle.Top;
            flpDashboardInstructor.BackColor = Color.FromArgb(233, 69, 96);
            flpDashboardInstructor.Cursor = Cursors.Hand;
            flpDashboardInstructor.Name = "flpDashboardInstructor";
            flpDashboardInstructor.Padding = new Padding(4, 0, 0, 0);
            flpDashboardInstructor.Size = new Size(177, 40);
            flpDashboardInstructor.TabIndex = 0;
            flpDashboardInstructor.WrapContents = false;
            // 
            // picDashboardInstructor
            // 
            picDashboardInstructor.BackgroundImage = (Image)resources.GetObject("picDashboardInstructor.BackgroundImage");
            picDashboardInstructor.BackgroundImageLayout = ImageLayout.Zoom;
            picDashboardInstructor.Location = new Point(7, 3);
            picDashboardInstructor.Name = "picDashboardInstructor";
            picDashboardInstructor.Size = new Size(30, 30);
            picDashboardInstructor.TabIndex = 0;
            picDashboardInstructor.TabStop = false;
            // 
            // lblDashboardInstructor
            // 
            lblDashboardInstructor.Anchor = AnchorStyles.None;
            lblDashboardInstructor.Font = new Font("Bahnschrift", 10F);
            lblDashboardInstructor.ForeColor = Color.White;
            lblDashboardInstructor.Location = new Point(43, 6);
            lblDashboardInstructor.Name = "lblDashboardInstructor";
            lblDashboardInstructor.Size = new Size(81, 23);
            lblDashboardInstructor.TabIndex = 2;
            lblDashboardInstructor.Text = "Dashboard";
            lblDashboardInstructor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpSettingsInstructor
            flpSettingsInstructor.Name = "flpSettingsInstructor";
            flpSettingsInstructor.BackColor = Color.FromArgb(22, 33, 62);
            flpSettingsInstructor.BorderColor = Color.Transparent;
            flpSettingsInstructor.BorderRadius = 6;
            flpSettingsInstructor.Dock = DockStyle.Bottom;
            flpSettingsInstructor.Size = new Size(177, 42);
            flpSettingsInstructor.Padding = new Padding(8, 0, 0, 0);
            flpSettingsInstructor.WrapContents = false;
            flpSettingsInstructor.Cursor = Cursors.Hand;
            flpSettingsInstructor.Controls.Add(picSettingsInstructor);
            flpSettingsInstructor.Controls.Add(lblSettingsInstructor);
            // picSettingsInstructor
            picSettingsInstructor.Name = "picSettingsInstructor";
            picSettingsInstructor.BackgroundImage = (Image)resources.GetObject("picSettingsInstructor.BackgroundImage");
            picSettingsInstructor.BackgroundImageLayout = ImageLayout.Zoom;
            picSettingsInstructor.Size = new Size(24, 24);
            picSettingsInstructor.Margin = new Padding(0, 9, 8, 9);
            picSettingsInstructor.TabStop = false;
            picSettingsInstructor.Cursor = Cursors.Hand;
            // lblSettingsInstructor
            lblSettingsInstructor.Name = "lblSettingsInstructor";
            lblSettingsInstructor.Text = "Settings";
            lblSettingsInstructor.ForeColor = Color.White;
            lblSettingsInstructor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSettingsInstructor.Size = new Size(120, 42);
            lblSettingsInstructor.Margin = Padding.Empty;
            lblSettingsInstructor.TextAlign = ContentAlignment.MiddleLeft;
            lblSettingsInstructor.Cursor = Cursors.Hand;
            // flpSignOutInstructor
            flpSignOutInstructor.Name = "flpSignOutInstructor";
            flpSignOutInstructor.BackColor = Color.FromArgb(22, 33, 62);
            flpSignOutInstructor.BorderColor = Color.Transparent;
            flpSignOutInstructor.BorderRadius = 5;
            flpSignOutInstructor.Dock = DockStyle.Bottom;
            flpSignOutInstructor.Size = new Size(177, 40);
            flpSignOutInstructor.Padding = new Padding(4, 0, 0, 0);
            flpSignOutInstructor.WrapContents = false;
            flpSignOutInstructor.Cursor = Cursors.Hand;
            flpSignOutInstructor.Controls.Add(picSignOutInstructor);
            flpSignOutInstructor.Controls.Add(lblSignOutInstructor);
            // picSignOutInstructor
            picSignOutInstructor.Name = "picSignOutInstructor";
            picSignOutInstructor.BackgroundImage = (Image)resources.GetObject("picSignOutInstructor.BackgroundImage");
            picSignOutInstructor.BackgroundImageLayout = ImageLayout.Zoom;
            picSignOutInstructor.Size = new Size(30, 30);
            picSignOutInstructor.TabStop = false;
            picSignOutInstructor.Cursor = Cursors.Hand;
            // lblSignOutInstructor
            lblSignOutInstructor.Name = "lblSignOutInstructor";
            lblSignOutInstructor.Anchor = AnchorStyles.None;
            lblSignOutInstructor.Text = "Sign Out";
            lblSignOutInstructor.Font = new Font("Bahnschrift", 10F);
            lblSignOutInstructor.ForeColor = Color.White;
            lblSignOutInstructor.Size = new Size(120, 23);
            lblSignOutInstructor.TextAlign = ContentAlignment.MiddleLeft;
            lblSignOutInstructor.Cursor = Cursors.Hand;
            // lblWelcomeInstructor
            lblWelcomeInstructor.Name = "lblWelcomeInstructor";
            lblWelcomeInstructor.Text = "Welcome, Instructor!";
            lblWelcomeInstructor.Dock = DockStyle.Top;
            lblWelcomeInstructor.Height = 48;
            lblWelcomeInstructor.ForeColor = Color.White;
            lblWelcomeInstructor.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            // lblCurr
            lblCurr.Name = "lblCurr";
            lblCurr.Text = "Here are your current courses.";
            lblCurr.Dock = DockStyle.Top;
            lblCurr.Height = 30;
            lblCurr.ForeColor = Color.FromArgb(150, 150, 170);
            lblCurr.Font = new Font("Segoe UI", 11F);
            // cPnlCourseHolder
            cPnlCourseHolder.Name = "cPnlCourseHolder";
            cPnlCourseHolder.Size = new Size(220, 200);
            cPnlCourseHolder.BackColor = Color.FromArgb(22, 33, 62);
            cPnlCourseHolder.BorderColor = Color.FromArgb(233, 69, 96);
            cPnlCourseHolder.BorderWidth = 2;
            cPnlCourseHolder.CornerRadius = 12;
            cPnlCourseHolder.Margin = new Padding(0, 4, 18, 18);
            cPnlCourseHolder.Padding = new Padding(14);
            // lblCourse
            lblCourse.Name = "lblCourse";
            lblCourse.Text = "COURSE101";
            lblCourse.Dock = DockStyle.Top;
            lblCourse.Height = 30;
            lblCourse.ForeColor = Color.FromArgb(233, 69, 96);
            lblCourse.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblCourse.AutoEllipsis = true;
            lblCourse.TextAlign = ContentAlignment.MiddleLeft;
            // lblCourseName
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Text = "Course name";
            lblCourseName.Dock = DockStyle.Top;
            lblCourseName.Height = 38;
            lblCourseName.ForeColor = Color.White;
            lblCourseName.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lblCourseName.AutoEllipsis = true;
            lblCourseName.TextAlign = ContentAlignment.MiddleLeft;
            // lblCourseCode
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Text = "Code: 0000";
            lblCourseCode.Dock = DockStyle.Top;
            lblCourseCode.Height = 22;
            lblCourseCode.ForeColor = Color.FromArgb(150, 150, 170);
            lblCourseCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblCourseCode.AutoEllipsis = true;
            lblCourseCode.TextAlign = ContentAlignment.MiddleLeft;
            // lblCourseDetails
            lblCourseDetails.Name = "lblCourseDetails";
            lblCourseDetails.Text = "Schedule | Days\nRoom · Term · Program";
            lblCourseDetails.Dock = DockStyle.Top;
            lblCourseDetails.Height = 52;
            lblCourseDetails.ForeColor = Color.FromArgb(150, 150, 170);
            lblCourseDetails.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblCourseDetails.AutoEllipsis = true;
            lblCourseDetails.TextAlign = ContentAlignment.MiddleLeft;
            // lblCourseStudents
            lblCourseStudents.Name = "lblCourseStudents";
            lblCourseStudents.Text = "👥 0 Students";
            lblCourseStudents.Dock = DockStyle.Top;
            lblCourseStudents.Height = 25;
            lblCourseStudents.ForeColor = Color.FromArgb(150, 150, 170);
            lblCourseStudents.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblCourseStudents.AutoEllipsis = true;
            lblCourseStudents.TextAlign = ContentAlignment.MiddleLeft;
            // lblCourseOpen
            lblCourseOpen.Name = "lblCourseOpen";
            lblCourseOpen.Text = "Click to open →";
            lblCourseOpen.Dock = DockStyle.Top;
            lblCourseOpen.Height = 20;
            lblCourseOpen.ForeColor = Color.FromArgb(233, 69, 96);
            lblCourseOpen.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblCourseOpen.AutoEllipsis = true;
            lblCourseOpen.TextAlign = ContentAlignment.MiddleLeft;
            profile.Controls.Add(pbProfile);
            profile.Controls.Add(profileNameLabel);
            cPanelSideBarInstructor.Controls.Add(spacer);
            cPanelSideBarInstructor.Controls.Add(flpSettingsInstructor);
            cPanelSideBarInstructor.Controls.Add(flpSignOutInstructor);
            cPanelSideBarInstructor.Controls.Add(flpDashboardInstructor);
            cPanelSideBarInstructor.Controls.Add(bottomDivider);
            cPanelSideBarInstructor.Controls.Add(profile);
            cPanelSideBarInstructor.Controls.Add(topDivider);
            cPanelSideBarInstructor.Controls.Add(flpLogoInstructor);
            shell.Controls.Add(content);
            shell.Controls.Add(cPanelSideBarInstructor);
            Controls.Add(shell);
            flpLogoInstructor.Controls.Add(lblSMARTInstructor);
            flpLogoInstructor.Controls.Add(lblInstructorPanel);
            content.Controls.Add(courseCards);
            content.Controls.Add(lblCurr);
            content.Controls.Add(lblWelcomeInstructor);
            courseCards.Controls.Add(cPnlCourseHolder);
            cPnlCourseHolder.Controls.Add(lblCourseOpen);
            cPnlCourseHolder.Controls.Add(lblCourseStudents);
            cPnlCourseHolder.Controls.Add(lblCourseDetails);
            cPnlCourseHolder.Controls.Add(lblCourseCode);
            cPnlCourseHolder.Controls.Add(lblCourseName);
            cPnlCourseHolder.Controls.Add(lblCourse);


            flpDashboardInstructor.Click += Dashboard_Click;
            picDashboardInstructor.Click += Dashboard_Click;
            lblDashboardInstructor.Click += Dashboard_Click;
            picDashboardInstructor.Cursor = Cursors.Hand;
            lblDashboardInstructor.Cursor = Cursors.Hand;
            flpSignOutInstructor.Click += SignOut_Click;
            picSignOutInstructor.Click += SignOut_Click;
            lblSignOutInstructor.Click += SignOut_Click;
            pbProfile.Paint += Profile_Paint;
            flpSettingsInstructor.Click += Settings_Click;
            picSettingsInstructor.Click += Settings_Click;
            lblSettingsInstructor.Click += Settings_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 38);
            ClientSize = new Size(1540, 845);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(900, 600);
            Name = "InstructorUI";
            Text = "InstructorUI";
            WindowState = FormWindowState.Maximized;
            flpDashboardInstructor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDashboardInstructor).EndInit();
            flpSignOutInstructor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSignOutInstructor).EndInit();
            flpSettingsInstructor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSettingsInstructor).EndInit();
            shell.ResumeLayout(false);
            cPanelSideBarInstructor.ResumeLayout(false);
            flpLogoInstructor.ResumeLayout(false);
            profile.ResumeLayout(false);
            content.ResumeLayout(false);
            courseCards.ResumeLayout(false);
            cPnlCourseHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private CustomPanel shell;
        private CustomPanel cPanelSideBarInstructor;
        private CustomPanel flpLogoInstructor;
        private CustomPanel profile;
        private PictureBox pbProfile;
        private Label profileNameLabel;
        private CustomPanel spacer;
        private CustomPanel content;
        private RoundedFlowLayoutPanel courseCards;
        private Label lblSMARTInstructor;
        private Label lblInstructorPanel;
        private CustomPanel topDivider;
        private CustomPanel bottomDivider;
        private RoundedFlowLayoutPanel flpDashboardInstructor;
        private PictureBox picDashboardInstructor;
        private Label lblDashboardInstructor;
        private RoundedFlowLayoutPanel flpSignOutInstructor;
        private PictureBox picSignOutInstructor;
        private Label lblSignOutInstructor;
        private RoundedFlowLayoutPanel flpSettingsInstructor;
        private PictureBox picSettingsInstructor;
        private Label lblSettingsInstructor;
        private Label lblWelcomeInstructor;
        private Label lblCurr;
        private CustomPanel cPnlCourseHolder;
        private Label lblCourse;
        private Label lblCourseName;
        private Label lblCourseCode;
        private Label lblCourseDetails;
        private Label lblCourseStudents;
        private Label lblCourseOpen;

    }
}
