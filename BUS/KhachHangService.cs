using CK.DAO;
using CK.DAO.ENTITY;
using CK.DAO.Repositories;
using System.Collections.Generic;

namespace CK.BUS
{
    public class KhachHangService
    {
        private readonly KhachHangRepository _khRepo = new();
        private readonly PhongRepository _phRepo = new();

        public List<KhachHang> LayDanhSach()
        {
            return _khRepo.GetAll();
        }
        public List<KhachHang> Tim(string ten) => _khRepo.TimKiem(ten);

        public string Them(string ten, string sdt, string tt,string cccd, string dchi, string qtich, string gchu)
        {
            if (!string.IsNullOrWhiteSpace(cccd))
            {
                if (_khRepo.TonTaiCCCD(cccd))
                    return "CCCD đã tồn tại trong hệ thống";
            }
            var kh = new KhachHang
            {
                TenKhach = ten,
                Sdt = sdt,
                TrangThai = tt, 
                CCCD = cccd,
                DiaChi = dchi,
                QuocTich = qtich,
                GhiChu = gchu,
                NgayRa = null,
                NgayVao = null
            };
            _khRepo.Them(kh);

            return "Thêm khách hàng thành công";
        }

        public KhachHang GetKhachDangO(int phongId)
        {
            return _khRepo.GetKhachDangO(phongId);
        }

        public string ThemKhach(KhachHang kh)
        {
            if (!string.IsNullOrWhiteSpace(kh.CCCD))
            {
                if (_khRepo.TonTaiCCCD(kh.CCCD))
                    return "CCCD đã tồn tại trong hệ thống";
            }
            // 1. Khách mới mặc định là Chưa thanh toán
            kh.TrangThai = "Chưa thanh toán";

            if (kh.PhongId == null)
                return "Phải chọn phòng khi nhận phòng";

            var phong = _phRepo.GetById(kh.PhongId.Value);

            if (phong == null)
                return "Phòng không tồn tại";

            // 2. Khi nhận phòng -> phòng PHẢI đang trống
            if (phong.TrangThai == "Bận")
                return "Phòng đang bận, không thể nhận phòng";

            // 3. Thêm khách
            _khRepo.Them(kh);

            // 4. Cập nhật phòng: Trống -> Bận
            _phRepo.CapNhatTrangThai(phong.PhongId, "Bận");

            return "Nhận phòng thành công";
        }

        public void Xoa(int id) => _khRepo.Xoa(id);
        public void Sua(int id, string ten, string dchi, string gchu, string cc, string sdt, string qt, string tt)
        {
            _khRepo.Sua(new KhachHang { KhachHangId = id, TenKhach = ten, DiaChi = dchi, GhiChu = gchu, CCCD = cc, Sdt = sdt, QuocTich = qt, TrangThai = tt});
        }

        public KhachHangService()
        {
            _khRepo = new KhachHangRepository();
            _khRepo.TaoDuLieuMau();
        }
    }
}
