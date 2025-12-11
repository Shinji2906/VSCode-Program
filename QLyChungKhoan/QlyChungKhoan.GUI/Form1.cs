using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLyChungKhoan.BLL.QuanLy;
using QLyChungKhoan.DAL;

namespace QlyChungKhoan.GUI
{
    public partial class Form1 : Form
    {
        private QuanLyChungKhoan quanLyChungKhoan;
        private QuanLyKhachHang quanLyKhachHang;
        public Form1()
        {
            InitializeComponent();
            quanLyChungKhoan = new QuanLyChungKhoan();
            quanLyKhachHang = new QuanLyKhachHang();
            rdo_nam.Checked = true;
        }

        private void cb_MaCK_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doc_dulieu_cbMaCK();
            Tao_Header_dgvChungKhoan();
            Doc_DuLieu_dgvChungKhoan();
        }

        private void Doc_dulieu_cbMaCK()
        {
            List<ChungKhoan> lstChungKhoan = quanLyChungKhoan.GetAllChungKhoan();
            cb_MaCK.DataSource = lstChungKhoan;
            cb_MaCK.DisplayMember = "TenCK";
            cb_MaCK.ValueMember = "MaCK";
        }

        private void Tao_Header_dgvChungKhoan()
        {
            dgv_ChungKhoan.Columns.Clear();
            dgv_ChungKhoan.Columns.Add("MaKhachHang", "Ma khach hang");
            dgv_ChungKhoan.Columns.Add("TenKhachHang", "Ho ten khach hang");
            dgv_ChungKhoan.Columns.Add("SoTien", "So tien");
            dgv_ChungKhoan.Columns.Add("GioiTinh", "Gioi tinh");
            dgv_ChungKhoan.Columns.Add("MaCK", "Ma chung khoan");
        }

        private void Doc_DuLieu_dgvChungKhoan()
        {
            dgv_ChungKhoan.Rows.Clear();
            List<KhachHang> list_KhachHang
                = quanLyKhachHang.GetAllKhachHang();
            foreach (KhachHang kh in list_KhachHang)
            {
                dgv_ChungKhoan.Rows.Add(
                    kh.MaKhachHang,
                    kh.TenKhachHang,
                    kh.SoTien,
                    kh.GioiTinh == true ? "Nam" : "Nữ",
                    kh.ChungKhoan.TenCK);
            }
            dgv_ChungKhoan.AutoSizeColumnsMode
                        = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_ChungKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgv_ChungKhoan.Rows.Count)
            {
                DataGridViewRow row = dgv_ChungKhoan.Rows[index];
                if (row.IsNewRow  == false)
                {
                    string maKH = row.Cells["Makhachhang"].Value.ToString();
                    KhachHang kh = quanLyKhachHang.GetKhachHangByID(maKH);
                    if (kh != null)
                    {
                        txt_MaKH.Text = kh.MaKhachHang;
                        txt_TenKH.Text = kh.TenKhachHang;
                        txt_SoTien.Text = kh.SoTien.ToString();
                        cb_MaCK.SelectedValue = kh.MaCK;
                    }
                    string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                    if (gioiTinh == "Nam")
                    {
                        rdo_nam.Checked = true;
                    }
                    else
                    {
                        rdo_Nu.Checked = true;
                    }
                }
            }
        }
        private KhachHang Lay_DulieuKhachHang()
        {
            KhachHang khach = new KhachHang();
            string maKH = txt_MaKH.Text.Trim();
            if(maKH == "")
            {
                MessageBox.Show("Ma khach hang khong duoc de trong!");
                return null;
            }
            khach.MaKhachHang = maKH;
            
            string tenKH = txt_TenKH.Text.Trim();
            if(tenKH == "")
            {
                MessageBox.Show("Ten khach hang khong duoc de trong!");
                return null;
            }
            khach.TenKhachHang = tenKH;
            string soTien = txt_SoTien.Text.Trim();
                
            if (string.IsNullOrEmpty(soTien))
            {
                MessageBox.Show("Số tiền không được để trống!");
                return null;
            }

            double giaTri;
            if (!double.TryParse(soTien, out giaTri))
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                return null;
            }
            khach.SoTien = giaTri;  
            khach.MaCK =((ChungKhoan)cb_MaCK.SelectedItem).MaCK;

            khach.GioiTinh = rdo_nam.Checked ? true : false;

            return khach;
        }

        private void ResetForm()
        {
            txt_MaKH.Clear();
            txt_TenKH.Clear();
            txt_SoTien.Clear();
            rdo_nam.Checked = true;
            if(cb_MaCK.Items.Count > 0) cb_MaCK.SelectedIndex = 0;
            txt_MaKH.ReadOnly = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            KhachHang khach = Lay_DulieuKhachHang();
            if (khach == null) return;

            KhachHang existingkhach
                = quanLyKhachHang.GetKhachHangByID(khach.MaKhachHang);
            if (existingkhach != null)
            {
                MessageBox.Show("Ma KH da ton tai!");
                return;
            }
            quanLyKhachHang.ThemKhachHang(khach);
            Doc_DuLieu_dgvChungKhoan();
            ResetForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string makh = txt_MaKH.Text.Trim();
            if (makh == "")
            {
                MessageBox.Show("Ma KH khong dc de trong!");
                return;
            }
            quanLyKhachHang.XoaKhachHang(makh);
            Doc_DuLieu_dgvChungKhoan();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KhachHang khach = Lay_DulieuKhachHang();
            if (khach == null) return;

            KhachHang existingSach
                = quanLyKhachHang.GetKhachHangByID(khach.MaKhachHang);
            if (existingSach == null)
            {
                MessageBox.Show("Ma KH khong ton tai!");
                return;
            }
            quanLyKhachHang.UpdateKhachHang(khach);
            Doc_DuLieu_dgvChungKhoan();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_nhapkhachhang_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.OnKhachHangSaved += F2_OnKhachHangSaved;
            f2.ShowDialog();
        }
        private void F2_OnKhachHangSaved(KhachHang kh)
        {
            // Thêm vào database nếu muốn
            quanLyKhachHang.ThemKhachHang(kh);

            // Và đổ ra DataGridView
            Doc_DuLieu_dgvChungKhoan();
        }

        private void quanLyKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}
