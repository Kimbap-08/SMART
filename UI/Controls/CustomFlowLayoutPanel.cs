using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SMART
{
    /// <summary>
    /// A FlowLayoutPanel with rounded corners and an optional border.
    /// The panel's BackColor is the fill color, so you set it like on a normal panel.
    /// </summary>
    [DesignerCategory("Code")]
    [ToolboxItem(true)]
    public class RoundedFlowLayoutPanel : FlowLayoutPanel
    {
        private int borderRadius = 20;
        private int borderSize = 0;
        private Color borderColor = Color.Gray;

        public RoundedFlowLayoutPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);

            
        }

        // ---------- Appearance properties ----------

        [Category("Rounded Appearance"), DefaultValue(20)]
        [Description("How round the corners are. Use half the height for a pill shape.")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Rounded Appearance"), DefaultValue(0)]
        [Description("Thickness of the outline. 0 means no outline.")]
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

        // ---------- Painting ----------

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Paint the actual parent background, including images, instead of a flat color.
            if (Parent != null)
            {
                var state = g.Save();
                try
                {
                    g.TranslateTransform(-Left, -Top);
                    using var parentPaint = new PaintEventArgs(g, Bounds);
                    InvokePaintBackground(Parent, parentPaint);
                }
                finally { g.Restore(state); }
            }
            else base.OnPaintBackground(e);
            if (ClientSize.Width <= borderSize + 1 || ClientSize.Height <= borderSize + 1) return;

            float half = borderSize / 2f;
            var rect = new RectangleF(half, half, ClientSize.Width - borderSize - 1, ClientSize.Height - borderSize - 1);

            using (GraphicsPath path = CreateRoundedPath(rect, borderRadius))
            using (var fill = new SolidBrush(BackColor))
            {
                g.FillPath(fill, path);

                if (borderSize > 0)
                {
                    using (var pen = new Pen(borderColor, borderSize))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }

        // If the panel scrolls, repaint so the rounded background doesn't smear
        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            Invalidate();
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