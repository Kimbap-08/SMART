using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SMART
{
    // Named wrapper used by newer admin pages while preserving the existing theme.
    public class CustomButton : RoundedButton { }

    public class RoundedButton : Button
    {
        private int borderRadius = 20;
        private int borderSize = 0;
        private Color borderColor = Color.White;
        private Color hoverColor = Color.Empty;     // Empty = automatically lighter than BackColor
        private Color pressedColor = Color.Empty;   // Empty = automatically darker than BackColor
        private bool isHover;
        private bool isPressed;

        public RoundedButton()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.FromArgb(0, 120, 215);
            ForeColor = Color.White;
            Font = new Font("Segoe UI Semibold", 10F);
            Cursor = Cursors.Hand;
        }

        // ---------- Appearance properties ----------

        [Category("Rounded Appearance"), DefaultValue(20)]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Rounded Appearance"), DefaultValue(0)]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = Math.Max(0, value); Invalidate(); }
        }

        [Category("Rounded Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("Rounded Appearance")]
        [Description("Background while the mouse is over the button. Leave empty for an automatic lighter shade.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor
        {
            get => hoverColor;
            set { hoverColor = value; Invalidate(); }
        }

        [Category("Rounded Appearance")]
        [Description("Background while the button is pressed. Leave empty for an automatic darker shade.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color PressedColor
        {
            get => pressedColor;
            set { pressedColor = value; Invalidate(); }
        }

        // ---------- Mouse state ----------

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHover = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHover = false;
            isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                isPressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            isPressed = false;
            Invalidate();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        // ---------- Painting ----------

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Paint what's behind the button so the corners blend in
            g.Clear(Parent?.BackColor ?? SystemColors.Control);

            Color fill = GetFillColor();
            Color textColor = Enabled ? ForeColor : SystemColors.GrayText;

            float half = borderSize / 2f;
            var rect = new RectangleF(half, half, Width - borderSize - 1, Height - borderSize - 1);

            using (GraphicsPath path = CreateRoundedPath(rect, borderRadius))
            using (var brush = new SolidBrush(fill))
            {
                g.FillPath(brush, path);

                if (borderSize > 0)
                {
                    using (var pen = new Pen(borderColor, borderSize))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, textColor,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.SingleLine |
                TextFormatFlags.EndEllipsis |
                TextFormatFlags.NoPadding);
        }

        private Color GetFillColor()
        {
            if (!Enabled)
                return ControlPaint.Light(BackColor, 0.6f);

            if (isPressed)
                return pressedColor != Color.Empty ? pressedColor : ControlPaint.Dark(BackColor, 0.1f);

            if (isHover)
                return hoverColor != Color.Empty ? hoverColor : ControlPaint.Light(BackColor, 0.2f);

            return BackColor;
        }

        private static GraphicsPath CreateRoundedPath(RectangleF rect, int radius)
        {
            var path = new GraphicsPath();

            float d = Math.Min(radius * 2f, Math.Min(rect.Width, rect.Height));
            if (d <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);                          // top-left
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);                  // top-right
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);           // bottom-right
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);                  // bottom-left
            path.CloseFigure();
            return path;
        }
    }
}
