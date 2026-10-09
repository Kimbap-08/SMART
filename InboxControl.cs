using System.Data;
using System.Data.SqlClient;

namespace SMART;

public sealed class InboxControl : UserControl
{
    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private static readonly Color GreenColor = Color.FromArgb(0, 170, 0);
    private readonly FlowLayoutPanel messageList = new();
    private readonly ComboBox filterPicker = new();
    private readonly CheckBox unreadOnly = new();
    private readonly Label unreadCountLabel = new();
    private readonly Label fromLabel = new();
    private readonly Label subjectLabel = new();
    private readonly Label sentLabel = new();
    private readonly RichTextBox bodyView = new();
    private readonly RichTextBox replyInput = new();
    private readonly CustomButton replyButton = new();
    private readonly CustomButton resolveButton = new();
    private readonly Label statusLabel = new();
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
        BackColor = BgColor;
        BuildLayout();
        Load += (_, _) => LoadMessages();
    }

    private void BuildLayout()
    {
        var root = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2, BackColor = BgColor, Padding = new Padding(4) };
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        var heading = new Label
        {
            Text = "📬 Instructor Inbox", Dock = DockStyle.Fill, ForeColor = Color.White,
            Font = new Font("Segoe UI", 21F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft
        };
        var split = new SplitContainer
        {
            Dock = DockStyle.Fill, Size = new Size(1000, 650), Orientation = Orientation.Vertical, SplitterWidth = 8,
            SplitterDistance = 320, FixedPanel = FixedPanel.Panel1, Panel1MinSize = 280, Panel2MinSize = 400,
            BorderStyle = BorderStyle.None
        };
        BuildMessageListPanel(split.Panel1);
        BuildDetailPanel(split.Panel2);
        root.Controls.Add(heading, 0, 0);
        root.Controls.Add(split, 0, 1);
        Controls.Add(root);
    }

    private void BuildMessageListPanel(Control host)
    {
        host.BackColor = BgColor;
        var filterPanel = new CustomPanel
        {
            Dock = DockStyle.Top, Height = 86, BackColor = CardColor,
            BorderColor = CardColor, BorderWidth = 0, CornerRadius = 7, Padding = new Padding(9)
        };
        unreadCountLabel.Dock = DockStyle.Top;
        unreadCountLabel.Height = 25;
        unreadCountLabel.ForeColor = AccentColor;
        unreadCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        filterPicker.DropDownStyle = ComboBoxStyle.DropDownList;
        filterPicker.Items.AddRange(new object[] { "All", "Pending", "Resolved" });
        filterPicker.SelectedIndex = 0;
        filterPicker.Width = 120;
        filterPicker.BackColor = BgColor;
        filterPicker.ForeColor = Color.White;
        filterPicker.SelectedIndexChanged += (_, _) => RenderMessages();
        unreadOnly.Text = "Unread only";
        unreadOnly.ForeColor = TextGray;
        unreadOnly.BackColor = CardColor;
        unreadOnly.AutoSize = true;
        unreadOnly.CheckedChanged += (_, _) => RenderMessages();
        var filterRow = new FlowLayoutPanel { Dock = DockStyle.Fill, WrapContents = false, BackColor = CardColor, Padding = new Padding(0, 3, 0, 0) };
        filterRow.Controls.Add(filterPicker);
        filterRow.Controls.Add(unreadOnly);
        var refresh = MakeButton("Refresh", Color.FromArgb(55, 62, 86), 75, 28);
        refresh.Click += (_, _) => LoadMessages();
        filterRow.Controls.Add(refresh);
        filterPanel.Controls.Add(filterRow);
        filterPanel.Controls.Add(unreadCountLabel);
        messageList.Dock = DockStyle.Fill;
        messageList.FlowDirection = FlowDirection.TopDown;
        messageList.WrapContents = false;
        messageList.AutoScroll = true;
        messageList.BackColor = BgColor;
        host.Controls.Add(messageList);
        host.Controls.Add(filterPanel);
    }

    private void BuildDetailPanel(Control host)
    {
        host.BackColor = BgColor;
        var detail = new CustomPanel
        {
            Dock = DockStyle.Fill, BackColor = CardColor, BorderColor = CardColor,
            BorderWidth = 0, CornerRadius = 8, Padding = new Padding(16)
        };
        var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 9, BackColor = CardColor };
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 1));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 42));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
        StyleDetailLabel(fromLabel, Color.White, true);
        StyleDetailLabel(subjectLabel, Color.White, false);
        StyleDetailLabel(sentLabel, TextGray, false);
        layout.Controls.Add(fromLabel, 0, 0);
        layout.Controls.Add(subjectLabel, 0, 1);
        layout.Controls.Add(sentLabel, 0, 2);
        layout.Controls.Add(new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(50, 60, 82), Height = 1 }, 0, 3);
        StyleRichText(bodyView, true);
        bodyView.ScrollBars = RichTextBoxScrollBars.Vertical;
        layout.Controls.Add(bodyView, 0, 4);
        layout.Controls.Add(new Label { Text = "Admin Reply", Dock = DockStyle.Fill, ForeColor = TextGray, TextAlign = ContentAlignment.MiddleLeft }, 0, 5);
        StyleRichText(replyInput, false);
        replyInput.ScrollBars = RichTextBoxScrollBars.Vertical;
        layout.Controls.Add(replyInput, 0, 6);
        var actions = new FlowLayoutPanel { Dock = DockStyle.Fill, BackColor = CardColor, WrapContents = false };
        replyButton.Text = "📤 SEND REPLY";
        replyButton.BackColor = Color.FromArgb(0, 140, 200);
        replyButton.ForeColor = Color.White;
        replyButton.Size = new Size(140, 36);
        replyButton.BorderRadius = 6;
        replyButton.BorderSize = 0;
        replyButton.Click += (_, _) => SendReply();
        resolveButton.Text = "✅ MARK RESOLVED";
        resolveButton.BackColor = Color.FromArgb(0, 120, 50);
        resolveButton.ForeColor = Color.White;
        resolveButton.Size = new Size(160, 36);
        resolveButton.BorderRadius = 6;
        resolveButton.BorderSize = 0;
        resolveButton.Click += (_, _) => MarkResolved();
        actions.Controls.Add(replyButton);
        actions.Controls.Add(resolveButton);
        layout.Controls.Add(actions, 0, 7);
        statusLabel.Dock = DockStyle.Fill;
        statusLabel.ForeColor = TextGray;
        layout.Controls.Add(statusLabel, 0, 8);
        SetDetailEnabled(false);
        detail.Controls.Add(layout);
        host.Controls.Add(detail);
    }

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
        if (messageList.IsDisposed) return;
        messageList.SuspendLayout();
        foreach (Control old in messageList.Controls.Cast<Control>().ToArray())
        {
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
                Size = new Size(Math.Max(250, messageList.ClientSize.Width - 22), 75),
                BackColor = background, BorderColor = border, BorderWidth = 2,
                CornerRadius = 6, Margin = new Padding(3, 4, 3, 3), Padding = new Padding(9, 3, 4, 2),
                Cursor = Cursors.Hand, Tag = item.Id
            };
            var who = new Label
            {
                Text = (item.IsResolved ? "✅ " : !item.IsRead ? "⏳ " : "👁 ") + item.Instructor,
                Dock = DockStyle.Top, Height = 20, ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold), AutoEllipsis = true, Tag = item.Id, Cursor = Cursors.Hand
            };
            var subject = new Label
            {
                Text = item.Subject, Dock = DockStyle.Top, Height = 20, ForeColor = TextGray,
                Font = new Font("Segoe UI", 8F), AutoEllipsis = true, Tag = item.Id, Cursor = Cursors.Hand
            };
            var sent = new Label
            {
                Text = item.SentAt.ToString("MMM d h:mm tt"), Dock = DockStyle.Fill, ForeColor = TextGray,
                Font = new Font("Segoe UI", 7F), Tag = item.Id, Cursor = Cursors.Hand
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
        fromLabel.Enabled = enabled;
        subjectLabel.Enabled = enabled;
        sentLabel.Enabled = enabled;
        bodyView.Enabled = enabled;
        replyInput.Enabled = enabled;
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

    private static void StyleDetailLabel(Label label, Color color, bool bold)
    {
        label.Dock = DockStyle.Fill;
        label.ForeColor = color;
        label.Font = new Font("Segoe UI", 10F, bold ? FontStyle.Bold : FontStyle.Regular);
        label.AutoEllipsis = true;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }

    private static void StyleRichText(RichTextBox box, bool readOnly)
    {
        box.BackColor = BgColor;
        box.ForeColor = Color.White;
        box.Font = new Font("Segoe UI", 10F);
        box.BorderStyle = BorderStyle.None;
        box.ReadOnly = readOnly;
    }

    private static CustomButton MakeButton(string text, Color color, int width, int height) => new()
    {
        Text = text, BackColor = color, ForeColor = Color.White, Size = new Size(width, height),
        BorderRadius = 6, BorderSize = 0, Cursor = Cursors.Hand, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
    };
}
