using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SMART
{

public partial class InstructorCourses : Form
{
    #region Windows Form Designer generated code
    private System.Windows.Forms.TabControl designerControl1 = null!;
    private System.Windows.Forms.TabPage designerControl2 = null!;
    private System.Windows.Forms.DataGridView studentsGrid = null!;
    private System.Windows.Forms.TabPage designerControl4 = null!;
    private System.Windows.Forms.DataGridView attendanceGrid = null!;
    private SMART.RoundedFlowLayoutPanel designerControl6 = null!;
    private System.Windows.Forms.DateTimePicker attendanceDate = null!;
    private SMART.CustomButton designerControl8 = null!;
    private SMART.CustomButton designerControl9 = null!;
    private System.Windows.Forms.Label attendanceMessage = null!;
    private System.Windows.Forms.TabPage designerControl11 = null!;
    private System.Windows.Forms.SplitContainer designerControl12 = null!;
    private System.Windows.Forms.DataGridView quizGrid = null!;
    private System.Windows.Forms.DataGridView quizScoreGrid = null!;
    private SMART.RoundedFlowLayoutPanel designerControl15 = null!;
    private SMART.CustomButton designerControl16 = null!;
    private SMART.CustomButton designerControl17 = null!;
    private System.Windows.Forms.Label quizMessage = null!;
    private SMART.CustomPanel designerControl19 = null!;
    private SMART.RoundedTextBox quizTitleInput = null!;
    private SMART.RoundedTextBox quizTotalInput = null!;
    private System.Windows.Forms.DateTimePicker quizDate = null!;
    private SMART.CustomButton designerControl23 = null!;
    private System.Windows.Forms.TabPage designerControl24 = null!;
    private System.Windows.Forms.SplitContainer designerControl25 = null!;
    private System.Windows.Forms.DataGridView examGrid = null!;
    private System.Windows.Forms.DataGridView examScoreGrid = null!;
    private SMART.RoundedFlowLayoutPanel designerControl28 = null!;
    private SMART.CustomButton designerControl29 = null!;
    private SMART.CustomButton designerControl30 = null!;
    private System.Windows.Forms.Label examMessage = null!;
    private SMART.CustomPanel designerControl32 = null!;
    private System.Windows.Forms.Label designerControl33 = null!;
    private System.Windows.Forms.DateTimePicker examDate = null!;
    private SMART.RoundedTextBox examItemsInput = null!;
    private SMART.RoundedTextBox examWeightInput = null!;
    private SMART.CustomButton designerControl37 = null!;
    private System.Windows.Forms.TabPage designerControl38 = null!;
    private System.Windows.Forms.DataGridView performanceGrid = null!;
    private SMART.RoundedFlowLayoutPanel designerControl40 = null!;
    private SMART.CustomButton designerControl41 = null!;
    private SMART.CustomPanel designerControl42 = null!;
    private SMART.CustomPanel designerControl43 = null!;
    private System.Windows.Forms.Label designerControl44 = null!;
    private System.Windows.Forms.Label designerControl45 = null!;
    private SMART.CustomButton designerControl46 = null!;

    private void InitializeComponent()
    {
            designerControl1 = new System.Windows.Forms.TabControl();
            designerControl2 = new System.Windows.Forms.TabPage();
            studentsGrid = new System.Windows.Forms.DataGridView();
            designerControl4 = new System.Windows.Forms.TabPage();
            attendanceGrid = new System.Windows.Forms.DataGridView();
            designerControl6 = new SMART.RoundedFlowLayoutPanel();
            attendanceDate = new System.Windows.Forms.DateTimePicker();
            designerControl8 = new SMART.CustomButton();
            designerControl9 = new SMART.CustomButton();
            attendanceMessage = new System.Windows.Forms.Label();
            designerControl11 = new System.Windows.Forms.TabPage();
            designerControl12 = new System.Windows.Forms.SplitContainer();
            quizGrid = new System.Windows.Forms.DataGridView();
            quizScoreGrid = new System.Windows.Forms.DataGridView();
            designerControl15 = new SMART.RoundedFlowLayoutPanel();
            designerControl16 = new SMART.CustomButton();
            designerControl17 = new SMART.CustomButton();
            quizMessage = new System.Windows.Forms.Label();
            designerControl19 = new SMART.CustomPanel();
            quizTitleInput = new SMART.RoundedTextBox();
            quizTotalInput = new SMART.RoundedTextBox();
            quizDate = new System.Windows.Forms.DateTimePicker();
            designerControl23 = new SMART.CustomButton();
            designerControl24 = new System.Windows.Forms.TabPage();
            designerControl25 = new System.Windows.Forms.SplitContainer();
            examGrid = new System.Windows.Forms.DataGridView();
            examScoreGrid = new System.Windows.Forms.DataGridView();
            designerControl28 = new SMART.RoundedFlowLayoutPanel();
            designerControl29 = new SMART.CustomButton();
            designerControl30 = new SMART.CustomButton();
            examMessage = new System.Windows.Forms.Label();
            designerControl32 = new SMART.CustomPanel();
            designerControl33 = new System.Windows.Forms.Label();
            examDate = new System.Windows.Forms.DateTimePicker();
            examItemsInput = new SMART.RoundedTextBox();
            examWeightInput = new SMART.RoundedTextBox();
            designerControl37 = new SMART.CustomButton();
            designerControl38 = new System.Windows.Forms.TabPage();
            performanceGrid = new System.Windows.Forms.DataGridView();
            designerControl40 = new SMART.RoundedFlowLayoutPanel();
            designerControl41 = new SMART.CustomButton();
            designerControl42 = new SMART.CustomPanel();
            designerControl43 = new SMART.CustomPanel();
            designerControl44 = new System.Windows.Forms.Label();
            designerControl45 = new System.Windows.Forms.Label();
            designerControl46 = new SMART.CustomButton();
            var studentsGridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var studentsGridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var studentsGridDefaultCellStyle = new DataGridViewCellStyle();
            var attendanceGridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var attendanceGridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var attendanceGridDefaultCellStyle = new DataGridViewCellStyle();
            var quizGridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var quizGridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var quizGridDefaultCellStyle = new DataGridViewCellStyle();
            var quizScoreGridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var quizScoreGridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var quizScoreGridDefaultCellStyle = new DataGridViewCellStyle();
            var examGridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var examGridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var examGridDefaultCellStyle = new DataGridViewCellStyle();
            var examScoreGridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var examScoreGridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var examScoreGridDefaultCellStyle = new DataGridViewCellStyle();
            var performanceGridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var performanceGridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var performanceGridDefaultCellStyle = new DataGridViewCellStyle();
            ((System.ComponentModel.ISupportInitialize)designerControl12).BeginInit();
            designerControl12.Panel1.SuspendLayout();
            designerControl12.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)designerControl25).BeginInit();
            designerControl25.Panel1.SuspendLayout();
            designerControl25.Panel2.SuspendLayout();
            designerControl1.SuspendLayout();
            designerControl2.SuspendLayout();
            designerControl4.SuspendLayout();
            designerControl6.SuspendLayout();
            designerControl11.SuspendLayout();
            designerControl12.SuspendLayout();
            designerControl15.SuspendLayout();
            designerControl19.SuspendLayout();
            designerControl24.SuspendLayout();
            designerControl25.SuspendLayout();
            designerControl28.SuspendLayout();
            designerControl32.SuspendLayout();
            designerControl38.SuspendLayout();
            designerControl40.SuspendLayout();
            designerControl42.SuspendLayout();
            designerControl43.SuspendLayout();
            SuspendLayout();
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(1200, 800);
            this.Dock = (System.Windows.Forms.DockStyle)0;
            this.Anchor = (System.Windows.Forms.AnchorStyles)5;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            this.AutoSize = false;
            this.AutoScroll = false;
            this.Text = "S.M.A.R.T. — Course title";
            this.TabIndex = 0;
            this.TabStop = true;
            this.Enabled = true;
            this.DialogResult = (System.Windows.Forms.DialogResult)0;
            this.StartPosition = (System.Windows.Forms.FormStartPosition)4;
            this.FormBorderStyle = (System.Windows.Forms.FormBorderStyle)4;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ShowInTaskbar = true;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.ClientSize = new System.Drawing.Size(1184, 761);
            designerControl1.Name = "designerControl1";
            designerControl1.Location = new System.Drawing.Point(0, 88);
            designerControl1.Size = new System.Drawing.Size(1184, 673);
            designerControl1.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl1.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl1.Padding = new System.Drawing.Point(14, 6);
            designerControl1.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
            designerControl1.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl1.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl1.AutoSize = false;
            designerControl1.Text = "";
            designerControl1.TabIndex = 0;
            designerControl1.TabStop = true;
            designerControl1.Enabled = true;
            designerControl1.Multiline = false;
            designerControl1.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl2.Name = "designerControl2";
            designerControl2.Location = new System.Drawing.Point(0, 0);
            designerControl2.Size = new System.Drawing.Size(200, 100);
            designerControl2.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl2.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl2.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            designerControl2.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl2.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl2.AutoSize = false;
            designerControl2.AutoScroll = false;
            designerControl2.Text = "👥 Students";
            designerControl2.TabIndex = 0;
            designerControl2.TabStop = false;
            designerControl2.Enabled = true;
            designerControl2.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl2.MinimumSize = new System.Drawing.Size(0, 0);
            studentsGrid.Name = "studentsGrid";
            studentsGrid.Location = new System.Drawing.Point(12, 12);
            studentsGrid.Size = new System.Drawing.Size(176, 76);
            studentsGrid.Dock = (System.Windows.Forms.DockStyle)5;
            studentsGrid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            studentsGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            studentsGrid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            studentsGrid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            studentsGrid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            studentsGrid.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            studentsGrid.AutoSize = false;
            studentsGrid.Text = "";
            studentsGrid.TabIndex = 0;
            studentsGrid.TabStop = true;
            studentsGrid.Enabled = true;
            studentsGrid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            studentsGrid.ReadOnly = true;
            studentsGrid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            studentsGrid.AllowUserToAddRows = false;
            studentsGrid.AllowUserToDeleteRows = false;
            studentsGrid.AllowUserToResizeRows = false;
            studentsGrid.MultiSelect = true;
            studentsGrid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            studentsGrid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)16;
            studentsGrid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            studentsGrid.GridColor = System.Drawing.Color.FromArgb(255, 40, 40, 60);
            studentsGrid.EnableHeadersVisualStyles = false;
            studentsGrid.RowHeadersVisible = false;
            studentsGrid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            studentsGrid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            studentsGrid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            studentsGrid.ColumnHeadersHeight = 23;
            studentsGrid.MinimumSize = new System.Drawing.Size(0, 0);
            studentsGrid.RowTemplate.Height = 36;
            studentsGridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            studentsGridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            studentsGridColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 0, 120, 215);
            studentsGridColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            studentsGridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            studentsGridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            studentsGridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            studentsGridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)1;
            studentsGrid.ColumnHeadersDefaultCellStyle = studentsGridColumnHeadersDefaultCellStyle;
            studentsGridAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 28, 40, 72);
            studentsGridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            studentsGridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            studentsGridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            studentsGrid.AlternatingRowsDefaultCellStyle = studentsGridAlternatingRowsDefaultCellStyle;
            studentsGridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            studentsGridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            studentsGridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            studentsGridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            studentsGridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            studentsGridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            studentsGridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            studentsGridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            studentsGrid.DefaultCellStyle = studentsGridDefaultCellStyle;
            designerControl4.Name = "designerControl4";
            designerControl4.Location = new System.Drawing.Point(0, 0);
            designerControl4.Size = new System.Drawing.Size(200, 100);
            designerControl4.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl4.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl4.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            designerControl4.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl4.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl4.AutoSize = false;
            designerControl4.AutoScroll = false;
            designerControl4.Text = "📋 Attendance";
            designerControl4.TabIndex = 1;
            designerControl4.TabStop = false;
            designerControl4.Enabled = true;
            designerControl4.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl4.MinimumSize = new System.Drawing.Size(0, 0);
            attendanceGrid.Name = "attendanceGrid";
            attendanceGrid.Location = new System.Drawing.Point(12, 70);
            attendanceGrid.Size = new System.Drawing.Size(176, 18);
            attendanceGrid.Dock = (System.Windows.Forms.DockStyle)5;
            attendanceGrid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            attendanceGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            attendanceGrid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            attendanceGrid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            attendanceGrid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            attendanceGrid.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            attendanceGrid.AutoSize = false;
            attendanceGrid.Text = "";
            attendanceGrid.TabIndex = 0;
            attendanceGrid.TabStop = true;
            attendanceGrid.Enabled = true;
            attendanceGrid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            attendanceGrid.ReadOnly = true;
            attendanceGrid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            attendanceGrid.AllowUserToAddRows = false;
            attendanceGrid.AllowUserToDeleteRows = false;
            attendanceGrid.AllowUserToResizeRows = false;
            attendanceGrid.MultiSelect = true;
            attendanceGrid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            attendanceGrid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)16;
            attendanceGrid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            attendanceGrid.GridColor = System.Drawing.Color.FromArgb(255, 40, 40, 60);
            attendanceGrid.EnableHeadersVisualStyles = false;
            attendanceGrid.RowHeadersVisible = false;
            attendanceGrid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            attendanceGrid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            attendanceGrid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            attendanceGrid.ColumnHeadersHeight = 23;
            attendanceGrid.MinimumSize = new System.Drawing.Size(0, 0);
            attendanceGrid.RowTemplate.Height = 36;
            attendanceGridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            attendanceGridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            attendanceGridColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 0, 120, 215);
            attendanceGridColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            attendanceGridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            attendanceGridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            attendanceGridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            attendanceGridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)1;
            attendanceGrid.ColumnHeadersDefaultCellStyle = attendanceGridColumnHeadersDefaultCellStyle;
            attendanceGridAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 28, 40, 72);
            attendanceGridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            attendanceGridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            attendanceGridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            attendanceGrid.AlternatingRowsDefaultCellStyle = attendanceGridAlternatingRowsDefaultCellStyle;
            attendanceGridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            attendanceGridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            attendanceGridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            attendanceGridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            attendanceGridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            attendanceGridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            attendanceGridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            attendanceGridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            attendanceGrid.DefaultCellStyle = attendanceGridDefaultCellStyle;
            designerControl6.Name = "designerControl6";
            designerControl6.Location = new System.Drawing.Point(12, 12);
            designerControl6.Size = new System.Drawing.Size(176, 58);
            designerControl6.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl6.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl6.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            designerControl6.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl6.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl6.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl6.AutoSize = false;
            designerControl6.AutoScroll = false;
            designerControl6.Text = "";
            designerControl6.TabIndex = 1;
            designerControl6.TabStop = false;
            designerControl6.Enabled = true;
            designerControl6.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl6.BorderColor = System.Drawing.Color.FromArgb(255, 128, 128, 128);
            designerControl6.BorderRadius = 20;
            designerControl6.BorderSize = 0;
            designerControl6.FlowDirection = (System.Windows.Forms.FlowDirection)0;
            designerControl6.WrapContents = false;
            designerControl6.MinimumSize = new System.Drawing.Size(0, 0);
            attendanceDate.Name = "attendanceDate";
            attendanceDate.Location = new System.Drawing.Point(8, 16);
            attendanceDate.Size = new System.Drawing.Size(150, 25);
            attendanceDate.Dock = (System.Windows.Forms.DockStyle)0;
            attendanceDate.Anchor = (System.Windows.Forms.AnchorStyles)5;
            attendanceDate.Margin = new System.Windows.Forms.Padding(4, 8, 8, 4);
            attendanceDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            attendanceDate.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            attendanceDate.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            attendanceDate.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            attendanceDate.AutoSize = false;
            attendanceDate.Text = "";
            attendanceDate.TabIndex = 0;
            attendanceDate.TabStop = true;
            attendanceDate.Enabled = true;
            attendanceDate.Format = (System.Windows.Forms.DateTimePickerFormat)2;
            attendanceDate.ShowCheckBox = false;
            attendanceDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            attendanceDate.CalendarForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            attendanceDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            attendanceDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            attendanceDate.Checked = true;
            attendanceDate.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl8.Name = "designerControl8";
            designerControl8.Location = new System.Drawing.Point(169, 11);
            designerControl8.Size = new System.Drawing.Size(140, 38);
            designerControl8.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl8.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl8.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl8.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl8.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl8.AutoSize = false;
            designerControl8.Text = "Load Students";
            designerControl8.TabIndex = 1;
            designerControl8.TabStop = true;
            designerControl8.Enabled = true;
            designerControl8.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl8.BorderRadius = 7;
            designerControl8.BorderSize = 0;
            designerControl8.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl8.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl8.AutoEllipsis = false;
            designerControl8.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl8.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl9.Name = "designerControl9";
            designerControl9.Location = new System.Drawing.Point(315, 11);
            designerControl9.Size = new System.Drawing.Size(155, 38);
            designerControl9.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl9.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl9.BackColor = System.Drawing.Color.FromArgb(255, 0, 170, 0);
            designerControl9.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl9.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl9.AutoSize = false;
            designerControl9.Text = "Save Attendance";
            designerControl9.TabIndex = 2;
            designerControl9.TabStop = true;
            designerControl9.Enabled = true;
            designerControl9.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl9.BorderRadius = 7;
            designerControl9.BorderSize = 0;
            designerControl9.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl9.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl9.AutoEllipsis = false;
            designerControl9.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl9.MinimumSize = new System.Drawing.Size(0, 0);
            attendanceMessage.Name = "attendanceMessage";
            attendanceMessage.Location = new System.Drawing.Point(476, 8);
            attendanceMessage.Size = new System.Drawing.Size(100, 23);
            attendanceMessage.Dock = (System.Windows.Forms.DockStyle)0;
            attendanceMessage.Anchor = (System.Windows.Forms.AnchorStyles)5;
            attendanceMessage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            attendanceMessage.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            attendanceMessage.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            attendanceMessage.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            attendanceMessage.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            attendanceMessage.AutoSize = false;
            attendanceMessage.Text = "";
            attendanceMessage.TabIndex = 3;
            attendanceMessage.TabStop = false;
            attendanceMessage.Enabled = true;
            attendanceMessage.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            attendanceMessage.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            attendanceMessage.TextAlign = (System.Drawing.ContentAlignment)16;
            attendanceMessage.AutoEllipsis = false;
            attendanceMessage.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl11.Name = "designerControl11";
            designerControl11.Location = new System.Drawing.Point(0, 0);
            designerControl11.Size = new System.Drawing.Size(200, 100);
            designerControl11.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl11.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl11.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            designerControl11.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl11.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl11.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl11.AutoSize = false;
            designerControl11.AutoScroll = false;
            designerControl11.Text = "📝 Quizzes";
            designerControl11.TabIndex = 2;
            designerControl11.TabStop = false;
            designerControl11.Enabled = true;
            designerControl11.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl11.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl12.Name = "designerControl12";
            designerControl12.Location = new System.Drawing.Point(12, 152);
            designerControl12.Size = new System.Drawing.Size(1100, 450);
            designerControl12.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl12.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl12.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl12.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl12.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl12.AutoSize = false;
            designerControl12.AutoScroll = false;
            designerControl12.Text = "";
            designerControl12.TabIndex = 0;
            designerControl12.TabStop = true;
            designerControl12.Enabled = true;
            designerControl12.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl12.Orientation = (System.Windows.Forms.Orientation)0;
            designerControl12.SplitterWidth = 4;
            designerControl12.FixedPanel = (System.Windows.Forms.FixedPanel)0;
            designerControl12.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl12.SplitterDistance = 210;
            designerControl12.Panel1MinSize = 25;
            designerControl12.Panel2MinSize = 25;
            designerControl12.Panel1.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl12.Panel2.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            quizGrid.Name = "quizGrid";
            quizGrid.Location = new System.Drawing.Point(0, 0);
            quizGrid.Size = new System.Drawing.Size(176, 38);
            quizGrid.Dock = (System.Windows.Forms.DockStyle)5;
            quizGrid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            quizGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            quizGrid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizGrid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            quizGrid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizGrid.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            quizGrid.AutoSize = false;
            quizGrid.Text = "";
            quizGrid.TabIndex = 0;
            quizGrid.TabStop = true;
            quizGrid.Enabled = true;
            quizGrid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            quizGrid.ReadOnly = true;
            quizGrid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            quizGrid.AllowUserToAddRows = false;
            quizGrid.AllowUserToDeleteRows = false;
            quizGrid.AllowUserToResizeRows = false;
            quizGrid.MultiSelect = true;
            quizGrid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            quizGrid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)16;
            quizGrid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            quizGrid.GridColor = System.Drawing.Color.FromArgb(255, 40, 40, 60);
            quizGrid.EnableHeadersVisualStyles = false;
            quizGrid.RowHeadersVisible = false;
            quizGrid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            quizGrid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            quizGrid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            quizGrid.ColumnHeadersHeight = 23;
            quizGrid.MinimumSize = new System.Drawing.Size(0, 0);
            quizGrid.RowTemplate.Height = 36;
            quizGridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            quizGridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizGridColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 0, 120, 215);
            quizGridColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizGridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            quizGridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizGridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            quizGridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)1;
            quizGrid.ColumnHeadersDefaultCellStyle = quizGridColumnHeadersDefaultCellStyle;
            quizGridAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 28, 40, 72);
            quizGridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizGridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            quizGridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            quizGrid.AlternatingRowsDefaultCellStyle = quizGridAlternatingRowsDefaultCellStyle;
            quizGridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            quizGridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizGridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            quizGridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizGridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            quizGridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizGridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            quizGridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            quizGrid.DefaultCellStyle = quizGridDefaultCellStyle;
            quizScoreGrid.Name = "quizScoreGrid";
            quizScoreGrid.Location = new System.Drawing.Point(0, 0);
            quizScoreGrid.Size = new System.Drawing.Size(176, 100);
            quizScoreGrid.Dock = (System.Windows.Forms.DockStyle)5;
            quizScoreGrid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            quizScoreGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            quizScoreGrid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizScoreGrid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            quizScoreGrid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizScoreGrid.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            quizScoreGrid.AutoSize = false;
            quizScoreGrid.Text = "";
            quizScoreGrid.TabIndex = 0;
            quizScoreGrid.TabStop = true;
            quizScoreGrid.Enabled = true;
            quizScoreGrid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            quizScoreGrid.ReadOnly = true;
            quizScoreGrid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            quizScoreGrid.AllowUserToAddRows = false;
            quizScoreGrid.AllowUserToDeleteRows = false;
            quizScoreGrid.AllowUserToResizeRows = false;
            quizScoreGrid.MultiSelect = true;
            quizScoreGrid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            quizScoreGrid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)16;
            quizScoreGrid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            quizScoreGrid.GridColor = System.Drawing.Color.FromArgb(255, 40, 40, 60);
            quizScoreGrid.EnableHeadersVisualStyles = false;
            quizScoreGrid.RowHeadersVisible = false;
            quizScoreGrid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            quizScoreGrid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            quizScoreGrid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            quizScoreGrid.ColumnHeadersHeight = 23;
            quizScoreGrid.MinimumSize = new System.Drawing.Size(0, 0);
            quizScoreGrid.RowTemplate.Height = 36;
            quizScoreGridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            quizScoreGridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizScoreGridColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 0, 120, 215);
            quizScoreGridColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizScoreGridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            quizScoreGridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizScoreGridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            quizScoreGridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)1;
            quizScoreGrid.ColumnHeadersDefaultCellStyle = quizScoreGridColumnHeadersDefaultCellStyle;
            quizScoreGridAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 28, 40, 72);
            quizScoreGridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizScoreGridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            quizScoreGridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            quizScoreGrid.AlternatingRowsDefaultCellStyle = quizScoreGridAlternatingRowsDefaultCellStyle;
            quizScoreGridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            quizScoreGridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizScoreGridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            quizScoreGridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizScoreGridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            quizScoreGridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizScoreGridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            quizScoreGridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            quizScoreGrid.DefaultCellStyle = quizScoreGridDefaultCellStyle;
            designerControl15.Name = "designerControl15";
            designerControl15.Location = new System.Drawing.Point(0, -14);
            designerControl15.Size = new System.Drawing.Size(176, 48);
            designerControl15.Dock = (System.Windows.Forms.DockStyle)2;
            designerControl15.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl15.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            designerControl15.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl15.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl15.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl15.AutoSize = false;
            designerControl15.AutoScroll = false;
            designerControl15.Text = "";
            designerControl15.TabIndex = 1;
            designerControl15.TabStop = false;
            designerControl15.Enabled = true;
            designerControl15.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl15.BorderColor = System.Drawing.Color.FromArgb(255, 128, 128, 128);
            designerControl15.BorderRadius = 20;
            designerControl15.BorderSize = 0;
            designerControl15.FlowDirection = (System.Windows.Forms.FlowDirection)0;
            designerControl15.WrapContents = false;
            designerControl15.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl16.Name = "designerControl16";
            designerControl16.Location = new System.Drawing.Point(7, 7);
            designerControl16.Size = new System.Drawing.Size(250, 38);
            designerControl16.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl16.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl16.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl16.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl16.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl16.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl16.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl16.AutoSize = false;
            designerControl16.Text = "Load Scores for Selected Quiz";
            designerControl16.TabIndex = 0;
            designerControl16.TabStop = true;
            designerControl16.Enabled = true;
            designerControl16.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl16.BorderRadius = 7;
            designerControl16.BorderSize = 0;
            designerControl16.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl16.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl16.AutoEllipsis = false;
            designerControl16.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl16.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl17.Name = "designerControl17";
            designerControl17.Location = new System.Drawing.Point(263, 7);
            designerControl17.Size = new System.Drawing.Size(140, 38);
            designerControl17.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl17.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl17.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl17.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl17.BackColor = System.Drawing.Color.FromArgb(255, 0, 170, 0);
            designerControl17.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl17.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl17.AutoSize = false;
            designerControl17.Text = "Save Scores";
            designerControl17.TabIndex = 1;
            designerControl17.TabStop = true;
            designerControl17.Enabled = true;
            designerControl17.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl17.BorderRadius = 7;
            designerControl17.BorderSize = 0;
            designerControl17.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl17.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl17.AutoEllipsis = false;
            designerControl17.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl17.MinimumSize = new System.Drawing.Size(0, 0);
            quizMessage.Name = "quizMessage";
            quizMessage.Location = new System.Drawing.Point(12, 124);
            quizMessage.Size = new System.Drawing.Size(176, 28);
            quizMessage.Dock = (System.Windows.Forms.DockStyle)1;
            quizMessage.Anchor = (System.Windows.Forms.AnchorStyles)5;
            quizMessage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            quizMessage.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            quizMessage.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            quizMessage.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            quizMessage.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            quizMessage.AutoSize = false;
            quizMessage.Text = "";
            quizMessage.TabIndex = 1;
            quizMessage.TabStop = false;
            quizMessage.Enabled = true;
            quizMessage.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            quizMessage.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            quizMessage.TextAlign = (System.Drawing.ContentAlignment)16;
            quizMessage.AutoEllipsis = false;
            quizMessage.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl19.Name = "designerControl19";
            designerControl19.Location = new System.Drawing.Point(12, 12);
            designerControl19.Size = new System.Drawing.Size(176, 112);
            designerControl19.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl19.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl19.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl19.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            designerControl19.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl19.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl19.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl19.AutoSize = false;
            designerControl19.AutoScroll = false;
            designerControl19.Text = "";
            designerControl19.TabIndex = 2;
            designerControl19.TabStop = false;
            designerControl19.Enabled = true;
            designerControl19.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl19.BorderColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl19.BorderWidth = 0;
            designerControl19.CornerRadius = 8;
            designerControl19.MinimumSize = new System.Drawing.Size(0, 0);
            quizTitleInput.Name = "quizTitleInput";
            quizTitleInput.Location = new System.Drawing.Point(12, 12);
            quizTitleInput.Size = new System.Drawing.Size(260, 40);
            quizTitleInput.Dock = (System.Windows.Forms.DockStyle)0;
            quizTitleInput.Anchor = (System.Windows.Forms.AnchorStyles)5;
            quizTitleInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            quizTitleInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizTitleInput.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            quizTitleInput.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizTitleInput.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            quizTitleInput.AutoSize = false;
            quizTitleInput.AutoScroll = false;
            quizTitleInput.Text = "";
            quizTitleInput.TabIndex = 0;
            quizTitleInput.TabStop = true;
            quizTitleInput.Enabled = true;
            quizTitleInput.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            quizTitleInput.BorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            quizTitleInput.BorderRadius = 7;
            quizTitleInput.BorderSize = 2;
            quizTitleInput.FillColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            quizTitleInput.FocusBorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            quizTitleInput.PlaceholderText = "Quiz title";
            quizTitleInput.Multiline = false;
            quizTitleInput.ReadOnly = false;
            quizTitleInput.MaxLength = 32767;
            quizTitleInput.UseSystemPasswordChar = false;
            quizTitleInput.PasswordChar = (char)0;
            quizTitleInput.MinimumSize = new System.Drawing.Size(0, 0);
            quizTotalInput.Name = "quizTotalInput";
            quizTotalInput.Location = new System.Drawing.Point(284, 12);
            quizTotalInput.Size = new System.Drawing.Size(150, 40);
            quizTotalInput.Dock = (System.Windows.Forms.DockStyle)0;
            quizTotalInput.Anchor = (System.Windows.Forms.AnchorStyles)5;
            quizTotalInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            quizTotalInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizTotalInput.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            quizTotalInput.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizTotalInput.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            quizTotalInput.AutoSize = false;
            quizTotalInput.AutoScroll = false;
            quizTotalInput.Text = "";
            quizTotalInput.TabIndex = 1;
            quizTotalInput.TabStop = true;
            quizTotalInput.Enabled = true;
            quizTotalInput.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            quizTotalInput.BorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            quizTotalInput.BorderRadius = 7;
            quizTotalInput.BorderSize = 2;
            quizTotalInput.FillColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            quizTotalInput.FocusBorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            quizTotalInput.PlaceholderText = "Total score";
            quizTotalInput.Multiline = false;
            quizTotalInput.ReadOnly = false;
            quizTotalInput.MaxLength = 12;
            quizTotalInput.UseSystemPasswordChar = false;
            quizTotalInput.PasswordChar = (char)0;
            quizTotalInput.MinimumSize = new System.Drawing.Size(0, 0);
            quizDate.Name = "quizDate";
            quizDate.Location = new System.Drawing.Point(446, 14);
            quizDate.Size = new System.Drawing.Size(150, 25);
            quizDate.Dock = (System.Windows.Forms.DockStyle)0;
            quizDate.Anchor = (System.Windows.Forms.AnchorStyles)5;
            quizDate.Margin = new System.Windows.Forms.Padding(4, 8, 8, 4);
            quizDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            quizDate.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            quizDate.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizDate.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            quizDate.AutoSize = false;
            quizDate.Text = "";
            quizDate.TabIndex = 2;
            quizDate.TabStop = true;
            quizDate.Enabled = true;
            quizDate.Format = (System.Windows.Forms.DateTimePickerFormat)2;
            quizDate.ShowCheckBox = false;
            quizDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            quizDate.CalendarForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            quizDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            quizDate.Checked = true;
            quizDate.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl23.Name = "designerControl23";
            designerControl23.Location = new System.Drawing.Point(608, 12);
            designerControl23.Size = new System.Drawing.Size(150, 38);
            designerControl23.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl23.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl23.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl23.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl23.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl23.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl23.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl23.AutoSize = false;
            designerControl23.Text = "Create Quiz";
            designerControl23.TabIndex = 3;
            designerControl23.TabStop = true;
            designerControl23.Enabled = true;
            designerControl23.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl23.BorderRadius = 7;
            designerControl23.BorderSize = 0;
            designerControl23.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl23.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl23.AutoEllipsis = false;
            designerControl23.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl23.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl24.Name = "designerControl24";
            designerControl24.Location = new System.Drawing.Point(0, 0);
            designerControl24.Size = new System.Drawing.Size(200, 100);
            designerControl24.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl24.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl24.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl24.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            designerControl24.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl24.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl24.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl24.AutoSize = false;
            designerControl24.AutoScroll = false;
            designerControl24.Text = "📄 Exams";
            designerControl24.TabIndex = 3;
            designerControl24.TabStop = false;
            designerControl24.Enabled = true;
            designerControl24.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl24.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl25.Name = "designerControl25";
            designerControl25.Location = new System.Drawing.Point(12, 154);
            designerControl25.Size = new System.Drawing.Size(1100, 450);
            designerControl25.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl25.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl25.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl25.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl25.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl25.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl25.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl25.AutoSize = false;
            designerControl25.AutoScroll = false;
            designerControl25.Text = "";
            designerControl25.TabIndex = 0;
            designerControl25.TabStop = true;
            designerControl25.Enabled = true;
            designerControl25.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl25.Orientation = (System.Windows.Forms.Orientation)0;
            designerControl25.SplitterWidth = 4;
            designerControl25.FixedPanel = (System.Windows.Forms.FixedPanel)0;
            designerControl25.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl25.SplitterDistance = 210;
            designerControl25.Panel1MinSize = 25;
            designerControl25.Panel2MinSize = 25;
            designerControl25.Panel1.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl25.Panel2.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            examGrid.Name = "examGrid";
            examGrid.Location = new System.Drawing.Point(0, 0);
            examGrid.Size = new System.Drawing.Size(176, 36);
            examGrid.Dock = (System.Windows.Forms.DockStyle)5;
            examGrid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            examGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            examGrid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examGrid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            examGrid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examGrid.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            examGrid.AutoSize = false;
            examGrid.Text = "";
            examGrid.TabIndex = 0;
            examGrid.TabStop = true;
            examGrid.Enabled = true;
            examGrid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            examGrid.ReadOnly = true;
            examGrid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            examGrid.AllowUserToAddRows = false;
            examGrid.AllowUserToDeleteRows = false;
            examGrid.AllowUserToResizeRows = false;
            examGrid.MultiSelect = true;
            examGrid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            examGrid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)16;
            examGrid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            examGrid.GridColor = System.Drawing.Color.FromArgb(255, 40, 40, 60);
            examGrid.EnableHeadersVisualStyles = false;
            examGrid.RowHeadersVisible = false;
            examGrid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            examGrid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            examGrid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            examGrid.ColumnHeadersHeight = 23;
            examGrid.MinimumSize = new System.Drawing.Size(0, 0);
            examGrid.RowTemplate.Height = 36;
            examGridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            examGridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examGridColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 0, 120, 215);
            examGridColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examGridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            examGridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examGridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            examGridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)1;
            examGrid.ColumnHeadersDefaultCellStyle = examGridColumnHeadersDefaultCellStyle;
            examGridAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 28, 40, 72);
            examGridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examGridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            examGridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            examGrid.AlternatingRowsDefaultCellStyle = examGridAlternatingRowsDefaultCellStyle;
            examGridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            examGridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examGridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            examGridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examGridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            examGridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examGridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            examGridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            examGrid.DefaultCellStyle = examGridDefaultCellStyle;
            examScoreGrid.Name = "examScoreGrid";
            examScoreGrid.Location = new System.Drawing.Point(0, 0);
            examScoreGrid.Size = new System.Drawing.Size(176, 100);
            examScoreGrid.Dock = (System.Windows.Forms.DockStyle)5;
            examScoreGrid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            examScoreGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            examScoreGrid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examScoreGrid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            examScoreGrid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examScoreGrid.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            examScoreGrid.AutoSize = false;
            examScoreGrid.Text = "";
            examScoreGrid.TabIndex = 0;
            examScoreGrid.TabStop = true;
            examScoreGrid.Enabled = true;
            examScoreGrid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            examScoreGrid.ReadOnly = true;
            examScoreGrid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            examScoreGrid.AllowUserToAddRows = false;
            examScoreGrid.AllowUserToDeleteRows = false;
            examScoreGrid.AllowUserToResizeRows = false;
            examScoreGrid.MultiSelect = true;
            examScoreGrid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            examScoreGrid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)16;
            examScoreGrid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            examScoreGrid.GridColor = System.Drawing.Color.FromArgb(255, 40, 40, 60);
            examScoreGrid.EnableHeadersVisualStyles = false;
            examScoreGrid.RowHeadersVisible = false;
            examScoreGrid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            examScoreGrid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            examScoreGrid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            examScoreGrid.ColumnHeadersHeight = 23;
            examScoreGrid.MinimumSize = new System.Drawing.Size(0, 0);
            examScoreGrid.RowTemplate.Height = 36;
            examScoreGridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            examScoreGridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examScoreGridColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 0, 120, 215);
            examScoreGridColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examScoreGridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            examScoreGridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examScoreGridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            examScoreGridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)1;
            examScoreGrid.ColumnHeadersDefaultCellStyle = examScoreGridColumnHeadersDefaultCellStyle;
            examScoreGridAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 28, 40, 72);
            examScoreGridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examScoreGridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            examScoreGridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            examScoreGrid.AlternatingRowsDefaultCellStyle = examScoreGridAlternatingRowsDefaultCellStyle;
            examScoreGridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            examScoreGridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examScoreGridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            examScoreGridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examScoreGridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            examScoreGridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examScoreGridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            examScoreGridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            examScoreGrid.DefaultCellStyle = examScoreGridDefaultCellStyle;
            designerControl28.Name = "designerControl28";
            designerControl28.Location = new System.Drawing.Point(0, -12);
            designerControl28.Size = new System.Drawing.Size(176, 48);
            designerControl28.Dock = (System.Windows.Forms.DockStyle)2;
            designerControl28.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl28.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl28.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            designerControl28.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl28.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl28.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl28.AutoSize = false;
            designerControl28.AutoScroll = false;
            designerControl28.Text = "";
            designerControl28.TabIndex = 1;
            designerControl28.TabStop = false;
            designerControl28.Enabled = true;
            designerControl28.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl28.BorderColor = System.Drawing.Color.FromArgb(255, 128, 128, 128);
            designerControl28.BorderRadius = 20;
            designerControl28.BorderSize = 0;
            designerControl28.FlowDirection = (System.Windows.Forms.FlowDirection)0;
            designerControl28.WrapContents = false;
            designerControl28.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl29.Name = "designerControl29";
            designerControl29.Location = new System.Drawing.Point(7, 7);
            designerControl29.Size = new System.Drawing.Size(205, 38);
            designerControl29.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl29.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl29.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl29.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl29.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl29.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl29.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl29.AutoSize = false;
            designerControl29.Text = "Load Enrolled Students";
            designerControl29.TabIndex = 0;
            designerControl29.TabStop = true;
            designerControl29.Enabled = true;
            designerControl29.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl29.BorderRadius = 7;
            designerControl29.BorderSize = 0;
            designerControl29.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl29.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl29.AutoEllipsis = false;
            designerControl29.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl29.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl30.Name = "designerControl30";
            designerControl30.Location = new System.Drawing.Point(218, 7);
            designerControl30.Size = new System.Drawing.Size(155, 38);
            designerControl30.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl30.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl30.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl30.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl30.BackColor = System.Drawing.Color.FromArgb(255, 0, 170, 0);
            designerControl30.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl30.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl30.AutoSize = false;
            designerControl30.Text = "Save Raw Scores";
            designerControl30.TabIndex = 1;
            designerControl30.TabStop = true;
            designerControl30.Enabled = true;
            designerControl30.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl30.BorderRadius = 7;
            designerControl30.BorderSize = 0;
            designerControl30.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl30.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl30.AutoEllipsis = false;
            designerControl30.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl30.MinimumSize = new System.Drawing.Size(0, 0);
            examMessage.Name = "examMessage";
            examMessage.Location = new System.Drawing.Point(12, 124);
            examMessage.Size = new System.Drawing.Size(176, 30);
            examMessage.Dock = (System.Windows.Forms.DockStyle)1;
            examMessage.Anchor = (System.Windows.Forms.AnchorStyles)5;
            examMessage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            examMessage.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            examMessage.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            examMessage.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            examMessage.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            examMessage.AutoSize = false;
            examMessage.Text = "";
            examMessage.TabIndex = 1;
            examMessage.TabStop = false;
            examMessage.Enabled = true;
            examMessage.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            examMessage.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            examMessage.TextAlign = (System.Drawing.ContentAlignment)16;
            examMessage.AutoEllipsis = false;
            examMessage.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl32.Name = "designerControl32";
            designerControl32.Location = new System.Drawing.Point(12, 12);
            designerControl32.Size = new System.Drawing.Size(176, 112);
            designerControl32.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl32.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl32.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl32.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            designerControl32.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl32.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl32.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl32.AutoSize = false;
            designerControl32.AutoScroll = false;
            designerControl32.Text = "";
            designerControl32.TabIndex = 2;
            designerControl32.TabStop = false;
            designerControl32.Enabled = true;
            designerControl32.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl32.BorderColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl32.BorderWidth = 0;
            designerControl32.CornerRadius = 8;
            designerControl32.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl33.Name = "designerControl33";
            designerControl33.Location = new System.Drawing.Point(12, 8);
            designerControl33.Size = new System.Drawing.Size(220, 24);
            designerControl33.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl33.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl33.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl33.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl33.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl33.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl33.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)1);
            designerControl33.AutoSize = false;
            designerControl33.Text = "Grading period: ";
            designerControl33.TabIndex = 0;
            designerControl33.TabStop = false;
            designerControl33.Enabled = true;
            designerControl33.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl33.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl33.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl33.AutoEllipsis = false;
            designerControl33.MinimumSize = new System.Drawing.Size(0, 0);
            examDate.Name = "examDate";
            examDate.Location = new System.Drawing.Point(12, 44);
            examDate.Size = new System.Drawing.Size(150, 25);
            examDate.Dock = (System.Windows.Forms.DockStyle)0;
            examDate.Anchor = (System.Windows.Forms.AnchorStyles)5;
            examDate.Margin = new System.Windows.Forms.Padding(4, 8, 8, 4);
            examDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examDate.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            examDate.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examDate.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            examDate.AutoSize = false;
            examDate.Text = "";
            examDate.TabIndex = 1;
            examDate.TabStop = true;
            examDate.Enabled = true;
            examDate.Format = (System.Windows.Forms.DateTimePickerFormat)2;
            examDate.ShowCheckBox = true;
            examDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            examDate.CalendarForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            examDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examDate.Checked = true;
            examDate.MinimumSize = new System.Drawing.Size(0, 0);
            examItemsInput.Name = "examItemsInput";
            examItemsInput.Location = new System.Drawing.Point(176, 42);
            examItemsInput.Size = new System.Drawing.Size(150, 40);
            examItemsInput.Dock = (System.Windows.Forms.DockStyle)0;
            examItemsInput.Anchor = (System.Windows.Forms.AnchorStyles)5;
            examItemsInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            examItemsInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examItemsInput.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            examItemsInput.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examItemsInput.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            examItemsInput.AutoSize = false;
            examItemsInput.AutoScroll = false;
            examItemsInput.Text = "";
            examItemsInput.TabIndex = 2;
            examItemsInput.TabStop = true;
            examItemsInput.Enabled = true;
            examItemsInput.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            examItemsInput.BorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            examItemsInput.BorderRadius = 7;
            examItemsInput.BorderSize = 2;
            examItemsInput.FillColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            examItemsInput.FocusBorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            examItemsInput.PlaceholderText = "Total items";
            examItemsInput.Multiline = false;
            examItemsInput.ReadOnly = false;
            examItemsInput.MaxLength = 8;
            examItemsInput.UseSystemPasswordChar = false;
            examItemsInput.PasswordChar = (char)0;
            examItemsInput.MinimumSize = new System.Drawing.Size(0, 0);
            examWeightInput.Name = "examWeightInput";
            examWeightInput.Location = new System.Drawing.Point(340, 42);
            examWeightInput.Size = new System.Drawing.Size(180, 40);
            examWeightInput.Dock = (System.Windows.Forms.DockStyle)0;
            examWeightInput.Anchor = (System.Windows.Forms.AnchorStyles)5;
            examWeightInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            examWeightInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            examWeightInput.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            examWeightInput.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            examWeightInput.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            examWeightInput.AutoSize = false;
            examWeightInput.AutoScroll = false;
            examWeightInput.Text = "";
            examWeightInput.TabIndex = 3;
            examWeightInput.TabStop = true;
            examWeightInput.Enabled = true;
            examWeightInput.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            examWeightInput.BorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            examWeightInput.BorderRadius = 7;
            examWeightInput.BorderSize = 2;
            examWeightInput.FillColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            examWeightInput.FocusBorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            examWeightInput.PlaceholderText = "Weight % (Summer only)";
            examWeightInput.Multiline = false;
            examWeightInput.ReadOnly = true;
            examWeightInput.MaxLength = 6;
            examWeightInput.UseSystemPasswordChar = false;
            examWeightInput.PasswordChar = (char)0;
            examWeightInput.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl37.Name = "designerControl37";
            designerControl37.Location = new System.Drawing.Point(536, 42);
            designerControl37.Size = new System.Drawing.Size(170, 38);
            designerControl37.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl37.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl37.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl37.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl37.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl37.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl37.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl37.AutoSize = false;
            designerControl37.Text = "Save Exam Details";
            designerControl37.TabIndex = 4;
            designerControl37.TabStop = true;
            designerControl37.Enabled = true;
            designerControl37.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl37.BorderRadius = 7;
            designerControl37.BorderSize = 0;
            designerControl37.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl37.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl37.AutoEllipsis = false;
            designerControl37.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl37.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl38.Name = "designerControl38";
            designerControl38.Location = new System.Drawing.Point(0, 0);
            designerControl38.Size = new System.Drawing.Size(200, 100);
            designerControl38.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl38.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl38.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl38.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            designerControl38.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl38.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl38.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl38.AutoSize = false;
            designerControl38.AutoScroll = false;
            designerControl38.Text = "📊 Performance";
            designerControl38.TabIndex = 4;
            designerControl38.TabStop = false;
            designerControl38.Enabled = true;
            designerControl38.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl38.MinimumSize = new System.Drawing.Size(0, 0);
            performanceGrid.Name = "performanceGrid";
            performanceGrid.Location = new System.Drawing.Point(12, 66);
            performanceGrid.Size = new System.Drawing.Size(176, 22);
            performanceGrid.Dock = (System.Windows.Forms.DockStyle)5;
            performanceGrid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            performanceGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            performanceGrid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            performanceGrid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            performanceGrid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            performanceGrid.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            performanceGrid.AutoSize = false;
            performanceGrid.Text = "";
            performanceGrid.TabIndex = 0;
            performanceGrid.TabStop = true;
            performanceGrid.Enabled = true;
            performanceGrid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            performanceGrid.ReadOnly = true;
            performanceGrid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            performanceGrid.AllowUserToAddRows = false;
            performanceGrid.AllowUserToDeleteRows = false;
            performanceGrid.AllowUserToResizeRows = false;
            performanceGrid.MultiSelect = true;
            performanceGrid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            performanceGrid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)16;
            performanceGrid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            performanceGrid.GridColor = System.Drawing.Color.FromArgb(255, 40, 40, 60);
            performanceGrid.EnableHeadersVisualStyles = false;
            performanceGrid.RowHeadersVisible = false;
            performanceGrid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            performanceGrid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            performanceGrid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            performanceGrid.ColumnHeadersHeight = 23;
            performanceGrid.MinimumSize = new System.Drawing.Size(0, 0);
            performanceGrid.RowTemplate.Height = 36;
            performanceGridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            performanceGridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            performanceGridColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 0, 120, 215);
            performanceGridColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            performanceGridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            performanceGridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            performanceGridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            performanceGridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)1;
            performanceGrid.ColumnHeadersDefaultCellStyle = performanceGridColumnHeadersDefaultCellStyle;
            performanceGridAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 28, 40, 72);
            performanceGridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            performanceGridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            performanceGridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            performanceGrid.AlternatingRowsDefaultCellStyle = performanceGridAlternatingRowsDefaultCellStyle;
            performanceGridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            performanceGridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            performanceGridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            performanceGridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            performanceGridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            performanceGridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            performanceGridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            performanceGridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            performanceGrid.DefaultCellStyle = performanceGridDefaultCellStyle;
            designerControl40.Name = "designerControl40";
            designerControl40.Location = new System.Drawing.Point(12, 12);
            designerControl40.Size = new System.Drawing.Size(176, 54);
            designerControl40.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl40.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl40.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl40.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            designerControl40.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl40.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl40.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl40.AutoSize = false;
            designerControl40.AutoScroll = false;
            designerControl40.Text = "";
            designerControl40.TabIndex = 1;
            designerControl40.TabStop = false;
            designerControl40.Enabled = true;
            designerControl40.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl40.BorderColor = System.Drawing.Color.FromArgb(255, 128, 128, 128);
            designerControl40.BorderRadius = 20;
            designerControl40.BorderSize = 0;
            designerControl40.FlowDirection = (System.Windows.Forms.FlowDirection)0;
            designerControl40.WrapContents = true;
            designerControl40.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl41.Name = "designerControl41";
            designerControl41.Location = new System.Drawing.Point(7, 11);
            designerControl41.Size = new System.Drawing.Size(110, 38);
            designerControl41.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl41.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl41.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl41.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl41.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl41.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl41.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl41.AutoSize = false;
            designerControl41.Text = "Refresh";
            designerControl41.TabIndex = 0;
            designerControl41.TabStop = true;
            designerControl41.Enabled = true;
            designerControl41.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl41.BorderRadius = 7;
            designerControl41.BorderSize = 0;
            designerControl41.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl41.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl41.AutoEllipsis = false;
            designerControl41.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl41.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl42.Name = "designerControl42";
            designerControl42.Location = new System.Drawing.Point(0, 0);
            designerControl42.Size = new System.Drawing.Size(1184, 88);
            designerControl42.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl42.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl42.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl42.Padding = new System.Windows.Forms.Padding(20, 12, 20, 8);
            designerControl42.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl42.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl42.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl42.AutoSize = false;
            designerControl42.AutoScroll = false;
            designerControl42.Text = "";
            designerControl42.TabIndex = 1;
            designerControl42.TabStop = false;
            designerControl42.Enabled = true;
            designerControl42.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl42.BorderColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl42.BorderWidth = 0;
            designerControl42.CornerRadius = 1;
            designerControl42.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl43.Name = "designerControl43";
            designerControl43.Location = new System.Drawing.Point(120, 12);
            designerControl43.Size = new System.Drawing.Size(1044, 68);
            designerControl43.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl43.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl43.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl43.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            designerControl43.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl43.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl43.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl43.AutoSize = false;
            designerControl43.AutoScroll = false;
            designerControl43.Text = "";
            designerControl43.TabIndex = 0;
            designerControl43.TabStop = false;
            designerControl43.Enabled = true;
            designerControl43.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl43.BorderColor = System.Drawing.Color.FromArgb(255, 123, 104, 238);
            designerControl43.BorderWidth = 0;
            designerControl43.CornerRadius = 1;
            designerControl43.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl44.Name = "designerControl44";
            designerControl44.Location = new System.Drawing.Point(18, 25);
            designerControl44.Size = new System.Drawing.Size(1026, 38);
            designerControl44.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl44.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl44.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl44.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl44.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl44.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl44.Font = new System.Drawing.Font("Segoe UI", 18F, (System.Drawing.FontStyle)1);
            designerControl44.AutoSize = false;
            designerControl44.Text = "Course title — Course name";
            designerControl44.TabIndex = 0;
            designerControl44.TabStop = false;
            designerControl44.Enabled = true;
            designerControl44.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl44.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl44.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl44.AutoEllipsis = true;
            designerControl44.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl45.Name = "designerControl45";
            designerControl45.Location = new System.Drawing.Point(18, 0);
            designerControl45.Size = new System.Drawing.Size(1026, 25);
            designerControl45.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl45.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl45.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl45.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl45.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl45.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl45.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl45.AutoSize = false;
            designerControl45.Text = "Instructor: Instructor name";
            designerControl45.TabIndex = 1;
            designerControl45.TabStop = false;
            designerControl45.Enabled = true;
            designerControl45.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl45.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl45.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl45.AutoEllipsis = false;
            designerControl45.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl46.Name = "designerControl46";
            designerControl46.Location = new System.Drawing.Point(20, 12);
            designerControl46.Size = new System.Drawing.Size(100, 68);
            designerControl46.Dock = (System.Windows.Forms.DockStyle)3;
            designerControl46.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl46.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl46.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl46.BackColor = System.Drawing.Color.FromArgb(255, 55, 62, 86);
            designerControl46.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl46.Font = new System.Drawing.Font("Segoe UI", 9.5F, (System.Drawing.FontStyle)1);
            designerControl46.AutoSize = false;
            designerControl46.Text = "← Back";
            designerControl46.TabIndex = 1;
            designerControl46.TabStop = true;
            designerControl46.Enabled = true;
            designerControl46.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl46.BorderRadius = 7;
            designerControl46.BorderSize = 0;
            designerControl46.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl46.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl46.AutoEllipsis = false;
            designerControl46.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl46.MinimumSize = new System.Drawing.Size(0, 0);
            this.Controls.Add(designerControl1);
            designerControl1.TabPages.Add(designerControl2);
            designerControl2.Controls.Add(studentsGrid);
            designerControl1.TabPages.Add(designerControl4);
            designerControl4.Controls.Add(attendanceGrid);
            designerControl4.Controls.Add(designerControl6);
            designerControl6.Controls.Add(attendanceDate);
            designerControl6.Controls.Add(designerControl8);
            designerControl6.Controls.Add(designerControl9);
            designerControl6.Controls.Add(attendanceMessage);
            designerControl1.TabPages.Add(designerControl11);
            designerControl11.Controls.Add(designerControl12);
            designerControl12.Panel1.Controls.Add(quizGrid);
            designerControl12.Panel2.Controls.Add(quizScoreGrid);
            designerControl12.Panel2.Controls.Add(designerControl15);
            designerControl15.Controls.Add(designerControl16);
            designerControl15.Controls.Add(designerControl17);
            designerControl11.Controls.Add(quizMessage);
            designerControl11.Controls.Add(designerControl19);
            designerControl19.Controls.Add(quizTitleInput);
            designerControl19.Controls.Add(quizTotalInput);
            designerControl19.Controls.Add(quizDate);
            designerControl19.Controls.Add(designerControl23);
            designerControl1.TabPages.Add(designerControl24);
            designerControl24.Controls.Add(designerControl25);
            designerControl25.Panel1.Controls.Add(examGrid);
            designerControl25.Panel2.Controls.Add(examScoreGrid);
            designerControl25.Panel2.Controls.Add(designerControl28);
            designerControl28.Controls.Add(designerControl29);
            designerControl28.Controls.Add(designerControl30);
            designerControl24.Controls.Add(examMessage);
            designerControl24.Controls.Add(designerControl32);
            designerControl32.Controls.Add(designerControl33);
            designerControl32.Controls.Add(examDate);
            designerControl32.Controls.Add(examItemsInput);
            designerControl32.Controls.Add(examWeightInput);
            designerControl32.Controls.Add(designerControl37);
            designerControl1.TabPages.Add(designerControl38);
            designerControl38.Controls.Add(performanceGrid);
            designerControl38.Controls.Add(designerControl40);
            designerControl40.Controls.Add(designerControl41);
            this.Controls.Add(designerControl42);
            designerControl42.Controls.Add(designerControl43);
            designerControl43.Controls.Add(designerControl44);
            designerControl43.Controls.Add(designerControl45);
            designerControl42.Controls.Add(designerControl46);
            this.Load += this_Load;
            designerControl46.Click += designerControl46_Click;
            designerControl8.Click += designerControl8_Click;
            designerControl9.Click += designerControl9_Click;
            designerControl16.Click += designerControl16_Click;
            designerControl17.Click += designerControl17_Click;
            designerControl23.Click += designerControl23_Click;
            designerControl37.Click += designerControl37_Click;
            designerControl29.Click += designerControl29_Click;
            designerControl30.Click += designerControl30_Click;
            designerControl41.Click += designerControl41_Click;
            quizGrid.SelectionChanged += quizGrid_SelectionChanged;
            examGrid.SelectionChanged += examGrid_SelectionChanged;
            examScoreGrid.CellEndEdit += examScoreGrid_CellEndEdit;
            attendanceGrid.CellFormatting += AttendanceCellFormatting;
            designerControl43.ResumeLayout(false);
            designerControl43.PerformLayout();
            designerControl42.ResumeLayout(false);
            designerControl42.PerformLayout();
            designerControl40.ResumeLayout(false);
            designerControl40.PerformLayout();
            designerControl38.ResumeLayout(false);
            designerControl38.PerformLayout();
            designerControl32.ResumeLayout(false);
            designerControl32.PerformLayout();
            designerControl28.ResumeLayout(false);
            designerControl28.PerformLayout();
            designerControl25.ResumeLayout(false);
            designerControl25.PerformLayout();
            designerControl24.ResumeLayout(false);
            designerControl24.PerformLayout();
            designerControl19.ResumeLayout(false);
            designerControl19.PerformLayout();
            designerControl15.ResumeLayout(false);
            designerControl15.PerformLayout();
            designerControl12.ResumeLayout(false);
            designerControl12.PerformLayout();
            designerControl11.ResumeLayout(false);
            designerControl11.PerformLayout();
            designerControl6.ResumeLayout(false);
            designerControl6.PerformLayout();
            designerControl4.ResumeLayout(false);
            designerControl4.PerformLayout();
            designerControl2.ResumeLayout(false);
            designerControl2.PerformLayout();
            designerControl1.ResumeLayout(false);
            designerControl1.PerformLayout();
            designerControl12.Panel1.ResumeLayout(false);
            designerControl12.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)designerControl12).EndInit();
            designerControl25.Panel1.ResumeLayout(false);
            designerControl25.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)designerControl25).EndInit();
            ResumeLayout(false);
    }
    #endregion

    private void this_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode || courseId <= 0) return;
        gradingPeriod = LoadCourseGradingPeriod();
        designerControl33.Text = "Grading period: " + gradingPeriod;
        examWeightInput.ReadOnly = !gradingPeriod.Equals("Summer", StringComparison.OrdinalIgnoreCase);
        LoadStudents();
        LoadAttendanceRows();
        LoadAssessments(false);
        LoadExamRows();
        LoadPerformance();
        InstructorTheme.Apply(this);
    }

    private void designerControl46_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void designerControl8_Click(object? sender, EventArgs e)
    {
        LoadAttendanceRows();
    }

    private void designerControl9_Click(object? sender, EventArgs e)
    {
        SaveAttendance();
    }

    private void designerControl16_Click(object? sender, EventArgs e)
    {
        LoadScoreRows(false);
    }

    private void designerControl17_Click(object? sender, EventArgs e)
    {
        SaveScores(false);
    }

    private void designerControl23_Click(object? sender, EventArgs e)
    {
        CreateAssessment(false);
    }

    private void designerControl37_Click(object? sender, EventArgs e)
    {
        SaveExamDetails();
    }

    private void designerControl29_Click(object? sender, EventArgs e)
    {
        LoadExamScoreRows();
    }

    private void designerControl30_Click(object? sender, EventArgs e)
    {
        SaveExamScores();
    }

    private void designerControl41_Click(object? sender, EventArgs e)
    {
        LoadPerformance();
    }

    private void quizGrid_SelectionChanged(object? sender, EventArgs e)
    {
        if (!(System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode)) SelectAssessment(false);
    }

    private void examGrid_SelectionChanged(object? sender, EventArgs e)
    {
        if (!loadingExamGrid && !(System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode)) SelectExam();
    }

    private void examScoreGrid_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
    {
        RecalculateExamScoreRow(e.RowIndex);
    }

    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private static readonly Color GreenColor = Color.FromArgb(0, 170, 0);
    private readonly int courseId;
    private readonly string courseTitle = "";
    private readonly string courseName = "";
    private readonly string instructorName = "";
    private readonly string instructorEmployeeId = "";
    private readonly RoundedTextBox examTitleInput = new();
    private readonly RoundedTextBox examTotalInput = new();
    private int? selectedQuizId;
    private int? selectedExamId;
    private double selectedQuizTotal;
    private int selectedExamTotalItems;
    private decimal selectedExamWeight;
    private double selectedExamTotal;
    private string gradingPeriod = "";
    private bool loadingExamGrid;

    public InstructorCourses()
    {
        this.InitializeComponent();
        foreach (DataGridView grid in CourseGrids())
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = grid.ColumnHeadersDefaultCellStyle.BackColor;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = grid.ColumnHeadersDefaultCellStyle.ForeColor;
            grid.DataBindingComplete += CourseGrid_DataBindingComplete;
        }
        Shown += CourseGrids_Shown;
    }

    private DataGridView[] CourseGrids() => new[]
    {
        studentsGrid, attendanceGrid, quizGrid, quizScoreGrid,
        examGrid, examScoreGrid, performanceGrid
    };

    private static void ClearInitialSelection(DataGridView grid)
    {
        grid.CurrentCell = null;
        grid.ClearSelection();
    }

    private void CourseGrid_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
    {
        if (e.ListChangedType == System.ComponentModel.ListChangedType.Reset && sender is DataGridView grid)
            ClearInitialSelection(grid);
    }

    private void CourseGrids_Shown(object? sender, EventArgs e)
    {
        foreach (DataGridView grid in CourseGrids()) ClearInitialSelection(grid);
        designerControl46.Focus();
    }

    public InstructorCourses(int courseId, string courseTitle, string courseName, string instructorName, string instructorEmployeeId) : this()
    {
        this.courseId = courseId;
        this.courseTitle = courseTitle;
        this.courseName = courseName;
        this.instructorName = instructorName;
        this.instructorEmployeeId = instructorEmployeeId;
        Text = "S.M.A.R.T. — " + courseTitle;
        designerControl44.Text = courseTitle + " — " + courseName;
        designerControl45.Text = "Instructor: " + instructorName;
        WindowState = FormWindowState.Maximized;
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
            ClearInitialSelection(attendanceGrid);
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
            using var transaction = connection.BeginTransaction();
            using var command = new SqlCommand($"INSERT INTO dbo.{table} (CourseId, Title, TotalScore, Date) VALUES (@CourseId, @Title, @TotalScore, @Date)", connection, transaction);
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@Title", SqlDbType.NVarChar, 100).Value = title;
            command.Parameters.Add("@TotalScore", SqlDbType.Float).Value = total;
            command.Parameters.Add("@Date", SqlDbType.Date).Value = dateInput.Value.Date;
            command.ExecuteNonQuery();
            if (!exam)
            {
                string rawEventTitle = courseTitle + " — " + title;
                string eventTitle = rawEventTitle.Length <= 200 ? rawEventTitle : rawEventTitle[..200];
                using var eventCommand = new SqlCommand(@"INSERT INTO dbo.Events
                        (Title, EventDate, EventType, CourseId, InstructorEmployeeID, IsAutoGenerated)
                    VALUES (@Title, @Date, N'Quiz', @CourseId, @EmployeeID, 1)", connection, transaction);
                eventCommand.Parameters.Add("@Title", SqlDbType.NVarChar, 200).Value = eventTitle;
                eventCommand.Parameters.Add("@Date", SqlDbType.Date).Value = dateInput.Value.Date;
                eventCommand.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
                eventCommand.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 50).Value = instructorEmployeeId;
                eventCommand.ExecuteNonQuery();
            }
            transaction.Commit();
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
            ClearInitialSelection(grid);
            if (exam) selectedExamId = null;
            else selectedQuizId = null;
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
            ClearInitialSelection(examGrid);
            examItemsInput.Text = "";
            examWeightInput.Text = "";
            examScoreGrid.DataSource = null;
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
            using var transaction = connection.BeginTransaction();
            using var command = new SqlCommand(@"IF EXISTS (SELECT 1 FROM dbo.ExamScores WHERE ExamId = @ExamId AND Score > @TotalItems)
                    THROW 51003, 'Total Items cannot be lower than a score already entered.', 1;
                UPDATE dbo.Exams SET TotalItems = @TotalItems, TotalScore = @TotalItems,
                    WeightPercent = @Weight, Date = @Date
                WHERE ExamId = @ExamId AND CourseId = @CourseId AND GradingPeriod = @Period;", connection, transaction);
            command.Parameters.Add("@ExamId", SqlDbType.Int).Value = selectedExamId.Value;
            command.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@Period", SqlDbType.NVarChar, 30).Value = gradingPeriod;
            command.Parameters.Add("@TotalItems", SqlDbType.Int).Value = totalItems;
            command.Parameters.Add("@Weight", SqlDbType.Decimal).Value = weight;
            command.Parameters["@Weight"].Precision = 5;
            command.Parameters["@Weight"].Scale = 2;
            command.Parameters.Add("@Date", SqlDbType.Date).Value = examDate.Checked ? examDate.Value.Date : DBNull.Value;
            command.ExecuteNonQuery();
            string examTitle = Convert.ToString(examGrid.CurrentRow?.Cells["Title"].Value) ?? "Exam";
            string rawEventTitle = courseTitle + " — " + examTitle;
            string eventTitle = rawEventTitle.Length <= 200 ? rawEventTitle : rawEventTitle[..200];
            using var eventCommand = new SqlCommand(@"IF @HasDate = 1
                BEGIN
                    IF EXISTS (SELECT 1 FROM dbo.Events WHERE CourseId = @CourseId
                        AND InstructorEmployeeID = @EmployeeID AND EventType = N'Exam'
                        AND Title = @Title AND IsAutoGenerated = 1)
                        UPDATE dbo.Events SET EventDate = @Date WHERE CourseId = @CourseId
                            AND InstructorEmployeeID = @EmployeeID AND EventType = N'Exam'
                            AND Title = @Title AND IsAutoGenerated = 1;
                    ELSE
                        INSERT INTO dbo.Events (Title, EventDate, EventType, CourseId,
                            InstructorEmployeeID, IsAutoGenerated)
                        VALUES (@Title, @Date, N'Exam', @CourseId, @EmployeeID, 1);
                END
                ELSE
                    DELETE FROM dbo.Events WHERE CourseId = @CourseId
                        AND InstructorEmployeeID = @EmployeeID AND EventType = N'Exam'
                        AND Title = @Title AND IsAutoGenerated = 1;", connection, transaction);
            eventCommand.Parameters.Add("@HasDate", SqlDbType.Bit).Value = examDate.Checked;
            eventCommand.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseId;
            eventCommand.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 50).Value = instructorEmployeeId;
            eventCommand.Parameters.Add("@Title", SqlDbType.NVarChar, 200).Value = eventTitle;
            eventCommand.Parameters.Add("@Date", SqlDbType.Date).Value = examDate.Checked ? examDate.Value.Date : DBNull.Value;
            eventCommand.ExecuteNonQuery();
            transaction.Commit();
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
            ClearInitialSelection(examScoreGrid);
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
            ClearInitialSelection(examScoreGrid);
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
}
