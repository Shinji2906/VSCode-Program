using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySach.DAL;

namespace QuanLySach.BLL.QuanLy
{
    public class QLySach
    {
        private QLYSACH_Entities dbContext;

        public QLySach()
        {
            dbContext = new QLYSACH_Entities();
        }

        public List<Sach> GetAllSach()
        {
            return dbContext.Sach.ToList();
        }

        public Sach GetSachByID(String id)
        {
            return dbContext.Sach.Find(id);
        }

        public void AddSach(Sach sach)
        {
            dbContext.Sach.Add(sach);
            dbContext.SaveChanges();
        }

        public void UpdateSach(Sach sach)
        {
            var existingSach = dbContext.Sach.Find(sach.MaSach);
            if (existingSach != null)
            {
                existingSach.TenSach = sach.TenSach;
                existingSach.TacGia = sach.TacGia;
                existingSach.GioiThieu = sach.GioiThieu;
                dbContext.SaveChanges();
            }
        }

        public void DeleteSach(string id)
        {
            var sach = dbContext.Sach.Find(id);
            if (sach != null)
            {
                dbContext.Sach.Remove(sach);
                dbContext.SaveChanges();
            }
        }

        public void DeteleStudent(Sach sach)
        {
            DeleteSach(sach.MaSach);
        }
    }
}
