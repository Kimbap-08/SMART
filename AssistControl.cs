using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SMART
{

public partial class AssistControl : UserControl
{
    #region Windows Form Designer generated code
    private System.Windows.Forms.TableLayoutPanel designerControl1 = null!;
    private System.Windows.Forms.Label designerControl2 = null!;
    private SMART.CustomPanel designerControl3 = null!;
    private System.Windows.Forms.TableLayoutPanel designerControl4 = null!;
    private System.Windows.Forms.Label designerControl5 = null!;
    private System.Windows.Forms.Label designerControl6 = null!;
    private SMART.RoundedTextBox subjectInput = null!;
    private System.Windows.Forms.Label designerControl8 = null!;
    private System.Windows.Forms.Panel designerControl9 = null!;
    private System.Windows.Forms.RichTextBox messageInput = null!;
    private System.Windows.Forms.FlowLayoutPanel designerControl11 = null!;
    private SMART.CustomButton designerControl12 = null!;
    private System.Windows.Forms.Label sendStatus = null!;
    private System.Windows.Forms.Label designerControl14 = null!;
    private System.Windows.Forms.Panel designerControl15 = null!;
    private System.Windows.Forms.DataGridView sentGrid = null!;

    private void InitializeComponent()
    {
            designerControl1 = new System.Windows.Forms.TableLayoutPanel();
            designerControl2 = new System.Windows.Forms.Label();
            designerControl3 = new SMART.CustomPanel();
            designerControl4 = new System.Windows.Forms.TableLayoutPanel();
            designerControl5 = new System.Windows.Forms.Label();
            designerControl6 = new System.Windows.Forms.Label();
            subjectInput = new SMART.RoundedTextBox();
            designerControl8 = new System.Windows.Forms.Label();
            designerControl9 = new System.Windows.Forms.Panel();
            messageInput = new System.Windows.Forms.RichTextBox();
            designerControl11 = new System.Windows.Forms.FlowLayoutPanel();
            designerControl12 = new SMART.CustomButton();
            sendStatus = new System.Windows.Forms.Label();
            designerControl14 = new System.Windows.Forms.Label();
            designerControl15 = new System.Windows.Forms.Panel();
            sentGrid = new System.Windows.Forms.DataGridView();
            var sentGridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var sentGridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var sentGridDefaultCellStyle = new DataGridViewCellStyle();
            designerControl1.SuspendLayout();
            designerControl3.SuspendLayout();
            designerControl4.SuspendLayout();
            designerControl9.SuspendLayout();
            designerControl11.SuspendLayout();
            designerControl15.SuspendLayout();
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
            designerControl1.RowStyles.Add(new RowStyle((SizeType)1, 42F));
            designerControl1.RowStyles.Add(new RowStyle((SizeType)1, 285F));
            designerControl1.RowStyles.Add(new RowStyle((SizeType)1, 38F));
            designerControl1.RowStyles.Add(new RowStyle((SizeType)2, 100F));
            designerControl2.Name = "designerControl2";
            designerControl2.Location = new System.Drawing.Point(7, 4);
            designerControl2.Size = new System.Drawing.Size(1186, 42);
            designerControl2.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl2.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl2.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl2.Font = new System.Drawing.Font("Segoe UI", 19F, (System.Drawing.FontStyle)1);
            designerControl2.AutoSize = false;
            designerControl2.Text = "🆘 Assist — Send a message to the Administrator";
            designerControl2.TabIndex = 0;
            designerControl2.TabStop = false;
            designerControl2.Enabled = true;
            designerControl2.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl2.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl2.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl2.AutoEllipsis = false;
            designerControl2.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl3.Name = "designerControl3";
            designerControl3.Location = new System.Drawing.Point(7, 49);
            designerControl3.Size = new System.Drawing.Size(1186, 279);
            designerControl3.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl3.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl3.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            designerControl3.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl3.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl3.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl3.AutoSize = false;
            designerControl3.AutoScroll = false;
            designerControl3.Text = "";
            designerControl3.TabIndex = 1;
            designerControl3.TabStop = false;
            designerControl3.Enabled = true;
            designerControl3.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl3.BorderColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl3.BorderWidth = 0;
            designerControl3.CornerRadius = 8;
            designerControl3.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl4.Name = "designerControl4";
            designerControl4.Location = new System.Drawing.Point(14, 14);
            designerControl4.Size = new System.Drawing.Size(1158, 251);
            designerControl4.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl4.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl4.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl4.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl4.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl4.AutoSize = false;
            designerControl4.AutoScroll = false;
            designerControl4.Text = "";
            designerControl4.TabIndex = 0;
            designerControl4.TabStop = false;
            designerControl4.Enabled = true;
            designerControl4.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl4.ColumnCount = 1;
            designerControl4.RowCount = 5;
            designerControl4.CellBorderStyle = (System.Windows.Forms.TableLayoutPanelCellBorderStyle)0;
            designerControl4.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl4.RowStyles.Add(new RowStyle((SizeType)1, 24F));
            designerControl4.RowStyles.Add(new RowStyle((SizeType)1, 20F));
            designerControl4.RowStyles.Add(new RowStyle((SizeType)1, 38F));
            designerControl4.RowStyles.Add(new RowStyle((SizeType)1, 20F));
            designerControl4.RowStyles.Add(new RowStyle((SizeType)2, 100F));
            designerControl5.Name = "designerControl5";
            designerControl5.Location = new System.Drawing.Point(3, 0);
            designerControl5.Size = new System.Drawing.Size(1152, 24);
            designerControl5.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl5.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl5.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl5.ForeColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl5.Font = new System.Drawing.Font("Segoe UI", 11F, (System.Drawing.FontStyle)1);
            designerControl5.AutoSize = false;
            designerControl5.Text = "+ Compose New Message";
            designerControl5.TabIndex = 0;
            designerControl5.TabStop = false;
            designerControl5.Enabled = true;
            designerControl5.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl5.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl5.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl5.AutoEllipsis = false;
            designerControl5.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl6.Name = "designerControl6";
            designerControl6.Location = new System.Drawing.Point(3, 24);
            designerControl6.Size = new System.Drawing.Size(1152, 20);
            designerControl6.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl6.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl6.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl6.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl6.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl6.AutoSize = false;
            designerControl6.Text = "Subject";
            designerControl6.TabIndex = 1;
            designerControl6.TabStop = false;
            designerControl6.Enabled = true;
            designerControl6.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl6.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl6.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl6.AutoEllipsis = false;
            designerControl6.MinimumSize = new System.Drawing.Size(0, 0);
            subjectInput.Name = "subjectInput";
            subjectInput.Location = new System.Drawing.Point(3, 47);
            subjectInput.Size = new System.Drawing.Size(1152, 32);
            subjectInput.Dock = (System.Windows.Forms.DockStyle)5;
            subjectInput.Anchor = (System.Windows.Forms.AnchorStyles)5;
            subjectInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            subjectInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            subjectInput.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            subjectInput.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            subjectInput.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            subjectInput.AutoSize = false;
            subjectInput.AutoScroll = false;
            subjectInput.Text = "";
            subjectInput.TabIndex = 2;
            subjectInput.TabStop = true;
            subjectInput.Enabled = true;
            subjectInput.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            subjectInput.BorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            subjectInput.BorderRadius = 7;
            subjectInput.BorderSize = 2;
            subjectInput.FillColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            subjectInput.FocusBorderColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            subjectInput.PlaceholderText = "e.g. Did not receive announcement";
            subjectInput.Multiline = false;
            subjectInput.ReadOnly = false;
            subjectInput.MaxLength = 32767;
            subjectInput.UseSystemPasswordChar = false;
            subjectInput.PasswordChar = (char)0;
            subjectInput.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl8.Name = "designerControl8";
            designerControl8.Location = new System.Drawing.Point(3, 82);
            designerControl8.Size = new System.Drawing.Size(1152, 20);
            designerControl8.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl8.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl8.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl8.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl8.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl8.AutoSize = false;
            designerControl8.Text = "Message";
            designerControl8.TabIndex = 3;
            designerControl8.TabStop = false;
            designerControl8.Enabled = true;
            designerControl8.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl8.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl8.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl8.AutoEllipsis = false;
            designerControl8.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl9.Name = "designerControl9";
            designerControl9.Location = new System.Drawing.Point(3, 105);
            designerControl9.Size = new System.Drawing.Size(1152, 143);
            designerControl9.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl9.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl9.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl9.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl9.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl9.AutoSize = false;
            designerControl9.AutoScroll = false;
            designerControl9.Text = "";
            designerControl9.TabIndex = 4;
            designerControl9.TabStop = false;
            designerControl9.Enabled = true;
            designerControl9.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl9.MinimumSize = new System.Drawing.Size(0, 0);
            messageInput.Name = "messageInput";
            messageInput.Location = new System.Drawing.Point(0, 0);
            messageInput.Size = new System.Drawing.Size(1152, 101);
            messageInput.Dock = (System.Windows.Forms.DockStyle)5;
            messageInput.Anchor = (System.Windows.Forms.AnchorStyles)5;
            messageInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            messageInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            messageInput.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            messageInput.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            messageInput.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            messageInput.AutoSize = false;
            messageInput.Text = "";
            messageInput.TabIndex = 0;
            messageInput.TabStop = true;
            messageInput.Enabled = true;
            messageInput.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            messageInput.Multiline = true;
            messageInput.ReadOnly = false;
            messageInput.MaxLength = 2147483647;
            messageInput.ScrollBars = (System.Windows.Forms.RichTextBoxScrollBars)2;
            messageInput.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl11.Name = "designerControl11";
            designerControl11.Location = new System.Drawing.Point(0, 101);
            designerControl11.Size = new System.Drawing.Size(1152, 42);
            designerControl11.Dock = (System.Windows.Forms.DockStyle)2;
            designerControl11.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl11.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl11.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl11.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl11.AutoSize = false;
            designerControl11.AutoScroll = false;
            designerControl11.Text = "";
            designerControl11.TabIndex = 1;
            designerControl11.TabStop = false;
            designerControl11.Enabled = true;
            designerControl11.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl11.FlowDirection = (System.Windows.Forms.FlowDirection)0;
            designerControl11.WrapContents = false;
            designerControl11.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl12.Name = "designerControl12";
            designerControl12.Location = new System.Drawing.Point(3, 3);
            designerControl12.Size = new System.Drawing.Size(170, 36);
            designerControl12.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl12.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl12.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            designerControl12.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl12.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            designerControl12.AutoSize = false;
            designerControl12.Text = "📤 SEND MESSAGE";
            designerControl12.TabIndex = 0;
            designerControl12.TabStop = true;
            designerControl12.Enabled = true;
            designerControl12.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl12.BorderRadius = 6;
            designerControl12.BorderSize = 0;
            designerControl12.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            designerControl12.TextAlign = (System.Drawing.ContentAlignment)32;
            designerControl12.AutoEllipsis = false;
            designerControl12.DialogResult = (System.Windows.Forms.DialogResult)0;
            designerControl12.MinimumSize = new System.Drawing.Size(0, 0);
            sendStatus.Name = "sendStatus";
            sendStatus.Location = new System.Drawing.Point(179, 0);
            sendStatus.Size = new System.Drawing.Size(8, 28);
            sendStatus.Dock = (System.Windows.Forms.DockStyle)0;
            sendStatus.Anchor = (System.Windows.Forms.AnchorStyles)5;
            sendStatus.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            sendStatus.Padding = new System.Windows.Forms.Padding(8, 10, 0, 0);
            sendStatus.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            sendStatus.ForeColor = System.Drawing.Color.FromArgb(255, 50, 205, 50);
            sendStatus.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            sendStatus.AutoSize = true;
            sendStatus.Text = "";
            sendStatus.TabIndex = 1;
            sendStatus.TabStop = false;
            sendStatus.Enabled = true;
            sendStatus.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            sendStatus.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            sendStatus.TextAlign = (System.Drawing.ContentAlignment)1;
            sendStatus.AutoEllipsis = false;
            sendStatus.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl14.Name = "designerControl14";
            designerControl14.Location = new System.Drawing.Point(7, 331);
            designerControl14.Size = new System.Drawing.Size(1186, 38);
            designerControl14.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl14.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl14.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl14.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl14.Font = new System.Drawing.Font("Segoe UI", 14F, (System.Drawing.FontStyle)1);
            designerControl14.AutoSize = false;
            designerControl14.Text = "My Sent Messages";
            designerControl14.TabIndex = 2;
            designerControl14.TabStop = false;
            designerControl14.Enabled = true;
            designerControl14.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl14.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl14.TextAlign = (System.Drawing.ContentAlignment)16;
            designerControl14.AutoEllipsis = false;
            designerControl14.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl15.Name = "designerControl15";
            designerControl15.Location = new System.Drawing.Point(7, 372);
            designerControl15.Size = new System.Drawing.Size(1186, 421);
            designerControl15.Dock = (System.Windows.Forms.DockStyle)5;
            designerControl15.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl15.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            designerControl15.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl15.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl15.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl15.AutoSize = false;
            designerControl15.AutoScroll = false;
            designerControl15.Text = "";
            designerControl15.TabIndex = 3;
            designerControl15.TabStop = false;
            designerControl15.Enabled = true;
            designerControl15.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl15.MinimumSize = new System.Drawing.Size(0, 0);
            sentGrid.Name = "sentGrid";
            sentGrid.Location = new System.Drawing.Point(0, 4);
            sentGrid.Size = new System.Drawing.Size(1186, 417);
            sentGrid.Dock = (System.Windows.Forms.DockStyle)5;
            sentGrid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            sentGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            sentGrid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            sentGrid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            sentGrid.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            sentGrid.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            sentGrid.AutoSize = false;
            sentGrid.Text = "";
            sentGrid.TabIndex = 0;
            sentGrid.TabStop = true;
            sentGrid.Enabled = true;
            sentGrid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            sentGrid.ReadOnly = true;
            sentGrid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            sentGrid.AllowUserToAddRows = false;
            sentGrid.AllowUserToDeleteRows = false;
            sentGrid.AllowUserToResizeRows = true;
            sentGrid.MultiSelect = false;
            sentGrid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            sentGrid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)1;
            sentGrid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            sentGrid.GridColor = System.Drawing.Color.FromArgb(255, 40, 52, 85);
            sentGrid.EnableHeadersVisualStyles = false;
            sentGrid.RowHeadersVisible = false;
            sentGrid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            sentGrid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            sentGrid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            sentGrid.ColumnHeadersHeight = 23;
            sentGrid.MinimumSize = new System.Drawing.Size(0, 0);
            sentGrid.RowTemplate.Height = 25;
            sentGridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 15, 23, 42);
            sentGridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            sentGridColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 0, 120, 215);
            sentGridColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            sentGridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            sentGridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            sentGridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            sentGridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)1;
            sentGrid.ColumnHeadersDefaultCellStyle = sentGridColumnHeadersDefaultCellStyle;
            sentGridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            sentGridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            sentGridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            sentGrid.AlternatingRowsDefaultCellStyle = sentGridAlternatingRowsDefaultCellStyle;
            sentGridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            sentGridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            sentGridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            sentGridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            sentGridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            sentGridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            sentGridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            sentGridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            sentGrid.DefaultCellStyle = sentGridDefaultCellStyle;
            this.Controls.Add(designerControl1);
            designerControl1.Controls.Add(designerControl2, 0, 0);
            designerControl1.Controls.Add(designerControl3, 0, 1);
            designerControl3.Controls.Add(designerControl4);
            designerControl4.Controls.Add(designerControl5, 0, 0);
            designerControl4.Controls.Add(designerControl6, 0, 1);
            designerControl4.Controls.Add(subjectInput, 0, 2);
            designerControl4.Controls.Add(designerControl8, 0, 3);
            designerControl4.Controls.Add(designerControl9, 0, 4);
            designerControl9.Controls.Add(messageInput);
            designerControl9.Controls.Add(designerControl11);
            designerControl11.Controls.Add(designerControl12);
            designerControl11.Controls.Add(sendStatus);
            designerControl1.Controls.Add(designerControl14, 0, 2);
            designerControl1.Controls.Add(designerControl15, 0, 3);
            designerControl15.Controls.Add(sentGrid);
            this.Load += this_Load;
            designerControl12.Click += designerControl12_Click;
            sentGrid.CellFormatting += sentGrid_CellFormatting;
            designerControl15.ResumeLayout(false);
            designerControl15.PerformLayout();
            designerControl11.ResumeLayout(false);
            designerControl11.PerformLayout();
            designerControl9.ResumeLayout(false);
            designerControl9.PerformLayout();
            designerControl4.ResumeLayout(false);
            designerControl4.PerformLayout();
            designerControl3.ResumeLayout(false);
            designerControl3.PerformLayout();
            designerControl1.ResumeLayout(false);
            designerControl1.PerformLayout();
            ResumeLayout(false);
    }
    #endregion

    private void this_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode || string.IsNullOrEmpty(employeeId)) return;
        LoadSentMessages();
    }

    private void designerControl12_Click(object? sender, EventArgs e)
    {
        SendMessage();
    }

    private void sentGrid_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0 || sentGrid.Columns[e.ColumnIndex].Name != "Status") return;
        string status = Convert.ToString(e.Value) ?? "";
        e.CellStyle.ForeColor = status.Contains("Resolved", StringComparison.Ordinal) ? Color.LimeGreen
            : status.Contains("Seen", StringComparison.Ordinal) ? Color.FromArgb(255, 170, 0) : TextGray;
    }

    private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
    private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private static readonly Color TextGray = Color.FromArgb(150, 150, 170);
    private readonly string employeeId = "";
    private readonly string instructorName = "";

    public AssistControl()
    {
        this.InitializeComponent();
    }

    public AssistControl(string employeeId, string instructorName) : this()
    {
        this.employeeId = employeeId;
        this.instructorName = instructorName;
    }

    private void LoadSentMessages()
    {
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"SELECT MessageId, Subject, SentAt,
                    CASE WHEN IsResolved = 1 THEN N'✅ Resolved'
                         WHEN IsRead = 1 THEN N'👁 Seen' ELSE N'⏳ Pending' END AS Status,
                    AdminReply, IsRead, IsResolved
                FROM dbo.AssistMessages WHERE InstructorEmployeeID = @empId
                ORDER BY SentAt DESC", connection);
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            sentGrid.DataSource = table;
            if (sentGrid.Columns.Contains("MessageId")) sentGrid.Columns["MessageId"].Visible = false;
            if (sentGrid.Columns.Contains("IsRead")) sentGrid.Columns["IsRead"].Visible = false;
            if (sentGrid.Columns.Contains("IsResolved")) sentGrid.Columns["IsResolved"].Visible = false;
            if (sentGrid.Columns.Contains("Subject")) sentGrid.Columns["Subject"].Width = 220;
            if (sentGrid.Columns.Contains("SentAt")) sentGrid.Columns["SentAt"].Width = 150;
            if (sentGrid.Columns.Contains("Status")) sentGrid.Columns["Status"].Width = 110;
            if (sentGrid.Columns.Contains("AdminReply"))
            {
                sentGrid.Columns["AdminReply"].HeaderText = "Admin Reply";
                sentGrid.Columns["AdminReply"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            sendStatus.Text = "";
        }
        catch (SqlException ex) { sendStatus.Text = "Could not load messages: " + ex.Message; sendStatus.ForeColor = AccentColor; }
    }

    private void SendMessage()
    {
        string subject = subjectInput.Text.Trim();
        string body = messageInput.Text.Trim();
        if (subject.Length == 0 || subject.Length > 200)
        {
            SetStatus("Enter a subject up to 200 characters.", true);
            return;
        }
        if (body.Length == 0)
        {
            SetStatus("Enter a message before sending.", true);
            return;
        }
        try
        {
            using var connection = OpenConnection();
            using var command = new SqlCommand(@"INSERT INTO dbo.AssistMessages
                    (InstructorEmployeeID, InstructorName, Subject, Message)
                VALUES (@empId, @name, @subject, @msg)", connection);
            command.Parameters.Add("@empId", SqlDbType.NVarChar, 50).Value = employeeId;
            command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = instructorName.Length > 100 ? instructorName[..100] : instructorName;
            command.Parameters.Add("@subject", SqlDbType.NVarChar, 200).Value = subject;
            command.Parameters.Add("@msg", SqlDbType.NVarChar, -1).Value = body;
            command.ExecuteNonQuery();
            subjectInput.Text = "";
            messageInput.Clear();
            SetStatus("Message sent to the administrator.", false);
            LoadSentMessages();
            SetStatus("Message sent to the administrator.", false);
        }
        catch (SqlException ex) { SetStatus("Could not send message: " + ex.Message, true); }
    }

    private void SetStatus(string text, bool error)
    {
        sendStatus.Text = text;
        sendStatus.ForeColor = error ? AccentColor : Color.LimeGreen;
    }

    private SqlConnection OpenConnection()
    {
        var connection = new SqlConnection(DatabaseConnection.ConnectionString);
        try { DatabaseConnection.Open(connection); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private static void ConfigureInput(RoundedTextBox input, string placeholder)
    {
        input.FillColor = BgColor;
        input.BorderColor = AccentColor;
        input.FocusBorderColor = AccentColor;
        input.BorderRadius = 7;
        input.Font = new Font("Segoe UI", 10F);
        input.ForeColor = Color.White;
        input.PlaceholderText = placeholder;
    }

    private static Label MakeLabel(string text) => new()
    {
        Text = text, Dock = DockStyle.Fill, ForeColor = TextGray,
        Font = new Font("Segoe UI", 8F), TextAlign = ContentAlignment.MiddleLeft
    };

    private static CustomButton MakeButton(string text, Color color, int width, int height) => new()
    {
        Text = text, BackColor = color, ForeColor = Color.White, Size = new Size(width, height),
        BorderRadius = 6, BorderSize = 0, Cursor = Cursors.Hand, Font = new Font("Segoe UI", 9F, FontStyle.Bold)
    };

    private static void StyleGrid(DataGridView grid)
    {
        grid.Dock = DockStyle.Fill;
        grid.ReadOnly = true;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.MultiSelect = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        grid.BackgroundColor = CardColor;
        grid.BorderStyle = BorderStyle.None;
        grid.GridColor = Color.FromArgb(40, 52, 85);
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        grid.DefaultCellStyle.BackColor = CardColor;
        grid.DefaultCellStyle.ForeColor = Color.White;
        grid.DefaultCellStyle.SelectionBackColor = AccentColor;
        grid.DefaultCellStyle.SelectionForeColor = Color.White;
        grid.RowHeadersVisible = false;
        grid.CellFormatting += (_, e) =>
        {
            if (e.RowIndex < 0 || grid.Columns[e.ColumnIndex].Name != "Status") return;
            string status = Convert.ToString(e.Value) ?? "";
            e.CellStyle.ForeColor = status.Contains("Resolved", StringComparison.Ordinal) ? Color.LimeGreen
                : status.Contains("Seen", StringComparison.Ordinal) ? Color.FromArgb(255, 170, 0) : TextGray;
        };
    }
}
}
