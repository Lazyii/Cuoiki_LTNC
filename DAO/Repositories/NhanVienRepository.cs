using CK.DAO.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.Repositories
{
    public class NhanVienRepository
    {
        public NhanVien DangNhap(string taikhoan, string matkhau)
        {
            using var db = new AppDbContext();

            return db.NhanViens
                     .FirstOrDefault(nv =>
                         nv.Taikhoan == taikhoan &&
                         nv.Matkhau == matkhau);
        }
        public void TaoTaiKhoanMacDinh()
        {
            using var db = new AppDbContext();

            var dsTaiKhoan = new List<NhanVien>
            {
                new NhanVien { Taikhoan = "admin",   Matkhau = "123" },
                new NhanVien { Taikhoan = "user1",   Matkhau = "123" },
                new NhanVien { Taikhoan = "user2",   Matkhau = "123" },
                new NhanVien { Taikhoan = "manager", Matkhau = "456" }
            };

            foreach (var nv in dsTaiKhoan)
            {
                if (!db.NhanViens.Any(x => x.Taikhoan == nv.Taikhoan))
                {
                    db.NhanViens.Add(nv);
                }
            }

            db.SaveChanges();
        }

    }

}
