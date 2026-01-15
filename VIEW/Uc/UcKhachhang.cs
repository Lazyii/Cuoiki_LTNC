using CK.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK.VIEW.Uc
{
    public partial class UcKhachhang : UserControl
    {
        private readonly KhachHangService _service = new();
        private int _idDangChon = 0;
        public UcKhachhang()
        {
            InitializeComponent();
            LoadDgv();
        }
        private void LoadDgv()
        {
            dgvKhachhang.DataSource = null;
            dgvKhachhang.DataSource = _service.LayDanhSach();

            dgvKhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvKhachhang.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            if (dgvKhachhang.Columns["KhachHangId"] != null)
                dgvKhachhang.Columns["KhachHangId"].Visible = false;

            dgvKhachhang.Columns["TenKhach"].HeaderText = "Tên Khách";
            dgvKhachhang.Columns["QuocTich"].HeaderText = "Quốc tịch";
            dgvKhachhang.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgvKhachhang.Columns["CCCD"].HeaderText = "CCCD/Passport";
            dgvKhachhang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachhang.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvKhachhang.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvKhachhang.Columns["NgayVao"].HeaderText = "Ngày vào";
            dgvKhachhang.Columns["NgayRa"].HeaderText = "Ngày ra";

            dgvKhachhang.Columns["TenKhach"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvKhachhang.Columns["QuocTich"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKhachhang.Columns["Sdt"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKhachhang.Columns["CCCD"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKhachhang.Columns["DiaChi"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKhachhang.Columns["TrangThai"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKhachhang.Columns["GhiChu"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKhachhang.Columns["NgayVao"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKhachhang.Columns["NgayRa"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

        }
        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvKhachhang.Rows[e.RowIndex];
            _idDangChon = Convert.ToInt32(row.Cells["KhachHangId"].Value);
            textHoten.Text = row.Cells["TenKhach"].Value.ToString();
            textSdt.Text = row.Cells["Sdt"].Value.ToString();
            textTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            textCCCD.Text = row.Cells["CCCD"].Value.ToString();
            textDiachi.Text = row.Cells["Sdt"].Value.ToString();
            textGhichu.Text = row.Cells["GhiChu"]?.Value?.ToString() ?? "";
            textQuoctich.Text = row.Cells["QuocTich"].Value.ToString();
        }
        private void buttonTim_Click(object sender, EventArgs e)
        {
            dgvKhachhang.DataSource = _service.Tim(textHoten.Text);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            _service.Them(textHoten.Text, textSdt.Text, textTrangThai.Text, textCCCD.Text, textDiachi.Text, textQuoctich.Text, textGhichu.Text);
            LoadDgv();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (_idDangChon == 0) return;

            _service.Sua(_idDangChon, textHoten.Text, textDiachi.Text, textGhichu.Text, textCCCD.Text, textSdt.Text, textQuoctich.Text, textTrangThai.Text);
            LoadDgv();
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (_idDangChon == 0) return;

            _service.Xoa(_idDangChon);
            LoadDgv();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
