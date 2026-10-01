namespace SMART
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            // Clicking the panel, its icon, or its text signs the user out
            foreach (Control c in new Control[] { flpSignOutAdmin, picSignOutAdmin, lblSignOutAdmin })
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
        private void flpSignOutAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}