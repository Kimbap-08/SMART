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
            loginCard = new CustomPanel();
            lblLoginBadge = new Label();
            lblAccessHelp = new Label();
            chkShowPassword = new CheckBox();
            lblBrandFeatures = new Label();
            lblBrandFooter = new Label();
            lblLoginFooter = new Label();
            picLogoLogin = new PictureBox();
            lblSMART = new Label();
            panel1 = new TranslucentBackgroundPanel();
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
            picLogoLogin.Location = new Point(48, 80);
            picLogoLogin.BackColor = Color.Transparent;
            picLogoLogin.Name = "picLogoLogin";
            picLogoLogin.Size = new Size(112, 112);
            picLogoLogin.TabIndex = 2;
            picLogoLogin.TabStop = false;
            // 
            // lblSMART
            // 
            lblSMART.AutoSize = false;
            lblSMART.Font = new Font("Bahnschrift", 35F, FontStyle.Bold);
            lblSMART.ForeColor = Color.FromArgb(233, 69, 96);
            lblSMART.Location = new Point(48, 220);
            lblSMART.BackColor = Color.Transparent;
            lblSMART.Name = "lblSMART";
            lblSMART.Size = new Size(384, 64);
            lblSMART.TabIndex = 14;
            lblSMART.Text = "S.M.A.R.T";
            lblSMART.TextAlign = ContentAlignment.TopLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 33, 62);
            panel1.BackgroundImage = (Image)resources.GetObject("Login.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.ImageOpacity = 0.45F;
            panel1.Controls.Add(lblBrandFeatures);
            panel1.Controls.Add(lblBrandFooter);
            panel1.Controls.Add(lblMSAPOP);
            panel1.Controls.Add(lblTAMP);
            panel1.Controls.Add(lblSMART);
            panel1.Controls.Add(picLogoLogin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 720);
            panel1.TabIndex = 0;
            // 
            // lblMSAPOP
            // 
            lblMSAPOP.AutoSize = false;
            lblMSAPOP.Font = new Font("Bahnschrift Light", 12F);
            lblMSAPOP.ForeColor = Color.FromArgb(180, 190, 211);
            lblMSAPOP.Location = new Point(48, 380);
            lblMSAPOP.BackColor = Color.Transparent;
            lblMSAPOP.Name = "lblMSAPOP";
            lblMSAPOP.Size = new Size(384, 70);
            lblMSAPOP.TabIndex = 16;
            lblMSAPOP.Text = "Manage students, attendance, and performance in one place.";
            // 
            // lblTAMP
            // 
            lblTAMP.AutoSize = false;
            lblTAMP.Font = new Font("Bahnschrift", 16F);
            lblTAMP.ForeColor = Color.White;
            lblTAMP.Location = new Point(48, 298);
            lblTAMP.BackColor = Color.Transparent;
            lblTAMP.Name = "lblTAMP";
            lblTAMP.Size = new Size(384, 76);
            lblTAMP.TabIndex = 15;
            lblTAMP.Text = "Teacher Academic\r\nMonitoring Portal";
            lblTAMP.TextAlign = ContentAlignment.TopLeft;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = false;
            lblWelcome.Font = new Font("Gadugi", 26F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(32, 58);
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(416, 48);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome back";
            // 
            // lblSign
            // 
            lblSign.AutoSize = false;
            lblSign.Font = new Font("Bahnschrift Light", 11F);
            lblSign.ForeColor = Color.FromArgb(180, 190, 211);
            lblSign.Location = new Point(32, 114);
            lblSign.BackColor = Color.Transparent;
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(416, 42);
            lblSign.TabIndex = 4;
            lblSign.Text = "Sign in to manage your academic workspace.";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = false;
            lblUsername.Font = new Font("Bahnschrift", 11F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(32, 178);
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(416, 22);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = false;
            lblPassword.Font = new Font("Bahnschrift", 11F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(32, 272);
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(416, 22);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password: ";
            // 
            // rBtnLogin
            // 
            rBtnLogin.BackColor = Color.FromArgb(233, 69, 96);
            rBtnLogin.BorderColor = Color.White;
            rBtnLogin.BorderRadius = 8;
            rBtnLogin.FlatAppearance.BorderSize = 0;
            rBtnLogin.FlatStyle = FlatStyle.Flat;
            rBtnLogin.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            rBtnLogin.ForeColor = Color.White;
            rBtnLogin.HoverColor = Color.Empty;
            rBtnLogin.Location = new Point(32, 396);
            rBtnLogin.Name = "rBtnLogin";
            rBtnLogin.PressedColor = Color.Empty;
            rBtnLogin.Size = new Size(416, 48);
            rBtnLogin.TabIndex = 3;
            rBtnLogin.Text = "Sign in";
            rBtnLogin.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(loginCard);
            panel2.Controls.Add(lblLoginFooter);
            loginCard.Controls.Add(rTbPassword);
            loginCard.Controls.Add(rTbUsername);
            loginCard.Controls.Add(rBtnLogin);
            loginCard.Controls.Add(lblPassword);
            loginCard.Controls.Add(lblUsername);
            loginCard.Controls.Add(lblSign);
            loginCard.Controls.Add(lblWelcome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(480, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 720);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // rTbPassword
            // 
            rTbPassword.BackColor = Color.Transparent;
            rTbPassword.BorderColor = Color.FromArgb(233, 69, 96);
            rTbPassword.BorderRadius = 8;
            rTbPassword.FillColor = Color.FromArgb(26, 26, 46);
            rTbPassword.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbPassword.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbPassword.ForeColor = Color.White;
            rTbPassword.Location = new Point(32, 298);
            rTbPassword.Name = "rTbPassword";
            rTbPassword.PlaceholderText = "Enter Password";
            rTbPassword.Size = new Size(416, 46);
            rTbPassword.TabIndex = 1;
            // 
            // rTbUsername
            // 
            rTbUsername.BackColor = Color.Transparent;
            rTbUsername.BorderColor = Color.FromArgb(233, 69, 96);
            rTbUsername.BorderRadius = 8;
            rTbUsername.FillColor = Color.FromArgb(26, 26, 46);
            rTbUsername.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rTbUsername.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rTbUsername.ForeColor = Color.White;
            rTbUsername.Location = new Point(32, 204);
            rTbUsername.Name = "rTbUsername";
            rTbUsername.PlaceholderText = "Enter Username";
            rTbUsername.Size = new Size(416, 46);
            rTbUsername.TabIndex = 0;
            loginCard.Name = "loginCard";
            loginCard.BackColor = Color.FromArgb(178, 22, 33, 62);
            loginCard.BorderColor = Color.FromArgb(40, 52, 85);
            loginCard.BorderWidth = 1;
            loginCard.CornerRadius = 16;
            loginCard.Location = new Point(90, 78);
            loginCard.Size = new Size(480, 540);
            loginCard.Controls.Add(lblLoginBadge);
            loginCard.Controls.Add(chkShowPassword);
            loginCard.Controls.Add(lblAccessHelp);
            lblLoginBadge.BackColor = Color.Transparent;
            lblLoginBadge.Name = "lblLoginBadge";
            lblLoginBadge.Text = "ACCOUNT ACCESS";
            lblLoginBadge.Font = new Font("Bahnschrift", 9F, FontStyle.Bold);
            lblLoginBadge.ForeColor = Color.FromArgb(233, 69, 96);
            lblLoginBadge.Location = new Point(32, 30);
            lblLoginBadge.Size = new Size(416, 20);
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Text = "Show password";
            chkShowPassword.Font = new Font("Bahnschrift Light", 10F);
            chkShowPassword.ForeColor = Color.FromArgb(180, 190, 211);
            chkShowPassword.Location = new Point(32, 358);
            chkShowPassword.Size = new Size(180, 24);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
            lblAccessHelp.BackColor = Color.Transparent;
            lblAccessHelp.Name = "lblAccessHelp";
            lblAccessHelp.Text = "Need access? Contact your administrator.";
            lblAccessHelp.Font = new Font("Bahnschrift Light", 10F);
            lblAccessHelp.ForeColor = Color.FromArgb(180, 190, 211);
            lblAccessHelp.Location = new Point(32, 466);
            lblAccessHelp.Size = new Size(416, 42);
            lblAccessHelp.TextAlign = ContentAlignment.TopCenter;
            lblBrandFeatures.BackColor = Color.Transparent;
            lblBrandFeatures.Name = "lblBrandFeatures";
            lblBrandFeatures.Text = "STUDENTS  /  COURSES  /  ENROLLMENT";
            lblBrandFeatures.Font = new Font("Bahnschrift", 10F);
            lblBrandFeatures.ForeColor = Color.FromArgb(180, 190, 211);
            lblBrandFeatures.Location = new Point(48, 494);
            lblBrandFeatures.Size = new Size(384, 60);
            lblBrandFooter.BackColor = Color.Transparent;
            lblBrandFooter.Name = "lblBrandFooter";
            lblBrandFooter.Text = "Your academic workspace, connected.";
            lblBrandFooter.Font = new Font("Bahnschrift Light", 10F);
            lblBrandFooter.ForeColor = Color.FromArgb(150, 160, 185);
            lblBrandFooter.Location = new Point(48, 658);
            lblBrandFooter.Size = new Size(384, 32);
            lblLoginFooter.Name = "lblLoginFooter";
            lblLoginFooter.Text = "S.M.A.R.T  |  Teacher Academic Monitoring Portal";
            lblLoginFooter.Font = new Font("Bahnschrift Light", 9F);
            lblLoginFooter.ForeColor = Color.FromArgb(150, 160, 185);
            lblLoginFooter.TextAlign = ContentAlignment.MiddleCenter;
            lblLoginFooter.Location = new Point(24, 676);
            lblLoginFooter.Size = new Size(612, 24);
            rTbPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("Login.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1140, 720);
            MinimumSize = new Size(1000, 680);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S.M.A.R.T - Sign in";
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomPanel loginCard;
        private Label lblLoginBadge;
        private Label lblAccessHelp;
        private CheckBox chkShowPassword;
        private Label lblBrandFeatures;
        private Label lblBrandFooter;
        private Label lblLoginFooter;
        private PictureBox picLogoLogin;
        private Label lblSMART;
        private TranslucentBackgroundPanel panel1;
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
