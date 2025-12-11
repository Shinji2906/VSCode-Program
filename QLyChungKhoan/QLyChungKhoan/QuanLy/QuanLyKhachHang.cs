using Microsoft.SqlServer.Server;
using QLyChungKhoan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyChungKhoan.BLL.QuanLy
{
    public class QuanLyKhachHang
    {
        private QLCK_Entities dbContext;
        public QuanLyKhachHang()
        {
            dbContext = new QLCK_Entities();
        }

        public List<KhachHang> GetAllKhachHang()
        {
            return dbContext.KhachHang.ToList();
        }

        public KhachHang GetKhachHangByID(string id)
        {
            return dbContext.KhachHang.Include("ChungKhoan")
                .FirstOrDefault(kh => kh.MaKhachHang == id);
        }

        public void ThemKhachHang(KhachHang khach)
        {
            dbContext.KhachHang.Add(khach);
            dbContext.SaveChanges();
        }

        public void UpdateKhachHang(KhachHang khach)
        {
            var existingKhachHang = dbContext.KhachHang.Find(khach.MaKhachHang);
            if (existingKhachHang != null)
            {
                existingKhachHang.TenKhachHang = khach.TenKhachHang;
                existingKhachHang.SoTien = khach.SoTien;
                existingKhachHang.GioiTinh = khach.GioiTinh;
                existingKhachHang.MaCK = khach.MaCK;
                dbContext.SaveChanges();
            }
        }
        public void XoaKhachHang(string id)
        {
            var khach = dbContext.KhachHang.Find(id);
            if (khach != null)
            {
                dbContext.KhachHang.Remove(khach);
                dbContext.SaveChanges();
            }
        }
    }
}
