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
    public partial class Dichvu : Form
    {
        private readonly DichVuService _service = new();
        private int _idDangChon = 0;
        public Dichvu()
        {
            InitializeComponent();
            LoadDgv();
        }

        private void Dichvu_Load(object sender, EventArgs e)
        {

        }
        private void LoadDgv()
        {
            dgvDichvu.DataSource = null;
            dgvDichvu.DataSource = _service.LayDanhSach();

            dgvDichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDichvu.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            if (dgvDichvu.Columns["Id"] != null)
                dgvDichvu.Columns["Id"].Visible = false;

            dgvDichvu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvDichvu.Columns["Gia"].HeaderText = "Giá";

            dgvDichvu.Columns["TenDichVu"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvDichvu.Columns["Gia"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvDichvu.Columns["Gia"].DefaultCellStyle.Format = "N0";
        }


        private void dgvDichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDichvu.Rows[e.RowIndex];
            _idDangChon = Convert.ToInt32(row.Cells["Id"].Value);
            textTendichvu.Text = row.Cells["TenDichVu"].Value.ToString();
            textGia.Text = row.Cells["Gia"].Value.ToString();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            _service.Them(textTendichvu.Text, decimal.Parse(textGia.Text));
            LoadDgv();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (_idDangChon == 0) return;

            _service.Sua(_idDangChon, textTendichvu.Text, decimal.Parse(textGia.Text));
            LoadDgv();
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (_idDangChon == 0) return;

            _service.Xoa(_idDangChon);
            LoadDgv();
        }
        private void buttonTim_Click(object sender, EventArgs e)
        {
            dgvDichvu.DataSource = _service.Tim(textTendichvu.Text);
        }


    }
}
