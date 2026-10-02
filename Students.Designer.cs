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
            rBtnName = new RoundedButton();
            rBtnID = new RoundedButton();
            roundedButton1 = new RoundedButton();
            cPnlAddStudent = new CustomPanel();
            pnlHeaderInstructor.SuspendLayout();
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
            lblStudentheader.Font = new Font("Bahnschrift", 10F);
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
            rTbSearchStudents.Location = new Point(25, 127);
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
            rBtnSearch.Location = new Point(406, 127);
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
            rBtnRefresh.Location = new Point(505, 127);
            rBtnRefresh.Name = "rBtnRefresh";
            rBtnRefresh.PressedColor = Color.Empty;
            rBtnRefresh.Size = new Size(93, 40);
            rBtnRefresh.TabIndex = 19;
            rBtnRefresh.Text = "Refresh";
            rBtnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblSlash
            // 
            lblSlash.AutoSize = true;
            lblSlash.Font = new Font("Segoe UI", 15F);
            lblSlash.ForeColor = Color.DarkGray;
            lblSlash.Location = new Point(604, 131);
            lblSlash.Name = "lblSlash";
            lblSlash.Size = new Size(17, 28);
            lblSlash.TabIndex = 20;
            lblSlash.Text = "|";
            // 
            // lblSort
            // 
            lblSort.Font = new Font("Bahnschrift", 10F);
            lblSort.ForeColor = Color.White;
            lblSort.Location = new Point(627, 136);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(78, 23);
            lblSort.TabIndex = 3;
            lblSort.Text = "Sort by:";
            lblSort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rBtnName
            // 
            rBtnName.BackColor = Color.FromArgb(22, 33, 62);
            rBtnName.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnName.BorderRadius = 5;
            rBtnName.BorderSize = 2;
            rBtnName.FlatAppearance.BorderSize = 0;
            rBtnName.FlatStyle = FlatStyle.Flat;
            rBtnName.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnName.ForeColor = Color.White;
            rBtnName.HoverColor = Color.Empty;
            rBtnName.Location = new Point(688, 127);
            rBtnName.Name = "rBtnName";
            rBtnName.PressedColor = Color.Empty;
            rBtnName.Size = new Size(64, 40);
            rBtnName.TabIndex = 21;
            rBtnName.Text = "Name";
            rBtnName.UseVisualStyleBackColor = false;
            // 
            // rBtnID
            // 
            rBtnID.BackColor = Color.FromArgb(22, 33, 62);
            rBtnID.BorderColor = Color.FromArgb(233, 69, 96);
            rBtnID.BorderRadius = 5;
            rBtnID.BorderSize = 2;
            rBtnID.FlatAppearance.BorderSize = 0;
            rBtnID.FlatStyle = FlatStyle.Flat;
            rBtnID.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnID.ForeColor = Color.White;
            rBtnID.HoverColor = Color.Empty;
            rBtnID.Location = new Point(758, 127);
            rBtnID.Name = "rBtnID";
            rBtnID.PressedColor = Color.Empty;
            rBtnID.Size = new Size(64, 40);
            rBtnID.TabIndex = 22;
            rBtnID.Text = "ID No.";
            rBtnID.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(22, 33, 62);
            roundedButton1.BorderColor = Color.FromArgb(233, 69, 96);
            roundedButton1.BorderRadius = 5;
            roundedButton1.BorderSize = 2;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.HoverColor = Color.Empty;
            roundedButton1.Location = new Point(828, 127);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.PressedColor = Color.Empty;
            roundedButton1.Size = new Size(64, 40);
            roundedButton1.TabIndex = 23;
            roundedButton1.Text = "Year";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // cPnlAddStudent
            // 
            cPnlAddStudent.Anchor = AnchorStyles.None;
            cPnlAddStudent.BackColor = Color.FromArgb(22, 33, 62);
            cPnlAddStudent.BorderColor = Color.FromArgb(22, 33, 62);
            cPnlAddStudent.CornerRadius = 5;
            cPnlAddStudent.Location = new Point(25, 233);
            cPnlAddStudent.Name = "cPnlAddStudent";
            cPnlAddStudent.Size = new Size(1400, 200);
            cPnlAddStudent.TabIndex = 24;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(1540, 845);
            Controls.Add(cPnlAddStudent);
            Controls.Add(roundedButton1);
            Controls.Add(rBtnID);
            Controls.Add(rBtnName);
            Controls.Add(lblSort);
            Controls.Add(lblSlash);
            Controls.Add(rBtnRefresh);
            Controls.Add(rBtnSearch);
            Controls.Add(rTbSearchStudents);
            Controls.Add(pnlHeaderInstructor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Students";
            Text = "Students";
            WindowState = FormWindowState.Maximized;
            pnlHeaderInstructor.ResumeLayout(false);
            pnlHeaderInstructor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private RoundedButton rBtnName;
        private RoundedButton rBtnID;
        private RoundedButton roundedButton1;
        private CustomPanel cPnlAddStudent;
    }
}