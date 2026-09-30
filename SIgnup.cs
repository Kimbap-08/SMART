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
        public SIgnup()
        {
            InitializeComponent();
            new CenteredLoginControls(pnlMainSignUp);   // all the sign-up fields and the button
            new CenteredLoginControls(pnlLeftSignUp).CenterExactly();    // the logo and its text
        }

        private void linkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Create instance of Login form
            Login loginForm = new Login();

            // 2. Keep form position consistent
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = this.Location;

            // 3. Show Login form and hide Signup form
            loginForm.Show();
            this.Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); // Closes the app completely when user clicks X
        }
    }
}
