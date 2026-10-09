using System.Data;
using System.Data.SqlClient;

namespace SMART;

public sealed class ScheduleControl : UserControl
{
    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color GridLineColor = Color.FromArgb(35, 45, 70);
    private static readonly Color HeaderColor = Color.FromArgb(10, 15, 35);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private static readonly Color[] CourseColors =
    {
        Color.FromArgb(106, 13, 173), Color.FromArgb(0, 102, 204),
        Color.FromArgb(0, 140, 80), Color.FromArgb(180, 80, 0),
        Color.FromArgb(140, 0, 140), Color.FromArgb(0, 130, 130)
    };
    private static readonly string[] Days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    private const int TimeColumnWidth = 80;
    private const int DayColumnMinWidth = 150;
    private const int SlotHeight = 40;
    private const int HeaderHeight = 34;
    private const int StartHour = 7;
    private const int EndHour = 21;

    private readonly string employeeId;
    private readonly ComboBox termPicker = new();
    private readonly Panel dayHeader = new();
    private readonly Panel scheduleScroll = new();
    private readonly Panel scheduleCanvas = new();
    private readonly FlowLayoutPanel courseLegend = new();
    private readonly Label statusLabel = new();
    private readonly ToolTip courseToolTip = new();
    private List<ScheduleCourse> allCourses = new();
    private bool buildingCanvas;
    private int dayColumnWidth = DayColumnMinWidth;

    private sealed record ScheduleCourse(int Id, string Title, string Name, string Room,
        string Day, string Time, string Term, string Program);

    private sealed record TimeRange(TimeSpan Start, TimeSpan End);

    public ScheduleControl(string employeeId)
    {
        this.employeeId = employeeId;
        BackColor = BgColor;
        BuildLayout();
        Load += (_, _) => LoadCourses();
    }

    private void BuildLayout()
    {
        var root = new TableLayoutPanel
        {
            Dock = DockStyle.Fill, BackColor = BgColor, ColumnCount = 1,
            RowCount = 4, Padding = new Padding(4)
        };
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 62));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, HeaderHeight));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 62));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 38));

        var heading = new Panel { Dock = DockStyle.Fill, BackColor = BgColor };
        var title = new Label
        {
            Text = "🗓 Class Schedule", Location = new Point(0, 0), Size = new Size(450, 36),
            ForeColor = Color.White, Font = new Font("Segoe UI", 20F, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleLeft
        };
        var subtitle = new Label
        {
            Text = "Your assigned courses this term", Location = new Point(2, 36),
            Size = new Size(450, 22), ForeColor = TextGray, Font = new Font("Segoe UI", 9F)
        };
        termPicker.DropDownStyle = ComboBoxStyle.DropDownList;
        termPicker.BackColor = CardColor;
        termPicker.ForeColor = Color.White;
        termPicker.Font = new Font("Segoe UI", 9F);
        termPicker.Width = 175;
        termPicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        termPicker.Location = new Point(Math.Max(0, Width - 190), 14);
        termPicker.SelectedIndexChanged += (_, _) => { if (!buildingCanvas) RenderSchedule(); };
        var termCaption = new Label
        {
            Text = "Term:", Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Size = new Size(48, 26), ForeColor = TextGray,
            TextAlign = ContentAlignment.MiddleRight, Location = new Point(Math.Max(0, Width - 244), 14)
        };
        var print = MakeButton("🖨 Print Schedule", AccentColor, 155, 34);
        print.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        print.Location = new Point(Math.Max(0, Width - 410), 10);
        print.Click += (_, _) => CopyScheduleToClipboard();
        heading.Resize += (_, _) =>
        {
            termPicker.Left = Math.Max(0, heading.ClientSize.Width - termPicker.Width);
            termCaption.Left = termPicker.Left - termCaption.Width - 6;
            print.Left = Math.Max(0, termCaption.Left - print.Width - 12);
        };
        heading.Controls.Add(title);
        heading.Controls.Add(subtitle);
        heading.Controls.Add(termCaption);
        heading.Controls.Add(termPicker);
        heading.Controls.Add(print);

        dayHeader.Dock = DockStyle.Fill;
        dayHeader.BackColor = HeaderColor;
        scheduleScroll.Dock = DockStyle.Fill;
        scheduleScroll.BackColor = BgColor;
        scheduleScroll.AutoScroll = true;
        scheduleScroll.Resize += (_, _) => ResizeCanvas();
        scheduleScroll.Scroll += (_, _) => SyncDayHeader();
        scheduleCanvas.Location = Point.Empty;
        scheduleCanvas.BackColor = BgColor;
        scheduleCanvas.Paint += DrawGrid;
        scheduleScroll.Controls.Add(scheduleCanvas);

        var legendPanel = new CustomPanel
        {
            Dock = DockStyle.Fill, BackColor = BgColor, BorderColor = BgColor,
            BorderWidth = 0, CornerRadius = 1, Padding = new Padding(2, 4, 2, 2)
        };
        var legendHeading = new Label
        {
            Text = "Courses", Dock = DockStyle.Top, Height = 28,
            ForeColor = Color.White, Font = new Font("Segoe UI", 13F, FontStyle.Bold)
        };
        courseLegend.Dock = DockStyle.Fill;
        courseLegend.AutoScroll = true;
        courseLegend.WrapContents = true;
        courseLegend.FlowDirection = FlowDirection.LeftToRight;
        courseLegend.BackColor = BgColor;
        legendPanel.Controls.Add(courseLegend);
        legendPanel.Controls.Add(legendHeading);
        statusLabel.Dock = DockStyle.Bottom;
        statusLabel.Height = 22;
        statusLabel.ForeColor = TextGray;
        legendPanel.Controls.Add(statusLabel);

        root.Controls.Add(heading, 0, 0);
        root.Controls.Add(dayHeader, 0, 1);
        root.Controls.Add(scheduleScroll, 0, 2);
        root.Controls.Add(legendPanel, 0, 3);
        Controls.Add(root);
    }

    private void LoadCourses()
    {
        buildingCanvas = true;
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT CourseRecordID, CourseTitle, CourseName,
                    RoomNumber, Day, Time, Term, Program
                FROM dbo.Courses WHERE InstructorEmployeeID = @empId
                ORDER BY CourseTitle", connection);
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            using var reader = command.ExecuteReader();
            allCourses = new List<ScheduleCourse>();
            while (reader.Read())
                allCourses.Add(new ScheduleCourse(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), reader.GetString(6), reader.GetString(7)));

            termPicker.Items.Clear();
            termPicker.Items.Add("All Terms");
            foreach (string term in allCourses.Select(course => course.Term)
                         .Where(term => !string.IsNullOrWhiteSpace(term)).Distinct(StringComparer.OrdinalIgnoreCase)
                         .OrderBy(term => term))
                termPicker.Items.Add(term);
            termPicker.SelectedIndex = 0;
            statusLabel.Text = "";
        }
        catch (SqlException ex)
        {
            allCourses.Clear();
            statusLabel.Text = "Could not load schedule: " + ex.Message;
            statusLabel.ForeColor = AccentColor;
        }
        finally { buildingCanvas = false; }
        RenderSchedule();
    }

    private List<ScheduleCourse> VisibleCourses()
    {
        string selectedTerm = Convert.ToString(termPicker.SelectedItem) ?? "All Terms";
        return selectedTerm == "All Terms" ? allCourses
            : allCourses.Where(course => course.Term.Equals(selectedTerm, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    private void RenderSchedule()
    {
        if (IsDisposed || scheduleCanvas.IsDisposed) return;
        var courses = VisibleCourses();
        BuildDayHeader();
        BuildCanvas(courses);
        BuildLegend(courses);
    }

    private void BuildDayHeader()
    {
        foreach (Control old in dayHeader.Controls.Cast<Control>().ToArray())
        {
            dayHeader.Controls.Remove(old);
            old.Dispose();
        }
        int availableWidth = Math.Max(scheduleScroll.ClientSize.Width, TimeColumnWidth + 6 * DayColumnMinWidth);
        dayColumnWidth = Math.Max(DayColumnMinWidth, (availableWidth - TimeColumnWidth) / Days.Length);
        dayHeader.Width = availableWidth;
        dayHeader.Controls.Add(new Label
        {
            Text = "Time", Location = Point.Empty, Size = new Size(TimeColumnWidth, HeaderHeight),
            BackColor = HeaderColor, ForeColor = TextGray, Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter
        });
        for (int i = 0; i < Days.Length; i++)
            dayHeader.Controls.Add(new Label
            {
                Text = Days[i], Location = new Point(TimeColumnWidth + i * dayColumnWidth - scheduleScroll.HorizontalScroll.Value, 0),
                Size = new Size(dayColumnWidth, HeaderHeight), BackColor = HeaderColor,
                ForeColor = Color.White, Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            });
    }

    private void SyncDayHeader()
    {
        for (int i = 0; i < Days.Length && i + 1 < dayHeader.Controls.Count; i++)
            dayHeader.Controls[i + 1].Left = TimeColumnWidth + i * dayColumnWidth - scheduleScroll.HorizontalScroll.Value;
    }

    private void BuildCanvas(List<ScheduleCourse> courses)
    {
        int availableWidth = Math.Max(scheduleScroll.ClientSize.Width, TimeColumnWidth + 6 * DayColumnMinWidth);
        int columnWidth = Math.Max(DayColumnMinWidth, (availableWidth - TimeColumnWidth) / Days.Length);
        scheduleCanvas.SuspendLayout();
        foreach (Control old in scheduleCanvas.Controls.Cast<Control>().ToArray())
        {
            scheduleCanvas.Controls.Remove(old);
            old.Dispose();
        }
        scheduleCanvas.Size = new Size(TimeColumnWidth + columnWidth * Days.Length,
            (EndHour - StartHour) * 2 * SlotHeight);
        scheduleScroll.AutoScrollMinSize = scheduleCanvas.Size;
        if (courses.Count == 0)
        {
            var empty = new Label
            {
                Text = "No courses assigned yet.\nContact admin to assign courses.",
                Location = new Point(TimeColumnWidth + 12, 16),
                Size = new Size(scheduleCanvas.Width - TimeColumnWidth - 24, 70),
                ForeColor = Color.FromArgb(170, 170, 170), Font = new Font("Segoe UI", 12F),
                TextAlign = ContentAlignment.MiddleCenter, BackColor = Color.Transparent
            };
            scheduleCanvas.Controls.Add(empty);
        }
        for (int slot = 0; slot <= (EndHour - StartHour) * 2; slot++)
        {
            var time = new TimeSpan(StartHour, 0, 0).Add(TimeSpan.FromMinutes(slot * 30));
            var timeLabel = new Label
            {
                Text = DateTime.Today.Add(time).ToString("h:mm tt"),
                Location = new Point(0, slot * SlotHeight), Size = new Size(TimeColumnWidth - 4, SlotHeight),
                ForeColor = TextGray, Font = new Font("Segoe UI", 8F),
                TextAlign = ContentAlignment.TopRight, BackColor = BgColor
            };
            scheduleCanvas.Controls.Add(timeLabel);
        }

        for (int courseIndex = 0; courseIndex < courses.Count; courseIndex++)
        {
            ScheduleCourse course = courses[courseIndex];
            if (!TryParseTime(course.Time, out TimeRange range)) continue;
            TimeSpan dayStart = new(StartHour, 0, 0);
            TimeSpan dayEnd = new(EndHour, 0, 0);
            TimeSpan clippedStart = range.Start < dayStart ? dayStart : range.Start;
            TimeSpan clippedEnd = range.End > dayEnd ? dayEnd : range.End;
            if (clippedEnd <= clippedStart) continue;
            int y = (int)Math.Round((clippedStart - dayStart).TotalMinutes / 30 * SlotHeight);
            int height = Math.Max(20, (int)Math.Round((clippedEnd - clippedStart).TotalMinutes / 30 * SlotHeight));
            foreach (string day in ParseDays(course.Day))
            {
                int dayIndex = Array.IndexOf(Days, day);
                if (dayIndex < 0) continue;
                int x = TimeColumnWidth + dayIndex * columnWidth + 4;
                int colorIndex = allCourses.IndexOf(course);
                var block = CreateCourseBlock(course, CourseColors[colorIndex % CourseColors.Length],
                    x, y, columnWidth - 8, height);
                scheduleCanvas.Controls.Add(block);
                block.BringToFront();
            }
        }
        scheduleCanvas.ResumeLayout(true);
        scheduleCanvas.Invalidate();
    }

    private Control CreateCourseBlock(ScheduleCourse course, Color color, int x, int y, int width, int height)
    {
        var block = new CustomPanel
        {
            Location = new Point(x, y), Size = new Size(width, height),
            BackColor = color, BorderColor = ControlPaint.Light(color), BorderWidth = 1,
            CornerRadius = 7, Padding = new Padding(5, 2, 3, 2)
        };
        var title = new Label
        {
            Text = course.Title, Dock = DockStyle.Top, Height = Math.Min(19, Math.Max(14, height / 3)),
            ForeColor = Color.White, Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            AutoEllipsis = true, BackColor = Color.Transparent
        };
        block.Controls.Add(title);
        if (height >= 38)
        {
            var name = new Label
            {
                Text = course.Name, Dock = DockStyle.Top, Height = 15, ForeColor = Color.White,
                Font = new Font("Segoe UI", 7.5F), AutoEllipsis = true, BackColor = Color.Transparent
            };
            block.Controls.Add(name);
        }
        if (height >= 58)
        {
            var room = new Label
            {
                Text = course.Room, Dock = DockStyle.Top, Height = 15, ForeColor = Color.Gainsboro,
                Font = new Font("Segoe UI", 7.5F), AutoEllipsis = true, BackColor = Color.Transparent
            };
            block.Controls.Add(room);
        }
        string details = $"{course.Title} — {course.Name}\nRoom: {course.Room}\n{course.Day} {course.Time} | {course.Term} | {course.Program}";
        courseToolTip.SetToolTip(block, details);
        foreach (Control child in block.Controls) courseToolTip.SetToolTip(child, details);
        return block;
    }

    private void DrawGrid(object? sender, PaintEventArgs e)
    {
        int columnWidth = Math.Max(DayColumnMinWidth, (scheduleCanvas.Width - TimeColumnWidth) / Days.Length);
        using var gridPen = new Pen(GridLineColor, 1);
        int totalSlots = (EndHour - StartHour) * 2;
        for (int slot = 0; slot <= totalSlots; slot++)
        {
            int y = slot * SlotHeight;
            e.Graphics.DrawLine(gridPen, 0, y, scheduleCanvas.Width, y);
        }
        e.Graphics.DrawLine(gridPen, TimeColumnWidth, 0, TimeColumnWidth, scheduleCanvas.Height);
        for (int day = 0; day <= Days.Length; day++)
        {
            int x = TimeColumnWidth + day * columnWidth;
            e.Graphics.DrawLine(gridPen, x, 0, x, scheduleCanvas.Height);
        }

        DateTime now = DateTime.Now;
        if (now.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday) return;
        TimeSpan start = new(StartHour, 0, 0);
        double minutes = (now.TimeOfDay - start).TotalMinutes;
        if (minutes < 0 || minutes > (EndHour - StartHour) * 60) return;
        int yNow = (int)(minutes / 30 * SlotHeight);
        using var timePen = new Pen(AccentColor, 2);
        e.Graphics.DrawLine(timePen, TimeColumnWidth, yNow, scheduleCanvas.Width, yNow);
        using var dotBrush = new SolidBrush(AccentColor);
        e.Graphics.FillEllipse(dotBrush, TimeColumnWidth - 6, yNow - 5, 10, 10);
    }

    private void BuildLegend(List<ScheduleCourse> courses)
    {
        courseLegend.SuspendLayout();
        foreach (Control old in courseLegend.Controls.Cast<Control>().ToArray())
        {
            courseLegend.Controls.Remove(old);
            old.Dispose();
        }
        for (int i = 0; i < courses.Count; i++)
        {
            ScheduleCourse course = courses[i];
            Color color = CourseColors[allCourses.IndexOf(course) % CourseColors.Length];
            var card = new CustomPanel
            {
                Size = new Size(330, 78), BackColor = CardColor,
                BorderColor = color, BorderWidth = 2, CornerRadius = 7,
                Margin = new Padding(4, 3, 8, 5), Padding = new Padding(10)
            };
            var swatch = new Panel { BackColor = color, Location = new Point(10, 13), Size = new Size(18, 18) };
            var title = new Label
            {
                Text = course.Title + " — " + course.Name, Location = new Point(38, 8),
                Size = new Size(278, 24), ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold), AutoEllipsis = true
            };
            var details = new Label
            {
                Text = $"Room: {course.Room}  |  {course.Day} {course.Time}  |  {course.Term}",
                Location = new Point(38, 35), Size = new Size(278, 30), ForeColor = TextGray,
                Font = new Font("Segoe UI", 8F), AutoEllipsis = true
            };
            card.Controls.Add(swatch);
            card.Controls.Add(title);
            card.Controls.Add(details);
            courseLegend.Controls.Add(card);
        }
        courseLegend.ResumeLayout(true);
    }

    private void ResizeCanvas()
    {
        if (buildingCanvas || scheduleScroll.ClientSize.Width <= 0) return;
        RenderSchedule();
    }

    private static List<string> ParseDays(string dayString)
    {
        string value = (dayString ?? "").Trim();
        string lower = value.ToLowerInvariant();
        if (lower.Contains("daily") || lower.Contains("mtwthf")) return new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri" };
        if (lower is "m-sa" or "m-sa1" or "m-sa2" or "m-sat") return new List<string>(Days);
        if (lower is "m-fri" or "m-f") return new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri" };
        if (lower is "sa" or "sat" or "saturday") return new List<string> { "Sat" };

        bool monday = lower.Contains("mon") || lower.Contains('m');
        bool tuesday = lower.Contains("tue");
        bool thursday = lower.Contains("thu") || lower.Contains("th");
        bool wednesday = lower.Contains("wed");
        bool friday = lower.Contains("fri");
        bool saturday = lower.Contains("sat") || lower.Contains("sa");
        string compact = lower.Replace("thursday", "", StringComparison.Ordinal)
            .Replace("thu", "", StringComparison.Ordinal)
            .Replace("th", "", StringComparison.Ordinal)
            .Replace("tuesday", "", StringComparison.Ordinal)
            .Replace("tue", "", StringComparison.Ordinal)
            .Replace("wednesday", "", StringComparison.Ordinal)
            .Replace("wed", "", StringComparison.Ordinal)
            .Replace("monday", "", StringComparison.Ordinal)
            .Replace("mon", "", StringComparison.Ordinal)
            .Replace("friday", "", StringComparison.Ordinal)
            .Replace("fri", "", StringComparison.Ordinal)
            .Replace("saturday", "", StringComparison.Ordinal)
            .Replace("sat", "", StringComparison.Ordinal)
            .Replace("sa", "", StringComparison.Ordinal);
        tuesday |= compact.Contains('t');
        wednesday |= compact.Contains('w');
        friday |= compact.Contains('f');
        var days = new List<string>();
        if (monday) days.Add("Mon");
        if (tuesday) days.Add("Tue");
        if (wednesday) days.Add("Wed");
        if (thursday) days.Add("Thu");
        if (friday) days.Add("Fri");
        if (saturday) days.Add("Sat");
        return days;
    }

    private static bool TryParseTime(string value, out TimeRange range)
    {
        range = new TimeRange(TimeSpan.Zero, TimeSpan.Zero);
        if (string.IsNullOrWhiteSpace(value)) return false;
        int separator = value.IndexOf('-');
        if (separator < 0) return false;
        if (!TryParseTimeToken(value[..separator], out TimeSpan start) ||
            !TryParseTimeToken(value[(separator + 1)..], out TimeSpan end) || end <= start)
            return false;
        range = new TimeRange(start, end);
        return true;
    }

    private static bool TryParseTimeToken(string token, out TimeSpan time)
    {
        string value = token.Trim().ToUpperInvariant().Replace(" ", "");
        bool isPm = value.EndsWith("PM", StringComparison.Ordinal) || value.EndsWith('P') || value.EndsWith('E');
        bool hasMeridiem = isPm || value.EndsWith("AM", StringComparison.Ordinal) || value.EndsWith('A');
        if (value.EndsWith("AM", StringComparison.Ordinal) || value.EndsWith("PM", StringComparison.Ordinal))
            value = value[..^2];
        else if (hasMeridiem) value = value[..^1];

        string[] parts = value.Split(':');
        if (parts.Length is < 1 or > 2 || !int.TryParse(parts[0], out int hour))
        {
            time = TimeSpan.Zero;
            return false;
        }
        int minute = 0;
        if (parts.Length == 2 && !int.TryParse(parts[1], out minute))
        {
            time = TimeSpan.Zero;
            return false;
        }
        if (minute < 0 || minute > 59 || hour < 0 || hour > 24 || (hour == 24 && minute != 0))
        {
            time = TimeSpan.Zero;
            return false;
        }
        if (hasMeridiem)
        {
            if (hour is < 1 or > 12) { time = TimeSpan.Zero; return false; }
            if (isPm && hour < 12) hour += 12;
            if (!isPm && hour == 12) hour = 0;
        }
        time = new TimeSpan(hour, minute, 0);
        return true;
    }

    private void CopyScheduleToClipboard()
    {
        var courses = VisibleCourses();
        string text = "Class Schedule — " + (Convert.ToString(termPicker.SelectedItem) ?? "All Terms") + Environment.NewLine +
            string.Join(Environment.NewLine, courses.Select(course =>
                $"{course.Title} — {course.Name} | {course.Day} {course.Time} | Room {course.Room} | {course.Term}"));
        try
        {
            Clipboard.SetText(text);
            statusLabel.Text = "Schedule copied to clipboard.";
            statusLabel.ForeColor = Color.LimeGreen;
        }
        catch (Exception ex) when (ex is System.Runtime.InteropServices.ExternalException or ThreadStateException)
        {
            statusLabel.Text = "Could not copy schedule: " + ex.Message;
            statusLabel.ForeColor = AccentColor;
        }
    }

    private SqlConnection OpenConnection()
    {
        var connection = new SqlConnection(DatabaseConnection.ConnectionString);
        try { DatabaseConnection.Open(connection); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private static CustomButton MakeButton(string text, Color color, int width, int height) => new()
    {
        Text = text, BackColor = color, ForeColor = Color.White,
        Size = new Size(width, height), BorderRadius = 6, BorderSize = 0,
        Cursor = Cursors.Hand, Font = new Font("Segoe UI", 9F, FontStyle.Bold)
    };
}
