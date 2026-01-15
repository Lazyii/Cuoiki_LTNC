using CK.DAO;
using CK.DAO.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.Repositories
{
    public class ThietBiRepository
    {
        public List<ThietBi> GetAll()
        {
            using var db = new AppDbContext();
            return db.ThietBis.ToList();
        }

        public void Them(ThietBi dv)
        {
            using var db = new AppDbContext();
            db.ThietBis.Add(dv);
            db.SaveChanges();
        }
        public void Sua(ThietBi dv)
        {
            using var db = new AppDbContext();
            var old = db.ThietBis.Find(dv.Id);
            if (old == null) return;

            old.TenThietBi = dv.TenThietBi;
            old.Gia = dv.Gia;
            db.SaveChanges();
        }
        public void Xoa(int id)
        {
            using var db = new AppDbContext();
            var dv = db.ThietBis.Find(id);
            if (dv == null) return;

            db.ThietBis.Remove(dv);
            db.SaveChanges();
        }
        public List<ThietBi> TimKiem(string ten)
        {
            using var db = new AppDbContext();
            return db.ThietBis
                     .Where(x => x.TenThietBi.Contains(ten))
                     .ToList();
        }
        public void TaoThietBiMacDinh()
        {
            using var db = new AppDbContext();

            var dsThietBi = new List<ThietBi>
            {
                new ThietBi { TenThietBi = "Tivi", Gia = 3000000 },
                new ThietBi { TenThietBi = "Tủ lạnh", Gia = 5000000 },
                new ThietBi { TenThietBi = "Điều hòa", Gia = 2000000 },
                new ThietBi { TenThietBi = "Bàn", Gia = 5000000 },
                new ThietBi { TenThietBi = "Chăn", Gia = 2000000 },
                new ThietBi { TenThietBi = "Bình siêu tốc", Gia = 500000 },
                new ThietBi { TenThietBi = "Máy sấy", Gia = 2000000 }
            };

            foreach (var dv in dsThietBi)
            {
                if (!db.ThietBis.Any(x => x.TenThietBi == dv.TenThietBi))
                {
                    db.ThietBis.Add(dv);
                }
            }

            db.SaveChanges();
        }
    }
}

