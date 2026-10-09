namespace SMART;

public sealed partial class InstructorAnnouncementDetailsDialog : Form
{
    public InstructorAnnouncementDetailsDialog()
    {
        InitializeComponent();
    }

    public void SetAnnouncement(string title, DateTime postedAt, string sender, string message)
    {
        lblTitle.Text = string.IsNullOrWhiteSpace(title) ? "Announcement" : title;
        lblDate.Text = postedAt.ToString("MMMM d, yyyy  h:mm tt");
        lblSender.Text = "From: " + (string.IsNullOrWhiteSpace(sender) ? "Administration" : sender);
        txtMessage.Text = message ?? string.Empty;
        txtMessage.SelectionStart = 0;
        txtMessage.SelectionLength = 0;
        txtMessage.ScrollToCaret();
    }
}
