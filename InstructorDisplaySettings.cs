namespace SMART;

public partial class InstructorDisplaySettings : Form
{
    private bool loadingDisplay;
    public InstructorDisplaySettings()
    {
        InitializeComponent();
        loadingDisplay = true;
        cmbDisplayMode.SelectedIndex = InstructorTheme.IsLight ? 1 : 0;
        loadingDisplay = false;
        InstructorTheme.Apply(this);
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
        Destination = InstructorSettingsDestination.Profile;
        Close();
    }
    private void DisplayMode_Changed(object? sender, EventArgs e)
    {
        if (loadingDisplay) return;
        try { InstructorTheme.SavePreference(cmbDisplayMode.SelectedIndex == 1); InstructorTheme.Apply(this); }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        { loadingDisplay = true; cmbDisplayMode.SelectedIndex = InstructorTheme.IsLight ? 1 : 0; loadingDisplay = false; MessageBox.Show(this, ex.Message, "Display preference not saved"); }
    }
}
