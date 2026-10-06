namespace SMART
{
    partial class AdminCourses
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
            pnlHeaderInstructorC = new Panel();
            pnlSearchSortCourses = new Panel();
            cPnlAddCourses = new CustomPanel();
            dgvCourses = new DataGridView();
            lblCourseheader = new Label();
            lblCourseManagement = new Label();
            pnlHeaderInstructorC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderInstructorC
            // 
            pnlHeaderInstructorC.BackColor = Color.FromArgb(22, 33, 62);
            pnlHeaderInstructorC.Controls.Add(lblCourseheader);
            pnlHeaderInstructorC.Controls.Add(lblCourseManagement);
            pnlHeaderInstructorC.Dock = DockStyle.Top;
            pnlHeaderInstructorC.Location = new Point(0, 0);
            pnlHeaderInstructorC.Name = "pnlHeaderInstructorC";
            pnlHeaderInstructorC.Size = new Size(1540, 106);
            pnlHeaderInstructorC.TabIndex = 1;
            // 
            // pnlSearchSortCourses
            // 
            pnlSearchSortCourses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearchSortCourses.Location = new Point(12, 112);
            pnlSearchSortCourses.Name = "pnlSearchSortCourses";
            pnlSearchSortCourses.Size = new Size(1493, 82);
            pnlSearchSortCourses.TabIndex = 25;
            // 
            // cPnlAddCourses
            // 
            cPnlAddCourses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cPnlAddCourses.BackColor = Color.FromArgb(22, 33, 62);
            cPnlAddCourses.BorderColor = Color.FromArgb(22, 33, 62);
            cPnlAddCourses.CornerRadius = 5;
            cPnlAddCourses.Location = new Point(12, 200);
            cPnlAddCourses.Name = "cPnlAddCourses";
            cPnlAddCourses.Size = new Size(1493, 281);
            cPnlAddCourses.TabIndex = 24;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(12, 490);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(1493, 340);
            dgvCourses.TabIndex = 26;
            // 
            // lblCourseheader
            // 
            lblCourseheader.Anchor = AnchorStyles.Left;
            lblCourseheader.Font = new Font("Bahnschrift Light", 10F);
            lblCourseheader.ForeColor = Color.White;
            lblCourseheader.Location = new Point(25, 68);
            lblCourseheader.Name = "lblCourseheader";
            lblCourseheader.Size = new Size(319, 23);
            lblCourseheader.TabIndex = 4;
            lblCourseheader.Text = "Create and Manage Courses";
            lblCourseheader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCourseManagement
            // 
            lblCourseManagement.Anchor = AnchorStyles.Left;
            lblCourseManagement.AutoSize = true;
            lblCourseManagement.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            lblCourseManagement.ForeColor = Color.White;
            lblCourseManagement.Location = new Point(25, 36);
            lblCourseManagement.Name = "lblCourseManagement";
            lblCourseManagement.Size = new Size(280, 32);
            lblCourseManagement.TabIndex = 3;
            lblCourseManagement.Text = "Course Management";
            // 
            // AdminCourses
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(1540, 845);
            Controls.Add(dgvCourses);
            Controls.Add(pnlSearchSortCourses);
            Controls.Add(pnlHeaderInstructorC);
            Controls.Add(cPnlAddCourses);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminCourses";
            Text = "AdminCourses";
            WindowState = FormWindowState.Maximized;
            pnlHeaderInstructorC.ResumeLayout(false);
            pnlHeaderInstructorC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderInstructorC;
        private Panel pnlSearchSortCourses;
        private CustomPanel cPnlAddCourses;
        private DataGridView dgvCourses;
        private Label lblCourseheader;
        private Label lblCourseManagement;
    }
}
