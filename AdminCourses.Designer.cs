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
            lblCourseheader = new Label();
            lblCourseManagement = new Label();
            rTbSearchCourses = new RoundedTextBox();
            rBtnSearchCourses = new RoundedButton();
            rBtnRefreshCourses = new RoundedButton();
            lblSlashCourses = new Label();
            lblSortCourses = new Label();
            rBtnSortNameCourses = new RoundedButton();
            rBtnSortIDCourses = new RoundedButton();
            rBtnSortTimeCourses = new RoundedButton();
            cPnlAddCourses = new CustomPanel();
            lblAddNewCourse = new Label();
            rBtnDeleteCourses = new RoundedButton();
            rBtnUpdateCourses = new RoundedButton();
            rBtnCancelCourses = new RoundedButton();
            rBtnAddCourse = new RoundedButton();
            pnlProgramCourses = new Panel();
            rTbProgramCourses = new RoundedTextBox();
            listProgramCourses = new ListBox();
            lblProgramCourses = new Label();
            rTbCourseID = new RoundedTextBox();
            lblCourseID = new Label();
            rTbCourseTitle = new RoundedTextBox();
            lblCourseTitle = new Label();
            pnlSearchSortCourses = new Panel();
            dgvCourses = new DataGridView();
            rTbRoomNum = new RoundedTextBox();
            lblRoomNum = new Label();
            rTbCourseTime = new RoundedTextBox();
            lblCourseTime = new Label();
            rTbCourseName = new RoundedTextBox();
            lblCourseName = new Label();
            lblDay = new Label();
            listDay = new ListBox();
            listBoxTerm = new ListBox();
            lblTerm = new Label();
            lblInstructorAssignment = new Label();
            lblAssignInstructor = new Label();
            pnlAssignInstructor = new Panel();
            rTbAssignInstructor = new RoundedTextBox();
            listBoxAssignInstructor = new ListBox();
            pnlHeaderInstructorC.SuspendLayout();
            cPnlAddCourses.SuspendLayout();
            pnlProgramCourses.SuspendLayout();
            pnlSearchSortCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            pnlAssignInstructor.SuspendLayout();
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
            // rTbSearchCourses
            // 
            rTbSearchCourses.BackColor = Color.Transparent;
            rTbSearchCourses.BorderColor = Color.FromArgb(233, 69, 96);
            rTbSearchCourses.BorderRadius = 5;
            rTbSearchCourses.FillColor = Color.FromArgb(22, 33, 62);
            rTbSearchCourses.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbSearchCourses.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbSearchCourses.ForeColor = Color.White;
            rTbSearchCourses.Location = new Point(13, 30);
            rTbSearchCourses.Name = "rTbSearchCourses";
            rTbSearchCourses.Padding = new Padding(2);
            rTbSearchCourses.PlaceholderText = "Search by Name, ID, Program, Year Level ";
            rTbSearchCourses.Size = new Size(375, 40);
            rTbSearchCourses.TabIndex = 17;
            // 
            // rBtnSearchCourses
            // 
            rBtnSearchCourses.BackColor = Color.FromArgb(233, 69, 96);
            rBtnSearchCourses.BorderColor = Color.White;
            rBtnSearchCourses.BorderRadius = 5;
            rBtnSearchCourses.FlatAppearance.BorderSize = 0;
            rBtnSearchCourses.FlatStyle = FlatStyle.Flat;
            rBtnSearchCourses.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSearchCourses.ForeColor = Color.White;
            rBtnSearchCourses.HoverColor = Color.Empty;
            rBtnSearchCourses.Location = new Point(394, 30);
            rBtnSearchCourses.Name = "rBtnSearchCourses";
            rBtnSearchCourses.PressedColor = Color.Empty;
            rBtnSearchCourses.Size = new Size(93, 40);
            rBtnSearchCourses.TabIndex = 18;
            rBtnSearchCourses.Text = "Search";
            rBtnSearchCourses.UseVisualStyleBackColor = false;
            // 
            // rBtnRefreshCourses
            // 
            rBtnRefreshCourses.BackColor = Color.DimGray;
            rBtnRefreshCourses.BorderColor = Color.White;
            rBtnRefreshCourses.BorderRadius = 5;
            rBtnRefreshCourses.FlatAppearance.BorderSize = 0;
            rBtnRefreshCourses.FlatStyle = FlatStyle.Flat;
            rBtnRefreshCourses.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnRefreshCourses.ForeColor = Color.White;
            rBtnRefreshCourses.HoverColor = Color.Empty;
            rBtnRefreshCourses.Location = new Point(493, 30);
            rBtnRefreshCourses.Name = "rBtnRefreshCourses";
            rBtnRefreshCourses.PressedColor = Color.Empty;
            rBtnRefreshCourses.Size = new Size(93, 40);
            rBtnRefreshCourses.TabIndex = 19;
            rBtnRefreshCourses.Text = "Refresh";
            rBtnRefreshCourses.UseVisualStyleBackColor = false;
            // 
            // lblSlashCourses
            // 
            lblSlashCourses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSlashCourses.Font = new Font("Segoe UI", 15F);
            lblSlashCourses.ForeColor = Color.DarkGray;
            lblSlashCourses.Location = new Point(592, 34);
            lblSlashCourses.Name = "lblSlashCourses";
            lblSlashCourses.Size = new Size(15, 25);
            lblSlashCourses.TabIndex = 20;
            lblSlashCourses.Text = "|";
            lblSlashCourses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSortCourses
            // 
            lblSortCourses.AutoSize = true;
            lblSortCourses.Font = new Font("Bahnschrift", 10F);
            lblSortCourses.ForeColor = Color.White;
            lblSortCourses.Location = new Point(609, 39);
            lblSortCourses.Name = "lblSortCourses";
            lblSortCourses.Size = new Size(57, 17);
            lblSortCourses.TabIndex = 3;
            lblSortCourses.Text = "Sort by:";
            lblSortCourses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rBtnSortNameCourses
            // 
            rBtnSortNameCourses.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortNameCourses.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortNameCourses.BorderRadius = 5;
            rBtnSortNameCourses.BorderSize = 2;
            rBtnSortNameCourses.FlatAppearance.BorderSize = 0;
            rBtnSortNameCourses.FlatStyle = FlatStyle.Flat;
            rBtnSortNameCourses.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortNameCourses.ForeColor = Color.White;
            rBtnSortNameCourses.HoverColor = Color.Empty;
            rBtnSortNameCourses.Location = new Point(695, 30);
            rBtnSortNameCourses.Name = "rBtnSortNameCourses";
            rBtnSortNameCourses.PressedColor = Color.Empty;
            rBtnSortNameCourses.Size = new Size(128, 40);
            rBtnSortNameCourses.TabIndex = 21;
            rBtnSortNameCourses.Text = "Course Name";
            rBtnSortNameCourses.UseVisualStyleBackColor = false;
            // 
            // rBtnSortIDCourses
            // 
            rBtnSortIDCourses.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortIDCourses.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortIDCourses.BorderRadius = 5;
            rBtnSortIDCourses.BorderSize = 2;
            rBtnSortIDCourses.FlatAppearance.BorderSize = 0;
            rBtnSortIDCourses.FlatStyle = FlatStyle.Flat;
            rBtnSortIDCourses.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortIDCourses.ForeColor = Color.White;
            rBtnSortIDCourses.HoverColor = Color.Empty;
            rBtnSortIDCourses.Location = new Point(854, 30);
            rBtnSortIDCourses.Name = "rBtnSortIDCourses";
            rBtnSortIDCourses.PressedColor = Color.Empty;
            rBtnSortIDCourses.Size = new Size(128, 40);
            rBtnSortIDCourses.TabIndex = 22;
            rBtnSortIDCourses.Text = "Course Code";
            rBtnSortIDCourses.UseVisualStyleBackColor = false;
            // 
            // rBtnSortTimeCourses
            // 
            rBtnSortTimeCourses.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortTimeCourses.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortTimeCourses.BorderRadius = 5;
            rBtnSortTimeCourses.BorderSize = 2;
            rBtnSortTimeCourses.FlatAppearance.BorderSize = 0;
            rBtnSortTimeCourses.FlatStyle = FlatStyle.Flat;
            rBtnSortTimeCourses.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortTimeCourses.ForeColor = Color.White;
            rBtnSortTimeCourses.HoverColor = Color.Empty;
            rBtnSortTimeCourses.Location = new Point(1037, 30);
            rBtnSortTimeCourses.Name = "rBtnSortTimeCourses";
            rBtnSortTimeCourses.PressedColor = Color.Empty;
            rBtnSortTimeCourses.Size = new Size(74, 40);
            rBtnSortTimeCourses.TabIndex = 23;
            rBtnSortTimeCourses.Text = "Time";
            rBtnSortTimeCourses.UseVisualStyleBackColor = false;
            // 
            // cPnlAddCourses
            // 
            cPnlAddCourses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cPnlAddCourses.BackColor = Color.FromArgb(22, 33, 62);
            cPnlAddCourses.BorderColor = Color.FromArgb(22, 33, 62);
            cPnlAddCourses.Controls.Add(pnlAssignInstructor);
            cPnlAddCourses.Controls.Add(listBoxAssignInstructor);
            cPnlAddCourses.Controls.Add(lblAssignInstructor);
            cPnlAddCourses.Controls.Add(lblInstructorAssignment);
            cPnlAddCourses.Controls.Add(listBoxTerm);
            cPnlAddCourses.Controls.Add(lblTerm);
            cPnlAddCourses.Controls.Add(listDay);
            cPnlAddCourses.Controls.Add(lblDay);
            cPnlAddCourses.Controls.Add(rTbCourseName);
            cPnlAddCourses.Controls.Add(lblCourseName);
            cPnlAddCourses.Controls.Add(rTbCourseTime);
            cPnlAddCourses.Controls.Add(lblCourseTime);
            cPnlAddCourses.Controls.Add(rTbRoomNum);
            cPnlAddCourses.Controls.Add(lblRoomNum);
            cPnlAddCourses.Controls.Add(lblAddNewCourse);
            cPnlAddCourses.Controls.Add(rBtnDeleteCourses);
            cPnlAddCourses.Controls.Add(rBtnUpdateCourses);
            cPnlAddCourses.Controls.Add(rBtnCancelCourses);
            cPnlAddCourses.Controls.Add(rBtnAddCourse);
            cPnlAddCourses.Controls.Add(pnlProgramCourses);
            cPnlAddCourses.Controls.Add(listProgramCourses);
            cPnlAddCourses.Controls.Add(lblProgramCourses);
            cPnlAddCourses.Controls.Add(rTbCourseID);
            cPnlAddCourses.Controls.Add(lblCourseID);
            cPnlAddCourses.Controls.Add(rTbCourseTitle);
            cPnlAddCourses.Controls.Add(lblCourseTitle);
            cPnlAddCourses.CornerRadius = 5;
            cPnlAddCourses.Location = new Point(12, 200);
            cPnlAddCourses.Name = "cPnlAddCourses";
            cPnlAddCourses.Size = new Size(1493, 341);
            cPnlAddCourses.TabIndex = 24;
            // 
            // lblAddNewCourse
            // 
            lblAddNewCourse.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblAddNewCourse.ForeColor = Color.FromArgb(233, 69, 96);
            lblAddNewCourse.Location = new Point(13, 11);
            lblAddNewCourse.Name = "lblAddNewCourse";
            lblAddNewCourse.Size = new Size(230, 30);
            lblAddNewCourse.TabIndex = 2;
            lblAddNewCourse.Text = "+ Add New Course";
            lblAddNewCourse.TextAlign = ContentAlignment.MiddleLeft;
            lblAddNewCourse.UseCompatibleTextRendering = true;
            // 
            // rBtnDeleteCourses
            // 
            rBtnDeleteCourses.BackColor = Color.Firebrick;
            rBtnDeleteCourses.BorderColor = Color.White;
            rBtnDeleteCourses.BorderRadius = 5;
            rBtnDeleteCourses.FlatAppearance.BorderSize = 0;
            rBtnDeleteCourses.FlatStyle = FlatStyle.Flat;
            rBtnDeleteCourses.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnDeleteCourses.ForeColor = Color.White;
            rBtnDeleteCourses.HoverColor = Color.Empty;
            rBtnDeleteCourses.Location = new Point(286, 283);
            rBtnDeleteCourses.Name = "rBtnDeleteCourses";
            rBtnDeleteCourses.PressedColor = Color.Empty;
            rBtnDeleteCourses.Size = new Size(135, 40);
            rBtnDeleteCourses.TabIndex = 36;
            rBtnDeleteCourses.Text = "Delete Course";
            rBtnDeleteCourses.UseVisualStyleBackColor = false;
            // 
            // rBtnUpdateCourses
            // 
            rBtnUpdateCourses.BackColor = Color.DarkOrange;
            rBtnUpdateCourses.BorderColor = Color.White;
            rBtnUpdateCourses.BorderRadius = 5;
            rBtnUpdateCourses.FlatAppearance.BorderSize = 0;
            rBtnUpdateCourses.FlatStyle = FlatStyle.Flat;
            rBtnUpdateCourses.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnUpdateCourses.ForeColor = Color.White;
            rBtnUpdateCourses.HoverColor = Color.Empty;
            rBtnUpdateCourses.Location = new Point(141, 283);
            rBtnUpdateCourses.Name = "rBtnUpdateCourses";
            rBtnUpdateCourses.PressedColor = Color.Empty;
            rBtnUpdateCourses.Size = new Size(139, 40);
            rBtnUpdateCourses.TabIndex = 35;
            rBtnUpdateCourses.Text = "Update Course";
            rBtnUpdateCourses.UseVisualStyleBackColor = false;
            // 
            // rBtnCancelCourses
            // 
            rBtnCancelCourses.BackColor = Color.DimGray;
            rBtnCancelCourses.BorderColor = Color.White;
            rBtnCancelCourses.BorderRadius = 5;
            rBtnCancelCourses.FlatAppearance.BorderSize = 0;
            rBtnCancelCourses.FlatStyle = FlatStyle.Flat;
            rBtnCancelCourses.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnCancelCourses.ForeColor = Color.White;
            rBtnCancelCourses.HoverColor = Color.Empty;
            rBtnCancelCourses.Location = new Point(430, 283);
            rBtnCancelCourses.Name = "rBtnCancelCourses";
            rBtnCancelCourses.PressedColor = Color.Empty;
            rBtnCancelCourses.Size = new Size(82, 40);
            rBtnCancelCourses.TabIndex = 24;
            rBtnCancelCourses.Text = "Cancel";
            rBtnCancelCourses.UseVisualStyleBackColor = false;
            // 
            // rBtnAddCourse
            // 
            rBtnAddCourse.BackColor = Color.LimeGreen;
            rBtnAddCourse.BorderColor = Color.White;
            rBtnAddCourse.BorderRadius = 5;
            rBtnAddCourse.FlatAppearance.BorderSize = 0;
            rBtnAddCourse.FlatStyle = FlatStyle.Flat;
            rBtnAddCourse.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnAddCourse.ForeColor = Color.White;
            rBtnAddCourse.HoverColor = Color.Empty;
            rBtnAddCourse.Location = new Point(13, 283);
            rBtnAddCourse.Name = "rBtnAddCourse";
            rBtnAddCourse.PressedColor = Color.Empty;
            rBtnAddCourse.Size = new Size(122, 40);
            rBtnAddCourse.TabIndex = 24;
            rBtnAddCourse.Text = "Add Course";
            rBtnAddCourse.UseVisualStyleBackColor = false;
            // 
            // pnlProgramCourses
            // 
            pnlProgramCourses.Controls.Add(rTbProgramCourses);
            pnlProgramCourses.Location = new Point(972, 91);
            pnlProgramCourses.Name = "pnlProgramCourses";
            pnlProgramCourses.Size = new Size(340, 47);
            pnlProgramCourses.TabIndex = 32;
            // 
            // rTbProgramCourses
            // 
            rTbProgramCourses.BackColor = Color.Transparent;
            rTbProgramCourses.BorderColor = Color.FromArgb(233, 69, 96);
            rTbProgramCourses.BorderRadius = 5;
            rTbProgramCourses.FillColor = Color.FromArgb(22, 33, 62);
            rTbProgramCourses.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbProgramCourses.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbProgramCourses.ForeColor = Color.White;
            rTbProgramCourses.Location = new Point(0, 3);
            rTbProgramCourses.Name = "rTbProgramCourses";
            rTbProgramCourses.Padding = new Padding(2);
            rTbProgramCourses.PlaceholderText = "Enter or Select Program";
            rTbProgramCourses.Size = new Size(340, 35);
            rTbProgramCourses.TabIndex = 27;
            // 
            // listProgramCourses
            // 
            listProgramCourses.BackColor = Color.FromArgb(22, 33, 62);
            listProgramCourses.BorderStyle = BorderStyle.None;
            listProgramCourses.Font = new Font("Bahnschrift Light", 12F);
            listProgramCourses.ForeColor = Color.White;
            listProgramCourses.FormattingEnabled = true;
            listProgramCourses.Location = new Point(972, 144);
            listProgramCourses.Name = "listProgramCourses";
            listProgramCourses.Size = new Size(340, 19);
            listProgramCourses.TabIndex = 34;
            // 
            // lblProgramCourses
            // 
            lblProgramCourses.Font = new Font("Bahnschrift Light", 10F);
            lblProgramCourses.ForeColor = Color.White;
            lblProgramCourses.Location = new Point(972, 65);
            lblProgramCourses.Name = "lblProgramCourses";
            lblProgramCourses.Size = new Size(171, 23);
            lblProgramCourses.TabIndex = 33;
            lblProgramCourses.Text = "Program:";
            lblProgramCourses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rTbCourseID
            // 
            rTbCourseID.BackColor = Color.Transparent;
            rTbCourseID.BorderColor = Color.FromArgb(233, 69, 96);
            rTbCourseID.BorderRadius = 5;
            rTbCourseID.FillColor = Color.FromArgb(22, 33, 62);
            rTbCourseID.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbCourseID.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbCourseID.ForeColor = Color.White;
            rTbCourseID.Location = new Point(419, 91);
            rTbCourseID.Name = "rTbCourseID";
            rTbCourseID.Padding = new Padding(2);
            rTbCourseID.PlaceholderText = "e.g. 2765";
            rTbCourseID.Size = new Size(93, 40);
            rTbCourseID.TabIndex = 27;
            // 
            // lblCourseID
            // 
            lblCourseID.Font = new Font("Bahnschrift Light", 10F);
            lblCourseID.ForeColor = Color.White;
            lblCourseID.Location = new Point(419, 65);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(135, 23);
            lblCourseID.TabIndex = 26;
            lblCourseID.Text = "Course Code:";
            lblCourseID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rTbCourseTitle
            // 
            rTbCourseTitle.BackColor = Color.Transparent;
            rTbCourseTitle.BorderColor = Color.FromArgb(233, 69, 96);
            rTbCourseTitle.BorderRadius = 5;
            rTbCourseTitle.FillColor = Color.FromArgb(22, 33, 62);
            rTbCourseTitle.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbCourseTitle.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbCourseTitle.ForeColor = Color.White;
            rTbCourseTitle.Location = new Point(10, 91);
            rTbCourseTitle.Name = "rTbCourseTitle";
            rTbCourseTitle.Padding = new Padding(2);
            rTbCourseTitle.PlaceholderText = "e.g. CEE105";
            rTbCourseTitle.Size = new Size(135, 40);
            rTbCourseTitle.TabIndex = 25;
            // 
            // lblCourseTitle
            // 
            lblCourseTitle.Font = new Font("Bahnschrift Light", 10F);
            lblCourseTitle.ForeColor = Color.White;
            lblCourseTitle.Location = new Point(10, 65);
            lblCourseTitle.Name = "lblCourseTitle";
            lblCourseTitle.Size = new Size(135, 23);
            lblCourseTitle.TabIndex = 3;
            lblCourseTitle.Text = "Course Title:";
            lblCourseTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSearchSortCourses
            // 
            pnlSearchSortCourses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearchSortCourses.Controls.Add(rTbSearchCourses);
            pnlSearchSortCourses.Controls.Add(lblSlashCourses);
            pnlSearchSortCourses.Controls.Add(lblSortCourses);
            pnlSearchSortCourses.Controls.Add(rBtnSortTimeCourses);
            pnlSearchSortCourses.Controls.Add(rBtnSearchCourses);
            pnlSearchSortCourses.Controls.Add(rBtnSortIDCourses);
            pnlSearchSortCourses.Controls.Add(rBtnRefreshCourses);
            pnlSearchSortCourses.Controls.Add(rBtnSortNameCourses);
            pnlSearchSortCourses.Location = new Point(12, 112);
            pnlSearchSortCourses.Name = "pnlSearchSortCourses";
            pnlSearchSortCourses.Size = new Size(1493, 82);
            pnlSearchSortCourses.TabIndex = 25;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(12, 547);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(1493, 283);
            dgvCourses.TabIndex = 26;
            // 
            // rTbRoomNum
            // 
            rTbRoomNum.BackColor = Color.Transparent;
            rTbRoomNum.BorderColor = Color.FromArgb(233, 69, 96);
            rTbRoomNum.BorderRadius = 5;
            rTbRoomNum.FillColor = Color.FromArgb(22, 33, 62);
            rTbRoomNum.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbRoomNum.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbRoomNum.ForeColor = Color.White;
            rTbRoomNum.Location = new Point(10, 170);
            rTbRoomNum.Name = "rTbRoomNum";
            rTbRoomNum.Padding = new Padding(2);
            rTbRoomNum.PlaceholderText = "e.g. BE 212";
            rTbRoomNum.Size = new Size(135, 40);
            rTbRoomNum.TabIndex = 38;
            // 
            // lblRoomNum
            // 
            lblRoomNum.Font = new Font("Bahnschrift Light", 10F);
            lblRoomNum.ForeColor = Color.White;
            lblRoomNum.Location = new Point(13, 144);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(132, 23);
            lblRoomNum.TabIndex = 37;
            lblRoomNum.Text = "Room Number:";
            lblRoomNum.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rTbCourseTime
            // 
            rTbCourseTime.BackColor = Color.Transparent;
            rTbCourseTime.BorderColor = Color.FromArgb(233, 69, 96);
            rTbCourseTime.BorderRadius = 5;
            rTbCourseTime.FillColor = Color.FromArgb(22, 33, 62);
            rTbCourseTime.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbCourseTime.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbCourseTime.ForeColor = Color.White;
            rTbCourseTime.Location = new Point(158, 170);
            rTbCourseTime.Name = "rTbCourseTime";
            rTbCourseTime.Padding = new Padding(2);
            rTbCourseTime.PlaceholderText = "e.g. 5:30A-7:30E";
            rTbCourseTime.Size = new Size(135, 40);
            rTbCourseTime.TabIndex = 40;
            // 
            // lblCourseTime
            // 
            lblCourseTime.Font = new Font("Bahnschrift Light", 10F);
            lblCourseTime.ForeColor = Color.White;
            lblCourseTime.Location = new Point(161, 144);
            lblCourseTime.Name = "lblCourseTime";
            lblCourseTime.Size = new Size(132, 23);
            lblCourseTime.TabIndex = 39;
            lblCourseTime.Text = "Time:";
            lblCourseTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rTbCourseName
            // 
            rTbCourseName.BackColor = Color.Transparent;
            rTbCourseName.BorderColor = Color.FromArgb(233, 69, 96);
            rTbCourseName.BorderRadius = 5;
            rTbCourseName.FillColor = Color.FromArgb(22, 33, 62);
            rTbCourseName.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbCourseName.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbCourseName.ForeColor = Color.White;
            rTbCourseName.Location = new Point(158, 91);
            rTbCourseName.Name = "rTbCourseName";
            rTbCourseName.Padding = new Padding(2);
            rTbCourseName.PlaceholderText = "ENGINEERING DATA ANALYSIS";
            rTbCourseName.Size = new Size(244, 40);
            rTbCourseName.TabIndex = 42;
            // 
            // lblCourseName
            // 
            lblCourseName.Font = new Font("Bahnschrift Light", 10F);
            lblCourseName.ForeColor = Color.White;
            lblCourseName.Location = new Point(158, 65);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(135, 23);
            lblCourseName.TabIndex = 41;
            lblCourseName.Text = "Course Name:";
            lblCourseName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDay
            // 
            lblDay.Font = new Font("Bahnschrift Light", 10F);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(310, 144);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(78, 23);
            lblDay.TabIndex = 43;
            lblDay.Text = "Day:";
            lblDay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listDay
            // 
            listDay.BackColor = Color.FromArgb(22, 33, 62);
            listDay.BorderStyle = BorderStyle.None;
            listDay.Font = new Font("Bahnschrift Light", 12F);
            listDay.ForeColor = Color.White;
            listDay.FormattingEnabled = true;
            listDay.Items.AddRange(new object[] { "M-Sa", "M-Fri", "Sa", "M-SA1", "M-SA2" });
            listDay.Location = new Point(310, 170);
            listDay.Name = "listDay";
            listDay.Size = new Size(78, 19);
            listDay.TabIndex = 44;
            // 
            // listBoxTerm
            // 
            listBoxTerm.BackColor = Color.FromArgb(22, 33, 62);
            listBoxTerm.BorderStyle = BorderStyle.None;
            listBoxTerm.Font = new Font("Bahnschrift Light", 12F);
            listBoxTerm.ForeColor = Color.White;
            listBoxTerm.FormattingEnabled = true;
            listBoxTerm.Items.AddRange(new object[] { "Sem", "Tern", "Summer" });
            listBoxTerm.Location = new Point(409, 170);
            listBoxTerm.Name = "listBoxTerm";
            listBoxTerm.Size = new Size(78, 19);
            listBoxTerm.TabIndex = 46;
            // 
            // lblTerm
            // 
            lblTerm.Font = new Font("Bahnschrift Light", 10F);
            lblTerm.ForeColor = Color.White;
            lblTerm.Location = new Point(409, 144);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(78, 23);
            lblTerm.TabIndex = 45;
            lblTerm.Text = "Term:";
            lblTerm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInstructorAssignment
            // 
            lblInstructorAssignment.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblInstructorAssignment.ForeColor = Color.FromArgb(233, 69, 96);
            lblInstructorAssignment.Location = new Point(695, 11);
            lblInstructorAssignment.Name = "lblInstructorAssignment";
            lblInstructorAssignment.Size = new Size(230, 30);
            lblInstructorAssignment.TabIndex = 47;
            lblInstructorAssignment.Text = "Instructor Assignment";
            lblInstructorAssignment.TextAlign = ContentAlignment.MiddleLeft;
            lblInstructorAssignment.UseCompatibleTextRendering = true;
            lblInstructorAssignment.Click += label1_Click;
            // 
            // lblAssignInstructor
            // 
            lblAssignInstructor.Font = new Font("Bahnschrift Light", 10F);
            lblAssignInstructor.ForeColor = Color.White;
            lblAssignInstructor.Location = new Point(695, 65);
            lblAssignInstructor.Name = "lblAssignInstructor";
            lblAssignInstructor.Size = new Size(135, 23);
            lblAssignInstructor.TabIndex = 48;
            lblAssignInstructor.Text = "Assign Instructor: ";
            lblAssignInstructor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlAssignInstructor
            // 
            pnlAssignInstructor.Controls.Add(rTbAssignInstructor);
            pnlAssignInstructor.Location = new Point(695, 94);
            pnlAssignInstructor.Name = "pnlAssignInstructor";
            pnlAssignInstructor.Size = new Size(257, 47);
            pnlAssignInstructor.TabIndex = 35;
            // 
            // rTbAssignInstructor
            // 
            rTbAssignInstructor.BackColor = Color.Transparent;
            rTbAssignInstructor.BorderColor = Color.FromArgb(233, 69, 96);
            rTbAssignInstructor.BorderRadius = 5;
            rTbAssignInstructor.FillColor = Color.FromArgb(22, 33, 62);
            rTbAssignInstructor.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbAssignInstructor.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbAssignInstructor.ForeColor = Color.White;
            rTbAssignInstructor.Location = new Point(0, 3);
            rTbAssignInstructor.Name = "rTbAssignInstructor";
            rTbAssignInstructor.Padding = new Padding(2);
            rTbAssignInstructor.PlaceholderText = "Enter or Select Instructor";
            rTbAssignInstructor.Size = new Size(257, 35);
            rTbAssignInstructor.TabIndex = 27;
            // 
            // listBoxAssignInstructor
            // 
            listBoxAssignInstructor.BackColor = Color.FromArgb(22, 33, 62);
            listBoxAssignInstructor.BorderStyle = BorderStyle.None;
            listBoxAssignInstructor.Font = new Font("Bahnschrift Light", 12F);
            listBoxAssignInstructor.ForeColor = Color.White;
            listBoxAssignInstructor.FormattingEnabled = true;
            listBoxAssignInstructor.Location = new Point(695, 147);
            listBoxAssignInstructor.Name = "listBoxAssignInstructor";
            listBoxAssignInstructor.Size = new Size(257, 19);
            listBoxAssignInstructor.TabIndex = 36;
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
            cPnlAddCourses.ResumeLayout(false);
            pnlProgramCourses.ResumeLayout(false);
            pnlSearchSortCourses.ResumeLayout(false);
            pnlSearchSortCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            pnlAssignInstructor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderInstructorC;
        private Label lblCourseheader;
        private Label lblCourseManagement;
        private RoundedTextBox rTbSearchCourses;
        private RoundedButton rBtnSearchCourses;
        private RoundedButton rBtnRefreshCourses;
        private Label lblSlashCourses;
        private Label lblSortCourses;
        private RoundedButton rBtnSortNameCourses;
        private RoundedButton rBtnSortIDCourses;
        private RoundedButton rBtnSortTimeCourses;
        private CustomPanel cPnlAddCourses;
        private Label lblAddNewCourse;
        private Label lblCourseTitle;
        private RoundedTextBox rTbCourseTitle;
        private RoundedTextBox rTbCourseID;
        private Label lblCourseID;
        private Panel pnlSearchSortCourses;
        private RoundedTextBox rTbProgramCourses;
        private Label lblProgramCourses;
        private ListBox listProgramCourses;
        private Panel pnlProgramCourses;
        private RoundedButton rBtnAddCourse;
        private RoundedButton rBtnCancelCourses;
        private DataGridView dgvCourses;
        private RoundedButton rBtnUpdateCourses;
        private RoundedButton rBtnDeleteCourses;
        private RoundedTextBox rTbCourseTime;
        private Label lblCourseTime;
        private RoundedTextBox rTbRoomNum;
        private Label lblRoomNum;
        private RoundedTextBox rTbCourseName;
        private Label lblCourseName;
        private Label lblDay;
        private ListBox listDay;
        private ListBox listBoxTerm;
        private Label lblTerm;
        private Label lblInstructorAssignment;
        private Label lblAssignInstructor;
        private Panel pnlAssignInstructor;
        private RoundedTextBox rTbAssignInstructor;
        private ListBox listBoxAssignInstructor;
    }
}
