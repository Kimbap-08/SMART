using System.Data;
using System.Data.SqlClient;

namespace SMART
{

public sealed partial class InboxControl : UserControl
{
    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private static readonly Color GreenColor = Color.FromArgb(0, 170, 0);
    private List<AssistMessage> messages = new();
    private AssistMessage? selectedMessage;

    public event EventHandler? UnreadCountChanged;

    private sealed class AssistMessage
    {
        public int Id { get; init; }
        public string Instructor { get; init; } = "";
        public string Subject { get; init; } = "";
        public string Body { get; init; } = "";
        public DateTime SentAt { get; init; }
        public bool IsRead { get; set; }
        public bool IsResolved { get; set; }
        public string? AdminReply { get; set; }
    }

    public InboxControl()
    {
        InitializeComponent();
        filterPicker.SelectedIndex = 0;
    }

    private bool IsDesignPreview => DesignMode ||
        System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;

    private void InboxControl_Load(object? sender, EventArgs e)
    {
        if (IsDesignPreview) return;
        messageCardTemplate.Visible = false;
        SetDetailEnabled(false);
        LoadMessages();
    }

    private void FilterChanged(object? sender, EventArgs e)
    {
        if (!IsDesignPreview && IsHandleCreated) RenderMessages();
    }

    private void RefreshButton_Click(object? sender, EventArgs e) => LoadMessages();
    private void ReplyButton_Click(object? sender, EventArgs e) => SendReply();
    private void ResolveButton_Click(object? sender, EventArgs e) => MarkResolved();

    private void LoadMessages(int? selectId = null)
    {
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT MessageId, InstructorName, Subject, Message, SentAt,
                    IsRead, IsResolved, AdminReply
                FROM dbo.AssistMessages ORDER BY IsRead ASC, SentAt DESC", connection);
            using var reader = command.ExecuteReader();
            messages = new List<AssistMessage>();
            while (reader.Read())
                messages.Add(new AssistMessage
                {
                    Id = reader.GetInt32(0), Instructor = reader.GetString(1), Subject = reader.GetString(2),
                    Body = reader.GetString(3), SentAt = reader.GetDateTime(4), IsRead = reader.GetBoolean(5),
                    IsResolved = reader.GetBoolean(6), AdminReply = reader.IsDBNull(7) ? null : reader.GetString(7)
                });
            RenderMessages();
            UpdateUnreadCount();
            if (selectId.HasValue)
            {
                var item = messages.FirstOrDefault(row => row.Id == selectId.Value);
                if (item != null) ShowMessage(item);
            }
            statusLabel.Text = "";
        }
        catch (SqlException ex)
        {
            messages.Clear();
            RenderMessages();
            statusLabel.Text = "Could not load inbox: " + ex.Message;
            statusLabel.ForeColor = AccentColor;
            SetDetailEnabled(false);
        }
    }

    private void RenderMessages()
    {
        if (messageList.IsDisposed || IsDesignPreview) return;
        messageCardTemplate.Visible = false;
        messageList.SuspendLayout();
        foreach (Control old in messageList.Controls.Cast<Control>().ToArray())
        {
            if (old == messageCardTemplate) continue;
            messageList.Controls.Remove(old);
            old.Dispose();
        }
        IEnumerable<AssistMessage> filtered = messages;
        if (unreadOnly.Checked) filtered = filtered.Where(item => !item.IsRead);
        string filter = Convert.ToString(filterPicker.SelectedItem) ?? "All";
        if (filter == "Pending") filtered = filtered.Where(item => !item.IsResolved);
        else if (filter == "Resolved") filtered = filtered.Where(item => item.IsResolved);
        foreach (var item in filtered)
        {
            Color background = item.IsResolved ? Color.FromArgb(15, 35, 20)
                : !item.IsRead ? Color.FromArgb(40, 28, 50) : CardColor;
            Color border = item.IsResolved ? GreenColor : !item.IsRead ? AccentColor : Color.FromArgb(75, 85, 105);
            var card = new CustomPanel
            {
                Size = new Size(Math.Max(250, messageList.ClientSize.Width - 22), messageCardTemplate.Height),
                BackColor = Color.FromArgb(178, background), BorderColor = border, BorderWidth = 2,
                CornerRadius = messageCardTemplate.CornerRadius, Margin = messageCardTemplate.Margin, Padding = messageCardTemplate.Padding,
                Cursor = Cursors.Hand, Tag = item.Id
            };
            var who = new Label
            {
                BackColor = Color.Transparent,
                Text = (item.IsResolved ? "✅ " : !item.IsRead ? "⏳ " : "👁 ") + item.Instructor,
                Dock = DockStyle.Top, Height = 20, ForeColor = Color.White,
                Font = messageInstructorTemplate.Font, AutoEllipsis = true, Tag = item.Id, Cursor = Cursors.Hand
            };
            var subject = new Label
            {
                BackColor = Color.Transparent,
                Text = item.Subject, Dock = DockStyle.Top, Height = 20, ForeColor = TextGray,
                Font = messageSubjectTemplate.Font, AutoEllipsis = true, Tag = item.Id, Cursor = Cursors.Hand
            };
            var sent = new Label
            {
                BackColor = Color.Transparent,
                Text = item.SentAt.ToString("MMM d h:mm tt"), Dock = DockStyle.Fill, ForeColor = TextGray,
                Font = messageSentTemplate.Font, Tag = item.Id, Cursor = Cursors.Hand
            };
            card.Controls.Add(sent);
            card.Controls.Add(subject);
            card.Controls.Add(who);
            WireMessageCard(card);
            messageList.Controls.Add(card);
        }
        messageList.ResumeLayout(true);
    }

    private void WireMessageCard(Control control)
    {
        control.Click += (_, _) =>
        {
            if (!int.TryParse(Convert.ToString(control.Tag), out int id)) return;
            var item = messages.FirstOrDefault(row => row.Id == id);
            if (item != null) ShowMessage(item);
        };
        foreach (Control child in control.Controls) WireMessageCard(child);
    }

    private void ShowMessage(AssistMessage item)
    {
        selectedMessage = item;
        if (!item.IsRead)
        {
            try
            {
                using var connection = OpenConnection();
                using var command = new SqlCommand("UPDATE dbo.AssistMessages SET IsRead=1 WHERE MessageId=@id AND IsRead=0", connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = item.Id;
                command.ExecuteNonQuery();
                item.IsRead = true;
                UpdateUnreadCount();
                RenderMessages();
                UnreadCountChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (SqlException ex) { statusLabel.Text = "Could not mark message as read: " + ex.Message; }
        }
        fromLabel.Text = "From: " + item.Instructor;
        subjectLabel.Text = "Subject: " + item.Subject;
        sentLabel.Text = "Sent: " + item.SentAt.ToString("MMM d, yyyy h:mm tt");
        bodyView.Text = item.Body;
        replyInput.Text = item.AdminReply ?? "";
        SetDetailEnabled(!item.IsResolved);
        statusLabel.Text = item.IsResolved ? "This message is resolved." : "";
        statusLabel.ForeColor = TextGray;
    }

    private void SendReply()
    {
        if (selectedMessage == null || selectedMessage.IsResolved) return;
        string reply = replyInput.Text.Trim();
        if (reply.Length == 0) { statusLabel.Text = "Enter a reply first."; statusLabel.ForeColor = AccentColor; return; }
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"UPDATE dbo.AssistMessages
                SET AdminReply=@reply, RepliedAt=GETDATE(), IsRead=1 WHERE MessageId=@id", connection);
            command.Parameters.Add("@reply", SqlDbType.NVarChar, -1).Value = reply;
            command.Parameters.Add("@id", SqlDbType.Int).Value = selectedMessage.Id;
            command.ExecuteNonQuery();
            selectedMessage.AdminReply = reply;
            selectedMessage.IsRead = true;
            statusLabel.Text = "Reply sent.";
            statusLabel.ForeColor = Color.LimeGreen;
            RenderMessages();
            UpdateUnreadCount();
            UnreadCountChanged?.Invoke(this, EventArgs.Empty);
        }
        catch (SqlException ex) { statusLabel.Text = "Could not send reply: " + ex.Message; statusLabel.ForeColor = AccentColor; }
    }

    private void MarkResolved()
    {
        if (selectedMessage == null || selectedMessage.IsResolved) return;
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand("UPDATE dbo.AssistMessages SET IsResolved=1, IsRead=1 WHERE MessageId=@id", connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = selectedMessage.Id;
            command.ExecuteNonQuery();
            selectedMessage.IsResolved = true;
            selectedMessage.IsRead = true;
            SetDetailEnabled(false);
            statusLabel.Text = "Message marked resolved.";
            statusLabel.ForeColor = Color.LimeGreen;
            RenderMessages();
            UpdateUnreadCount();
            UnreadCountChanged?.Invoke(this, EventArgs.Empty);
        }
        catch (SqlException ex) { statusLabel.Text = "Could not resolve message: " + ex.Message; statusLabel.ForeColor = AccentColor; }
    }

    private void UpdateUnreadCount()
    {
        int unread = messages.Count(item => !item.IsRead);
        unreadCountLabel.Text = $"📬 {unread} unread messages";
        unreadCountLabel.ForeColor = unread > 0 ? AccentColor : TextGray;
        UnreadCountChanged?.Invoke(this, EventArgs.Empty);
    }

    private void SetDetailEnabled(bool enabled)
    {
        // Keep labels and text areas enabled so Windows retains their dark theme.
        // ReadOnly blocks editing without replacing colors with disabled colors.
        fromLabel.Enabled = true;
        subjectLabel.Enabled = true;
        sentLabel.Enabled = true;
        bodyView.Enabled = true;
        bodyView.ReadOnly = true;
        replyInput.Enabled = true;
        replyInput.ReadOnly = !enabled;
        replyButton.Enabled = enabled;
        resolveButton.Enabled = enabled;
        if (!enabled && selectedMessage == null)
        {
            fromLabel.Text = "Select a message to view its details.";
            subjectLabel.Text = "";
            sentLabel.Text = "";
            bodyView.Clear();
            replyInput.Clear();
        }
    }

    private SqlConnection OpenConnection()
    {
        var connection = new SqlConnection(DatabaseConnection.ConnectionString);
        try { DatabaseConnection.Open(connection); return connection; }
        catch { connection.Dispose(); throw; }
    }

}
}
