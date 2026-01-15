using CK.DAO;
using CK.DAO.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.Repositories
{
    public class KhachHangRepository
    {
        public List<KhachHang> GetAll()
        {
            using var db = new AppDbContext();
            return db.KhachHangs.ToList();
        }

        public void Them(KhachHang kh)
        {
            using var db = new AppDbContext();
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }
        public bool TonTaiCCCD(string cccd)
        {
            using var db = new AppDbContext();
            return db.KhachHangs.Any(k => k.CCCD == cccd);
        }


        public void Xoa(int id)
        {
            using var db = new AppDbContext();
            var dv = db.KhachHangs.Find(id);
            if (dv == null) return;

            db.KhachHangs.Remove(dv);
            db.SaveChanges();
        }
        public List<KhachHang> TimKiem(string ten)
        {
            using var db = new AppDbContext();
            return db.KhachHangs
                     .Where(x => x.TenKhach.Contains(ten))
                     .ToList();
        }
        

        public Phong GetById(int id)
        {
            using var db = new AppDbContext();
            return db.Phongs.FirstOrDefault(p => p.PhongId == id);
        }

        public void Sua(KhachHang dv)
        {
            using var db = new AppDbContext();
            var old = db.KhachHangs.Find(dv.KhachHangId);
            if (old == null) return;

            old.TenKhach = dv.TenKhach;
            old.QuocTich = dv.QuocTich;
            old.Sdt = dv.Sdt;
            old.TrangThai = dv.TrangThai;
            old.CCCD = dv.CCCD;
            old.DiaChi = dv.DiaChi;
            old.GhiChu = dv.GhiChu;

            db.SaveChanges();
        }
        public KhachHang GetKhachDangO(int phongId)
        {
            using var db = new AppDbContext();
            return db.KhachHangs
                .FirstOrDefault(x =>
                    x.PhongId == phongId &&
                    x.TrangThai == "Chưa thanh toán");
        }

        public void TaoDuLieuMau()
        {
            using var db = new AppDbContext();

            if (db.KhachHangs.Any()) return;

            db.KhachHangs.AddRange(
                new KhachHang
                {
                    TenKhach = "Nguyễn Văn A",
                    QuocTich = "Việt Nam",
                    Sdt = "09876521",
                    CCCD = "013827421021",
                    DiaChi = "Hà Nội",
                    TrangThai = "Chưa thanh toán",
                    PhongId = 2,
                    NgayVao = new DateOnly(2025,05,03),
                    NgayRa = new DateOnly(2025, 05, 06),
                    GhiChu = null
                },
                new KhachHang
                {
                    TenKhach = "Nguyễn Văn B",
                    QuocTich = "Việt Nam",
                    Sdt = "098764446",
                    CCCD = "013826478921",
                    DiaChi = "Hà Nội",
                    TrangThai = "Chưa thanh toán",
                    PhongId = 6,
                    NgayVao = new DateOnly(2025, 05, 03),
                    NgayRa = new DateOnly(2025, 05, 08),
                    GhiChu = null
                },
                new KhachHang
                {
                    TenKhach = "Nguyễn Văn C",
                    QuocTich = "Lào",
                    Sdt = "098785541",
                    CCCD = "876527421021",
                    DiaChi = null,
                    TrangThai = "Chưa thanh toán",
                    PhongId = 7,
                    NgayVao = new DateOnly(2025, 04, 30),
                    NgayRa = new DateOnly(2025, 05, 01),
                    GhiChu = null
                },
                new KhachHang
                {
                    TenKhach = "Nguyễn Văn D",
                    QuocTich = "Thái Lan",
                    Sdt = "09876891",
                    CCCD = "013876431021",
                    DiaChi = null,
                    TrangThai = "Chưa thanh toán",
                    PhongId = 8,
                    NgayVao = new DateOnly(2025, 05, 03),
                    NgayRa = new DateOnly(2025, 05, 06),
                    GhiChu = null
                },
                new KhachHang
                {
                    TenKhach = "Nguyễn Văn E",
                    QuocTich = "Việt Nam",
                    Sdt = "09876761",
                    CCCD = "010987521021",
                    DiaChi = "Hà Nội",
                    TrangThai = "Chưa thanh toán",
                    PhongId = 9,
                    NgayVao = new DateOnly(2025, 05, 03),
                    NgayRa = new DateOnly(2025, 05, 06),
                    GhiChu = null
                },
                new KhachHang
                {
                    TenKhach = "Nguyễn Thị A",
                    QuocTich = "Việt Nam",
                    Sdt = "09877758",
                    CCCD = "013827421089",
                    DiaChi = "Hà Nội",
                    TrangThai = "Đã thanh toán",
                    NgayVao = new DateOnly(2025, 05, 03),
                    NgayRa = new DateOnly(2025, 05, 06),
                    GhiChu = null
                },
                new KhachHang
                {
                    TenKhach = "Nguyễn Thị G",
                    QuocTich = "Nhật Bản",
                    Sdt = "09876981",
                    CCCD = "013459871021",
                    DiaChi = "Tokyo",
                    TrangThai = "Đã thanh toán",
                    NgayVao = new DateOnly(2025, 05, 03),
                    NgayRa = new DateOnly(2025, 05, 06),
                    GhiChu = null
                },
                new KhachHang
                {
                    TenKhach = "Nguyễn Văn H",
                    QuocTich = "Hoa Kỳ",
                    Sdt = "098766789",
                    CCCD = "013827568485",
                    DiaChi = "Hà Nội",
                    TrangThai = "Không xác định",
                    PhongId = 2,
                    NgayVao = null,
                    NgayRa = null,
                    GhiChu = "18/02/2026 Đơn 1"
                }
            );

            db.SaveChanges();
        }

    }
}

