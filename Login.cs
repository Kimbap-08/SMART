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
        public Login()
        {
            InitializeComponent();
            Resize += (s, e) => ArrangeLoginLayout();
            VisibleChanged += (s, e) => { if (Visible) chkShowPassword.Checked = false; };
            ArrangeLoginLayout();
            InitializeAuth();
        }

        private void ArrangeLoginLayout()
        {
            panel1.Width = Math.Min(480, (int)(ClientSize.Width * .42));
            int brandTop = Math.Max(40, (panel1.Height - 560) / 2);
            int brandWidth = Math.Max(240, panel1.Width - 96);
            // Compensate for the larger title font's leading glyph padding.
            lblSMART.SetBounds(44, brandTop + 140, brandWidth + 4, 64);
            int titleWidth = TextRenderer.MeasureText(lblSMART.Text, lblSMART.Font,
                Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix).Width;
            picLogoLogin.SetBounds(lblSMART.Left + (Math.Min(titleWidth, lblSMART.Width) - 112) / 2,
                brandTop, 112, 112);
            lblTAMP.SetBounds(48, brandTop + 218, brandWidth, 76);
            lblMSAPOP.SetBounds(48, brandTop + 300, brandWidth, 70);
            lblBrandFeatures.SetBounds(48, brandTop + 414, brandWidth, 60);
            lblBrandFooter.SetBounds(48, panel1.Height - 62, brandWidth, 32);

            int cardWidth = Math.Min(480, Math.Max(360, panel2.Width - 80));
            loginCard.SetBounds((panel2.Width - cardWidth) / 2,
                Math.Max(24, (panel2.Height - 540) / 2 - 12), cardWidth, 540);
            int contentWidth = cardWidth - 64;
            foreach (Control control in new Control[] { lblLoginBadge, lblWelcome, lblSign,
                lblUsername, lblPassword, rTbUsername, rTbPassword, rBtnLogin })
                control.Width = contentWidth;
            lblLoginFooter.SetBounds(24, panel2.Height - 44, panel2.Width - 48, 24);
            panel1.Invalidate(true);
            panel2.Invalidate(true);
        }

        private void ChkShowPassword_CheckedChanged(object? sender, EventArgs e) =>
            rTbPassword.UseSystemPasswordChar = !chkShowPassword.Checked;

        // ---------- Event handlers ----------
        private void txtTAMP_TextChanged(object sender, EventArgs e)
        {

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
