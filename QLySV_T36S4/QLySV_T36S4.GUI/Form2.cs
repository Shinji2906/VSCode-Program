using QLySV_T36S4.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLySV_T36S4.BLL.Services;
using QLySV_T36S4.DAL;

namespace QLySV_T36S4.GUI
{
    public partial class Form2 : Form
    {
        private FacultyService facultyService;
        public Form2()
        {
            InitializeComponent();
            facultyService = new FacultyService();
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Dong form phu, mo lai form chinh
            Application.OpenForms["Form1"].Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Tao_Header_dgvgs();
            Doc_DuLieu_dgvgs();
        }

        private void Tao_Header_dgvgs()
        {
            dgv_gs.Columns.Add("MaKhoa", "Ma khoa");
            dgv_gs.Columns.Add("TenKhoa", "Ten khoa");
            dgv_gs.Columns.Add("Sogiaosu", "So giao su");
        }
        
        private void Doc_DuLieu_dgvgs()
        {
            dgv_gs.Rows.Clear();
            List<Faculty> lst_Faculty
                = facultyService.GetAllFaculties();
            foreach (Faculty fk in lst_Faculty)
            {
                dgv_gs.Rows.Add(
                    fk.FacultyID,
                    fk.FacultyName,
                    fk.count_professor);
            }
            dgv_gs.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgv_gs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
