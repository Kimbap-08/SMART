using System.Drawing;
using System.Windows.Forms;

namespace SMART
{
    internal static class AdminPanelLayout
    {
        // Match the margins, toolbar rows and spacing used by AdminCourses.
        internal static void ArrangeToolbar(Form form, Panel header, Panel toolbar,
            Control search, Label separator, Label caption, params Control[] controls)
        {
            int width = Math.Max(300, form.ClientSize.Width - 24);
            toolbar.SetBounds(12, header.Bottom + 6, width, 82);
            separator.AutoSize = caption.AutoSize = false;
            separator.Text = "|";
            separator.TextAlign = caption.TextAlign = ContentAlignment.MiddleCenter;
            separator.Font = caption.Font;
            separator.ForeColor = caption.ForeColor = Color.White;
            separator.BackColor = caption.BackColor = Color.Transparent;
            separator.Visible = caption.Visible = true;
            int x = 12, y = 16;
            int TextWidth(Control control) => TextRenderer.MeasureText(control.Text,
                control.Font, Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix).Width;
            foreach (Control control in controls)
            {
                int itemWidth = control == search ? Math.Min(375, width - 24)
                    : control == controls[1] ? 104 : control == controls[2] ? 112
                    : control == separator ? 24 : control == caption ? 104 : TextWidth(control) + 28;
                int requiredWidth = control == separator
                    ? itemWidth + 104 + TextWidth(controls[5]) + 28 + 16
                    : itemWidth;
                if (x > 12 && x + requiredWidth > width - 12) { x = 12; y += 50; }
                control.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                control.SetBounds(x, y, itemWidth, 40);
                x += itemWidth + 8;
            }
            toolbar.Height = y + 52;
        }
    }
}
