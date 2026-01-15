using CK.BUS;
using CK.DAO.ENTITY;
using CK.VIEW.form_phụ;
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
    public partial class UcDanhsachphong : UserControl
    {
        private readonly PhongService _phongService = new PhongService();

        public UcDanhsachphong()
        {
            InitializeComponent();
            Load += UcDanhSachPhong_Load;
        }

        private void UcDanhSachPhong_Load(object sender, System.EventArgs e)
        {
            HienThiPhong();
        }

        private void HienThiPhong()
        {
            flowLayoutDanhsachphong.Controls.Clear();

            var dsPhong = _phongService.LayDanhSach();

            foreach (var phong in dsPhong)
            {
                Button btn = new Button();
                btn.Text = phong.TenPhong;
                btn.Width = 100;
                btn.Height = 80;
                btn.Font = new Font("Arial", 10, FontStyle.Bold);
                btn.ForeColor = Color.White;

                // Màu theo trạng thái
                if (phong.TrangThai == "Trống")
                    btn.BackColor = Color.LightGreen;
                else
                    btn.BackColor = Color.Red;

                // Lưu thông tin phòng vào Tag
                btn.Tag = phong;

                // Click mở form tương ứng
                btn.Click += (s, e) =>
                {
                    var p = (Phong)((Button)s).Tag;

                    if (p.TrangThai == "Trống")
                    {
                        Datphong f = new Datphong(p);
                        f.ShowDialog();
                    }
                    else
                    {
                        Thongtinphong f = new Thongtinphong(p);
                        f.ShowDialog();
                    }

                    // refresh lại danh sách sau khi form đóng
                    HienThiPhong();
                };

                flowLayoutDanhsachphong.Controls.Add(btn);
            }
        }
    }
}
