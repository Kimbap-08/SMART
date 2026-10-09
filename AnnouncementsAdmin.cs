using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SMART
{

public partial class AnnouncementsAdmin : System.Windows.Forms.UserControl
{

    #region Windows Form Designer generated code
        private System.ComponentModel.IContainer? components;
        private System.Windows.Forms.Panel announcementsBody = null!;
        private System.Windows.Forms.Panel pnlHeaderAnnouncementsAdmin = null!;
        private System.Windows.Forms.Label heading = null!;
        private System.Windows.Forms.Label subtitle = null!;
        private CustomPanel card = null!;
        private System.Windows.Forms.Label titleLabel = null!;
        private RoundedTextBox txtTitle = null!;
        private System.Windows.Forms.Label priorityLabel = null!;
        private System.Windows.Forms.ComboBox cboPriority = null!;
        private ComboBox cboAudience = null!;
        private Label audienceLabel = null!;
        private DataGridViewTextBoxColumn colAudience = null!;
        private System.Windows.Forms.Label messageLabel = null!;
        private RoundedTextBox rtbMessage = null!;
        private CustomButton btnPost = null!;
        private CustomButton btnUpdate = null!;
        private CustomButton btnDelete = null!;
        private CustomButton btnCancel = null!;
        private CustomButton btnToggleActive = null!;
        private System.Windows.Forms.Label lblMsg = null!;
        private System.Windows.Forms.Label lblTotal = null!;
        private System.Windows.Forms.DataGridView grid = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnnouncementId = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostedAt = null!;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            components = new System.ComponentModel.Container();
            colAnnouncementId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            colAudience = new DataGridViewTextBoxColumn();
            colPostedAt = new DataGridViewTextBoxColumn();
            colActive = new DataGridViewCheckBoxColumn();
            colMessage = new DataGridViewTextBoxColumn();
            announcementsBody = new Panel();
            grid = new DataGridView();
            lblTotal = new Label();
            card = new CustomPanel();
            titleLabel = new Label();
            txtTitle = new RoundedTextBox();
            priorityLabel = new Label();
            cboPriority = new ComboBox();
            cboAudience = new ComboBox();
            audienceLabel = new Label();
            messageLabel = new Label();
            rtbMessage = new RoundedTextBox();
            btnPost = new CustomButton();
            btnUpdate = new CustomButton();
            btnDelete = new CustomButton();
            btnCancel = new CustomButton();
            btnToggleActive = new CustomButton();
            lblMsg = new Label();
            pnlHeaderAnnouncementsAdmin = new Panel();
            subtitle = new Label();
            heading = new Label();
            announcementsBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            card.SuspendLayout();
            pnlHeaderAnnouncementsAdmin.SuspendLayout();
            SuspendLayout();
            //
            // announcementsBody
            //
            announcementsBody.BackColor = Color.Transparent;
            announcementsBody.Controls.Add(grid);
            announcementsBody.Controls.Add(lblTotal);
            announcementsBody.Controls.Add(card);
            announcementsBody.Dock = DockStyle.Fill;
            announcementsBody.Location = new Point(0, 106);
            announcementsBody.Name = "announcementsBody";
            announcementsBody.Padding = new Padding(12, 0, 12, 15);
            announcementsBody.Size = new Size(1200, 614);
            announcementsBody.TabIndex = 0;
            //
            // grid
            //
            colAnnouncementId.Name = "AnnouncementId";
            colAnnouncementId.DataPropertyName = "AnnouncementId";
            colAnnouncementId.HeaderText = "ID";
            colAnnouncementId.ReadOnly = true;
            colAnnouncementId.Visible = false;
            colTitle.Name = "Title";
            colTitle.DataPropertyName = "Title";
            colTitle.HeaderText = "Title";
            colTitle.ReadOnly = true;
            colPriority.Name = "Priority";
            colPriority.DataPropertyName = "Priority";
            colPriority.HeaderText = "Priority";
            colPriority.ReadOnly = true;
            colAudience.Name = "Audience";
            colAudience.DataPropertyName = "Audience";
            colAudience.HeaderText = "Audience";
            colAudience.ReadOnly = true;
            colPostedAt.Name = "Posted At";
            colPostedAt.DataPropertyName = "Posted At";
            colPostedAt.HeaderText = "Posted At";
            colPostedAt.ReadOnly = true;
            colActive.Name = "Active";
            colActive.DataPropertyName = "Active";
            colActive.HeaderText = "Active";
            colActive.ReadOnly = true;
            colMessage.Name = "Message";
            colMessage.DataPropertyName = "Message";
            colMessage.HeaderText = "Message";
            colMessage.ReadOnly = true;
            grid.Columns.AddRange(new DataGridViewColumn[] { colAnnouncementId, colTitle, colPriority, colAudience, colPostedAt, colActive, colMessage });
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 40, 72);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.FromArgb(22, 33, 62);
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grid.ColumnHeadersHeight = 38;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 33, 62);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift Light", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle = dataGridViewCellStyle3;
            grid.Dock = DockStyle.Fill;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = Color.FromArgb(40, 52, 85);
            grid.Location = new Point(12, 284);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 36;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(1176, 315);
            grid.TabIndex = 0;
            grid.CellClick += Grid_CellClick;
            grid.CellFormatting += Grid_CellFormatting;
            grid.Paint += Grid_Paint;
            //
            // lblTotal
            //
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Dock = DockStyle.Top;
            lblTotal.Font = new Font("Segoe UI", 10F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(12, 250);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(1176, 34);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: 0 announcements";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            //
            // card
            //
            card.BackColor = Color.FromArgb(178, 22, 33, 62);
            card.BorderColor = Color.FromArgb(22, 33, 62);
            card.BorderWidth = 0;
            card.Controls.Add(titleLabel);
            card.Controls.Add(txtTitle);
            card.Controls.Add(priorityLabel);
            card.Controls.Add(cboPriority);
            card.Controls.Add(audienceLabel);
            card.Controls.Add(cboAudience);
            card.Controls.Add(messageLabel);
            card.Controls.Add(rtbMessage);
            card.Controls.Add(btnPost);
            card.Controls.Add(btnUpdate);
            card.Controls.Add(btnDelete);
            card.Controls.Add(btnCancel);
            card.Controls.Add(btnToggleActive);
            card.Controls.Add(lblMsg);
            card.CornerRadius = 8;
            card.Dock = DockStyle.Top;
            card.Location = new Point(12, 0);
            card.Name = "card";
            card.Padding = new Padding(18);
            card.Size = new Size(1176, 250);
            card.TabIndex = 2;
            //
            // titleLabel
            //
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 9F);
            titleLabel.ForeColor = Color.FromArgb(150, 150, 170);
            titleLabel.Location = new Point(18, 14);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(30, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            //
            // txtTitle
            //
            txtTitle.BackColor = Color.Transparent;
            txtTitle.BorderColor = Color.FromArgb(233, 69, 96);
            txtTitle.BorderRadius = 5;
            txtTitle.FillColor = Color.FromArgb(26, 26, 46);
            txtTitle.FocusBorderColor = Color.FromArgb(233, 69, 96);
            txtTitle.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(18, 34);
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(2);
            txtTitle.PlaceholderText = "Announcement title...";
            txtTitle.Size = new Size(550, 40);
            txtTitle.TabIndex = 1;
            //
            // priorityLabel
            //
            priorityLabel.AutoSize = true;
            priorityLabel.BackColor = Color.Transparent;
            priorityLabel.Font = new Font("Segoe UI", 9F);
            priorityLabel.ForeColor = Color.FromArgb(150, 150, 170);
            priorityLabel.Location = new Point(590, 14);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(45, 15);
            priorityLabel.TabIndex = 2;
            priorityLabel.Text = "Priority";
            //
            // cboPriority
            //
            cboPriority.BackColor = Color.FromArgb(22, 33, 62);
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriority.DrawMode = DrawMode.OwnerDrawFixed;
            cboPriority.FlatStyle = FlatStyle.Flat;
            cboPriority.ItemHeight = 24;
            cboPriority.DrawItem += Dropdown_DrawItem;
            cboPriority.Font = new Font("Bahnschrift Light", 10F);
            cboPriority.ForeColor = Color.White;
            cboPriority.Items.AddRange(new object[] { "Normal", "Urgent" });
            cboPriority.Location = new Point(590, 34);
            cboPriority.Name = "cboPriority";
            cboPriority.Size = new Size(140, 25);
            cboPriority.TabIndex = 3;
            audienceLabel.Name = "audienceLabel";
            audienceLabel.Text = "Audience";
            audienceLabel.BackColor = Color.Transparent;
            audienceLabel.ForeColor = Color.FromArgb(150, 150, 170);
            audienceLabel.Font = new Font("Segoe UI", 9F);
            audienceLabel.Location = new Point(750, 14);
            audienceLabel.AutoSize = true;
            cboAudience.Name = "cboAudience";
            cboAudience.Location = new Point(750, 34);
            cboAudience.Size = new Size(320, 25);
            cboAudience.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAudience.DrawMode = DrawMode.OwnerDrawFixed;
            cboAudience.FlatStyle = FlatStyle.Flat;
            cboAudience.ItemHeight = 24;
            cboAudience.DrawItem += Dropdown_DrawItem;
            cboAudience.BackColor = Color.FromArgb(22, 33, 62);
            cboAudience.ForeColor = Color.White;
            cboAudience.Font = new Font("Bahnschrift Light", 10F);
            cboAudience.Items.AddRange(new object[] { "All Instructors", "BS in Computer Engineering", "BS in Civil Engineering" });
            //
            // messageLabel
            //
            messageLabel.AutoSize = true;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 9F);
            messageLabel.ForeColor = Color.FromArgb(150, 150, 170);
            messageLabel.Location = new Point(18, 76);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(53, 15);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message";
            //
            // rtbMessage
            //
            rtbMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbMessage.BackColor = Color.Transparent;
            rtbMessage.BorderColor = Color.FromArgb(233, 69, 96);
            rtbMessage.BorderRadius = 5;
            rtbMessage.FillColor = Color.FromArgb(26, 26, 46);
            rtbMessage.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rtbMessage.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbMessage.ForeColor = Color.White;
            rtbMessage.Location = new Point(18, 96);
            rtbMessage.Multiline = true;
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Padding = new Padding(2);
            rtbMessage.Size = new Size(1140, 80);
            rtbMessage.TabIndex = 5;
            //
            // btnPost
            //
            btnPost.BackColor = Color.FromArgb(233, 69, 96);
            btnPost.BorderColor = Color.White;
            btnPost.BorderRadius = 5;
            btnPost.FlatStyle = FlatStyle.Flat;
            btnPost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPost.ForeColor = Color.White;
            btnPost.HoverColor = Color.Empty;
            btnPost.Location = new Point(18, 194);
            btnPost.Name = "btnPost";
            btnPost.PressedColor = Color.Empty;
            btnPost.Size = new Size(190, 36);
            btnPost.TabIndex = 6;
            btnPost.Text = "POST ANNOUNCEMENT";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += BtnPost_Click;
            //
            // btnUpdate
            //
            btnUpdate.BackColor = Color.FromArgb(0, 140, 200);
            btnUpdate.BorderColor = Color.White;
            btnUpdate.BorderRadius = 5;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.HoverColor = Color.Empty;
            btnUpdate.Location = new Point(218, 194);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.PressedColor = Color.Empty;
            btnUpdate.Size = new Size(100, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.BackColor = Color.FromArgb(233, 69, 96);
            btnDelete.BorderColor = Color.White;
            btnDelete.BorderRadius = 5;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverColor = Color.Empty;
            btnDelete.Location = new Point(328, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedColor = Color.Empty;
            btnDelete.Size = new Size(100, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.FromArgb(60, 60, 80);
            btnCancel.BorderColor = Color.White;
            btnCancel.BorderRadius = 5;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.HoverColor = Color.Empty;
            btnCancel.Location = new Point(438, 194);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedColor = Color.Empty;
            btnCancel.Size = new Size(100, 36);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            //
            // btnToggleActive
            //
            btnToggleActive.BackColor = Color.FromArgb(60, 60, 80);
            btnToggleActive.BorderColor = Color.White;
            btnToggleActive.BorderRadius = 5;
            btnToggleActive.FlatStyle = FlatStyle.Flat;
            btnToggleActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnToggleActive.ForeColor = Color.White;
            btnToggleActive.HoverColor = Color.Empty;
            btnToggleActive.Location = new Point(548, 194);
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.PressedColor = Color.Empty;
            btnToggleActive.Size = new Size(120, 36);
            btnToggleActive.TabIndex = 10;
            btnToggleActive.Text = "DEACTIVATE";
            btnToggleActive.UseVisualStyleBackColor = false;
            btnToggleActive.Click += BtnToggleActive_Click;
            //
            // lblMsg
            //
            lblMsg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMsg.BackColor = Color.Transparent;
            lblMsg.Font = new Font("Segoe UI", 9F);
            lblMsg.ForeColor = Color.FromArgb(150, 150, 170);
            lblMsg.Location = new Point(680, 199);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(478, 28);
            lblMsg.TabIndex = 11;
            lblMsg.TextAlign = ContentAlignment.MiddleLeft;
            //
            // pnlHeaderAnnouncementsAdmin
            //
            pnlHeaderAnnouncementsAdmin.BackColor = Color.Transparent;
            pnlHeaderAnnouncementsAdmin.Controls.Add(subtitle);
            pnlHeaderAnnouncementsAdmin.Controls.Add(heading);
            pnlHeaderAnnouncementsAdmin.Dock = DockStyle.Top;
            pnlHeaderAnnouncementsAdmin.Location = new Point(0, 0);
            pnlHeaderAnnouncementsAdmin.Name = "pnlHeaderAnnouncementsAdmin";
            pnlHeaderAnnouncementsAdmin.Size = new Size(1200, 106);
            pnlHeaderAnnouncementsAdmin.TabIndex = 1;
            //
            // subtitle
            //
            subtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subtitle.BackColor = Color.Transparent;
            subtitle.Font = new Font("Segoe UI", 10F);
            subtitle.ForeColor = Color.FromArgb(150, 150, 170);
            subtitle.Location = new Point(29, 76);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(1146, 26);
            subtitle.TabIndex = 0;
            subtitle.Text = "Create and manage announcements for instructors";
            subtitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // heading
            //
            heading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            heading.BackColor = Color.Transparent;
            heading.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            heading.ForeColor = Color.White;
            heading.Location = new Point(25, 22);
            heading.Name = "heading";
            heading.Size = new Size(1150, 46);
            heading.TabIndex = 1;
            heading.Text = "Announcements";
            //
            // AnnouncementsAdmin
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(announcementsBody);
            Controls.Add(pnlHeaderAnnouncementsAdmin);
            Font = new Font("Segoe UI", 9F);
            Name = "AnnouncementsAdmin";
            Size = new Size(1200, 720);
            Load += AnnouncementsAdmin_Load;
            announcementsBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            card.ResumeLayout(false);
            card.PerformLayout();
            pnlHeaderAnnouncementsAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }
    #endregion

        private void Dropdown_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (sender is not ComboBox combo) return;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color background = isSelected ? Color.FromArgb(233, 69, 96) : combo.BackColor;
            using var brush = new SolidBrush(background);
            e.Graphics.FillRectangle(brush, e.Bounds);
            object? item = e.Index >= 0 && e.Index < combo.Items.Count ? combo.Items[e.Index] : combo.SelectedItem;
            if (item != null)
            {
                string text = combo.GetItemText(item) ?? "";
                var bounds = new Rectangle(e.Bounds.X + 6, e.Bounds.Y,
                    Math.Max(0, e.Bounds.Width - 12), e.Bounds.Height);
                TextRenderer.DrawText(e.Graphics, text, e.Font ?? combo.Font, bounds,
                    combo.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter |
                    TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis);
            }
        }


    private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
    private int? editingId;
    private bool editingActive;

    public AnnouncementsAdmin()
    {
        this.InitializeComponent();
    }

    private void AnnouncementsAdmin_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode)
            return;
        ClearForm();
        LoadAnnouncements();
    }

    private void BtnPost_Click(object? sender, EventArgs e) => SaveAnnouncement(false);
    private void BtnUpdate_Click(object? sender, EventArgs e) => SaveAnnouncement(true);
    private void BtnDelete_Click(object? sender, EventArgs e) => DeleteAnnouncement();
    private void BtnCancel_Click(object? sender, EventArgs e) => ClearForm();
    private void BtnToggleActive_Click(object? sender, EventArgs e) => ToggleActive();

    private void Grid_Paint(object? sender, PaintEventArgs e)
    {
        // DataGridView does not support transparent backgrounds. Blend only its
        // unused area, leaving the headers, rows, and selection readable.
        if (BackgroundImage == null) return;
        int bottom = grid.ColumnHeadersVisible ? grid.ColumnHeadersHeight : 0;
        foreach (DataGridViewRow row in grid.Rows)
        {
            if (row.Displayed)
                bottom = Math.Max(bottom, grid.GetRowDisplayRectangle(row.Index, false).Bottom);
        }
        var emptyArea = new Rectangle(0, bottom, grid.ClientSize.Width,
            Math.Max(0, grid.ClientSize.Height - bottom));
        if (emptyArea.Height == 0) return;
        var state = e.Graphics.Save();
        try
        {
            e.Graphics.SetClip(emptyArea, System.Drawing.Drawing2D.CombineMode.Intersect);
            var origin = PointToClient(grid.PointToScreen(Point.Empty));
            e.Graphics.DrawImageUnscaled(BackgroundImage, -origin.X, -origin.Y);
            using var tint = new SolidBrush(Color.FromArgb(178, grid.BackgroundColor));
            e.Graphics.FillRectangle(tint, emptyArea);
        }
        finally { e.Graphics.Restore(state); }
    }

    private static void EnsureTable(SqlConnection connection)
    {
        using var command = new SqlCommand(@"IF OBJECT_ID(N'dbo.Announcements', N'U') IS NULL
            CREATE TABLE dbo.Announcements (
                AnnouncementId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Announcements PRIMARY KEY,
                Title NVARCHAR(200) NOT NULL,
                Message NVARCHAR(MAX) NOT NULL,
                PostedBy NVARCHAR(100) NOT NULL CONSTRAINT DF_Announcements_PostedBy DEFAULT N'System Administrator',
                PostedAt DATETIME NOT NULL CONSTRAINT DF_Announcements_PostedAt DEFAULT GETDATE(),
                IsActive BIT NOT NULL CONSTRAINT DF_Announcements_IsActive DEFAULT (1),
                Priority NVARCHAR(20) NOT NULL CONSTRAINT DF_Announcements_Priority DEFAULT N'Normal',
                TargetProgram NVARCHAR(150) NOT NULL CONSTRAINT DF_Announcements_TargetProgram DEFAULT N'All Instructors'
            );
            IF COL_LENGTH(N'dbo.Announcements', N'TargetProgram') IS NULL
                ALTER TABLE dbo.Announcements ADD TargetProgram NVARCHAR(150) NOT NULL
                    CONSTRAINT DF_Announcements_TargetProgram DEFAULT N'All Instructors' WITH VALUES;", connection);
        command.ExecuteNonQuery();
    }

    private void LoadAnnouncements()
    {
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            EnsureTable(connection);
            LoadAudiencePrograms(connection);
            using var adapter = new SqlDataAdapter(@"SELECT AnnouncementId, Title,
                CASE WHEN Priority = N'Important' THEN N'Urgent' ELSE Priority END AS Priority,
                TargetProgram AS Audience, PostedAt AS [Posted At], IsActive AS Active, Message
                FROM dbo.Announcements ORDER BY PostedAt DESC", connection);
            var table = new DataTable();
            adapter.Fill(table);
            grid.AutoGenerateColumns = false;
            grid.DataSource = table;
            lblTotal.Text = $"Total: {table.Rows.Count} announcements";
        }
        catch (SqlException ex) { ShowMessage("Could not load announcements: " + ex.Message, true); }
    }

    private void LoadAudiencePrograms(SqlConnection connection)
    {
        string? selected = cboAudience.SelectedItem?.ToString();
        cboAudience.BeginUpdate();
        try
        {
            cboAudience.Items.Clear();
            cboAudience.Items.Add("All Instructors");
            using var command = new SqlCommand(@"SELECT DISTINCT LTRIM(RTRIM(Program))
                FROM dbo.Instructors
                WHERE Program IS NOT NULL AND LTRIM(RTRIM(Program)) <> N''
                ORDER BY LTRIM(RTRIM(Program))", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string program = reader.GetString(0);
                if (!cboAudience.Items.Contains(program)) cboAudience.Items.Add(program);
            }
            cboAudience.SelectedItem = selected != null && cboAudience.Items.Contains(selected)
                ? selected : "All Instructors";
        }
        finally { cboAudience.EndUpdate(); }
    }

    private void SaveAnnouncement(bool updating)
    {
        string title = txtTitle.Text.Trim();
        string message = rtbMessage.Text.Trim();
        if (title.Length == 0) { ShowMessage("Enter an announcement title.", true); txtTitle.Focus(); return; }
        if (title.Length > 200) { ShowMessage("Title must be 200 characters or fewer.", true); txtTitle.Focus(); return; }
        if (message.Length == 0) { ShowMessage("Enter an announcement message.", true); rtbMessage.Focus(); return; }
        string targetProgram = cboAudience.SelectedItem?.ToString() ?? "All Instructors";
        if (updating && editingId == null) { ShowMessage("Select an announcement to update.", true); return; }

        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            EnsureTable(connection);
            string sql = updating
                ? @"UPDATE dbo.Announcements SET Title=@title, Message=@msg, Priority=@priority, TargetProgram=@targetProgram
                    WHERE AnnouncementId=@id"
                : @"INSERT INTO dbo.Announcements (Title, Message, Priority, TargetProgram, PostedBy)
                    VALUES (@title, @msg, @priority, @targetProgram, N'System Administrator')";
            using var command = new SqlCommand(sql, connection);
            command.Parameters.Add("@title", SqlDbType.NVarChar, 200).Value = title;
            command.Parameters.Add("@msg", SqlDbType.NVarChar, -1).Value = message;
            command.Parameters.Add("@priority", SqlDbType.NVarChar, 20).Value = cboPriority.SelectedItem?.ToString() ?? "Normal";
            command.Parameters.Add("@targetProgram", SqlDbType.NVarChar, 150).Value = targetProgram;
            if (updating) command.Parameters.Add("@id", SqlDbType.Int).Value = editingId!.Value;
            if (command.ExecuteNonQuery() == 0) { ShowMessage("Announcement not found.", true); return; }
            ShowMessage(updating ? "Announcement updated." : "Announcement posted.", false);
            ClearForm();
            LoadAnnouncements();
        }
        catch (SqlException ex) { ShowMessage("Could not save announcement: " + ex.Message, true); }
    }

    private void DeleteAnnouncement()
    {
        if (editingId == null) { ShowMessage("Select an announcement to delete.", true); return; }
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            using var command = new SqlCommand("UPDATE dbo.Announcements SET IsActive=0 WHERE AnnouncementId=@id", connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = editingId.Value;
            if (command.ExecuteNonQuery() == 0) { ShowMessage("Announcement not found.", true); return; }
            ShowMessage("Announcement archived.", false);
            ClearForm();
            LoadAnnouncements();
        }
        catch (SqlException ex) { ShowMessage("Could not delete announcement: " + ex.Message, true); }
    }

    private void Grid_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var row = grid.Rows[e.RowIndex];
        editingId = Convert.ToInt32(row.Cells["AnnouncementId"].Value);
        txtTitle.Text = Convert.ToString(row.Cells["Title"].Value) ?? "";
        rtbMessage.Text = Convert.ToString(row.Cells["Message"].Value) ?? "";
        cboPriority.SelectedItem = Convert.ToString(row.Cells["Priority"].Value) ?? "Normal";
        cboAudience.SelectedItem = Convert.ToString(row.Cells["Audience"].Value) ?? "All Instructors";
        string savedAudience = Convert.ToString(row.Cells["Audience"].Value) ?? "All Instructors";
        if (cboAudience.SelectedIndex < 0 && !string.IsNullOrWhiteSpace(savedAudience))
        {
            cboAudience.Items.Add(savedAudience);
            cboAudience.SelectedItem = savedAudience;
        }
        if (cboAudience.SelectedIndex < 0) cboAudience.SelectedIndex = 0;
        editingActive = Convert.ToBoolean(row.Cells["Active"].Value);
        btnPost.Visible = false;
        btnUpdate.Visible = true;
        btnToggleActive.Visible = true;
        btnToggleActive.Text = editingActive ? "DEACTIVATE" : "ACTIVATE";
        btnToggleActive.BackColor = editingActive ? AccentColor : Color.FromArgb(0, 140, 200);
        ShowMessage("Editing selected announcement.", false);
    }

    private void ToggleActive()
    {
        if (editingId == null) return;
        try
        {
            using var connection = new SqlConnection(DatabaseConnection.ConnectionString);
            DatabaseConnection.Open(connection);
            using var command = new SqlCommand(
                "UPDATE dbo.Announcements SET IsActive=@active WHERE AnnouncementId=@id", connection);
            command.Parameters.Add("@active", SqlDbType.Bit).Value = !editingActive;
            command.Parameters.Add("@id", SqlDbType.Int).Value = editingId.Value;
            if (command.ExecuteNonQuery() == 0) { ShowMessage("Announcement not found.", true); return; }
            ShowMessage(editingActive ? "Announcement deactivated." : "Announcement activated.", false);
            ClearForm();
            LoadAnnouncements();
        }
        catch (SqlException ex) { ShowMessage("Could not change announcement status: " + ex.Message, true); }
    }

    private void Grid_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || grid.Columns[e.ColumnIndex].Name != "Priority") return;
        string priority = Convert.ToString(e.Value) ?? "Normal";
        e.CellStyle.ForeColor = priority switch
        {
            "Urgent" => AccentColor,
            _ => Color.White
        };
        if (priority == "Urgent") e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
    }

    private void ClearForm()
    {
        editingId = null;
        txtTitle.Text = "";
        rtbMessage.Text = "";
        cboPriority.SelectedIndex = 0;
        cboAudience.SelectedIndex = 0;
        btnPost.Visible = true;
        btnUpdate.Visible = false;
        btnToggleActive.Visible = false;
        editingActive = false;
        grid.ClearSelection();
    }

    private void ShowMessage(string message, bool isError)
    {
        lblMsg.Text = message;
        lblMsg.ForeColor = isError ? AccentColor : Color.LightGreen;
    }
}
}
