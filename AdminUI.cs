namespace SMART
{
    public partial class AdminUI : Form
    {
        // The fill color of the selected menu row. Change it to the color you chose.
        private static readonly Color ActiveRowColor = Color.FromArgb(233, 69, 96);

        private RoundedFlowLayoutPanel[] menuRows;

        public AdminUI()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            SetupMenu();

            // Clicking anything in the Sign Out row signs the user out
            WireClicks(flpSignOutAdmin, (s, e) => SignOut());
        }

        // ---------- Menu rows: clicking one fills it with the chosen color ----------

        private void SetupMenu()
        {
            // The rows that work like tabs. Sign Out is not one of them, it just signs out.
            menuRows = new[]
            {
                flpDashboardAdmin, flpStudentsAdmin, flpTeachersAdmin,
                flpCoursesAdmin, flpEnrollmentAdmin
            };

            foreach (RoundedFlowLayoutPanel row in menuRows)
            {
                RoundedFlowLayoutPanel current = row;   // each handler remembers its own row
                WireClicks(row, (s, e) => SelectRow(current));
            }

            SelectRow(flpDashboardAdmin);   // start on Dashboard. Delete this line to start with nothing selected.
        }

        private void SelectRow(RoundedFlowLayoutPanel selected)
        {
            foreach (RoundedFlowLayoutPanel row in menuRows)
            {
                // The selected row gets the color, the others take the sidebar's color
                row.BackColor = (row == selected) ? ActiveRowColor : row.Parent.BackColor;
            }

            // Show the page that belongs to the selected row here
        }

        // Makes a control, and everything inside it (icon, text, inner panels), react to clicks
        private static void WireClicks(Control control, EventHandler handler)
        {
            control.Cursor = Cursors.Hand;
            control.Click += handler;

            foreach (Control child in control.Controls)
                WireClicks(child, handler);
        }

        // ---------- Sign out ----------

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}