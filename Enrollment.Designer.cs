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
            components = new System.ComponentModel.Container();
            SuspendLayout();
            cboCourse = new ComboBox();
            gridAll = new DataGridView();
            gridEnrolled = new DataGridView();
            btnEnroll = new CustomButton();
            btnRemove = new CustomButton();
            lblStatus = new Label();
            lblEnrolledCount = new Label();
            header = new Panel();
            header.Dock = DockStyle.Top;
            header.Height = 112;
            header.BackColor = Color.FromArgb(22, 33, 62);
            header.Padding = new Padding(26, 16, 20, 12);

            title = new Label();
            title.Text = "Enrollment Management";
            title.Dock = DockStyle.Top;
            title.Height = 44;
            title.ForeColor = Color.White;
            title.Font = new Font("Segoe UI", 20, FontStyle.Bold);

            subtitle = new Label();
            subtitle.Text = "Enroll students into courses";
            subtitle.Dock = DockStyle.Top;
            subtitle.Height = 28;
            subtitle.ForeColor = Color.FromArgb(150, 150, 170);
            subtitle.Font = new Font("Segoe UI", 10);

            header.Controls.Add(subtitle);
            header.Controls.Add(title);
            body = new TableLayoutPanel();
            body.Dock = DockStyle.Fill;
            body.BackColor = Color.FromArgb(13, 17, 38);
            body.Padding = new Padding(24, 16, 24, 20);
            body.ColumnCount = 3;
            body.RowCount = 1;

            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            top = new Panel();
            top.Dock = DockStyle.Top;
            top.Height = 84;
            top.BackColor = Color.FromArgb(13, 17, 38);

            courseLabel = new Label();
            courseLabel.Text = "Select Course:";
            courseLabel.ForeColor = Color.White;
            courseLabel.Font = new Font("Segoe UI", 10);
            courseLabel.AutoSize = true;
            courseLabel.Location = new Point(0, 9);

            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.BackColor = Color.FromArgb(22, 33, 62);
            cboCourse.ForeColor = Color.White;
            cboCourse.FlatStyle = FlatStyle.Flat;
            cboCourse.Font = new Font("Segoe UI", 10);
            cboCourse.Location = new Point(116, 4);
            cboCourse.Size = new Size(460, 32);
            cboCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cboCourse.SelectedIndexChanged += CboCourse_Changed;
            lblStatus.Text = "Select a course to view students.";
            lblStatus.ForeColor = Color.FromArgb(150, 150, 170);
            lblStatus.Font = new Font("Segoe UI", 9);
            lblStatus.AutoEllipsis = true;
            lblStatus.Location = new Point(0, 47);
            lblStatus.Size = new Size(500, 24);
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top.Controls.Add(courseLabel);
            top.Controls.Add(cboCourse);
            top.Controls.Add(lblStatus);
            left = new CustomPanel();
            left.Dock = DockStyle.Fill;
            left.BackColor = Color.FromArgb(22, 33, 62);
            left.BorderColor = Color.FromArgb(40, 48, 72);
            left.BorderWidth = 0;
            left.CornerRadius = 10;
            left.Padding = new Padding(8);

            right = new CustomPanel();
            right.Dock = DockStyle.Fill;
            right.BackColor = Color.FromArgb(22, 33, 62);
            right.BorderColor = Color.FromArgb(40, 48, 72);
            right.BorderWidth = 0;
            right.CornerRadius = 10;
            right.Padding = new Padding(8);

            lblEnrolledCount.Text = "Enrolled Students (0)";
            rightLayout = new TableLayoutPanel();
            rightLayout.Dock = DockStyle.Fill;
            rightLayout.BackColor = Color.FromArgb(22, 33, 62);
            rightLayout.Padding = new Padding(12);
            rightLayout.RowCount = 3;
            rightLayout.ColumnCount = 1;

            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            lblEnrolledCount.ForeColor = Color.White;
            lblEnrolledCount.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnRemove.Text = "− Remove Selected Student";
            btnRemove.BackColor = Color.FromArgb(60, 60, 80);
            btnRemove.ForeColor = Color.FromArgb(233, 69, 96);
            btnRemove.Dock = DockStyle.Fill;
            btnRemove.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnRemove.Click += BtnRemove_Click;
            rightLayout.Controls.Add(lblEnrolledCount, 0, 0);
            rightLayout.Controls.Add(gridEnrolled, 0, 1);
            rightLayout.Controls.Add(btnRemove, 0, 2);
            right.Controls.Add(rightLayout);
            leftLayout = new TableLayoutPanel();
            leftLayout.Dock = DockStyle.Fill;
            leftLayout.BackColor = Color.FromArgb(22, 33, 62);
            leftLayout.Padding = new Padding(12);
            leftLayout.RowCount = 3;
            leftLayout.ColumnCount = 1;

            leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            leftTitle = new Label();
            leftTitle.Text = "All Students";
            leftTitle.ForeColor = Color.White;
            leftTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            leftTitle.Dock = DockStyle.Fill;
            leftTitle.TextAlign = ContentAlignment.MiddleLeft;

            btnEnroll.Text = "+ Enroll Selected Student";
            btnEnroll.BackColor = Color.FromArgb(233, 69, 96);
            btnEnroll.ForeColor = Color.White;
            btnEnroll.Dock = DockStyle.Fill;
            btnEnroll.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnEnroll.Click += BtnEnroll_Click;
            leftLayout.Controls.Add(leftTitle, 0, 0);
            leftLayout.Controls.Add(gridAll, 0, 1);
            leftLayout.Controls.Add(btnEnroll, 0, 2);
            left.Controls.Add(leftLayout);
            middle = new Panel();
            middle.Dock = DockStyle.Fill;
            middle.BackColor = Color.FromArgb(13, 17, 38);

            arrow = new Label();
            arrow.Text = "→";
            arrow.ForeColor = Color.FromArgb(233, 69, 96);
            arrow.Dock = DockStyle.Fill;
            arrow.TextAlign = ContentAlignment.MiddleCenter;
            arrow.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            middle.Controls.Add(arrow);
            body.Controls.Add(left, 0, 0);
            body.Controls.Add(middle, 1, 0);
            body.Controls.Add(right, 2, 0);

            gridAll.Dock = DockStyle.Fill;
            gridAll.BackgroundColor = Color.FromArgb(22, 33, 62);
            gridAll.ForeColor = Color.White;
            gridAll.GridColor = Color.FromArgb(40, 40, 60);
            gridAll.BorderStyle = BorderStyle.None;
            gridAll.RowHeadersVisible = false;
            gridAll.AllowUserToAddRows = false;
            gridAll.ReadOnly = true;
            gridAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridAll.MultiSelect = false;
            gridAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAll.EnableHeadersVisualStyles = false;
            gridAll.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 15, 35);
            gridAll.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridAll.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            gridAll.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            gridAll.DefaultCellStyle.ForeColor = Color.White;
            gridAll.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            gridAll.DefaultCellStyle.SelectionForeColor = Color.White;
            gridAll.RowTemplate.Height = 36;
            gridAllStudentNumber = new DataGridViewTextBoxColumn();
            gridAllStudentNumber.Name = "StudentNumber";
            gridAllStudentNumber.HeaderText = "Student No.";
            gridAllStudentNumber.DataPropertyName = "StudentNumber";
            gridAllStudentNumber.FillWeight = 28;
            gridAll.Columns.Add(gridAllStudentNumber);
            gridAllFullName = new DataGridViewTextBoxColumn();
            gridAllFullName.Name = "FullName";
            gridAllFullName.HeaderText = "Full Name";
            gridAllFullName.DataPropertyName = "FullName";
            gridAllFullName.FillWeight = 45;
            gridAll.Columns.Add(gridAllFullName);
            gridAllProgram = new DataGridViewTextBoxColumn();
            gridAllProgram.Name = "Program";
            gridAllProgram.HeaderText = "Program";
            gridAllProgram.DataPropertyName = "Program";
            gridAllProgram.FillWeight = 32;
            gridAll.Columns.Add(gridAllProgram);
            gridEnrolled.Dock = DockStyle.Fill;
            gridEnrolled.BackgroundColor = Color.FromArgb(22, 33, 62);
            gridEnrolled.ForeColor = Color.White;
            gridEnrolled.GridColor = Color.FromArgb(40, 40, 60);
            gridEnrolled.BorderStyle = BorderStyle.None;
            gridEnrolled.RowHeadersVisible = false;
            gridEnrolled.AllowUserToAddRows = false;
            gridEnrolled.ReadOnly = true;
            gridEnrolled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEnrolled.MultiSelect = false;
            gridEnrolled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridEnrolled.EnableHeadersVisualStyles = false;
            gridEnrolled.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 15, 35);
            gridEnrolled.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridEnrolled.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            gridEnrolled.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            gridEnrolled.DefaultCellStyle.ForeColor = Color.White;
            gridEnrolled.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            gridEnrolled.DefaultCellStyle.SelectionForeColor = Color.White;
            gridEnrolled.RowTemplate.Height = 36;
            gridEnrolledStudentNumber = new DataGridViewTextBoxColumn();
            gridEnrolledStudentNumber.Name = "StudentNumber";
            gridEnrolledStudentNumber.HeaderText = "Student No.";
            gridEnrolledStudentNumber.DataPropertyName = "StudentNumber";
            gridEnrolledStudentNumber.FillWeight = 28;
            gridEnrolled.Columns.Add(gridEnrolledStudentNumber);
            gridEnrolledFullName = new DataGridViewTextBoxColumn();
            gridEnrolledFullName.Name = "FullName";
            gridEnrolledFullName.HeaderText = "Full Name";
            gridEnrolledFullName.DataPropertyName = "FullName";
            gridEnrolledFullName.FillWeight = 45;
            gridEnrolled.Columns.Add(gridEnrolledFullName);
            gridEnrolledProgram = new DataGridViewTextBoxColumn();
            gridEnrolledProgram.Name = "Program";
            gridEnrolledProgram.HeaderText = "Program";
            gridEnrolledProgram.DataPropertyName = "Program";
            gridEnrolledProgram.FillWeight = 32;
            gridEnrolled.Columns.Add(gridEnrolledProgram);
            top.Dock = DockStyle.Top;
            // Add docked controls from fill to top so the header and course selector reserve space.
            Controls.Add(body);
            Controls.Add(top);
            Controls.Add(header);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 38);
            ClientSize = new Size(1100, 650);
            MinimumSize = new Size(800, 450);
            Name = "Enrollment";
            Text = "Enrollment Management";
            Load += Enrollment_Load;
            cboCourse.Name = "cboCourse";
            gridAll.Name = "gridAll";
            gridEnrolled.Name = "gridEnrolled";
            btnEnroll.Name = "btnEnroll";
            btnRemove.Name = "btnRemove";
            lblStatus.Name = "lblStatus";
            lblEnrolledCount.Name = "lblEnrolledCount";
            header.Name = "header";
            title.Name = "title";
            subtitle.Name = "subtitle";
            body.Name = "body";
            top.Name = "top";
            courseLabel.Name = "courseLabel";
            rightLayout.Name = "rightLayout";
            leftLayout.Name = "leftLayout";
            leftTitle.Name = "leftTitle";
            middle.Name = "middle";
            arrow.Name = "arrow";
            left.Name = "left";
            right.Name = "right";
            ResumeLayout(false);
        }


        private DataGridViewTextBoxColumn gridAllStudentNumber = null!;
        private DataGridViewTextBoxColumn gridAllFullName = null!;
        private DataGridViewTextBoxColumn gridAllProgram = null!;
        private DataGridViewTextBoxColumn gridEnrolledStudentNumber = null!;
        private DataGridViewTextBoxColumn gridEnrolledFullName = null!;
        private DataGridViewTextBoxColumn gridEnrolledProgram = null!;
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
