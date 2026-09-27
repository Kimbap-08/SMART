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
            txtCourses = new TextBox();
            pictureBox3 = new PictureBox();
            txtHome = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            customPanel2 = new CustomPanel();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.DarkOrchid;
            customPanel1.BorderColor = Color.DarkOrchid;
            customPanel1.Controls.Add(txtCourses);
            customPanel1.Controls.Add(pictureBox3);
            customPanel1.Controls.Add(txtHome);
            customPanel1.Controls.Add(pictureBox2);
            customPanel1.Controls.Add(pictureBox1);
            customPanel1.Location = new Point(12, 12);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(288, 716);
            customPanel1.TabIndex = 0;
            // 
            // txtCourses
            // 
            txtCourses.BackColor = Color.DarkOrchid;
            txtCourses.BorderStyle = BorderStyle.None;
            txtCourses.Font = new Font("Tahoma", 25F, FontStyle.Bold);
            txtCourses.ForeColor = SystemColors.HighlightText;
            txtCourses.Location = new Point(68, 250);
            txtCourses.Multiline = true;
            txtCourses.Name = "txtCourses";
            txtCourses.ReadOnly = true;
            txtCourses.Size = new Size(324, 35);
            txtCourses.TabIndex = 1;
            txtCourses.Text = "COURSES";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(27, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtHome
            // 
            txtHome.BackColor = Color.DarkOrchid;
            txtHome.BorderStyle = BorderStyle.None;
            txtHome.Font = new Font("Tahoma", 25F, FontStyle.Bold);
            txtHome.ForeColor = SystemColors.HighlightText;
            txtHome.Location = new Point(71, 166);
            txtHome.Multiline = true;
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(163, 35);
            txtHome.TabIndex = 1;
            txtHome.Text = "HOME";
            txtHome.TextChanged += txtHome_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(27, 166);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-67, -69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 313);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel customPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtHome;
        private PictureBox pictureBox3;
        private TextBox txtCourses;
        private CustomPanel customPanel2;
    }
}
