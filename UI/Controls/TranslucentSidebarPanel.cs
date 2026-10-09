using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace SMART;

public class TranslucentSidebarPanel : CustomPanel
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

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        var image = Parent?.BackgroundImage;
        if (image == null || Width <= 0 || Height <= 0)
        {
            base.OnPaintBackground(e);
            return;
        }

        e.Graphics.Clear(BackColor);
        e.Graphics.DrawImage(image,
            new Rectangle(-Left, -Top, Parent!.ClientSize.Width, Parent.ClientSize.Height));
        int alpha = (int)Math.Round((1F - imageOpacity) * 255F);
        using var overlay = new LinearGradientBrush(ClientRectangle,
            Color.FromArgb(alpha, BackColor), Color.FromArgb(0, BackColor),
            LinearGradientMode.Horizontal);
        e.Graphics.FillRectangle(overlay, ClientRectangle);
    }
}
