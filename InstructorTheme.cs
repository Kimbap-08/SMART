using System.Security.Cryptography;
using System.Text;
using System.Runtime.CompilerServices;

namespace SMART;

public static class InstructorTheme
{
    private sealed record Original(Color Back, Color Fore);
    private static readonly ConditionalWeakTable<Control, Original> Originals = new();
    private sealed class NavigationIcon
    {
        public Image Original { get; }
        public Bitmap? Light { get; set; }
        public NavigationIcon(Image original) => Original = original;
    }
    private static readonly ConditionalWeakTable<PictureBox, NavigationIcon> NavigationIcons = new();

    internal static void RefreshNavigationIcon(PictureBox pictureBox)
    {
        if (pictureBox.Name is not ("picSettingsInstructor" or "picSignOutInstructor" or "picDashboardInstructor" or "picLogoInstructor" or "picProfileSettings" or "picDisplaySettings")) return;
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
    public static Color Background => IsLight ? Color.FromArgb(245, 247, 251) : Color.FromArgb(13, 17, 38);
    public static Color Surface => IsLight ? Color.White : Color.FromArgb(22, 33, 62);
    public static Color Text => IsLight ? Color.FromArgb(25, 35, 55) : Color.White;
    public static Color Muted => IsLight ? Color.FromArgb(85, 95, 115) : Color.FromArgb(150, 150, 170);
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
        bool darkSurface = back.ToArgb() == Color.FromArgb(22, 33, 62).ToArgb();
        control.BackColor = IsLight && darkBackground ? Background : IsLight && darkSurface ? Surface : back;
        if (original.Fore.ToArgb() == Color.White.ToArgb())
            control.ForeColor = IsLight && (control is not Button || darkSurface || darkBackground) && (control.Parent == null || control.Parent.BackColor != Color.FromArgb(233, 69, 96)) ? Text : original.Fore;
        else if (original.Fore.ToArgb() == Color.FromArgb(150, 150, 170).ToArgb() || original.Fore.ToArgb() == Color.FromArgb(170, 170, 185).ToArgb())
            control.ForeColor = Muted;
        else control.ForeColor = original.Fore;
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
            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = Text;
            grid.AlternatingRowsDefaultCellStyle.BackColor = IsLight ? Color.FromArgb(238, 242, 249) : Color.FromArgb(28, 40, 72);
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Text;
        }
    }
}