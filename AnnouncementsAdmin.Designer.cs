#nullable disable

namespace SMART
{
    public sealed partial class AnnouncementsAdmin
    {
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel announcementsBody;
        private System.Windows.Forms.Panel pnlHeaderAnnouncementsAdmin;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label subtitle;
        private CustomPanel card;
        private System.Windows.Forms.Label titleLabel;
        private RoundedTextBox txtTitle;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox cboPriority;
        private ComboBox cboAudience;
        private Label audienceLabel;
        private DataGridViewTextBoxColumn colAudience;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            colAnnouncementId = new DataGridViewTextBoxColumn();
            colAnnouncementId.Name = "AnnouncementId";
            colAnnouncementId.DataPropertyName = "AnnouncementId";
            colAnnouncementId.HeaderText = "ID";
            colAnnouncementId.ReadOnly = true;
            colAnnouncementId.Visible = false;
            grid.Columns.Add(colAnnouncementId);
            colTitle = new DataGridViewTextBoxColumn();
            colTitle.Name = "Title";
            colTitle.DataPropertyName = "Title";
            colTitle.HeaderText = "Title";
            colTitle.ReadOnly = true;
            grid.Columns.Add(colTitle);
            colPriority = new DataGridViewTextBoxColumn();
            colPriority.Name = "Priority";
            colPriority.DataPropertyName = "Priority";
            colPriority.HeaderText = "Priority";
            colPriority.ReadOnly = true;
            grid.Columns.Add(colPriority);
            colAudience = new DataGridViewTextBoxColumn();
            colAudience.Name = "Audience";
            colAudience.DataPropertyName = "Audience";
            colAudience.HeaderText = "Audience";
            colAudience.ReadOnly = true;
            grid.Columns.Add(colAudience);
            colPostedAt = new DataGridViewTextBoxColumn();
            colPostedAt.Name = "Posted At";
            colPostedAt.DataPropertyName = "Posted At";
            colPostedAt.HeaderText = "Posted At";
            colPostedAt.ReadOnly = true;
            grid.Columns.Add(colPostedAt);
            colActive = new DataGridViewCheckBoxColumn();
            colActive.Name = "Active";
            colActive.DataPropertyName = "Active";
            colActive.HeaderText = "Active";
            colActive.ReadOnly = true;
            grid.Columns.Add(colActive);
            colMessage = new DataGridViewTextBoxColumn();
            colMessage.Name = "Message";
            colMessage.DataPropertyName = "Message";
            colMessage.HeaderText = "Message";
            colMessage.ReadOnly = true;
            grid.Columns.Add(colMessage);
            grid.AutoGenerateColumns = false;
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
            cboPriority.BackColor = Color.FromArgb(13, 17, 38);
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriority.Font = new Font("Segoe UI", 10F);
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
            cboAudience.BackColor = Color.FromArgb(13, 17, 38);
            cboAudience.ForeColor = Color.White;
            cboAudience.Font = new Font("Segoe UI", 10F);
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
    }
}
