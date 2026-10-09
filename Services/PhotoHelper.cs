using System.Drawing.Drawing2D;

namespace SMART;

public static class PhotoHelper
{
    public static void DrawInitials(PictureBox pictureBox, string name)
    {
        if (pictureBox.Width <= 0 || pictureBox.Height <= 0) return;
        string initials = string.Concat((name ?? "").Trim()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Take(2).Select(word => char.ToUpperInvariant(word[0])));
        if (initials.Length == 0) initials = "?";

        var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        using (var graphics = Graphics.FromImage(bitmap))
        using (var font = new Font("Segoe UI", Math.Max(8F, pictureBox.Width / 3.2F), FontStyle.Bold))
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.FromArgb(233, 69, 96));
            var size = graphics.MeasureString(initials, font);
            graphics.DrawString(initials, font, Brushes.White,
                (pictureBox.Width - size.Width) / 2, (pictureBox.Height - size.Height) / 2);
        }
        var oldImage = pictureBox.Image;
        pictureBox.Image = bitmap;
        if (oldImage != null && !ReferenceEquals(oldImage, bitmap)) oldImage.Dispose();
    }

    public static void LoadPhoto(PictureBox pictureBox, byte[]? photoBytes, string name)
    {
        if (photoBytes is { Length: > 0 })
        {
            try
            {
                using var stream = new MemoryStream(photoBytes);
                using var source = Image.FromStream(stream);
                var image = new Bitmap(source);
                var oldImage = pictureBox.Image;
                pictureBox.Image = image;
                if (oldImage != null && !ReferenceEquals(oldImage, image)) oldImage.Dispose();
                return;
            }
            catch (ArgumentException) { }
            catch (OutOfMemoryException) { }
        }
        DrawDefaultProfile(pictureBox);
    }

    public static void DrawDefaultProfile(PictureBox pictureBox)
    {
        if (pictureBox.Width <= 0 || pictureBox.Height <= 0) return;
        var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        using (var graphics = Graphics.FromImage(bitmap))
        using (var brush = new SolidBrush(Color.FromArgb(150, 150, 170)))
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            float w = bitmap.Width, h = bitmap.Height;
            graphics.FillEllipse(brush, w * .32F, h * .12F, w * .36F, h * .36F);
            graphics.FillEllipse(brush, w * .16F, h * .52F, w * .68F, h * .60F);
        }
        var oldImage = pictureBox.Image;
        pictureBox.Image = bitmap;
        oldImage?.Dispose();
    }

    public static void MakeCircular(PictureBox pictureBox)
    {
        void UpdateRegion(object? sender, EventArgs e)
        {
            if (pictureBox.Width <= 0 || pictureBox.Height <= 0) return;
            using var path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
            var oldRegion = pictureBox.Region;
            pictureBox.Region = new Region(path);
            oldRegion?.Dispose();
        }
        pictureBox.SizeChanged += UpdateRegion;
        UpdateRegion(pictureBox, EventArgs.Empty);
    }
}
