using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SMART
{
    /// <summary>
    /// Keeps a set of controls in the arrangement you designed, following the
    /// center of their container when it resizes.
    /// Create it right after InitializeComponent(), while the container still has
    /// its designed size. Add .CenterExactly() to center the group perfectly
    /// instead of keeping its designed offset.
    /// </summary>
    public class CenteredLoginControls
    {
        private readonly Control container;
        private readonly Control[] items;
        private readonly Dictionary<Control, Point> offsets = new Dictionary<Control, Point>();
        private int anchorX;   // group's left edge, measured from the container's center
        private int anchorY;   // group's top edge, measured from the container's center

        // Uses every control inside the container, so no names are needed
        public CenteredLoginControls(Control container)
            : this(container, container.Controls.Cast<Control>().ToArray())
        {
        }

        public CenteredLoginControls(Control container, params Control[] items)
        {
            this.container = container;
            this.items = items.Where(c => c != null).ToArray();   // skips any control that doesn't exist
            if (this.items.Length == 0) return;                   // nothing to center

            int minX = this.items.Min(c => c.Left);
            int minY = this.items.Min(c => c.Top);

            foreach (Control c in this.items)
                offsets[c] = new Point(c.Left - minX, c.Top - minY);

            // Remember where the group sits relative to the container's center
            anchorX = minX - container.ClientSize.Width / 2;
            anchorY = minY - container.ClientSize.Height / 2;

            container.Resize += (s, e) => Apply();
        }

        /// <summary>
        /// Centers the group exactly in the container, both horizontally and vertically,
        /// ignoring where it was placed in the designer.
        /// </summary>
        public CenteredLoginControls CenterExactly()
        {
            if (items.Length == 0) return this;

            int width = items.Max(c => c.Right) - items.Min(c => c.Left);
            int height = items.Max(c => c.Bottom) - items.Min(c => c.Top);

            anchorX = -width / 2;
            anchorY = -height / 2;
            Apply();
            return this;
        }

        public void Apply()
        {
            if (items.Length == 0) return;

            int startX = container.ClientSize.Width / 2 + anchorX;
            int startY = container.ClientSize.Height / 2 + anchorY;

            foreach (Control c in items)
            {
                c.Left = startX + offsets[c].X;
                c.Top = startY + offsets[c].Y;
            }
        }
    }
}