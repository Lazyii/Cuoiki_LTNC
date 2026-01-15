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


namespace CK.VIEW
{
    public partial class Login : Form
    {
        private readonly NhanVienService _service;


        public Login()
        {
            InitializeComponent();
            _service = new NhanVienService();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void quenpass_LinkClicked(object sender, EventArgs e)
        {
        }


        private void buttonDangnhap_Click(object sender, EventArgs e)
        {
            string tk = textTaikhoan.Text.Trim();
            string mk = textMatkhau.Text.Trim();

            if (_service.DangNhap(tk, mk))
            {
                this.Hide();
                MainForm main = new MainForm();
                main.FormClosed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show(
                    "Sai tài khoản hoặc mật khẩu",
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


    }
}
