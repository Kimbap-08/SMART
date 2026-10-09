using System.Data;
using System.Data.SqlClient;

namespace SMART;

public sealed class AnnouncementsAdmin : UserControl
{
    private static readonly Color BackgroundColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private readonly RoundedTextBox txtTitle = new();
    private readonly ComboBox cboPriority = new();
    private readonly RichTextBox rtbMessage = new();
    private readonly CustomButton btnPost = new();
    private readonly CustomButton btnUpdate = new();
    private readonly CustomButton btnDelete = new();
    private readonly CustomButton btnCancel = new();
    private readonly CustomButton btnToggleActive = new();
    private readonly Label lblMsg = new();
    private readonly Label lblTotal = new();
    private readonly DataGridView grid = new();
    private int? editingId;
    private bool editingActive;

    public AnnouncementsAdmin()
    {
        BackColor = BackgroundColor;
        BuildLayout();
        Load += (_, _) => LoadAnnouncements();
    }

    private void BuildLayout()
    {
        var heading = new Label
        {
            Text = "📢 Announcements", Dock = DockStyle.Top, Height = 42,
            ForeColor = Color.White, Font = new Font("Segoe UI", 22F, FontStyle.Bold)
        };
        var subtitle = new Label
        {
            Text = "Create and manage announcements for instructors", Dock = DockStyle.Top,
            Height = 30, ForeColor = TextGray, Font = new Font("Segoe UI", 10F)
        };
        var card = new CustomPanel
        {
            Dock = DockStyle.Top, Height = 250, Padding = new Padding(18),
            BackColor = CardColor, BorderColor = CardColor, BorderWidth = 0, CornerRadius = 8
        };
        var titleLabel = MakeLabel("Title", 18, 14);
        txtTitle.SetBounds(18, 34, 550, 34);
        txtTitle.PlaceholderText = "Announcement title...";
        txtTitle.ForeColor = Color.White;
        txtTitle.FillColor = BackgroundColor;
        var priorityLabel = MakeLabel("Priority", 590, 14);
        cboPriority.SetBounds(590, 34, 140, 34);
        cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPriority.Items.AddRange(new object[] { "Normal", "Important", "Urgent" });
        cboPriority.SelectedIndex = 0;
        cboPriority.BackColor = BackgroundColor;
        cboPriority.ForeColor = Color.White;
        cboPriority.Font = new Font("Segoe UI", 10F);

        var messageLabel = MakeLabel("Message", 18, 76);
        rtbMessage.SetBounds(18, 96, Math.Max(400, Width - 72), 80);
        rtbMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        rtbMessage.BackColor = BackgroundColor;
        rtbMessage.ForeColor = Color.White;
        rtbMessage.BorderStyle = BorderStyle.FixedSingle;
        rtbMessage.Font = new Font("Segoe UI", 10F);

        StyleButton(btnPost, "POST ANNOUNCEMENT", AccentColor, 18, 190);
        btnPost.Click += (_, _) => SaveAnnouncement(false);
        StyleButton(btnUpdate, "UPDATE", Color.FromArgb(0, 140, 200), 218, 100);
        btnUpdate.Visible = false;
        btnUpdate.Click += (_, _) => SaveAnnouncement(true);
        StyleButton(btnDelete, "DELETE", AccentColor, 328, 100);
        btnDelete.Click += (_, _) => DeleteAnnouncement();
        StyleButton(btnCancel, "CANCEL", Color.FromArgb(60, 60, 80), 438, 100);
        btnCancel.Click += (_, _) => ClearForm();
        StyleButton(btnToggleActive, "DEACTIVATE", Color.FromArgb(60, 60, 80), 548, 120);
        btnToggleActive.Visible = false;
        btnToggleActive.Click += (_, _) => ToggleActive();
        lblMsg.SetBounds(680, 199, Math.Max(200, Width - 710), 28);
        lblMsg.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        lblMsg.AutoSize = false;
        lblMsg.ForeColor = TextGray;
        lblMsg.TextAlign = ContentAlignment.MiddleLeft;

        card.Controls.AddRange(new Control[]
        {
            titleLabel, txtTitle, priorityLabel, cboPriority, messageLabel, rtbMessage,
            btnPost, btnUpdate, btnDelete, btnCancel, btnToggleActive, lblMsg
        });
        lblTotal.Dock = DockStyle.Top;
        lblTotal.Height = 34;
        lblTotal.ForeColor = TextGray;
        lblTotal.Font = new Font("Segoe UI", 10F);
        lblTotal.TextAlign = ContentAlignment.MiddleLeft;

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
        grid.CellClick += Grid_CellClick;
        grid.CellFormatting += Grid_CellFormatting;

        Controls.Add(grid);
        Controls.Add(lblTotal);
        Controls.Add(card);
        Controls.Add(subtitle);
        Controls.Add(heading);
    }

    private static Label MakeLabel(string text, int x, int y) => new()
    {
        Text = text, Location = new Point(x, y), AutoSize = true,
        ForeColor = TextGray, Font = new Font("Segoe UI", 9F)
    };

    private static void StyleButton(CustomButton button, string text, Color color, int x, int width)
    {
        button.Text = text;
        button.SetBounds(x, 194, width, 36);
        button.BackColor = color;
        button.ForeColor = Color.White;
        button.BorderRadius = 5;
        button.BorderSize = 0;
        button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
    }

    private static void EnsureTable(SqlConnection connection)
    {
        using var command = new SqlCommand(@"IF OBJECT_ID(N'dbo.Announcements', N'U') IS NULL
            CREATE TABLE dbo.Announcements (
                AnnouncementId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Announcements PRIMARY KEY,
                Title NVARCHAR(200) NOT NULL,
                Message NVARCHAR(MAX) NOT NULL,
                PostedBy NVARCHAR(100) NOT NULL CONSTRAINT DF_Announcements_PostedBy DEFAULT N'System Administrator',
                PostedAt DATETIME NOT NULL CONSTRAINT DF_Announcements_PostedAt DEFAULT GETDATE(),
                IsActive BIT NOT NULL CONSTRAINT DF_Announcements_IsActive DEFAULT (1),
                Priority NVARCHAR(20) NOT NULL CONSTRAINT DF_Announcements_Priority DEFAULT N'Normal'
            );", connection);
        command.ExecuteNonQuery();
    }

    private void LoadAnnouncements()
    {
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            EnsureTable(connection);
            using var adapter = new SqlDataAdapter(@"SELECT AnnouncementId, Title, Priority,
                PostedAt AS [Posted At], IsActive AS Active, Message
                FROM dbo.Announcements ORDER BY PostedAt DESC", connection);
            var table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;
            grid.Columns["AnnouncementId"].Visible = false;
            grid.Columns["Title"].Width = 200;
            grid.Columns["Priority"].Width = 100;
            grid.Columns["Posted At"].Width = 150;
            grid.Columns["Active"].Width = 80;
            grid.Columns["Message"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lblTotal.Text = $"Total: {table.Rows.Count} announcements";
        }
        catch (SqlException ex) { ShowMessage("Could not load announcements: " + ex.Message, true); }
    }

    private void SaveAnnouncement(bool updating)
    {
        string title = txtTitle.Text.Trim();
        string message = rtbMessage.Text.Trim();
        if (title.Length == 0) { ShowMessage("Enter an announcement title.", true); txtTitle.Focus(); return; }
        if (title.Length > 200) { ShowMessage("Title must be 200 characters or fewer.", true); txtTitle.Focus(); return; }
        if (message.Length == 0) { ShowMessage("Enter an announcement message.", true); rtbMessage.Focus(); return; }
        if (updating && editingId == null) { ShowMessage("Select an announcement to update.", true); return; }

        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            EnsureTable(connection);
            string sql = updating
                ? @"UPDATE dbo.Announcements SET Title=@title, Message=@msg, Priority=@priority
                    WHERE AnnouncementId=@id"
                : @"INSERT INTO dbo.Announcements (Title, Message, Priority, PostedBy)
                    VALUES (@title, @msg, @priority, N'System Administrator')";
            using var command = new SqlCommand(sql, connection);
            command.Parameters.Add("@title", SqlDbType.NVarChar, 200).Value = title;
            command.Parameters.Add("@msg", SqlDbType.NVarChar, -1).Value = message;
            command.Parameters.Add("@priority", SqlDbType.NVarChar, 20).Value = cboPriority.SelectedItem?.ToString() ?? "Normal";
            if (updating) command.Parameters.Add("@id", SqlDbType.Int).Value = editingId!.Value;
            if (command.ExecuteNonQuery() == 0) { ShowMessage("Announcement not found.", true); return; }
            ShowMessage(updating ? "Announcement updated." : "Announcement posted.", false);
            ClearForm();
            LoadAnnouncements();
        }
        catch (SqlException ex) { ShowMessage("Could not save announcement: " + ex.Message, true); }
    }

    private void DeleteAnnouncement()
    {
        if (editingId == null) { ShowMessage("Select an announcement to delete.", true); return; }
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            using var command = new SqlCommand("UPDATE dbo.Announcements SET IsActive=0 WHERE AnnouncementId=@id", connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = editingId.Value;
            if (command.ExecuteNonQuery() == 0) { ShowMessage("Announcement not found.", true); return; }
            ShowMessage("Announcement archived.", false);
            ClearForm();
            LoadAnnouncements();
        }
        catch (SqlException ex) { ShowMessage("Could not delete announcement: " + ex.Message, true); }
    }

    private void Grid_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var row = grid.Rows[e.RowIndex];
        editingId = Convert.ToInt32(row.Cells["AnnouncementId"].Value);
        txtTitle.Text = Convert.ToString(row.Cells["Title"].Value) ?? "";
        rtbMessage.Text = Convert.ToString(row.Cells["Message"].Value) ?? "";
        cboPriority.SelectedItem = Convert.ToString(row.Cells["Priority"].Value) ?? "Normal";
        editingActive = Convert.ToBoolean(row.Cells["Active"].Value);
        btnPost.Visible = false;
        btnUpdate.Visible = true;
        btnToggleActive.Visible = true;
        btnToggleActive.Text = editingActive ? "DEACTIVATE" : "ACTIVATE";
        btnToggleActive.BackColor = editingActive ? AccentColor : Color.FromArgb(0, 140, 200);
        ShowMessage("Editing selected announcement.", false);
    }

    private void ToggleActive()
    {
        if (editingId == null) return;
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            using var command = new SqlCommand(
                "UPDATE dbo.Announcements SET IsActive=@active WHERE AnnouncementId=@id", connection);
            command.Parameters.Add("@active", SqlDbType.Bit).Value = !editingActive;
            command.Parameters.Add("@id", SqlDbType.Int).Value = editingId.Value;
            if (command.ExecuteNonQuery() == 0) { ShowMessage("Announcement not found.", true); return; }
            ShowMessage(editingActive ? "Announcement deactivated." : "Announcement activated.", false);
            ClearForm();
            LoadAnnouncements();
        }
        catch (SqlException ex) { ShowMessage("Could not change announcement status: " + ex.Message, true); }
    }

    private void Grid_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || grid.Columns[e.ColumnIndex].Name != "Priority") return;
        string priority = Convert.ToString(e.Value) ?? "Normal";
        e.CellStyle.ForeColor = priority switch
        {
            "Urgent" => AccentColor,
            "Important" => Color.FromArgb(255, 170, 0),
            _ => Color.White
        };
        if (priority == "Urgent") e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
    }

    private void ClearForm()
    {
        editingId = null;
        txtTitle.Text = "";
        rtbMessage.Clear();
        cboPriority.SelectedIndex = 0;
        btnPost.Visible = true;
        btnUpdate.Visible = false;
        btnToggleActive.Visible = false;
        editingActive = false;
        grid.ClearSelection();
    }

    private void ShowMessage(string message, bool isError)
    {
        lblMsg.Text = message;
        lblMsg.ForeColor = isError ? AccentColor : Color.LightGreen;
    }
}
