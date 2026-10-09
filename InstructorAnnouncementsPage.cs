using System.Data;
using System.Data.SqlClient;

namespace SMART;

public sealed partial class InstructorAnnouncementsPage : Form
{
    private string username = string.Empty;
    private Action? onRead;

    public InstructorAnnouncementsPage()
    {
        InitializeComponent();
        cards.SizeChanged += (_, _) => ResizeCards();
    }

    public InstructorAnnouncementsPage(string username, Action onRead) : this()
    {
        this.username = username;
        this.onRead = onRead;
        Load += (_, _) => LoadAnnouncements();
    }

    private void btnRefresh_Click(object? sender, EventArgs e) => LoadAnnouncements();

    private void LoadAnnouncements()
    {
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            string program;
            using (var instructor = new SqlCommand(
                "SELECT Program FROM dbo.Instructors WHERE Username=@Username", connection))
            {
                instructor.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = username;
                program = Convert.ToString(instructor.ExecuteScalar()) ?? string.Empty;
            }
            using (var markRead = new SqlCommand(@"INSERT INTO dbo.InstructorAnnouncementReads (AnnouncementId, Username)
                SELECT a.AnnouncementId, @Username
                FROM dbo.Announcements a
                WHERE a.IsActive=1 AND (a.TargetProgram=N'All Instructors' OR a.TargetProgram=@Program)
                  AND NOT EXISTS (
                    SELECT 1 FROM dbo.InstructorAnnouncementReads r
                    WHERE r.AnnouncementId=a.AnnouncementId AND r.Username=@Username)", connection))
            {
                markRead.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = username;
                markRead.Parameters.Add("@Program", SqlDbType.NVarChar, 150).Value = program;
                markRead.ExecuteNonQuery();
            }

            using var command = new SqlCommand(@"SELECT AnnouncementId, Title, Message, Priority, PostedAt, IsActive, PostedBy
                FROM dbo.Announcements WHERE IsActive=1
                  AND (TargetProgram=N'All Instructors' OR TargetProgram=@Program)
                ORDER BY CASE Priority WHEN N'Urgent' THEN 1 WHEN N'Important' THEN 2 ELSE 3 END,
                    PostedAt DESC", connection);
            command.Parameters.Add("@Program", SqlDbType.NVarChar, 150).Value = program;
            using var reader = command.ExecuteReader();
            foreach (Control oldCard in cards.Controls.Cast<Control>().ToArray()) oldCard.Dispose();
            cards.Controls.Clear();
            if (!reader.HasRows)
            {
                status.Text = "No announcements at this time.";
                onRead?.Invoke();
                return;
            }

            status.Text = "";
            while (reader.Read())
            {
                cards.Controls.Add(CreateCard(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetBoolean(5),
                    reader.IsDBNull(6) ? "Administration" : reader.GetString(6)));
            }
            ResizeCards();
            onRead?.Invoke();
        }
        catch (SqlException ex)
        {
            status.Text = "Announcements could not be loaded: " + ex.Message;
        }
    }

    private InstructorAnnouncementCard CreateCard(int id, string title, string message, string priority,
        DateTime postedAt, bool active, string sender)
    {
        var card = new InstructorAnnouncementCard
        {
            Width = Math.Max(400, cards.ClientSize.Width - 28),
            Margin = new Padding(0, 0, 0, 12)
        };
        card.SetAnnouncement(title, message, priority, postedAt, active);
        card.CardClicked += (_, _) =>
        {
            using var dialog = new InstructorAnnouncementDetailsDialog();
            dialog.SetAnnouncement(title, postedAt, sender, message);
            var owner = FindForm();
            if (owner is null) dialog.ShowDialog();
            else dialog.ShowDialog(owner);
        };
        return card;
    }

    private void ResizeCards()
    {
        int width = Math.Max(400, cards.ClientSize.Width - 28);
        foreach (Control control in cards.Controls)
        {
            if (control is InstructorAnnouncementCard card) card.Width = width;
        }
    }
}
