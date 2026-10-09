namespace SMART;

public sealed partial class InstructorAnnouncementDetailsDialog
{
    private System.ComponentModel.IContainer? components;
    private CustomPanel pnlDialog = null!;
    private Label lblTitle = null!;
    private Label lblDate = null!;
    private Label lblSender = null!;
    private RichTextBox txtMessage = null!;
    private CustomButton btnX = null!;
    private CustomButton btnClose = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        pnlDialog = new CustomPanel();
        lblTitle = new Label();
        lblDate = new Label();
        lblSender = new Label();
        txtMessage = new RichTextBox();
        btnX = new CustomButton();
        btnClose = new CustomButton();
        pnlDialog.SuspendLayout();
        SuspendLayout();
        pnlDialog.BackColor = Color.FromArgb(22, 33, 62);
        pnlDialog.BorderColor = Color.FromArgb(233, 69, 96);
        pnlDialog.BorderWidth = 1;
        pnlDialog.CornerRadius = 10;
        pnlDialog.Controls.Add(lblTitle);
        pnlDialog.Controls.Add(lblDate);
        pnlDialog.Controls.Add(lblSender);
        pnlDialog.Controls.Add(txtMessage);
        pnlDialog.Controls.Add(btnX);
        pnlDialog.Controls.Add(btnClose);
        pnlDialog.Dock = DockStyle.Fill;
        lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitle.AutoEllipsis = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(24, 20);
        lblTitle.Size = new Size(650, 36);
        lblDate.Font = new Font("Segoe UI", 9F);
        lblDate.ForeColor = Color.FromArgb(150, 150, 170);
        lblDate.Location = new Point(26, 67);
        lblDate.Size = new Size(500, 22);
        lblSender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblSender.ForeColor = Color.FromArgb(150, 150, 170);
        lblSender.Location = new Point(26, 92);
        lblSender.Size = new Size(620, 22);
        txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtMessage.BackColor = Color.FromArgb(22, 33, 62);
        txtMessage.BorderStyle = BorderStyle.None;
        txtMessage.Font = new Font("Segoe UI", 11F);
        txtMessage.ForeColor = Color.White;
        txtMessage.Location = new Point(26, 128);
        txtMessage.ReadOnly = true;
        txtMessage.ScrollBars = RichTextBoxScrollBars.Vertical;
        txtMessage.Size = new Size(648, 390);
        txtMessage.TabStop = false;
        txtMessage.WordWrap = true;
        btnX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnX.BackColor = Color.FromArgb(22, 33, 62);
        btnX.FlatAppearance.BorderSize = 0;
        btnX.FlatStyle = FlatStyle.Flat;
        btnX.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnX.ForeColor = Color.FromArgb(233, 69, 96);
        btnX.Location = new Point(660, 12);
        btnX.Size = new Size(38, 36);
        btnX.Text = "X";
        btnX.Click += (_, _) => Close();
        btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnClose.BackColor = Color.FromArgb(233, 69, 96);
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnClose.ForeColor = Color.White;
        btnClose.Location = new Point(574, 536);
        btnClose.Size = new Size(100, 36);
        btnClose.Text = "Close";
        btnClose.Click += (_, _) => Close();
        AcceptButton = btnClose;
        CancelButton = btnClose;
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(13, 17, 38);
        ClientSize = new Size(710, 590);
        Controls.Add(pnlDialog);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "InstructorAnnouncementDetailsDialog";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Announcement";
        pnlDialog.ResumeLayout(false);
        ResumeLayout(false);
    }
}
