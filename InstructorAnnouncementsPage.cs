using System.Data;
using System.Data.SqlClient;

namespace SMART;

internal sealed class InstructorAnnouncementsPage : UserControl
{
    private static readonly Color BackgroundColor = Color.FromArgb(13, 17, 38);
    private static readonly Color SurfaceColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color YellowColor = Color.FromArgb(255, 170, 0);
    private static readonly Color MutedColor = Color.FromArgb(150, 150, 170);
    private readonly string username;
    private readonly Action onRead;
    private readonly FlowLayoutPanel cards = new();
    private readonly Label status = new();

    internal InstructorAnnouncementsPage(string username, Action onRead)
    {
        this.username = username;
        this.onRead = onRead;
        BackColor = BackgroundColor;
        BuildLayout();
        Load += (_, _) => LoadAnnouncements();
    }

    private void BuildLayout()
    {
        var heading = new Label
        {
            Text = "📢 Announcements from Administration", Dock = DockStyle.Top, Height = 44,
            ForeColor = Color.White, Font = new Font("Segoe UI", 21F, FontStyle.Bold)
        };
        var subtitle = new Label
        {
            Text = "Updates and notices for instructors", Dock = DockStyle.Top, Height = 30,
            ForeColor = MutedColor, Font = new Font("Segoe UI", 10F)
        };
        var toolbar = new Panel { Dock = DockStyle.Top, Height = 42, BackColor = BackgroundColor };
        var refresh = new CustomButton
        {
            Text = "🔄 Refresh", Size = new Size(105, 32), Location = new Point(0, 4),
            BackColor = Color.FromArgb(48, 63, 93), ForeColor = Color.White,
            BorderRadius = 5, BorderSize = 0, Font = new Font("Segoe UI", 9F, FontStyle.Bold)
        };
        refresh.Click += (_, _) => LoadAnnouncements();
        toolbar.Controls.Add(refresh);
        status.Dock = DockStyle.Top;
        status.Height = 28;
        status.ForeColor = MutedColor;
        status.Font = new Font("Segoe UI", 10F);
        status.TextAlign = ContentAlignment.MiddleCenter;
        cards.Dock = DockStyle.Fill;
        cards.AutoScroll = true;
        cards.FlowDirection = FlowDirection.TopDown;
        cards.WrapContents = false;
        cards.BackColor = BackgroundColor;
        cards.Padding = new Padding(0, 8, 12, 8);
        cards.SizeChanged += (_, _) => ResizeCards();
        Controls.Add(cards);
        Controls.Add(status);
        Controls.Add(toolbar);
        Controls.Add(subtitle);
        Controls.Add(heading);
    }

    private void LoadAnnouncements()
    {
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            using (var markRead = new SqlCommand(@"INSERT INTO dbo.InstructorAnnouncementReads (AnnouncementId, Username)
                SELECT a.AnnouncementId, @Username
                FROM dbo.Announcements a
                WHERE a.IsActive=1 AND NOT EXISTS (
                    SELECT 1 FROM dbo.InstructorAnnouncementReads r
                    WHERE r.AnnouncementId=a.AnnouncementId AND r.Username=@Username)", connection))
            {
                markRead.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = username;
                markRead.ExecuteNonQuery();
            }

            using var command = new SqlCommand(@"SELECT AnnouncementId, Title, Message, Priority, PostedAt, IsActive
                FROM dbo.Announcements WHERE IsActive=1
                ORDER BY CASE Priority WHEN N'Urgent' THEN 1 WHEN N'Important' THEN 2 ELSE 3 END,
                    PostedAt DESC", connection);
            using var reader = command.ExecuteReader();
            foreach (Control oldCard in cards.Controls.Cast<Control>().ToArray()) oldCard.Dispose();
            cards.Controls.Clear();
            if (!reader.HasRows)
            {
                status.Text = "No announcements at this time.";
                onRead();
                return;
            }

            status.Text = "";
            while (reader.Read())
            {
                cards.Controls.Add(CreateCard(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetBoolean(5)));
            }
            ResizeCards();
            onRead();
        }
        catch (SqlException ex)
        {
            status.Text = "Announcements could not be loaded: " + ex.Message;
        }
    }

    private CustomPanel CreateCard(int id, string title, string message, string priority,
        DateTime postedAt, bool active)
    {
        Color priorityColor = priority switch
        {
            "Urgent" => AccentColor,
            "Important" => YellowColor,
            _ => MutedColor
        };
        var card = new CustomPanel
        {
            Width = Math.Max(400, cards.ClientSize.Width - 28), Height = 142,
            Margin = new Padding(0, 0, 0, 12), Padding = new Padding(14),
            BackColor = SurfaceColor, BorderColor = priority == "Normal" ? Color.FromArgb(48, 63, 93) : priorityColor,
            BorderWidth = priority == "Normal" ? 1 : 2, CornerRadius = 8
        };
        var titleLabel = new Label
        {
            Name = "announcementTitle",
            Text = title, Location = new Point(14, 12), Size = new Size(Math.Max(250, card.Width - 220), 26),
            ForeColor = Color.White, Font = new Font("Segoe UI", 13F, FontStyle.Bold),
            BackColor = Color.Transparent, AutoEllipsis = true
        };
        var priorityLabel = new Label
        {
            Name = "announcementPriority",
            Text = priority.ToUpperInvariant(), Location = new Point(card.Width - 180, 14), Size = new Size(105, 22),
            ForeColor = priorityColor, Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleRight
        };
        var activeLabel = new Label
        {
            Name = "announcementActive",
            Text = active ? "ACTIVE" : "INACTIVE", Location = new Point(card.Width - 72, 14), Size = new Size(58, 22),
            ForeColor = active ? Color.LightGreen : MutedColor, Font = new Font("Segoe UI", 8F, FontStyle.Bold),
            BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleRight
        };
        var messageLabel = new Label
        {
            Name = "announcementMessage",
            Text = message, Location = new Point(14, 46), Size = new Size(card.Width - 36, 58),
            ForeColor = MutedColor, Font = new Font("Segoe UI", 10F),
            BackColor = Color.Transparent, AutoEllipsis = true
        };
        var dateLabel = new Label
        {
            Name = "announcementDate",
            Text = postedAt.ToString("MMM dd, yyyy  h:mm tt"),
            Location = new Point(14, 112), Size = new Size(card.Width - 36, 18),
            ForeColor = Color.FromArgb(85, 85, 119), Font = new Font("Segoe UI", 8F),
            BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleRight
        };
        card.Controls.Add(titleLabel);
        card.Controls.Add(priorityLabel);
        card.Controls.Add(activeLabel);
        card.Controls.Add(messageLabel);
        card.Controls.Add(dateLabel);
        return card;
    }

    private void ResizeCards()
    {
        int width = Math.Max(400, cards.ClientSize.Width - 28);
        foreach (Control control in cards.Controls)
        {
            if (control is not CustomPanel card) continue;
            card.Width = width;
            foreach (Control child in card.Controls)
            {
                if (child.Name == "announcementTitle") child.Width = Math.Max(250, width - 220);
                else if (child.Name == "announcementMessage" || child.Name == "announcementDate") child.Width = width - 36;
                else if (child.Name == "announcementPriority") child.Left = width - 180;
                else if (child.Name == "announcementActive") child.Left = width - 72;
            }
        }
    }
}
