namespace SMART
{
    partial class AdminStudents
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
            studentFieldsLayout = new TableLayoutPanel();
            studentFieldsLayout.BackColor = Color.Transparent;
            studentFieldsLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            lblAddNewStudent = new Label();
            lblAddNewStudent.BackColor = Color.Transparent;
            pnlStudentIdentity = new Panel();
            pnlStudentIdentity.BackColor = Color.Transparent;
            rTbStudentName = new RoundedTextBox();
            lblStudentName = new Label();
            lblStudentName.BackColor = Color.Transparent;
            pnlStudentNumber = new Panel();
            pnlStudentNumber.BackColor = Color.Transparent;
            rTbStudentID = new RoundedTextBox();
            lblStudentID = new Label();
            lblStudentID.BackColor = Color.Transparent;
            pnlStudentYear = new Panel();
            pnlStudentYear.BackColor = Color.Transparent;
            cmbYear = new ComboBox();
            lblYear = new Label();
            lblYear.BackColor = Color.Transparent;
            pnlProgram = new Panel();
            pnlProgram.BackColor = Color.Transparent;
            rTbProgram = new RoundedTextBox();
            lblProgram = new Label();
            lblProgram.BackColor = Color.Transparent;
            pnlDept = new Panel();
            pnlDept.BackColor = Color.Transparent;
            rTbDepartment = new RoundedTextBox();
            lblDepartment = new Label();
            lblDepartment.BackColor = Color.Transparent;
            studentActions = new FlowLayoutPanel();
            studentActions.BackColor = Color.Transparent;
            rBtnAddStudent = new RoundedButton();
            rBtnUpdate = new RoundedButton();
            rBtnDelete = new RoundedButton();
            rBtnCancel = new RoundedButton();
            studentStatusActions = new FlowLayoutPanel();
            studentStatusActions.BackColor = Color.Transparent;
            lblStudentStatusActions = new Label();
            lblStudentStatusActions.BackColor = Color.Transparent;
            rBtnSetActive = new RoundedButton();
            rBtnSetInactive = new RoundedButton();
            rBtnSetDropped = new RoundedButton();
            pnlHeaderInstructor = new Panel();
            lblStudentheader = new Label();
            lblStudentheader.BackColor = Color.Transparent;
            lblStudentManagement = new Label();
            lblStudentManagement.BackColor = Color.Transparent;
            rTbSearchStudents = new RoundedTextBox();
            rBtnSearch = new RoundedButton();
            rBtnRefresh = new RoundedButton();
            lblSlash = new Label();
            lblSlash.BackColor = Color.Transparent;
            lblSort = new Label();
            lblSort.BackColor = Color.Transparent;
            rBtnSortName = new RoundedButton();
            rBtnSortID = new RoundedButton();
            rBtnSortYear = new RoundedButton();
            cPnlAddStudent = new CustomPanel();
            listProgram = new ListBox();
            listDept = new ListBox();
            pnlSearchSort = new Panel();
            pnlSearchSort.BackColor = Color.FromArgb(210, 22, 33, 62);
            dgvStudents = new DataGridView();
            studentFieldsLayout.SuspendLayout();
            pnlStudentIdentity.SuspendLayout();
            pnlStudentNumber.SuspendLayout();
            pnlStudentYear.SuspendLayout();
            pnlProgram.SuspendLayout();
            pnlDept.SuspendLayout();
            studentActions.SuspendLayout();
            studentStatusActions.SuspendLayout();
            pnlHeaderInstructor.SuspendLayout();
            cPnlAddStudent.SuspendLayout();
            pnlSearchSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // studentFieldsLayout
            // 
            studentFieldsLayout.ColumnCount = 12;
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            studentFieldsLayout.Controls.Add(lblAddNewStudent, 0, 0);
            studentFieldsLayout.Controls.Add(pnlStudentIdentity, 0, 1);
            studentFieldsLayout.Controls.Add(pnlStudentNumber, 6, 1);
            studentFieldsLayout.Controls.Add(pnlStudentYear, 9, 1);
            studentFieldsLayout.Controls.Add(pnlProgram, 0, 2);
            studentFieldsLayout.Controls.Add(pnlDept, 6, 2);
            studentFieldsLayout.Controls.Add(studentActions, 0, 3);
            studentFieldsLayout.Controls.Add(studentStatusActions, 0, 4);
            studentFieldsLayout.Dock = DockStyle.Fill;
            studentFieldsLayout.Location = new Point(0, 0);
            studentFieldsLayout.Name = "studentFieldsLayout";
            studentFieldsLayout.Padding = new Padding(24);
            studentFieldsLayout.RowCount = 5;
            studentFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            studentFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            studentFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            studentFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            studentFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            studentFieldsLayout.Size = new Size(1493, 388);
            studentFieldsLayout.TabIndex = 0;
            // 
            // lblAddNewStudent
            // 
            studentFieldsLayout.SetColumnSpan(lblAddNewStudent, 12);
            lblAddNewStudent.Dock = DockStyle.Fill;
            lblAddNewStudent.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblAddNewStudent.ForeColor = Color.FromArgb(233, 69, 96);
            lblAddNewStudent.Location = new Point(24, 24);
            lblAddNewStudent.Margin = new Padding(0);
            lblAddNewStudent.Name = "lblAddNewStudent";
            lblAddNewStudent.Size = new Size(1445, 40);
            lblAddNewStudent.TabIndex = 2;
            lblAddNewStudent.Text = "+ Add New Student";
            lblAddNewStudent.TextAlign = ContentAlignment.MiddleLeft;
            lblAddNewStudent.UseCompatibleTextRendering = true;
            // 
            // pnlStudentIdentity
            // 
            studentFieldsLayout.SetColumnSpan(pnlStudentIdentity, 6);
            pnlStudentIdentity.Controls.Add(rTbStudentName);
            pnlStudentIdentity.Controls.Add(lblStudentName);
            pnlStudentIdentity.Dock = DockStyle.Fill;
            pnlStudentIdentity.Location = new Point(24, 72);
            pnlStudentIdentity.Margin = new Padding(0, 8, 20, 8);
            pnlStudentIdentity.Name = "pnlStudentIdentity";
            pnlStudentIdentity.Size = new Size(700, 66);
            pnlStudentIdentity.TabIndex = 3;
            // 
            // rTbStudentName
            // 
            rTbStudentName.BackColor = Color.Transparent;
            rTbStudentName.BorderColor = Color.FromArgb(233, 69, 96);
            rTbStudentName.BorderRadius = 5;
            rTbStudentName.Dock = DockStyle.Top;
            rTbStudentName.FillColor = Color.FromArgb(26, 26, 46);
            rTbStudentName.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbStudentName.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbStudentName.ForeColor = Color.White;
            rTbStudentName.Location = new Point(0, 26);
            rTbStudentName.Name = "rTbStudentName";
            rTbStudentName.Padding = new Padding(2);
            rTbStudentName.PlaceholderText = "FIRST NAME, MIDDLE INITIAL, SURNAME";
            rTbStudentName.Size = new Size(700, 40);
            rTbStudentName.TabIndex = 25;
            // 
            // lblStudentName
            // 
            lblStudentName.Dock = DockStyle.Top;
            lblStudentName.Font = new Font("Bahnschrift Light", 10F);
            lblStudentName.ForeColor = Color.White;
            lblStudentName.Location = new Point(0, 0);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(700, 26);
            lblStudentName.TabIndex = 3;
            lblStudentName.Text = "Student Name:";
            // 
            // pnlStudentNumber
            // 
            studentFieldsLayout.SetColumnSpan(pnlStudentNumber, 3);
            pnlStudentNumber.Controls.Add(rTbStudentID);
            pnlStudentNumber.Controls.Add(lblStudentID);
            pnlStudentNumber.Dock = DockStyle.Fill;
            pnlStudentNumber.Location = new Point(744, 72);
            pnlStudentNumber.Margin = new Padding(0, 8, 20, 8);
            pnlStudentNumber.Name = "pnlStudentNumber";
            pnlStudentNumber.Size = new Size(340, 66);
            pnlStudentNumber.TabIndex = 4;
            // 
            // rTbStudentID
            // 
            rTbStudentID.BackColor = Color.Transparent;
            rTbStudentID.BorderColor = Color.FromArgb(233, 69, 96);
            rTbStudentID.BorderRadius = 5;
            rTbStudentID.Dock = DockStyle.Top;
            rTbStudentID.FillColor = Color.FromArgb(26, 26, 46);
            rTbStudentID.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbStudentID.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbStudentID.ForeColor = Color.White;
            rTbStudentID.Location = new Point(0, 26);
            rTbStudentID.Name = "rTbStudentID";
            rTbStudentID.Padding = new Padding(2);
            rTbStudentID.PlaceholderText = "e.g. 123456";
            rTbStudentID.Size = new Size(340, 40);
            rTbStudentID.TabIndex = 27;
            // 
            // lblStudentID
            // 
            lblStudentID.Dock = DockStyle.Top;
            lblStudentID.Font = new Font("Bahnschrift Light", 10F);
            lblStudentID.ForeColor = Color.White;
            lblStudentID.Location = new Point(0, 0);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(340, 26);
            lblStudentID.TabIndex = 26;
            lblStudentID.Text = "Student ID:";
            // 
            // pnlStudentYear
            // 
            studentFieldsLayout.SetColumnSpan(pnlStudentYear, 3);
            pnlStudentYear.Controls.Add(cmbYear);
            pnlStudentYear.Controls.Add(lblYear);
            pnlStudentYear.Dock = DockStyle.Fill;
            pnlStudentYear.Location = new Point(1104, 72);
            pnlStudentYear.Margin = new Padding(0, 8, 20, 8);
            pnlStudentYear.Name = "pnlStudentYear";
            pnlStudentYear.Size = new Size(345, 66);
            pnlStudentYear.TabIndex = 5;
            // 
            // cmbYear
            // 
            cmbYear.BackColor = Color.FromArgb(22, 33, 62);
            cmbYear.Dock = DockStyle.Top;
            cmbYear.DrawMode = DrawMode.OwnerDrawFixed;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.Font = new Font("Bahnschrift Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbYear.ForeColor = Color.White;
            cmbYear.FormattingEnabled = true;
            cmbYear.ItemHeight = 22;
            cmbYear.Items.AddRange(new object[] { "First", "Second", "Third", "Fourth", "Fifth" });
            cmbYear.Location = new Point(0, 26);
            cmbYear.MinimumSize = new Size(130, 0);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(345, 28);
            cmbYear.TabIndex = 29;
            // 
            // lblYear
            // 
            lblYear.Dock = DockStyle.Top;
            lblYear.Font = new Font("Bahnschrift Light", 10F);
            lblYear.ForeColor = Color.White;
            lblYear.Location = new Point(0, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(345, 26);
            lblYear.TabIndex = 28;
            lblYear.Text = "Year Level:";
            // 
            // pnlProgram
            // 
            studentFieldsLayout.SetColumnSpan(pnlProgram, 6);
            pnlProgram.Controls.Add(rTbProgram);
            pnlProgram.Controls.Add(lblProgram);
            pnlProgram.Dock = DockStyle.Fill;
            pnlProgram.Location = new Point(24, 154);
            pnlProgram.Margin = new Padding(0, 8, 20, 8);
            pnlProgram.Name = "pnlProgram";
            pnlProgram.Size = new Size(700, 74);
            pnlProgram.TabIndex = 32;
            // 
            // rTbProgram
            // 
            rTbProgram.BackColor = Color.Transparent;
            rTbProgram.BorderColor = Color.FromArgb(233, 69, 96);
            rTbProgram.BorderRadius = 5;
            rTbProgram.Dock = DockStyle.Top;
            rTbProgram.FillColor = Color.FromArgb(26, 26, 46);
            rTbProgram.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbProgram.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbProgram.ForeColor = Color.White;
            rTbProgram.Location = new Point(0, 26);
            rTbProgram.Name = "rTbProgram";
            rTbProgram.Padding = new Padding(2);
            rTbProgram.PlaceholderText = "Enter or Select Program";
            rTbProgram.Size = new Size(700, 40);
            rTbProgram.TabIndex = 27;
            rTbProgram.TextChanged += rTbProgram_TextChanged;
            // 
            // lblProgram
            // 
            lblProgram.Dock = DockStyle.Top;
            lblProgram.Font = new Font("Bahnschrift Light", 10F);
            lblProgram.ForeColor = Color.White;
            lblProgram.Location = new Point(0, 0);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(700, 26);
            lblProgram.TabIndex = 33;
            lblProgram.Text = "Program:";
            // 
            // pnlDept
            // 
            studentFieldsLayout.SetColumnSpan(pnlDept, 6);
            pnlDept.Controls.Add(rTbDepartment);
            pnlDept.Controls.Add(lblDepartment);
            pnlDept.Dock = DockStyle.Fill;
            pnlDept.Location = new Point(744, 154);
            pnlDept.Margin = new Padding(0, 8, 20, 8);
            pnlDept.Name = "pnlDept";
            pnlDept.Size = new Size(705, 74);
            pnlDept.TabIndex = 31;
            // 
            // rTbDepartment
            // 
            rTbDepartment.BackColor = Color.Transparent;
            rTbDepartment.BorderColor = Color.FromArgb(233, 69, 96);
            rTbDepartment.BorderRadius = 5;
            rTbDepartment.Dock = DockStyle.Top;
            rTbDepartment.FillColor = Color.FromArgb(26, 26, 46);
            rTbDepartment.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbDepartment.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbDepartment.ForeColor = Color.White;
            rTbDepartment.Location = new Point(0, 26);
            rTbDepartment.Name = "rTbDepartment";
            rTbDepartment.Padding = new Padding(2);
            rTbDepartment.PlaceholderText = "Enter or Select Department";
            rTbDepartment.Size = new Size(705, 40);
            rTbDepartment.TabIndex = 26;
            rTbDepartment.TextChanged += rTbDepartment_TextChanged;
            // 
            // lblDepartment
            // 
            lblDepartment.Dock = DockStyle.Top;
            lblDepartment.Font = new Font("Bahnschrift Light", 10F);
            lblDepartment.ForeColor = Color.White;
            lblDepartment.Location = new Point(0, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(705, 26);
            lblDepartment.TabIndex = 30;
            lblDepartment.Text = "Department:";
            // 
            // studentActions
            // 
            studentFieldsLayout.SetColumnSpan(studentActions, 12);
            studentActions.Controls.Add(rBtnAddStudent);
            studentActions.Controls.Add(rBtnUpdate);
            studentActions.Controls.Add(rBtnDelete);
            studentActions.Controls.Add(rBtnCancel);
            studentActions.Dock = DockStyle.Fill;
            studentActions.Location = new Point(24, 250);
            studentActions.Margin = new Padding(0, 14, 0, 0);
            studentActions.Name = "studentActions";
            studentActions.Size = new Size(1445, 50);
            studentActions.TabIndex = 33;
            // 
            // rBtnAddStudent
            // 
            rBtnAddStudent.BackColor = Color.FromArgb(233, 69, 96);
            rBtnAddStudent.BorderColor = Color.White;
            rBtnAddStudent.BorderRadius = 5;
            rBtnAddStudent.FlatAppearance.BorderSize = 0;
            rBtnAddStudent.FlatStyle = FlatStyle.Flat;
            rBtnAddStudent.Font = new Font("Bahnschrift", 11F);
            rBtnAddStudent.ForeColor = Color.White;
            rBtnAddStudent.HoverColor = Color.Empty;
            rBtnAddStudent.Location = new Point(0, 0);
            rBtnAddStudent.Margin = new Padding(0, 0, 12, 8);
            rBtnAddStudent.Name = "rBtnAddStudent";
            rBtnAddStudent.PressedColor = Color.Empty;
            rBtnAddStudent.Size = new Size(160, 40);
            rBtnAddStudent.TabIndex = 24;
            rBtnAddStudent.Text = "Add Student";
            rBtnAddStudent.UseVisualStyleBackColor = false;
            rBtnAddStudent.Click += rBtnAddStudent_Click;
            // 
            // rBtnUpdate
            // 
            rBtnUpdate.BackColor = Color.FromArgb(48, 63, 93);
            rBtnUpdate.BorderColor = Color.White;
            rBtnUpdate.BorderRadius = 5;
            rBtnUpdate.FlatAppearance.BorderSize = 0;
            rBtnUpdate.FlatStyle = FlatStyle.Flat;
            rBtnUpdate.Font = new Font("Bahnschrift", 11F);
            rBtnUpdate.ForeColor = Color.White;
            rBtnUpdate.HoverColor = Color.Empty;
            rBtnUpdate.Location = new Point(172, 0);
            rBtnUpdate.Margin = new Padding(0, 0, 12, 8);
            rBtnUpdate.Name = "rBtnUpdate";
            rBtnUpdate.PressedColor = Color.Empty;
            rBtnUpdate.Size = new Size(120, 40);
            rBtnUpdate.TabIndex = 35;
            rBtnUpdate.Text = "Update";
            rBtnUpdate.UseVisualStyleBackColor = false;
            rBtnUpdate.Click += rBtnUpdate_Click;
            // 
            // rBtnDelete
            // 
            rBtnDelete.BackColor = Color.FromArgb(92, 39, 54);
            rBtnDelete.BorderColor = Color.White;
            rBtnDelete.BorderRadius = 5;
            rBtnDelete.FlatAppearance.BorderSize = 0;
            rBtnDelete.FlatStyle = FlatStyle.Flat;
            rBtnDelete.Font = new Font("Bahnschrift", 11F);
            rBtnDelete.ForeColor = Color.White;
            rBtnDelete.HoverColor = Color.Empty;
            rBtnDelete.Location = new Point(304, 0);
            rBtnDelete.Margin = new Padding(0, 0, 12, 8);
            rBtnDelete.Name = "rBtnDelete";
            rBtnDelete.PressedColor = Color.Empty;
            rBtnDelete.Size = new Size(120, 40);
            rBtnDelete.TabIndex = 36;
            rBtnDelete.Text = "Delete";
            rBtnDelete.UseVisualStyleBackColor = false;
            // 
            // rBtnCancel
            // 
            rBtnCancel.BackColor = Color.FromArgb(48, 63, 93);
            rBtnCancel.BorderColor = Color.White;
            rBtnCancel.BorderRadius = 5;
            rBtnCancel.FlatAppearance.BorderSize = 0;
            rBtnCancel.FlatStyle = FlatStyle.Flat;
            rBtnCancel.Font = new Font("Bahnschrift", 11F);
            rBtnCancel.ForeColor = Color.White;
            rBtnCancel.HoverColor = Color.Empty;
            rBtnCancel.Location = new Point(436, 0);
            rBtnCancel.Margin = new Padding(0, 0, 12, 8);
            rBtnCancel.Name = "rBtnCancel";
            rBtnCancel.PressedColor = Color.Empty;
            rBtnCancel.Size = new Size(120, 40);
            rBtnCancel.TabIndex = 24;
            rBtnCancel.Text = "Cancel";
            rBtnCancel.UseVisualStyleBackColor = false;
            rBtnCancel.Click += rBtnCancel_Click;
            // 
            // studentStatusActions
            // 
            studentFieldsLayout.SetColumnSpan(studentStatusActions, 12);
            studentStatusActions.Controls.Add(lblStudentStatusActions);
            studentStatusActions.Controls.Add(rBtnSetActive);
            studentStatusActions.Controls.Add(rBtnSetInactive);
            studentStatusActions.Controls.Add(rBtnSetDropped);
            studentStatusActions.Dock = DockStyle.Fill;
            studentStatusActions.Location = new Point(24, 306);
            studentStatusActions.Margin = new Padding(0, 6, 0, 0);
            studentStatusActions.Name = "studentStatusActions";
            studentStatusActions.Size = new Size(1445, 58);
            studentStatusActions.TabIndex = 34;
            // 
            // lblStudentStatusActions
            // 
            lblStudentStatusActions.Font = new Font("Bahnschrift Light", 10F);
            lblStudentStatusActions.ForeColor = Color.White;
            lblStudentStatusActions.Location = new Point(0, 0);
            lblStudentStatusActions.Margin = new Padding(0, 0, 12, 8);
            lblStudentStatusActions.Name = "lblStudentStatusActions";
            lblStudentStatusActions.Size = new Size(130, 40);
            lblStudentStatusActions.TabIndex = 0;
            lblStudentStatusActions.Text = "Student Status:";
            lblStudentStatusActions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rBtnSetActive
            // 
            rBtnSetActive.BackColor = Color.FromArgb(37, 88, 65);
            rBtnSetActive.BorderColor = Color.White;
            rBtnSetActive.BorderRadius = 5;
            rBtnSetActive.FlatAppearance.BorderSize = 0;
            rBtnSetActive.FlatStyle = FlatStyle.Flat;
            rBtnSetActive.Font = new Font("Bahnschrift", 11F);
            rBtnSetActive.ForeColor = Color.White;
            rBtnSetActive.HoverColor = Color.Empty;
            rBtnSetActive.Location = new Point(142, 0);
            rBtnSetActive.Margin = new Padding(0, 0, 12, 8);
            rBtnSetActive.Name = "rBtnSetActive";
            rBtnSetActive.PressedColor = Color.Empty;
            rBtnSetActive.Size = new Size(130, 40);
            rBtnSetActive.TabIndex = 37;
            rBtnSetActive.Text = "Set Active";
            rBtnSetActive.UseVisualStyleBackColor = false;
            rBtnSetActive.Click += rBtnSetActive_Click;
            // 
            // rBtnSetInactive
            // 
            rBtnSetInactive.BackColor = Color.FromArgb(96, 70, 36);
            rBtnSetInactive.BorderColor = Color.White;
            rBtnSetInactive.BorderRadius = 5;
            rBtnSetInactive.FlatAppearance.BorderSize = 0;
            rBtnSetInactive.FlatStyle = FlatStyle.Flat;
            rBtnSetInactive.Font = new Font("Bahnschrift", 11F);
            rBtnSetInactive.ForeColor = Color.White;
            rBtnSetInactive.HoverColor = Color.Empty;
            rBtnSetInactive.Location = new Point(284, 0);
            rBtnSetInactive.Margin = new Padding(0, 0, 12, 8);
            rBtnSetInactive.Name = "rBtnSetInactive";
            rBtnSetInactive.PressedColor = Color.Empty;
            rBtnSetInactive.Size = new Size(130, 40);
            rBtnSetInactive.TabIndex = 38;
            rBtnSetInactive.Text = "Set Inactive";
            rBtnSetInactive.UseVisualStyleBackColor = false;
            rBtnSetInactive.Click += rBtnSetInactive_Click;
            // 
            // rBtnSetDropped
            // 
            rBtnSetDropped.BackColor = Color.FromArgb(92, 39, 54);
            rBtnSetDropped.BorderColor = Color.White;
            rBtnSetDropped.BorderRadius = 5;
            rBtnSetDropped.FlatAppearance.BorderSize = 0;
            rBtnSetDropped.FlatStyle = FlatStyle.Flat;
            rBtnSetDropped.Font = new Font("Bahnschrift", 11F);
            rBtnSetDropped.ForeColor = Color.White;
            rBtnSetDropped.HoverColor = Color.Empty;
            rBtnSetDropped.Location = new Point(426, 0);
            rBtnSetDropped.Margin = new Padding(0, 0, 12, 8);
            rBtnSetDropped.Name = "rBtnSetDropped";
            rBtnSetDropped.PressedColor = Color.Empty;
            rBtnSetDropped.Size = new Size(130, 40);
            rBtnSetDropped.TabIndex = 39;
            rBtnSetDropped.Text = "Set Dropped";
            rBtnSetDropped.UseVisualStyleBackColor = false;
            rBtnSetDropped.Click += rBtnSetDropped_Click;
            // 
            // pnlHeaderInstructor
            // 
            pnlHeaderInstructor.BackColor = Color.Transparent;
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
            lblStudentheader.Font = new Font("Bahnschrift Light", 10F);
            lblStudentheader.ForeColor = Color.White;
            lblStudentheader.AutoSize = false;
            lblStudentheader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStudentheader.Location = new Point(29, 76);
            lblStudentheader.Name = "lblStudentheader";
            lblStudentheader.Size = new Size(1486, 26);
            lblStudentheader.TabIndex = 2;
            lblStudentheader.Text = "Add, search, sort, and manage student records";
            lblStudentheader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentManagement
            // 
            lblStudentManagement.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            lblStudentManagement.ForeColor = Color.White;
            lblStudentManagement.AutoSize = false;
            lblStudentManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStudentManagement.Location = new Point(25, 22);
            lblStudentManagement.Name = "lblStudentManagement";
            lblStudentManagement.Size = new Size(1490, 46);
            lblStudentManagement.TabIndex = 0;
            lblStudentManagement.Text = "Student Management";
            // 
            // rTbSearchStudents
            // 
            rTbSearchStudents.BackColor = Color.Transparent;
            rTbSearchStudents.BorderColor = Color.FromArgb(233, 69, 96);
            rTbSearchStudents.BorderRadius = 5;
            rTbSearchStudents.FillColor = Color.FromArgb(26, 26, 46);
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
            rBtnSortID.Location = new Point(808, 30);
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
            rBtnSortYear.Location = new Point(921, 30);
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
            cPnlAddStudent.BackColor = Color.FromArgb(210, 22, 33, 62);
            cPnlAddStudent.BorderColor = Color.Transparent;
            cPnlAddStudent.BorderWidth = 0;
            cPnlAddStudent.Controls.Add(studentFieldsLayout);
            cPnlAddStudent.CornerRadius = 5;
            cPnlAddStudent.Location = new Point(12, 200);
            cPnlAddStudent.Name = "cPnlAddStudent";
            cPnlAddStudent.Size = new Size(1493, 388);
            cPnlAddStudent.TabIndex = 24;
            // 
            // listProgram
            // 
            listProgram.BackColor = Color.FromArgb(22, 33, 62);
            listProgram.BorderStyle = BorderStyle.None;
            listProgram.Font = new Font("Bahnschrift Light", 12F);
            listProgram.ForeColor = Color.White;
            listProgram.FormattingEnabled = true;
            listProgram.Location = new Point(695, 147);
            listProgram.Name = "listProgram";
            listProgram.Size = new Size(340, 19);
            listProgram.TabIndex = 34;
            listProgram.Visible = false;
            // 
            // listDept
            // 
            listDept.BackColor = Color.FromArgb(22, 33, 62);
            listDept.BorderStyle = BorderStyle.None;
            listDept.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listDept.ForeColor = Color.White;
            listDept.FormattingEnabled = true;
            listDept.Items.AddRange(new object[] { "College of Accounting Education (CAE)", "", "", "College of Architecture and Fine Arts Education (CAFAE)", "", "", "College of Arts and Sciences Education (CASE)", "", "", "College of Business Administration Education (CBAE)", "", "", "College of Computing Education (CCE)", "", "", "College of Criminal Justice Education (CCJE)", "", "", "College of Engineering Education (CEE)", "", "", "College of Health Sciences Education (CHSE)", "", "", "College of Hospitality Education (CHE)", "", "", "College of Legal Education (CLE)", "", "", "College of Teacher Education (CTE)" });
            listDept.Location = new Point(1099, 147);
            listDept.Name = "listDept";
            listDept.Size = new Size(340, 19);
            listDept.TabIndex = 32;
            listDept.Visible = false;
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
            dgvStudents.Location = new Point(12, 597);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1493, 233);
            dgvStudents.TabIndex = 26;
            // 
            // AdminStudents
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(1540, 845);
            Controls.Add(dgvStudents);
            Controls.Add(pnlSearchSort);
            Controls.Add(pnlHeaderInstructor);
            Controls.Add(cPnlAddStudent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminStudents";
            Text = "Students";
            WindowState = FormWindowState.Maximized;
            studentFieldsLayout.ResumeLayout(false);
            pnlStudentIdentity.ResumeLayout(false);
            pnlStudentNumber.ResumeLayout(false);
            pnlStudentYear.ResumeLayout(false);
            pnlProgram.ResumeLayout(false);
            pnlDept.ResumeLayout(false);
            studentActions.ResumeLayout(false);
            studentStatusActions.ResumeLayout(false);
            pnlHeaderInstructor.ResumeLayout(false);
            pnlHeaderInstructor.PerformLayout();
            cPnlAddStudent.ResumeLayout(false);
            pnlSearchSort.ResumeLayout(false);
            pnlSearchSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel studentFieldsLayout;
        private Panel pnlStudentIdentity;
        private Panel pnlStudentNumber;
        private Panel pnlStudentYear;
        private FlowLayoutPanel studentActions;
        private FlowLayoutPanel studentStatusActions;
        private Label lblStudentStatusActions;
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
        private ComboBox cmbYear;
        private RoundedButton rBtnSetDropped;
        private RoundedButton rBtnSetInactive;
        private RoundedButton rBtnSetActive;
    }
}
