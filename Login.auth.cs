using System;
using System.Windows.Forms;

namespace SMART
{
    // Login logic, kept in its own file so Login.cs stays small.
    public partial class Login
    {
        private void InitializeAuth()
        {
            try
            {
                AuthService.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The account database could not be opened:\n\n" + ex.Message,
                    "S.M.A.R.T", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AcceptButton = rBtnLogin;               // Enter key presses the Log in button
            rTbPassword.UseSystemPasswordChar = true;
            rBtnLogin.Click += RBtnLogin_Click;
        }

        private void RBtnLogin_Click(object sender, EventArgs e)
        {
            string username = rTbUsername.Text.Trim();
            string password = rTbPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter your username and password.",
                    "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User user;
            try
            {
                user = AuthService.Login(username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not check your account:\n\n" + ex.Message,
                    "Log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user == null)
            {
                // Same message for a wrong username and a wrong password, on purpose
                MessageBox.Show("Invalid username or password.",
                    "Log in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rTbPassword.Text = "";
                return;
            }

            Session.CurrentUser = user;
            OpenDashboard(user);
        }

        // Sends admins to AdminUI and instructors to InstructorUI
        private void OpenDashboard(User user)
        {
            Form dashboard;

            switch (user.Role)
            {
                case UserRole.Admin:
                    dashboard = new AdminUI();
                    break;
                case UserRole.Instructor:
                    dashboard = new InstructorUI();
                    break;
                default:
                    MessageBox.Show("This account has no access.", "Log in",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Session.CurrentUser = null;
                    return;
            }

            dashboard.FormClosed += (s, args) =>
            {
                if (Session.CurrentUser == null)
                {
                    // The user signed out, so show the login screen again
                    rTbUsername.Text = "";
                    rTbPassword.Text = "";
                    Show();
                }
                else
                {
                    // The window was closed, so exit the program
                    Close();
                }
            };

            Hide();
            dashboard.Show();
        }

    }
}
