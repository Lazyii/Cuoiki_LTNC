namespace CK.VIEW.form_phụ
{
    partial class Dichvu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonThem = new Button();
            buttonTim = new Button();
            textGia = new TextBox();
            label2 = new Label();
            textTendichvu = new TextBox();
            label1 = new Label();
            dgvDichvu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDichvu).BeginInit();
            SuspendLayout();
            // 
            // buttonSua
            // 
            buttonSua.BackColor = SystemColors.ActiveCaption;
            buttonSua.Cursor = Cursors.Hand;
            buttonSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSua.Location = new Point(295, 144);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(75, 23);
            buttonSua.TabIndex = 27;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = SystemColors.ActiveCaption;
            buttonXoa.Cursor = Cursors.Hand;
            buttonXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.Location = new Point(139, 144);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 23);
            buttonXoa.TabIndex = 26;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = SystemColors.ActiveCaption;
            buttonThem.Cursor = Cursors.Hand;
            buttonThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThem.Location = new Point(295, 104);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(75, 23);
            buttonThem.TabIndex = 25;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonTim
            // 
            buttonTim.BackColor = SystemColors.ActiveCaption;
            buttonTim.Cursor = Cursors.Hand;
            buttonTim.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTim.Location = new Point(139, 104);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(75, 23);
            buttonTim.TabIndex = 24;
            buttonTim.Text = "Tìm";
            buttonTim.UseVisualStyleBackColor = false;
            buttonTim.Click += buttonTim_Click;
            // 
            // textGia
            // 
            textGia.Location = new Point(127, 53);
            textGia.Name = "textGia";
            textGia.Size = new Size(161, 23);
            textGia.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 59);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 22;
            label2.Text = "Giá:";
            // 
            // textTendichvu
            // 
            textTendichvu.Location = new Point(127, 24);
            textTendichvu.Name = "textTendichvu";
            textTendichvu.Size = new Size(161, 23);
            textTendichvu.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 20;
            label1.Text = "Tên dịch vụ:";
            // 
            // dgvDichvu
            // 
            dgvDichvu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichvu.Location = new Point(36, 206);
            dgvDichvu.Name = "dgvDichvu";
            dgvDichvu.Size = new Size(386, 195);
            dgvDichvu.TabIndex = 28;
            dgvDichvu.CellClick += dgvDichvu_CellClick;
            // 
            // Dichvu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 436);
            Controls.Add(dgvDichvu);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(buttonTim);
            Controls.Add(textGia);
            Controls.Add(label2);
            Controls.Add(textTendichvu);
            Controls.Add(label1);
            Name = "Dichvu";
            Text = "Dichvu";
            Load += Dichvu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDichvu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonThem;
        private Button buttonTim;
        private TextBox textGia;
        private Label label2;
        private TextBox textTendichvu;
        private Label label1;
        private DataGridView dgvDichvu;
    }
}