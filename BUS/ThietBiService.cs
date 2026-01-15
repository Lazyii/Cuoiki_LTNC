using CK.DAO.ENTITY;
using CK.DAO.Repositories;
using System.Collections.Generic;

namespace CK.BUS
{
    public class ThietBiService
    {
        private readonly ThietBiRepository _repo = new();

        public List<ThietBi> LayDanhSach()
        {
            return _repo.GetAll();
        }

        public void Them(string ten, decimal gia)
        {
            _repo.Them(new ThietBi
            {
                TenThietBi = ten,
                Gia = gia
            });
        }
        public void Sua(int id, string ten, decimal gia)
        {
            _repo.Sua(new ThietBi { Id = id, TenThietBi = ten, Gia = gia });
        }

        public void Xoa(int id) => _repo.Xoa(id);

        public List<ThietBi> Tim(string ten) => _repo.TimKiem(ten);
        public ThietBiService()
        {
            _repo = new ThietBiRepository();
            _repo.TaoThietBiMacDinh();
        }

    }
}
