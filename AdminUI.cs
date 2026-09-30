namespace SMART
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void flpSignOutAdmin_Paint(object sender, PaintEventArgs e)
        {
            Session.CurrentUser = null;
            Close();
        }
    }
}
