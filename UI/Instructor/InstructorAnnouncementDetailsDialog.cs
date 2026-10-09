using System.Drawing;
using System.Windows.Forms;
namespace SMART
{

public partial class InstructorAnnouncementDetailsDialog : Form
{
    public InstructorAnnouncementDetailsDialog()
    {
        InitializeComponent();
    }

    private void Close_Click(object? sender, EventArgs e)
    {
        Close();
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

}
