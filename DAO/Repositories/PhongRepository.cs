using CK.DAO;
using CK.DAO.ENTITY;
using CK.VIEW.form_phụ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.Repositories
{
    public class PhongRepository
    {
        public List<Phong> GetAll()
        {
            using var db = new AppDbContext();
            return db.Phongs.ToList();
        }
        public void CapNhatTrangThai(int id, string trangThai)
        {
            using var db = new AppDbContext();
            var p = db.Phongs.FirstOrDefault(x => x.PhongId == id);
            if (p != null)
            {
                p.TrangThai = trangThai;
                db.SaveChanges();
            }
        }

        public void Them(Phong dv)
        {
            using var db = new AppDbContext();
            db.Phongs.Add(dv);
            db.SaveChanges();
        }
        public bool TonTaiTenPhong(string tenPhong)
        {
            using var db = new AppDbContext();
            return db.Phongs.Any(p => p.TenPhong == tenPhong);
        }
        public void Sua(Phong dv)
        {
            using var db = new AppDbContext();
            var old = db.Phongs.Find(dv.PhongId);
            if (old == null) return;

            old.TenPhong = dv.TenPhong;
            old.LoaiPhong = dv.LoaiPhong;
            old.TrangThai = dv.TrangThai;
            old.Gia = dv.Gia;
            db.SaveChanges();
        }
        public Phong GetById(int id)
        {
            using var db = new AppDbContext();
            return db.Phongs.FirstOrDefault(p => p.PhongId == id);
        }

        public void Xoa(int id)
        {
            using var db = new AppDbContext();
            var p = db.Phongs.FirstOrDefault(x => x.PhongId == id);
            if (p != null)
            {
                db.Phongs.Remove(p);
                db.SaveChanges();
            }
        }

        public List<Phong> TimKiem(string ten)
        {
            using var db = new AppDbContext();
            return db.Phongs
                     .Where(x => x.TenPhong.Contains(ten))
                     .ToList();
        }
        public void TaoPhongMacDinh()
        {
            using var db = new AppDbContext();

            var dsPhong = new List<Phong>
            {
                new Phong { LoaiPhong = "Phòng đơn", TenPhong = "Đơn 1", TrangThai= "Trống", Gia = 300000 },
                new Phong { LoaiPhong = "Phòng đơn", TenPhong = "Đơn 2", TrangThai= "Bận", Gia = 300000 },
                new Phong { LoaiPhong = "Phòng đôi", TenPhong = "Đôi 1", TrangThai= "Trống", Gia = 500000 },
                new Phong { LoaiPhong = "Phòng đôi", TenPhong = "Đôi 2", TrangThai= "Trống", Gia = 500000 },
                new Phong { LoaiPhong = "Phòng đôi", TenPhong = "Đôi 3", TrangThai= "Trống", Gia = 500000 },
                new Phong { LoaiPhong = "Gia đình", TenPhong = "GĐ 1", TrangThai= "Bận", Gia = 700000 },
                new Phong { LoaiPhong = "Gia đình", TenPhong = "GĐ 2", TrangThai= "Bận", Gia = 700000 },
                new Phong { LoaiPhong = "Gia đình", TenPhong = "GĐ 3", TrangThai= "Bận", Gia = 700000 },
                new Phong { LoaiPhong = "Cao cấp", TenPhong = "Pro 1", TrangThai= "Bận", Gia = 1000000 },
                new Phong { LoaiPhong = "Cao cấp", TenPhong = "Pro 2", TrangThai= "Trống", Gia = 1000000 },
            };

            foreach (var dv in dsPhong)
            {
                if (!db.Phongs.Any(x => x.TenPhong == dv.TenPhong))
                {
                    db.Phongs.Add(dv);
                }
            }

            db.SaveChanges();
        }
    }
}

