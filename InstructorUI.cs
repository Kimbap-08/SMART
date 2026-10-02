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
    public partial class InstructorUI : Form
    {
        public InstructorUI()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            // Clicking the panel, its icon, or its text signs the user out
            foreach (Control c in new Control[] { flpSignOutInstructor, picSignOutInstructor, lblSignOutInstructor })
            {
                c.Cursor = Cursors.Hand;
                c.Click += (s, e) => SignOut();
            }
        }

        private void SignOut()
        {
            Session.CurrentUser = null;
            Close();   // the Login form sees that nobody is signed in and shows itself again
        }

        // Left empty on purpose. The designer still connects this method to the panel's
        // Paint event, and Paint runs every time the panel is drawn, so it must not sign out.
        private void flpSignOutInstructor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}