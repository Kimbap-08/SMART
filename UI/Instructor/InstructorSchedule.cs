using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SMART
{

public partial class InstructorSchedule : UserControl
{
    #region Windows Form Designer generated code
    private System.Windows.Forms.TableLayoutPanel designerControl1 = null!;
    private System.Windows.Forms.Panel designerControl2 = null!;
    private System.Windows.Forms.Label designerControl3 = null!;
    private System.Windows.Forms.Label designerControl4 = null!;
    private System.Windows.Forms.Label designerControl5 = null!;
    private System.Windows.Forms.ComboBox termPicker = null!;
    private SMART.CustomButton designerControl7 = null!;
    private System.Windows.Forms.Panel dayHeader = null!;
    private System.Windows.Forms.Label designerControl9 = null!;
    private System.Windows.Forms.Label designerControl10 = null!;
    private System.Windows.Forms.Label designerControl11 = null!;
    private System.Windows.Forms.Label designerControl12 = null!;
    private System.Windows.Forms.Label designerControl13 = null!;
    private System.Windows.Forms.Label designerControl14 = null!;
    private System.Windows.Forms.Label designerControl15 = null!;
    private System.Windows.Forms.Panel scheduleScroll = null!;
    private System.Windows.Forms.Panel scheduleCanvas = null!;
    private System.Windows.Forms.Label designerControl18 = null!;
    private System.Windows.Forms.Label designerControl19 = null!;
    private System.Windows.Forms.Label designerControl20 = null!;
    private System.Windows.Forms.Label designerControl21 = null!;
    private System.Windows.Forms.Label designerControl22 = null!;
    private System.Windows.Forms.Label designerControl23 = null!;
    private System.Windows.Forms.Label designerControl24 = null!;
    private System.Windows.Forms.Label designerControl25 = null!;
    private System.Windows.Forms.Label designerControl26 = null!;
    private System.Windows.Forms.Label designerControl27 = null!;
    private System.Windows.Forms.Label designerControl28 = null!;
    private System.Windows.Forms.Label designerControl29 = null!;
    private System.Windows.Forms.Label designerControl30 = null!;
    private System.Windows.Forms.Label designerControl31 = null!;
    private System.Windows.Forms.Label designerControl32 = null!;
    private System.Windows.Forms.Label designerControl33 = null!;
    private System.Windows.Forms.Label designerControl34 = null!;
    private System.Windows.Forms.Label designerControl35 = null!;
    private System.Windows.Forms.Label designerControl36 = null!;
    private System.Windows.Forms.Label designerControl37 = null!;
    private System.Windows.Forms.Label designerControl38 = null!;
    private System.Windows.Forms.Label designerControl39 = null!;
    private System.Windows.Forms.Label designerControl40 = null!;
    private System.Windows.Forms.Label designerControl41 = null!;
    private System.Windows.Forms.Label designerControl42 = null!;
    private System.Windows.Forms.Label designerControl43 = null!;
    private System.Windows.Forms.Label designerControl44 = null!;
    private System.Windows.Forms.Label designerControl45 = null!;
    private System.Windows.Forms.Label designerControl46 = null!;
    private System.Windows.Forms.Label designerControl47 = null!;
    private SMART.CustomPanel designerControl48 = null!;
    private System.Windows.Forms.FlowLayoutPanel courseLegend = null!;
    private System.Windows.Forms.Label designerControl50 = null!;
    private System.Windows.Forms.Label statusLabel = null!;

    private void InitializeComponent()
    {
            designerControl1 = new System.Windows.Forms.TableLayoutPanel();
            designerControl2 = new System.Windows.Forms.Panel();
            designerControl3 = new System.Windows.Forms.Label();
            designerControl4 = new System.Windows.Forms.Label();
            designerControl5 = new System.Windows.Forms.Label();
            termPicker = new System.Windows.Forms.ComboBox();
            designerControl7 = new SMART.CustomButton();
            dayHeader = new System.Windows.Forms.Panel();
            designerControl9 = new System.Windows.Forms.Label();
            designerControl10 = new System.Windows.Forms.Label();
            designerControl11 = new System.Windows.Forms.Label();
            designerControl12 = new System.Windows.Forms.Label();
            designerControl13 = new System.Windows.Forms.Label();
            designerControl14 = new System.Windows.Forms.Label();
            designerControl15 = new System.Windows.Forms.Label();
            scheduleScroll = new StableScrollPanel();
            scheduleCanvas = new System.Windows.Forms.Panel();
            designerControl18 = new System.Windows.Forms.Label();
            designerControl19 = new System.Windows.Forms.Label();
            designerControl20 = new System.Windows.Forms.Label();
            designerControl21 = new System.Windows.Forms.Label();
            designerControl22 = new System.Windows.Forms.Label();
            designerControl23 = new System.Windows.Forms.Label();
            designerControl24 = new System.Windows.Forms.Label();
            designerControl25 = new System.Windows.Forms.Label();
            designerControl26 = new System.Windows.Forms.Label();
            designerControl27 = new System.Windows.Forms.Label();
            designerControl28 = new System.Windows.Forms.Label();
            designerControl29 = new System.Windows.Forms.Label();
            designerControl30 = new System.Windows.Forms.Label();
            designerControl31 = new System.Windows.Forms.Label();
            designerControl32 = new System.Windows.Forms.Label();
            designerControl33 = new System.Windows.Forms.Label();
            designerControl34 = new System.Windows.Forms.Label();
            designerControl35 = new System.Windows.Forms.Label();
            designerControl36 = new System.Windows.Forms.Label();
            designerControl37 = new System.Windows.Forms.Label();
            designerControl38 = new System.Windows.Forms.Label();
            designerControl39 = new System.Windows.Forms.Label();
            designerControl40 = new System.Windows.Forms.Label();
            designerControl41 = new System.Windows.Forms.Label();
            designerControl42 = new System.Windows.Forms.Label();
            designerControl43 = new System.Windows.Forms.Label();
            designerControl44 = new System.Windows.Forms.Label();
            designerControl45 = new System.Windows.Forms.Label();
            designerControl46 = new System.Windows.Forms.Label();
            designerControl47 = new System.Windows.Forms.Label();
            designerControl48 = new SMART.CustomPanel();
            courseLegend = new System.Windows.Forms.FlowLayoutPanel();
            designerControl50 = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            designerControl1.SuspendLayout();
            designerControl2.SuspendLayout();
            dayHeader.SuspendLayout();
            scheduleScroll.SuspendLayout();
            scheduleCanvas.SuspendLayout();
            designerControl48.SuspendLayout();
            courseLegend.SuspendLayout();
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
            designerControl1.Location = new System.Drawing.Point(0, 0);
            designerControl1.Size = new System.Drawing.Size(1200, 800);
            designerControl1.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl1.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            designerControl1.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl1.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl1.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl1.AutoSize = false;
            designerControl1.AutoScroll = false;
            designerControl1.Text = "";
            designerControl1.TabIndex = 0;
            designerControl1.TabStop = false;
            designerControl1.Enabled = true;
            designerControl1.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl1.ColumnCount = 1;
            designerControl1.RowCount = 4;
            designerControl1.CellBorderStyle = (System.Windows.Forms.TableLayoutPanelCellBorderStyle)0;
            designerControl1.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl1.RowStyles.Add(new RowStyle((SizeType)1, 106F));
            designerControl1.RowStyles.Add(new RowStyle((SizeType)1, 34F));
            designerControl1.RowStyles.Add(new RowStyle((SizeType)2, 62F));
            designerControl1.RowStyles.Add(new RowStyle((SizeType)2, 38F));
            designerControl2.Name = "designerControl2";
            designerControl2.Location = new System.Drawing.Point(7, 7);
            designerControl2.Size = new System.Drawing.Size(1186, 56);
            designerControl2.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl2.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl2.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl2.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl2.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl2.AutoSize = false;
            designerControl2.AutoScroll = false;
            designerControl2.Text = "";
            designerControl2.TabIndex = 0;
            designerControl2.TabStop = false;
            designerControl2.Enabled = true;
            designerControl2.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl2.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl3.Name = "designerControl3";
            designerControl3.Location = new Point(25, 22);
            designerControl3.Size = new Size(1100, 46);
            designerControl3.Dock = DockStyle.None;
            designerControl3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            designerControl3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl3.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl3.ForeColor = Color.White;
            designerControl3.Font = new Font("Gadugi", 20F, FontStyle.Bold);
            designerControl3.AutoSize = false;
            designerControl3.Text = "🗓 Class Schedule";
            designerControl3.TabIndex = 0;
            designerControl3.TabStop = false;
            designerControl3.Enabled = true;
            designerControl3.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl3.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl3.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl3.AutoEllipsis = false;
            designerControl3.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl4.Name = "designerControl4";
            designerControl4.Location = new Point(29, 76);
            designerControl4.Size = new Size(1100, 26);
            designerControl4.Dock = DockStyle.None;
            designerControl4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            designerControl4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl4.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl4.ForeColor = Color.White;
            designerControl4.Font = new Font("Bahnschrift Light", 10F);
            designerControl4.AutoSize = false;
            designerControl4.Text = "Your assigned courses this term";
            designerControl4.TabIndex = 1;
            designerControl4.TabStop = false;
            designerControl4.Enabled = true;
            designerControl4.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl4.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl4.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl4.AutoEllipsis = false;
            designerControl4.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl5.Name = "designerControl5";
            designerControl5.Location = new System.Drawing.Point(957, 14);
            designerControl5.Size = new System.Drawing.Size(48, 26);
            designerControl5.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl5.Anchor = (System.Windows.Forms.AnchorStyles)9;
            designerControl5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl5.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl5.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl5.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl5.AutoSize = false;
            designerControl5.Text = "Term:";
            designerControl5.TabIndex = 2;
            designerControl5.TabStop = false;
            designerControl5.Enabled = true;
            designerControl5.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl5.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl5.TextAlign = (System.Drawing.ContentAlignment)64;
            designerControl5.AutoEllipsis = false;
            designerControl5.MinimumSize = new System.Drawing.Size(0, 0);
            termPicker.Name = "termPicker";
            termPicker.Location = new System.Drawing.Point(1011, 14);
            termPicker.Size = new System.Drawing.Size(175, 23);
            termPicker.Dock = (System.Windows.Forms.DockStyle)0;
            termPicker.Anchor = (System.Windows.Forms.AnchorStyles)9;
            termPicker.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            termPicker.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            termPicker.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            termPicker.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            termPicker.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            termPicker.AutoSize = false;
            termPicker.Text = "";
            termPicker.TabIndex = 3;
            termPicker.TabStop = true;
            termPicker.Enabled = true;
            termPicker.MaxLength = 0;
            termPicker.DropDownStyle = (System.Windows.Forms.ComboBoxStyle)2;
            termPicker.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            termPicker.IntegralHeight = true;
            termPicker.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl7.Name = "designerControl7";
            designerControl7.Location = new System.Drawing.Point(790, 10);
            designerControl7.Size = new System.Drawing.Size(155, 34);
            designerControl7.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl7.Anchor = (System.Windows.Forms.AnchorStyles)9;
            designerControl7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl7.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl7.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl7.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl7.AutoSize = false;
            designerControl7.Text = "🖨 Print Schedule";
            designerControl7.TabIndex = 4;
            designerControl7.TabStop = true;
            designerControl7.Enabled = true;
            designerControl7.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl7.BorderRadius = 6;
            designerControl7.BorderSize = 0;
            designerControl7.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl7.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl7.AutoEllipsis = false;
            designerControl7.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl7.MinimumSize = new System.Drawing.Size(0, 0);
            dayHeader.Name = "dayHeader";
            dayHeader.Location = new System.Drawing.Point(7, 69);
            dayHeader.Size = new System.Drawing.Size(1186, 28);
            dayHeader.Dock = (System.Windows.Forms.DockStyle)5;
            dayHeader.Anchor = (System.Windows.Forms.AnchorStyles)5;
            dayHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            dayHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            dayHeader.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            dayHeader.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            dayHeader.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            dayHeader.AutoSize = false;
            dayHeader.AutoScroll = false;
            dayHeader.Text = "";
            dayHeader.TabIndex = 1;
            dayHeader.TabStop = false;
            dayHeader.Enabled = true;
            dayHeader.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            dayHeader.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl9.Name = "designerControl9";
            designerControl9.Location = new System.Drawing.Point(0, 0);
            designerControl9.Size = new System.Drawing.Size(80, 34);
            designerControl9.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl9.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl9.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            designerControl9.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl9.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl9.AutoSize = false;
            designerControl9.Text = "Time";
            designerControl9.TabIndex = 0;
            designerControl9.TabStop = false;
            designerControl9.Enabled = true;
            designerControl9.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl9.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl9.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl9.AutoEllipsis = false;
            designerControl9.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl10.Name = "designerControl10";
            designerControl10.Location = new System.Drawing.Point(80, 0);
            designerControl10.Size = new System.Drawing.Size(181, 34);
            designerControl10.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl10.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl10.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            designerControl10.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl10.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl10.AutoSize = false;
            designerControl10.Text = "Mon";
            designerControl10.TabIndex = 1;
            designerControl10.TabStop = false;
            designerControl10.Enabled = true;
            designerControl10.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl10.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl10.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl10.AutoEllipsis = false;
            designerControl10.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl11.Name = "designerControl11";
            designerControl11.Location = new System.Drawing.Point(261, 0);
            designerControl11.Size = new System.Drawing.Size(181, 34);
            designerControl11.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl11.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl11.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            designerControl11.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl11.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl11.AutoSize = false;
            designerControl11.Text = "Tue";
            designerControl11.TabIndex = 2;
            designerControl11.TabStop = false;
            designerControl11.Enabled = true;
            designerControl11.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl11.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl11.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl11.AutoEllipsis = false;
            designerControl11.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl12.Name = "designerControl12";
            designerControl12.Location = new System.Drawing.Point(442, 0);
            designerControl12.Size = new System.Drawing.Size(181, 34);
            designerControl12.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl12.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl12.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            designerControl12.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl12.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl12.AutoSize = false;
            designerControl12.Text = "Wed";
            designerControl12.TabIndex = 3;
            designerControl12.TabStop = false;
            designerControl12.Enabled = true;
            designerControl12.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl12.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl12.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl12.AutoEllipsis = false;
            designerControl12.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl13.Name = "designerControl13";
            designerControl13.Location = new System.Drawing.Point(623, 0);
            designerControl13.Size = new System.Drawing.Size(181, 34);
            designerControl13.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl13.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl13.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl13.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            designerControl13.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl13.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl13.AutoSize = false;
            designerControl13.Text = "Thu";
            designerControl13.TabIndex = 4;
            designerControl13.TabStop = false;
            designerControl13.Enabled = true;
            designerControl13.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl13.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl13.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl13.AutoEllipsis = false;
            designerControl13.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl14.Name = "designerControl14";
            designerControl14.Location = new System.Drawing.Point(804, 0);
            designerControl14.Size = new System.Drawing.Size(181, 34);
            designerControl14.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl14.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl14.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            designerControl14.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl14.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl14.AutoSize = false;
            designerControl14.Text = "Fri";
            designerControl14.TabIndex = 5;
            designerControl14.TabStop = false;
            designerControl14.Enabled = true;
            designerControl14.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl14.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl14.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl14.AutoEllipsis = false;
            designerControl14.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl15.Name = "designerControl15";
            designerControl15.Location = new System.Drawing.Point(985, 0);
            designerControl15.Size = new System.Drawing.Size(181, 34);
            designerControl15.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl15.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl15.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            designerControl15.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl15.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl15.AutoSize = false;
            designerControl15.Text = "Sat";
            designerControl15.TabIndex = 6;
            designerControl15.TabStop = false;
            designerControl15.Enabled = true;
            designerControl15.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl15.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl15.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl15.AutoEllipsis = false;
            designerControl15.MinimumSize = new System.Drawing.Size(0, 0);
            scheduleScroll.Name = "scheduleScroll";
            scheduleScroll.Location = new System.Drawing.Point(7, 103);
            scheduleScroll.Size = new System.Drawing.Size(1186, 425);
            scheduleScroll.Dock = (System.Windows.Forms.DockStyle)5;
            scheduleScroll.Anchor = (System.Windows.Forms.AnchorStyles)5;
            scheduleScroll.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            scheduleScroll.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            scheduleScroll.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            scheduleScroll.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            scheduleScroll.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            scheduleScroll.AutoSize = false;
            scheduleScroll.AutoScroll = true;
            scheduleScroll.Text = "";
            scheduleScroll.TabIndex = 2;
            scheduleScroll.TabStop = false;
            scheduleScroll.Enabled = true;
            scheduleScroll.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            scheduleScroll.MinimumSize = new System.Drawing.Size(0, 0);
            scheduleCanvas.Name = "scheduleCanvas";
            scheduleCanvas.Location = new System.Drawing.Point(0, 0);
            scheduleCanvas.Size = new System.Drawing.Size(1166, 1120);
            scheduleCanvas.Dock = (System.Windows.Forms.DockStyle)0;
            scheduleCanvas.Anchor = (System.Windows.Forms.AnchorStyles)5;
            scheduleCanvas.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            scheduleCanvas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            scheduleCanvas.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            scheduleCanvas.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            scheduleCanvas.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            scheduleCanvas.AutoSize = false;
            scheduleCanvas.AutoScroll = false;
            scheduleCanvas.Text = "";
            scheduleCanvas.TabIndex = 0;
            scheduleCanvas.TabStop = false;
            scheduleCanvas.Enabled = true;
            scheduleCanvas.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            scheduleCanvas.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl18.Name = "designerControl18";
            designerControl18.Location = new System.Drawing.Point(92, 16);
            designerControl18.Size = new System.Drawing.Size(1062, 70);
            designerControl18.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl18.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl18.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl18.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl18.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            designerControl18.ForeColor = System.Drawing.Color.FromArgb(255, 170, 170, 170);
            designerControl18.Font = new System.Drawing.Font("Segoe UI", 12F, (System.Drawing.FontStyle)0);
            designerControl18.AutoSize = false;
            designerControl18.Text = "No courses assigned yet.\nContact admin to assign courses.";
            designerControl18.TabIndex = 0;
            designerControl18.TabStop = false;
            designerControl18.Enabled = true;
            designerControl18.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl18.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl18.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl18.AutoEllipsis = false;
            designerControl18.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl19.Name = "designerControl19";
            designerControl19.Location = new System.Drawing.Point(0, 0);
            designerControl19.Size = new System.Drawing.Size(76, 40);
            designerControl19.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl19.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl19.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl19.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl19.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl19.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl19.AutoSize = false;
            designerControl19.Text = "7:00 am";
            designerControl19.TabIndex = 1;
            designerControl19.TabStop = false;
            designerControl19.Enabled = true;
            designerControl19.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl19.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl19.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl19.AutoEllipsis = false;
            designerControl19.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl20.Name = "designerControl20";
            designerControl20.Location = new System.Drawing.Point(0, 40);
            designerControl20.Size = new System.Drawing.Size(76, 40);
            designerControl20.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl20.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl20.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl20.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl20.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl20.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl20.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl20.AutoSize = false;
            designerControl20.Text = "7:30 am";
            designerControl20.TabIndex = 2;
            designerControl20.TabStop = false;
            designerControl20.Enabled = true;
            designerControl20.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl20.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl20.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl20.AutoEllipsis = false;
            designerControl20.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl21.Name = "designerControl21";
            designerControl21.Location = new System.Drawing.Point(0, 80);
            designerControl21.Size = new System.Drawing.Size(76, 40);
            designerControl21.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl21.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl21.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl21.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl21.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl21.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl21.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl21.AutoSize = false;
            designerControl21.Text = "8:00 am";
            designerControl21.TabIndex = 3;
            designerControl21.TabStop = false;
            designerControl21.Enabled = true;
            designerControl21.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl21.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl21.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl21.AutoEllipsis = false;
            designerControl21.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl22.Name = "designerControl22";
            designerControl22.Location = new System.Drawing.Point(0, 120);
            designerControl22.Size = new System.Drawing.Size(76, 40);
            designerControl22.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl22.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl22.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl22.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl22.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl22.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl22.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl22.AutoSize = false;
            designerControl22.Text = "8:30 am";
            designerControl22.TabIndex = 4;
            designerControl22.TabStop = false;
            designerControl22.Enabled = true;
            designerControl22.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl22.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl22.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl22.AutoEllipsis = false;
            designerControl22.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl23.Name = "designerControl23";
            designerControl23.Location = new System.Drawing.Point(0, 160);
            designerControl23.Size = new System.Drawing.Size(76, 40);
            designerControl23.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl23.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl23.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl23.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl23.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl23.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl23.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl23.AutoSize = false;
            designerControl23.Text = "9:00 am";
            designerControl23.TabIndex = 5;
            designerControl23.TabStop = false;
            designerControl23.Enabled = true;
            designerControl23.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl23.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl23.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl23.AutoEllipsis = false;
            designerControl23.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl24.Name = "designerControl24";
            designerControl24.Location = new System.Drawing.Point(0, 200);
            designerControl24.Size = new System.Drawing.Size(76, 40);
            designerControl24.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl24.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl24.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl24.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl24.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl24.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl24.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl24.AutoSize = false;
            designerControl24.Text = "9:30 am";
            designerControl24.TabIndex = 6;
            designerControl24.TabStop = false;
            designerControl24.Enabled = true;
            designerControl24.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl24.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl24.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl24.AutoEllipsis = false;
            designerControl24.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl25.Name = "designerControl25";
            designerControl25.Location = new System.Drawing.Point(0, 240);
            designerControl25.Size = new System.Drawing.Size(76, 40);
            designerControl25.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl25.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl25.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl25.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl25.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl25.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl25.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl25.AutoSize = false;
            designerControl25.Text = "10:00 am";
            designerControl25.TabIndex = 7;
            designerControl25.TabStop = false;
            designerControl25.Enabled = true;
            designerControl25.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl25.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl25.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl25.AutoEllipsis = false;
            designerControl25.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl26.Name = "designerControl26";
            designerControl26.Location = new System.Drawing.Point(0, 280);
            designerControl26.Size = new System.Drawing.Size(76, 40);
            designerControl26.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl26.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl26.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl26.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl26.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl26.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl26.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl26.AutoSize = false;
            designerControl26.Text = "10:30 am";
            designerControl26.TabIndex = 8;
            designerControl26.TabStop = false;
            designerControl26.Enabled = true;
            designerControl26.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl26.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl26.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl26.AutoEllipsis = false;
            designerControl26.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl27.Name = "designerControl27";
            designerControl27.Location = new System.Drawing.Point(0, 320);
            designerControl27.Size = new System.Drawing.Size(76, 40);
            designerControl27.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl27.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl27.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl27.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl27.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl27.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl27.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl27.AutoSize = false;
            designerControl27.Text = "11:00 am";
            designerControl27.TabIndex = 9;
            designerControl27.TabStop = false;
            designerControl27.Enabled = true;
            designerControl27.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl27.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl27.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl27.AutoEllipsis = false;
            designerControl27.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl28.Name = "designerControl28";
            designerControl28.Location = new System.Drawing.Point(0, 360);
            designerControl28.Size = new System.Drawing.Size(76, 40);
            designerControl28.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl28.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl28.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl28.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl28.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl28.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl28.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl28.AutoSize = false;
            designerControl28.Text = "11:30 am";
            designerControl28.TabIndex = 10;
            designerControl28.TabStop = false;
            designerControl28.Enabled = true;
            designerControl28.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl28.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl28.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl28.AutoEllipsis = false;
            designerControl28.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl29.Name = "designerControl29";
            designerControl29.Location = new System.Drawing.Point(0, 400);
            designerControl29.Size = new System.Drawing.Size(76, 40);
            designerControl29.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl29.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl29.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl29.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl29.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl29.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl29.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl29.AutoSize = false;
            designerControl29.Text = "12:00 pm";
            designerControl29.TabIndex = 11;
            designerControl29.TabStop = false;
            designerControl29.Enabled = true;
            designerControl29.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl29.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl29.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl29.AutoEllipsis = false;
            designerControl29.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl30.Name = "designerControl30";
            designerControl30.Location = new System.Drawing.Point(0, 440);
            designerControl30.Size = new System.Drawing.Size(76, 40);
            designerControl30.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl30.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl30.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl30.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl30.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl30.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl30.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl30.AutoSize = false;
            designerControl30.Text = "12:30 pm";
            designerControl30.TabIndex = 12;
            designerControl30.TabStop = false;
            designerControl30.Enabled = true;
            designerControl30.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl30.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl30.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl30.AutoEllipsis = false;
            designerControl30.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl31.Name = "designerControl31";
            designerControl31.Location = new System.Drawing.Point(0, 480);
            designerControl31.Size = new System.Drawing.Size(76, 40);
            designerControl31.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl31.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl31.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl31.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl31.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl31.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl31.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl31.AutoSize = false;
            designerControl31.Text = "1:00 pm";
            designerControl31.TabIndex = 13;
            designerControl31.TabStop = false;
            designerControl31.Enabled = true;
            designerControl31.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl31.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl31.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl31.AutoEllipsis = false;
            designerControl31.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl32.Name = "designerControl32";
            designerControl32.Location = new System.Drawing.Point(0, 520);
            designerControl32.Size = new System.Drawing.Size(76, 40);
            designerControl32.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl32.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl32.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl32.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl32.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl32.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl32.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl32.AutoSize = false;
            designerControl32.Text = "1:30 pm";
            designerControl32.TabIndex = 14;
            designerControl32.TabStop = false;
            designerControl32.Enabled = true;
            designerControl32.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl32.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl32.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl32.AutoEllipsis = false;
            designerControl32.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl33.Name = "designerControl33";
            designerControl33.Location = new System.Drawing.Point(0, 560);
            designerControl33.Size = new System.Drawing.Size(76, 40);
            designerControl33.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl33.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl33.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl33.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl33.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl33.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl33.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl33.AutoSize = false;
            designerControl33.Text = "2:00 pm";
            designerControl33.TabIndex = 15;
            designerControl33.TabStop = false;
            designerControl33.Enabled = true;
            designerControl33.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl33.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl33.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl33.AutoEllipsis = false;
            designerControl33.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl34.Name = "designerControl34";
            designerControl34.Location = new System.Drawing.Point(0, 600);
            designerControl34.Size = new System.Drawing.Size(76, 40);
            designerControl34.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl34.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl34.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl34.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl34.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl34.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl34.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl34.AutoSize = false;
            designerControl34.Text = "2:30 pm";
            designerControl34.TabIndex = 16;
            designerControl34.TabStop = false;
            designerControl34.Enabled = true;
            designerControl34.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl34.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl34.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl34.AutoEllipsis = false;
            designerControl34.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl35.Name = "designerControl35";
            designerControl35.Location = new System.Drawing.Point(0, 640);
            designerControl35.Size = new System.Drawing.Size(76, 40);
            designerControl35.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl35.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl35.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl35.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl35.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl35.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl35.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl35.AutoSize = false;
            designerControl35.Text = "3:00 pm";
            designerControl35.TabIndex = 17;
            designerControl35.TabStop = false;
            designerControl35.Enabled = true;
            designerControl35.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl35.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl35.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl35.AutoEllipsis = false;
            designerControl35.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl36.Name = "designerControl36";
            designerControl36.Location = new System.Drawing.Point(0, 680);
            designerControl36.Size = new System.Drawing.Size(76, 40);
            designerControl36.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl36.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl36.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl36.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl36.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl36.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl36.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl36.AutoSize = false;
            designerControl36.Text = "3:30 pm";
            designerControl36.TabIndex = 18;
            designerControl36.TabStop = false;
            designerControl36.Enabled = true;
            designerControl36.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl36.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl36.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl36.AutoEllipsis = false;
            designerControl36.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl37.Name = "designerControl37";
            designerControl37.Location = new System.Drawing.Point(0, 720);
            designerControl37.Size = new System.Drawing.Size(76, 40);
            designerControl37.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl37.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl37.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl37.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl37.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl37.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl37.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl37.AutoSize = false;
            designerControl37.Text = "4:00 pm";
            designerControl37.TabIndex = 19;
            designerControl37.TabStop = false;
            designerControl37.Enabled = true;
            designerControl37.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl37.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl37.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl37.AutoEllipsis = false;
            designerControl37.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl38.Name = "designerControl38";
            designerControl38.Location = new System.Drawing.Point(0, 760);
            designerControl38.Size = new System.Drawing.Size(76, 40);
            designerControl38.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl38.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl38.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl38.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl38.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl38.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl38.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl38.AutoSize = false;
            designerControl38.Text = "4:30 pm";
            designerControl38.TabIndex = 20;
            designerControl38.TabStop = false;
            designerControl38.Enabled = true;
            designerControl38.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl38.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl38.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl38.AutoEllipsis = false;
            designerControl38.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl39.Name = "designerControl39";
            designerControl39.Location = new System.Drawing.Point(0, 800);
            designerControl39.Size = new System.Drawing.Size(76, 40);
            designerControl39.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl39.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl39.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl39.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl39.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl39.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl39.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl39.AutoSize = false;
            designerControl39.Text = "5:00 pm";
            designerControl39.TabIndex = 21;
            designerControl39.TabStop = false;
            designerControl39.Enabled = true;
            designerControl39.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl39.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl39.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl39.AutoEllipsis = false;
            designerControl39.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl40.Name = "designerControl40";
            designerControl40.Location = new System.Drawing.Point(0, 840);
            designerControl40.Size = new System.Drawing.Size(76, 40);
            designerControl40.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl40.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl40.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl40.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl40.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl40.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl40.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl40.AutoSize = false;
            designerControl40.Text = "5:30 pm";
            designerControl40.TabIndex = 22;
            designerControl40.TabStop = false;
            designerControl40.Enabled = true;
            designerControl40.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl40.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl40.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl40.AutoEllipsis = false;
            designerControl40.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl41.Name = "designerControl41";
            designerControl41.Location = new System.Drawing.Point(0, 880);
            designerControl41.Size = new System.Drawing.Size(76, 40);
            designerControl41.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl41.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl41.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl41.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl41.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl41.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl41.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl41.AutoSize = false;
            designerControl41.Text = "6:00 pm";
            designerControl41.TabIndex = 23;
            designerControl41.TabStop = false;
            designerControl41.Enabled = true;
            designerControl41.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl41.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl41.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl41.AutoEllipsis = false;
            designerControl41.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl42.Name = "designerControl42";
            designerControl42.Location = new System.Drawing.Point(0, 920);
            designerControl42.Size = new System.Drawing.Size(76, 40);
            designerControl42.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl42.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl42.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl42.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl42.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl42.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl42.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl42.AutoSize = false;
            designerControl42.Text = "6:30 pm";
            designerControl42.TabIndex = 24;
            designerControl42.TabStop = false;
            designerControl42.Enabled = true;
            designerControl42.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl42.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl42.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl42.AutoEllipsis = false;
            designerControl42.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl43.Name = "designerControl43";
            designerControl43.Location = new System.Drawing.Point(0, 960);
            designerControl43.Size = new System.Drawing.Size(76, 40);
            designerControl43.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl43.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl43.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl43.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl43.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl43.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl43.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl43.AutoSize = false;
            designerControl43.Text = "7:00 pm";
            designerControl43.TabIndex = 25;
            designerControl43.TabStop = false;
            designerControl43.Enabled = true;
            designerControl43.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl43.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl43.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl43.AutoEllipsis = false;
            designerControl43.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl44.Name = "designerControl44";
            designerControl44.Location = new System.Drawing.Point(0, 1000);
            designerControl44.Size = new System.Drawing.Size(76, 40);
            designerControl44.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl44.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl44.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl44.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl44.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl44.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl44.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl44.AutoSize = false;
            designerControl44.Text = "7:30 pm";
            designerControl44.TabIndex = 26;
            designerControl44.TabStop = false;
            designerControl44.Enabled = true;
            designerControl44.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl44.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl44.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl44.AutoEllipsis = false;
            designerControl44.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl45.Name = "designerControl45";
            designerControl45.Location = new System.Drawing.Point(0, 1040);
            designerControl45.Size = new System.Drawing.Size(76, 40);
            designerControl45.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl45.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl45.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl45.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl45.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl45.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl45.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl45.AutoSize = false;
            designerControl45.Text = "8:00 pm";
            designerControl45.TabIndex = 27;
            designerControl45.TabStop = false;
            designerControl45.Enabled = true;
            designerControl45.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl45.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl45.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl45.AutoEllipsis = false;
            designerControl45.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl46.Name = "designerControl46";
            designerControl46.Location = new System.Drawing.Point(0, 1080);
            designerControl46.Size = new System.Drawing.Size(76, 40);
            designerControl46.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl46.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl46.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl46.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl46.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl46.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl46.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl46.AutoSize = false;
            designerControl46.Text = "8:30 pm";
            designerControl46.TabIndex = 28;
            designerControl46.TabStop = false;
            designerControl46.Enabled = true;
            designerControl46.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl46.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl46.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl46.AutoEllipsis = false;
            designerControl46.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl47.Name = "designerControl47";
            designerControl47.Location = new System.Drawing.Point(0, 1120);
            designerControl47.Size = new System.Drawing.Size(76, 40);
            designerControl47.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl47.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl47.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl47.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl47.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl47.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl47.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl47.AutoSize = false;
            designerControl47.Text = "9:00 pm";
            designerControl47.TabIndex = 29;
            designerControl47.TabStop = false;
            designerControl47.Enabled = true;
            designerControl47.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl47.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl47.TextAlign = (System.Drawing.ContentAlignment)4;
            designerControl47.AutoEllipsis = false;
            designerControl47.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl48.Name = "designerControl48";
            designerControl48.Location = new System.Drawing.Point(7, 534);
            designerControl48.Size = new System.Drawing.Size(1186, 259);
            designerControl48.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl48.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl48.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl48.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            designerControl48.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl48.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl48.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl48.AutoSize = false;
            designerControl48.AutoScroll = false;
            designerControl48.Text = "";
            designerControl48.TabIndex = 3;
            designerControl48.TabStop = false;
            designerControl48.Enabled = true;
            designerControl48.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl48.BorderColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl48.BorderWidth = 0;
            designerControl48.CornerRadius = 1;
            designerControl48.MinimumSize = new System.Drawing.Size(0, 0);
            courseLegend.Name = "courseLegend";
            courseLegend.Location = new System.Drawing.Point(2, 32);
            courseLegend.Size = new System.Drawing.Size(1182, 203);
            courseLegend.Dock = (System.Windows.Forms.DockStyle)5;
            courseLegend.Anchor = (System.Windows.Forms.AnchorStyles)5;
            courseLegend.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            courseLegend.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            courseLegend.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            courseLegend.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            courseLegend.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            courseLegend.AutoSize = false;
            courseLegend.AutoScroll = true;
            courseLegend.Text = "";
            courseLegend.TabIndex = 0;
            courseLegend.TabStop = false;
            courseLegend.Enabled = true;
            courseLegend.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            courseLegend.FlowDirection = (System.Windows.Forms.FlowDirection)0;
            courseLegend.WrapContents = true;
            courseLegend.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl50.Name = "designerControl50";
            designerControl50.Location = new System.Drawing.Point(2, 4);
            designerControl50.Size = new System.Drawing.Size(1182, 28);
            designerControl50.Dock = (System.Windows.Forms.DockStyle)1;
            designerControl50.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl50.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl50.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl50.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl50.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl50.Font = new System.Drawing.Font("Segoe UI", 13F, (System.Drawing.FontStyle)1);
            designerControl50.AutoSize = false;
            designerControl50.Text = "Courses";
            designerControl50.TabIndex = 1;
            designerControl50.TabStop = false;
            designerControl50.Enabled = true;
            designerControl50.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl50.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl50.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl50.AutoEllipsis = false;
            designerControl50.MinimumSize = new System.Drawing.Size(0, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Location = new System.Drawing.Point(2, 235);
            statusLabel.Size = new System.Drawing.Size(1182, 22);
            statusLabel.Dock = (System.Windows.Forms.DockStyle)2;
            statusLabel.Anchor = (System.Windows.Forms.AnchorStyles)5;
            statusLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            statusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            statusLabel.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            statusLabel.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            statusLabel.AutoSize = false;
            statusLabel.Text = "";
            statusLabel.TabIndex = 2;
            statusLabel.TabStop = false;
            statusLabel.Enabled = true;
            statusLabel.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            statusLabel.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            statusLabel.TextAlign = (System.Drawing.ContentAlignment)1;
            statusLabel.AutoEllipsis = false;
            statusLabel.MinimumSize = new System.Drawing.Size(0, 0);
            this.Controls.Add(designerControl1);
            designerControl1.Controls.Add(designerControl2, 0, 0);
            designerControl2.Controls.Add(designerControl3);
            designerControl2.Controls.Add(designerControl4);
            designerControl2.Controls.Add(designerControl5);
            designerControl2.Controls.Add(termPicker);
            designerControl2.Controls.Add(designerControl7);
            designerControl1.Controls.Add(dayHeader, 0, 1);
            dayHeader.Controls.Add(designerControl9);
            dayHeader.Controls.Add(designerControl10);
            dayHeader.Controls.Add(designerControl11);
            dayHeader.Controls.Add(designerControl12);
            dayHeader.Controls.Add(designerControl13);
            dayHeader.Controls.Add(designerControl14);
            dayHeader.Controls.Add(designerControl15);
            designerControl1.Controls.Add(scheduleScroll, 0, 2);
            scheduleScroll.Controls.Add(scheduleCanvas);
            scheduleCanvas.Controls.Add(designerControl18);
            scheduleCanvas.Controls.Add(designerControl19);
            scheduleCanvas.Controls.Add(designerControl20);
            scheduleCanvas.Controls.Add(designerControl21);
            scheduleCanvas.Controls.Add(designerControl22);
            scheduleCanvas.Controls.Add(designerControl23);
            scheduleCanvas.Controls.Add(designerControl24);
            scheduleCanvas.Controls.Add(designerControl25);
            scheduleCanvas.Controls.Add(designerControl26);
            scheduleCanvas.Controls.Add(designerControl27);
            scheduleCanvas.Controls.Add(designerControl28);
            scheduleCanvas.Controls.Add(designerControl29);
            scheduleCanvas.Controls.Add(designerControl30);
            scheduleCanvas.Controls.Add(designerControl31);
            scheduleCanvas.Controls.Add(designerControl32);
            scheduleCanvas.Controls.Add(designerControl33);
            scheduleCanvas.Controls.Add(designerControl34);
            scheduleCanvas.Controls.Add(designerControl35);
            scheduleCanvas.Controls.Add(designerControl36);
            scheduleCanvas.Controls.Add(designerControl37);
            scheduleCanvas.Controls.Add(designerControl38);
            scheduleCanvas.Controls.Add(designerControl39);
            scheduleCanvas.Controls.Add(designerControl40);
            scheduleCanvas.Controls.Add(designerControl41);
            scheduleCanvas.Controls.Add(designerControl42);
            scheduleCanvas.Controls.Add(designerControl43);
            scheduleCanvas.Controls.Add(designerControl44);
            scheduleCanvas.Controls.Add(designerControl45);
            scheduleCanvas.Controls.Add(designerControl46);
            scheduleCanvas.Controls.Add(designerControl47);
            designerControl1.Controls.Add(designerControl48, 0, 3);
            designerControl48.Controls.Add(courseLegend);
            designerControl48.Controls.Add(designerControl50);
            designerControl48.Controls.Add(statusLabel);
            this.Load += this_Load;
            termPicker.SelectedIndexChanged += termPicker_SelectedIndexChanged;
            designerControl7.Click += designerControl7_Click;
            designerControl2.Resize += designerControl2_Resize;
            scheduleScroll.Resize += scheduleScroll_Resize;
            scheduleScroll.Scroll += scheduleScroll_Scroll;
            scheduleCanvas.Paint += DrawGrid;
            courseLegend.ResumeLayout(false);
            courseLegend.PerformLayout();
            designerControl48.ResumeLayout(false);
            designerControl48.PerformLayout();
            scheduleCanvas.ResumeLayout(false);
            scheduleCanvas.PerformLayout();
            scheduleScroll.ResumeLayout(false);
            scheduleScroll.PerformLayout();
            dayHeader.ResumeLayout(false);
            dayHeader.PerformLayout();
            designerControl2.ResumeLayout(false);
            designerControl2.PerformLayout();
            designerControl1.ResumeLayout(false);
            designerControl1.PerformLayout();
            ResumeLayout(false);
    }
    #endregion

    private void this_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode || string.IsNullOrEmpty(employeeId)) return;
        LoadCourses();
    }

    private void termPicker_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (!buildingCanvas && !(System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode)) RenderSchedule();
    }

    private void designerControl7_Click(object? sender, EventArgs e)
    {
        CopyScheduleToClipboard();
    }

    private void designerControl2_Resize(object? sender, EventArgs e)
    {
        termPicker.Left = Math.Max(0, designerControl2.ClientSize.Width - termPicker.Width);
        designerControl5.Left = termPicker.Left - designerControl5.Width - 6;
        designerControl7.Left = Math.Max(0, designerControl5.Left - designerControl7.Width - 12);
        designerControl7.Top = 28;
        designerControl5.Top = 30;
        termPicker.Top = 30;
        designerControl3.Width = Math.Max(160, designerControl7.Left - designerControl3.Left - 16);
    }

    private void scheduleScroll_Resize(object? sender, EventArgs e)
    {
        if (!(System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode)) ResizeCanvas();
    }

    private void scheduleScroll_Scroll(object? sender, ScrollEventArgs e)
    {
        SyncDayHeader();
    }

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

    private readonly string employeeId = "";
    private readonly ToolTip courseToolTip = new();
    private List<ScheduleCourse> allCourses = new();
    private bool buildingCanvas;
    private int dayColumnWidth = DayColumnMinWidth;

    private sealed record ScheduleCourse(int Id, string Title, string Name, string Room,
        string Day, string Time, string Term, string Program);

    private sealed record TimeRange(TimeSpan Start, TimeSpan End);

    public InstructorSchedule()
    {
        this.InitializeComponent();
        designerControl2_Resize(designerControl2, EventArgs.Empty);
    }

    public InstructorSchedule(string employeeId) : this()
    {
        this.employeeId = employeeId;
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
        string compactDays = new string(lower.Where(char.IsLetterOrDigit).ToArray());
        switch (compactDays)
        {
            case "msa":
            case "msat":
            case "monsat":
            case "mondaysaturday":
            case "msa1":
            case "msa2":
                return new List<string>(Days);
            case "mf":
            case "mfri":
            case "monfri":
            case "mondayfriday":
                return new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri" };
            case "sa":
            case "sat":
            case "saturday":
                return new List<string> { "Sat" };
        }
        if (lower.Contains("daily") || compactDays == "mtwthf")
            return new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri" };

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
        value = value.Replace('–', '-').Replace('—', '-');
        int separator = value.IndexOf(" to ", StringComparison.OrdinalIgnoreCase);
        int separatorLength = 4;
        if (separator < 0)
        {
            separator = value.IndexOf('-');
            separatorLength = 1;
        }
        if (separator < 0) return false;
        if (!TryParseTimeToken(value[..separator], out TimeSpan start) ||
            !TryParseTimeToken(value[(separator + separatorLength)..], out TimeSpan end) || end <= start)
            return false;
        range = new TimeRange(start, end);
        return true;
    }

    private static bool TryParseTimeToken(string token, out TimeSpan time)
    {
        string value = token.Trim().ToUpperInvariant().Replace(" ", "").Replace(".", "");
        // Course schedules use M for morning and A for afternoon; also accept
        // standard AM/PM and the older P/E suffixes.
        bool isPm = value.EndsWith("PM", StringComparison.Ordinal) ||
            value.EndsWith('P') || value.EndsWith('E') || value.EndsWith('A');
        bool isAm = value.EndsWith("AM", StringComparison.Ordinal) || value.EndsWith('M');
        bool hasMeridiem = isPm || isAm;
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
}
