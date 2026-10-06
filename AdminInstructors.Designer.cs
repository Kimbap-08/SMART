namespace SMART
{
    partial class AdminInstructors
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
            dgvInstructors = new DataGridView();
            pnlSearchSortInstructor = new Panel();
            rBtnSortProgramInstructor = new RoundedButton();
            rTbSearchInstructor = new RoundedTextBox();
            lblSortInstructor = new Label();
            rBtnSortDeptInstructor = new RoundedButton();
            rBtnSearchInstructor = new RoundedButton();
            rBtnSortIDInstructor = new RoundedButton();
            rBtnRefreshInstructor = new RoundedButton();
            rBtnSortNameInstructor = new RoundedButton();
            pnlHeaderInstructorMgt = new Panel();
            lblInstructorheader = new Label();
            lblInstructorManagement = new Label();
            cPnlAddInstructor = new CustomPanel();
            lblAddNewInstructor = new Label();
            rBtnDeleteInstructor = new RoundedButton();
            rBtnUpdateInstructor = new RoundedButton();
            rBtnCancelInstructor = new RoundedButton();
            rBtnAddInstructor = new RoundedButton();
            pnlProgram = new Panel();
            rTbProgramInstructor = new RoundedTextBox();
            listProgramInstructor = new ListBox();
            listDeptInstructor = new ListBox();
            pnlDept = new Panel();
            rTbDepartmentInstructor = new RoundedTextBox();
            rTbStudentID = new RoundedTextBox();
            lblEmployeeNumber = new Label();
            rTbInstructorName = new RoundedTextBox();
            lblInstructorName = new Label();
            lblProgramInstructor = new Label();
            lblDepartmentInstructor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).BeginInit();
            pnlSearchSortInstructor.SuspendLayout();
            pnlHeaderInstructorMgt.SuspendLayout();
            cPnlAddInstructor.SuspendLayout();
            pnlProgram.SuspendLayout();
            pnlDept.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInstructors
            // 
            dgvInstructors.AllowUserToDeleteRows = false;
            dgvInstructors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInstructors.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstructors.Location = new Point(12, 490);
            dgvInstructors.Name = "dgvInstructors";
            dgvInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInstructors.Size = new Size(1493, 340);
            dgvInstructors.TabIndex = 30;
            // 
            // pnlSearchSortInstructor
            // 
            pnlSearchSortInstructor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearchSortInstructor.BackColor = Color.FromArgb(26, 26, 46);
            pnlSearchSortInstructor.Controls.Add(rBtnSortProgramInstructor);
            pnlSearchSortInstructor.Controls.Add(rTbSearchInstructor);
            pnlSearchSortInstructor.Controls.Add(lblSortInstructor);
            pnlSearchSortInstructor.Controls.Add(rBtnSortDeptInstructor);
            pnlSearchSortInstructor.Controls.Add(rBtnSearchInstructor);
            pnlSearchSortInstructor.Controls.Add(rBtnSortIDInstructor);
            pnlSearchSortInstructor.Controls.Add(rBtnRefreshInstructor);
            pnlSearchSortInstructor.Controls.Add(rBtnSortNameInstructor);
            pnlSearchSortInstructor.Location = new Point(12, 112);
            pnlSearchSortInstructor.Name = "pnlSearchSortInstructor";
            pnlSearchSortInstructor.Size = new Size(1493, 82);
            pnlSearchSortInstructor.TabIndex = 29;
            // 
            // rBtnSortProgramInstructor
            // 
            rBtnSortProgramInstructor.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortProgramInstructor.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortProgramInstructor.BorderRadius = 5;
            rBtnSortProgramInstructor.BorderSize = 2;
            rBtnSortProgramInstructor.FlatAppearance.BorderSize = 0;
            rBtnSortProgramInstructor.FlatStyle = FlatStyle.Flat;
            rBtnSortProgramInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortProgramInstructor.ForeColor = Color.White;
            rBtnSortProgramInstructor.HoverColor = Color.Empty;
            rBtnSortProgramInstructor.Location = new Point(1034, 30);
            rBtnSortProgramInstructor.Name = "rBtnSortProgramInstructor";
            rBtnSortProgramInstructor.PressedColor = Color.Empty;
            rBtnSortProgramInstructor.Size = new Size(110, 40);
            rBtnSortProgramInstructor.TabIndex = 24;
            rBtnSortProgramInstructor.Text = "Program";
            rBtnSortProgramInstructor.UseVisualStyleBackColor = false;
            // 
            // rTbSearchInstructor
            // 
            rTbSearchInstructor.BackColor = Color.Transparent;
            rTbSearchInstructor.BorderColor = Color.FromArgb(233, 69, 96);
            rTbSearchInstructor.BorderRadius = 5;
            rTbSearchInstructor.FillColor = Color.FromArgb(22, 33, 62);
            rTbSearchInstructor.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbSearchInstructor.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbSearchInstructor.ForeColor = Color.White;
            rTbSearchInstructor.Location = new Point(13, 30);
            rTbSearchInstructor.Name = "rTbSearchInstructor";
            rTbSearchInstructor.Padding = new Padding(2);
            rTbSearchInstructor.PlaceholderText = "Search by Name, ID, Program, Year Level ";
            rTbSearchInstructor.Size = new Size(375, 40);
            rTbSearchInstructor.TabIndex = 17;
            // 
            // lblSortInstructor
            // 
            lblSortInstructor.AutoSize = true;
            lblSortInstructor.Font = new Font("Bahnschrift", 10F);
            lblSortInstructor.ForeColor = Color.White;
            lblSortInstructor.Location = new Point(609, 39);
            lblSortInstructor.Name = "lblSortInstructor";
            lblSortInstructor.Size = new Size(57, 17);
            lblSortInstructor.TabIndex = 3;
            lblSortInstructor.Text = "Sort by:";
            lblSortInstructor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rBtnSortDeptInstructor
            // 
            rBtnSortDeptInstructor.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortDeptInstructor.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortDeptInstructor.BorderRadius = 5;
            rBtnSortDeptInstructor.BorderSize = 2;
            rBtnSortDeptInstructor.FlatAppearance.BorderSize = 0;
            rBtnSortDeptInstructor.FlatStyle = FlatStyle.Flat;
            rBtnSortDeptInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortDeptInstructor.ForeColor = Color.White;
            rBtnSortDeptInstructor.HoverColor = Color.Empty;
            rBtnSortDeptInstructor.Location = new Point(921, 30);
            rBtnSortDeptInstructor.Name = "rBtnSortDeptInstructor";
            rBtnSortDeptInstructor.PressedColor = Color.Empty;
            rBtnSortDeptInstructor.Size = new Size(74, 40);
            rBtnSortDeptInstructor.TabIndex = 23;
            rBtnSortDeptInstructor.Text = "Dept";
            rBtnSortDeptInstructor.UseVisualStyleBackColor = false;
            // 
            // rBtnSearchInstructor
            // 
            rBtnSearchInstructor.BackColor = Color.FromArgb(233, 69, 96);
            rBtnSearchInstructor.BorderColor = Color.White;
            rBtnSearchInstructor.BorderRadius = 5;
            rBtnSearchInstructor.FlatAppearance.BorderSize = 0;
            rBtnSearchInstructor.FlatStyle = FlatStyle.Flat;
            rBtnSearchInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSearchInstructor.ForeColor = Color.White;
            rBtnSearchInstructor.HoverColor = Color.Empty;
            rBtnSearchInstructor.Location = new Point(394, 30);
            rBtnSearchInstructor.Name = "rBtnSearchInstructor";
            rBtnSearchInstructor.PressedColor = Color.Empty;
            rBtnSearchInstructor.Size = new Size(93, 40);
            rBtnSearchInstructor.TabIndex = 18;
            rBtnSearchInstructor.Text = "Search";
            rBtnSearchInstructor.UseVisualStyleBackColor = false;
            // 
            // rBtnSortIDInstructor
            // 
            rBtnSortIDInstructor.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortIDInstructor.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortIDInstructor.BorderRadius = 5;
            rBtnSortIDInstructor.BorderSize = 2;
            rBtnSortIDInstructor.FlatAppearance.BorderSize = 0;
            rBtnSortIDInstructor.FlatStyle = FlatStyle.Flat;
            rBtnSortIDInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortIDInstructor.ForeColor = Color.White;
            rBtnSortIDInstructor.HoverColor = Color.Empty;
            rBtnSortIDInstructor.Location = new Point(808, 30);
            rBtnSortIDInstructor.Name = "rBtnSortIDInstructor";
            rBtnSortIDInstructor.PressedColor = Color.Empty;
            rBtnSortIDInstructor.Size = new Size(74, 40);
            rBtnSortIDInstructor.TabIndex = 22;
            rBtnSortIDInstructor.Text = "ID No.";
            rBtnSortIDInstructor.UseVisualStyleBackColor = false;
            // 
            // rBtnRefreshInstructor
            // 
            rBtnRefreshInstructor.BackColor = Color.DimGray;
            rBtnRefreshInstructor.BorderColor = Color.White;
            rBtnRefreshInstructor.BorderRadius = 5;
            rBtnRefreshInstructor.FlatAppearance.BorderSize = 0;
            rBtnRefreshInstructor.FlatStyle = FlatStyle.Flat;
            rBtnRefreshInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnRefreshInstructor.ForeColor = Color.White;
            rBtnRefreshInstructor.HoverColor = Color.Empty;
            rBtnRefreshInstructor.Location = new Point(493, 30);
            rBtnRefreshInstructor.Name = "rBtnRefreshInstructor";
            rBtnRefreshInstructor.PressedColor = Color.Empty;
            rBtnRefreshInstructor.Size = new Size(93, 40);
            rBtnRefreshInstructor.TabIndex = 19;
            rBtnRefreshInstructor.Text = "Refresh";
            rBtnRefreshInstructor.UseVisualStyleBackColor = false;
            // 
            // rBtnSortNameInstructor
            // 
            rBtnSortNameInstructor.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortNameInstructor.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortNameInstructor.BorderRadius = 5;
            rBtnSortNameInstructor.BorderSize = 2;
            rBtnSortNameInstructor.FlatAppearance.BorderSize = 0;
            rBtnSortNameInstructor.FlatStyle = FlatStyle.Flat;
            rBtnSortNameInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortNameInstructor.ForeColor = Color.White;
            rBtnSortNameInstructor.HoverColor = Color.Empty;
            rBtnSortNameInstructor.Location = new Point(695, 30);
            rBtnSortNameInstructor.Name = "rBtnSortNameInstructor";
            rBtnSortNameInstructor.PressedColor = Color.Empty;
            rBtnSortNameInstructor.Size = new Size(74, 40);
            rBtnSortNameInstructor.TabIndex = 21;
            rBtnSortNameInstructor.Text = "Name";
            rBtnSortNameInstructor.UseVisualStyleBackColor = false;
            // 
            // pnlHeaderInstructorMgt
            // 
            pnlHeaderInstructorMgt.BackColor = Color.FromArgb(22, 33, 62);
            pnlHeaderInstructorMgt.Controls.Add(lblInstructorheader);
            pnlHeaderInstructorMgt.Controls.Add(lblInstructorManagement);
            pnlHeaderInstructorMgt.Dock = DockStyle.Top;
            pnlHeaderInstructorMgt.Location = new Point(0, 0);
            pnlHeaderInstructorMgt.Name = "pnlHeaderInstructorMgt";
            pnlHeaderInstructorMgt.Size = new Size(1540, 106);
            pnlHeaderInstructorMgt.TabIndex = 27;
            // 
            // lblInstructorheader
            // 
            lblInstructorheader.Anchor = AnchorStyles.Left;
            lblInstructorheader.Font = new Font("Bahnschrift Light", 10F);
            lblInstructorheader.ForeColor = Color.White;
            lblInstructorheader.Location = new Point(25, 68);
            lblInstructorheader.Name = "lblInstructorheader";
            lblInstructorheader.Size = new Size(319, 23);
            lblInstructorheader.TabIndex = 2;
            lblInstructorheader.Text = "Manage Instructor Accounts";
            lblInstructorheader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInstructorManagement
            // 
            lblInstructorManagement.Anchor = AnchorStyles.Left;
            lblInstructorManagement.AutoSize = true;
            lblInstructorManagement.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            lblInstructorManagement.ForeColor = Color.White;
            lblInstructorManagement.Location = new Point(25, 36);
            lblInstructorManagement.Name = "lblInstructorManagement";
            lblInstructorManagement.Size = new Size(319, 32);
            lblInstructorManagement.TabIndex = 0;
            lblInstructorManagement.Text = "Instructor Management";
            // 
            // cPnlAddInstructor
            // 
            cPnlAddInstructor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cPnlAddInstructor.BackColor = Color.FromArgb(22, 33, 62);
            cPnlAddInstructor.BorderColor = Color.FromArgb(22, 33, 62);
            cPnlAddInstructor.Controls.Add(lblAddNewInstructor);
            cPnlAddInstructor.Controls.Add(rBtnDeleteInstructor);
            cPnlAddInstructor.Controls.Add(rBtnUpdateInstructor);
            cPnlAddInstructor.Controls.Add(rBtnCancelInstructor);
            cPnlAddInstructor.Controls.Add(rBtnAddInstructor);
            cPnlAddInstructor.Controls.Add(pnlProgram);
            cPnlAddInstructor.Controls.Add(listProgramInstructor);
            cPnlAddInstructor.Controls.Add(listDeptInstructor);
            cPnlAddInstructor.Controls.Add(pnlDept);
            cPnlAddInstructor.Controls.Add(rTbStudentID);
            cPnlAddInstructor.Controls.Add(lblEmployeeNumber);
            cPnlAddInstructor.Controls.Add(rTbInstructorName);
            cPnlAddInstructor.Controls.Add(lblInstructorName);
            cPnlAddInstructor.Controls.Add(lblProgramInstructor);
            cPnlAddInstructor.Controls.Add(lblDepartmentInstructor);
            cPnlAddInstructor.CornerRadius = 5;
            cPnlAddInstructor.Location = new Point(12, 200);
            cPnlAddInstructor.Name = "cPnlAddInstructor";
            cPnlAddInstructor.Size = new Size(1493, 281);
            cPnlAddInstructor.TabIndex = 28;
            // 
            // lblAddNewInstructor
            // 
            lblAddNewInstructor.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblAddNewInstructor.ForeColor = Color.FromArgb(233, 69, 96);
            lblAddNewInstructor.Location = new Point(13, 11);
            lblAddNewInstructor.Name = "lblAddNewInstructor";
            lblAddNewInstructor.Size = new Size(450, 30);
            lblAddNewInstructor.TabIndex = 2;
            lblAddNewInstructor.Text = "+ Add New Instructor";
            lblAddNewInstructor.TextAlign = ContentAlignment.MiddleLeft;
            lblAddNewInstructor.UseCompatibleTextRendering = true;
            // 
            // rBtnDeleteInstructor
            // 
            rBtnDeleteInstructor.BackColor = Color.Firebrick;
            rBtnDeleteInstructor.BorderColor = Color.White;
            rBtnDeleteInstructor.BorderRadius = 5;
            rBtnDeleteInstructor.FlatAppearance.BorderSize = 0;
            rBtnDeleteInstructor.FlatStyle = FlatStyle.Flat;
            rBtnDeleteInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnDeleteInstructor.ForeColor = Color.White;
            rBtnDeleteInstructor.HoverColor = Color.Empty;
            rBtnDeleteInstructor.Location = new Point(283, 221);
            rBtnDeleteInstructor.Name = "rBtnDeleteInstructor";
            rBtnDeleteInstructor.PressedColor = Color.Empty;
            rBtnDeleteInstructor.Size = new Size(135, 40);
            rBtnDeleteInstructor.TabIndex = 36;
            rBtnDeleteInstructor.Text = "Delete Instructor";
            rBtnDeleteInstructor.UseVisualStyleBackColor = false;
            // 
            // rBtnUpdateInstructor
            // 
            rBtnUpdateInstructor.BackColor = Color.DarkOrange;
            rBtnUpdateInstructor.BorderColor = Color.White;
            rBtnUpdateInstructor.BorderRadius = 5;
            rBtnUpdateInstructor.FlatAppearance.BorderSize = 0;
            rBtnUpdateInstructor.FlatStyle = FlatStyle.Flat;
            rBtnUpdateInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnUpdateInstructor.ForeColor = Color.White;
            rBtnUpdateInstructor.HoverColor = Color.Empty;
            rBtnUpdateInstructor.Location = new Point(138, 221);
            rBtnUpdateInstructor.Name = "rBtnUpdateInstructor";
            rBtnUpdateInstructor.PressedColor = Color.Empty;
            rBtnUpdateInstructor.Size = new Size(139, 40);
            rBtnUpdateInstructor.TabIndex = 35;
            rBtnUpdateInstructor.Text = "Update Instructor";
            rBtnUpdateInstructor.UseVisualStyleBackColor = false;
            // 
            // rBtnCancelInstructor
            // 
            rBtnCancelInstructor.BackColor = Color.DimGray;
            rBtnCancelInstructor.BorderColor = Color.White;
            rBtnCancelInstructor.BorderRadius = 5;
            rBtnCancelInstructor.FlatAppearance.BorderSize = 0;
            rBtnCancelInstructor.FlatStyle = FlatStyle.Flat;
            rBtnCancelInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnCancelInstructor.ForeColor = Color.White;
            rBtnCancelInstructor.HoverColor = Color.Empty;
            rBtnCancelInstructor.Location = new Point(427, 221);
            rBtnCancelInstructor.Name = "rBtnCancelInstructor";
            rBtnCancelInstructor.PressedColor = Color.Empty;
            rBtnCancelInstructor.Size = new Size(82, 40);
            rBtnCancelInstructor.TabIndex = 24;
            rBtnCancelInstructor.Text = "Cancel";
            rBtnCancelInstructor.UseVisualStyleBackColor = false;
            // 
            // rBtnAddInstructor
            // 
            rBtnAddInstructor.BackColor = Color.LimeGreen;
            rBtnAddInstructor.BorderColor = Color.White;
            rBtnAddInstructor.BorderRadius = 5;
            rBtnAddInstructor.FlatAppearance.BorderSize = 0;
            rBtnAddInstructor.FlatStyle = FlatStyle.Flat;
            rBtnAddInstructor.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnAddInstructor.ForeColor = Color.White;
            rBtnAddInstructor.HoverColor = Color.Empty;
            rBtnAddInstructor.Location = new Point(10, 221);
            rBtnAddInstructor.Name = "rBtnAddInstructor";
            rBtnAddInstructor.PressedColor = Color.Empty;
            rBtnAddInstructor.Size = new Size(122, 40);
            rBtnAddInstructor.TabIndex = 24;
            rBtnAddInstructor.Text = "Add Instructor";
            rBtnAddInstructor.UseVisualStyleBackColor = false;
            // 
            // pnlProgram
            // 
            pnlProgram.Controls.Add(rTbProgramInstructor);
            pnlProgram.Location = new Point(695, 94);
            pnlProgram.Name = "pnlProgram";
            pnlProgram.Size = new Size(340, 47);
            pnlProgram.TabIndex = 32;
            // 
            // rTbProgramInstructor
            // 
            rTbProgramInstructor.BackColor = Color.Transparent;
            rTbProgramInstructor.BorderColor = Color.FromArgb(233, 69, 96);
            rTbProgramInstructor.BorderRadius = 5;
            rTbProgramInstructor.FillColor = Color.FromArgb(22, 33, 62);
            rTbProgramInstructor.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbProgramInstructor.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbProgramInstructor.ForeColor = Color.White;
            rTbProgramInstructor.Location = new Point(0, 3);
            rTbProgramInstructor.Name = "rTbProgramInstructor";
            rTbProgramInstructor.Padding = new Padding(2);
            rTbProgramInstructor.PlaceholderText = "Enter or Select Program";
            rTbProgramInstructor.Size = new Size(340, 35);
            rTbProgramInstructor.TabIndex = 27;
            // 
            // listProgramInstructor
            // 
            listProgramInstructor.BackColor = Color.FromArgb(22, 33, 62);
            listProgramInstructor.BorderStyle = BorderStyle.None;
            listProgramInstructor.Font = new Font("Bahnschrift Light", 12F);
            listProgramInstructor.ForeColor = Color.White;
            listProgramInstructor.FormattingEnabled = true;
            listProgramInstructor.Location = new Point(695, 147);
            listProgramInstructor.Name = "listProgramInstructor";
            listProgramInstructor.Size = new Size(340, 19);
            listProgramInstructor.TabIndex = 34;
            // 
            // listDeptInstructor
            // 
            listDeptInstructor.BackColor = Color.FromArgb(22, 33, 62);
            listDeptInstructor.BorderStyle = BorderStyle.None;
            listDeptInstructor.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listDeptInstructor.ForeColor = Color.White;
            listDeptInstructor.FormattingEnabled = true;
            listDeptInstructor.Items.AddRange(new object[] { "College of Accounting Education (CAE)", "", "", "College of Architecture and Fine Arts Education (CAFAE)", "", "", "College of Arts and Sciences Education (CASE)", "", "", "College of Business Administration Education (CBAE)", "", "", "College of Computing Education (CCE)", "", "", "College of Criminal Justice Education (CCJE)", "", "", "College of Engineering Education (CEE)", "", "", "College of Health Sciences Education (CHSE)", "", "", "College of Hospitality Education (CHE)", "", "", "College of Legal Education (CLE)", "", "", "College of Teacher Education (CTE)" });
            listDeptInstructor.Location = new Point(1099, 147);
            listDeptInstructor.Name = "listDeptInstructor";
            listDeptInstructor.Size = new Size(340, 19);
            listDeptInstructor.TabIndex = 32;
            // 
            // pnlDept
            // 
            pnlDept.Controls.Add(rTbDepartmentInstructor);
            pnlDept.Location = new Point(1099, 94);
            pnlDept.Name = "pnlDept";
            pnlDept.Size = new Size(340, 47);
            pnlDept.TabIndex = 31;
            // 
            // rTbDepartmentInstructor
            // 
            rTbDepartmentInstructor.BackColor = Color.Transparent;
            rTbDepartmentInstructor.BorderColor = Color.FromArgb(233, 69, 96);
            rTbDepartmentInstructor.BorderRadius = 5;
            rTbDepartmentInstructor.FillColor = Color.FromArgb(22, 33, 62);
            rTbDepartmentInstructor.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbDepartmentInstructor.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbDepartmentInstructor.ForeColor = Color.White;
            rTbDepartmentInstructor.Location = new Point(0, 3);
            rTbDepartmentInstructor.Name = "rTbDepartmentInstructor";
            rTbDepartmentInstructor.Padding = new Padding(2);
            rTbDepartmentInstructor.PlaceholderText = "Enter or Select Department";
            rTbDepartmentInstructor.Size = new Size(340, 35);
            rTbDepartmentInstructor.TabIndex = 26;
            // 
            // rTbStudentID
            // 
            rTbStudentID.BackColor = Color.Transparent;
            rTbStudentID.BorderColor = Color.FromArgb(233, 69, 96);
            rTbStudentID.BorderRadius = 5;
            rTbStudentID.FillColor = Color.FromArgb(22, 33, 62);
            rTbStudentID.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbStudentID.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbStudentID.ForeColor = Color.White;
            rTbStudentID.Location = new Point(374, 91);
            rTbStudentID.Name = "rTbStudentID";
            rTbStudentID.Padding = new Padding(2);
            rTbStudentID.PlaceholderText = "e.g. 2024-00001";
            rTbStudentID.Size = new Size(135, 40);
            rTbStudentID.TabIndex = 27;
            // 
            // lblEmployeeNumber
            // 
            lblEmployeeNumber.Font = new Font("Bahnschrift Light", 10F);
            lblEmployeeNumber.ForeColor = Color.White;
            lblEmployeeNumber.Location = new Point(374, 65);
            lblEmployeeNumber.Name = "lblEmployeeNumber";
            lblEmployeeNumber.Size = new Size(171, 23);
            lblEmployeeNumber.TabIndex = 26;
            lblEmployeeNumber.Text = "Employee ID:";
            lblEmployeeNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rTbInstructorName
            // 
            rTbInstructorName.BackColor = Color.Transparent;
            rTbInstructorName.BorderColor = Color.FromArgb(233, 69, 96);
            rTbInstructorName.BorderRadius = 5;
            rTbInstructorName.FillColor = Color.FromArgb(22, 33, 62);
            rTbInstructorName.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbInstructorName.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbInstructorName.ForeColor = Color.White;
            rTbInstructorName.Location = new Point(10, 91);
            rTbInstructorName.Name = "rTbInstructorName";
            rTbInstructorName.Padding = new Padding(2);
            rTbInstructorName.PlaceholderText = "FIRST NAME, MIDDLE INITIAL, SURNAME";
            rTbInstructorName.Size = new Size(340, 40);
            rTbInstructorName.TabIndex = 25;
            // 
            // lblInstructorName
            // 
            lblInstructorName.Font = new Font("Bahnschrift Light", 10F);
            lblInstructorName.ForeColor = Color.White;
            lblInstructorName.Location = new Point(10, 65);
            lblInstructorName.Name = "lblInstructorName";
            lblInstructorName.Size = new Size(171, 23);
            lblInstructorName.TabIndex = 3;
            lblInstructorName.Text = "Full Name:";
            lblInstructorName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProgramInstructor
            // 
            lblProgramInstructor.Font = new Font("Bahnschrift Light", 10F);
            lblProgramInstructor.ForeColor = Color.White;
            lblProgramInstructor.Location = new Point(695, 68);
            lblProgramInstructor.Name = "lblProgramInstructor";
            lblProgramInstructor.Size = new Size(171, 23);
            lblProgramInstructor.TabIndex = 33;
            lblProgramInstructor.Text = "Program:";
            lblProgramInstructor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDepartmentInstructor
            // 
            lblDepartmentInstructor.Font = new Font("Bahnschrift Light", 10F);
            lblDepartmentInstructor.ForeColor = Color.White;
            lblDepartmentInstructor.Location = new Point(1099, 68);
            lblDepartmentInstructor.Name = "lblDepartmentInstructor";
            lblDepartmentInstructor.Size = new Size(171, 23);
            lblDepartmentInstructor.TabIndex = 30;
            lblDepartmentInstructor.Text = "Department:";
            lblDepartmentInstructor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AdminInstructors
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(1540, 845);
            Controls.Add(dgvInstructors);
            Controls.Add(pnlSearchSortInstructor);
            Controls.Add(pnlHeaderInstructorMgt);
            Controls.Add(cPnlAddInstructor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminInstructors";
            Text = "AdminInstructors";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).EndInit();
            pnlSearchSortInstructor.ResumeLayout(false);
            pnlSearchSortInstructor.PerformLayout();
            pnlHeaderInstructorMgt.ResumeLayout(false);
            pnlHeaderInstructorMgt.PerformLayout();
            cPnlAddInstructor.ResumeLayout(false);
            pnlProgram.ResumeLayout(false);
            pnlDept.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInstructors;
        private Panel pnlSearchSortInstructor;
        private RoundedTextBox rTbSearchInstructor;
        private Label lblSortInstructor;
        private RoundedButton rBtnSortDeptInstructor;
        private RoundedButton rBtnSearchInstructor;
        private RoundedButton rBtnSortIDInstructor;
        private RoundedButton rBtnRefreshInstructor;
        private RoundedButton rBtnSortNameInstructor;
        private Panel pnlHeaderInstructorMgt;
        private Label lblInstructorheader;
        private Label lblInstructorManagement;
        private CustomPanel cPnlAddInstructor;
        private Label lblAddNewInstructor;
        private RoundedButton rBtnDeleteInstructor;
        private RoundedButton rBtnUpdateInstructor;
        private RoundedButton rBtnCancelInstructor;
        private RoundedButton rBtnAddInstructor;
        private Panel pnlProgram;
        private RoundedTextBox rTbProgramInstructor;
        private ListBox listProgramInstructor;
        private Label lblProgramInstructor;
        private ListBox listDeptInstructor;
        private Panel pnlDept;
        private RoundedTextBox rTbDepartmentInstructor;
        private Label lblDepartmentInstructor;
        private RoundedTextBox rTbStudentID;
        private Label lblEmployeeNumber;
        private RoundedTextBox rTbInstructorName;
        private Label lblInstructorName;
        private RoundedButton rBtnSortProgramInstructor;
    }
}
