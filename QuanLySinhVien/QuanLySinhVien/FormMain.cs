using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void formQLSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLSinhVien frm_con = new FormQLSinhVien();
            frm_con.MdiParent = this;
            frm_con.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DR;
            DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.No)
                e.Cancel = true;
        }
    }
}
