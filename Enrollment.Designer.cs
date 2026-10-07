namespace SMART
{
    partial class Enrollment
    {
        private System.ComponentModel.IContainer components = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            cboCourse = new ComboBox();
            gridAll = new DataGridView();
            gridAllStudentNumber = new DataGridViewTextBoxColumn();
            gridAllFullName = new DataGridViewTextBoxColumn();
            gridAllProgram = new DataGridViewTextBoxColumn();
            gridEnrolled = new DataGridView();
            gridEnrolledStudentNumber = new DataGridViewTextBoxColumn();
            gridEnrolledFullName = new DataGridViewTextBoxColumn();
            gridEnrolledProgram = new DataGridViewTextBoxColumn();
            btnEnroll = new CustomButton();
            btnRemove = new CustomButton();
            lblStatus = new Label();
            lblEnrolledCount = new Label();
            header = new Panel();
            subtitle = new Label();
            title = new Label();
            body = new TableLayoutPanel();
            left = new CustomPanel();
            leftLayout = new TableLayoutPanel();
            leftTitle = new Label();
            middle = new Panel();
            arrow = new Label();
            right = new CustomPanel();
            rightLayout = new TableLayoutPanel();
            top = new Panel();
            courseLabel = new Label();
            listPrograms = new ListBox();
            programLabel = new Label();
            cboStudentProgram = new ComboBox();
            studentProgramLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gridAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridEnrolled).BeginInit();
            header.SuspendLayout();
            body.SuspendLayout();
            left.SuspendLayout();
            leftLayout.SuspendLayout();
            middle.SuspendLayout();
            right.SuspendLayout();
            rightLayout.SuspendLayout();
            top.SuspendLayout();
            SuspendLayout();
            // 
            // cboCourse
            // 
            cboCourse.BackColor = Color.FromArgb(22, 33, 62);
            cboCourse.DrawMode = DrawMode.OwnerDrawFixed;
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FlatStyle = FlatStyle.Flat;
            cboCourse.Font = new Font("Bahnschrift Light", 10F);
            cboCourse.ForeColor = Color.White;
            cboCourse.ItemHeight = 24;
            cboCourse.Location = new Point(24, 42);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(724, 30);
            cboCourse.TabIndex = 1;
            cboCourse.DrawItem += CboCourse_DrawItem;
            cboCourse.SelectedIndexChanged += CboCourse_Changed;
            // 
            // gridAll
            // 
            gridAll.AllowUserToAddRows = false;
            gridAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAll.BackgroundColor = Color.FromArgb(22, 33, 62);
            gridAll.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridAll.Columns.AddRange(new DataGridViewColumn[] { gridAllStudentNumber, gridAllFullName, gridAllProgram });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 33, 62);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift Light", 10.5F);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridAll.DefaultCellStyle = dataGridViewCellStyle2;
            gridAll.Dock = DockStyle.Fill;
            gridAll.EnableHeadersVisualStyles = false;
            gridAll.GridColor = Color.FromArgb(40, 52, 85);
            gridAll.Location = new Point(15, 43);
            gridAll.MultiSelect = false;
            gridAll.Name = "gridAll";
            gridAll.AllowUserToResizeRows = false;
            gridAll.ColumnHeadersHeight = 38;
            gridAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridAll.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridAll.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridAll.ReadOnly = true;
            gridAll.RowHeadersVisible = false;
            gridAll.RowTemplate.Height = 36;
            gridAll.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            gridAll.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);

            gridAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridAll.Size = new Size(442, 290);
            gridAll.TabIndex = 1;
            // 
            // gridAllStudentNumber
            // 
            gridAllStudentNumber.DataPropertyName = "StudentNumber";
            gridAllStudentNumber.FillWeight = 28F;
            gridAllStudentNumber.HeaderText = "Student No.";
            gridAllStudentNumber.Name = "gridAllStudentNumber";
            gridAllStudentNumber.ReadOnly = true;
            // 
            // gridAllFullName
            // 
            gridAllFullName.DataPropertyName = "FullName";
            gridAllFullName.FillWeight = 45F;
            gridAllFullName.HeaderText = "Full Name";
            gridAllFullName.Name = "gridAllFullName";
            gridAllFullName.ReadOnly = true;
            // 
            // gridAllProgram
            // 
            gridAllProgram.DataPropertyName = "Program";
            gridAllProgram.FillWeight = 32F;
            gridAllProgram.HeaderText = "Program";
            gridAllProgram.Name = "gridAllProgram";
            gridAllProgram.ReadOnly = true;
            // 
            // gridEnrolled
            // 
            gridEnrolled.AllowUserToAddRows = false;
            gridEnrolled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridEnrolled.BackgroundColor = Color.FromArgb(22, 33, 62);
            gridEnrolled.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridEnrolled.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridEnrolled.Columns.AddRange(new DataGridViewColumn[] { gridEnrolledStudentNumber, gridEnrolledFullName, gridEnrolledProgram });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 33, 62);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift Light", 10.5F);
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            gridEnrolled.DefaultCellStyle = dataGridViewCellStyle4;
            gridEnrolled.Dock = DockStyle.Fill;
            gridEnrolled.EnableHeadersVisualStyles = false;
            gridEnrolled.GridColor = Color.FromArgb(40, 52, 85);
            gridEnrolled.Location = new Point(15, 43);
            gridEnrolled.MultiSelect = false;
            gridEnrolled.Name = "gridEnrolled";
            gridEnrolled.AllowUserToResizeRows = false;
            gridEnrolled.ColumnHeadersHeight = 38;
            gridEnrolled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridEnrolled.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridEnrolled.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridEnrolled.ReadOnly = true;
            gridEnrolled.RowHeadersVisible = false;
            gridEnrolled.RowTemplate.Height = 36;
            gridEnrolled.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            gridEnrolled.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);

            gridEnrolled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEnrolled.Size = new Size(442, 290);
            gridEnrolled.TabIndex = 1;
            // 
            // gridEnrolledStudentNumber
            // 
            gridEnrolledStudentNumber.DataPropertyName = "StudentNumber";
            gridEnrolledStudentNumber.FillWeight = 28F;
            gridEnrolledStudentNumber.HeaderText = "Student No.";
            gridEnrolledStudentNumber.Name = "gridEnrolledStudentNumber";
            gridEnrolledStudentNumber.ReadOnly = true;
            // 
            // gridEnrolledFullName
            // 
            gridEnrolledFullName.DataPropertyName = "FullName";
            gridEnrolledFullName.FillWeight = 45F;
            gridEnrolledFullName.HeaderText = "Full Name";
            gridEnrolledFullName.Name = "gridEnrolledFullName";
            gridEnrolledFullName.ReadOnly = true;
            // 
            // gridEnrolledProgram
            // 
            gridEnrolledProgram.DataPropertyName = "Program";
            gridEnrolledProgram.FillWeight = 32F;
            gridEnrolledProgram.HeaderText = "Program";
            gridEnrolledProgram.Name = "gridEnrolledProgram";
            gridEnrolledProgram.ReadOnly = true;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.FromArgb(233, 69, 96);
            btnEnroll.BorderColor = Color.White;
            btnEnroll.BorderRadius = 5;
            btnEnroll.Dock = DockStyle.Fill;
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.Font = new Font("Bahnschrift", 11F);
            btnEnroll.ForeColor = Color.White;
            btnEnroll.HoverColor = Color.Empty;
            btnEnroll.Location = new Point(15, 339);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Margin = new Padding(0, 16, 0, 8);
            btnEnroll.PressedColor = Color.Empty;
            btnEnroll.Size = new Size(442, 42);
            btnEnroll.TabIndex = 2;
            btnEnroll.Text = "+ Enroll Selected Student";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += BtnEnroll_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(92, 39, 54);
            btnRemove.BorderColor = Color.White;
            btnRemove.BorderRadius = 5;
            btnRemove.Dock = DockStyle.Fill;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Bahnschrift", 11F);
            btnRemove.ForeColor = Color.White;
            btnRemove.HoverColor = Color.Empty;
            btnRemove.Location = new Point(15, 339);
            btnRemove.Name = "btnRemove";
            btnRemove.Margin = new Padding(0, 16, 0, 8);
            btnRemove.PressedColor = Color.Empty;
            btnRemove.Size = new Size(442, 42);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "− Remove Selected Student";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += BtnRemove_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.Font = new Font("Bahnschrift Light", 10F);
            lblStatus.ForeColor = Color.FromArgb(150, 150, 170);
            lblStatus.Location = new Point(24, 152);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1492, 46);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Select a course to view students.";
            // 
            // lblEnrolledCount
            // 
            lblEnrolledCount.Dock = DockStyle.Fill;
            lblEnrolledCount.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            lblEnrolledCount.ForeColor = Color.White;
            lblEnrolledCount.Location = new Point(15, 12);
            lblEnrolledCount.Name = "lblEnrolledCount";
            lblEnrolledCount.Margin = Padding.Empty;
            lblEnrolledCount.Size = new Size(442, 28);
            lblEnrolledCount.TabIndex = 0;
            lblEnrolledCount.Text = "Enrolled Students (0)";
            lblEnrolledCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(22, 33, 62);
            header.Controls.Add(subtitle);
            header.Controls.Add(title);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Padding = Padding.Empty;
            header.Size = new Size(1540, 106);
            header.TabIndex = 2;
            // 
            // subtitle
            // 
            subtitle.Dock = DockStyle.None;
            subtitle.Font = new Font("Bahnschrift Light", 10F);
            subtitle.ForeColor = Color.White;
            subtitle.Location = new Point(25, 68);
            subtitle.Name = "subtitle";
            subtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            subtitle.Size = new Size(1000, 23);
            subtitle.TabIndex = 0;
            subtitle.Text = "Enroll students into courses";
            // 
            // title
            // 
            title.Dock = DockStyle.None;
            title.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Location = new Point(25, 36);
            title.Name = "title";
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            title.Size = new Size(1000, 32);
            title.TabIndex = 1;
            title.Text = "Enrollment Management";
            // 
            // body
            // 
            body.BackColor = Color.FromArgb(26, 26, 46);
            body.ColumnCount = 3;
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            body.Controls.Add(left, 0, 0);
            body.Controls.Add(middle, 1, 0);
            body.Controls.Add(right, 2, 0);
            body.Dock = DockStyle.Fill;
            body.Location = new Point(0, 314);
            body.Name = "body";
            body.Padding = new Padding(12, 6, 12, 15);
            body.RowCount = 1;
            body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            body.Size = new Size(1540, 531);
            body.TabIndex = 0;
            // 
            // left
            // 
            left.BackColor = Color.FromArgb(22, 33, 62);
            left.BorderColor = Color.FromArgb(40, 52, 85);
            left.BorderWidth = 0;
            left.Controls.Add(leftLayout);
            left.CornerRadius = 5;
            left.Dock = DockStyle.Fill;
            left.Location = new Point(27, 19);
            left.Name = "left";
            left.Margin = Padding.Empty;
            left.Padding = Padding.Empty;
            left.Size = new Size(488, 412);
            left.TabIndex = 0;
            // 
            // leftLayout
            // 
            leftLayout.BackColor = Color.FromArgb(22, 33, 62);
            leftLayout.ColumnCount = 1;
            leftLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftLayout.Controls.Add(leftTitle, 0, 0);
            leftLayout.Controls.Add(gridAll, 0, 1);
            leftLayout.Controls.Add(btnEnroll, 0, 2);
            leftLayout.Dock = DockStyle.Fill;
            leftLayout.Location = new Point(8, 8);
            leftLayout.Name = "leftLayout";
            leftLayout.Padding = new Padding(16);
            leftLayout.RowCount = 3;
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            leftLayout.Size = new Size(472, 396);
            leftLayout.TabIndex = 0;
            // 
            // leftTitle
            // 
            leftTitle.Dock = DockStyle.Fill;
            leftTitle.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            leftTitle.ForeColor = Color.White;
            leftTitle.Location = new Point(15, 12);
            leftTitle.Name = "leftTitle";
            leftTitle.Margin = Padding.Empty;
            leftTitle.Size = new Size(442, 28);
            leftTitle.TabIndex = 0;
            leftTitle.Text = "All Students";
            leftTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // middle
            // 
            middle.BackColor = Color.FromArgb(26, 26, 46);
            middle.Controls.Add(arrow);
            middle.Dock = DockStyle.Fill;
            middle.Location = new Point(521, 19);
            middle.Name = "middle";
            middle.Size = new Size(58, 412);
            middle.TabIndex = 1;
            // 
            // arrow
            // 
            arrow.Dock = DockStyle.Fill;
            arrow.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            arrow.ForeColor = Color.FromArgb(233, 69, 96);
            arrow.Location = new Point(0, 0);
            arrow.Name = "arrow";
            arrow.Size = new Size(58, 412);
            arrow.TabIndex = 0;
            arrow.Text = "→";
            arrow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // right
            // 
            right.BackColor = Color.FromArgb(22, 33, 62);
            right.BorderColor = Color.FromArgb(40, 52, 85);
            right.BorderWidth = 0;
            right.Controls.Add(rightLayout);
            right.CornerRadius = 5;
            right.Dock = DockStyle.Fill;
            right.Location = new Point(585, 19);
            right.Name = "right";
            right.Margin = Padding.Empty;
            right.Padding = Padding.Empty;
            right.Size = new Size(488, 412);
            right.TabIndex = 2;
            // 
            // rightLayout
            // 
            rightLayout.BackColor = Color.FromArgb(22, 33, 62);
            rightLayout.ColumnCount = 1;
            rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightLayout.Controls.Add(lblEnrolledCount, 0, 0);
            rightLayout.Controls.Add(gridEnrolled, 0, 1);
            rightLayout.Controls.Add(btnRemove, 0, 2);
            rightLayout.Dock = DockStyle.Fill;
            rightLayout.Location = new Point(8, 8);
            rightLayout.Name = "rightLayout";
            rightLayout.Padding = new Padding(16);
            rightLayout.RowCount = 3;
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            rightLayout.Size = new Size(472, 396);
            rightLayout.TabIndex = 0;
            // 
            // top
            // 
            top.BackColor = Color.FromArgb(26, 26, 46);
            top.Controls.Add(courseLabel);
            top.Controls.Add(cboCourse);
            top.Controls.Add(lblStatus);
            top.Controls.Add(cboStudentProgram);
            top.Controls.Add(studentProgramLabel);
            top.Controls.Add(programLabel);
            top.Controls.Add(listPrograms);
            top.Dock = DockStyle.Top;
            top.Location = new Point(0, 106);
            top.Name = "top";
            top.Size = new Size(1540, 208);
            top.TabIndex = 1;
            top.SizeChanged += Top_SizeChanged;
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = false;
            courseLabel.Font = new Font("Bahnschrift Light", 10F);
            courseLabel.ForeColor = Color.White;
            courseLabel.Location = new Point(24, 16);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(724, 24);
            courseLabel.TabIndex = 0;
            courseLabel.Text = "Select Course:";
            programLabel.Name = "programLabel";
            programLabel.AutoSize = false;
            programLabel.Text = "Course programs:";
            programLabel.ForeColor = Color.White;
            programLabel.Font = new Font("Bahnschrift Light", 10F);
            programLabel.Location = new Point(24, 84);
            programLabel.Size = new Size(1492, 24);
            listPrograms.Name = "listPrograms";
            listPrograms.BackColor = Color.FromArgb(22, 33, 62);
            listPrograms.ForeColor = Color.White;
            listPrograms.Font = new Font("Bahnschrift Light", 10F);
            listPrograms.BorderStyle = BorderStyle.None;
            listPrograms.DrawMode = DrawMode.OwnerDrawFixed;
            listPrograms.ItemHeight = 26;
            listPrograms.IntegralHeight = false;
            listPrograms.MultiColumn = true;
            listPrograms.ColumnWidth = 90;
            listPrograms.Location = new Point(24, 110);
            listPrograms.Size = new Size(1492, 32);
            listPrograms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listPrograms.Items.AddRange(new object[] { "ME", "CES", "COE", "BSN", "IT", "GEO", "ECE", "ACC" });
            listPrograms.DrawItem += ListPrograms_DrawItem;
            studentProgramLabel.Name = "studentProgramLabel";
            studentProgramLabel.AutoSize = false;
            studentProgramLabel.Text = "Student program:";
            studentProgramLabel.Font = new Font("Bahnschrift Light", 10F);
            studentProgramLabel.ForeColor = Color.White;
            studentProgramLabel.Location = new Point(772, 16);
            studentProgramLabel.Size = new Size(744, 24);
            cboStudentProgram.Name = "cboStudentProgram";
            cboStudentProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStudentProgram.DrawMode = DrawMode.OwnerDrawFixed;
            cboStudentProgram.ItemHeight = 24;
            cboStudentProgram.FlatStyle = FlatStyle.Flat;
            cboStudentProgram.BackColor = Color.FromArgb(22, 33, 62);
            cboStudentProgram.ForeColor = Color.White;
            cboStudentProgram.Font = new Font("Bahnschrift Light", 10F);
            cboStudentProgram.Location = new Point(772, 42);
            cboStudentProgram.Size = new Size(744, 30);
            cboStudentProgram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboStudentProgram.Items.AddRange(new object[] { "All Programs" });
            cboStudentProgram.DrawItem += CboCourse_DrawItem;
            cboStudentProgram.SelectedIndexChanged += CboStudentProgram_Changed;


            // 
            // Enrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(1540, 845);
            Controls.Add(body);
            Controls.Add(top);
            Controls.Add(header);
            MinimumSize = new Size(800, 450);
            Name = "Enrollment";
            Text = "Enrollment Management";
            Load += Enrollment_Load;
            ((System.ComponentModel.ISupportInitialize)gridAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridEnrolled).EndInit();
            header.ResumeLayout(false);
            body.ResumeLayout(false);
            left.ResumeLayout(false);
            leftLayout.ResumeLayout(false);
            middle.ResumeLayout(false);
            right.ResumeLayout(false);
            rightLayout.ResumeLayout(false);
            top.ResumeLayout(false);
            top.PerformLayout();
            ResumeLayout(false);
        }


        private DataGridViewTextBoxColumn gridAllStudentNumber = null!;
        private DataGridViewTextBoxColumn gridAllFullName = null!;
        private DataGridViewTextBoxColumn gridAllProgram = null!;
        private DataGridViewTextBoxColumn gridEnrolledStudentNumber = null!;
        private DataGridViewTextBoxColumn gridEnrolledFullName = null!;
        private DataGridViewTextBoxColumn gridEnrolledProgram = null!;
        private ComboBox cboStudentProgram = null!;
        private Label studentProgramLabel = null!;
        private ListBox listPrograms = null!;
        private Label programLabel = null!;
        private ComboBox cboCourse = null!;
        private DataGridView gridAll = null!;
        private DataGridView gridEnrolled = null!;
        private CustomButton btnEnroll = null!;
        private CustomButton btnRemove = null!;
        private Label lblStatus = null!;
        private Label lblEnrolledCount = null!;
        private Panel header = null!;
        private Label title = null!;
        private Label subtitle = null!;
        private TableLayoutPanel body = null!;
        private Panel top = null!;
        private Label courseLabel = null!;
        private TableLayoutPanel rightLayout = null!;
        private TableLayoutPanel leftLayout = null!;
        private Label leftTitle = null!;
        private Panel middle = null!;
        private Label arrow = null!;
        private CustomPanel left = null!;
        private CustomPanel right = null!;
    }
}
