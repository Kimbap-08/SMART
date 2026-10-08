using System.Data;
using System.Data.SqlClient;

namespace SMART;

public sealed class CourseViewForm : Form
{
    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private static readonly Color GreenColor = Color.FromArgb(0, 170, 0);
    private readonly int courseId;
    private readonly string courseTitle;
    private readonly string courseName;
    private readonly string instructorName;
    private readonly DataGridView studentsGrid = new();
    private readonly DataGridView attendanceGrid = new();
    private readonly DataGridView quizGrid = new();
    private readonly DataGridView examGrid = new();
    private readonly DataGridView quizScoreGrid = new();
    private readonly DataGridView examScoreGrid = new();
    private readonly DataGridView performanceGrid = new();
    private readonly DateTimePicker attendanceDate = new() { Format = DateTimePickerFormat.Short };
    private readonly DateTimePicker quizDate = new() { Format = DateTimePickerFormat.Short };
    private readonly DateTimePicker examDate = new() { Format = DateTimePickerFormat.Short };
    private readonly RoundedTextBox quizTitleInput = new();
    private readonly RoundedTextBox quizTotalInput = new();
    private readonly RoundedTextBox examTitleInput = new();
    private readonly RoundedTextBox examTotalInput = new();
    private readonly RoundedTextBox examItemsInput = new();
    private readonly RoundedTextBox examWeightInput = new();
    private int? selectedQuizId;
    private int? selectedExamId;
    private double selectedQuizTotal;
    private int selectedExamTotalItems;
    private decimal selectedExamWeight;
    private double selectedExamTotal;
    private string gradingPeriod = "";
    private bool loadingExamGrid;
    private Label attendanceMessage = new();
    private Label quizMessage = new();
    private Label examMessage = new();

    public CourseViewForm(int courseId, string courseTitle, string courseName, string instructorName)
    {
        this.courseId = courseId;
        this.courseTitle = courseTitle;
        this.courseName = courseName;
        this.instructorName = instructorName;
        Text = "S.M.A.R.T. — " + courseTitle;
        StartPosition = FormStartPosition.CenterParent;
        WindowState = FormWindowState.Maximized;
        MinimumSize = new Size(1000, 650);
        BackColor = BgColor;
        Font = new Font("Segoe UI", 10F);
        gradingPeriod = LoadCourseGradingPeriod();
        BuildLayout();
        LoadStudents();
        LoadAssessments(false);
        LoadExamRows();
        LoadPerformance();
        InstructorTheme.Apply(this);
    }

    private void BuildLayout()
    {
        var header = new CustomPanel
        {
            Dock = DockStyle.Top, Height = 88, BackColor = CardColor,
            BorderColor = CardColor, BorderWidth = 0, CornerRadius = 0, Padding = new Padding(20, 12, 20, 8)
        };
        var back = MakeButton("← Back", Color.FromArgb(55, 62, 86), 100, 38);
        back.Dock = DockStyle.Left;
        back.Click += (_, _) => Close();
        var details = new CustomPanel { Dock = DockStyle.Fill, BackColor = CardColor, Padding = new Padding(18, 0, 0, 0), BorderWidth = 0, CornerRadius = 1 };
        details.Controls.Add(new Label
        {
            Text = courseTitle + " — " + courseName, Dock = DockStyle.Top, Height = 38,
            ForeColor = Color.White, Font = new Font("Segoe UI", 18F, FontStyle.Bold), AutoEllipsis = true
        });
        details.Controls.Add(new Label
        {
            Text = "Instructor: " + instructorName, Dock = DockStyle.Top, Height = 25,
            ForeColor = TextGray, Font = new Font("Segoe UI", 10F)
        });
        header.Controls.Add(details);
        header.Controls.Add(back);

        var tabs = new TabControl { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 10F), Padding = new Point(14, 6) };
        tabs.TabPages.Add(BuildStudentsTab());
        tabs.TabPages.Add(BuildAttendanceTab());
        tabs.TabPages.Add(BuildAssessmentTab(false));
        tabs.TabPages.Add(BuildExamTab());
        tabs.TabPages.Add(BuildPerformanceTab());
        Controls.Add(tabs);
        Controls.Add(header);
    }

    private TabPage BuildStudentsTab()
    {
        var page = MakeTab("👥 Students");
        page.Controls.Add(StyleGrid(studentsGrid));
        return page;
    }

    private TabPage BuildAttendanceTab()
    {
        var page = MakeTab("📋 Attendance");
        var toolbar = new RoundedFlowLayoutPanel { Dock = DockStyle.Top, Height = 58, BackColor = BgColor, Padding = new Padding(4, 8, 4, 4), WrapContents = false, BorderSize = 0 };
        StyleDate(attendanceDate);
        var load = MakeButton("Load Students", AccentColor, 140, 38);
        var save = MakeButton("Save Attendance", GreenColor, 155, 38);
        attendanceMessage = MakeMessageLabel();
        attendanceGrid.CellFormatting += AttendanceCellFormatting;
        load.Click += (_, _) => LoadAttendanceRows();
        save.Click += (_, _) => SaveAttendance();
        toolbar.Controls.Add(attendanceDate);
        toolbar.Controls.Add(load);
        toolbar.Controls.Add(save);
        toolbar.Controls.Add(attendanceMessage);
        page.Controls.Add(StyleGrid(attendanceGrid));
        page.Controls.Add(toolbar);
        LoadAttendanceRows();
        return page;
    }

    private TabPage BuildAssessmentTab(bool exam)
    {
        string kind = exam ? "Exam" : "Quiz";
        var page = MakeTab(exam ? "📄 Exams" : "📝 Quizzes");
        var form = new CustomPanel
        {
            Dock = DockStyle.Top, Height = 112, BackColor = CardColor, BorderColor = CardColor,
            BorderWidth = 0, CornerRadius = 8, Padding = new Padding(12)
        };
        var titleInput = exam ? examTitleInput : quizTitleInput;
        var totalInput = exam ? examTotalInput : quizTotalInput;
        var dateInput = exam ? examDate : quizDate;
        StyleInput(titleInput, kind + " title");
        StyleInput(totalInput, "Total score");
        totalInput.MaxLength = 12;
        StyleDate(dateInput);
        var create = MakeButton("Create " + kind, AccentColor, 150, 38);
        titleInput.SetBounds(12, 12, 260, 40);
        totalInput.SetBounds(284, 12, 150, 40);
        dateInput.SetBounds(446, 14, 150, 36);
        create.SetBounds(608, 12, 150, 38);
        form.Controls.AddRange(new Control[] { titleInput, totalInput, dateInput, create });

        var message = MakeMessageLabel();
        if (exam) examMessage = message; else quizMessage = message;
        message.Dock = DockStyle.Top;
        message.Height = 28;

        var split = new SplitContainer
        {
            Dock = DockStyle.Fill, Orientation = Orientation.Horizontal,
            Size = new Size(900, 500), SplitterDistance = 250, BackColor = BgColor, BorderStyle = BorderStyle.None
        };
        var listGrid = exam ? examGrid : quizGrid;
        var scoreGrid = exam ? examScoreGrid : quizScoreGrid;
        split.Panel1.Controls.Add(StyleGrid(listGrid));
        split.Panel2.Controls.Add(StyleGrid(scoreGrid));
        var actions = new RoundedFlowLayoutPanel { Dock = DockStyle.Bottom, Height = 48, BackColor = BgColor, Padding = new Padding(4, 4, 4, 4), WrapContents = false, BorderSize = 0 };
        var enterScores = MakeButton("Load Scores for Selected " + kind, AccentColor, 250, 38);
        var saveScores = MakeButton("Save Scores", GreenColor, 140, 38);
        enterScores.Click += (_, _) => LoadScoreRows(exam);
        saveScores.Click += (_, _) => SaveScores(exam);
        actions.Controls.Add(enterScores);
        actions.Controls.Add(saveScores);
        split.Panel2.Controls.Add(actions);

        create.Click += (_, _) => CreateAssessment(exam);
        listGrid.SelectionChanged += (_, _) => SelectAssessment(exam);
        page.Controls.Add(split);
        page.Controls.Add(message);
        page.Controls.Add(form);
        if (!exam) LoadAssessments(false);
        return page;
    }

    private TabPage BuildExamTab()
    {
        var page = MakeTab("📄 Exams");
        var setup = new CustomPanel
        {
            Dock = DockStyle.Top, Height = 112, BackColor = CardColor, BorderColor = CardColor,
            BorderWidth = 0, CornerRadius = 8, Padding = new Padding(12)
        };
        var periodLabel = new Label
        {
            Text = "Grading period: " + gradingPeriod, ForeColor = Color.White,
            Font = new Font("Segoe UI", 10F, FontStyle.Bold), Location = new Point(12, 8), Size = new Size(220, 24)
        };
        StyleDate(examDate);
        examDate.ShowCheckBox = true;
        StyleInput(examItemsInput, "Total items");
        examItemsInput.MaxLength = 8;
        StyleInput(examWeightInput, "Weight % (Summer only)");
        examWeightInput.MaxLength = 6;
        examWeightInput.ReadOnly = !gradingPeriod.Equals("Summer", StringComparison.OrdinalIgnoreCase);
        var saveDetails = MakeButton("Save Exam Details", AccentColor, 170, 38);
        examDate.SetBounds(12, 44, 150, 36);
        examItemsInput.SetBounds(176, 42, 150, 40);
        examWeightInput.SetBounds(340, 42, 180, 40);
        saveDetails.SetBounds(536, 42, 170, 38);
        saveDetails.Click += (_, _) => SaveExamDetails();
        setup.Controls.AddRange(new Control[] { periodLabel, examDate, examItemsInput, examWeightInput, saveDetails });

        examMessage = MakeMessageLabel();
        examMessage.Dock = DockStyle.Top;
        examMessage.Height = 30;
        var split = new SplitContainer
        {
            Dock = DockStyle.Fill, Orientation = Orientation.Horizontal,
            Size = new Size(900, 500), SplitterDistance = 240, BackColor = BgColor, BorderStyle = BorderStyle.None
        };
        split.Panel1.Controls.Add(StyleGrid(examGrid));
        split.Panel2.Controls.Add(StyleGrid(examScoreGrid));
        var actions = new RoundedFlowLayoutPanel
        {
            Dock = DockStyle.Bottom, Height = 48, BackColor = BgColor,
            Padding = new Padding(4), WrapContents = false, BorderSize = 0
        };
        var loadScores = MakeButton("Load Enrolled Students", AccentColor, 205, 38);
        var saveScores = MakeButton("Save Raw Scores", GreenColor, 155, 38);
        loadScores.Click += (_, _) => LoadExamScoreRows();
        saveScores.Click += (_, _) => SaveExamScores();
        actions.Controls.Add(loadScores);
        actions.Controls.Add(saveScores);
        split.Panel2.Controls.Add(actions);
        examGrid.SelectionChanged += (_, _) => { if (!loadingExamGrid) SelectExam(); };
        examScoreGrid.CellEndEdit += (_, e) => RecalculateExamScoreRow(e.RowIndex);
        page.Controls.Add(split);
        page.Controls.Add(examMessage);
        page.Controls.Add(setup);
        return page;
    }

    private TabPage BuildPerformanceTab()
    {
        var page = MakeTab("📊 Performance");
        var toolbar = new RoundedFlowLayoutPanel { Dock = DockStyle.Top, Height = 54, BackColor = BgColor, Padding = new Padding(4, 8, 4, 4), BorderSize = 0 };
        var refresh = MakeButton("Refresh", AccentColor, 110, 38);
        refresh.Click += (_, _) => LoadPerformance();
        toolbar.Controls.Add(refresh);
        page.Controls.Add(StyleGrid(performanceGrid));
        page.Controls.Add(toolbar);
        return page;
    }

    private TabPage MakeTab(string title) => new(title)
    {
        BackColor = BgColor,
        ForeColor = Color.White,
        Padding = new Padding(12)
    };

    private static CustomButton MakeButton(string text, Color color, int width, int height) => new()
    {
        Text = text, BackColor = color, ForeColor = Color.White, Size = new Size(width, height),
        BorderRadius = 7, BorderSize = 0, Cursor = Cursors.Hand, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
    };

    private static Label MakeMessageLabel() => new()
    {
        AutoSize = false, ForeColor = TextGray, TextAlign = ContentAlignment.MiddleLeft,
        Padding = new Padding(8, 0, 4, 0)
    };

    private static void StyleInput(RoundedTextBox input, string placeholder)
    {
        input.BackColor = Color.Transparent;
        input.FillColor = CardColor;
        input.BorderColor = AccentColor;
        input.FocusBorderColor = AccentColor;
        input.BorderRadius = 7;
        input.Font = new Font("Segoe UI", 10F);
        input.ForeColor = Color.White;
        input.PlaceholderText = placeholder;
    }

    private static void StyleDate(DateTimePicker picker)
    {
        picker.Format = DateTimePickerFormat.Short;
        picker.CalendarMonthBackground = CardColor;
        picker.CalendarForeColor = Color.White;
        picker.CalendarTitleBackColor = AccentColor;
        picker.CalendarTitleForeColor = Color.White;
        picker.BackColor = CardColor;
        picker.ForeColor = Color.White;
        picker.Font = new Font("Segoe UI", 10F);
        picker.Size = new Size(150, 36);
        picker.Margin = new Padding(4, 8, 8, 4);
    }

    private static DataGridView StyleGrid(DataGridView grid)
    {
        grid.Dock = DockStyle.Fill;
        grid.BackgroundColor = CardColor;
        grid.ForeColor = Color.White;
        grid.GridColor = Color.FromArgb(40, 40, 60);
        grid.BorderStyle = BorderStyle.None;
        grid.RowHeadersVisible = false;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.ReadOnly = true;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.RowTemplate.Height = 36;
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 15, 35);
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grid.DefaultCellStyle.BackColor = CardColor;
        grid.DefaultCellStyle.ForeColor = Color.White;
        grid.DefaultCellStyle.SelectionBackColor = AccentColor;
        grid.DefaultCellStyle.SelectionForeColor = Color.White;
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
        return grid;
    }

    private SqlConnection OpenConnection()
    {
        var connection = new SqlConnection(DatabaseConnection.ConnectionString);
        try { DatabaseConnection.Open(connection); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private void LoadStudents()
    {
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT s.StudentID, s.StudentName AS [Student Name],
                    s.Program, s.YearLevel AS [Year Level], COALESCE(s.Status, N'ACTIVE') AS Status
                FROM dbo.Students s JOIN dbo.Enrollments e ON e.StudentID = s.StudentID
                WHERE e.CourseId = @CourseId ORDER BY s.StudentName", connection);
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            studentsGrid.DataSource = table;
            if (studentsGrid.Columns.Contains("StudentID")) studentsGrid.Columns["StudentID"].HeaderText = "Student No.";
            studentsGrid.CellFormatting += StudentStatusFormatting;
        }
        catch (SqlException ex) { ShowMessage("Students", ex.Message); }
    }

    private void StudentStatusFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || studentsGrid.Columns[e.ColumnIndex].Name != "Status") return;
        string status = Convert.ToString(e.Value)?.Trim().ToUpperInvariant() ?? "ACTIVE";
        e.Value = status switch
        {
            "ACTIVE" => "🟢 ACTIVE",
            "INACTIVE" => "🟡 INACTIVE",
            "DROPPED" => "🔴 DROPPED",
            _ => status
        };
        e.CellStyle.ForeColor = status switch
        {
            "ACTIVE" => Color.FromArgb(0, 204, 0),
            "INACTIVE" => Color.FromArgb(255, 170, 0),
            "DROPPED" => AccentColor,
            _ => TextGray
        };
        e.FormattingApplied = true;
    }

    private void AttendanceCellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0) return;
        string column = attendanceGrid.Columns[e.ColumnIndex].Name;
        if (column == "Status")
            e.CellStyle.ForeColor = ColorForAttendance(Convert.ToString(e.Value) ?? "");
        else if (column == "Attendance %" && double.TryParse(Convert.ToString(e.Value)?.TrimEnd('%'), out double percent))
            e.CellStyle.ForeColor = ColorForPercent(percent);
    }

    private void LoadAttendanceRows()
    {
        attendanceGrid.Columns.Clear();
        attendanceGrid.Rows.Clear();
        attendanceGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentID", HeaderText = "Student ID", Visible = false });
        attendanceGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Student Name", HeaderText = "Student Name", ReadOnly = true });
        var statusColumn = new DataGridViewComboBoxColumn
        {
            Name = "Status", HeaderText = "Status", FlatStyle = FlatStyle.Flat,
            DataSource = new[] { "PRESENT", "ABSENT", "LATE", "EXCUSED" }
        };
        attendanceGrid.Columns.Add(statusColumn);
        attendanceGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Attendance %", HeaderText = "Attendance %", ReadOnly = true });
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT s.StudentID, s.StudentName,
                    COALESCE(a.Status, N'PRESENT') AS Status,
                    COALESCE((SELECT CAST(ROUND(100.0 * SUM(CASE WHEN ax.Status IN (N'PRESENT', N'LATE') THEN 1 ELSE 0 END) / NULLIF(COUNT(*), 0), 1) AS DECIMAL(5,1))
                        FROM dbo.Attendance ax WHERE ax.StudentID = s.StudentID AND ax.CourseId = @CourseId), 0) AS AttendancePercent
                FROM dbo.Students s JOIN dbo.Enrollments e ON e.StudentID = s.StudentID
                LEFT JOIN dbo.Attendance a ON a.StudentID = s.StudentID AND a.CourseId = @CourseId AND a.Date = @Date
                WHERE e.CourseId = @CourseId ORDER BY s.StudentName", connection);
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@Date", SqlDbType.Date).Value = attendanceDate.Value.Date;
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                int row = attendanceGrid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    Convert.ToString(reader.GetValue(3)) + "%");
                attendanceGrid.Rows[row].Tag = reader.GetString(0);
            }
            attendanceGrid.Columns["Status"].ReadOnly = false;
            attendanceGrid.ReadOnly = false;
            foreach (DataGridViewColumn column in attendanceGrid.Columns)
                if (column.Name != "Status") column.ReadOnly = true;
            attendanceMessage.Text = $"{attendanceGrid.Rows.Count} enrolled student(s).";
        }
        catch (SqlException ex) { ShowMessage("Attendance", ex.Message); }
    }

    private void SaveAttendance()
    {
        try
        {
            attendanceGrid.EndEdit();
            using var connection = OpenConnection();
            using var transaction = connection.BeginTransaction();
            foreach (DataGridViewRow row in attendanceGrid.Rows)
            {
                string studentId = Convert.ToString(row.Cells["StudentID"].Value) ?? "";
                string status = Convert.ToString(row.Cells["Status"].Value) ?? "PRESENT";
                using var command = new SqlCommand(@"IF EXISTS (SELECT 1 FROM dbo.Attendance WHERE StudentID = @StudentID AND CourseId = @CourseId AND Date = @Date)
                    UPDATE dbo.Attendance SET Status = @Status WHERE StudentID = @StudentID AND CourseId = @CourseId AND Date = @Date;
                    ELSE INSERT INTO dbo.Attendance (StudentID, CourseId, Date, Status) VALUES (@StudentID, @CourseId, @Date, @Status);",
                    connection, transaction);
                AddAttendanceParameters(command, studentId, status);
                command.ExecuteNonQuery();
            }
            transaction.Commit();
            attendanceMessage.Text = "Attendance saved.";
            LoadAttendanceRows();
        }
        catch (Exception ex) { ShowMessage("Attendance", ex.Message); }
    }

    private void AddAttendanceParameters(SqlCommand command, string studentId, string status)
    {
        command.Parameters.Add("@StudentID", SqlDbType.VarChar, 10).Value = studentId;
        command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
        command.Parameters.Add("@Date", SqlDbType.Date).Value = attendanceDate.Value.Date;
        command.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = status;
    }

    private void CreateAssessment(bool exam)
    {
        var titleInput = exam ? examTitleInput : quizTitleInput;
        var totalInput = exam ? examTotalInput : quizTotalInput;
        var dateInput = exam ? examDate : quizDate;
        Label message = exam ? examMessage : quizMessage;
        string title = titleInput.Text.Trim();
        if (title.Length == 0 || title.Length > 100 || !double.TryParse(totalInput.Text.Trim(), out double total) || total <= 0)
        {
            message.Text = "Enter a title and a total score greater than zero.";
            message.ForeColor = Color.FromArgb(255, 170, 0);
            return;
        }
        string table = exam ? "Exams" : "Quizzes";
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand($"INSERT INTO dbo.{table} (CourseId, Title, TotalScore, Date) VALUES (@CourseId, @Title, @TotalScore, @Date)", connection);
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@Title", SqlDbType.NVarChar, 100).Value = title;
            command.Parameters.Add("@TotalScore", SqlDbType.Float).Value = total;
            command.Parameters.Add("@Date", SqlDbType.Date).Value = dateInput.Value.Date;
            command.ExecuteNonQuery();
            titleInput.Text = "";
            totalInput.Text = "";
            message.Text = kindName(exam) + " created.";
            message.ForeColor = GreenColor;
            LoadAssessments(exam);
        }
        catch (SqlException ex) { ShowMessage(kindName(exam), ex.Message); }
    }

    private static string kindName(bool exam) => exam ? "Exam" : "Quiz";

    private void LoadAssessments(bool exam)
    {
        string table = exam ? "Exams" : "Quizzes";
        DataGridView grid = exam ? examGrid : quizGrid;
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand($"SELECT { (exam ? "ExamId" : "QuizId") } AS ID, Title, Date, TotalScore FROM dbo.{table} WHERE CourseId = @CourseId ORDER BY Date DESC, ID DESC", connection);
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            using var adapter = new SqlDataAdapter(command);
            var data = new DataTable();
            adapter.Fill(data);
            grid.DataSource = data;
            if (grid.Columns.Contains("ID")) grid.Columns["ID"].Visible = false;
            SelectAssessment(exam);
        }
        catch (SqlException ex) { ShowMessage(kindName(exam), ex.Message); }
    }

    private void SelectAssessment(bool exam)
    {
        DataGridView grid = exam ? examGrid : quizGrid;
        if (grid.CurrentRow == null || grid.CurrentRow.IsNewRow) return;
        int id = Convert.ToInt32(grid.CurrentRow.Cells["ID"].Value);
        double total = Convert.ToDouble(grid.CurrentRow.Cells["TotalScore"].Value);
        if (exam) { selectedExamId = id; selectedExamTotal = total; }
        else { selectedQuizId = id; selectedQuizTotal = total; }
    }

    private void LoadScoreRows(bool exam)
    {
        DataGridView grid = exam ? examGrid : quizGrid;
        int? assessmentId = exam ? selectedExamId : selectedQuizId;
        DataGridView scoreGrid = exam ? examScoreGrid : quizScoreGrid;
        if (!assessmentId.HasValue) { ShowMessage(kindName(exam), "Select a " + kindName(exam).ToLowerInvariant() + " first."); return; }
        string scoreTable = exam ? "ExamScores" : "QuizScores";
        string idColumn = exam ? "ExamId" : "QuizId";
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand($@"SELECT s.StudentID, s.StudentName,
                    CAST(sc.Score AS NVARCHAR(40)) AS Score
                FROM dbo.Students s JOIN dbo.Enrollments en ON en.StudentID = s.StudentID
                LEFT JOIN dbo.{scoreTable} sc ON sc.StudentID = s.StudentID AND sc.{idColumn} = @AssessmentId
                WHERE en.CourseId = @CourseId ORDER BY s.StudentName", connection);
            command.Parameters.Add("@AssessmentId", SqlDbType.Int).Value = assessmentId.Value;
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            using var adapter = new SqlDataAdapter(command);
            var data = new DataTable();
            adapter.Fill(data);
            scoreGrid.DataSource = data;
            scoreGrid.Columns["StudentID"].Visible = false;
            scoreGrid.Columns["StudentName"].HeaderText = "Student Name";
            scoreGrid.Columns["Score"].HeaderText = "Score (max " + (exam ? selectedExamTotal : selectedQuizTotal).ToString("0.##") + ")";
            scoreGrid.Columns["StudentID"].ReadOnly = true;
            scoreGrid.Columns["StudentName"].ReadOnly = true;
            scoreGrid.Columns["Score"].ReadOnly = false;
            scoreGrid.ReadOnly = false;
            _ = grid;
        }
        catch (SqlException ex) { ShowMessage(kindName(exam), ex.Message); }
    }

    private void SaveScores(bool exam)
    {
        int? assessmentId = exam ? selectedExamId : selectedQuizId;
        double total = exam ? selectedExamTotal : selectedQuizTotal;
        DataGridView grid = exam ? examScoreGrid : quizScoreGrid;
        if (!assessmentId.HasValue) { ShowMessage(kindName(exam), "Select and load a " + kindName(exam).ToLowerInvariant() + " first."); return; }
        try
        {
            grid.EndEdit();
            var scores = new List<(string StudentId, double Score)>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                string id = Convert.ToString(row.Cells["StudentID"].Value) ?? "";
                if (!double.TryParse(Convert.ToString(row.Cells["Score"].Value), out double score) || score < 0 || score > total)
                    throw new InvalidOperationException($"Enter a score from 0 to {total:0.##} for every student.");
                scores.Add((id, score));
            }
            string table = exam ? "ExamScores" : "QuizScores";
            string idColumn = exam ? "ExamId" : "QuizId";
            using var connection = OpenConnection();
            using var transaction = connection.BeginTransaction();
            foreach (var item in scores)
            {
                using var command = new SqlCommand($@"IF EXISTS (SELECT 1 FROM dbo.{table} WHERE {idColumn} = @AssessmentId AND StudentID = @StudentID)
                    UPDATE dbo.{table} SET Score = @Score WHERE {idColumn} = @AssessmentId AND StudentID = @StudentID;
                    ELSE INSERT INTO dbo.{table} ({idColumn}, StudentID, Score) VALUES (@AssessmentId, @StudentID, @Score);",
                    connection, transaction);
                command.Parameters.Add("@AssessmentId", SqlDbType.Int).Value = assessmentId.Value;
                command.Parameters.Add("@StudentID", SqlDbType.VarChar, 10).Value = item.StudentId;
                command.Parameters.Add("@Score", SqlDbType.Float).Value = item.Score;
                command.ExecuteNonQuery();
            }
            transaction.Commit();
            ShowMessage(kindName(exam), "Scores saved.");
            LoadPerformance();
        }
        catch (Exception ex) { ShowMessage(kindName(exam), ex.Message); }
    }

    private string LoadCourseGradingPeriod()
    {
        using var connection = OpenConnection();
        using var command = new SqlCommand("SELECT Term FROM dbo.Courses WHERE CourseRecordID = @CourseId", connection);
        command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
        return ExamRepository.NormalizePeriod(Convert.ToString(command.ExecuteScalar()));
    }

    private void LoadExamRows()
    {
        loadingExamGrid = true;
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT ExamId, Title, ExamType, GradingPeriod,
                    WeightPercent, TotalItems, Date, Status
                FROM dbo.Exams WHERE CourseId = @CourseId AND GradingPeriod = @Period
                ORDER BY CASE ExamType WHEN N'Prelim' THEN 1 WHEN N'Exam' THEN 2
                    WHEN N'Midterm' THEN 3 WHEN N'Final' THEN 4 ELSE 5 END, ExamId", connection);
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@Period", SqlDbType.NVarChar, 30).Value = gradingPeriod;
            using var adapter = new SqlDataAdapter(command);
            var data = new DataTable();
            adapter.Fill(data);
            examGrid.DataSource = data;
            examGrid.Columns["ExamId"].Visible = false;
            examGrid.Columns["ExamType"].Visible = false;
            examGrid.Columns["GradingPeriod"].Visible = false;
            examGrid.Columns["Title"].HeaderText = "Exam";
            examGrid.Columns["WeightPercent"].HeaderText = "Weight %";
            examGrid.Columns["TotalItems"].HeaderText = "Total Items";
            examGrid.Columns["Date"].HeaderText = "Date";
            examGrid.Columns["Status"].HeaderText = "Status";
            selectedExamId = null;
            if (examGrid.Rows.Count > 0 && !examGrid.Rows[0].IsNewRow)
            {
                examGrid.CurrentCell = examGrid.Rows[0].Cells["Title"];
                SelectExam();
            }
            else
            {
                examItemsInput.Text = "";
                examWeightInput.Text = "";
                examScoreGrid.DataSource = null;
            }
            examMessage.Text = examGrid.Rows.Count == 0
                ? "No exam structure exists for this grading period. Reopen the course after saving it in Admin Courses."
                : $"{gradingPeriod} exam structure · {examGrid.Rows.Count} exam(s).";
        }
        catch (SqlException ex) { ShowMessage("Exam", ex.Message); }
        finally { loadingExamGrid = false; }
    }

    private void SelectExam()
    {
        if (!examGrid.Columns.Contains("ExamId") || examGrid.CurrentRow == null || examGrid.CurrentRow.IsNewRow) return;
        DataGridViewRow row = examGrid.CurrentRow;
        selectedExamId = Convert.ToInt32(row.Cells["ExamId"].Value);
        selectedExamTotalItems = row.Cells["TotalItems"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["TotalItems"].Value);
        selectedExamWeight = row.Cells["WeightPercent"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["WeightPercent"].Value);
        examItemsInput.Text = selectedExamTotalItems > 0 ? selectedExamTotalItems.ToString() : "";
        examWeightInput.Text = selectedExamWeight.ToString("0.##");
        bool hasDate = row.Cells["Date"].Value != DBNull.Value;
        examDate.Checked = hasDate;
        if (hasDate) examDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
        LoadExamScoreRows();
    }

    private void SaveExamDetails()
    {
        if (!selectedExamId.HasValue) { ShowMessage("Exam", "Select an exam first."); return; }
        if (!int.TryParse(examItemsInput.Text.Trim(), out int totalItems) || totalItems <= 0)
        {
            ShowMessage("Exam", "Total Items must be a whole number greater than zero.");
            examItemsInput.Focus();
            return;
        }
        decimal weight;
        if (gradingPeriod == "Summer")
        {
            if (!decimal.TryParse(examWeightInput.Text.Trim(), out weight) || weight < 0 || weight > 100)
            {
                ShowMessage("Exam", "Summer exam weight must be between 0 and 100.");
                examWeightInput.Focus();
                return;
            }
        }
        else
        {
            var template = ExamRepository.TemplatesFor(gradingPeriod)
                .FirstOrDefault(item => item.Title == Convert.ToString(examGrid.CurrentRow?.Cells["Title"].Value));
            if (template == null) { ShowMessage("Exam", "The selected exam is not part of the configured grading period."); return; }
            weight = template.WeightPercent;
        }

        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"IF EXISTS (SELECT 1 FROM dbo.ExamScores WHERE ExamId = @ExamId AND Score > @TotalItems)
                    THROW 51003, 'Total Items cannot be lower than a score already entered.', 1;
                UPDATE dbo.Exams SET TotalItems = @TotalItems, TotalScore = @TotalItems,
                    WeightPercent = @Weight, Date = @Date
                WHERE ExamId = @ExamId AND CourseId = @CourseId AND GradingPeriod = @Period;", connection);
            command.Parameters.Add("@ExamId", SqlDbType.Int).Value = selectedExamId.Value;
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@Period", SqlDbType.NVarChar, 30).Value = gradingPeriod;
            command.Parameters.Add("@TotalItems", SqlDbType.Int).Value = totalItems;
            command.Parameters.Add("@Weight", SqlDbType.Decimal).Value = weight;
            command.Parameters["@Weight"].Precision = 5;
            command.Parameters["@Weight"].Scale = 2;
            command.Parameters.Add("@Date", SqlDbType.Date).Value = examDate.Checked ? examDate.Value.Date : DBNull.Value;
            command.ExecuteNonQuery();
            examMessage.Text = "Exam details saved.";
            examMessage.ForeColor = GreenColor;
            LoadExamRows();
        }
        catch (SqlException ex) { ShowMessage("Exam", ex.Message); }
    }

    private void LoadExamScoreRows()
    {
        examScoreGrid.Columns.Clear();
        examScoreGrid.Rows.Clear();
        if (!selectedExamId.HasValue || selectedExamTotalItems <= 0)
        {
            examScoreGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Info", HeaderText = "Score Entry" });
            examScoreGrid.Rows.Add("Select an exam and save a Total Items value before entering scores.");
            return;
        }

        examScoreGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentID", HeaderText = "Student ID", Visible = false });
        examScoreGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentName", HeaderText = "Student Name", ReadOnly = true });
        examScoreGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "RawScore", HeaderText = $"Raw Score (0–{selectedExamTotalItems})" });
        examScoreGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "TransmutedGrade", HeaderText = "Transmuted Grade", ReadOnly = true });
        examScoreGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "WeightedContribution", HeaderText = "Weighted Contribution", ReadOnly = true });
        examScoreGrid.ReadOnly = false;
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT s.StudentID, s.StudentName, es.Score
                FROM dbo.Students s JOIN dbo.Enrollments en ON en.StudentID = s.StudentID
                LEFT JOIN dbo.ExamScores es ON es.StudentID = s.StudentID AND es.ExamId = @ExamId
                WHERE en.CourseId = @CourseId ORDER BY s.StudentName", connection);
            command.Parameters.Add("@ExamId", SqlDbType.Int).Value = selectedExamId.Value;
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                int index = examScoreGrid.Rows.Add(reader.GetString(0), reader.GetString(1),
                    reader.IsDBNull(2) ? "" : Convert.ToString(reader.GetValue(2)), "", "");
                RecalculateExamScoreRow(index);
            }
        }
        catch (SqlException ex) { ShowMessage("Exam", ex.Message); }
    }

    private void RecalculateExamScoreRow(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= examScoreGrid.Rows.Count ||
            !examScoreGrid.Columns.Contains("RawScore")) return;
        DataGridViewRow row = examScoreGrid.Rows[rowIndex];
        if (!double.TryParse(Convert.ToString(row.Cells["RawScore"].Value), out double raw) ||
            selectedExamTotalItems <= 0 || raw < 0 || raw > selectedExamTotalItems)
        {
            row.Cells["TransmutedGrade"].Value = "";
            row.Cells["WeightedContribution"].Value = "";
            return;
        }
        double grade = (raw / selectedExamTotalItems) * 85 + 15;
        if (grade > 100) grade = 100;
        row.Cells["TransmutedGrade"].Value = grade.ToString("0.0");
        row.Cells["WeightedContribution"].Value = (grade * (double)selectedExamWeight / 100).ToString("0.00");
    }

    private void SaveExamScores()
    {
        if (!selectedExamId.HasValue) { ShowMessage("Exam", "Select an exam first."); return; }
        if (selectedExamTotalItems <= 0) { ShowMessage("Exam", "Total Items must be greater than zero before saving scores."); return; }
        if (selectedExamWeight < 0 || selectedExamWeight > 100) { ShowMessage("Exam", "Exam weight must be between 0 and 100."); return; }
        try
        {
            examScoreGrid.EndEdit();
            var scores = new List<(string StudentId, double RawScore)>();
            foreach (DataGridViewRow row in examScoreGrid.Rows)
            {
                string studentId = Convert.ToString(row.Cells["StudentID"].Value) ?? "";
                if (!double.TryParse(Convert.ToString(row.Cells["RawScore"].Value), out double raw) || raw < 0 || raw > selectedExamTotalItems)
                    throw new InvalidOperationException($"Each raw score must be from 0 to {selectedExamTotalItems}.");
                double grade = (raw / selectedExamTotalItems) * 85 + 15;
                if (grade < 0 || grade > 100) throw new InvalidOperationException("The calculated grade must be between 0 and 100.");
                scores.Add((studentId, raw));
            }

            using var connection = OpenConnection();
            using var transaction = connection.BeginTransaction();
            foreach (var item in scores)
            {
                using var command = new SqlCommand(@"IF EXISTS (SELECT 1 FROM dbo.ExamScores WHERE ExamId = @ExamId AND StudentID = @StudentID)
                    UPDATE dbo.ExamScores SET Score = @Score WHERE ExamId = @ExamId AND StudentID = @StudentID;
                    ELSE INSERT INTO dbo.ExamScores (ExamId, StudentID, Score) VALUES (@ExamId, @StudentID, @Score);",
                    connection, transaction);
                command.Parameters.Add("@ExamId", SqlDbType.Int).Value = selectedExamId.Value;
                command.Parameters.Add("@StudentID", SqlDbType.VarChar, 10).Value = item.StudentId;
                command.Parameters.Add("@Score", SqlDbType.Float).Value = item.RawScore;
                command.ExecuteNonQuery();
            }
            using (var status = new SqlCommand("UPDATE dbo.Exams SET Status = N'Entered' WHERE ExamId = @ExamId", connection, transaction))
            {
                status.Parameters.Add("@ExamId", SqlDbType.Int).Value = selectedExamId.Value;
                status.ExecuteNonQuery();
            }
            transaction.Commit();
            examMessage.Text = "Raw scores saved. Transmuted and weighted grades are displayed beside each score.";
            examMessage.ForeColor = GreenColor;
            LoadExamRows();
            LoadPerformance();
        }
        catch (Exception ex) { ShowMessage("Exam", ex.Message); }
    }

    private void LoadPerformance()
    {
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"WITH Enrolled AS
                (
                    SELECT s.StudentID, s.StudentName
                    FROM dbo.Students s JOIN dbo.Enrollments en ON en.StudentID = s.StudentID
                    WHERE en.CourseId = @CourseId
                ), AttendanceStats AS
                (
                    SELECT StudentID, CAST(100.0 * SUM(CASE WHEN Status IN (N'PRESENT', N'LATE') THEN 1 ELSE 0 END) / NULLIF(COUNT(*), 0) AS FLOAT) AS AttendancePct
                    FROM dbo.Attendance WHERE CourseId = @CourseId GROUP BY StudentID
                ), QuizStats AS
                (
                    SELECT qs.StudentID, AVG(CASE WHEN q.TotalScore > 0 THEN qs.Score * 100.0 / q.TotalScore END) AS QuizPct
                    FROM dbo.QuizScores qs JOIN dbo.Quizzes q ON q.QuizId = qs.QuizId
                    WHERE q.CourseId = @CourseId GROUP BY qs.StudentID
                ), ExamStats AS
                (
                    SELECT es.StudentID,
                        SUM(((es.Score * 85.0 / NULLIF(ex.TotalItems, 0)) + 15.0) * ex.WeightPercent / 100.0) AS ExamWeighted
                    FROM dbo.ExamScores es JOIN dbo.Exams ex ON ex.ExamId = es.ExamId
                    WHERE ex.CourseId = @CourseId AND ex.GradingPeriod = @Period
                        AND ex.TotalItems > 0 AND es.Score >= 0 AND es.Score <= ex.TotalItems
                    GROUP BY es.StudentID
                )
                SELECT e.StudentName AS [Student Name],
                    CAST(ROUND(COALESCE(a.AttendancePct, 0), 1) AS DECIMAL(5,1)) AS [Attendance %],
                    CAST(ROUND(COALESCE(q.QuizPct, 0), 1) AS DECIMAL(5,1)) AS [Quiz Avg %],
                    CAST(ROUND(COALESCE(x.ExamWeighted, 0), 1) AS DECIMAL(6,1)) AS [Exam Weighted Contribution],
                    CAST(ROUND((COALESCE(a.AttendancePct, 0) + COALESCE(q.QuizPct, 0) + COALESCE(x.ExamWeighted, 0)) / 3.0, 1) AS DECIMAL(6,1)) AS [Overall %]
                FROM Enrolled e LEFT JOIN AttendanceStats a ON a.StudentID = e.StudentID
                    LEFT JOIN QuizStats q ON q.StudentID = e.StudentID LEFT JOIN ExamStats x ON x.StudentID = e.StudentID
                ORDER BY e.StudentName", connection);
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@Period", SqlDbType.NVarChar, 30).Value = gradingPeriod;
            using var adapter = new SqlDataAdapter(command);
            var data = new DataTable();
            adapter.Fill(data);
            if (!data.Columns.Contains("Remark")) data.Columns.Add("Remark", typeof(string));
            foreach (DataRow row in data.Rows)
            {
                double pct = Convert.ToDouble(row["Overall %"]);
                row["Remark"] = pct >= 90 ? "🟢 Excellent" : pct >= 75 ? "🟡 Good" : "🔴 Needs Help";
            }
            performanceGrid.DataSource = data;
            performanceGrid.CellFormatting -= PerformanceCellFormatting;
            performanceGrid.CellFormatting += PerformanceCellFormatting;
        }
        catch (SqlException ex) { ShowMessage("Performance", ex.Message); }
    }

    private void PerformanceCellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || !performanceGrid.Columns[e.ColumnIndex].HeaderText.Contains('%')) return;
        if (double.TryParse(Convert.ToString(e.Value), out double percent))
            e.CellStyle.ForeColor = ColorForPercent(percent);
    }

    private static Color ColorForPercent(double percent) => percent >= 90
        ? Color.FromArgb(0, 204, 0)
        : percent >= 75 ? Color.FromArgb(255, 170, 0) : AccentColor;

    private static Color ColorForAttendance(string status) => status.ToUpperInvariant() switch
    {
        "PRESENT" => Color.FromArgb(0, 204, 0),
        "LATE" => Color.FromArgb(255, 170, 0),
        "ABSENT" => AccentColor,
        "EXCUSED" => Color.FromArgb(79, 195, 247),
        _ => Color.Gray
    };

    private void ShowMessage(string section, string message)
    {
        Label label = section switch
        {
            "Attendance" => attendanceMessage,
            "Quiz" => quizMessage,
            "Exam" => examMessage,
            _ => new Label()
        };
        label.Text = message;
        label.ForeColor = Color.FromArgb(255, 170, 0);
        if (section is not ("Attendance" or "Quiz" or "Exam"))
            MessageBox.Show(message, section, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
