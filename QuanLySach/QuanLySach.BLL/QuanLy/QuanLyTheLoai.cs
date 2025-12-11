using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySach.DAL;

namespace QuanLySach.BLL.QuanLy
{
    public class QuanLyTheLoai
    {
        private static QLYSACH_Entities dbContext;
        public QuanLyTheLoai()
        {
            dbContext = new QLYSACH_Entities();
        }
        public List<TheLoaiSach> GetAllTheLoai()
        {
            return dbContext.TheLoaiSach.ToList();
        }

        public TheLoaiSach GetTheLoai(int id)
        {
            return dbContext.TheLoaiSach.Find(id);
        }
    }   
}
