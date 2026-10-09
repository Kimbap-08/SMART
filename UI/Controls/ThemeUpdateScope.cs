using System.Runtime.InteropServices;

namespace SMART;

internal sealed class ThemeUpdateScope : IDisposable
{
    private const int SetRedraw = 0x000B;
    private readonly Control root;
    private readonly List<Control> controls = new();
    private readonly List<Control> paused = new();

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr window, int message, IntPtr parameter, IntPtr data);

    internal ThemeUpdateScope(Control root)
    {
        this.root = root;
        Pause(root);
    }

    private void Pause(Control control)
    {
        controls.Add(control);
        control.SuspendLayout();
        if (control.IsHandleCreated && control.Visible)
        {
            SendMessage(control.Handle, SetRedraw, IntPtr.Zero, IntPtr.Zero);
            paused.Add(control);
        }
        foreach (Control child in control.Controls) Pause(child);
    }

    public void Dispose()
    {
        for (int index = controls.Count - 1; index >= 0; index--)
            if (!controls[index].IsDisposed) controls[index].ResumeLayout(true);
        foreach (Control control in paused)
            if (!control.IsDisposed && control.IsHandleCreated)
                SendMessage(control.Handle, SetRedraw, new IntPtr(1), IntPtr.Zero);
        if (!root.IsDisposed) root.Invalidate(true);
    }
}
