using CK.DAO.ENTITY;
using CK.DAO.Repositories;
using System.Collections.Generic;

namespace CK.BUS
{
    public class DichVuService
    {
        private readonly DichVuRepository _repo = new();

        public List<DichVu> LayDanhSach()
        {
            return _repo.GetAll();
        }

        public void Them(string ten, decimal gia)
        {
            _repo.Them(new DichVu
            {
                TenDichVu = ten,
                Gia = gia
            });
        }
        public void Sua(int id, string ten, decimal gia)
        {
            _repo.Sua(new DichVu { Id = id, TenDichVu = ten, Gia = gia });
        }

        public void Xoa(int id) => _repo.Xoa(id);

        public List<DichVu> Tim(string ten) => _repo.TimKiem(ten);
        public DichVuService()
        {
            _repo = new DichVuRepository();
            _repo.TaoDichVuMacDinh();
        }

    }
}
