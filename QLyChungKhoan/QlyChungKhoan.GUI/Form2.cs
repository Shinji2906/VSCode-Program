using QLyChungKhoan.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyChungKhoan.GUI
{
    public partial class Form2 : Form
    {
        public delegate void KhachHangHandler(KhachHang kh);
        public event KhachHangHandler OnKhachHangSaved;

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = txt_MaKH.Text.Trim();
            kh.TenKhachHang = txt_TenKH.Text.Trim();
            kh.SoTien = double.Parse(txt_SoTien.Text.Trim());
            kh.GioiTinh = rdo_nam.Checked;

            OnKhachHangSaved?.Invoke(kh);

            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Form1"].Show();
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
