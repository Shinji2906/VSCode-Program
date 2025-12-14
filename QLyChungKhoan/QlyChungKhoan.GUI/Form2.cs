using QLyChungKhoan.BLL.QuanLy;
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
        private QuanLyChungKhoan quanLyChungKhoan;
        private QuanLyKhachHang quanLyKhachHang;

        public Form2()
        {
            InitializeComponent();
            quanLyChungKhoan = new QuanLyChungKhoan();
            quanLyKhachHang = new QuanLyKhachHang();
            Doc_dulieu_cbMaCK();
        }
        private void Doc_dulieu_cbMaCK()
        {
            cb_MaCK.DataSource = quanLyChungKhoan.GetAllChungKhoan();
            cb_MaCK.DisplayMember = "TenCK";
            cb_MaCK.ValueMember = "MaCK";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = txt_MaKH.Text.Trim();
            kh.TenKhachHang = txt_TenKH.Text.Trim();
            kh.SoTien = double.Parse(txt_SoTien.Text.Trim());
            kh.GioiTinh = rdo_nam.Checked;
            kh.MaCK = ((ChungKhoan)cb_MaCK.SelectedItem).MaCK;
            OnKhachHangSaved?.Invoke(kh);

            this.Close();
        }


        private void btn_exit2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

        }

    }
}
