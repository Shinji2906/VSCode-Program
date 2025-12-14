using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QlyCafe.BLL;
using QLyCafe.DAL;


namespace QLyCafe.GUI
{
    public partial class Form_QLDanhMuc : Form
    {
        private CategoryServices categoryServices;
        public Form_QLDanhMuc()
        {
            InitializeComponent();
            categoryServices = new CategoryServices();
        }

        private void Form_QLDanhMuc_Load(object sender, EventArgs e)
        {
            Tao_Header_dgvCategory();
            Doc_Dulieu_dgvCategory();
            Tao_Header_dgvCategoryDeleted();
            Doc_Dulieu_dgvCategoryDeleted();
        }

        private void Tao_Header_dgvCategory()
        {
            dgv_Category.Columns.Add("ID", "Ma danh muc");
            dgv_Category.Columns.Add("Name", "Ten danh muc");
        }

        private void Doc_Dulieu_dgvCategory()
        {
            List<Category> categories = categoryServices.GetCategories();
            dgv_Category.Rows.Clear();
            foreach (var category in categories)
            {
                dgv_Category.Rows.Add(category.ID, category.Name);
            }
            dgv_Category.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Tao_Header_dgvCategoryDeleted()
        {
            dgv_Category_Deleted.Columns.Add("ID", "Ma danh muc");
            dgv_Category_Deleted.Columns.Add("Name", "Ten danh muc");
        }
        private void Doc_Dulieu_dgvCategoryDeleted()
        {
            List<Category> categories = categoryServices.GetCategoriesDeleted();
            dgv_Category_Deleted.Rows.Clear();
            foreach (var category in categories)
            {
                dgv_Category_Deleted.Rows.Add(category.ID, category.Name);
            }
            dgv_Category_Deleted.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form_QLDanhMuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(UserSession.islogin() == true)
            {
                Application.OpenForms["Form1"].Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgv_Category.Rows.Count)
            {
                DataGridViewRow selectedRow = dgv_Category.Rows[rowIndex];
                if (selectedRow.IsNewRow == false)
                {
                    txt_CategoryID.Text = selectedRow.Cells["ID"].Value.ToString();
                    txt_CategoryName.Text = selectedRow.Cells["Name"].Value.ToString();
                    lbl_Message.Text = "Danh muc nay da xoa";
                }
            }
        }

        private void dgv_Category_Deleted_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
