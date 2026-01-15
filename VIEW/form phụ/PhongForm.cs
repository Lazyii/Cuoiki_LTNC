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

namespace CK.VIEW.form_phụ
{
    public partial class PhongForm : Form
    {
        private readonly PhongService _service = new();
        private int _idDangChon = 0;
        public PhongForm()
        {
            InitializeComponent();
            LoadDgv();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadDgv()
        {
            dgvPhong.DataSource = null;
            dgvPhong.DataSource = _service.LayDanhSach();

            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPhong.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            if (dgvPhong.Columns["PhongId"] != null)
                dgvPhong.Columns["PhongId"].Visible = false;

            dgvPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvPhong.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dgvPhong.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvPhong.Columns["Gia"].HeaderText = "Giá";

            dgvPhong.Columns["TenPhong"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvPhong.Columns["LoaiPhong"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvPhong.Columns["TrangThai"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvPhong.Columns["Gia"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvPhong.Columns["Gia"].DefaultCellStyle.Format = "N0";
        }


        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvPhong.Rows[e.RowIndex];
            _idDangChon = Convert.ToInt32(row.Cells["PhongId"].Value);
            textTenphong.Text = row.Cells["TenPhong"].Value.ToString();
            textLoaiphong.Text = row.Cells["LoaiPhong"].Value.ToString();
            textTrangthai.Text = row.Cells["TrangThai"].Value.ToString();
            textGia.Text = row.Cells["Gia"].Value.ToString();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textTenphong.Text))
            {
                MessageBox.Show("Tên phòng không được để trống");
                return;
            }

            decimal gia;
            if (!decimal.TryParse(textGia.Text, out gia))
            {
                MessageBox.Show("Giá không hợp lệ");
                return;
            }

            string kq = _service.ThemPhong(
                textLoaiphong.Text,
                textTenphong.Text.Trim(),
                gia
            );

            MessageBox.Show(kq);
            LoadDgv();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (_idDangChon == 0) return;

            _service.Sua(_idDangChon, textTenphong.Text, textLoaiphong.Text, textTrangthai.Text, decimal.Parse(textGia.Text));
            LoadDgv();
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null)
            {
                MessageBox.Show("Chọn phòng cần xóa");
                return;
            }

            int id = (int)dgvPhong.CurrentRow.Cells["PhongId"].Value;

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa phòng này?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            string kq = _service.XoaPhong(id);
            MessageBox.Show(kq);

            LoadDgv();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = _service.Tim(textTenphong.Text);
        }
    }
}
