using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace SMART;

public class TranslucentBackgroundPanel : Panel
{
    private float imageOpacity = .45F;

    [Category("Appearance")]
    [DefaultValue(.45F)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public float ImageOpacity
    {
        get => imageOpacity;
        set { imageOpacity = Math.Clamp(value, 0F, 1F); Invalidate(true); }
    }

    public TranslucentBackgroundPanel()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        if (BackgroundImage == null)
        {
            base.OnPaintBackground(e);
            return;
        }
        e.Graphics.Clear(BackColor);
        // Use the parent's image bounds so both panels draw the same continuous image.
        var imageBounds = Parent == null
            ? ClientRectangle
            : new Rectangle(-Left, -Top, Parent.ClientSize.Width, Parent.ClientSize.Height);
        e.Graphics.DrawImage(BackgroundImage, imageBounds);
        if (ClientSize.Width <= 0 || ClientSize.Height <= 0) return;
        // Dim the branding side, fading the overlay out at the panel boundary.
        int overlayAlpha = (int)Math.Round((1F - imageOpacity) * 255F);
        using var overlay = new LinearGradientBrush(ClientRectangle,
            Color.FromArgb(overlayAlpha, BackColor), Color.FromArgb(0, BackColor),
            LinearGradientMode.Horizontal);
        e.Graphics.FillRectangle(overlay, ClientRectangle);
    }
}