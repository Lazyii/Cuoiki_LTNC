using CK.VIEW.Uc;
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
    public partial class MainForm : Form
    {
        private Dictionary<string, UserControl> _ucCache
            = new Dictionary<string, UserControl>();

        public MainForm()
        {
            InitializeComponent();

            InitMenu();      // gắn click + tag
            InitHover();     // hiệu ứng hover
        }

        // =========================
        // INIT MENU
        // =========================
        private void InitMenu()
        {
            // GÁN TAG (có thể gán trong Designer)
            panelBaocao.Tag = "Baocao";
            panelDanhsachphong.Tag = "Danhsachphong";
            panelNhanvien.Tag = "Nhanvien";
            panelDieukhien.Tag = "Dieukhien";
            panelDatphong.Tag = "Datphong";
            panelKhachhang.Tag = "Khachhang";
            panelThongke.Tag = "Thongke";

            // GẮN CLICK CHUNG
            panelDieukhien.Click += Menu_Click;
            panelDatphong.Click += Menu_Click;
            panelKhachhang.Click += Menu_Click;
            panelDanhsachphong.Click += Menu_Click;
            panelBaocao.Click += Menu_Click;
            panelNhanvien.Click += Menu_Click;
            panelThongke.Click += Menu_Click;

            // CLICK XUYÊN CHO LABEL / ICON
            BindChildren(panelDieukhien);
            BindChildren(panelDatphong);
            BindChildren(panelKhachhang);
            BindChildren(panelDanhsachphong);
            BindChildren(panelNhanvien);
            BindChildren(panelBaocao);
            BindChildren(panelThongke);
        }

        private void BindChildren(Panel panel)
        {
            foreach (Control c in panel.Controls)
                c.Click += Menu_Click;
        }

        // =========================
        // MENU CLICK
        // =========================
        private void Menu_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel
                ?? ((Control)sender).Parent as Panel;

            if (panel == null || panel.Tag == null) return;

            SetActiveMenu(panel);

            switch (panel.Tag.ToString())
            {
                case "Dieukhien":
                    LoadUC("Dieukhien", () => new UcDieukhien());
                    break;

                case "Datphong":
                    LoadUC("Datphong", () => new UcDatphong());
                    break;

                case "Khachhang":
                    LoadUC("Khachhang", () => new UcKhachhang());
                    break;
                case "Danhsachphong":
                    LoadUC("Danhsachphong", () => new UcDanhsachphong());
                    break;

                case "Nhanvien":
                    LoadUC("Nhanvien", () => new UcNhanvien());
                    break;
                case "Baocao":
                    LoadUC("Baocao", () => new UcBaocao());
                    break;

                case "Thongke":
                    LoadUC("Thongke", () => new UcThongke());
                    break;
            }
        }

        // =========================
        // LOAD USERCONTROL
        // =========================
        private void LoadUC(string key, Func<UserControl> create)
        {
            if (!_ucCache.ContainsKey(key))
                _ucCache[key] = create();

            panelContent.Controls.Clear();

            UserControl uc = _ucCache[key];
            uc.Dock = DockStyle.Fill;

            panelContent.Controls.Add(uc);
        }

        // =========================
        // ACTIVE MENU
        // =========================
        private void SetActiveMenu(Panel selected)
        {
            foreach (Control c in panelMenu.Controls)
            {
                if (c is Panel p)
                    p.BackColor = Color.Transparent;
            }

            selected.BackColor = Color.FromArgb(60, 60, 65);
        }

        // =========================
        // HOVER EFFECT (OPTIONAL)
        // =========================
        private void InitHover()
        {
            foreach (Control c in panelMenu.Controls)
            {
                if (c is Panel p)
                {
                    p.MouseEnter += (s, e) =>
                    {
                        if (p.BackColor == Color.Transparent)
                            p.BackColor = Color.FromArgb(45, 45, 48);
                    };

                    p.MouseLeave += (s, e) =>
                    {
                        if (p.BackColor == Color.FromArgb(45, 45, 48))
                            p.BackColor = Color.Transparent;
                    };
                }
            }
        }

        // =========================
        // LOAD MẶC ĐỊNH
        // =========================
        private void MainForm_Load(object sender, EventArgs e)
        {
            Menu_Click(panelDieukhien, EventArgs.Empty);
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panelDieukhien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
