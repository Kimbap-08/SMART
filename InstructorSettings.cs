namespace SMART;

public partial class InstructorSettings : Form
{
    private InstructorSettingsDestination? activeSection;

    public InstructorSettings()
    {
        InitializeComponent();
        InstructorTheme.Apply(this);
    }
    private void Back_Click(object? sender, EventArgs e) => Close();
    private void BtnProfileSettings_Click(object? sender, EventArgs e) => OpenSection(InstructorSettingsDestination.Profile);
    private void BtnDisplaySettings_Click(object? sender, EventArgs e) => OpenSection(InstructorSettingsDestination.Display);

    private void HighlightSection()
    {
        SetRow(flpProfileSettings, activeSection == InstructorSettingsDestination.Profile);
        SetRow(flpDisplaySettings, activeSection == InstructorSettingsDestination.Display);
    }
    private static void SetRow(Control row, bool selected)
    {
        row.BackColor = selected ? Color.FromArgb(233, 69, 96) : InstructorTheme.Surface;
        foreach (Control child in row.Controls)
        {
            child.BackColor = row.BackColor;
            child.ForeColor = selected ? Color.White : InstructorTheme.Text;
        }
        row.Invalidate(true);
    }

    private void SettingsCheckpoint_Click(object? sender, EventArgs e)
    {
        ClearSection();
        activeSection = null;
        lblBreadcrumbSection.Text = "";
        lblSettingsTitle.Text = "Instructor Settings";
        RefreshTheme();
    }

    private void ClearSection()
    {
        foreach (Control child in pnlSettingsContent.Controls.Cast<Control>().ToArray())
        {
            pnlSettingsContent.Controls.Remove(child);
            child.Dispose();
        }
        pnlSettingsContent.Tag = null;
    }

    private void RefreshTheme()
    {
        InstructorTheme.Apply(this);
        HighlightSection();
    }

    private void DisplayTheme_Changed(object? sender, EventArgs e) => RefreshTheme();

    private void OpenSection(InstructorSettingsDestination destination)
    {
        if (activeSection == destination && pnlSettingsContent.Controls.Count > 0) return;
        ClearSection();
        Form form;
        if (destination == InstructorSettingsDestination.Profile)
        {
            var profile = new InstructorProfileSettings();
            profile.PrepareForEmbedding();
            form = profile;
        }
        else
        {
            var display = new InstructorDisplaySettings();
            display.PrepareForEmbedding();
            display.ThemeChanged += DisplayTheme_Changed;
            form = display;
        }
        activeSection = destination;
        lblBreadcrumbSection.Text = destination == InstructorSettingsDestination.Profile ? "›  Profile" : "›  Display";
        lblSettingsTitle.Text = destination == InstructorSettingsDestination.Profile ? "Profile Settings" : "Display Settings";
        form.WindowState = FormWindowState.Normal;
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        pnlSettingsContent.Controls.Add(form);
        pnlSettingsContent.Tag = form;
        form.Show();
        RefreshTheme();
    }
}