using System.Security.Cryptography;
using System.Text;
using System.Runtime.CompilerServices;

namespace SMART
{

public static class InstructorTheme
{
    private sealed record Original(Color Back, Color Fore);
    private static readonly ConditionalWeakTable<Control, Original> Originals = new();
    private static readonly System.ComponentModel.ComponentResourceManager BackgroundResources = new(typeof(InstructorUI));
    private static Image? darkImage;
    private static Image? lightImage;
    private static Image ThemeImage => IsLight
        ? lightImage ??= (Image)BackgroundResources.GetObject("InstructorLightBackground.Image")!
        : darkImage ??= (Image)BackgroundResources.GetObject("InstructorBackground.Image")!;
    private sealed class NavigationIcon
    {
        public Image Original { get; }
        public Bitmap? Light { get; set; }
        public NavigationIcon(Image original) => Original = original;
    }
    private static readonly ConditionalWeakTable<PictureBox, NavigationIcon> NavigationIcons = new();

    internal static void RefreshNavigationIcon(PictureBox pictureBox)
    {
        if (pictureBox.Name is not ("picSettingsInstructor" or "picSignOutInstructor" or "picDashboardInstructor" or "picLogoInstructor" or "picProfileSettings" or "picDisplaySettings" or "picScheduleInstructor" or "picAnnouncementsInstructor" or "picCalendarInstructor" or "picNotesInstructor" or "picAssistInstructor")) return;
        if (pictureBox.BackgroundImage == null) return;
        var icon = NavigationIcons.GetValue(pictureBox, picture =>
        {
            var state = new NavigationIcon(picture.BackgroundImage!);
            picture.Disposed += (_, _) => state.Light?.Dispose();
            return state;
        });
        bool lightRow = IsLight && pictureBox.Parent?.BackColor != Color.FromArgb(233, 69, 96);
        if (lightRow && icon.Light == null)
        {
            var bitmap = new Bitmap(icon.Original.Width, icon.Original.Height);
            using var graphics = Graphics.FromImage(bitmap);
            using var attributes = new System.Drawing.Imaging.ImageAttributes();
            // Replace RGB while retaining the PNG's alpha channel and antialiased edges.
            var matrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
            {
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 25F / 255F, 35F / 255F, 55F / 255F, 0, 1 }
            });
            attributes.SetColorMatrix(matrix);
            graphics.DrawImage(icon.Original, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                0, 0, icon.Original.Width, icon.Original.Height, GraphicsUnit.Pixel, attributes);
            icon.Light = bitmap;
        }
        pictureBox.BackgroundImage = lightRow ? icon.Light : icon.Original;
    }

    public static bool IsLight { get; private set; }
    public static Color Background => IsLight ? Color.FromArgb(225, 228, 233) : Color.FromArgb(13, 17, 38);
    public static Color Surface => IsLight ? Color.White : Color.FromArgb(22, 33, 62);
    public static Color Text => IsLight ? Color.FromArgb(25, 35, 55) : Color.White;
    public static Color Muted => IsLight ? Color.FromArgb(45, 55, 70) : Color.FromArgb(150, 150, 170);
    public static Color Hover => IsLight ? Color.FromArgb(232, 237, 247) : Color.FromArgb(30, 42, 69);
    private static string PreferencePath
    {
        get
        {
            string key = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(Session.CurrentUser?.Username ?? "")));
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SMART", "display", key + ".txt");
        }
    }
    public static void LoadPreference()
    {
        IsLight = false;
        try { IsLight = File.Exists(PreferencePath) && File.ReadAllText(PreferencePath) == "Light"; }
        catch (IOException) { }
        catch (UnauthorizedAccessException) { }
    }
    public static void SavePreference(bool light)
    {
        string path = PreferencePath;
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        File.WriteAllText(path, light ? "Light" : "Dark");
        IsLight = light;
    }
    public static void Apply(Control root)
    {
        using var update = new ThemeUpdateScope(root);
        if (root is InstructorUI instructor) instructor.ApplyBackground(ThemeImage);
        else if (root is InstructorSettings settings) settings.ApplyBackground(ThemeImage);
        Capture(root);
        ApplyTree(root);
    }
    private static void Capture(Control control)
    {
        Originals.GetValue(control, c => new Original(c.BackColor, c.ForeColor));
        foreach (Control child in control.Controls) Capture(child);
    }
    private static void ApplyTree(Control control)
    {
        ApplyOne(control);
        foreach (Control child in control.Controls) ApplyTree(child);
    }
    private static void ApplyOne(Control control)
    {
        var original = Originals.GetValue(control, c => new Original(c.BackColor, c.ForeColor));
        Color back = original.Back;
        bool darkBackground = back.ToArgb() == Color.FromArgb(13, 17, 38).ToArgb() || back.ToArgb() == Color.FromArgb(26, 26, 46).ToArgb();
        darkBackground |= back.ToArgb() == Color.FromArgb(18, 24, 48).ToArgb() || back.ToArgb() == Color.FromArgb(10, 15, 35).ToArgb();
        bool darkSurface = back.ToArgb() == Color.FromArgb(22, 33, 62).ToArgb();
        bool tintedSurface = back.A < 255 && back.A > 0 && back.R == 22 && back.G == 33 && back.B == 62;
        control.BackColor = IsLight && darkBackground ? Background : IsLight && darkSurface ? Surface : back;
        if (IsLight && tintedSurface) control.BackColor = Color.FromArgb(150, Surface);
        if (original.Fore.ToArgb() == Color.White.ToArgb())
            control.ForeColor = IsLight && (control is not Button || darkSurface || darkBackground) && (control.Parent == null || control.Parent.BackColor != Color.FromArgb(233, 69, 96)) ? Text : original.Fore;
        else if (original.Fore.ToArgb() == Color.FromArgb(150, 150, 170).ToArgb() || original.Fore.ToArgb() == Color.FromArgb(170, 170, 185).ToArgb())
            control.ForeColor = Muted;
        else control.ForeColor = original.Fore;
        if (IsLight && control is Label && original.Fore.ToArgb() == Color.FromArgb(233, 69, 96).ToArgb())
            control.ForeColor = Color.FromArgb(180, 25, 55);
        bool blended = control.BackgroundImage != null;
        for (Control? ancestor = control.Parent; !blended && ancestor != null; ancestor = ancestor.Parent)
            blended = ancestor is InstructorUI || ancestor.BackgroundImage != null;
        if (blended && control is not TranslucentSidebarPanel)
        {
            if (control is SplitContainer)
                control.BackColor = Color.Transparent;
            else if (control is UserControl && control is not RoundedTextBox)
                control.BackColor = Color.Transparent;
            else if (control is Panel || control is Label)
            {
                if (control is Panel && control.Name == "scheduleCanvas")
                    control.BackColor = Color.FromArgb(210, Background);
                else if (darkBackground) control.BackColor = Color.Transparent;
                else if (darkSurface)
                {
                    // Layout panels should not stack multiple white overlays.
                    bool surfaceParent = control.Parent is Panel && control.Parent.BackColor.A > 0 && control.Parent.BackColor.A < 255;
                    control.BackColor = IsLight && surfaceParent ? Color.Transparent
                        : Color.FromArgb(IsLight ? 150 : 178, IsLight ? Color.White : Color.FromArgb(22, 33, 62));
                }
            }
        }
        if (control is PictureBox navigationPicture) RefreshNavigationIcon(navigationPicture);
        if (control is RoundedTextBox roundedInput)
        {
            roundedInput.FillColor = Surface;
            roundedInput.ForeColor = Text;
        }
        if (control is TextBox or ComboBox or NumericUpDown)
        {
            control.BackColor = Surface;
            control.ForeColor = Text;
        }
        if (control is DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Surface;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Text;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Surface;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Text;
            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = Text;
            grid.AlternatingRowsDefaultCellStyle.BackColor = IsLight ? Color.FromArgb(238, 242, 249) : Color.FromArgb(28, 40, 72);
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Text;
        }
        if (control is CustomPanel calendarCell && control.Name.StartsWith("dayCell", StringComparison.Ordinal) &&
            int.TryParse(control.Name.Substring(7), out int dayIndex))
        {
            if (IsLight)
            {
                calendarCell.BackColor = dayIndex % 7 is 0 or 6 ? Color.FromArgb(232, 232, 232) : Color.White;
                calendarCell.BorderColor = Color.FromArgb(200, 200, 200);
            }
            if (calendarCell.Tag is DateTime date && date.Date == DateTime.Today)
            {
                calendarCell.BackColor = IsLight ? Color.FromArgb(255, 228, 233) : Color.FromArgb(60, 30, 50);
                calendarCell.BorderColor = Color.FromArgb(233, 69, 96);
            }
        }
        if (IsLight && control is Label && control.Parent?.Name.StartsWith("dayCell", StringComparison.Ordinal) == true)
            control.ForeColor = original.Fore == Color.FromArgb(85, 85, 119) ? Color.FromArgb(100, 100, 100) : Color.FromArgb(35, 35, 35);
    }
}

}
