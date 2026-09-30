namespace SMART
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Load += (s, e) => MessageBox.Show($"Client: {ClientSize}");
        }

    }
}
