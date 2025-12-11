namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form_Load();
        }
        //set gia tri mac dinh cho cac object tren form
        private void Form_Load()
        {
            //gioi tinh mac dinh la nam
            rdo_Nam.Checked = true;

            //chonn khoa mac dinh la cong nghe thong tin
            cbo_CNganh.Items.Add("Cong nghe thong tin");
            cbo_CNganh.Items.Add("Thuomg mai dien tu");
            cbo_CNganh.Items.Add("Ngon ngu Anh");
            cbo_CNganh.SelectedIndex = 0;

            //tao header cho datagridview
            dgv_SinhVien.Columns.Add("MaSV", "Ma SV");
            dgv_SinhVien.Columns.Add("HoTen", "Ho Ten");
            dgv_SinhVien.Columns.Add("GioiTinh", "Gioi Tinh");
            dgv_SinhVien.Columns.Add("CNganh", "Chuyen Nganh");
            //Nhap du lieu mau
            dgv_SinhVien.Rows
                .Add("SV001", "Nguyen Van A", "Nam", "Cong nghe thong tin");
            dgv_SinhVien.Rows
                .Add("SV002", "Tran Thi B", "Nu", "Thuong mai dien tu");
            dgv_SinhVien.AutoSizeColumnsMode
                = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

            Tinh_SLNamNu();
        }

        private void Tinh_SLNamNu()
        {
            int slNam = 0, slNu = 0;
            foreach (DataGridViewRow row in dgv_SinhVien.Rows)
            {
                if (row.Cells["GioiTinh"].Value != null)
                {
                    string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                    if (gioiTinh == "Nam")
                    {
                        slNam++;
                    }
                    else if (gioiTinh == "Nu")
                    {
                        slNu++;
                    }
                }
            }
            txt_SLNam.Text = slNam.ToString();
            txt_SLNu.Text = slNu.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string maSV = txt_MSSV.Text.Trim();
            if(maSV == "")
            {
                MessageBox.Show("Ma sinh vien khong duoc de trong", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowIndex = Tim_MaSV(maSV);
            if (rowIndex == -1)
            {
                string hoTen = txt_HoTen.Text.Trim();
                string gioiTinh = rdo_Nam.Checked ? "Nam" : "Nu";
                string chuyenNganh = cbo_CNganh.SelectedItem.ToString();
                dgv_SinhVien.Rows.Add(maSV, hoTen, gioiTinh, chuyenNganh);
                Tinh_SLNamNu();
                MessageBox.Show("Them sinh vien thanh cong", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewRow row = dgv_SinhVien.Rows[rowIndex];
                row.Cells["HoTen"].Value = txt_HoTen.Text.Trim();
                row.Cells["GioiTinh"].Value = rdo_Nam.Checked ? "Nam" : "Nu";
                Tinh_SLNamNu();
                MessageBox.Show("Sua thong tin sinh vien thanh cong", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maSV = txt_MSSV.Text.Trim();
            int rowIndex = Tim_MaSV(maSV);
            if (rowIndex == -1)
            {
                MessageBox.Show("Ma sinh vien khong ton tai", "loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgv_SinhVien.Rows.RemoveAt(rowIndex);
                Tinh_SLNamNu();
                MessageBox.Show("Xoa sinh vien thanh cong", "thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int Tim_MaSV(string maSV)
        {
            foreach(DataGridViewRow row in dgv_SinhVien.Rows)
            {
                if (row.Cells["MaSV"].Value != null
                    && row.Cells["MaSV"].Value.ToString() == maSV)
                {
                    return row.Index;
                }
            }
            return -1;
        }

        private void dgv_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgv_SinhVien.Rows.Count)
            {
                DataGridViewRow row = dgv_SinhVien.Rows[rowIndex];
                if (row.Cells["MaSV"].Value != null)
                {
                    txt_MSSV.Text = row.Cells["MaSV"].Value.ToString();
                    txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                    string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                    if (gioiTinh == "Nam")
                    {
                        rdo_Nam.Checked = true;
                    }
                    else
                    {
                        rdo_Nu.Checked = true;
                    }
                    string ChuyenNganh = row.Cells["CNganh"].Value.ToString();
                    cbo_CNganh.SelectedItem = ChuyenNganh;
                }
            }
        }
    }
}
