using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART
{
    public partial class SIgnup : Form
    {
        private bool returningToLogin;

        public SIgnup()
        {
            InitializeComponent();
            new CenteredLoginControls(pnlMainSignUp);                   // all the sign-up fields and the button
            new CenteredLoginControls(pnlLeftSignUp).CenterExactly();   // the logo and its text

            InitializeAuth();
        }

        // Closes this form and returns to the Login form, which is waiting behind it
        private void GoBackToLogin()
        {
            returningToLogin = true;
            Close();
        }

        private void linkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoBackToLogin();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Exit the whole program only when the user clicks X,
            // not when we are just going back to the Login form.
            if (!returningToLogin)
                Application.Exit();
        }
    }
}