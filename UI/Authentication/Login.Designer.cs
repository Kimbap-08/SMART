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
            rTbPassword = new RoundedTextBox();
            rTbUsername = new RoundedTextBox();
            rBtnLogin = new RoundedButton();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSign = new Label();
            lblWelcome = new Label();
            lblLoginBadge = new Label();
            chkShowPassword = new CheckBox();
            lblBrandFeatures = new Label();
            lblBrandFooter = new Label();
            lblLoginFooter = new Label();
            picLogoLogin = new PictureBox();
            lblSMART = new Label();
            panel1 = new TranslucentBackgroundPanel();
            lblMSAPOP = new Label();
            lblTAMP = new Label();
            panel2 = new Panel();
            loginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // loginCard
            // 
            loginCard.BackColor = Color.FromArgb(178, 22, 33, 62);
            loginCard.BorderColor = Color.FromArgb(40, 52, 85);
            loginCard.BorderWidth = 1;
            loginCard.Controls.Add(rTbPassword);
            loginCard.Controls.Add(rTbUsername);
            loginCard.Controls.Add(rBtnLogin);
            loginCard.Controls.Add(lblPassword);
            loginCard.Controls.Add(lblUsername);
            loginCard.Controls.Add(lblSign);
            loginCard.Controls.Add(lblWelcome);
            loginCard.Controls.Add(lblLoginBadge);
            loginCard.Controls.Add(chkShowPassword);
            loginCard.CornerRadius = 16;
            loginCard.Location = new Point(90, 78);
            loginCard.Name = "loginCard";
            loginCard.Size = new Size(480, 540);
            loginCard.TabIndex = 0;
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
            rTbPassword.PasswordChar = '●';
            rTbPassword.PlaceholderText = "Enter Password";
            rTbPassword.Size = new Size(416, 46);
            rTbPassword.TabIndex = 1;
            rTbPassword.UseSystemPasswordChar = true;
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
            // lblPassword
            // 
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Bahnschrift", 11F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(32, 272);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(416, 22);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password: ";
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Bahnschrift", 11F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(32, 178);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(416, 22);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // lblSign
            // 
            lblSign.BackColor = Color.Transparent;
            lblSign.Font = new Font("Bahnschrift Light", 11F);
            lblSign.ForeColor = Color.FromArgb(180, 190, 211);
            lblSign.Location = new Point(32, 114);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(416, 42);
            lblSign.TabIndex = 4;
            lblSign.Text = "Sign in to manage your academic workspace.";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Gadugi", 26F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(32, 58);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(416, 48);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome back";
            // 
            // lblLoginBadge
            // 
            lblLoginBadge.BackColor = Color.Transparent;
            lblLoginBadge.Font = new Font("Bahnschrift", 9F, FontStyle.Bold);
            lblLoginBadge.ForeColor = Color.FromArgb(233, 69, 96);
            lblLoginBadge.Location = new Point(32, 30);
            lblLoginBadge.Name = "lblLoginBadge";
            lblLoginBadge.Size = new Size(416, 20);
            lblLoginBadge.TabIndex = 8;
            lblLoginBadge.Text = "ACCOUNT ACCESS";
            // 
            // chkShowPassword
            // 
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Bahnschrift Light", 10F);
            chkShowPassword.ForeColor = Color.FromArgb(180, 190, 211);
            chkShowPassword.Location = new Point(32, 358);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(180, 24);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
            // 
            // lblBrandFeatures
            // 
            lblBrandFeatures.BackColor = Color.Transparent;
            lblBrandFeatures.Font = new Font("Bahnschrift", 10F);
            lblBrandFeatures.ForeColor = Color.FromArgb(180, 190, 211);
            lblBrandFeatures.Location = new Point(48, 494);
            lblBrandFeatures.Name = "lblBrandFeatures";
            lblBrandFeatures.Size = new Size(384, 60);
            lblBrandFeatures.TabIndex = 0;
            lblBrandFeatures.Text = "STUDENTS  /  COURSES  /  ENROLLMENT";
            // 
            // lblBrandFooter
            // 
            lblBrandFooter.BackColor = Color.Transparent;
            lblBrandFooter.Font = new Font("Bahnschrift Light", 10F);
            lblBrandFooter.ForeColor = Color.FromArgb(150, 160, 185);
            lblBrandFooter.Location = new Point(48, 658);
            lblBrandFooter.Name = "lblBrandFooter";
            lblBrandFooter.Size = new Size(384, 32);
            lblBrandFooter.TabIndex = 1;
            lblBrandFooter.Text = "Your academic workspace, connected.";
            // 
            // lblLoginFooter
            // 
            lblLoginFooter.Font = new Font("Bahnschrift Light", 9F);
            lblLoginFooter.ForeColor = Color.FromArgb(150, 160, 185);
            lblLoginFooter.Location = new Point(24, 676);
            lblLoginFooter.Name = "lblLoginFooter";
            lblLoginFooter.Size = new Size(612, 24);
            lblLoginFooter.TabIndex = 1;
            lblLoginFooter.Text = "S.M.A.R.T  |  Teacher Academic Monitoring Portal";
            lblLoginFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogoLogin
            // 
            picLogoLogin.BackColor = Color.Transparent;
            picLogoLogin.BackgroundImage = (Image)resources.GetObject("picLogoLogin.BackgroundImage");
            picLogoLogin.BackgroundImageLayout = ImageLayout.Zoom;
            picLogoLogin.Location = new Point(96, 80);
            picLogoLogin.Name = "picLogoLogin";
            picLogoLogin.Size = new Size(112, 112);
            picLogoLogin.TabIndex = 2;
            picLogoLogin.TabStop = false;
            // 
            // lblSMART
            // 
            lblSMART.BackColor = Color.Transparent;
            lblSMART.Font = new Font("Bahnschrift", 35F, FontStyle.Bold);
            lblSMART.ForeColor = Color.FromArgb(233, 69, 96);
            lblSMART.Location = new Point(44, 220);
            lblSMART.Name = "lblSMART";
            lblSMART.Size = new Size(388, 64);
            lblSMART.TabIndex = 14;
            lblSMART.Text = "S.M.A.R.T";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 33, 62);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
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
            lblMSAPOP.BackColor = Color.Transparent;
            lblMSAPOP.Font = new Font("Bahnschrift Light", 12F);
            lblMSAPOP.ForeColor = Color.FromArgb(180, 190, 211);
            lblMSAPOP.Location = new Point(48, 380);
            lblMSAPOP.Name = "lblMSAPOP";
            lblMSAPOP.Size = new Size(384, 70);
            lblMSAPOP.TabIndex = 16;
            lblMSAPOP.Text = "Manage students, attendance, and performance in one place.";
            // 
            // lblTAMP
            // 
            lblTAMP.BackColor = Color.Transparent;
            lblTAMP.Font = new Font("Bahnschrift", 16F);
            lblTAMP.ForeColor = Color.White;
            lblTAMP.Location = new Point(48, 298);
            lblTAMP.Name = "lblTAMP";
            lblTAMP.Size = new Size(384, 76);
            lblTAMP.TabIndex = 15;
            lblTAMP.Text = "Teacher Academic\r\nMonitoring Portal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(loginCard);
            panel2.Controls.Add(lblLoginFooter);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(480, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 720);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1140, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 680);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S.M.A.R.T - Sign in";
            loginCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CustomPanel loginCard;
        private Label lblLoginBadge;
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
