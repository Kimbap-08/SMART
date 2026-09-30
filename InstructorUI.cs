using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace SMART
{
    public partial class InstructorUI : Form
    {
        public InstructorUI()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void flpSignOutInstructor_Paint(object sender, PaintEventArgs e)
        {
            Session.CurrentUser = null;
            Close();
        }
    }
}
