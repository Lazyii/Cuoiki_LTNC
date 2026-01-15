namespace CK.VIEW.form_phụ
{
    partial class PhongForm
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
            label1 = new Label();
            textTenphong = new TextBox();
            textLoaiphong = new TextBox();
            label2 = new Label();
            textTrangthai = new TextBox();
            label3 = new Label();
            buttonTim = new Button();
            buttonThem = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            dgvPhong = new DataGridView();
            label4 = new Label();
            textGia = new TextBox();
            fontDialog1 = new FontDialog();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 0;
            label1.Text = "Tên phòng:";
            // 
            // textTenphong
            // 
            textTenphong.Location = new Point(100, 14);
            textTenphong.Name = "textTenphong";
            textTenphong.Size = new Size(161, 23);
            textTenphong.TabIndex = 1;
            // 
            // textLoaiphong
            // 
            textLoaiphong.Location = new Point(100, 43);
            textLoaiphong.Name = "textLoaiphong";
            textLoaiphong.Size = new Size(161, 23);
            textLoaiphong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 2;
            label2.Text = "Loại phòng:";
            // 
            // textTrangthai
            // 
            textTrangthai.Location = new Point(100, 72);
            textTrangthai.Name = "textTrangthai";
            textTrangthai.ReadOnly = true;
            textTrangthai.Size = new Size(161, 23);
            textTrangthai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái:";
            // 
            // buttonTim
            // 
            buttonTim.BackColor = SystemColors.ActiveCaption;
            buttonTim.Cursor = Cursors.Hand;
            buttonTim.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTim.Location = new Point(118, 159);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(75, 23);
            buttonTim.TabIndex = 6;
            buttonTim.Text = "Tìm";
            buttonTim.UseVisualStyleBackColor = false;
            buttonTim.Click += buttonTim_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = SystemColors.ActiveCaption;
            buttonThem.Cursor = Cursors.Hand;
            buttonThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThem.Location = new Point(274, 159);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(75, 23);
            buttonThem.TabIndex = 7;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = SystemColors.ActiveCaption;
            buttonXoa.Cursor = Cursors.Hand;
            buttonXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.Location = new Point(118, 188);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 23);
            buttonXoa.TabIndex = 8;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = SystemColors.ActiveCaption;
            buttonSua.Cursor = Cursors.Hand;
            buttonSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSua.Location = new Point(274, 188);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(75, 23);
            buttonSua.TabIndex = 9;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // dgvPhong
            // 
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Location = new Point(27, 226);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.Size = new Size(415, 218);
            dgvPhong.TabIndex = 10;
            dgvPhong.CellClick += dgvPhong_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 11;
            label4.Text = "Giá:";
            label4.Click += label4_Click;
            // 
            // textGia
            // 
            textGia.Location = new Point(100, 101);
            textGia.Name = "textGia";
            textGia.Size = new Size(161, 23);
            textGia.TabIndex = 12;
            // 
            // PhongForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 436);
            Controls.Add(textGia);
            Controls.Add(label4);
            Controls.Add(dgvPhong);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(buttonTim);
            Controls.Add(textTrangthai);
            Controls.Add(label3);
            Controls.Add(textLoaiphong);
            Controls.Add(label2);
            Controls.Add(textTenphong);
            Controls.Add(label1);
            Name = "PhongForm";
            Text = "Phòng";
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textTenphong;
        private TextBox textLoaiphong;
        private Label label2;
        private TextBox textTrangthai;
        private Label label3;
        private Button buttonTim;
        private Button buttonThem;
        private Button buttonXoa;
        private Button buttonSua;
        private DataGridView dgvPhong;
        private Label label4;
        private TextBox textGia;
        private FontDialog fontDialog1;
    }
}