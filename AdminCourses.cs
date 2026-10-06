using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART
{
    public partial class AdminCourses : Form
    {
        public AdminCourses()
        {
            InitializeComponent();
            StyleDataGridView();
        }

        private void StyleDataGridView()
        {
            // 1. Interaction & Edit Restrictions
            dgvCourses.ReadOnly = true;
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AllowUserToResizeRows = false;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.MultiSelect = false;

            // 2. Table Colors & Border Styles
            dgvCourses.BackgroundColor = Color.FromArgb(22, 33, 62);
            dgvCourses.BorderStyle = BorderStyle.None;
            dgvCourses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCourses.GridColor = Color.FromArgb(40, 52, 85);
            dgvCourses.EnableHeadersVisualStyles = false;
            dgvCourses.RowHeadersVisible = false;

            // 3. Column Header Styles
            dgvCourses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCourses.ColumnHeadersHeight = 38;
            dgvCourses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvCourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCourses.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            dgvCourses.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCourses.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dgvCourses.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // 4. Default Cell Styles
            dgvCourses.DefaultCellStyle.BackColor = Color.FromArgb(22, 33, 62);
            dgvCourses.DefaultCellStyle.ForeColor = Color.White;
            dgvCourses.DefaultCellStyle.Font = new Font("Bahnschrift Light", 10.5F);
            dgvCourses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvCourses.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCourses.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            // 5. Alternating Row Styles
            dgvCourses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 40, 72);
            dgvCourses.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvCourses.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 69, 96);
            dgvCourses.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvCourses.RowTemplate.Height = 36;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
