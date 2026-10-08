namespace SMART;

public partial class InstructorSettings : Form
{
    public InstructorSettings()
    {
        InitializeComponent();
        InstructorTheme.Apply(this);
    }
    private void Back_Click(object? sender, EventArgs e) => Close();
    private void BtnProfileSettings_Click(object? sender, EventArgs e) => OpenSection(InstructorSettingsDestination.Profile);
    private void BtnDisplaySettings_Click(object? sender, EventArgs e) => OpenSection(InstructorSettingsDestination.Display);

    private void OpenSection(InstructorSettingsDestination destination)
    {
        while (destination is InstructorSettingsDestination.Profile or InstructorSettingsDestination.Display)
        {
            if (destination == InstructorSettingsDestination.Profile)
            {
                using var form = new InstructorProfileSettings();
                form.ShowDialog(this);
                destination = form.Destination;
            }
            else
            {
                using var form = new InstructorDisplaySettings();
                form.ShowDialog(this);
                destination = form.Destination;
            }
            InstructorTheme.Apply(this);
        }
        if (destination == InstructorSettingsDestination.Dashboard) Close();
    }
}