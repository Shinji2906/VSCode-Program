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
    public partial class Form1 : Form
    {
        private FacultyService facultyService;
        private StudentService studentService;
        public Form1()
        {
            InitializeComponent();
            facultyService = new FacultyService();
            studentService = new StudentService();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doc_dulieu_cboCNganh();
            Tao_Header_dgvSinhVien();
            Doc_Dulieu_dgvSinhVien();
        }

        private void Doc_dulieu_cboCNganh()
        {
            List<Faculty> lstFaculty = facultyService.GetAllFaculties();
            cb_CNganh.DataSource = lstFaculty;
            cb_CNganh.DisplayMember = "FacultyName";
            cb_CNganh.ValueMember = "FacultyID";
        }

        private void Tao_Header_dgvSinhVien()
        {
            dgv_SinhVien.Columns.Add("MaSV", "Ma SV");
            dgv_SinhVien.Columns.Add("Ten Sv", "Ho Ten SV");
            dgv_SinhVien.Columns.Add("DiemTB", "Diem TB");
            dgv_SinhVien.Columns.Add("CNganh", "Chuyen Nganh");
        }

        private void Doc_Dulieu_dgvSinhVien()
        {
            dgv_SinhVien.Rows.Clear();
            List<Student> list_Student
                = studentService.GetAllStudents();
            foreach (Student sv in list_Student)
            {
                dgv_SinhVien.Rows.Add(
                    sv.StudentID,
                    sv.StudentName,
                    sv.AverageScore,
                    sv.Faculty.FacultyName);
            }
            dgv_SinhVien.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgv_SinhVien.Rows.Count)
            {
                DataGridViewRow row = dgv_SinhVien.Rows[index];
                if (row.IsNewRow == false)
                {
                    string maSV = row.Cells["MaSV"].Value.ToString();
                    Student sv = studentService.GetStudentById(maSV);
                    if (sv != null)
                    {
                        txt_MSV.Text = sv.StudentID;
                        txt_HoTen.Text = sv.StudentName;
                        txt_DiemTB.Text = sv.AverageScore.ToString();
                        cb_CNganh.SelectedValue = sv.FacultyID;
                    }
                }
            }
        }

        private Student Lay_DuLieu_Student()
        {
            Student student = new Student();
            string maSV = txt_MSV.Text.Trim();
            if (maSV == "")
            {
                MessageBox.Show("Ma sinh vien khong duoc de trong!");
                return null;
            }
            student.StudentID = maSV;

            string tenSV = txt_HoTen.Text.Trim();
            if (tenSV == "")
            {
                MessageBox.Show("Ten sinh vien khong duoc de trong!");
                return null;
            }
            student.StudentName = tenSV;

            float diemTB;
            string str_diemTB = txt_DiemTB.Text.Trim();
            if (str_diemTB == "" ||
                float.TryParse(str_diemTB, out diemTB) == false)
            {
                MessageBox.Show("Diem trung binh khong dung dinh dang!");
                return null;
            }
            if (diemTB < 0 || diemTB > 10)
            {
                MessageBox.Show("Diem trung binh phai o trong khoang 1-10!");
                return null;
            }
            student.AverageScore = diemTB;

            student.FacultyID =
                ((Faculty)cb_CNganh.SelectedItem).FacultyID;

            return student;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Student student = Lay_DuLieu_Student();
            if (student == null) return;

            Student existingStudent
                = studentService.GetStudentById(student.StudentID);
            if (existingStudent != null)
            {
                MessageBox.Show("Ma sinh vien da ton tai!");
                return;
            }
            studentService.AddStudent(student);
            Doc_Dulieu_dgvSinhVien();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Student student = Lay_DuLieu_Student();
            if (student == null) return;

            Student existingStudent
                = studentService.GetStudentById(student.StudentID);
            if (existingStudent != null)
            {
                MessageBox.Show("Ma sinh vien khong ton tai!");
                return;
            }
            studentService.UpdateStudent(student);
            Doc_Dulieu_dgvSinhVien();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maSV = txt_MSV.Text.Trim();
            if (maSV == "")
            {
                MessageBox.Show("Ma sv khong dc de trong!");
                return;
            }
            studentService.DeleteStudent(maSV);
            Doc_Dulieu_dgvSinhVien();
        }


        private void btn_exit_Click(object sender, EventArgs e)
            {
            this.Hide();
            this.Close();
            }

        private void quanLyKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
    }
