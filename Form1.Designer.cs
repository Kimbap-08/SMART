namespace SMART
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new ReaLTaiizor.Controls.Panel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(kryptonTextBox1);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.ForeColor = Color.Cornsilk;
            panel1.Location = new Point(-12, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(292, 946);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Enabled = false;
            kryptonTextBox1.Location = new Point(0, 22);
            kryptonTextBox1.Multiline = true;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.ReadOnly = true;
            kryptonTextBox1.Size = new Size(287, 74);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.Maroon;
            kryptonTextBox1.StateCommon.Border.Color1 = Color.Transparent;
            kryptonTextBox1.StateCommon.Border.Color2 = Color.Transparent;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Yellow;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Impact", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox1.TabIndex = 0;
            kryptonTextBox1.Text = "S.M.A.R.T";
            kryptonTextBox1.TextAlign = HorizontalAlignment.Center;
            kryptonTextBox1.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 845);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}
