using System.Data;
using System.Data.SqlClient;

namespace SMART
{

public sealed partial class AnnouncementsAdmin : UserControl
{
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private int? editingId;
    private bool editingActive;

    public AnnouncementsAdmin()
    {
        InitializeComponent();
        cboPriority.SelectedIndex = 0;
    }

    private void AnnouncementsAdmin_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode)
            return;
        ClearForm();
        LoadAnnouncements();
    }

    private void BtnPost_Click(object? sender, EventArgs e) => SaveAnnouncement(false);
    private void BtnUpdate_Click(object? sender, EventArgs e) => SaveAnnouncement(true);
    private void BtnDelete_Click(object? sender, EventArgs e) => DeleteAnnouncement();
    private void BtnCancel_Click(object? sender, EventArgs e) => ClearForm();
    private void BtnToggleActive_Click(object? sender, EventArgs e) => ToggleActive();

    private void Grid_Paint(object? sender, PaintEventArgs e)
    {
        // DataGridView does not support transparent backgrounds. Blend only its
        // unused area, leaving the headers, rows, and selection readable.
        if (BackgroundImage == null) return;
        int bottom = grid.ColumnHeadersVisible ? grid.ColumnHeadersHeight : 0;
        foreach (DataGridViewRow row in grid.Rows)
        {
            if (row.Displayed)
                bottom = Math.Max(bottom, grid.GetRowDisplayRectangle(row.Index, false).Bottom);
        }
        var emptyArea = new Rectangle(0, bottom, grid.ClientSize.Width,
            Math.Max(0, grid.ClientSize.Height - bottom));
        if (emptyArea.Height == 0) return;
        var state = e.Graphics.Save();
        try
        {
            e.Graphics.SetClip(emptyArea, System.Drawing.Drawing2D.CombineMode.Intersect);
            var origin = PointToClient(grid.PointToScreen(Point.Empty));
            e.Graphics.DrawImageUnscaled(BackgroundImage, -origin.X, -origin.Y);
            using var tint = new SolidBrush(Color.FromArgb(210, grid.BackgroundColor));
            e.Graphics.FillRectangle(tint, emptyArea);
        }
        finally { e.Graphics.Restore(state); }
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
            using var adapter = new SqlDataAdapter(@"SELECT AnnouncementId, Title,
                CASE WHEN Priority = N'Important' THEN N'Urgent' ELSE Priority END AS Priority,
                PostedAt AS [Posted At], IsActive AS Active, Message
                FROM dbo.Announcements ORDER BY PostedAt DESC", connection);
            var table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;
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
            _ => Color.White
        };
        if (priority == "Urgent") e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
    }

    private void ClearForm()
    {
        editingId = null;
        txtTitle.Text = "";
        rtbMessage.Text = "";
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
}
