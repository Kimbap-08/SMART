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
    }
}
