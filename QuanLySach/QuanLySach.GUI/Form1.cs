using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySach.BLL.QuanLy;
using QuanLySach.DAL;

namespace QuanLySach.GUI
{
    public partial class Form1 : Form
    {
        private QuanLyTheLoai quanlytheloai;
        private QLySach quanlysach;
        public Form1()
        {
            InitializeComponent();
            quanlytheloai = new QuanLyTheLoai();
            quanlysach = new QLySach();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doc_dulieu_cbTheLoai();
            Tao_Header_dgvSach();
            Doc_Dulieu_dgvSach();
        }

        private void Doc_dulieu_cbTheLoai()
        {
            List<TheLoaiSach> lstTheLoai = quanlytheloai.GetAllTheLoai();
            cb_TheLoai.DataSource = lstTheLoai;
            cb_TheLoai.DisplayMember = "MaTheLoai";
            cb_TheLoai.ValueMember = "TenTheLoai";
        }

        private void Tao_Header_dgvSach()
        {
            dgv_Sach.Columns.Add("MaSach", "Ma Sach");
            dgv_Sach.Columns.Add("TenSach", "Ten Sach");
            dgv_Sach.Columns.Add("TacGia", "Tac Gia");
            dgv_Sach.Columns.Add("Gioithieu", "Gioi Thieu");
            dgv_Sach.Columns.Add("TheLoai", "The Loai");
        }

        private void Doc_Dulieu_dgvSach()
        {
            dgv_Sach.Rows.Clear();
            List<Sach> list_Sach
                = quanlysach.GetAllSach();
            foreach (Sach s in list_Sach)
            {
                dgv_Sach.Rows.Add(
                    s.MaSach,
                    s.TenSach,
                    s.TacGia,
                    s.GioiThieu,
                    s.TheLoaiSach.TenTheLoai);
            }
            dgv_Sach.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgv_Sach.Rows.Count)
            {
                DataGridViewRow row = dgv_Sach.Rows[index];
                if (row.IsNewRow == false)
                {
                    string maS = row.Cells["MaSach"].Value.ToString();
                    Sach s = quanlysach.GetSachByID(maS);
                    if (s != null)
                    {
                        txt_MaSach.Text = s.MaSach;
                        txt_TenSach.Text = s.TenSach;
                        txt_TacGia.Text = s.TacGia;
                        txt_GioiThieu.Text = s.GioiThieu;
                        cb_TheLoai.SelectedValue = s.MaTheLoai;
                    }
                }
            }
        }

        private Sach Lay_DuLieu_Sach()
        {
            Sach sach = new Sach();
            string maS = txt_MaSach.Text.Trim();
            if (maS == "")
            {
                MessageBox.Show("Ma sach khong duoc de trong!");
                return null;
            }
            sach.MaSach = maS;

            string tenS = txt_TenSach.Text.Trim();
            if (tenS == "")
            {
                MessageBox.Show("Ten sach khong duoc de trong!");
                return null;
            }
            sach.TenSach = tenS;

            string tacgia = txt_TacGia.Text.Trim();
            if (tacgia == "")
            {
                MessageBox.Show("Ten tac gia khong duoc de trong!");
                return null;
            }
            sach.TacGia = tacgia;

            sach.MaTheLoai =
                ((TheLoaiSach)cb_TheLoai.SelectedItem).MaTheLoai;

            return sach;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Sach sach = Lay_DuLieu_Sach();
            if (sach == null) return;

            Sach existingSach
                = quanlysach.GetSachByID(sach.MaSach);
            if (existingSach != null)
            {
                MessageBox.Show("Ma sach da ton tai!");
                return;
            }
            quanlysach.AddSach(sach);
            Doc_Dulieu_dgvSach();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Sach sach = Lay_DuLieu_Sach();
            if (sach == null) return;

            Sach existingSach
                = quanlysach.GetSachByID(sach.MaSach);
            if (existingSach != null)
            {
                MessageBox.Show("Ma sach khong ton tai!");
                return;
            }
            quanlysach.UpdateSach(sach);
            Doc_Dulieu_dgvSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maS = txt_MaSach.Text.Trim();
            if (maS == "")
            {
                MessageBox.Show("Ma sach khong dc de trong!");
                return;
            }
            quanlysach.DeleteSach(maS);
            Doc_Dulieu_dgvSach();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

       
    }
}
