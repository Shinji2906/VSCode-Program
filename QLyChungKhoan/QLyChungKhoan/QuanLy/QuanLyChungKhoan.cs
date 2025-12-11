using QLyChungKhoan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyChungKhoan.BLL.QuanLy
{
    public class QuanLyChungKhoan
    {
        private static QLCK_Entities dbContext;
        public QuanLyChungKhoan()
        {
            dbContext = new QLCK_Entities();
        }
        public List<ChungKhoan> GetAllChungKhoan()
        {
            return dbContext.ChungKhoan.ToList();
        }

        public ChungKhoan GetChungKhoan(int id)
        {
            return dbContext.ChungKhoan.Find(id);
        }
    }
}
