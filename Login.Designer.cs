namespace SMART
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            picLogoLogin = new PictureBox();
            lblSMART = new Label();
            panel1 = new Panel();
            lblMSAPOP = new Label();
            lblTAMP = new Label();
            lblWelcome = new Label();
            lblSign = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            rBtnLogin = new RoundedButton();
            panel2 = new Panel();
            rTbPassword = new RoundedTextBox();
            rTbUsername = new RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // picLogoLogin
            // 
            picLogoLogin.BackgroundImage = (Image)resources.GetObject("picLogoLogin.BackgroundImage");
            picLogoLogin.BackgroundImageLayout = ImageLayout.Zoom;
            picLogoLogin.Location = new Point(175, 222);
            picLogoLogin.Name = "picLogoLogin";
            picLogoLogin.Size = new Size(150, 150);
            picLogoLogin.TabIndex = 2;
            picLogoLogin.TabStop = false;
            // 
            // lblSMART
            // 
            lblSMART.AutoSize = true;
            lblSMART.Font = new Font("Bahnschrift", 35F, FontStyle.Bold);
            lblSMART.ForeColor = Color.FromArgb(233, 69, 96);
            lblSMART.Location = new Point(134, 375);
            lblSMART.Name = "lblSMART";
            lblSMART.Size = new Size(217, 57);
            lblSMART.TabIndex = 14;
            lblSMART.Text = "S.M.A.R.T";
            lblSMART.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 33, 62);
            panel1.Controls.Add(lblMSAPOP);
            panel1.Controls.Add(lblTAMP);
            panel1.Controls.Add(lblSMART);
            panel1.Controls.Add(picLogoLogin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 608);
            panel1.TabIndex = 0;
            // 
            // lblMSAPOP
            // 
            lblMSAPOP.AutoSize = true;
            lblMSAPOP.Font = new Font("BankGothic Lt BT", 9F);
            lblMSAPOP.ForeColor = Color.White;
            lblMSAPOP.Location = new Point(45, 462);
            lblMSAPOP.Name = "lblMSAPOP";
            lblMSAPOP.Size = new Size(407, 13);
            lblMSAPOP.TabIndex = 16;
            lblMSAPOP.Text = "Manage students, attendance, and performance in one place.";
            // 
            // lblTAMP
            // 
            lblTAMP.AutoSize = true;
            lblTAMP.Font = new Font("BankGothic Lt BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTAMP.ForeColor = Color.White;
            lblTAMP.Location = new Point(77, 432);
            lblTAMP.Name = "lblTAMP";
            lblTAMP.Size = new Size(328, 17);
            lblTAMP.TabIndex = 15;
            lblTAMP.Text = "Teacher Academic Monitoring Portal";
            lblTAMP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Gadugi", 30F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(109, 61);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(308, 48);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome Back!";
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSign.ForeColor = Color.White;
            lblSign.Location = new Point(202, 109);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(131, 14);
            lblSign.TabIndex = 4;
            lblSign.Text = "Sign in to your account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 16F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(73, 178);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(116, 30);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(75, 284);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 30);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password: ";
            // 
            // rBtnLogin
            // 
            rBtnLogin.BackColor = Color.FromArgb(233, 69, 96);
            rBtnLogin.BorderColor = Color.White;
            rBtnLogin.BorderRadius = 5;
            rBtnLogin.FlatAppearance.BorderSize = 0;
            rBtnLogin.FlatStyle = FlatStyle.Flat;
            rBtnLogin.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnLogin.ForeColor = Color.White;
            rBtnLogin.HoverColor = Color.Empty;
            rBtnLogin.Location = new Point(75, 367);
            rBtnLogin.Name = "rBtnLogin";
            rBtnLogin.PressedColor = Color.Empty;
            rBtnLogin.Size = new Size(375, 40);
            rBtnLogin.TabIndex = 15;
            rBtnLogin.Text = "Log in";
            rBtnLogin.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 46);
            panel2.Controls.Add(rTbPassword);
            panel2.Controls.Add(rTbUsername);
            panel2.Controls.Add(rBtnLogin);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblSign);
            panel2.Controls.Add(lblWelcome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(489, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 608);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // rTbPassword
            // 
            rTbPassword.BackColor = Color.Transparent;
            rTbPassword.BorderColor = Color.FromArgb(233, 69, 96);
            rTbPassword.BorderRadius = 5;
            rTbPassword.FillColor = Color.FromArgb(26, 26, 46);
            rTbPassword.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbPassword.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbPassword.ForeColor = Color.White;
            rTbPassword.Location = new Point(75, 321);
            rTbPassword.Name = "rTbPassword";
            rTbPassword.PlaceholderText = "Enter Password";
            rTbPassword.Size = new Size(373, 40);
            rTbPassword.TabIndex = 17;
            // 
            // rTbUsername
            // 
            rTbUsername.BackColor = Color.Transparent;
            rTbUsername.BorderColor = Color.FromArgb(233, 69, 96);
            rTbUsername.BorderRadius = 5;
            rTbUsername.FillColor = Color.FromArgb(26, 26, 46);
            rTbUsername.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbUsername.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbUsername.ForeColor = Color.White;
            rTbUsername.Location = new Point(73, 211);
            rTbUsername.Name = "rTbUsername";
            rTbUsername.PlaceholderText = "Enter Username";
            rTbUsername.Size = new Size(375, 40);
            rTbUsername.TabIndex = 16;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 608);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picLogoLogin;
        private Label lblSMART;
        private Panel panel1;
        private Label lblTAMP;
        private Label lblMSAPOP;
        private Label lblWelcome;
        private Label lblSign;
        private Label lblUsername;
        private Label lblPassword;
        private RoundedButton rBtnLogin;
        private Panel panel2;
        private RoundedTextBox rTbUsername;
        private RoundedTextBox rTbPassword;
    }
}
