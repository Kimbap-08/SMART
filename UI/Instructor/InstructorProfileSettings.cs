using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SMART.NewFolder;

namespace SMART
{

public partial class InstructorProfileSettings : Form
{
    private static readonly Color BackgroundColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private static readonly Color DimColor = Color.FromArgb(100, 100, 130);
    private static readonly Color GreenColor = Color.FromArgb(0, 204, 0);

    private readonly CustomPanel pnlAccountInfo = new();
    private readonly CustomPanel pnlChangePassword = new();
    private readonly Dictionary<string, Label> accountValues = new();
    private readonly RoundedTextBox txtCurrentPassword = new();
    private readonly RoundedTextBox txtNewPassword = new();
    private readonly RoundedTextBox txtConfirmPassword = new();
    private readonly CustomButton btnChangePassword = new();
    private readonly Label lblPasswordStatus = new();
    private readonly Label lblStrength = new();
    private readonly Panel pnlStrength = new();
    private readonly Panel pnlStrengthFill = new();
    private string instructorEmployeeId = string.Empty;

    public InstructorProfileSettings()
    {
        InitializeComponent();
        PhotoHelper.MakeCircular(pbProfileSettings);
        PhotoHelper.DrawDefaultProfile(pbProfileSettings);
        BuildAccountAndPasswordSections();
        pnlSettingsContent.SizeChanged += (_, _) => ResizeProfileSections();
        InstructorTheme.Apply(this);
    }
    internal void PrepareForEmbedding()
    {
        pnlHeaderInstructor.Visible = false;
        MinimumSize = Size.Empty;
    }

    internal InstructorSettingsDestination Destination { get; private set; } = InstructorSettingsDestination.Settings;
    private void Back_Click(object? sender, EventArgs e) => Close();
    private void Dashboard_Click(object? sender, EventArgs e)
    {
        Destination = InstructorSettingsDestination.Dashboard;
        Close();
    }
    private void SwitchSection_Click(object? sender, EventArgs e)
    {
        Destination = InstructorSettingsDestination.Display;
        Close();
    }
    private void InstructorProfileSettings_Load(object? sender, EventArgs e)
    {
        LoadProfile();
        LoadAccountInfo();
    }

    private void BuildAccountAndPasswordSections()
    {
        var accountHeading = CreateSectionHeading("ACCOUNT INFORMATION");
        accountHeading.Location = new Point(32, 300);
        accountHeading.Name = "lblAccountInfoHeading";
        pnlAccountInfo.Name = "pnlAccountInfo";
        pnlAccountInfo.Location = new Point(32, 330);
        pnlAccountInfo.Size = new Size(620, 205);
        pnlAccountInfo.Padding = new Padding(15);
        pnlAccountInfo.BackColor = CardColor;
        pnlAccountInfo.BorderColor = CardColor;
        pnlAccountInfo.BorderWidth = 0;
        pnlAccountInfo.CornerRadius = 8;

        string[] fields = { "Employee ID", "Full Name", "Program", "Department", "Email", "Username" };
        for (int i = 0; i < fields.Length; i++)
        {
            int y = 14 + i * 28;
            pnlAccountInfo.Controls.Add(new Label
            {
                Text = fields[i] + ":", Location = new Point(15, y), Size = new Size(130, 24),
                ForeColor = TextGray, Font = new Font("Segoe UI", 9F), TextAlign = ContentAlignment.MiddleLeft
            });
            var value = new Label
            {
                Text = "Loading…", Location = new Point(150, y), Size = new Size(440, 24),
                ForeColor = Color.White, Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoEllipsis = true, TextAlign = ContentAlignment.MiddleLeft
            };
            accountValues[fields[i]] = value;
            pnlAccountInfo.Controls.Add(value);
        }

        var passwordHeading = CreateSectionHeading("CHANGE PASSWORD");
        passwordHeading.Location = new Point(32, 555);
        passwordHeading.Name = "lblChangePasswordHeading";
        pnlChangePassword.Name = "pnlChangePassword";
        pnlChangePassword.Location = new Point(32, 585);
        pnlChangePassword.Size = new Size(620, 365);
        pnlChangePassword.Padding = new Padding(15);
        pnlChangePassword.BackColor = CardColor;
        pnlChangePassword.BorderColor = CardColor;
        pnlChangePassword.BorderWidth = 0;
        pnlChangePassword.CornerRadius = 8;

        AddPasswordField("Current Password", txtCurrentPassword, 14, "Enter your current password", out _);
        AddPasswordField("New Password", txtNewPassword, 82, "At least 8 characters", out _);
        AddPasswordField("Confirm New Password", txtConfirmPassword, 150, "Re-enter new password", out _);

        pnlStrength.Location = new Point(15, 216);
        pnlStrength.Size = new Size(350, 6);
        pnlStrength.BackColor = Color.FromArgb(40, 40, 60);
        pnlStrengthFill.Location = Point.Empty;
        pnlStrengthFill.Size = new Size(0, 6);
        pnlStrength.Controls.Add(pnlStrengthFill);
        pnlChangePassword.Controls.Add(pnlStrength);
        lblStrength.SetBounds(15, 225, 120, 20);
        lblStrength.ForeColor = DimColor;
        lblStrength.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
        pnlChangePassword.Controls.Add(lblStrength);

        pnlChangePassword.Controls.Add(new Label
        {
            Text = "Password must be at least 8 characters", Location = new Point(15, 249),
            Size = new Size(350, 20), ForeColor = DimColor, Font = new Font("Segoe UI", 8F, FontStyle.Italic)
        });
        btnChangePassword.Text = "🔒 CHANGE PASSWORD";
        btnChangePassword.SetBounds(15, 282, 200, 38);
        btnChangePassword.BackColor = AccentColor;
        btnChangePassword.ForeColor = Color.White;
        btnChangePassword.BorderRadius = 6;
        btnChangePassword.BorderSize = 0;
        btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnChangePassword.Click += (_, _) => ChangePassword();
        pnlChangePassword.Controls.Add(btnChangePassword);
        lblPasswordStatus.SetBounds(230, 280, 360, 42);
        lblPasswordStatus.AutoSize = false;
        lblPasswordStatus.ForeColor = TextGray;
        lblPasswordStatus.Font = new Font("Segoe UI", 9F);
        lblPasswordStatus.TextAlign = ContentAlignment.MiddleLeft;
        pnlChangePassword.Controls.Add(lblPasswordStatus);

        txtNewPassword.TextChanged += (_, _) => UpdatePasswordStrength();
        pnlSettingsContent.Controls.Add(accountHeading);
        pnlSettingsContent.Controls.Add(pnlAccountInfo);
        pnlSettingsContent.Controls.Add(passwordHeading);
        pnlSettingsContent.Controls.Add(pnlChangePassword);
        ResizeProfileSections();
    }

    private static Label CreateSectionHeading(string text) => new()
    {
        Text = text, Size = new Size(620, 26), ForeColor = AccentColor,
        Font = new Font("Segoe UI", 11F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft,
        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
    };

    private void AddPasswordField(string label, RoundedTextBox textbox, int top, string placeholder, out CustomButton toggle)
    {
        pnlChangePassword.Controls.Add(new Label
        {
            Text = label, Location = new Point(15, top), Size = new Size(350, 18),
            ForeColor = TextGray, Font = new Font("Segoe UI", 8F)
        });
        textbox.SetBounds(15, top + 21, 350, 34);
        textbox.PlaceholderText = placeholder;
        textbox.UseSystemPasswordChar = true;
        textbox.ForeColor = Color.White;
        textbox.FillColor = BackgroundColor;
        textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        pnlChangePassword.Controls.Add(textbox);
        toggle = new CustomButton
        {
            Text = "👁", Bounds = new Rectangle(372, top + 22, 32, 32),
            BackColor = CardColor, ForeColor = TextGray, BorderRadius = 4, BorderSize = 0,
            Font = new Font("Segoe UI Emoji", 10F)
        };
        toggle.Click += (_, _) => textbox.UseSystemPasswordChar = !textbox.UseSystemPasswordChar;
        pnlChangePassword.Controls.Add(toggle);
    }

    private void ResizeProfileSections()
    {
        int width = Math.Max(500, Math.Min(620, pnlSettingsContent.ClientSize.Width - 64));
        pnlAccountInfo.Width = width;
        pnlChangePassword.Width = width;
        foreach (var value in accountValues.Values) value.Width = Math.Max(250, width - 180);
        pnlChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    }

    private void LoadAccountInfo()
    {
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            using var command = new SqlCommand(@"SELECT EmployeeID, FullName, Program,
                Department, Email, Username
                FROM dbo.Instructors WHERE Username=@Username AND IsActive=1", connection);
            command.Parameters.Add("@Username", SqlDbType.NVarChar, 30).Value = Session.CurrentUser?.Username ?? "";
            using var reader = command.ExecuteReader();
            if (!reader.Read())
            {
                foreach (var value in accountValues.Values) value.Text = "Unavailable";
                instructorEmployeeId = string.Empty;
                ShowPasswordStatus("❌ Instructor account could not be found.", true);
                btnChangePassword.Enabled = false;
                return;
            }

            instructorEmployeeId = reader["EmployeeID"] as string ?? Convert.ToString(reader["EmployeeID"]) ?? "";
            accountValues["Employee ID"].Text = instructorEmployeeId;
            accountValues["Full Name"].Text = ReadNullableString(reader, "FullName");
            accountValues["Program"].Text = ReadNullableString(reader, "Program");
            accountValues["Department"].Text = ReadNullableString(reader, "Department");
            accountValues["Email"].Text = ReadNullableString(reader, "Email");
            accountValues["Username"].Text = ReadNullableString(reader, "Username");
            lblProfileName.Text = accountValues["Full Name"].Text;
            btnChangePassword.Enabled = !string.IsNullOrWhiteSpace(instructorEmployeeId);
        }
        catch (SqlException ex)
        {
            ShowPasswordStatus("❌ Could not load account information: " + ex.Message, true);
            btnChangePassword.Enabled = false;
        }
    }

    private static string ReadNullableString(SqlDataReader reader, string column) =>
        reader.IsDBNull(reader.GetOrdinal(column)) ? "—" : Convert.ToString(reader[column]) ?? "—";

    private void UpdatePasswordStrength()
    {
        string password = txtNewPassword.Text;
        bool longEnough = password.Length >= 8;
        bool hasLetter = password.Any(char.IsLetter);
        bool hasDigit = password.Any(char.IsDigit);
        bool hasSymbol = password.Any(c => !char.IsLetterOrDigit(c));
        string strength;
        Color color;
        int percent;
        if (!longEnough)
        {
            strength = password.Length == 0 ? "" : "Weak";
            color = AccentColor;
            percent = 0;
        }
        else if (hasSymbol)
        {
            strength = "Strong";
            color = GreenColor;
            percent = 100;
        }
        else if (hasLetter && hasDigit)
        {
            strength = "Fair";
            color = Color.FromArgb(255, 170, 0);
            percent = 70;
        }
        else
        {
            strength = "Weak";
            color = AccentColor;
            percent = 40;
        }
        lblStrength.Text = strength;
        lblStrength.ForeColor = color;
        pnlStrengthFill.BackColor = color;
        pnlStrengthFill.Width = pnlStrength.ClientSize.Width * percent / 100;
    }

    private void ChangePassword()
    {
        string current = txtCurrentPassword.Text;
        string next = txtNewPassword.Text;
        string confirm = txtConfirmPassword.Text;
        if (string.IsNullOrEmpty(current)) { ShowPasswordStatus("❌ Please enter your current password.", true); txtCurrentPassword.Focus(); return; }
        if (string.IsNullOrEmpty(next)) { ShowPasswordStatus("❌ Please enter a new password.", true); txtNewPassword.Focus(); return; }
        if (next.Length < 8) { ShowPasswordStatus("❌ Password must be at least 8 characters.", true); txtNewPassword.Focus(); return; }
        if (next != confirm) { ShowPasswordStatus("❌ New passwords do not match.", true); txtConfirmPassword.Focus(); return; }
        if (next == current) { ShowPasswordStatus("❌ New password must be different from current password.", true); txtNewPassword.Focus(); return; }
        if (string.IsNullOrWhiteSpace(instructorEmployeeId)) { ShowPasswordStatus("❌ Instructor account could not be found.", true); return; }

        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            string storedHash;
            using (var readHash = new SqlCommand(
                "SELECT PasswordHash FROM dbo.Instructors WHERE EmployeeID=@EmployeeID AND IsActive=1", connection))
            {
                readHash.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 50).Value = instructorEmployeeId;
                object? result = readHash.ExecuteScalar();
                storedHash = Convert.ToString(result) ?? "";
            }
            if (!PasswordHasher.Verify(current, storedHash))
            {
                ShowPasswordStatus("❌ Current password is incorrect.", true);
                return;
            }

            string newHash = PasswordHasher.Hash(next);
            using var update = new SqlCommand(
                "UPDATE dbo.Instructors SET PasswordHash=@PasswordHash WHERE EmployeeID=@EmployeeID AND IsActive=1", connection);
            update.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 200).Value = newHash;
            update.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 50).Value = instructorEmployeeId;
            if (update.ExecuteNonQuery() != 1)
            {
                ShowPasswordStatus("❌ Password could not be updated. Try again.", true);
                return;
            }

            ShowPasswordStatus("✅ Password changed successfully!", false);
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtCurrentPassword.Focus();
        }
        catch (SqlException ex) { ShowPasswordStatus("❌ Could not change password: " + ex.Message, true); }
    }

    private void ShowPasswordStatus(string message, bool isError)
    {
        lblPasswordStatus.Text = message;
        lblPasswordStatus.ForeColor = isError ? AccentColor : GreenColor;
    }
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
}

}
