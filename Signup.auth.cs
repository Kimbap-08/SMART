using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SMART
{
    // Sign-up logic, kept in its own file so SIgnup.cs stays small.
    // NOTE: your form's class is spelled SIgnup (capital I), so it must be spelled that way here.
    public partial class SIgnup
    {
        // Filled in after a successful sign-up so the Login form can pre-fill it
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RegisteredUsername { get; private set; }

        private void InitializeAuth()
        {
            AcceptButton = rBtnSignUp;              // Enter key presses the Sign Up button
            rTbPasswordSignUp.UseSystemPasswordChar = true;
            rTbConfirmPasswordSignUp.UseSystemPasswordChar = true;

            rBtnSignUp.Click += RBtnSignUp_Click;
        }

        private void RBtnSignUp_Click(object sender, EventArgs e)
        {
            string username = rTbUsernameSignUp.Text.Trim();
            string email = rTbEmailSignUp.Text.Trim();
            string password = rTbPasswordSignUp.Text;
            string confirm = rTbConfirmPasswordSignUp.Text;

            if (password != confirm)
            {
                MessageBox.Show("The passwords do not match.",
                    "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = false;
            string error = null;

            try
            {
                ok = AuthService.Register(username, email, password, out error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not create your account:\n\n" + ex.Message,
                    "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ok)
            {
                MessageBox.Show(error, "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisteredUsername = username;
            MessageBox.Show("Your account was created. You can now log in.",
                "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoBackToLogin();
        }
    }
}