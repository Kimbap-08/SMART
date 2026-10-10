using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SMART
{

public partial class InstructorNotes : UserControl
{
    private Panel pnlHeaderInstructorNotes = null!;
    #region Windows Form Designer generated code
    private System.Windows.Forms.SplitContainer designerControl1 = null!;
    private SMART.CustomPanel designerControl2 = null!;
    private System.Windows.Forms.FlowLayoutPanel notesList = null!;
    private SMART.CustomButton designerControl4 = null!;
    private SMART.CustomPanel designerControl5 = null!;
    private System.Windows.Forms.TableLayoutPanel designerControl6 = null!;
    private System.Windows.Forms.Label designerControl7 = null!;
    private SMART.RoundedTextBox titleInput = null!;
    private System.Windows.Forms.FlowLayoutPanel designerControl9 = null!;
    private System.Windows.Forms.Label designerControl10 = null!;
    private System.Windows.Forms.ComboBox colorPicker = null!;
    private System.Windows.Forms.Label designerControl12 = null!;
    private System.Windows.Forms.RichTextBox contentInput = null!;
    private System.Windows.Forms.FlowLayoutPanel designerControl14 = null!;
    private SMART.CustomButton designerControl15 = null!;
    private SMART.CustomButton deleteButton = null!;
    private System.Windows.Forms.Label saveStatus = null!;
    private System.Windows.Forms.Label designerControl18 = null!;
    private System.Windows.Forms.Label designerControl19 = null!;

    private void InitializeComponent()
    {
            pnlHeaderInstructorNotes = new Panel();
            pnlHeaderInstructorNotes.Name = "pnlHeaderInstructorNotes";
            pnlHeaderInstructorNotes.BackColor = Color.Transparent;
            pnlHeaderInstructorNotes.Dock = DockStyle.Top;
            pnlHeaderInstructorNotes.Size = new Size(1200, 106);

            designerControl1 = new System.Windows.Forms.SplitContainer();
            designerControl2 = new SMART.CustomPanel();
            notesList = new StableFlowLayoutPanel();
            designerControl4 = new SMART.CustomButton();
            designerControl5 = new SMART.CustomPanel();
            designerControl6 = new System.Windows.Forms.TableLayoutPanel();
            designerControl7 = new System.Windows.Forms.Label();
            titleInput = new SMART.RoundedTextBox();
            designerControl9 = new System.Windows.Forms.FlowLayoutPanel();
            designerControl10 = new System.Windows.Forms.Label();
            colorPicker = new System.Windows.Forms.ComboBox();
            designerControl12 = new System.Windows.Forms.Label();
            contentInput = new System.Windows.Forms.RichTextBox();
            designerControl14 = new System.Windows.Forms.FlowLayoutPanel();
            designerControl15 = new SMART.CustomButton();
            deleteButton = new SMART.CustomButton();
            saveStatus = new System.Windows.Forms.Label();
            designerControl18 = new System.Windows.Forms.Label();
            designerControl19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)designerControl1).BeginInit();
            designerControl1.Panel1.SuspendLayout();
            designerControl1.Panel2.SuspendLayout();
            designerControl1.SuspendLayout();
            designerControl2.SuspendLayout();
            notesList.SuspendLayout();
            designerControl5.SuspendLayout();
            designerControl6.SuspendLayout();
            designerControl9.SuspendLayout();
            designerControl14.SuspendLayout();
            SuspendLayout();
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(1200, 800);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            this.AutoScroll = false;
            this.TabIndex = 0;
            this.TabStop = true;
            this.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.ClientSize = new System.Drawing.Size(1200, 800);
            designerControl1.Name = "designerControl1";
            designerControl1.Location = new System.Drawing.Point(0, 70);
            designerControl1.Size = new System.Drawing.Size(1200, 730);
            designerControl1.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl1.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl1.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl1.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl1.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl1.AutoSize = false;
            designerControl1.AutoScroll = false;
            designerControl1.Text = "";
            designerControl1.TabIndex = 0;
            designerControl1.TabStop = true;
            designerControl1.Enabled = true;
            designerControl1.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl1.Orientation = (System.Windows.Forms.Orientation)1;
            designerControl1.SplitterWidth = 8;
            designerControl1.FixedPanel = (System.Windows.Forms.FixedPanel)1;
            designerControl1.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl1.SplitterDistance = 280;
            designerControl1.Panel1MinSize = 250;
            designerControl1.Panel2MinSize = 400;
            designerControl1.Panel1.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl1.Panel2.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl2.Name = "designerControl2";
            designerControl2.Location = new System.Drawing.Point(0, 0);
            designerControl2.Size = new System.Drawing.Size(280, 730);
            designerControl2.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl2.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            designerControl2.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl2.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl2.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl2.AutoSize = false;
            designerControl2.AutoScroll = false;
            designerControl2.Text = "";
            designerControl2.TabIndex = 0;
            designerControl2.TabStop = false;
            designerControl2.Enabled = true;
            designerControl2.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl2.BorderColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl2.BorderWidth = 0;
            designerControl2.CornerRadius = 8;
            designerControl2.MinimumSize = new System.Drawing.Size(0, 0);
            notesList.Name = "notesList";
            notesList.Location = new System.Drawing.Point(10, 46);
            notesList.Size = new System.Drawing.Size(260, 674);
            notesList.Dock = (System.Windows.Forms.DockStyle)5;
            notesList.Anchor = (System.Windows.Forms.AnchorStyles)5;
            notesList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            notesList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            notesList.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            notesList.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            notesList.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            notesList.AutoSize = false;
            notesList.AutoScroll = true;
            notesList.Text = "";
            notesList.TabIndex = 0;
            notesList.TabStop = false;
            notesList.Enabled = true;
            notesList.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            notesList.FlowDirection = (System.Windows.Forms.FlowDirection)1;
            notesList.WrapContents = false;
            notesList.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl4.Name = "designerControl4";
            designerControl4.Location = new System.Drawing.Point(10, 10);
            designerControl4.Size = new System.Drawing.Size(260, 36);
            designerControl4.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl4.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl4.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl4.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl4.AutoSize = false;
            designerControl4.Text = "+ New Note";
            designerControl4.TabIndex = 1;
            designerControl4.TabStop = true;
            designerControl4.Enabled = true;
            designerControl4.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl4.BorderRadius = 6;
            designerControl4.BorderSize = 0;
            designerControl4.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl4.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl4.AutoEllipsis = false;
            designerControl4.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl4.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl5.Name = "designerControl5";
            designerControl5.Location = new System.Drawing.Point(0, 0);
            designerControl5.Size = new System.Drawing.Size(912, 730);
            designerControl5.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl5.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl5.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            designerControl5.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl5.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl5.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl5.AutoSize = false;
            designerControl5.AutoScroll = false;
            designerControl5.Text = "";
            designerControl5.TabIndex = 0;
            designerControl5.TabStop = false;
            designerControl5.Enabled = true;
            designerControl5.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl5.BorderColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl5.BorderWidth = 0;
            designerControl5.CornerRadius = 1;
            designerControl5.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl6.Name = "designerControl6";
            designerControl6.Location = new System.Drawing.Point(16, 16);
            designerControl6.Size = new System.Drawing.Size(880, 698);
            designerControl6.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl6.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl6.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl6.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl6.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl6.AutoSize = false;
            designerControl6.AutoScroll = false;
            designerControl6.Text = "";
            designerControl6.TabIndex = 0;
            designerControl6.TabStop = false;
            designerControl6.Enabled = true;
            designerControl6.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl6.ColumnCount = 1;
            designerControl6.RowCount = 6;
            designerControl6.CellBorderStyle = (System.Windows.Forms.TableLayoutPanelCellBorderStyle)0;
            designerControl6.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl6.RowStyles.Add(new RowStyle((SizeType)1, 20F));
            designerControl6.RowStyles.Add(new RowStyle((SizeType)1, 42F));
            designerControl6.RowStyles.Add(new RowStyle((SizeType)1, 42F));
            designerControl6.RowStyles.Add(new RowStyle((SizeType)1, 20F));
            designerControl6.RowStyles.Add(new RowStyle((SizeType)2, 100F));
            designerControl6.RowStyles.Add(new RowStyle((SizeType)1, 48F));
            designerControl7.Name = "designerControl7";
            designerControl7.Location = new System.Drawing.Point(3, 0);
            designerControl7.Size = new System.Drawing.Size(874, 20);
            designerControl7.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl7.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl7.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl7.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl7.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl7.AutoSize = false;
            designerControl7.Text = "Title";
            designerControl7.TabIndex = 0;
            designerControl7.TabStop = false;
            designerControl7.Enabled = true;
            designerControl7.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl7.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl7.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl7.AutoEllipsis = false;
            designerControl7.MinimumSize = new System.Drawing.Size(0, 0);
            titleInput.Name = "titleInput";
            titleInput.Location = new System.Drawing.Point(3, 23);
            titleInput.Size = new System.Drawing.Size(874, 36);
            titleInput.Dock = (System.Windows.Forms.DockStyle)5;
            titleInput.Anchor = (System.Windows.Forms.AnchorStyles)5;
            titleInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            titleInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            titleInput.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            titleInput.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            titleInput.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            titleInput.AutoSize = false;
            titleInput.AutoScroll = false;
            titleInput.Text = "";
            titleInput.TabIndex = 1;
            titleInput.TabStop = true;
            titleInput.Enabled = true;
            titleInput.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            titleInput.BorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            titleInput.BorderRadius = 7;
            titleInput.BorderSize = 2;
            titleInput.FillColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            titleInput.FocusBorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            titleInput.PlaceholderText = "Note title...";
            titleInput.Multiline = false;
            titleInput.ReadOnly = false;
            titleInput.MaxLength = 32767;
            titleInput.UseSystemPasswordChar = false;
            titleInput.PasswordChar = (char)0;
            titleInput.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl9.Name = "designerControl9";
            designerControl9.Location = new System.Drawing.Point(3, 65);
            designerControl9.Size = new System.Drawing.Size(874, 36);
            designerControl9.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl9.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl9.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl9.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl9.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl9.AutoSize = false;
            designerControl9.AutoScroll = false;
            designerControl9.Text = "";
            designerControl9.TabIndex = 2;
            designerControl9.TabStop = false;
            designerControl9.Enabled = true;
            designerControl9.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl9.FlowDirection = (System.Windows.Forms.FlowDirection)0;
            designerControl9.WrapContents = false;
            designerControl9.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl10.Name = "designerControl10";
            designerControl10.Location = new System.Drawing.Point(3, 0);
            designerControl10.Size = new System.Drawing.Size(100, 25);
            designerControl10.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl10.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl10.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl10.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl10.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl10.AutoSize = false;
            designerControl10.Text = "Color";
            designerControl10.TabIndex = 0;
            designerControl10.TabStop = false;
            designerControl10.Enabled = true;
            designerControl10.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl10.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl10.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl10.AutoEllipsis = false;
            designerControl10.MinimumSize = new System.Drawing.Size(0, 0);
            colorPicker.Name = "colorPicker";
            colorPicker.Location = new System.Drawing.Point(116, 2);
            colorPicker.Size = new System.Drawing.Size(130, 23);
            colorPicker.Dock = (System.Windows.Forms.DockStyle)0;
            colorPicker.Anchor = (System.Windows.Forms.AnchorStyles)5;
            colorPicker.Margin = new System.Windows.Forms.Padding(10, 2, 0, 0);
            colorPicker.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            colorPicker.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            colorPicker.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            colorPicker.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            colorPicker.AutoSize = false;
            colorPicker.Text = "Default";
            colorPicker.TabIndex = 1;
            colorPicker.TabStop = true;
            colorPicker.Enabled = true;
            colorPicker.MaxLength = 0;
            colorPicker.DropDownStyle = (System.Windows.Forms.ComboBoxStyle)2;
            colorPicker.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            colorPicker.IntegralHeight = true;
            colorPicker.MinimumSize = new System.Drawing.Size(0, 0);
            colorPicker.Items.AddRange(new object[] { "Default", "Yellow", "Blue", "Green", "Red" });
            designerControl12.Name = "designerControl12";
            designerControl12.Location = new System.Drawing.Point(3, 104);
            designerControl12.Size = new System.Drawing.Size(874, 20);
            designerControl12.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl12.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl12.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl12.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl12.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl12.AutoSize = false;
            designerControl12.Text = "Content";
            designerControl12.TabIndex = 3;
            designerControl12.TabStop = false;
            designerControl12.Enabled = true;
            designerControl12.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl12.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl12.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl12.AutoEllipsis = false;
            designerControl12.MinimumSize = new System.Drawing.Size(0, 0);
            contentInput.Name = "contentInput";
            contentInput.Location = new System.Drawing.Point(3, 127);
            contentInput.Size = new System.Drawing.Size(874, 520);
            contentInput.Dock = (System.Windows.Forms.DockStyle)5;
            contentInput.Anchor = (System.Windows.Forms.AnchorStyles)5;
            contentInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            contentInput.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            contentInput.BackColor = System.Drawing.Color.FromArgb(255, 18, 24, 48);
            contentInput.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            contentInput.Font = new System.Drawing.Font("Segoe UI", 11F, (System.Drawing.FontStyle)0);
            contentInput.AutoSize = false;
            contentInput.Text = "";
            contentInput.TabIndex = 4;
            contentInput.TabStop = true;
            contentInput.Enabled = true;
            contentInput.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            contentInput.Multiline = true;
            contentInput.ReadOnly = false;
            contentInput.MaxLength = 2147483647;
            contentInput.ScrollBars = (System.Windows.Forms.RichTextBoxScrollBars)3;
            contentInput.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl14.Name = "designerControl14";
            designerControl14.Location = new System.Drawing.Point(3, 653);
            designerControl14.Size = new System.Drawing.Size(874, 42);
            designerControl14.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl14.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl14.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl14.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl14.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl14.AutoSize = false;
            designerControl14.AutoScroll = false;
            designerControl14.Text = "";
            designerControl14.TabIndex = 5;
            designerControl14.TabStop = false;
            designerControl14.Enabled = true;
            designerControl14.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl14.FlowDirection = (System.Windows.Forms.FlowDirection)0;
            designerControl14.WrapContents = false;
            designerControl14.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl15.Name = "designerControl15";
            designerControl15.Location = new System.Drawing.Point(3, 3);
            designerControl15.Size = new System.Drawing.Size(140, 36);
            designerControl15.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl15.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl15.BackColor = System.Drawing.Color.FromArgb(255, 0, 140, 0);
            designerControl15.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl15.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl15.AutoSize = false;
            designerControl15.Text = "💾 SAVE NOTE";
            designerControl15.TabIndex = 0;
            designerControl15.TabStop = true;
            designerControl15.Enabled = true;
            designerControl15.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl15.BorderRadius = 6;
            designerControl15.BorderSize = 0;
            designerControl15.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl15.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl15.AutoEllipsis = false;
            designerControl15.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl15.MinimumSize = new System.Drawing.Size(0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Location = new System.Drawing.Point(0, 0);
            deleteButton.Size = new System.Drawing.Size(100, 36);
            deleteButton.Dock = (System.Windows.Forms.DockStyle)0;
            deleteButton.Anchor = (System.Windows.Forms.AnchorStyles)5;
            deleteButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            deleteButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            deleteButton.BackColor = System.Drawing.Color.FromArgb(255, 80, 20, 30);
            deleteButton.ForeColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, (System.Drawing.FontStyle)0);
            deleteButton.AutoSize = false;
            deleteButton.Text = "🗑 DELETE";
            deleteButton.TabIndex = 1;
            deleteButton.TabStop = true;
            deleteButton.Enabled = true;
            deleteButton.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            deleteButton.BorderRadius = 6;
            deleteButton.BorderSize = 0;
            deleteButton.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            deleteButton.TextAlign = (System.Drawing.ContentAlignment)32;
            deleteButton.AutoEllipsis = false;
            deleteButton.DialogResult = (System.Windows.Forms.DialogResult)0;
            deleteButton.MinimumSize = new System.Drawing.Size(0, 0);
            deleteButton.Visible = false;
            saveStatus.Name = "saveStatus";
            saveStatus.Location = new System.Drawing.Point(149, 0);
            saveStatus.Size = new System.Drawing.Size(6, 27);
            saveStatus.Dock = (System.Windows.Forms.DockStyle)0;
            saveStatus.Anchor = (System.Windows.Forms.AnchorStyles)5;
            saveStatus.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            saveStatus.Padding = new System.Windows.Forms.Padding(6, 9, 0, 0);
            saveStatus.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            saveStatus.ForeColor = System.Drawing.Color.FromArgb(255, 50, 205, 50);
            saveStatus.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            saveStatus.AutoSize = true;
            saveStatus.Text = "";
            saveStatus.TabIndex = 2;
            saveStatus.TabStop = false;
            saveStatus.Enabled = true;
            saveStatus.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            saveStatus.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            saveStatus.TextAlign = (System.Drawing.ContentAlignment)1;
            saveStatus.AutoEllipsis = false;
            saveStatus.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl18.Name = "designerControl18";
            designerControl18.Location = new Point(29, 76);
            designerControl18.Size = new Size(1100, 26);
            designerControl18.Dock = DockStyle.None;
            designerControl18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            designerControl18.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl18.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl18.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl18.ForeColor = Color.White;
            designerControl18.Font = new Font("Bahnschrift Light", 10F);
            designerControl18.AutoSize = false;
            designerControl18.Text = "Personal notes — only you can see these";
            designerControl18.TabIndex = 1;
            designerControl18.TabStop = false;
            designerControl18.Enabled = true;
            designerControl18.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl18.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl18.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl18.AutoEllipsis = false;
            designerControl18.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl19.Name = "designerControl19";
            designerControl19.Location = new Point(25, 22);
            designerControl19.Size = new Size(1100, 46);
            designerControl19.Dock = DockStyle.None;
            designerControl19.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            designerControl19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl19.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl19.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl19.ForeColor = Color.White;
            designerControl19.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            designerControl19.AutoSize = false;
            designerControl19.Text = "📝 My Notes";
            designerControl19.TabIndex = 2;
            designerControl19.TabStop = false;
            designerControl19.Enabled = true;
            designerControl19.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl19.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl19.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl19.AutoEllipsis = false;
            designerControl19.MinimumSize = new System.Drawing.Size(0, 0);
            this.Controls.Add(designerControl1);
            designerControl1.Panel1.Controls.Add(designerControl2);
            designerControl2.Controls.Add(notesList);
            designerControl2.Controls.Add(designerControl4);
            designerControl1.Panel2.Controls.Add(designerControl5);
            designerControl5.Controls.Add(designerControl6);
            designerControl6.Controls.Add(designerControl7, 0, 0);
            designerControl6.Controls.Add(titleInput, 0, 1);
            designerControl6.Controls.Add(designerControl9, 0, 2);
            designerControl9.Controls.Add(designerControl10);
            designerControl9.Controls.Add(colorPicker);
            designerControl6.Controls.Add(designerControl12, 0, 3);
            designerControl6.Controls.Add(contentInput, 0, 4);
            designerControl6.Controls.Add(designerControl14, 0, 5);
            designerControl14.Controls.Add(designerControl15);
            designerControl14.Controls.Add(deleteButton);
            designerControl14.Controls.Add(saveStatus);

            pnlHeaderInstructorNotes.Controls.Add(designerControl19);
            pnlHeaderInstructorNotes.Controls.Add(designerControl18);
            Controls.Add(pnlHeaderInstructorNotes);

            this.Load += this_Load;
            designerControl4.Click += designerControl4_Click;
            designerControl15.Click += designerControl15_Click;
            deleteButton.Click += deleteButton_Click;
            designerControl14.ResumeLayout(false);
            designerControl14.PerformLayout();
            designerControl9.ResumeLayout(false);
            designerControl9.PerformLayout();
            designerControl6.ResumeLayout(false);
            designerControl6.PerformLayout();
            designerControl5.ResumeLayout(false);
            designerControl5.PerformLayout();
            notesList.ResumeLayout(false);
            notesList.PerformLayout();
            designerControl2.ResumeLayout(false);
            designerControl2.PerformLayout();
            designerControl1.ResumeLayout(false);
            designerControl1.PerformLayout();
            designerControl1.Panel1.ResumeLayout(false);
            designerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)designerControl1).EndInit();
            ResumeLayout(false);
    }
    #endregion

    private void this_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode || string.IsNullOrEmpty(employeeId)) return;
        colorPicker.SelectedIndex = 0;
        deleteButton.Visible = false;
        LoadNotes();
    }

    private void designerControl4_Click(object? sender, EventArgs e)
    {
        BeginNewNote();
    }

    private void designerControl15_Click(object? sender, EventArgs e)
    {
        SaveNote();
    }

    private void deleteButton_Click(object? sender, EventArgs e)
    {
        DeleteNote();
    }

    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private readonly string employeeId = "";
    private int? selectedNoteId;
    private bool loading;

    private sealed record Note(int Id, string Title, string Content, string Color, DateTime CreatedAt, DateTime UpdatedAt, bool IsFrozen);
    private List<Note> notes = new();

    public InstructorNotes()
    {
        this.InitializeComponent();
        deleteButton.Text = "DELETE";
        deleteButton.Visible = false;
    }

    public InstructorNotes(string employeeId) : this()
    {
        this.employeeId = employeeId;
    }

    private void LoadNotes(int? selectId = null)
    {
        try
        {
            using var connection = OpenConnection();
            using (var schema = new SqlCommand(@"IF COL_LENGTH(N'dbo.Notes', N'IsFrozen') IS NULL
                ALTER TABLE dbo.Notes ADD IsFrozen BIT NOT NULL CONSTRAINT DF_Notes_IsFrozen DEFAULT (0);", connection)) schema.ExecuteNonQuery();
            using var command = new SqlCommand(@"SELECT NoteId, Title, Content, Color, CreatedAt, UpdatedAt, IsFrozen
                FROM dbo.Notes WHERE InstructorEmployeeID = @empId ORDER BY IsFrozen, UpdatedAt DESC", connection);
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            using var reader = command.ExecuteReader();
            notes = new List<Note>();
            while (reader.Read())
                notes.Add(new Note(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetDateTime(4), reader.GetDateTime(5), reader.GetBoolean(6)));
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
            Color color = note.IsFrozen ? Color.FromArgb(75, 79, 91) : ColorForNote(note.Color);
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
                ForeColor = note.IsFrozen ? Color.FromArgb(195, 198, 205) : Color.White, Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand, Tag = note.Id
            };
            var preview = new Label
            {
                Text = note.Content.Length > 50 ? note.Content[..50] + "…" : note.Content,
                Dock = DockStyle.Top, Height = 19, AutoEllipsis = true,
                ForeColor = note.IsFrozen ? Color.FromArgb(165, 168, 175) : TextGray, Font = new Font("Segoe UI", 8F), Cursor = Cursors.Hand, Tag = note.Id
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
        bool editable = !note.IsFrozen;
        titleInput.ReadOnly = !editable;
        contentInput.ReadOnly = !editable;
        colorPicker.Enabled = editable;
        designerControl15.Enabled = editable;
        deleteButton.Visible = editable;
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
        titleInput.ReadOnly = false;
        contentInput.ReadOnly = false;
        colorPicker.Enabled = true;
        designerControl15.Enabled = true;
        colorPicker.SelectedIndex = 0;
        deleteButton.Visible = false;
        saveStatus.Text = "";
        loading = false;
        titleInput.Focus();
    }

    private void SaveNote()
    {
        if (loading) return;
        if (selectedNoteId.HasValue && notes.Any(note => note.Id == selectedNoteId.Value && note.IsFrozen))
        { saveStatus.Text = "Frozen notes cannot be changed."; return; }
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
                    WHERE NoteId=@id AND InstructorEmployeeID=@empId AND IsFrozen=0", connection)
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
            using var command = new SqlCommand("UPDATE dbo.Notes SET IsFrozen=1 WHERE NoteId=@id AND InstructorEmployeeID=@empId AND IsFrozen=0", connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = selectedNoteId.Value;
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            command.ExecuteNonQuery();
            BeginNewNote();
            LoadNotes();
        }
        catch (SqlException ex) { saveStatus.Text = "Could not freeze note: " + ex.Message; saveStatus.ForeColor = AccentColor; }
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
}
