using System.Windows.Forms;

namespace SMART;

public class StableScrollPanel : Panel
{
    public StableScrollPanel()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
    }

    protected override void OnScroll(ScrollEventArgs e)
    {
        base.OnScroll(e);
        Invalidate(true);
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        base.OnMouseWheel(e);
        Invalidate(true);
    }
}

public class StableFlowLayoutPanel : FlowLayoutPanel
{
    public StableFlowLayoutPanel()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
    }

    protected override void OnScroll(ScrollEventArgs e)
    {
        base.OnScroll(e);
        Invalidate(true);
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        base.OnMouseWheel(e);
        Invalidate(true);
    }
}
