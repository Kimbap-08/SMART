using System.Text.RegularExpressions;

namespace SMART
{
    internal sealed class InstructorCredentialsDialog : Form
    {
        private readonly TextBox username = new();
        private readonly TextBox password = new();
        private readonly TextBox confirmPassword = new();
        private readonly bool requirePassword;

        internal string Username => username.Text.Trim();
        internal string Password => password.Text;

        internal InstructorCredentialsDialog(string? currentUsername, bool requirePassword)
        {
            this.requirePassword = requirePassword;
            Text = "Instructor Login Credentials";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(430, 330);
            BackColor = Color.FromArgb(13, 17, 38);
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 10);

            var heading = new Label { Text = "Instructor Login", Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = Color.White, AutoSize = true, Location = new Point(24, 18) };
            var hint = new Label { Text = requirePassword ? "Set a username and initial password." : "Change the username or enter a new password. Leave it blank to keep the current password.", ForeColor = Color.FromArgb(165, 170, 190), Location = new Point(26, 56), Size = new Size(378, 42) };
            Controls.Add(heading);
            Controls.Add(hint);
            AddField("Username", username, 104);
            AddField(requirePassword ? "Initial Password" : "New Password", password, 163);
            AddField("Confirm Password", confirmPassword, 222);
            password.UseSystemPasswordChar = true;
            confirmPassword.UseSystemPasswordChar = true;

            var showPassword = new CheckBox { Text = "Show password", ForeColor = Color.White, AutoSize = true, Location = new Point(26, 280) };
            showPassword.CheckedChanged += (_, _) => password.UseSystemPasswordChar = confirmPassword.UseSystemPasswordChar = !showPassword.Checked;
            var cancel = new RoundedButton { Text = "Cancel", BackColor = Color.FromArgb(60, 60, 80), ForeColor = Color.White, Size = new Size(92, 36), Location = new Point(207, 280), BorderRadius = 5, BorderSize = 0, DialogResult = DialogResult.Cancel };
            var save = new RoundedButton { Text = "Save", BackColor = Color.FromArgb(233, 69, 96), ForeColor = Color.White, Size = new Size(92, 36), Location = new Point(310, 280), BorderRadius = 5, BorderSize = 0 };
            save.Click += Save_Click;
            Controls.Add(showPassword);
            Controls.Add(cancel);
            Controls.Add(save);
            AcceptButton = save;
            CancelButton = cancel;
            username.Text = currentUsername ?? "";
        }

        private void AddField(string labelText, TextBox field, int y)
        {
            Controls.Add(new Label { Text = labelText, ForeColor = Color.White, AutoSize = true, Location = new Point(26, y) });
            field.Location = new Point(26, y + 22);
            field.Size = new Size(378, 28);
            field.BackColor = Color.FromArgb(22, 33, 62);
            field.ForeColor = Color.White;
            field.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(field);
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
