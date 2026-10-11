using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SMART
{

public partial class InboxControl : System.Windows.Forms.UserControl
{

    #region Windows Form Designer generated code
        private System.ComponentModel.IContainer? components;
        private Panel pnlInboxAdmin = null!;
        private Label subtitle = null!;
        private TableLayoutPanel root = null!;
        private Label heading = null!;
        private SplitContainer split = null!;
        private CustomPanel filterPanel = null!;
        private Label unreadCountLabel = null!;
        private ComboBox filterPicker = null!;
        private CheckBox unreadOnly = null!;
        private FlowLayoutPanel filterRow = null!;
        private CustomButton refreshButton = null!;
        private FlowLayoutPanel messageList = null!;
        private CustomPanel detail = null!;
        private TableLayoutPanel detailLayout = null!;
        private Label fromLabel = null!;
        private Label subjectLabel = null!;
        private Label sentLabel = null!;
        private Panel separator = null!;
        private RichTextBox bodyView = null!;
        private RichTextBox replyInput = null!;
        private Label replyLabel = null!;
        private FlowLayoutPanel actions = null!;
        private CustomButton replyButton = null!;
        private CustomButton resolveButton = null!;
        private Label statusLabel = null!;
        private CustomPanel messageCardTemplate = null!;
        private Label messageInstructorTemplate = null!;
        private Label messageSubjectTemplate = null!;
        private Label messageSentTemplate = null!;
        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlInboxAdmin = new Panel();
            subtitle = new Label();
            root = new TableLayoutPanel();
            heading = new Label();
            split = new SplitContainer();
            filterPanel = new CustomPanel();
            unreadCountLabel = new Label();
            filterPicker = new ComboBox();
            unreadOnly = new CheckBox();
            filterRow = new FlowLayoutPanel();
            refreshButton = new CustomButton();
            messageList = new FlowLayoutPanel();
            detail = new CustomPanel();
            detailLayout = new TableLayoutPanel();
            fromLabel = new Label();
            subjectLabel = new Label();
            sentLabel = new Label();
            separator = new Panel();
            bodyView = new RichTextBox();
            replyInput = new RichTextBox();
            replyLabel = new Label();
            actions = new FlowLayoutPanel();
            replyButton = new CustomButton();
            resolveButton = new CustomButton();
            statusLabel = new Label();
            messageCardTemplate = new CustomPanel();
            messageInstructorTemplate = new Label();
            messageSubjectTemplate = new Label();
            messageSentTemplate = new Label();
            ((System.ComponentModel.ISupportInitialize)split).BeginInit();
            split.Panel1.SuspendLayout();
            split.Panel2.SuspendLayout();
            split.SuspendLayout();
            root.SuspendLayout();
            pnlInboxAdmin.SuspendLayout();
            filterPanel.SuspendLayout();
            filterRow.SuspendLayout();
            messageList.SuspendLayout();
            detail.SuspendLayout();
            detailLayout.SuspendLayout();
            actions.SuspendLayout();
            messageCardTemplate.SuspendLayout();
            SuspendLayout();
            root.Name = "root";
            root.Dock = DockStyle.Fill;
            root.ColumnCount = 1;
            root.RowCount = 1;
            root.BackColor = Color.Transparent;
            root.Padding = new Padding(4);
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            heading.Name = "heading";
            heading.Text = "Instructor Inbox";
            heading.BackColor = Color.Transparent;
            heading.AutoSize = false;
            heading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            heading.Location = new Point(25, 22);
            heading.Size = new Size(1150, 46);
            heading.ForeColor = Color.White;
            heading.TextAlign = ContentAlignment.MiddleLeft;
            heading.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            subtitle.Name = "subtitle";
            subtitle.Text = "View instructor messages, send replies, and resolve requests";
            subtitle.BackColor = Color.Transparent;
            subtitle.ForeColor = Color.White;
            subtitle.Font = new Font("Bahnschrift Light", 10F);
            subtitle.AutoSize = false;
            subtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subtitle.Location = new Point(29, 76);
            subtitle.Size = new Size(1146, 26);
            subtitle.TextAlign = ContentAlignment.MiddleLeft;
            pnlInboxAdmin.Name = "pnlInboxAdmin";
            pnlInboxAdmin.BackColor = Color.Transparent;
            pnlInboxAdmin.Dock = DockStyle.Top;
            pnlInboxAdmin.Location = new Point(0, 0);
            pnlInboxAdmin.Size = new Size(1200, 106);
            pnlInboxAdmin.Controls.Add(subtitle);
            pnlInboxAdmin.Controls.Add(heading);
            split.Name = "split";
            split.BackColor = Color.Transparent;
            split.Size = new Size(1192, 664);
            split.Dock = DockStyle.Fill;
            split.Orientation = Orientation.Vertical;
            split.SplitterWidth = 8;
            split.SplitterDistance = 390;
            split.FixedPanel = FixedPanel.Panel1;
            split.Panel1MinSize = 280;
            split.Panel2MinSize = 400;
            split.BorderStyle = BorderStyle.None;
            split.Panel1.BackColor = Color.Transparent;
            split.Panel2.BackColor = Color.Transparent;
            filterPanel.Name = "filterPanel";
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Height = 86;
            filterPanel.BackColor = Color.FromArgb(178, 22, 33, 62);
            filterPanel.BorderColor = Color.FromArgb(22, 33, 62);
            filterPanel.BorderWidth = 0;
            filterPanel.CornerRadius = 7;
            filterPanel.Padding = new Padding(9);
            unreadCountLabel.Name = "unreadCountLabel";
            unreadCountLabel.BackColor = Color.Transparent;
            unreadCountLabel.Text = "📬 0 unread messages";
            unreadCountLabel.Dock = DockStyle.Top;
            unreadCountLabel.ForeColor = Color.FromArgb(233, 69, 96);
            unreadCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            unreadCountLabel.Height = 25;
            unreadCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            filterPicker.Name = "filterPicker";
            filterPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            filterPicker.DrawMode = DrawMode.OwnerDrawFixed;
            filterPicker.FlatStyle = FlatStyle.Flat;
            filterPicker.ItemHeight = 24;
            filterPicker.DrawItem += Dropdown_DrawItem;
            filterPicker.Font = new Font("Bahnschrift Light", 10F);
            filterPicker.Width = 120;
            filterPicker.BackColor = Color.FromArgb(22, 33, 62);
            filterPicker.ForeColor = Color.White;
            filterPicker.Items.AddRange(new object[] { "All", "Pending", "Resolved" });
            unreadOnly.Name = "unreadOnly";
            unreadOnly.Text = "Unread only";
            unreadOnly.ForeColor = Color.FromArgb(150, 150, 170);
            unreadOnly.BackColor = Color.Transparent;
            unreadOnly.AutoSize = true;
            filterRow.Name = "filterRow";
            filterRow.Dock = DockStyle.Fill;
            filterRow.WrapContents = false;
            filterRow.BackColor = Color.Transparent;
            filterRow.Padding = new Padding(0, 3, 0, 0);
            refreshButton.Name = "refreshButton";
            refreshButton.Text = "Refresh";
            refreshButton.BackColor = Color.FromArgb(55, 62, 86);
            refreshButton.ForeColor = Color.White;
            refreshButton.Size = new Size(75, 28);
            refreshButton.BorderRadius = 6;
            refreshButton.BorderSize = 0;
            refreshButton.Cursor = Cursors.Hand;
            refreshButton.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            filterRow.Controls.Add(filterPicker);
            filterRow.Controls.Add(unreadOnly);
            filterRow.Controls.Add(refreshButton);
            filterPanel.Controls.Add(filterRow);
            filterPanel.Controls.Add(unreadCountLabel);
            messageList.Name = "messageList";
            messageList.Dock = DockStyle.Fill;
            messageList.FlowDirection = FlowDirection.TopDown;
            messageList.WrapContents = false;
            messageList.AutoScroll = true;
            messageList.BackColor = Color.Transparent;
            split.Panel1.Controls.Add(messageList);
            split.Panel1.Controls.Add(filterPanel);
            detail.Name = "detail";
            detail.Dock = DockStyle.Fill;
            detail.BackColor = Color.FromArgb(178, 22, 33, 62);
            detail.BorderColor = Color.FromArgb(22, 33, 62);
            detail.BorderWidth = 0;
            detail.CornerRadius = 8;
            detail.Padding = new Padding(16);
            detailLayout.Name = "detailLayout";
            detailLayout.Dock = DockStyle.Fill;
            detailLayout.ColumnCount = 1;
            detailLayout.RowCount = 9;
            detailLayout.BackColor = Color.Transparent;
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 1));
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 42));
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
            detailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
            fromLabel.Name = "fromLabel";
            fromLabel.BackColor = Color.Transparent;
            fromLabel.Text = "From: Instructor name";
            fromLabel.Dock = DockStyle.Fill;
            fromLabel.ForeColor = Color.White;
            fromLabel.TextAlign = ContentAlignment.MiddleLeft;
            fromLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            fromLabel.AutoEllipsis = true;
            subjectLabel.Name = "subjectLabel";
            subjectLabel.BackColor = Color.Transparent;
            subjectLabel.Text = "Subject: Message subject";
            subjectLabel.Dock = DockStyle.Fill;
            subjectLabel.ForeColor = Color.White;
            subjectLabel.TextAlign = ContentAlignment.MiddleLeft;
            subjectLabel.Font = new Font("Segoe UI", 10F);
            subjectLabel.AutoEllipsis = true;
            sentLabel.Name = "sentLabel";
            sentLabel.BackColor = Color.Transparent;
            sentLabel.Text = "Sent: Message date";
            sentLabel.Dock = DockStyle.Fill;
            sentLabel.ForeColor = Color.FromArgb(150, 150, 170);
            sentLabel.TextAlign = ContentAlignment.MiddleLeft;
            sentLabel.Font = new Font("Segoe UI", 10F);
            sentLabel.AutoEllipsis = true;
            separator.Name = "separator";
            separator.Dock = DockStyle.Fill;
            separator.BackColor = Color.FromArgb(50, 60, 82);
            separator.Height = 1;
            bodyView.Name = "bodyView";
            bodyView.Dock = DockStyle.Fill;
            bodyView.BackColor = Color.FromArgb(26, 26, 46);
            bodyView.ForeColor = Color.White;
            bodyView.Font = new Font("Segoe UI", 10F);
            bodyView.BorderStyle = BorderStyle.None;
            bodyView.ReadOnly = true;
            bodyView.ScrollBars = RichTextBoxScrollBars.Vertical;
            replyInput.Name = "replyInput";
            replyInput.Dock = DockStyle.Fill;
            replyInput.BackColor = Color.FromArgb(26, 26, 46);
            replyInput.ForeColor = Color.White;
            replyInput.Font = new Font("Segoe UI", 10F);
            replyInput.BorderStyle = BorderStyle.None;
            replyInput.ReadOnly = false;
            replyInput.ScrollBars = RichTextBoxScrollBars.Vertical;
            replyLabel.Name = "replyLabel";
            replyLabel.BackColor = Color.Transparent;
            replyLabel.Text = "Admin Reply";
            replyLabel.Dock = DockStyle.Fill;
            replyLabel.ForeColor = Color.FromArgb(150, 150, 170);
            replyLabel.TextAlign = ContentAlignment.MiddleLeft;
            actions.Name = "actions";
            actions.Dock = DockStyle.Fill;
            actions.BackColor = Color.Transparent;
            actions.WrapContents = false;
            replyButton.Name = "replyButton";
            replyButton.Text = "📤 SEND REPLY";
            replyButton.BackColor = Color.FromArgb(0, 140, 200);
            replyButton.ForeColor = Color.White;
            replyButton.Size = new Size(140, 36);
            replyButton.BorderRadius = 6;
            replyButton.BorderSize = 0;
            replyButton.Cursor = Cursors.Hand;
            replyButton.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            resolveButton.Name = "resolveButton";
            resolveButton.Text = "✅ MARK RESOLVED";
            resolveButton.BackColor = Color.FromArgb(0, 120, 50);
            resolveButton.ForeColor = Color.White;
            resolveButton.Size = new Size(160, 36);
            resolveButton.BorderRadius = 6;
            resolveButton.BorderSize = 0;
            resolveButton.Cursor = Cursors.Hand;
            resolveButton.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            actions.Controls.Add(replyButton);
            actions.Controls.Add(resolveButton);
            statusLabel.Name = "statusLabel";
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Text = "";
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.ForeColor = Color.FromArgb(150, 150, 170);
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            detailLayout.Controls.Add(fromLabel, 0, 0);
            detailLayout.Controls.Add(subjectLabel, 0, 1);
            detailLayout.Controls.Add(sentLabel, 0, 2);
            detailLayout.Controls.Add(separator, 0, 3);
            detailLayout.Controls.Add(bodyView, 0, 4);
            detailLayout.Controls.Add(replyLabel, 0, 5);
            detailLayout.Controls.Add(replyInput, 0, 6);
            detailLayout.Controls.Add(actions, 0, 7);
            detailLayout.Controls.Add(statusLabel, 0, 8);
            detail.Controls.Add(detailLayout);
            split.Panel2.Controls.Add(detail);
            root.Controls.Add(split, 0, 0);
            messageCardTemplate.Name = "messageCardTemplate";
            messageCardTemplate.Size = new Size(368, 75);
            messageCardTemplate.BackColor = Color.FromArgb(178, 22, 33, 62);
            messageCardTemplate.BorderColor = Color.FromArgb(75, 85, 105);
            messageCardTemplate.BorderWidth = 2;
            messageCardTemplate.CornerRadius = 6;
            messageCardTemplate.Margin = new Padding(3, 4, 3, 3);
            messageCardTemplate.Padding = new Padding(9, 3, 4, 2);
            messageCardTemplate.Cursor = Cursors.Hand;
            messageInstructorTemplate.Name = "messageInstructorTemplate";
            messageInstructorTemplate.BackColor = Color.Transparent;
            messageInstructorTemplate.Text = "Instructor name";
            messageInstructorTemplate.Dock = DockStyle.Top;
            messageInstructorTemplate.ForeColor = Color.White;
            messageInstructorTemplate.TextAlign = ContentAlignment.MiddleLeft;
            messageInstructorTemplate.Height = 20;
            messageInstructorTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            messageInstructorTemplate.AutoEllipsis = true;
            messageSubjectTemplate.Name = "messageSubjectTemplate";
            messageSubjectTemplate.BackColor = Color.Transparent;
            messageSubjectTemplate.Text = "Message subject";
            messageSubjectTemplate.Dock = DockStyle.Top;
            messageSubjectTemplate.ForeColor = Color.FromArgb(150, 150, 170);
            messageSubjectTemplate.TextAlign = ContentAlignment.MiddleLeft;
            messageSubjectTemplate.Height = 20;
            messageSubjectTemplate.Font = new Font("Segoe UI", 8F);
            messageSubjectTemplate.AutoEllipsis = true;
            messageSentTemplate.Name = "messageSentTemplate";
            messageSentTemplate.BackColor = Color.Transparent;
            messageSentTemplate.Text = "Message date";
            messageSentTemplate.Dock = DockStyle.Fill;
            messageSentTemplate.ForeColor = Color.FromArgb(150, 150, 170);
            messageSentTemplate.TextAlign = ContentAlignment.MiddleLeft;
            messageSentTemplate.Font = new Font("Segoe UI", 7F);
            messageCardTemplate.Controls.Add(messageSentTemplate);
            messageCardTemplate.Controls.Add(messageSubjectTemplate);
            messageCardTemplate.Controls.Add(messageInstructorTemplate);
            messageList.Controls.Add(messageCardTemplate);
            Load += InboxControl_Load;
            filterPicker.SelectedIndexChanged += FilterChanged;
            unreadOnly.CheckedChanged += FilterChanged;
            refreshButton.Click += RefreshButton_Click;
            replyButton.Click += ReplyButton_Click;
            resolveButton.Click += ResolveButton_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Font = new Font("Segoe UI", 9F);
            Name = "InboxControl";
            Size = new Size(1200, 720);
            Controls.Add(root);
            Controls.Add(pnlInboxAdmin);
            root.ResumeLayout(false);
            pnlInboxAdmin.ResumeLayout(false);
            root.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            filterRow.ResumeLayout(false);
            filterRow.PerformLayout();
            messageList.ResumeLayout(false);
            messageList.PerformLayout();
            detail.ResumeLayout(false);
            detail.PerformLayout();
            detailLayout.ResumeLayout(false);
            detailLayout.PerformLayout();
            actions.ResumeLayout(false);
            actions.PerformLayout();
            messageCardTemplate.ResumeLayout(false);
            messageCardTemplate.PerformLayout();
            split.Panel1.ResumeLayout(false);
            split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split).EndInit();
            split.ResumeLayout(false);
            ResumeLayout(false);
        }
    #endregion

        private void Dropdown_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (sender is not ComboBox combo) return;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color background = isSelected ? Color.FromArgb(233, 69, 96) : combo.BackColor;
            using var brush = new SolidBrush(background);
            e.Graphics.FillRectangle(brush, e.Bounds);
            object? item = e.Index >= 0 && e.Index < combo.Items.Count ? combo.Items[e.Index] : combo.SelectedItem;
            if (item != null)
            {
                string text = combo.GetItemText(item) ?? "";
                var bounds = new Rectangle(e.Bounds.X + 6, e.Bounds.Y,
                    Math.Max(0, e.Bounds.Width - 12), e.Bounds.Height);
                TextRenderer.DrawText(e.Graphics, text, e.Font ?? combo.Font, bounds,
                    combo.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                    TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis);
            }
        }


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
        this.InitializeComponent();
    }

    private bool IsDesignPreview => DesignMode ||
        System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;

    private void InboxControl_Load(object? sender, EventArgs e)
    {
        if (IsDesignPreview) return;
        filterPicker.SelectedIndex = 0;
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
