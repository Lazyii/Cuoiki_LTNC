using CK.DAO;
using CK.DAO.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.Repositories
{
    public class DichVuRepository
    {
        public List<DichVu> GetAll()
        {
            using var db = new AppDbContext();
            return db.DichVus.ToList();
        }

        public void Them(DichVu dv)
        {
            using var db = new AppDbContext();
            db.DichVus.Add(dv);
            db.SaveChanges();
        }
        public void Sua(DichVu dv)
        {
            using var db = new AppDbContext();
            var old = db.DichVus.Find(dv.Id);
            if (old == null) return;

            old.TenDichVu = dv.TenDichVu;
            old.Gia = dv.Gia;
            db.SaveChanges();
        }
        public void Xoa(int id)
        {
            using var db = new AppDbContext();
            var dv = db.DichVus.Find(id);
            if (dv == null) return;

            db.DichVus.Remove(dv);
            db.SaveChanges();
        }
        public List<DichVu> TimKiem(string ten)
        {
            using var db = new AppDbContext();
            return db.DichVus
                     .Where(x => x.TenDichVu.Contains(ten))
                     .ToList();
        }
        public void TaoDichVuMacDinh()
        {
            using var db = new AppDbContext();

            var dsDichVu = new List<DichVu>
            {
                new DichVu { TenDichVu = "Giặt ủi", Gia = 30000 },
                new DichVu { TenDichVu = "Ăn sáng", Gia =  50000 },
                new DichVu { TenDichVu = "Thuê xe", Gia = 200000 }
            };

            foreach (var dv in dsDichVu)
            {
                if (!db.DichVus.Any(x => x.TenDichVu == dv.TenDichVu))
                {
                    db.DichVus.Add(dv);
                }
            }

            db.SaveChanges();
        }
    }
}

