namespace SMART
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            customPanel1 = new CustomPanel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            txtSettings = new TextBox();
            picSettings = new PictureBox();
            txtCalendar = new TextBox();
            picCalendar = new PictureBox();
            txtCourses = new TextBox();
            picCourses = new PictureBox();
            txtHome = new TextBox();
            picHome = new PictureBox();
            picLogo = new PictureBox();
            customPanel2 = new CustomPanel();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCalendar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.DarkOrchid;
            customPanel1.BorderColor = Color.DarkOrchid;
            customPanel1.Controls.Add(textBox1);
            customPanel1.Controls.Add(pictureBox1);
            customPanel1.Controls.Add(txtSettings);
            customPanel1.Controls.Add(picSettings);
            customPanel1.Controls.Add(txtCalendar);
            customPanel1.Controls.Add(picCalendar);
            customPanel1.Controls.Add(txtCourses);
            customPanel1.Controls.Add(picCourses);
            customPanel1.Controls.Add(txtHome);
            customPanel1.Controls.Add(picHome);
            customPanel1.Controls.Add(picLogo);
            customPanel1.Location = new Point(12, 12);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(288, 716);
            customPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkOrchid;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.HighlightText;
            textBox1.Location = new Point(71, 635);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 36);
            textBox1.TabIndex = 8;
            textBox1.Text = "Sign Out";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(27, 636);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtSettings
            // 
            txtSettings.BackColor = Color.DarkOrchid;
            txtSettings.BorderStyle = BorderStyle.None;
            txtSettings.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            txtSettings.ForeColor = SystemColors.HighlightText;
            txtSettings.Location = new Point(71, 356);
            txtSettings.Multiline = true;
            txtSettings.Name = "txtSettings";
            txtSettings.Size = new Size(185, 47);
            txtSettings.TabIndex = 0;
            txtSettings.Text = "Settings";
            // 
            // picSettings
            // 
            picSettings.BackgroundImage = (Image)resources.GetObject("picSettings.BackgroundImage");
            picSettings.BackgroundImageLayout = ImageLayout.Zoom;
            picSettings.Location = new Point(27, 356);
            picSettings.Name = "picSettings";
            picSettings.Size = new Size(35, 35);
            picSettings.TabIndex = 6;
            picSettings.TabStop = false;
            picSettings.Click += pictureBox5_Click;
            // 
            // txtCalendar
            // 
            txtCalendar.BackColor = Color.DarkOrchid;
            txtCalendar.BorderStyle = BorderStyle.None;
            txtCalendar.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            txtCalendar.ForeColor = SystemColors.HighlightText;
            txtCalendar.Location = new Point(71, 288);
            txtCalendar.Multiline = true;
            txtCalendar.Name = "txtCalendar";
            txtCalendar.Size = new Size(214, 35);
            txtCalendar.TabIndex = 0;
            txtCalendar.Text = "Calendar";
            // 
            // picCalendar
            // 
            picCalendar.BackgroundImage = (Image)resources.GetObject("picCalendar.BackgroundImage");
            picCalendar.BackgroundImageLayout = ImageLayout.Zoom;
            picCalendar.Location = new Point(27, 288);
            picCalendar.Name = "picCalendar";
            picCalendar.Size = new Size(35, 35);
            picCalendar.TabIndex = 5;
            picCalendar.TabStop = false;
            // 
            // txtCourses
            // 
            txtCourses.BackColor = Color.DarkOrchid;
            txtCourses.BorderStyle = BorderStyle.None;
            txtCourses.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            txtCourses.ForeColor = SystemColors.HighlightText;
            txtCourses.Location = new Point(71, 228);
            txtCourses.Multiline = true;
            txtCourses.Name = "txtCourses";
            txtCourses.ReadOnly = true;
            txtCourses.Size = new Size(324, 35);
            txtCourses.TabIndex = 1;
            txtCourses.Text = "Courses";
            // 
            // picCourses
            // 
            picCourses.BackgroundImage = (Image)resources.GetObject("picCourses.BackgroundImage");
            picCourses.BackgroundImageLayout = ImageLayout.Zoom;
            picCourses.Location = new Point(27, 228);
            picCourses.Name = "picCourses";
            picCourses.Size = new Size(35, 35);
            picCourses.TabIndex = 3;
            picCourses.TabStop = false;
            picCourses.Click += pictureBox3_Click;
            // 
            // txtHome
            // 
            txtHome.BackColor = Color.DarkOrchid;
            txtHome.BorderStyle = BorderStyle.None;
            txtHome.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            txtHome.ForeColor = SystemColors.HighlightText;
            txtHome.Location = new Point(71, 166);
            txtHome.Multiline = true;
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(163, 35);
            txtHome.TabIndex = 1;
            txtHome.Text = "Home";
            txtHome.TextChanged += txtHome_TextChanged;
            // 
            // picHome
            // 
            picHome.BackgroundImage = (Image)resources.GetObject("picHome.BackgroundImage");
            picHome.BackgroundImageLayout = ImageLayout.Zoom;
            picHome.Location = new Point(27, 162);
            picHome.Name = "picHome";
            picHome.Size = new Size(39, 39);
            picHome.TabIndex = 1;
            picHome.TabStop = false;
            picHome.Click += pictureBox2_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Location = new Point(-67, -69);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(411, 313);
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            picLogo.Click += pictureBox1_Click;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.GhostWhite;
            customPanel2.BorderColor = Color.GhostWhite;
            customPanel2.Location = new Point(328, 12);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1330, 716);
            customPanel2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 845);
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCalendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel customPanel1;
        private PictureBox picLogo;
        private PictureBox picHome;
        private TextBox txtHome;
        private PictureBox picCourses;
        private TextBox txtCourses;
        private CustomPanel customPanel2;
        private TextBox txtCalendar;
        private PictureBox picCalendar;
        private PictureBox picSettings;
        private TextBox txtSettings;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
