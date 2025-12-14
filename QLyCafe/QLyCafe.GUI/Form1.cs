using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyCafe.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quanLyDanhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QLDanhMuc form_QLDanhMuc = new Form_QLDanhMuc();
            this.Hide();
            form_QLDanhMuc.ShowDialog();
        }

        private void quanLySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
