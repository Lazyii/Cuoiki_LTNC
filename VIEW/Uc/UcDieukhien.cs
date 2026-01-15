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

namespace CK.VIEW
{
    public partial class UcDieukhien : UserControl
    {
        public UcDieukhien()
        {
            InitializeComponent();
            AddClickEvent(panelPHONG, panelPHONG_MouseDown);
            AddClickEvent(panelTHIETBI, panelTHIETBI_MouseDown);
            AddClickEvent(panelDICHVU, panelDICHVU_MouseDown);
            AddClickEvent(panelTAIKHOAN, panelTAIKHOAN_MouseDown);
        }

        private void UcDieukhien_Load(object sender, EventArgs e)
        {

        }

        private void panelPHONG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UcDieukhien_Click(object sender, EventArgs e)
        {

        }

        private void panelTHIETBI_MouseDown(object sender, EventArgs e)
        {
            using (Thietbi frm = new Thietbi())
            {
                frm.ShowDialog();
            }
        }

        private void panelTAIKHOAN_MouseDown(object sender, EventArgs e)
        {
            using (Taikhoan frm = new Taikhoan())
            {
                frm.ShowDialog();
            }
        }

        private void panelDICHVU_MouseDown(object sender, EventArgs e)
        {
            using (Dichvu frm = new Dichvu())
            {
                frm.ShowDialog();
            }
        }

        private void panelPHONG_MouseDown(object sender, EventArgs e)
        {
            using (PhongForm frm = new PhongForm())
            {
                frm.ShowDialog();
            }
        }
        private void AddClickEvent(Control parent, EventHandler handler)
        {
            parent.Click += handler;
            foreach (Control c in parent.Controls)
            {
                AddClickEvent(c, handler);
            }
        }

    }
}
