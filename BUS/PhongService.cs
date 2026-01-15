using CK.DAO.ENTITY;
using CK.DAO.Repositories;
using System.Collections.Generic;

namespace CK.BUS
{
    public class PhongService
    {
        private readonly PhongRepository _repo = new();

        public List<Phong> LayDanhSach()
        {
            return _repo.GetAll()
                        .OrderBy(p => p.TrangThai == "Trống" ? 0 : 1)
                        .ToList();
        }


        
        public string ThemPhong(string loai, string ten, decimal gia)
        {
            // 1. kiểm tra trùng tên
            if (_repo.TonTaiTenPhong(ten))
                return "Tên phòng đã tồn tại";

            // 2. tạo phòng mới → mặc định Trống
            Phong p = new Phong
            {
                LoaiPhong = loai,
                TenPhong = ten,
                Gia = gia,
                TrangThai = "Trống"
            };

            _repo.Them(p);
            return "Thêm phòng thành công";
        }
        public void Sua(int id, string ten, string loai, string trangthai, decimal gia)
        {
            _repo.Sua(new Phong { PhongId = id, TenPhong = ten, LoaiPhong = loai, TrangThai = trangthai, Gia = gia });
        }

        public string XoaPhong(int id)
        {
            var phong = _repo.GetById(id);

            if (phong == null)
                return "Phòng không tồn tại";

            if (phong.TrangThai == "Bận")
                return "Phòng đang bận, không thể xóa";

            _repo.Xoa(id);
            return "Xóa phòng thành công";
        }


        public List<Phong> Tim(string ten) => _repo.TimKiem(ten);
        public PhongService()
        {
            _repo = new PhongRepository();
            _repo.TaoPhongMacDinh();
        }
        public Phong GetById(int id)
        {
            return _repo.GetById(id);
        }
    }
}
