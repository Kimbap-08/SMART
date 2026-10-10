namespace SMART
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            mainPanelAdmin = new Panel();
            lblSystemOverview = new Label();
            cPnlActiveStudentsHolder = new CustomPanel();
            lblActiveStudents = new Label();
            lblActiveStudents.BackColor = Color.Transparent;
            lblActiveStudentsCount = new Label();
            lblActiveStudentsCount.BackColor = Color.Transparent;
            pictureBox6 = new PictureBox();
            pictureBox6.BackColor = Color.Transparent;
            cPnlTotalCoursesHolder = new CustomPanel();
            lblTotalCourses = new Label();
            lblTotalCourses.BackColor = Color.Transparent;
            lblTotalCoursesCount = new Label();
            lblTotalCoursesCount.BackColor = Color.Transparent;
            pictureBox4 = new PictureBox();
            pictureBox4.BackColor = Color.Transparent;
            cPnlTotalnstructorsHolder = new CustomPanel();
            lblTotalInstructors = new Label();
            lblTotalInstructors.BackColor = Color.Transparent;
            lblTotalInstructorsCount = new Label();
            lblTotalInstructorsCount.BackColor = Color.Transparent;
            picTotalInstructors = new PictureBox();
            picTotalInstructors.BackColor = Color.Transparent;
            lblWelcomeAdmin = new Label();
            cPnlTotalStudentsHolder = new CustomPanel();
            lblTotalStudents = new Label();
            lblTotalStudents.BackColor = Color.Transparent;
            lblTotalStudentsCount = new Label();
            lblTotalStudentsCount.BackColor = Color.Transparent;
            picTotalStudents = new PictureBox();
            picTotalStudents.BackColor = Color.Transparent;
            mainPanelAdmin.SuspendLayout();
            cPnlActiveStudentsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            cPnlTotalCoursesHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            cPnlTotalnstructorsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalInstructors).BeginInit();
            cPnlTotalStudentsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalStudents).BeginInit();
            SuspendLayout();
            // 
            // mainPanelAdmin
            // 
            mainPanelAdmin.BackColor = Color.Transparent;
            mainPanelAdmin.Controls.Add(lblSystemOverview);
            mainPanelAdmin.Controls.Add(cPnlActiveStudentsHolder);
            mainPanelAdmin.Controls.Add(cPnlTotalCoursesHolder);
            mainPanelAdmin.Controls.Add(cPnlTotalnstructorsHolder);
            mainPanelAdmin.Controls.Add(lblWelcomeAdmin);
            mainPanelAdmin.Controls.Add(cPnlTotalStudentsHolder);
            mainPanelAdmin.Dock = DockStyle.Fill;
            mainPanelAdmin.Location = new Point(0, 0);
            mainPanelAdmin.Name = "mainPanelAdmin";
            mainPanelAdmin.Size = new Size(1540, 845);
            mainPanelAdmin.TabIndex = 2;
            // 
            // lblSystemOverview
            // 
            lblSystemOverview.Font = new Font("Bahnschrift", 10F);
            lblSystemOverview.ForeColor = Color.White;
            lblSystemOverview.Location = new Point(45, 83);
            lblSystemOverview.BackColor = Color.Transparent;
            lblSystemOverview.Name = "lblSystemOverview";
            lblSystemOverview.Size = new Size(319, 23);
            lblSystemOverview.TabIndex = 11;
            lblSystemOverview.Text = "Here is your system overview";
            lblSystemOverview.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cPnlActiveStudentsHolder
            // 
            cPnlActiveStudentsHolder.BackColor = Color.FromArgb(210, 22, 33, 62);
            cPnlActiveStudentsHolder.BorderColor = Color.FromArgb(233, 69, 96);
            cPnlActiveStudentsHolder.Controls.Add(lblActiveStudents);
            cPnlActiveStudentsHolder.Controls.Add(lblActiveStudentsCount);
            cPnlActiveStudentsHolder.Controls.Add(pictureBox6);
            cPnlActiveStudentsHolder.Location = new Point(689, 134);
            cPnlActiveStudentsHolder.Name = "cPnlActiveStudentsHolder";
            cPnlActiveStudentsHolder.Size = new Size(200, 150);
            cPnlActiveStudentsHolder.TabIndex = 10;
            // 
            // lblActiveStudents
            // 
            lblActiveStudents.Anchor = AnchorStyles.None;
            lblActiveStudents.Font = new Font("Bahnschrift", 10F);
            lblActiveStudents.ForeColor = Color.White;
            lblActiveStudents.Location = new Point(35, 109);
            lblActiveStudents.Name = "lblActiveStudents";
            lblActiveStudents.Size = new Size(135, 23);
            lblActiveStudents.TabIndex = 2;
            lblActiveStudents.Text = "Active Students";
            lblActiveStudents.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveStudentsCount
            // 
            lblActiveStudentsCount.Anchor = AnchorStyles.None;
            lblActiveStudentsCount.AutoSize = true;
            lblActiveStudentsCount.Font = new Font("Bahnschrift", 22F, FontStyle.Bold);
            lblActiveStudentsCount.ForeColor = Color.FromArgb(233, 69, 96);
            lblActiveStudentsCount.Location = new Point(86, 73);
            lblActiveStudentsCount.Name = "lblActiveStudentsCount";
            lblActiveStudentsCount.Size = new Size(32, 36);
            lblActiveStudentsCount.TabIndex = 2;
            lblActiveStudentsCount.Text = "0";
            lblActiveStudentsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(86, 18);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // cPnlTotalCoursesHolder
            // 
            cPnlTotalCoursesHolder.BackColor = Color.FromArgb(210, 22, 33, 62);
            cPnlTotalCoursesHolder.BorderColor = Color.FromArgb(233, 69, 96);
            cPnlTotalCoursesHolder.Controls.Add(lblTotalCourses);
            cPnlTotalCoursesHolder.Controls.Add(lblTotalCoursesCount);
            cPnlTotalCoursesHolder.Controls.Add(pictureBox4);
            cPnlTotalCoursesHolder.Location = new Point(471, 134);
            cPnlTotalCoursesHolder.Name = "cPnlTotalCoursesHolder";
            cPnlTotalCoursesHolder.Size = new Size(200, 150);
            cPnlTotalCoursesHolder.TabIndex = 9;
            // 
            // lblTotalCourses
            // 
            lblTotalCourses.Anchor = AnchorStyles.None;
            lblTotalCourses.Font = new Font("Bahnschrift", 10F);
            lblTotalCourses.ForeColor = Color.White;
            lblTotalCourses.Location = new Point(35, 109);
            lblTotalCourses.Name = "lblTotalCourses";
            lblTotalCourses.Size = new Size(135, 23);
            lblTotalCourses.TabIndex = 2;
            lblTotalCourses.Text = "Total Courses";
            lblTotalCourses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCoursesCount
            // 
            lblTotalCoursesCount.Anchor = AnchorStyles.None;
            lblTotalCoursesCount.AutoSize = true;
            lblTotalCoursesCount.Font = new Font("Bahnschrift", 22F, FontStyle.Bold);
            lblTotalCoursesCount.ForeColor = Color.FromArgb(233, 69, 96);
            lblTotalCoursesCount.Location = new Point(86, 73);
            lblTotalCoursesCount.Name = "lblTotalCoursesCount";
            lblTotalCoursesCount.Size = new Size(32, 36);
            lblTotalCoursesCount.TabIndex = 2;
            lblTotalCoursesCount.Text = "0";
            lblTotalCoursesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(86, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // cPnlTotalnstructorsHolder
            // 
            cPnlTotalnstructorsHolder.BackColor = Color.FromArgb(210, 22, 33, 62);
            cPnlTotalnstructorsHolder.BorderColor = Color.FromArgb(233, 69, 96);
            cPnlTotalnstructorsHolder.Controls.Add(lblTotalInstructors);
            cPnlTotalnstructorsHolder.Controls.Add(lblTotalInstructorsCount);
            cPnlTotalnstructorsHolder.Controls.Add(picTotalInstructors);
            cPnlTotalnstructorsHolder.Location = new Point(253, 134);
            cPnlTotalnstructorsHolder.Name = "cPnlTotalnstructorsHolder";
            cPnlTotalnstructorsHolder.Size = new Size(200, 150);
            cPnlTotalnstructorsHolder.TabIndex = 8;
            // 
            // lblTotalInstructors
            // 
            lblTotalInstructors.Anchor = AnchorStyles.None;
            lblTotalInstructors.Font = new Font("Bahnschrift", 10F);
            lblTotalInstructors.ForeColor = Color.White;
            lblTotalInstructors.Location = new Point(36, 109);
            lblTotalInstructors.Name = "lblTotalInstructors";
            lblTotalInstructors.Size = new Size(135, 23);
            lblTotalInstructors.TabIndex = 2;
            lblTotalInstructors.Text = "Total Instructors";
            lblTotalInstructors.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalInstructorsCount
            // 
            lblTotalInstructorsCount.Anchor = AnchorStyles.None;
            lblTotalInstructorsCount.AutoSize = true;
            lblTotalInstructorsCount.Font = new Font("Bahnschrift", 22F, FontStyle.Bold);
            lblTotalInstructorsCount.ForeColor = Color.FromArgb(233, 69, 96);
            lblTotalInstructorsCount.Location = new Point(86, 73);
            lblTotalInstructorsCount.Name = "lblTotalInstructorsCount";
            lblTotalInstructorsCount.Size = new Size(32, 36);
            lblTotalInstructorsCount.TabIndex = 2;
            lblTotalInstructorsCount.Text = "0";
            lblTotalInstructorsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picTotalInstructors
            // 
            picTotalInstructors.BackgroundImage = (Image)resources.GetObject("picTotalInstructors.BackgroundImage");
            picTotalInstructors.BackgroundImageLayout = ImageLayout.Zoom;
            picTotalInstructors.Location = new Point(86, 18);
            picTotalInstructors.Name = "picTotalInstructors";
            picTotalInstructors.Size = new Size(30, 30);
            picTotalInstructors.TabIndex = 4;
            picTotalInstructors.TabStop = false;
            // 
            // lblWelcomeAdmin
            // 
            lblWelcomeAdmin.AutoSize = true;
            lblWelcomeAdmin.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            lblWelcomeAdmin.ForeColor = Color.White;
            lblWelcomeAdmin.Location = new Point(35, 27);
            lblWelcomeAdmin.BackColor = Color.Transparent;
            lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            lblWelcomeAdmin.Size = new Size(438, 32);
            lblWelcomeAdmin.TabIndex = 8;
            lblWelcomeAdmin.Text = "Welcome, System Administrator!";
            // 
            // cPnlTotalStudentsHolder
            // 
            cPnlTotalStudentsHolder.BackColor = Color.FromArgb(210, 22, 33, 62);
            cPnlTotalStudentsHolder.BorderColor = Color.FromArgb(233, 69, 96);
            cPnlTotalStudentsHolder.Controls.Add(lblTotalStudents);
            cPnlTotalStudentsHolder.Controls.Add(lblTotalStudentsCount);
            cPnlTotalStudentsHolder.Controls.Add(picTotalStudents);
            cPnlTotalStudentsHolder.Location = new Point(35, 134);
            cPnlTotalStudentsHolder.Name = "cPnlTotalStudentsHolder";
            cPnlTotalStudentsHolder.Size = new Size(200, 150);
            cPnlTotalStudentsHolder.TabIndex = 7;
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.Anchor = AnchorStyles.None;
            lblTotalStudents.Font = new Font("Bahnschrift", 10F);
            lblTotalStudents.ForeColor = Color.White;
            lblTotalStudents.Location = new Point(35, 109);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(135, 23);
            lblTotalStudents.TabIndex = 2;
            lblTotalStudents.Text = "Total Students";
            lblTotalStudents.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalStudentsCount
            // 
            lblTotalStudentsCount.Anchor = AnchorStyles.None;
            lblTotalStudentsCount.AutoSize = true;
            lblTotalStudentsCount.Font = new Font("Bahnschrift", 22F, FontStyle.Bold);
            lblTotalStudentsCount.ForeColor = Color.FromArgb(233, 69, 96);
            lblTotalStudentsCount.Location = new Point(86, 73);
            lblTotalStudentsCount.Name = "lblTotalStudentsCount";
            lblTotalStudentsCount.Size = new Size(32, 36);
            lblTotalStudentsCount.TabIndex = 2;
            lblTotalStudentsCount.Text = "0";
            lblTotalStudentsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picTotalStudents
            // 
            picTotalStudents.BackgroundImage = (Image)resources.GetObject("picTotalStudents.BackgroundImage");
            picTotalStudents.BackgroundImageLayout = ImageLayout.Zoom;
            picTotalStudents.Location = new Point(86, 18);
            picTotalStudents.Name = "picTotalStudents";
            picTotalStudents.Size = new Size(30, 30);
            picTotalStudents.TabIndex = 4;
            picTotalStudents.TabStop = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 845);
            Controls.Add(mainPanelAdmin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            WindowState = FormWindowState.Maximized;
            mainPanelAdmin.ResumeLayout(false);
            mainPanelAdmin.PerformLayout();
            cPnlActiveStudentsHolder.ResumeLayout(false);
            cPnlActiveStudentsHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            cPnlTotalCoursesHolder.ResumeLayout(false);
            cPnlTotalCoursesHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            cPnlTotalnstructorsHolder.ResumeLayout(false);
            cPnlTotalnstructorsHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalInstructors).EndInit();
            cPnlTotalStudentsHolder.ResumeLayout(false);
            cPnlTotalStudentsHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanelAdmin;
        private Label lblSystemOverview;
        private CustomPanel cPnlActiveStudentsHolder;
        private Label lblActiveStudents;
        private Label lblActiveStudentsCount;
        private PictureBox pictureBox6;
        private CustomPanel cPnlTotalCoursesHolder;
        private Label lblTotalCourses;
        private Label lblTotalCoursesCount;
        private PictureBox pictureBox4;
        private CustomPanel cPnlTotalnstructorsHolder;
        private Label lblTotalInstructors;
        private Label lblTotalInstructorsCount;
        private PictureBox picTotalInstructors;
        private Label lblWelcomeAdmin;
        private CustomPanel cPnlTotalStudentsHolder;
        private Label lblTotalStudents;
        private Label lblTotalStudentsCount;
        private PictureBox picTotalStudents;
    }
}