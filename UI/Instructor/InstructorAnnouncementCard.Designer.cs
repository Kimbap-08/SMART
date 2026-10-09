using System.Drawing;
using System.Windows.Forms;
namespace SMART
{

partial class InstructorAnnouncementCard
{
    private System.ComponentModel.IContainer? components;
    private CustomPanel pnlCard = null!;
    private Label lblTitle = null!;
    private Label lblPriority = null!;
    private Label lblActive = null!;
    private Label lblMessage = null!;
    private Label lblPostedAt = null!;
    private Label lblReadMore = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        pnlCard = new CustomPanel();
        lblTitle = new Label();
        lblPriority = new Label();
        lblActive = new Label();
        lblMessage = new Label();
        lblPostedAt = new Label();
        lblReadMore = new Label();
        pnlCard.SuspendLayout();
        SuspendLayout();
        //
        // pnlCard
        //
        pnlCard.BackColor = Color.FromArgb(22, 33, 62);
        pnlCard.BorderColor = Color.FromArgb(48, 63, 93);
        pnlCard.BorderWidth = 1;
        pnlCard.CornerRadius = 8;
        pnlCard.Controls.Add(lblTitle);
        pnlCard.Controls.Add(lblPriority);
        pnlCard.Controls.Add(lblActive);
        pnlCard.Controls.Add(lblMessage);
        pnlCard.Controls.Add(lblPostedAt);
        pnlCard.Controls.Add(lblReadMore);
        pnlCard.Dock = DockStyle.Fill;
        pnlCard.Name = "pnlCard";
        //
        // lblTitle
        //
        lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitle.AutoEllipsis = true;
        lblTitle.BackColor = Color.Transparent;
        lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(14, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(480, 26);
        //
        // lblPriority
        //
        lblPriority.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblPriority.BackColor = Color.Transparent;
        lblPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPriority.ForeColor = Color.FromArgb(150, 150, 170);
        lblPriority.Location = new Point(520, 14);
        lblPriority.Name = "lblPriority";
        lblPriority.Size = new Size(105, 22);
        lblPriority.TextAlign = ContentAlignment.MiddleRight;
        //
        // lblActive
        //
        lblActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblActive.BackColor = Color.Transparent;
        lblActive.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblActive.ForeColor = Color.LightGreen;
        lblActive.Location = new Point(628, 14);
        lblActive.Name = "lblActive";
        lblActive.Size = new Size(58, 22);
        lblActive.TextAlign = ContentAlignment.MiddleRight;
        //
        // lblMessage
        //
        lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblMessage.AutoEllipsis = true;
        lblMessage.BackColor = Color.Transparent;
        lblMessage.Font = new Font("Segoe UI", 10F);
        lblMessage.ForeColor = Color.FromArgb(150, 150, 170);
        lblMessage.Location = new Point(14, 46);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(664, 58);
        //
        // lblPostedAt
        //
        lblPostedAt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblPostedAt.BackColor = Color.Transparent;
        lblPostedAt.Font = new Font("Segoe UI", 8F);
        lblPostedAt.ForeColor = Color.FromArgb(85, 85, 119);
        lblPostedAt.Location = new Point(428, 112);
        lblPostedAt.Name = "lblPostedAt";
        lblPostedAt.Size = new Size(250, 18);
        lblPostedAt.TextAlign = ContentAlignment.MiddleRight;
        //
        // lblReadMore
        //
        lblReadMore.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblReadMore.BackColor = Color.Transparent;
        lblReadMore.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblReadMore.ForeColor = Color.FromArgb(233, 69, 96);
        lblReadMore.Location = new Point(14, 112);
        lblReadMore.Name = "lblReadMore";
        lblReadMore.Size = new Size(150, 18);
        lblReadMore.Text = "Click to read more  →";
        //
        // InstructorAnnouncementCard
        //
        BackColor = Color.Transparent;
        Controls.Add(pnlCard);
        Margin = new Padding(0, 0, 0, 12);
        Name = "InstructorAnnouncementCard";
        Size = new Size(700, 142);
        pnlCard.ResumeLayout(false);
        ResumeLayout(false);
    }
    #endregion
}

}
