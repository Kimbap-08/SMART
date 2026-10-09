using System.Drawing;
using System.Windows.Forms;
namespace SMART
{

partial class InstructorAnnouncements
{
    private System.ComponentModel.IContainer? components;
    private Label heading = null!;
    private Label subtitle = null!;
    private Panel toolbar = null!;
    private CustomButton btnRefresh = null!;
    private Label status = null!;
    private FlowLayoutPanel cards = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private Panel pnlHeaderInstructorAnnouncements = null!;
    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
            pnlHeaderInstructorAnnouncements = new Panel();
            pnlHeaderInstructorAnnouncements.Name = "pnlHeaderInstructorAnnouncements";
            pnlHeaderInstructorAnnouncements.BackColor = Color.Transparent;
            pnlHeaderInstructorAnnouncements.Dock = DockStyle.Top;
            pnlHeaderInstructorAnnouncements.Size = new Size(1200, 106);

        components = new System.ComponentModel.Container();
        heading = new Label();
        subtitle = new Label();
        toolbar = new Panel();
        btnRefresh = new CustomButton();
        status = new Label();
        cards = new StableFlowLayoutPanel();
        toolbar.SuspendLayout();
        SuspendLayout();
        //
        // heading
        //
        heading.AutoEllipsis = true;
        heading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        heading.Font = new Font("Gadugi", 20F, FontStyle.Bold);
        heading.ForeColor = Color.White;
        heading.Location = new Point(25, 22);
        heading.Name = "heading";
        heading.Size = new Size(1100, 46);
        heading.Text = "📢 Announcements from Administration";
        //
        // subtitle
        //
        subtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        subtitle.Font = new Font("Bahnschrift Light", 10F);
        subtitle.ForeColor = Color.White;
        subtitle.Location = new Point(29, 76);
        subtitle.Name = "subtitle";
        subtitle.Size = new Size(1100, 26);
        subtitle.Text = "Updates and notices for instructors";
        //
        // toolbar
        //
        toolbar.BackColor = Color.FromArgb(13, 17, 38);
        toolbar.Controls.Add(btnRefresh);
        toolbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        toolbar.Location = new Point(0, 106);
        toolbar.Name = "toolbar";
        toolbar.Size = new Size(1540, 42);
        //
        // btnRefresh
        //
        btnRefresh.BackColor = Color.FromArgb(48, 63, 93);
        btnRefresh.BorderRadius = 5;
        btnRefresh.BorderSize = 0;
        btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRefresh.ForeColor = Color.White;
        btnRefresh.Location = new Point(0, 4);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(105, 32);
        btnRefresh.Text = "🔄 Refresh";
        btnRefresh.Click += btnRefresh_Click;
        //
        // status
        //
        status.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        status.Font = new Font("Segoe UI", 10F);
        status.ForeColor = Color.FromArgb(150, 150, 170);
        status.Location = new Point(0, 148);
        status.Name = "status";
        status.Size = new Size(1540, 28);
        status.TextAlign = ContentAlignment.MiddleCenter;
        //
        // cards
        //
        cards.AutoScroll = true;
        cards.BackColor = Color.FromArgb(13, 17, 38);
        cards.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cards.FlowDirection = FlowDirection.TopDown;
        cards.Location = new Point(0, 176);
        cards.Name = "cards";
        cards.Padding = new Padding(0, 8, 12, 8);
        cards.Size = new Size(1540, 669);
        cards.WrapContents = false;
        //
        // InstructorAnnouncements
        //
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(26, 26, 46);
        Controls.Add(cards);
        Controls.Add(status);
        Controls.Add(toolbar);

        pnlHeaderInstructorAnnouncements.Controls.Add(heading);
            pnlHeaderInstructorAnnouncements.Controls.Add(subtitle);
            Controls.Add(pnlHeaderInstructorAnnouncements);
        Name = "InstructorAnnouncements";
        ClientSize = new Size(1540, 845);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Text = "Announcements";
        WindowState = FormWindowState.Maximized;
        toolbar.ResumeLayout(false);
        ResumeLayout(false);
    }
    #endregion
}

}
