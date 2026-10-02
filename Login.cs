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
    public partial class Login : Form
    {
        // ---------- Left panel (your existing code, unchanged) ----------
        private Control[] groupControls;
        private Dictionary<Control, Point> offsets = new Dictionary<Control, Point>();
        private Size groupSize;

        // Set to true if you also want the group centered vertically
        private const bool CenterVertically = false;
        private const int TopMargin = 220; // used when CenterVertically is false

        public Login()
        {
            InitializeComponent();

            // ---------- Right panel: keeps the login controls in place when resizing ----------
            // Must be created right after InitializeComponent(), while panel2 still has its designed size.
            new CenteredLoginControls(panel2,
                lblWelcome, lblSign, lblUsername, lblPassword, rBtnLogin, lblCreateAcc, linkLabelSignUp, rTbUsername, rTbPassword);

            // ---------- Left panel (your existing code) ----------
            groupControls = new Control[] { picLogoLogin, lblSMART, lblTAMP, lblMSAPOP };

            Load += (s, e) =>
            {
                CaptureLayout();
                CenterGroup();
            };

            panel1.Resize += (s, e) => CenterGroup();

            // ---------- Accounts: log in and redirect (see Login.Auth.cs) ----------
            InitializeAuth();
        }

        // Remembers where each control sits relative to the group's top-left corner
        private void CaptureLayout()
        {
            int minX = groupControls.Min(c => c.Left);
            int minY = groupControls.Min(c => c.Top);
            int maxX = groupControls.Max(c => c.Right);
            int maxY = groupControls.Max(c => c.Bottom);

            groupSize = new Size(maxX - minX, maxY - minY);

            foreach (Control c in groupControls)
                offsets[c] = new Point(c.Left - minX, c.Top - minY);
        }

        private void CenterGroup()
        {
            if (offsets.Count == 0) return;

            int startX = (panel1.ClientSize.Width - groupSize.Width) / 2;
            int startY = CenterVertically
                ? (panel1.ClientSize.Height - groupSize.Height) / 2
                : TopMargin;

            foreach (Control c in groupControls)
            {
                c.Left = startX + offsets[c].X;
                c.Top = startY + offsets[c].Y;
            }
        }

        // ---------- Event handlers ----------
        private void txtTAMP_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenSignup();   // defined in Login.Auth.cs
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); // Closes the app completely when user clicks X
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}