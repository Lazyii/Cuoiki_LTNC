namespace CK.VIEW.Uc
{
    partial class UcKhachhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonTimkiem = new Button();
            buttonCapnhat = new Button();
            label5 = new Label();
            textDiachi = new TextBox();
            label4 = new Label();
            dgvKhachhang = new DataGridView();
            textTrangThai = new TextBox();
            label3 = new Label();
            textSdt = new TextBox();
            textHoten = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textCCCD = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textGhichu = new TextBox();
            buttonXoa = new Button();
            button1 = new Button();
            textQuoctich = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhachhang).BeginInit();
            SuspendLayout();
            // 
            // buttonTimkiem
            // 
            buttonTimkiem.BackColor = Color.Coral;
            buttonTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTimkiem.Location = new Point(425, 148);
            buttonTimkiem.Name = "buttonTimkiem";
            buttonTimkiem.Size = new Size(75, 23);
            buttonTimkiem.TabIndex = 25;
            buttonTimkiem.Text = "Tìm kiếm";
            buttonTimkiem.UseVisualStyleBackColor = false;
            buttonTimkiem.Click += buttonTim_Click;
            // 
            // buttonCapnhat
            // 
            buttonCapnhat.BackColor = Color.Coral;
            buttonCapnhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCapnhat.Location = new Point(62, 148);
            buttonCapnhat.Name = "buttonCapnhat";
            buttonCapnhat.Size = new Size(75, 23);
            buttonCapnhat.TabIndex = 24;
            buttonCapnhat.Text = "Cập nhật";
            buttonCapnhat.UseVisualStyleBackColor = false;
            buttonCapnhat.Click += buttonThem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(277, 87);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 22;
            label5.Text = "Quốc tịch:";
            // 
            // textDiachi
            // 
            textDiachi.Location = new Point(345, 23);
            textDiachi.Multiline = true;
            textDiachi.Name = "textDiachi";
            textDiachi.Size = new Size(191, 52);
            textDiachi.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(277, 29);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 20;
            label4.Text = "Địa chỉ:";
            // 
            // dgvKhachhang
            // 
            dgvKhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachhang.Location = new Point(27, 193);
            dgvKhachhang.Name = "dgvKhachhang";
            dgvKhachhang.Size = new Size(509, 176);
            dgvKhachhang.TabIndex = 19;
            dgvKhachhang.CellClick += dgvKhachhang_CellClick;
            // 
            // textTrangThai
            // 
            textTrangThai.Location = new Point(87, 81);
            textTrangThai.Name = "textTrangThai";
            textTrangThai.ReadOnly = true;
            textTrangThai.Size = new Size(172, 23);
            textTrangThai.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 87);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 17;
            label3.Text = "Tthái:";
            // 
            // textSdt
            // 
            textSdt.Location = new Point(87, 52);
            textSdt.Name = "textSdt";
            textSdt.Size = new Size(172, 23);
            textSdt.TabIndex = 16;
            // 
            // textHoten
            // 
            textHoten.Location = new Point(87, 23);
            textHoten.Name = "textHoten";
            textHoten.Size = new Size(172, 23);
            textHoten.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 58);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 14;
            label2.Text = "SĐT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 13;
            label1.Text = "Họ tên:";
            // 
            // textCCCD
            // 
            textCCCD.Location = new Point(87, 110);
            textCCCD.Name = "textCCCD";
            textCCCD.Size = new Size(172, 23);
            textCCCD.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 116);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 27;
            label7.Text = "CCCD:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(277, 116);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 30;
            label8.Text = "Ghi chú:";
            // 
            // textGhichu
            // 
            textGhichu.Location = new Point(345, 110);
            textGhichu.Name = "textGhichu";
            textGhichu.Size = new Size(191, 23);
            textGhichu.TabIndex = 31;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.Coral;
            buttonXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.Location = new Point(309, 148);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 23);
            buttonXoa.TabIndex = 32;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(184, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonSua_Click;
            // 
            // textQuoctich
            // 
            textQuoctich.Location = new Point(345, 81);
            textQuoctich.Name = "textQuoctich";
            textQuoctich.Size = new Size(191, 23);
            textQuoctich.TabIndex = 34;
            textQuoctich.TextChanged += textBox1_TextChanged;
            // 
            // UcKhachhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textQuoctich);
            Controls.Add(button1);
            Controls.Add(buttonXoa);
            Controls.Add(textGhichu);
            Controls.Add(label8);
            Controls.Add(textCCCD);
            Controls.Add(label7);
            Controls.Add(buttonTimkiem);
            Controls.Add(buttonCapnhat);
            Controls.Add(label5);
            Controls.Add(textDiachi);
            Controls.Add(label4);
            Controls.Add(dgvKhachhang);
            Controls.Add(textTrangThai);
            Controls.Add(label3);
            Controls.Add(textSdt);
            Controls.Add(textHoten);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UcKhachhang";
            Size = new Size(563, 392);
            ((System.ComponentModel.ISupportInitialize)dgvKhachhang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTimkiem;
        private Button buttonCapnhat;
        private Label label5;
        private TextBox textDiachi;
        private Label label4;
        private DataGridView dgvKhachhang;
        private TextBox textTrangThai;
        private Label label3;
        private TextBox textSdt;
        private TextBox textHoten;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox textCCCD;
        private Label label7;
        private Label label8;
        private TextBox textGhichu;
        private Button buttonXoa;
        private Button button1;
        private TextBox textQuoctich;
    }
}
