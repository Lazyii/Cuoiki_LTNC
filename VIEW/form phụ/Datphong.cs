using CK.BUS;
using CK.DAO.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK.VIEW.form_phụ
{
    public partial class Datphong : Form
    {
        private Phong _phong;
        private readonly PhongService _phongService = new PhongService();
        private readonly KhachHangService _khachService = new KhachHangService();

        private Phong _phongDangChon;
        public Datphong(Phong phong)
        {
            InitializeComponent();
            _phong = phong;
            Load += DatPhong_Load;
        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            var phongTron = _phongService.LayDanhSach().FirstOrDefault(p => p.TrangThai == "Trống");
            if (phongTron != null)
            {
                _phongDangChon = phongTron;
                textTenphong.Text = _phongDangChon.TenPhong;
                textLoaiphong.Text = _phongDangChon.LoaiPhong;
                textGia.Text = _phongDangChon.Gia.ToString("N0");
            }
            LoadComboQuocTich();
        }
        

        

        private void UpdateThongTinPhong()
        {
            if (_phongDangChon != null)
            {
                textLoaiphong.Text = _phongDangChon.LoaiPhong;
                textGia.Text = _phongDangChon.Gia.ToString("N0");
            }
        }

        // Load danh sách quốc tịch từ KhachHang có sẵn
        private void LoadComboQuocTich()
        {
            var dsQG = _khachService.LayDanhSach()
                        .Select(k => k.QuocTich)
                        .Where(q => !string.IsNullOrEmpty(q))
                        .Distinct()
                        .ToList();

            comboQuoctich.DataSource = dsQG;
        }

        private void dateNgayra_ValueChanged(object sender, EventArgs e)
        {
            UpdateNgayO();
        }

        private void dateNgayvao_ValueChanged(object sender, EventArgs e)
        {
            UpdateNgayO();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            UpdateNgayO();
        }

        private void UpdateNgayO()
        {
            if (dateNgayVao.Value <= dateNgayRa.Value)
            {
                TimeSpan ts = dateNgayRa.Value - dateNgayVao.Value;
                textNgayo.Text = (ts.Days+1).ToString();
            }
            else
            {
                textNgayo.Text = "0";
            }
        }


        // Button nhận phòng
        private void buttonNhanphong_Click(object sender, EventArgs e)
        {
            if (_phongDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phòng");
                return;
            }

            // Tạo khách mới
            KhachHang kh = new KhachHang
            {
                TenKhach = textTenkhach.Text.Trim(),
                CCCD = textCCCD.Text.Trim(),
                Sdt = textSDT.Text.Trim(),
                DiaChi = string.IsNullOrWhiteSpace(textDiachi.Text) ? null : textDiachi.Text,
                QuocTich = comboQuoctich.Text,
                TrangThai = "Chưa thanh toán",
                PhongId = _phongDangChon.PhongId
            };

            // **Gán DateOnly từ DateTimePicker**
            kh.NgayVao = DateOnly.FromDateTime(dateNgayVao.Value);
            kh.NgayRa = DateOnly.FromDateTime(dateNgayRa.Value);

            // Thêm khách
            string ketQua = _khachService.ThemKhach(kh);
            if (ketQua != "Thêm khách thành công")
            {
                MessageBox.Show(ketQua);
                return;
            }

            // Cập nhật trạng thái phòng Bận
            _phongDangChon.TrangThai = "Bận";
            _phongService.Sua(_phongDangChon.PhongId, _phongDangChon.TenPhong, _phongDangChon.LoaiPhong, _phongDangChon.TrangThai, _phongDangChon.Gia);

            MessageBox.Show("Nhận phòng thành công!");
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
