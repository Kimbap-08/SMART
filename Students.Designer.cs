namespace SMART
{
    partial class Students
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
            pnlHeaderInstructor = new Panel();
            lblStudentheader = new Label();
            lblStudentManagement = new Label();
            rTbSearchStudents = new RoundedTextBox();
            rBtnSearch = new RoundedButton();
            rBtnRefresh = new RoundedButton();
            lblSlash = new Label();
            lblSort = new Label();
            rBtnSortName = new RoundedButton();
            rBtnSortID = new RoundedButton();
            rBtnSortYear = new RoundedButton();
            cPnlAddStudent = new CustomPanel();
            lblAddNewStudent = new Label();
            rBtnDelete = new RoundedButton();
            rBtnUpdate = new RoundedButton();
            rBtnCancel = new RoundedButton();
            rBtnAddStudent = new RoundedButton();
            pnlProgram = new Panel();
            rTbProgram = new RoundedTextBox();
            listProgram = new ListBox();
            lblProgram = new Label();
            listDept = new ListBox();
            pnlDept = new Panel();
            rTbDepartment = new RoundedTextBox();
            lblDepartment = new Label();
            cmbYear = new ComboBox();
            lblYear = new Label();
            rTbStudentID = new RoundedTextBox();
            lblStudentID = new Label();
            rTbStudentName = new RoundedTextBox();
            lblStudentName = new Label();
            pnlSearchSort = new Panel();
            dgvStudents = new DataGridView();
            pnlHeaderInstructor.SuspendLayout();
            cPnlAddStudent.SuspendLayout();
            pnlProgram.SuspendLayout();
            pnlDept.SuspendLayout();
            pnlSearchSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderInstructor
            // 
            pnlHeaderInstructor.BackColor = Color.FromArgb(22, 33, 62);
            pnlHeaderInstructor.Controls.Add(lblStudentheader);
            pnlHeaderInstructor.Controls.Add(lblStudentManagement);
            pnlHeaderInstructor.Dock = DockStyle.Top;
            pnlHeaderInstructor.Location = new Point(0, 0);
            pnlHeaderInstructor.Name = "pnlHeaderInstructor";
            pnlHeaderInstructor.Size = new Size(1540, 106);
            pnlHeaderInstructor.TabIndex = 1;
            // 
            // lblStudentheader
            // 
            lblStudentheader.Anchor = AnchorStyles.Left;
            lblStudentheader.Font = new Font("Bahnschrift Light", 10F);
            lblStudentheader.ForeColor = Color.White;
            lblStudentheader.Location = new Point(25, 68);
            lblStudentheader.Name = "lblStudentheader";
            lblStudentheader.Size = new Size(319, 23);
            lblStudentheader.TabIndex = 2;
            lblStudentheader.Text = "Add, search, sort, and manage student records";
            lblStudentheader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentManagement
            // 
            lblStudentManagement.Anchor = AnchorStyles.Left;
            lblStudentManagement.AutoSize = true;
            lblStudentManagement.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            lblStudentManagement.ForeColor = Color.White;
            lblStudentManagement.Location = new Point(25, 36);
            lblStudentManagement.Name = "lblStudentManagement";
            lblStudentManagement.Size = new Size(293, 32);
            lblStudentManagement.TabIndex = 0;
            lblStudentManagement.Text = "Student Management";
            // 
            // rTbSearchStudents
            // 
            rTbSearchStudents.BackColor = Color.Transparent;
            rTbSearchStudents.BorderColor = Color.FromArgb(233, 69, 96);
            rTbSearchStudents.BorderRadius = 5;
            rTbSearchStudents.FillColor = Color.FromArgb(22, 33, 62);
            rTbSearchStudents.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbSearchStudents.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbSearchStudents.ForeColor = Color.White;
            rTbSearchStudents.Location = new Point(13, 30);
            rTbSearchStudents.Name = "rTbSearchStudents";
            rTbSearchStudents.Padding = new Padding(2);
            rTbSearchStudents.PlaceholderText = "Search by Name, ID, Program, Year Level ";
            rTbSearchStudents.Size = new Size(375, 40);
            rTbSearchStudents.TabIndex = 17;
            // 
            // rBtnSearch
            // 
            rBtnSearch.BackColor = Color.FromArgb(233, 69, 96);
            rBtnSearch.BorderColor = Color.White;
            rBtnSearch.BorderRadius = 5;
            rBtnSearch.FlatAppearance.BorderSize = 0;
            rBtnSearch.FlatStyle = FlatStyle.Flat;
            rBtnSearch.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSearch.ForeColor = Color.White;
            rBtnSearch.HoverColor = Color.Empty;
            rBtnSearch.Location = new Point(394, 30);
            rBtnSearch.Name = "rBtnSearch";
            rBtnSearch.PressedColor = Color.Empty;
            rBtnSearch.Size = new Size(93, 40);
            rBtnSearch.TabIndex = 18;
            rBtnSearch.Text = "Search";
            rBtnSearch.UseVisualStyleBackColor = false;
            // 
            // rBtnRefresh
            // 
            rBtnRefresh.BackColor = Color.DimGray;
            rBtnRefresh.BorderColor = Color.White;
            rBtnRefresh.BorderRadius = 5;
            rBtnRefresh.FlatAppearance.BorderSize = 0;
            rBtnRefresh.FlatStyle = FlatStyle.Flat;
            rBtnRefresh.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnRefresh.ForeColor = Color.White;
            rBtnRefresh.HoverColor = Color.Empty;
            rBtnRefresh.Location = new Point(493, 30);
            rBtnRefresh.Name = "rBtnRefresh";
            rBtnRefresh.PressedColor = Color.Empty;
            rBtnRefresh.Size = new Size(93, 40);
            rBtnRefresh.TabIndex = 19;
            rBtnRefresh.Text = "Refresh";
            rBtnRefresh.UseVisualStyleBackColor = false;
            rBtnRefresh.Click += rBtnRefresh_Click;
            // 
            // lblSlash
            // 
            lblSlash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSlash.Font = new Font("Segoe UI", 15F);
            lblSlash.ForeColor = Color.DarkGray;
            lblSlash.Location = new Point(592, 34);
            lblSlash.Name = "lblSlash";
            lblSlash.Size = new Size(15, 25);
            lblSlash.TabIndex = 20;
            lblSlash.Text = "|";
            lblSlash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Font = new Font("Bahnschrift", 10F);
            lblSort.ForeColor = Color.White;
            lblSort.Location = new Point(609, 39);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(57, 17);
            lblSort.TabIndex = 3;
            lblSort.Text = "Sort by:";
            lblSort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rBtnSortName
            // 
            rBtnSortName.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortName.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortName.BorderRadius = 5;
            rBtnSortName.BorderSize = 2;
            rBtnSortName.FlatAppearance.BorderSize = 0;
            rBtnSortName.FlatStyle = FlatStyle.Flat;
            rBtnSortName.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortName.ForeColor = Color.White;
            rBtnSortName.HoverColor = Color.Empty;
            rBtnSortName.Location = new Point(695, 30);
            rBtnSortName.Name = "rBtnSortName";
            rBtnSortName.PressedColor = Color.Empty;
            rBtnSortName.Size = new Size(74, 40);
            rBtnSortName.TabIndex = 21;
            rBtnSortName.Text = "Name";
            rBtnSortName.UseVisualStyleBackColor = false;
            rBtnSortName.Click += rBtnName_Click;
            // 
            // rBtnSortID
            // 
            rBtnSortID.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortID.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortID.BorderRadius = 5;
            rBtnSortID.BorderSize = 2;
            rBtnSortID.FlatAppearance.BorderSize = 0;
            rBtnSortID.FlatStyle = FlatStyle.Flat;
            rBtnSortID.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortID.ForeColor = Color.White;
            rBtnSortID.HoverColor = Color.Empty;
            rBtnSortID.Location = new Point(793, 30);
            rBtnSortID.Name = "rBtnSortID";
            rBtnSortID.PressedColor = Color.Empty;
            rBtnSortID.Size = new Size(74, 40);
            rBtnSortID.TabIndex = 22;
            rBtnSortID.Text = "ID No.";
            rBtnSortID.UseVisualStyleBackColor = false;
            rBtnSortID.Click += rBtnSortID_Click;
            // 
            // rBtnSortYear
            // 
            rBtnSortYear.BackColor = Color.FromArgb(22, 33, 62);
            rBtnSortYear.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnSortYear.BorderRadius = 5;
            rBtnSortYear.BorderSize = 2;
            rBtnSortYear.FlatAppearance.BorderSize = 0;
            rBtnSortYear.FlatStyle = FlatStyle.Flat;
            rBtnSortYear.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSortYear.ForeColor = Color.White;
            rBtnSortYear.HoverColor = Color.Empty;
            rBtnSortYear.Location = new Point(891, 30);
            rBtnSortYear.Name = "rBtnSortYear";
            rBtnSortYear.PressedColor = Color.Empty;
            rBtnSortYear.Size = new Size(74, 40);
            rBtnSortYear.TabIndex = 23;
            rBtnSortYear.Text = "Year";
            rBtnSortYear.UseVisualStyleBackColor = false;
            rBtnSortYear.Click += rBtnSortYear_Click;
            // 
            // cPnlAddStudent
            // 
            cPnlAddStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cPnlAddStudent.BackColor = Color.FromArgb(22, 33, 62);
            cPnlAddStudent.BorderColor = Color.FromArgb(22, 33, 62);
            cPnlAddStudent.Controls.Add(lblAddNewStudent);
            cPnlAddStudent.Controls.Add(rBtnDelete);
            cPnlAddStudent.Controls.Add(rBtnUpdate);
            cPnlAddStudent.Controls.Add(rBtnCancel);
            cPnlAddStudent.Controls.Add(rBtnAddStudent);
            cPnlAddStudent.Controls.Add(pnlProgram);
            cPnlAddStudent.Controls.Add(listProgram);
            cPnlAddStudent.Controls.Add(lblProgram);
            cPnlAddStudent.Controls.Add(listDept);
            cPnlAddStudent.Controls.Add(pnlDept);
            cPnlAddStudent.Controls.Add(lblDepartment);
            cPnlAddStudent.Controls.Add(cmbYear);
            cPnlAddStudent.Controls.Add(lblYear);
            cPnlAddStudent.Controls.Add(rTbStudentID);
            cPnlAddStudent.Controls.Add(lblStudentID);
            cPnlAddStudent.Controls.Add(rTbStudentName);
            cPnlAddStudent.Controls.Add(lblStudentName);
            cPnlAddStudent.CornerRadius = 5;
            cPnlAddStudent.Location = new Point(12, 200);
            cPnlAddStudent.Name = "cPnlAddStudent";
            cPnlAddStudent.Size = new Size(1493, 281);
            cPnlAddStudent.TabIndex = 24;
            // 
            // lblAddNewStudent
            // 
            lblAddNewStudent.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblAddNewStudent.ForeColor = Color.FromArgb(233, 69, 96);
            lblAddNewStudent.Location = new Point(13, 11);
            lblAddNewStudent.Name = "lblAddNewStudent";
            lblAddNewStudent.Size = new Size(230, 30);
            lblAddNewStudent.TabIndex = 2;
            lblAddNewStudent.Text = "+ Add New Student";
            lblAddNewStudent.TextAlign = ContentAlignment.MiddleLeft;
            lblAddNewStudent.UseCompatibleTextRendering = true;
            // 
            // rBtnDelete
            // 
            rBtnDelete.BackColor = Color.Firebrick;
            rBtnDelete.BorderColor = Color.White;
            rBtnDelete.BorderRadius = 5;
            rBtnDelete.FlatAppearance.BorderSize = 0;
            rBtnDelete.FlatStyle = FlatStyle.Flat;
            rBtnDelete.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnDelete.ForeColor = Color.White;
            rBtnDelete.HoverColor = Color.Empty;
            rBtnDelete.Location = new Point(283, 221);
            rBtnDelete.Name = "rBtnDelete";
            rBtnDelete.PressedColor = Color.Empty;
            rBtnDelete.Size = new Size(135, 40);
            rBtnDelete.TabIndex = 36;
            rBtnDelete.Text = "Delete Student";
            rBtnDelete.UseVisualStyleBackColor = false;
            rBtnDelete.Click += rBtnDelete_Click;
            // 
            // rBtnUpdate
            // 
            rBtnUpdate.BackColor = Color.DarkOrange;
            rBtnUpdate.BorderColor = Color.White;
            rBtnUpdate.BorderRadius = 5;
            rBtnUpdate.FlatAppearance.BorderSize = 0;
            rBtnUpdate.FlatStyle = FlatStyle.Flat;
            rBtnUpdate.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnUpdate.ForeColor = Color.White;
            rBtnUpdate.HoverColor = Color.Empty;
            rBtnUpdate.Location = new Point(138, 221);
            rBtnUpdate.Name = "rBtnUpdate";
            rBtnUpdate.PressedColor = Color.Empty;
            rBtnUpdate.Size = new Size(139, 40);
            rBtnUpdate.TabIndex = 35;
            rBtnUpdate.Text = "Update Student";
            rBtnUpdate.UseVisualStyleBackColor = false;
            rBtnUpdate.Click += rBtnUpdate_Click;
            // 
            // rBtnCancel
            // 
            rBtnCancel.BackColor = Color.DimGray;
            rBtnCancel.BorderColor = Color.White;
            rBtnCancel.BorderRadius = 5;
            rBtnCancel.FlatAppearance.BorderSize = 0;
            rBtnCancel.FlatStyle = FlatStyle.Flat;
            rBtnCancel.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnCancel.ForeColor = Color.White;
            rBtnCancel.HoverColor = Color.Empty;
            rBtnCancel.Location = new Point(427, 221);
            rBtnCancel.Name = "rBtnCancel";
            rBtnCancel.PressedColor = Color.Empty;
            rBtnCancel.Size = new Size(82, 40);
            rBtnCancel.TabIndex = 24;
            rBtnCancel.Text = "Cancel";
            rBtnCancel.UseVisualStyleBackColor = false;
            // 
            // rBtnAddStudent
            // 
            rBtnAddStudent.BackColor = Color.LimeGreen;
            rBtnAddStudent.BorderColor = Color.White;
            rBtnAddStudent.BorderRadius = 5;
            rBtnAddStudent.FlatAppearance.BorderSize = 0;
            rBtnAddStudent.FlatStyle = FlatStyle.Flat;
            rBtnAddStudent.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnAddStudent.ForeColor = Color.White;
            rBtnAddStudent.HoverColor = Color.Empty;
            rBtnAddStudent.Location = new Point(10, 221);
            rBtnAddStudent.Name = "rBtnAddStudent";
            rBtnAddStudent.PressedColor = Color.Empty;
            rBtnAddStudent.Size = new Size(122, 40);
            rBtnAddStudent.TabIndex = 24;
            rBtnAddStudent.Text = "Add Student";
            rBtnAddStudent.UseVisualStyleBackColor = false;
            rBtnAddStudent.Click += rBtnAddStudent_Click;
            // 
            // pnlProgram
            // 
            pnlProgram.Controls.Add(rTbProgram);
            pnlProgram.Location = new Point(1141, 91);
            pnlProgram.Name = "pnlProgram";
            pnlProgram.Size = new Size(340, 47);
            pnlProgram.TabIndex = 32;
            // 
            // rTbProgram
            // 
            rTbProgram.BackColor = Color.Transparent;
            rTbProgram.BorderColor = Color.FromArgb(233, 69, 96);
            rTbProgram.BorderRadius = 5;
            rTbProgram.FillColor = Color.FromArgb(22, 33, 62);
            rTbProgram.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbProgram.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbProgram.ForeColor = Color.White;
            rTbProgram.Location = new Point(0, 3);
            rTbProgram.Name = "rTbProgram";
            rTbProgram.Padding = new Padding(2);
            rTbProgram.PlaceholderText = "Enter or Select Program";
            rTbProgram.Size = new Size(340, 35);
            rTbProgram.TabIndex = 27;
            rTbProgram.TextChanged += rTbProgram_TextChanged;
            // 
            // listProgram
            // 
            listProgram.BackColor = Color.FromArgb(22, 33, 62);
            listProgram.BorderStyle = BorderStyle.None;
            listProgram.Font = new Font("Bahnschrift Light", 12F);
            listProgram.ForeColor = Color.White;
            listProgram.FormattingEnabled = true;
            listProgram.Location = new Point(1141, 144);
            listProgram.Name = "listProgram";
            listProgram.Size = new Size(340, 19);
            listProgram.TabIndex = 34;
            // 
            // lblProgram
            // 
            lblProgram.Font = new Font("Bahnschrift Light", 10F);
            lblProgram.ForeColor = Color.White;
            lblProgram.Location = new Point(1141, 65);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(171, 23);
            lblProgram.TabIndex = 33;
            lblProgram.Text = "Program:";
            lblProgram.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listDept
            // 
            listDept.BackColor = Color.FromArgb(22, 33, 62);
            listDept.BorderStyle = BorderStyle.None;
            listDept.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listDept.ForeColor = Color.White;
            listDept.FormattingEnabled = true;
            listDept.Items.AddRange(new object[] { "College of Accounting Education (CAE)", "", "", "College of Architecture and Fine Arts Education (CAFAE)", "", "", "College of Arts and Sciences Education (CASE)", "", "", "College of Business Administration Education (CBAE)", "", "", "College of Computing Education (CCE)", "", "", "College of Criminal Justice Education (CCJE)", "", "", "College of Engineering Education (CEE)", "", "", "College of Health Sciences Education (CHSE)", "", "", "College of Hospitality Education (CHE)", "", "", "College of Legal Education (CLE)", "", "", "College of Teacher Education (CTE)" });
            listDept.Location = new Point(686, 144);
            listDept.Name = "listDept";
            listDept.Size = new Size(340, 19);
            listDept.TabIndex = 32;
            // 
            // pnlDept
            // 
            pnlDept.Controls.Add(rTbDepartment);
            pnlDept.Location = new Point(686, 91);
            pnlDept.Name = "pnlDept";
            pnlDept.Size = new Size(340, 47);
            pnlDept.TabIndex = 31;
            // 
            // rTbDepartment
            // 
            rTbDepartment.BackColor = Color.Transparent;
            rTbDepartment.BorderColor = Color.FromArgb(233, 69, 96);
            rTbDepartment.BorderRadius = 5;
            rTbDepartment.FillColor = Color.FromArgb(22, 33, 62);
            rTbDepartment.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbDepartment.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbDepartment.ForeColor = Color.White;
            rTbDepartment.Location = new Point(0, 3);
            rTbDepartment.Name = "rTbDepartment";
            rTbDepartment.Padding = new Padding(2);
            rTbDepartment.PlaceholderText = "Enter or Select Department";
            rTbDepartment.Size = new Size(340, 35);
            rTbDepartment.TabIndex = 26;
            rTbDepartment.TextChanged += rTbDepartment_TextChanged;
            // 
            // lblDepartment
            // 
            lblDepartment.Font = new Font("Bahnschrift Light", 10F);
            lblDepartment.ForeColor = Color.White;
            lblDepartment.Location = new Point(686, 65);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(171, 23);
            lblDepartment.TabIndex = 30;
            lblDepartment.Text = "Department:";
            lblDepartment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbYear
            // 
            cmbYear.BackColor = Color.FromArgb(22, 33, 62);
            cmbYear.DrawMode = DrawMode.OwnerDrawFixed;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.Font = new Font("Bahnschrift Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbYear.ForeColor = Color.White;
            cmbYear.FormattingEnabled = true;
            cmbYear.ItemHeight = 22;
            cmbYear.Items.AddRange(new object[] { "First", "Second", "Third", "Fourth", "Fifth" });
            cmbYear.Location = new Point(531, 91);
            cmbYear.MinimumSize = new Size(130, 0);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(130, 28);
            cmbYear.TabIndex = 29;
            // 
            // lblYear
            // 
            lblYear.Font = new Font("Bahnschrift Light", 10F);
            lblYear.ForeColor = Color.White;
            lblYear.Location = new Point(531, 65);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(135, 23);
            lblYear.TabIndex = 28;
            lblYear.Text = "Year Level:";
            lblYear.TextAlign = ContentAlignment.MiddleLeft;
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
            rTbStudentID.PlaceholderText = "e.g. 123456";
            rTbStudentID.Size = new Size(135, 40);
            rTbStudentID.TabIndex = 27;
            // 
            // lblStudentID
            // 
            lblStudentID.Font = new Font("Bahnschrift Light", 10F);
            lblStudentID.ForeColor = Color.White;
            lblStudentID.Location = new Point(374, 65);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(171, 23);
            lblStudentID.TabIndex = 26;
            lblStudentID.Text = "Student ID:";
            lblStudentID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rTbStudentName
            // 
            rTbStudentName.BackColor = Color.Transparent;
            rTbStudentName.BorderColor = Color.FromArgb(233, 69, 96);
            rTbStudentName.BorderRadius = 5;
            rTbStudentName.FillColor = Color.FromArgb(22, 33, 62);
            rTbStudentName.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbStudentName.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbStudentName.ForeColor = Color.White;
            rTbStudentName.Location = new Point(10, 91);
            rTbStudentName.Name = "rTbStudentName";
            rTbStudentName.Padding = new Padding(2);
            rTbStudentName.PlaceholderText = "FIRST NAME, MIDDLE INITIAL, SURNAME";
            rTbStudentName.Size = new Size(340, 40);
            rTbStudentName.TabIndex = 25;
            // 
            // lblStudentName
            // 
            lblStudentName.Font = new Font("Bahnschrift Light", 10F);
            lblStudentName.ForeColor = Color.White;
            lblStudentName.Location = new Point(10, 65);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(171, 23);
            lblStudentName.TabIndex = 3;
            lblStudentName.Text = "Student Name:";
            lblStudentName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSearchSort
            // 
            pnlSearchSort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearchSort.Controls.Add(rTbSearchStudents);
            pnlSearchSort.Controls.Add(lblSlash);
            pnlSearchSort.Controls.Add(lblSort);
            pnlSearchSort.Controls.Add(rBtnSortYear);
            pnlSearchSort.Controls.Add(rBtnSearch);
            pnlSearchSort.Controls.Add(rBtnSortID);
            pnlSearchSort.Controls.Add(rBtnRefresh);
            pnlSearchSort.Controls.Add(rBtnSortName);
            pnlSearchSort.Location = new Point(12, 112);
            pnlSearchSort.Name = "pnlSearchSort";
            pnlSearchSort.Size = new Size(1493, 82);
            pnlSearchSort.TabIndex = 25;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 490);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1493, 340);
            dgvStudents.TabIndex = 26;
            // 
            // Students
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(1540, 845);
            Controls.Add(dgvStudents);
            Controls.Add(pnlSearchSort);
            Controls.Add(pnlHeaderInstructor);
            Controls.Add(cPnlAddStudent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Students";
            Text = "Students";
            WindowState = FormWindowState.Maximized;
            pnlHeaderInstructor.ResumeLayout(false);
            pnlHeaderInstructor.PerformLayout();
            cPnlAddStudent.ResumeLayout(false);
            pnlProgram.ResumeLayout(false);
            pnlDept.ResumeLayout(false);
            pnlSearchSort.ResumeLayout(false);
            pnlSearchSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderInstructor;
        private Label lblStudentheader;
        private Label lblStudentManagement;
        private RoundedTextBox rTbSearchStudents;
        private RoundedButton rBtnSearch;
        private RoundedButton rBtnRefresh;
        private Label lblSlash;
        private Label lblSort;
        private RoundedButton rBtnSortName;
        private RoundedButton rBtnSortID;
        private RoundedButton rBtnSortYear;
        private CustomPanel cPnlAddStudent;
        private Label lblAddNewStudent;
        private Label lblStudentName;
        private RoundedTextBox rTbStudentName;
        private RoundedTextBox rTbStudentID;
        private Label lblStudentID;
        private Label lblDepartment;
        private ComboBox cmbYear;
        private Label lblYear;
        private Panel pnlDept;
        private RoundedTextBox rTbDepartment;
        private ListBox listDept;
        private Panel pnlSearchSort;
        private RoundedTextBox rTbProgram;
        private Label lblProgram;
        private ListBox listProgram;
        private Panel pnlProgram;
        private RoundedButton rBtnAddStudent;
        private RoundedButton rBtnCancel;
        private DataGridView dgvStudents;
        private RoundedButton rBtnUpdate;
        private RoundedButton rBtnDelete;
    }
}