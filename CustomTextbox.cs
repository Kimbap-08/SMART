using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SMART
{
    [DefaultEvent("TextChanged")]
    public class RoundedTextBox : UserControl
    {
        private readonly TextBox inner = new TextBox();

        private int borderRadius = 15;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        private Color focusBorderColor = Color.DodgerBlue;
        private Color fillColor = Color.White;
        private bool isFocused;

        public RoundedTextBox()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;   // corners show whatever is behind the control
            Font = new Font("Segoe UI", 10F);
            Size = new Size(250, 40);

            inner.BorderStyle = BorderStyle.None;
            inner.BackColor = fillColor;
            inner.Font = Font;

            inner.Enter += (s, e) => { isFocused = true; Invalidate(); };
            inner.Leave += (s, e) => { isFocused = false; Invalidate(); };

            // Forward the events you are most likely to use
            inner.TextChanged += (s, e) => OnTextChanged(e);
            inner.KeyDown += (s, e) => OnKeyDown(e);
            inner.KeyPress += (s, e) => OnKeyPress(e);

            Controls.Add(inner);
            UpdateInnerLayout();
        }

        // ---------- Appearance properties ----------

        [Category("Rounded Appearance"), DefaultValue(15)]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = Math.Max(0, value); UpdateInnerLayout(); Invalidate(); }
        }

        [Category("Rounded Appearance"), DefaultValue(2)]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = Math.Max(0, value); UpdateInnerLayout(); Invalidate(); }
        }

        [Category("Rounded Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("Rounded Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FocusBorderColor
        {
            get => focusBorderColor;
            set { focusBorderColor = value; Invalidate(); }
        }

        [Category("Rounded Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FillColor
        {
            get => fillColor;
            set { fillColor = value; inner.BackColor = value; Invalidate(); }
        }

        // ---------- TextBox properties passed through ----------

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get => inner.Text;
            set => inner.Text = value;
        }

        [Category("Behavior"), DefaultValue(false)]
        public bool Multiline
        {
            get => inner.Multiline;
            set { inner.Multiline = value; UpdateInnerLayout(); }
        }

        [Category("Behavior"), DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get => inner.UseSystemPasswordChar;
            set => inner.UseSystemPasswordChar = value;
        }

        [Category("Behavior"), DefaultValue('\0')]
        public char PasswordChar
        {
            get => inner.PasswordChar;
            set => inner.PasswordChar = value;
        }

        [Category("Behavior"), DefaultValue(false)]
        public bool ReadOnly
        {
            get => inner.ReadOnly;
            set => inner.ReadOnly = value;
        }

        [Category("Behavior"), DefaultValue(32767)]
        public int MaxLength
        {
            get => inner.MaxLength;
            set => inner.MaxLength = value;
        }

        [Category("Behavior"), DefaultValue("")]
        [Description("Hint text shown while the box is empty. Disappears when the user types.")]
        public string PlaceholderText
        {
            get => inner.PlaceholderText;
            set => inner.PlaceholderText = value;
        }

        // ---------- Layout and painting ----------

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            inner.Font = Font;
            UpdateInnerLayout();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            inner.ForeColor = ForeColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateInnerLayout();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            inner.Focus();   // clicking the rounded border focuses the text
        }

        private void UpdateInnerLayout()
        {
            if (inner == null) return;

            int padX = borderSize + Math.Max(6, borderRadius / 2);
            inner.Left = padX;
            inner.Width = Math.Max(10, Width - padX * 2);

            if (inner.Multiline)
            {
                int padY = borderSize + 6;
                inner.Top = padY;
                inner.Height = Math.Max(10, Height - padY * 2);
            }
            else
            {
                inner.Top = (Height - inner.Height) / 2;   // vertically centered text
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Inset by half the pen width so the border isn't clipped
            float half = borderSize / 2f;
            var rect = new RectangleF(half, half, Width - borderSize - 1, Height - borderSize - 1);

            using (GraphicsPath path = CreateRoundedPath(rect, borderRadius))
            using (var fill = new SolidBrush(fillColor))
            {
                e.Graphics.FillPath(fill, path);

                if (borderSize > 0)
                {
                    using (var pen = new Pen(isFocused ? focusBorderColor : borderColor, borderSize))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
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