using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
using System.Text.RegularExpressions;

namespace SMART
{
    public partial class InstructorCredentialsDialog : Form
    {
    #region Windows Form Designer generated code
    private System.Windows.Forms.Label designerControl1 = null!;
    private System.Windows.Forms.Label designerControl2 = null!;
    private System.Windows.Forms.Label designerControl3 = null!;
    private System.Windows.Forms.TextBox username = null!;
    private System.Windows.Forms.Label designerControl5 = null!;
    private System.Windows.Forms.TextBox password = null!;
    private System.Windows.Forms.Label designerControl7 = null!;
    private System.Windows.Forms.TextBox confirmPassword = null!;
    private System.Windows.Forms.CheckBox designerControl9 = null!;
    private SMART.RoundedButton designerControl10 = null!;
    private SMART.RoundedButton designerControl11 = null!;

    private void InitializeComponent()
    {
            designerControl1 = new System.Windows.Forms.Label();
            designerControl2 = new System.Windows.Forms.Label();
            designerControl3 = new System.Windows.Forms.Label();
            username = new System.Windows.Forms.TextBox();
            designerControl5 = new System.Windows.Forms.Label();
            password = new System.Windows.Forms.TextBox();
            designerControl7 = new System.Windows.Forms.Label();
            confirmPassword = new System.Windows.Forms.TextBox();
            designerControl9 = new System.Windows.Forms.CheckBox();
            designerControl10 = new SMART.RoundedButton();
            designerControl11 = new SMART.RoundedButton();
            SuspendLayout();
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(446, 369);
            this.Dock = (System.Windows.Forms.DockStyle)0;
            this.Anchor = (System.Windows.Forms.AnchorStyles)5;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            this.AutoSize = false;
            this.AutoScroll = false;
            this.Text = "Instructor Login Credentials";
            this.TabIndex = 0;
            this.TabStop = true;
            this.Enabled = true;
            this.DialogResult = (System.Windows.Forms.DialogResult)0;
            this.StartPosition = (System.Windows.Forms.FormStartPosition)4;
            this.FormBorderStyle = (System.Windows.Forms.FormBorderStyle)3;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.ClientSize = new System.Drawing.Size(430, 330);
            designerControl1.Name = "designerControl1";
            designerControl1.Location = new System.Drawing.Point(24, 18);
            designerControl1.Size = new System.Drawing.Size(173, 35);
            designerControl1.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl1.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl1.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl1.Font = new System.Drawing.Font("Segoe UI", 16F, (System.Drawing.FontStyle)1);
            designerControl1.AutoSize = true;
            designerControl1.Text = "Instructor Login";
            designerControl1.TabIndex = 0;
            designerControl1.TabStop = false;
            designerControl1.Enabled = true;
            designerControl1.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl1.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl1.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl1.AutoEllipsis = false;
            designerControl1.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl2.Name = "designerControl2";
            designerControl2.Location = new System.Drawing.Point(26, 56);
            designerControl2.Size = new System.Drawing.Size(378, 42);
            designerControl2.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl2.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl2.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl2.ForeColor = System.Drawing.Color.FromArgb(255, 165, 170, 190);
            designerControl2.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl2.AutoSize = false;
            designerControl2.Text = "Change the username or enter a new password. Leave it blank to keep the current password.";
            designerControl2.TabIndex = 1;
            designerControl2.TabStop = false;
            designerControl2.Enabled = true;
            designerControl2.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl2.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl2.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl2.AutoEllipsis = false;
            designerControl2.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl3.Name = "designerControl3";
            designerControl3.Location = new System.Drawing.Point(26, 104);
            designerControl3.Size = new System.Drawing.Size(66, 23);
            designerControl3.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl3.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl3.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl3.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl3.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl3.AutoSize = true;
            designerControl3.Text = "Username";
            designerControl3.TabIndex = 2;
            designerControl3.TabStop = false;
            designerControl3.Enabled = true;
            designerControl3.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl3.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl3.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl3.AutoEllipsis = false;
            designerControl3.MinimumSize = new System.Drawing.Size(0, 0);
            username.Name = "username";
            username.Location = new System.Drawing.Point(26, 126);
            username.Size = new System.Drawing.Size(378, 25);
            username.Dock = (System.Windows.Forms.DockStyle)0;
            username.Anchor = (System.Windows.Forms.AnchorStyles)5;
            username.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            username.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            username.BackColor = System.Drawing.Color.FromArgb(255, 26, 26, 46);
            username.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            username.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            username.AutoSize = true;
            username.Text = "";
            username.TabIndex = 3;
            username.TabStop = true;
            username.Enabled = true;
            username.BorderStyle = (System.Windows.Forms.BorderStyle)1;
            username.PlaceholderText = "";
            username.Multiline = false;
            username.ReadOnly = false;
            username.MaxLength = 32767;
            username.UseSystemPasswordChar = false;
            username.PasswordChar = (char)0;
            username.TextAlign = (System.Windows.Forms.HorizontalAlignment)0;
            username.ScrollBars = (System.Windows.Forms.ScrollBars)0;
            username.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl5.Name = "designerControl5";
            designerControl5.Location = new System.Drawing.Point(26, 163);
            designerControl5.Size = new System.Drawing.Size(93, 23);
            designerControl5.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl5.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl5.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl5.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl5.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl5.AutoSize = true;
            designerControl5.Text = "New Password";
            designerControl5.TabIndex = 4;
            designerControl5.TabStop = false;
            designerControl5.Enabled = true;
            designerControl5.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl5.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl5.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl5.AutoEllipsis = false;
            designerControl5.MinimumSize = new System.Drawing.Size(0, 0);
            password.Name = "password";
            password.Location = new System.Drawing.Point(26, 185);
            password.Size = new System.Drawing.Size(378, 25);
            password.Dock = (System.Windows.Forms.DockStyle)0;
            password.Anchor = (System.Windows.Forms.AnchorStyles)5;
            password.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            password.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            password.BackColor = System.Drawing.Color.FromArgb(255, 26, 26, 46);
            password.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            password.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            password.AutoSize = true;
            password.Text = "";
            password.TabIndex = 5;
            password.TabStop = true;
            password.Enabled = true;
            password.BorderStyle = (System.Windows.Forms.BorderStyle)1;
            password.PlaceholderText = "";
            password.Multiline = false;
            password.ReadOnly = false;
            password.MaxLength = 32767;
            password.UseSystemPasswordChar = true;
            password.PasswordChar = (char)42;
            password.TextAlign = (System.Windows.Forms.HorizontalAlignment)0;
            password.ScrollBars = (System.Windows.Forms.ScrollBars)0;
            password.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl7.Name = "designerControl7";
            designerControl7.Location = new System.Drawing.Point(26, 222);
            designerControl7.Size = new System.Drawing.Size(114, 23);
            designerControl7.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl7.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl7.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl7.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl7.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl7.AutoSize = true;
            designerControl7.Text = "Confirm Password";
            designerControl7.TabIndex = 6;
            designerControl7.TabStop = false;
            designerControl7.Enabled = true;
            designerControl7.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl7.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl7.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl7.AutoEllipsis = false;
            designerControl7.MinimumSize = new System.Drawing.Size(0, 0);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Location = new System.Drawing.Point(26, 244);
            confirmPassword.Size = new System.Drawing.Size(378, 25);
            confirmPassword.Dock = (System.Windows.Forms.DockStyle)0;
            confirmPassword.Anchor = (System.Windows.Forms.AnchorStyles)5;
            confirmPassword.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            confirmPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            confirmPassword.BackColor = System.Drawing.Color.FromArgb(255, 26, 26, 46);
            confirmPassword.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            confirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            confirmPassword.AutoSize = true;
            confirmPassword.Text = "";
            confirmPassword.TabIndex = 7;
            confirmPassword.TabStop = true;
            confirmPassword.Enabled = true;
            confirmPassword.BorderStyle = (System.Windows.Forms.BorderStyle)1;
            confirmPassword.PlaceholderText = "";
            confirmPassword.Multiline = false;
            confirmPassword.ReadOnly = false;
            confirmPassword.MaxLength = 32767;
            confirmPassword.UseSystemPasswordChar = true;
            confirmPassword.PasswordChar = (char)42;
            confirmPassword.TextAlign = (System.Windows.Forms.HorizontalAlignment)0;
            confirmPassword.ScrollBars = (System.Windows.Forms.ScrollBars)0;
            confirmPassword.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl9.Name = "designerControl9";
            designerControl9.Location = new System.Drawing.Point(26, 280);
            designerControl9.Size = new System.Drawing.Size(118, 24);
            designerControl9.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl9.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl9.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl9.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl9.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl9.AutoSize = true;
            designerControl9.Text = "Show password";
            designerControl9.TabIndex = 8;
            designerControl9.TabStop = true;
            designerControl9.Enabled = true;
            designerControl9.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl9.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl9.AutoEllipsis = false;
            designerControl9.Checked = false;
            designerControl9.CheckAlign = (System.Drawing.ContentAlignment)16;
            designerControl9.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl10.Name = "designerControl10";
            designerControl10.Location = new System.Drawing.Point(207, 280);
            designerControl10.Size = new System.Drawing.Size(92, 36);
            designerControl10.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl10.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl10.BackColor = System.Drawing.Color.FromArgb(255, 60, 60, 80);
            designerControl10.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, (System.Drawing.FontStyle)0);
            designerControl10.AutoSize = false;
            designerControl10.Text = "Cancel";
            designerControl10.TabIndex = 9;
            designerControl10.TabStop = true;
            designerControl10.Enabled = true;
            designerControl10.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl10.BorderRadius = 5;
            designerControl10.BorderSize = 0;
            designerControl10.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl10.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl10.AutoEllipsis = false;
            designerControl10.DialogResult = (System.Windows.Forms.DialogResult)2;
            designerControl10.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl11.Name = "designerControl11";
            designerControl11.Location = new System.Drawing.Point(310, 280);
            designerControl11.Size = new System.Drawing.Size(92, 36);
            designerControl11.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl11.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl11.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl11.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, (System.Drawing.FontStyle)0);
            designerControl11.AutoSize = false;
            designerControl11.Text = "Save";
            designerControl11.TabIndex = 10;
            designerControl11.TabStop = true;
            designerControl11.Enabled = true;
            designerControl11.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl11.BorderRadius = 5;
            designerControl11.BorderSize = 0;
            designerControl11.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl11.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl11.AutoEllipsis = false;
            designerControl11.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl11.MinimumSize = new System.Drawing.Size(0, 0);
            this.Controls.Add(designerControl1);
            this.Controls.Add(designerControl2);
            this.Controls.Add(designerControl3);
            this.Controls.Add(username);
            this.Controls.Add(designerControl5);
            this.Controls.Add(password);
            this.Controls.Add(designerControl7);
            this.Controls.Add(confirmPassword);
            this.Controls.Add(designerControl9);
            this.Controls.Add(designerControl10);
            this.Controls.Add(designerControl11);
            designerControl9.CheckedChanged += designerControl9_CheckedChanged;
            designerControl11.Click += Save_Click;
            AcceptButton = designerControl11;
            CancelButton = designerControl10;
            ResumeLayout(false);
    }
    #endregion

    private void designerControl9_CheckedChanged(object? sender, EventArgs e)
    {
        password.UseSystemPasswordChar = confirmPassword.UseSystemPasswordChar = !designerControl9.Checked;
    }

        private readonly bool requirePassword;

        internal string Username => username.Text.Trim();
        internal string Password => password.Text;

        public InstructorCredentialsDialog()
        {
            this.InitializeComponent();
        }

        internal InstructorCredentialsDialog(string? currentUsername, bool requirePassword) : this()
        {
            this.requirePassword = requirePassword;
            designerControl2.Text = requirePassword
                ? "Set a username and initial password."
                : "Change the username or enter a new password. Leave it blank to keep the current password.";
            designerControl5.Text = requirePassword ? "Initial Password" : "New Password";
            username.Text = currentUsername ?? "";
        }



        private void Save_Click(object? sender, EventArgs e)
        {
            if (!Regex.IsMatch(Username, @"^[A-Za-z0-9_.]{3,30}$"))
            {
                MessageBox.Show("Username must be 3–30 characters using letters, numbers, dots, or underscores.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Focus();
                return;
            }
            if (Username.Equals("admin", StringComparison.OrdinalIgnoreCase) || Username.Equals("administrator", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("That username is reserved.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Focus();
                return;
            }
            if (requirePassword && password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
                return;
            }
            if (password.Text.Length > 0 && password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
                return;
            }
            if (password.Text != confirmPassword.Text)
            {
                MessageBox.Show("The passwords do not match.", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                confirmPassword.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
