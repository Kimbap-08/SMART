namespace SMART;

public sealed partial class InstructorAnnouncementCard : UserControl
{
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color YellowColor = Color.FromArgb(255, 170, 0);
    private static readonly Color MutedColor = Color.FromArgb(150, 150, 170);
    private static readonly Color SurfaceColor = Color.FromArgb(22, 33, 62);

    public InstructorAnnouncementCard()
    {
        InitializeComponent();
        WireCardClick(this);
    }

    public event EventHandler? CardClicked;

    public void SetAnnouncement(string title, string message, string priority, DateTime postedAt, bool active)
    {
        Color priorityColor = priority switch
        {
            "Urgent" => AccentColor,
            "Important" => YellowColor,
            _ => MutedColor
        };

        lblTitle.Text = title;
        lblMessage.Text = message;
        lblPriority.Text = priority.ToUpperInvariant();
        lblPriority.ForeColor = priorityColor;
        lblActive.Text = active ? "ACTIVE" : "INACTIVE";
        lblActive.ForeColor = active ? Color.LightGreen : MutedColor;
        lblPostedAt.Text = postedAt.ToString("MMM dd, yyyy  h:mm tt");
        pnlCard.BorderColor = priority == "Normal" ? Color.FromArgb(48, 63, 93) : priorityColor;
        pnlCard.BorderWidth = priority == "Normal" ? 1 : 2;
        pnlCard.BackColor = SurfaceColor;
    }

    private void WireCardClick(Control control)
    {
        control.Cursor = Cursors.Hand;
        control.Click += (_, e) => CardClicked?.Invoke(this, e);
        foreach (Control child in control.Controls) WireCardClick(child);
    }
}
