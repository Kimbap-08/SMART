#nullable disable

namespace SMART
{
    public sealed partial class AnnouncementsAdmin
    {
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel announcementsBody;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label subtitle;
        private CustomPanel card;
        private System.Windows.Forms.Label titleLabel;
        private RoundedTextBox txtTitle;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Label messageLabel;
        private RoundedTextBox rtbMessage;
        private CustomButton btnPost;
        private CustomButton btnUpdate;
        private CustomButton btnDelete;
        private CustomButton btnCancel;
        private CustomButton btnToggleActive;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnnouncementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostedAt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle;
            System.Windows.Forms.DataGridViewCellStyle cellStyle;
            components = new System.ComponentModel.Container();
            announcementsBody = new System.Windows.Forms.Panel();
            heading = new System.Windows.Forms.Label();
            subtitle = new System.Windows.Forms.Label();
            card = new CustomPanel();
            titleLabel = new System.Windows.Forms.Label();
            txtTitle = new RoundedTextBox();
            priorityLabel = new System.Windows.Forms.Label();
            cboPriority = new System.Windows.Forms.ComboBox();
            messageLabel = new System.Windows.Forms.Label();
            rtbMessage = new RoundedTextBox();
            btnPost = new CustomButton();
            btnUpdate = new CustomButton();
            btnDelete = new CustomButton();
            btnCancel = new CustomButton();
            btnToggleActive = new CustomButton();
            lblMsg = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            grid = new System.Windows.Forms.DataGridView();
            colAnnouncementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPostedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            card.SuspendLayout();
            announcementsBody.SuspendLayout();
            SuspendLayout();
            // heading
            heading.Name = "heading";
            heading.Text = "📢 Announcements";
            heading.ForeColor = Color.White;
            heading.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            heading.Dock = DockStyle.Top;
            heading.Height = 42;
            // subtitle
            subtitle.Name = "subtitle";
            subtitle.Text = "Create and manage announcements for instructors";
            subtitle.ForeColor = Color.FromArgb(150, 150, 170);
            subtitle.Font = new Font("Segoe UI", 10F);
            subtitle.Dock = DockStyle.Top;
            subtitle.Height = 30;
            // card
            card.Name = "card";
            card.Dock = DockStyle.Top;
            card.Size = new Size(1176, 250);
            card.Padding = new Padding(18);
            card.BackColor = Color.FromArgb(22, 33, 62);
            card.BorderColor = Color.FromArgb(22, 33, 62);
            card.BorderWidth = 0;
            card.CornerRadius = 8;
            // titleLabel
            titleLabel.Name = "titleLabel";
            titleLabel.Text = "Title";
            titleLabel.ForeColor = Color.FromArgb(150, 150, 170);
            titleLabel.Font = new Font("Segoe UI", 9F);
            titleLabel.Location = new Point(18, 14);
            titleLabel.AutoSize = true;
            // txtTitle
            txtTitle.Name = "txtTitle";
            txtTitle.Location = new Point(18, 34);
            txtTitle.Size = new Size(550, 40);
            txtTitle.BackColor = Color.Transparent;
            txtTitle.BorderColor = Color.FromArgb(233, 69, 96);
            txtTitle.BorderRadius = 5;
            txtTitle.FocusBorderColor = Color.FromArgb(233, 69, 96);
            txtTitle.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.Padding = new Padding(2);
            txtTitle.PlaceholderText = "Announcement title...";
            txtTitle.ForeColor = Color.White;
            txtTitle.FillColor = Color.FromArgb(26, 26, 46);
            // priorityLabel
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Text = "Priority";
            priorityLabel.ForeColor = Color.FromArgb(150, 150, 170);
            priorityLabel.Font = new Font("Segoe UI", 9F);
            priorityLabel.Location = new Point(590, 14);
            priorityLabel.AutoSize = true;
            // cboPriority
            cboPriority.Name = "cboPriority";
            cboPriority.Location = new Point(590, 34);
            cboPriority.Size = new Size(140, 26);
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriority.BackColor = Color.FromArgb(13, 17, 38);
            cboPriority.ForeColor = Color.White;
            cboPriority.Font = new Font("Segoe UI", 10F);
            cboPriority.Items.AddRange(new object[] { "Normal", "Urgent" });
            // messageLabel
            messageLabel.Name = "messageLabel";
            messageLabel.Text = "Message";
            messageLabel.ForeColor = Color.FromArgb(150, 150, 170);
            messageLabel.Font = new Font("Segoe UI", 9F);
            messageLabel.Location = new Point(18, 76);
            messageLabel.AutoSize = true;
            // rtbMessage
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Location = new Point(18, 96);
            rtbMessage.Size = new Size(1140, 80);
            rtbMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbMessage.BackColor = Color.Transparent;
            rtbMessage.ForeColor = Color.White;
            rtbMessage.BorderColor = Color.FromArgb(233, 69, 96);
            rtbMessage.FocusBorderColor = Color.FromArgb(233, 69, 96);
            rtbMessage.FillColor = Color.FromArgb(26, 26, 46);
            rtbMessage.BorderRadius = 5;
            rtbMessage.Padding = new Padding(2);
            rtbMessage.Multiline = true;
            rtbMessage.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            // btnPost
            btnPost.Name = "btnPost";
            btnPost.Text = "POST ANNOUNCEMENT";
            btnPost.Location = new Point(18, 194);
            btnPost.Size = new Size(190, 36);
            btnPost.BackColor = Color.FromArgb(233, 69, 96);
            btnPost.ForeColor = Color.White;
            btnPost.BorderRadius = 5;
            btnPost.BorderSize = 0;
            btnPost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPost.Click += BtnPost_Click;
            // btnUpdate
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Text = "UPDATE";
            btnUpdate.Location = new Point(218, 194);
            btnUpdate.Size = new Size(100, 36);
            btnUpdate.BackColor = Color.FromArgb(0, 140, 200);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.BorderRadius = 5;
            btnUpdate.BorderSize = 0;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Click += BtnUpdate_Click;
            // btnDelete
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "DELETE";
            btnDelete.Location = new Point(328, 194);
            btnDelete.Size = new Size(100, 36);
            btnDelete.BackColor = Color.FromArgb(233, 69, 96);
            btnDelete.ForeColor = Color.White;
            btnDelete.BorderRadius = 5;
            btnDelete.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Click += BtnDelete_Click;
            // btnCancel
            btnCancel.Name = "btnCancel";
            btnCancel.Text = "CANCEL";
            btnCancel.Location = new Point(438, 194);
            btnCancel.Size = new Size(100, 36);
            btnCancel.BackColor = Color.FromArgb(60, 60, 80);
            btnCancel.ForeColor = Color.White;
            btnCancel.BorderRadius = 5;
            btnCancel.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Click += BtnCancel_Click;
            // btnToggleActive
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Text = "DEACTIVATE";
            btnToggleActive.Location = new Point(548, 194);
            btnToggleActive.Size = new Size(120, 36);
            btnToggleActive.BackColor = Color.FromArgb(60, 60, 80);
            btnToggleActive.ForeColor = Color.White;
            btnToggleActive.BorderRadius = 5;
            btnToggleActive.BorderSize = 0;
            btnToggleActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnToggleActive.Click += BtnToggleActive_Click;
            // lblMsg
            lblMsg.Name = "lblMsg";
            lblMsg.Text = "";
            lblMsg.ForeColor = Color.FromArgb(150, 150, 170);
            lblMsg.Font = new Font("Segoe UI", 9F);
            lblMsg.Location = new Point(680, 199);
            lblMsg.Size = new Size(478, 28);
            lblMsg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMsg.AutoSize = false;
            lblMsg.TextAlign = ContentAlignment.MiddleLeft;
            // lblTotal
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total: 0 announcements";
            lblTotal.ForeColor = Color.FromArgb(150, 150, 170);
            lblTotal.Font = new Font("Segoe UI", 10F);
            lblTotal.Dock = DockStyle.Top;
            lblTotal.Height = 34;
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // grid
            grid.Name = "grid";
            grid.Dock = DockStyle.Fill;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 38;
            grid.RowTemplate.Height = 36;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.FromArgb(22, 33, 62);
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Color.FromArgb(40, 52, 85);
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = false;
            grid.AutoGenerateColumns = false;
            // colAnnouncementId
            colAnnouncementId.Name = "colAnnouncementId";
            colAnnouncementId.Name = "AnnouncementId";
            colAnnouncementId.HeaderText = "ID";
            colAnnouncementId.DataPropertyName = "AnnouncementId";
            colAnnouncementId.Width = 60;
            colAnnouncementId.ReadOnly = true;
            colAnnouncementId.Visible = false;
            grid.Columns.Add(colAnnouncementId);
            // colTitle
            colTitle.Name = "colTitle";
            colTitle.Name = "Title";
            colTitle.HeaderText = "Title";
            colTitle.DataPropertyName = "Title";
            colTitle.Width = 200;
            colTitle.ReadOnly = true;
            grid.Columns.Add(colTitle);
            // colPriority
            colPriority.Name = "colPriority";
            colPriority.Name = "Priority";
            colPriority.HeaderText = "Priority";
            colPriority.DataPropertyName = "Priority";
            colPriority.Width = 100;
            colPriority.ReadOnly = true;
            grid.Columns.Add(colPriority);
            // colPostedAt
            colPostedAt.Name = "colPostedAt";
            colPostedAt.Name = "Posted At";
            colPostedAt.HeaderText = "Posted At";
            colPostedAt.DataPropertyName = "Posted At";
            colPostedAt.Width = 150;
            colPostedAt.ReadOnly = true;
            grid.Columns.Add(colPostedAt);
            // colActive
            colActive.Name = "colActive";
            colActive.Name = "Active";
            colActive.HeaderText = "Active";
            colActive.DataPropertyName = "Active";
            colActive.Width = 80;
            colActive.ReadOnly = true;
            grid.Columns.Add(colActive);
            // colMessage
            colMessage.Name = "colMessage";
            colMessage.Name = "Message";
            colMessage.HeaderText = "Message";
            colMessage.DataPropertyName = "Message";
            colMessage.Width = 200;
            colMessage.ReadOnly = true;
            colMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns.Add(colMessage);
            headerStyle.BackColor = Color.FromArgb(15, 23, 42);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.SelectionBackColor = Color.FromArgb(15, 23, 42);
            headerStyle.SelectionForeColor = Color.White;
            cellStyle.BackColor = Color.FromArgb(22, 33, 62);
            cellStyle.ForeColor = Color.White;
            cellStyle.Font = new Font("Bahnschrift Light", 10.5F);
            cellStyle.Padding = new Padding(6, 0, 0, 0);
            cellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            cellStyle.SelectionForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle = headerStyle;
            grid.DefaultCellStyle = cellStyle;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            grid.CellClick += Grid_CellClick;
            grid.CellFormatting += Grid_CellFormatting;
            card.Controls.Add(titleLabel);
            card.Controls.Add(txtTitle);
            card.Controls.Add(priorityLabel);
            card.Controls.Add(cboPriority);
            card.Controls.Add(messageLabel);
            card.Controls.Add(rtbMessage);
            card.Controls.Add(btnPost);
            card.Controls.Add(btnUpdate);
            card.Controls.Add(btnDelete);
            card.Controls.Add(btnCancel);
            card.Controls.Add(btnToggleActive);
            card.Controls.Add(lblMsg);
            announcementsBody.Name = "announcementsBody";
            announcementsBody.Dock = DockStyle.Fill;
            announcementsBody.Padding = new Padding(12, 0, 12, 15);
            announcementsBody.Size = new Size(1200, 648);
            announcementsBody.Controls.Add(grid);
            announcementsBody.Controls.Add(lblTotal);
            announcementsBody.Controls.Add(card);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 38);
            Font = new Font("Segoe UI", 9F);
            Name = "AnnouncementsAdmin";
            Size = new Size(1200, 720);
            Controls.Add(announcementsBody);
            Controls.Add(subtitle);
            Controls.Add(heading);
            Load += AnnouncementsAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            card.ResumeLayout(false);
            card.PerformLayout();
            announcementsBody.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
