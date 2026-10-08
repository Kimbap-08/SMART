using System.Data;
using System.Data.SqlClient;

namespace SMART;

public partial class InstructorSettings : Form
{
    private bool loadingDisplay;
    public InstructorSettings()
    {
        InitializeComponent();
        PhotoHelper.MakeCircular(pbProfileSettings);
        PhotoHelper.DrawDefaultProfile(pbProfileSettings);
        loadingDisplay = true;
        cmbDisplayMode.SelectedIndex = InstructorTheme.IsLight ? 1 : 0;
        loadingDisplay = false;
        InstructorTheme.Apply(this);
        Load += (_, _) => LoadProfile();
    }
    private void Back_Click(object? sender, EventArgs e) => Close();
    private void LoadProfile()
    {
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            using var schema = new SqlCommand("IF COL_LENGTH(N'dbo.Instructors', N'Photo') IS NULL ALTER TABLE dbo.Instructors ADD Photo VARBINARY(MAX) NULL;", connection);
            schema.ExecuteNonQuery();
            using var command = new SqlCommand("SELECT FullName, Photo FROM dbo.Instructors WHERE Username = @Username AND IsActive = 1", connection);
            command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = Session.CurrentUser?.Username ?? "";
            using var reader = command.ExecuteReader();
            if (!reader.Read()) { btnImportPhoto.Enabled = false; lblProfileStatus.Text = "Your instructor profile is unavailable."; return; }
            lblProfileName.Text = reader.GetString(0);
            PhotoHelper.LoadPhoto(pbProfileSettings, reader.IsDBNull(1) ? null : (byte[])reader[1], lblProfileName.Text);
        }
        catch (SqlException ex) { btnImportPhoto.Enabled = false; MessageBox.Show(this, ex.Message, "Could not load profile", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
    private void ImportPhoto_Click(object? sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog { Title = "Select Profile Photo", Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif" };
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        try
        {
            if (new FileInfo(dialog.FileName).Length > 5 * 1024 * 1024) { MessageBox.Show(this, "Photo must be no larger than 5 MB.", "File Too Large"); return; }
            byte[] bytes = File.ReadAllBytes(dialog.FileName);
            using var stream = new MemoryStream(bytes);
            using var source = Image.FromStream(stream);
            using var decoded = new Bitmap(source);
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            using var command = new SqlCommand("UPDATE dbo.Instructors SET Photo = @Photo WHERE Username = @Username AND IsActive = 1", connection);
            command.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = bytes;
            command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = Session.CurrentUser?.Username ?? "";
            if (command.ExecuteNonQuery() != 1) { MessageBox.Show(this, "Your active instructor profile could not be found.", "Photo not saved"); return; }
            PhotoHelper.LoadPhoto(pbProfileSettings, bytes, lblProfileName.Text);
            lblProfileStatus.Text = "Profile photo saved.";
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or ArgumentException or OutOfMemoryException or SqlException)
        { MessageBox.Show(this, "Could not save this photo. " + ex.Message, "Photo not saved", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
    private void DisplayMode_Changed(object? sender, EventArgs e)
    {
        if (loadingDisplay) return;
        try { InstructorTheme.SavePreference(cmbDisplayMode.SelectedIndex == 1); InstructorTheme.Apply(this); }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        { loadingDisplay = true; cmbDisplayMode.SelectedIndex = InstructorTheme.IsLight ? 1 : 0; loadingDisplay = false; MessageBox.Show(this, ex.Message, "Display preference not saved"); }
    }
}