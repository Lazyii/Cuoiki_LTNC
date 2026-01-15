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
    public partial class Thietbi : Form
    {
        private readonly ThietBiService _service = new();
        private int _idDangChon = 0;
        public Thietbi()
        {
            InitializeComponent();
            LoadDgv();
        }

        private void Thietbi_Load(object sender, EventArgs e)
        {

        }
        private void LoadDgv()
        {
            dgvThietbi.DataSource = null;
            dgvThietbi.DataSource = _service.LayDanhSach();

            dgvThietbi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvThietbi.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            if (dgvThietbi.Columns["Id"] != null)
                dgvThietbi.Columns["Id"].Visible = false;

            dgvThietbi.Columns["TenThietBi"].HeaderText = "Tên thiết bị";
            dgvThietbi.Columns["Gia"].HeaderText = "Giá";

            dgvThietbi.Columns["TenThietBi"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvThietbi.Columns["Gia"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvThietbi.Columns["Gia"].DefaultCellStyle.Format = "N0";
        }


        private void dgvThietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvThietbi.Rows[e.RowIndex];
            _idDangChon = Convert.ToInt32(row.Cells["Id"].Value);
            textTenthietbi.Text = row.Cells["TenThietbi"].Value.ToString();
            textGia.Text = row.Cells["Gia"].Value.ToString();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            _service.Them(textTenthietbi.Text, decimal.Parse(textGia.Text));
            LoadDgv();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (_idDangChon == 0) return;

            _service.Sua(_idDangChon, textTenthietbi.Text, decimal.Parse(textGia.Text));
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
            dgvThietbi.DataSource = _service.Tim(textTenthietbi.Text);
        }


    }
}
