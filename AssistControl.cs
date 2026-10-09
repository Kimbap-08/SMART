using System.Data;
using System.Data.SqlClient;

namespace SMART;

public sealed class AssistControl : UserControl
{
    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private readonly string employeeId;
    private readonly string instructorName;
    private readonly RoundedTextBox subjectInput = new();
    private readonly RichTextBox messageInput = new();
    private readonly DataGridView sentGrid = new();
    private readonly Label sendStatus = new();

    public AssistControl(string employeeId, string instructorName)
    {
        this.employeeId = employeeId;
        this.instructorName = instructorName;
        BackColor = BgColor;
        BuildLayout();
        Load += (_, _) => LoadSentMessages();
    }

    private void BuildLayout()
    {
        var root = new TableLayoutPanel
        {
            Dock = DockStyle.Fill, BackColor = BgColor, ColumnCount = 1, RowCount = 4,
            Padding = new Padding(4)
        };
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 285));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        var heading = new Label
        {
            Text = "🆘 Assist — Send a message to the Administrator", Dock = DockStyle.Fill,
            ForeColor = Color.White, Font = new Font("Segoe UI", 19F, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleLeft
        };
        var compose = new CustomPanel
        {
            Dock = DockStyle.Fill, BackColor = CardColor, BorderColor = CardColor,
            BorderWidth = 0, CornerRadius = 8, Padding = new Padding(16)
        };
        compose.Padding = new Padding(14);
        var form = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 5, BackColor = CardColor };
        form.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
        form.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
        form.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
        form.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
        form.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        form.Controls.Add(new Label
        {
            Text = "+ Compose New Message", Dock = DockStyle.Fill, ForeColor = AccentColor,
            Font = new Font("Segoe UI", 11F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft
        }, 0, 0);
        form.Controls.Add(MakeLabel("Subject"), 0, 1);
        ConfigureInput(subjectInput, "e.g. Did not receive announcement");
        subjectInput.Dock = DockStyle.Fill;
        form.Controls.Add(subjectInput, 0, 2);
        form.Controls.Add(MakeLabel("Message"), 0, 3);
        messageInput.Dock = DockStyle.Fill;
        messageInput.BackColor = BgColor;
        messageInput.ForeColor = Color.White;
        messageInput.Font = new Font("Segoe UI", 10F);
        messageInput.BorderStyle = BorderStyle.None;
        messageInput.ScrollBars = RichTextBoxScrollBars.Vertical;
        // Keep the message editor immediately below its label and reserve the bottom for actions.
        var messageAndActions = new Panel { Dock = DockStyle.Fill, BackColor = CardColor };
        messageInput.Dock = DockStyle.Fill;
        var actions = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 42, BackColor = CardColor, WrapContents = false };
        var send = MakeButton("📤 SEND MESSAGE", AccentColor, 170, 36);
        send.Click += (_, _) => SendMessage();
        sendStatus.AutoSize = true;
        sendStatus.ForeColor = Color.LimeGreen;
        sendStatus.Padding = new Padding(8, 10, 0, 0);
        actions.Controls.Add(send);
        actions.Controls.Add(sendStatus);
        messageAndActions.Controls.Add(messageInput);
        messageAndActions.Controls.Add(actions);
        form.Controls.Add(messageAndActions, 0, 4);
        compose.Controls.Add(form);

        var sentHeading = new Label
        {
            Text = "My Sent Messages", Dock = DockStyle.Fill, ForeColor = Color.White,
            Font = new Font("Segoe UI", 14F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft
        };
        StyleGrid(sentGrid);
        var sentHost = new Panel { Dock = DockStyle.Fill, BackColor = BgColor, Padding = new Padding(0, 4, 0, 0) };
        sentHost.Controls.Add(sentGrid);
        root.Controls.Add(heading, 0, 0);
        root.Controls.Add(compose, 0, 1);
        root.Controls.Add(sentHeading, 0, 2);
        root.Controls.Add(sentHost, 0, 3);
        Controls.Add(root);
    }

    private void LoadSentMessages()
    {
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT MessageId, Subject, SentAt,
                    CASE WHEN IsResolved = 1 THEN N'✅ Resolved'
                         WHEN IsRead = 1 THEN N'👁 Seen' ELSE N'⏳ Pending' END AS Status,
                    AdminReply, IsRead, IsResolved
                FROM dbo.AssistMessages WHERE InstructorEmployeeID = @empId
                ORDER BY SentAt DESC", connection);
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            sentGrid.DataSource = table;
            if (sentGrid.Columns.Contains("MessageId")) sentGrid.Columns["MessageId"].Visible = false;
            if (sentGrid.Columns.Contains("IsRead")) sentGrid.Columns["IsRead"].Visible = false;
            if (sentGrid.Columns.Contains("IsResolved")) sentGrid.Columns["IsResolved"].Visible = false;
            if (sentGrid.Columns.Contains("Subject")) sentGrid.Columns["Subject"].Width = 220;
            if (sentGrid.Columns.Contains("SentAt")) sentGrid.Columns["SentAt"].Width = 150;
            if (sentGrid.Columns.Contains("Status")) sentGrid.Columns["Status"].Width = 110;
            if (sentGrid.Columns.Contains("AdminReply"))
            {
                sentGrid.Columns["AdminReply"].HeaderText = "Admin Reply";
                sentGrid.Columns["AdminReply"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            sendStatus.Text = "";
        }
        catch (SqlException ex) { sendStatus.Text = "Could not load messages: " + ex.Message; sendStatus.ForeColor = AccentColor; }
    }

    private void SendMessage()
    {
        string subject = subjectInput.Text.Trim();
        string body = messageInput.Text.Trim();
        if (subject.Length == 0 || subject.Length > 200)
        {
            SetStatus("Enter a subject up to 200 characters.", true);
            return;
        }
        if (body.Length == 0)
        {
            SetStatus("Enter a message before sending.", true);
            return;
        }
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"INSERT INTO dbo.AssistMessages
                    (InstructorEmployeeID, InstructorName, Subject, Message)
                VALUES (@empId, @name, @subject, @msg)", connection);
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = instructorName.Length > 100 ? instructorName[..100] : instructorName;
            command.Parameters.Add("@subject", SqlDbType.NVarChar, 200).Value = subject;
            command.Parameters.Add("@msg", SqlDbType.NVarChar, -1).Value = body;
            command.ExecuteNonQuery();
            subjectInput.Text = "";
            messageInput.Clear();
            SetStatus("Message sent to the administrator.", false);
            LoadSentMessages();
            SetStatus("Message sent to the administrator.", false);
        }
        catch (SqlException ex) { SetStatus("Could not send message: " + ex.Message, true); }
    }

    private void SetStatus(string text, bool error)
    {
        sendStatus.Text = text;
        sendStatus.ForeColor = error ? AccentColor : Color.LimeGreen;
    }

    private SqlConnection OpenConnection()
    {
        var connection = new SqlConnection(DatabaseConnection.ConnectionString);
        try { DatabaseConnection.Open(connection); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private static void ConfigureInput(RoundedTextBox input, string placeholder)
    {
        input.FillColor = BgColor;
        input.BorderColor = AccentColor;
        input.FocusBorderColor = AccentColor;
        input.BorderRadius = 7;
        input.Font = new Font("Segoe UI", 10F);
        input.ForeColor = Color.White;
        input.PlaceholderText = placeholder;
    }

    private static Label MakeLabel(string text) => new()
    {
        Text = text, Dock = DockStyle.Fill, ForeColor = TextGray,
        Font = new Font("Segoe UI", 8F), TextAlign = ContentAlignment.MiddleLeft
    };

    private static CustomButton MakeButton(string text, Color color, int width, int height) => new()
    {
        Text = text, BackColor = color, ForeColor = Color.White, Size = new Size(width, height),
        BorderRadius = 6, BorderSize = 0, Cursor = Cursors.Hand, Font = new Font("Segoe UI", 9F, FontStyle.Bold)
    };

    private static void StyleGrid(DataGridView grid)
    {
        grid.Dock = DockStyle.Fill;
        grid.ReadOnly = true;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.MultiSelect = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        grid.BackgroundColor = CardColor;
        grid.BorderStyle = BorderStyle.None;
        grid.GridColor = Color.FromArgb(40, 52, 85);
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        grid.DefaultCellStyle.BackColor = CardColor;
        grid.DefaultCellStyle.ForeColor = Color.White;
        grid.DefaultCellStyle.SelectionBackColor = AccentColor;
        grid.DefaultCellStyle.SelectionForeColor = Color.White;
        grid.RowHeadersVisible = false;
        grid.CellFormatting += (_, e) =>
        {
            if (e.RowIndex < 0 || grid.Columns[e.ColumnIndex].Name != "Status") return;
            string status = Convert.ToString(e.Value) ?? "";
            e.CellStyle.ForeColor = status.Contains("Resolved", StringComparison.Ordinal) ? Color.LimeGreen
                : status.Contains("Seen", StringComparison.Ordinal) ? Color.FromArgb(255, 170, 0) : TextGray;
        };
    }
}
