using CK.BUS;
using CK.DAO.ENTITY;
using System;
using System.Windows.Forms;

namespace CK.VIEW.form_phụ
{
    public partial class Thongtinphong : Form
    {
        private readonly PhongService _phongService = new();
        private readonly KhachHangService _khachService = new();
        private readonly DichVuService _dichVuService = new();


        private Phong _phong;   // ⭐ NGUỒN DỮ LIỆU DUY NHẤT

        public Thongtinphong(Phong phong)
        {
            InitializeComponent();
            _phong = phong;
            LoadThongTin();
            LoadDichVu();
        }

        private void LoadThongTin()
        {
            if (_phong == null) return;

            // ====== PHÒNG ======
            textTenphong.Text = _phong.TenPhong;
            textLoaiphong.Text = _phong.LoaiPhong;
            textGia.Text = _phong.Gia.ToString("N0");

            // ====== KHÁCH ĐANG Ở ======
            var kh = _khachService.GetKhachDangO(_phong.PhongId);
            if (kh == null) return;

            textTenKhach.Text = kh.TenKhach;
            textSDT.Text = kh.Sdt;
            textQuoctich.Text = kh.QuocTich;
            textDiachi.Text = kh.DiaChi;
            textCCCD.Text = kh.CCCD;

            dateNgayvao.Value = kh.NgayVao?.ToDateTime(TimeOnly.MinValue) ?? DateTime.Now;
            dateNgayra.Value = kh.NgayRa?.ToDateTime(TimeOnly.MinValue) ?? DateTime.Now;

            TinhTien();
        }

        private void TinhTien()
        {
            int soNgay = (dateNgayra.Value.Date - dateNgayvao.Value.Date).Days + 1;
            if (soNgay < 1) soNgay = 1;

            textNgayo.Text = soNgay.ToString();

            if (decimal.TryParse(textGia.Text.Replace(",", ""), out decimal gia))
            {
                textTongphong.Text = (soNgay * gia).ToString("N0");
            }
        }

        private void dateNgayvao_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void dateNgayra_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
        private void label19_Click(object sender, EventArgs e)
        {
            
        }
        private void LoadDichVu()
        {
            var ds = _dichVuService.LayDanhSach();

            comboDichvu.DataSource = ds;
            comboDichvu.DisplayMember = "TenDichVu";
            comboDichvu.ValueMember = "Id";
            comboDichvu.SelectedIndex = -1;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (comboDichvu.SelectedItem is not DichVu dv) return;

            dgvDichvu.Rows.Add(
                dv.TenDichVu,
                dv.Gia,
                dv.Id
            );

            TinhTongDichVu();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgvDichvu.CurrentRow == null) return;

            dgvDichvu.Rows.Remove(dgvDichvu.CurrentRow);

            TinhTongDichVu();
        }
        private void TinhTongDichVu()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvDichvu.Rows)
            {
                if (row.Cells["colGia"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["colGia"].Value);
                }
            }

            textTongdichvu.Text = tong.ToString("N0");
        }


    }
}
