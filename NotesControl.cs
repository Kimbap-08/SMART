using System.Data;
using System.Data.SqlClient;

namespace SMART;

public sealed class NotesControl : UserControl
{
    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private readonly string employeeId;
    private readonly FlowLayoutPanel notesList = new();
    private readonly RoundedTextBox titleInput = new();
    private readonly ComboBox colorPicker = new();
    private readonly RichTextBox contentInput = new();
    private readonly CustomButton deleteButton = new();
    private readonly Label saveStatus = new();
    private int? selectedNoteId;
    private bool loading;

    private sealed record Note(int Id, string Title, string Content, string Color, DateTime CreatedAt, DateTime UpdatedAt);
    private List<Note> notes = new();

    public NotesControl(string employeeId)
    {
        this.employeeId = employeeId;
        BackColor = BgColor;
        BuildLayout();
        Load += (_, _) => LoadNotes();
    }

    private void BuildLayout()
    {
        var heading = new Label
        {
            Text = "📝 My Notes", Dock = DockStyle.Top, Height = 42, ForeColor = Color.White,
            Font = new Font("Segoe UI", 21F, FontStyle.Bold)
        };
        var subtitle = new Label
        {
            Text = "Personal notes — only you can see these", Dock = DockStyle.Top, Height = 28,
            ForeColor = TextGray, Font = new Font("Segoe UI", 9.5F)
        };
        var split = new SplitContainer
        {
            Dock = DockStyle.Fill, Size = new Size(1000, 650), BackColor = BgColor, BorderStyle = BorderStyle.None,
            Orientation = Orientation.Vertical, SplitterWidth = 8, SplitterDistance = 280,
            FixedPanel = FixedPanel.Panel1, Panel1MinSize = 250, Panel2MinSize = 400
        };
        split.Panel1.BackColor = CardColor;
        split.Panel2.BackColor = BgColor;
        var listPanel = new CustomPanel
        {
            Dock = DockStyle.Fill, BackColor = CardColor, BorderColor = CardColor,
            BorderWidth = 0, CornerRadius = 8, Padding = new Padding(10)
        };
        var newButton = MakeButton("+ New Note", AccentColor, 240, 36);
        newButton.Dock = DockStyle.Top;
        newButton.Click += (_, _) => BeginNewNote();
        notesList.Dock = DockStyle.Fill;
        notesList.FlowDirection = FlowDirection.TopDown;
        notesList.WrapContents = false;
        notesList.AutoScroll = true;
        notesList.BackColor = CardColor;
        listPanel.Controls.Add(notesList);
        listPanel.Controls.Add(newButton);
        split.Panel1.Controls.Add(listPanel);
        split.Panel2.Controls.Add(BuildEditor());
        Controls.Add(split);
        Controls.Add(subtitle);
        Controls.Add(heading);
    }

    private Control BuildEditor()
    {
        var editor = new CustomPanel
        {
            Dock = DockStyle.Fill, BackColor = BgColor, BorderColor = BgColor,
            BorderWidth = 0, CornerRadius = 1, Padding = new Padding(16)
        };
        var layout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill, BackColor = BgColor, ColumnCount = 1, RowCount = 6
        };
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
        var titleLabel = MakeLabel("Title");
        ConfigureInput(titleInput, "Note title...");
        titleInput.Dock = DockStyle.Fill;
        colorPicker.DropDownStyle = ComboBoxStyle.DropDownList;
        colorPicker.Items.AddRange(new object[] { "Default", "Yellow", "Blue", "Green", "Red" });
        colorPicker.SelectedIndex = 0;
        colorPicker.BackColor = CardColor;
        colorPicker.ForeColor = Color.White;
        colorPicker.Font = new Font("Segoe UI", 9F);
        var colorRow = new FlowLayoutPanel { Dock = DockStyle.Fill, BackColor = BgColor, WrapContents = false };
        colorRow.Controls.Add(MakeLabel("Color"));
        colorPicker.Width = 130;
        colorPicker.Margin = new Padding(10, 2, 0, 0);
        colorRow.Controls.Add(colorPicker);
        contentInput.Dock = DockStyle.Fill;
        contentInput.BackColor = Color.FromArgb(18, 24, 48);
        contentInput.ForeColor = Color.White;
        contentInput.Font = new Font("Segoe UI", 11F);
        contentInput.BorderStyle = BorderStyle.None;
        contentInput.Padding = new Padding(8);
        var actions = new FlowLayoutPanel { Dock = DockStyle.Fill, BackColor = BgColor, WrapContents = false };
        var save = MakeButton("💾 SAVE NOTE", Color.FromArgb(0, 140, 0), 140, 36);
        save.Click += (_, _) => SaveNote();
        deleteButton.Text = "🗑 DELETE";
        deleteButton.BackColor = Color.FromArgb(80, 20, 30);
        deleteButton.ForeColor = AccentColor;
        deleteButton.Size = new Size(100, 36);
        deleteButton.BorderRadius = 6;
        deleteButton.BorderSize = 0;
        deleteButton.Visible = false;
        deleteButton.Click += (_, _) => DeleteNote();
        saveStatus.AutoSize = true;
        saveStatus.ForeColor = Color.LimeGreen;
        saveStatus.Padding = new Padding(6, 9, 0, 0);
        actions.Controls.Add(save);
        actions.Controls.Add(deleteButton);
        actions.Controls.Add(saveStatus);
        layout.Controls.Add(titleLabel, 0, 0);
        layout.Controls.Add(titleInput, 0, 1);
        layout.Controls.Add(colorRow, 0, 2);
        layout.Controls.Add(MakeLabel("Content"), 0, 3);
        layout.Controls.Add(contentInput, 0, 4);
        layout.Controls.Add(actions, 0, 5);
        editor.Controls.Add(layout);
        return editor;
    }

    private void LoadNotes(int? selectId = null)
    {
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT NoteId, Title, Content, Color, CreatedAt, UpdatedAt
                FROM dbo.Notes WHERE InstructorEmployeeID = @empId ORDER BY UpdatedAt DESC", connection);
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            using var reader = command.ExecuteReader();
            notes = new List<Note>();
            while (reader.Read())
                notes.Add(new Note(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetDateTime(4), reader.GetDateTime(5)));
            RenderNotes();
            if (selectId.HasValue)
            {
                var note = notes.FirstOrDefault(item => item.Id == selectId.Value);
                if (note != null) ShowNote(note);
            }
            saveStatus.Text = "";
        }
        catch (SqlException ex) { saveStatus.Text = "Could not load notes: " + ex.Message; saveStatus.ForeColor = AccentColor; }
    }

    private void RenderNotes()
    {
        notesList.SuspendLayout();
        foreach (Control old in notesList.Controls.Cast<Control>().ToArray())
        {
            notesList.Controls.Remove(old);
            old.Dispose();
        }
        foreach (var note in notes)
        {
            Color color = ColorForNote(note.Color);
            var card = new CustomPanel
            {
                Size = new Size(Math.Max(210, notesList.ClientSize.Width - 28), 70),
                BackColor = color, BorderColor = color, BorderWidth = 1, CornerRadius = 6,
                Margin = new Padding(2, 5, 2, 3), Padding = new Padding(10, 4, 5, 3),
                Cursor = Cursors.Hand, Tag = note.Id
            };
            var title = new Label
            {
                Text = "📌 " + note.Title, Dock = DockStyle.Top, Height = 21, AutoEllipsis = true,
                ForeColor = Color.White, Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand, Tag = note.Id
            };
            var preview = new Label
            {
                Text = note.Content.Length > 50 ? note.Content[..50] + "…" : note.Content,
                Dock = DockStyle.Top, Height = 19, AutoEllipsis = true,
                ForeColor = TextGray, Font = new Font("Segoe UI", 8F), Cursor = Cursors.Hand, Tag = note.Id
            };
            var date = new Label
            {
                Text = note.UpdatedAt.ToString("MMM d h:mm tt"), Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(120, 130, 155), Font = new Font("Segoe UI", 7F),
                Cursor = Cursors.Hand, Tag = note.Id
            };
            card.Controls.Add(date);
            card.Controls.Add(preview);
            card.Controls.Add(title);
            WireNoteCard(card);
            notesList.Controls.Add(card);
        }
        notesList.ResumeLayout(true);
    }

    private void WireNoteCard(Control control)
    {
        control.Click += (_, _) =>
        {
            int id = Convert.ToInt32(control.Tag);
            var note = notes.FirstOrDefault(item => item.Id == id);
            if (note != null) ShowNote(note);
        };
        foreach (Control child in control.Controls) WireNoteCard(child);
    }

    private void ShowNote(Note note)
    {
        loading = true;
        selectedNoteId = note.Id;
        titleInput.Text = note.Title;
        contentInput.Text = note.Content;
        colorPicker.SelectedItem = note.Color;
        if (colorPicker.SelectedIndex < 0) colorPicker.SelectedIndex = 0;
        deleteButton.Visible = true;
        saveStatus.Text = "Last saved: " + note.UpdatedAt.ToString("h:mm tt");
        saveStatus.ForeColor = Color.LimeGreen;
        loading = false;
    }

    private void BeginNewNote()
    {
        loading = true;
        selectedNoteId = null;
        titleInput.Text = "";
        contentInput.Clear();
        colorPicker.SelectedIndex = 0;
        deleteButton.Visible = false;
        saveStatus.Text = "";
        loading = false;
        titleInput.Focus();
    }

    private void SaveNote()
    {
        if (loading) return;
        string title = titleInput.Text.Trim();
        if (title.Length == 0 || title.Length > 200)
        {
            saveStatus.Text = "Enter a title up to 200 characters.";
            saveStatus.ForeColor = AccentColor;
            return;
        }
        try
        {
            using var connection = OpenConnection();
            using var command = selectedNoteId.HasValue
                ? new SqlCommand(@"UPDATE dbo.Notes SET Title=@title, Content=@content, Color=@color, UpdatedAt=GETDATE()
                    WHERE NoteId=@id AND InstructorEmployeeID=@empId", connection)
                : new SqlCommand(@"INSERT INTO dbo.Notes (InstructorEmployeeID, Title, Content, Color)
                    VALUES (@empId, @title, @content, @color); SELECT CAST(SCOPE_IDENTITY() AS int);", connection);
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            command.Parameters.Add("@title", SqlDbType.NVarChar, 200).Value = title;
            command.Parameters.Add("@content", SqlDbType.NVarChar, -1).Value = contentInput.Text;
            command.Parameters.Add("@color", SqlDbType.NVarChar, 20).Value = colorPicker.SelectedItem?.ToString() ?? "Default";
            if (selectedNoteId.HasValue)
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = selectedNoteId.Value;
                if (command.ExecuteNonQuery() == 0) { saveStatus.Text = "Note not found."; return; }
            }
            else selectedNoteId = Convert.ToInt32(command.ExecuteScalar());
            int savedId = selectedNoteId.Value;
            LoadNotes(savedId);
            saveStatus.Text = "✅ Saved";
            saveStatus.ForeColor = Color.LimeGreen;
        }
        catch (SqlException ex) { saveStatus.Text = "Could not save note: " + ex.Message; saveStatus.ForeColor = AccentColor; }
    }

    private void DeleteNote()
    {
        if (!selectedNoteId.HasValue) return;
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand("DELETE FROM dbo.Notes WHERE NoteId=@id AND InstructorEmployeeID=@empId", connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = selectedNoteId.Value;
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            command.ExecuteNonQuery();
            BeginNewNote();
            LoadNotes();
        }
        catch (SqlException ex) { saveStatus.Text = "Could not delete note: " + ex.Message; saveStatus.ForeColor = AccentColor; }
    }

    private SqlConnection OpenConnection()
    {
        var connection = new SqlConnection(DatabaseConnection.ConnectionString);
        try { DatabaseConnection.Open(connection); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private static Color ColorForNote(string color) => color switch
    {
        "Yellow" => Color.FromArgb(80, 70, 10),
        "Blue" => Color.FromArgb(10, 50, 90),
        "Green" => Color.FromArgb(10, 70, 40),
        "Red" => Color.FromArgb(80, 20, 30),
        _ => Color.FromArgb(30, 40, 65)
    };

    private static CustomButton MakeButton(string text, Color color, int width, int height) => new()
    {
        Text = text, BackColor = color, ForeColor = Color.White, Size = new Size(width, height),
        BorderRadius = 6, BorderSize = 0, Cursor = Cursors.Hand, Font = new Font("Segoe UI", 9F, FontStyle.Bold)
    };

    private static Label MakeLabel(string text) => new()
    {
        Text = text, Dock = DockStyle.Fill, ForeColor = TextGray, Font = new Font("Segoe UI", 8F),
        TextAlign = ContentAlignment.MiddleLeft
    };

    private static void ConfigureInput(RoundedTextBox input, string placeholder)
    {
        input.FillColor = CardColor;
        input.BorderColor = AccentColor;
        input.FocusBorderColor = AccentColor;
        input.BorderRadius = 7;
        input.Font = new Font("Segoe UI", 10F);
        input.ForeColor = Color.White;
        input.PlaceholderText = placeholder;
    }
}
