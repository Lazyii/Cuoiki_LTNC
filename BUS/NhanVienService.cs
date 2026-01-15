using CK.DAO.ENTITY;
using CK.DAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.BUS
{
    public class NhanVienService
    {
        private readonly NhanVienRepository _repo = new();

        public NhanVienService()
        {
            _repo = new NhanVienRepository();
            _repo.TaoTaiKhoanMacDinh(); // tạo admin/123 nếu chưa có
        }

        public bool DangNhap(string tk, string mk)
        {
            NhanVien nv = _repo.DangNhap(tk, mk);
            return nv != null;
        }

        public NhanVien DangNhapLayNhanVien(string tk, string mk)
        {
            return _repo.DangNhap(tk, mk);
        }
    }
}
