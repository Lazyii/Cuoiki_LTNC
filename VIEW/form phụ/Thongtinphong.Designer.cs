namespace CK.VIEW.form_phụ
{
    partial class Thongtinphong
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
            textTenKhach = new TextBox();
            label2 = new Label();
            textTenphong = new TextBox();
            label1 = new Label();
            textCCCD = new TextBox();
            label3 = new Label();
            textLoaiphong = new TextBox();
            label4 = new Label();
            textSDT = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textDiachi = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboDichvu = new ComboBox();
            buttonThem = new Button();
            buttonXoa = new Button();
            dgvDichvu = new DataGridView();
            colTenDV = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            textGiamgia = new TextBox();
            label12 = new Label();
            textNgayo = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textGia = new TextBox();
            label15 = new Label();
            textTongphong = new TextBox();
            label16 = new Label();
            textTongdichvu = new TextBox();
            label17 = new Label();
            textTonggiamgia = new TextBox();
            label18 = new Label();
            textTong = new TextBox();
            buttonDoiphong = new Button();
            buttonTraphong = new Button();
            buttonInhoadon = new Button();
            comboPhong = new ComboBox();
            label19 = new Label();
            textQuoctich = new TextBox();
            dateNgayvao = new DateTimePicker();
            dateNgayra = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvDichvu).BeginInit();
            SuspendLayout();
            // 
            // textTenKhach
            // 
            textTenKhach.Location = new Point(285, 12);
            textTenKhach.Name = "textTenKhach";
            textTenKhach.ReadOnly = true;
            textTenKhach.Size = new Size(160, 23);
            textTenKhach.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 20);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Tên khách:";
            // 
            // textTenphong
            // 
            textTenphong.Location = new Point(84, 12);
            textTenphong.Name = "textTenphong";
            textTenphong.ReadOnly = true;
            textTenphong.Size = new Size(110, 23);
            textTenphong.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Tên phòng:";
            // 
            // textCCCD
            // 
            textCCCD.Location = new Point(285, 41);
            textCCCD.Name = "textCCCD";
            textCCCD.ReadOnly = true;
            textCCCD.Size = new Size(160, 23);
            textCCCD.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(213, 49);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "CCCD:";
            // 
            // textLoaiphong
            // 
            textLoaiphong.Location = new Point(84, 41);
            textLoaiphong.Name = "textLoaiphong";
            textLoaiphong.ReadOnly = true;
            textLoaiphong.Size = new Size(110, 23);
            textLoaiphong.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 49);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "Loại phòng:";
            // 
            // textSDT
            // 
            textSDT.Location = new Point(285, 70);
            textSDT.Name = "textSDT";
            textSDT.ReadOnly = true;
            textSDT.Size = new Size(160, 23);
            textSDT.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(213, 78);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 14;
            label5.Text = "SĐT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 78);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 12;
            label6.Text = "Ngày vào:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(213, 107);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 18;
            label7.Text = "Quốc tịch:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 107);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 16;
            label8.Text = "Ngày ra:";
            // 
            // textDiachi
            // 
            textDiachi.Location = new Point(84, 128);
            textDiachi.Name = "textDiachi";
            textDiachi.ReadOnly = true;
            textDiachi.Size = new Size(361, 23);
            textDiachi.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 136);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 20;
            label9.Text = "Địa chỉ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 170);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(10, 165);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 23;
            label11.Text = "Dịch vụ:";
            // 
            // comboDichvu
            // 
            comboDichvu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDichvu.FormattingEnabled = true;
            comboDichvu.Location = new Point(84, 157);
            comboDichvu.Name = "comboDichvu";
            comboDichvu.Size = new Size(195, 23);
            comboDichvu.TabIndex = 24;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = SystemColors.MenuHighlight;
            buttonThem.Cursor = Cursors.Hand;
            buttonThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThem.Location = new Point(289, 155);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(75, 23);
            buttonThem.TabIndex = 25;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = SystemColors.MenuHighlight;
            buttonXoa.Cursor = Cursors.Hand;
            buttonXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.Location = new Point(370, 155);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 23);
            buttonXoa.TabIndex = 26;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // dgvDichvu
            // 
            dgvDichvu.AllowUserToAddRows = false;
            dgvDichvu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichvu.Columns.AddRange(new DataGridViewColumn[] { colTenDV, colGia });
            dgvDichvu.Location = new Point(84, 184);
            dgvDichvu.MultiSelect = false;
            dgvDichvu.Name = "dgvDichvu";
            dgvDichvu.ReadOnly = true;
            dgvDichvu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichvu.Size = new Size(301, 57);
            dgvDichvu.TabIndex = 27;
            // 
            // colTenDV
            // 
            colTenDV.HeaderText = "Tên dịch vụ";
            colTenDV.Name = "colTenDV";
            colTenDV.ReadOnly = true;
            // 
            // colGia
            // 
            colGia.HeaderText = "Giá";
            colGia.Name = "colGia";
            colGia.ReadOnly = true;
            // 
            // textGiamgia
            // 
            textGiamgia.Location = new Point(84, 247);
            textGiamgia.Name = "textGiamgia";
            textGiamgia.Size = new Size(110, 23);
            textGiamgia.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 255);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 28;
            label12.Text = "Giảm giá %:";
            // 
            // textNgayo
            // 
            textNgayo.Location = new Point(84, 276);
            textNgayo.Name = "textNgayo";
            textNgayo.ReadOnly = true;
            textNgayo.Size = new Size(32, 23);
            textNgayo.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(10, 284);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 30;
            label13.Text = "Ngày ở:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(133, 284);
            label14.Name = "label14";
            label14.Size = new Size(15, 15);
            label14.TabIndex = 32;
            label14.Text = "X";
            // 
            // textGia
            // 
            textGia.Location = new Point(167, 276);
            textGia.Name = "textGia";
            textGia.ReadOnly = true;
            textGia.Size = new Size(100, 23);
            textGia.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(285, 279);
            label15.Name = "label15";
            label15.Size = new Size(25, 25);
            label15.TabIndex = 34;
            label15.Text = "=";
            // 
            // textTongphong
            // 
            textTongphong.Location = new Point(327, 276);
            textTongphong.Name = "textTongphong";
            textTongphong.ReadOnly = true;
            textTongphong.Size = new Size(100, 23);
            textTongphong.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(249, 313);
            label16.Name = "label16";
            label16.Size = new Size(52, 15);
            label16.TabIndex = 36;
            label16.Text = "Dịch vụ:";
            // 
            // textTongdichvu
            // 
            textTongdichvu.Location = new Point(327, 305);
            textTongdichvu.Name = "textTongdichvu";
            textTongdichvu.ReadOnly = true;
            textTongdichvu.Size = new Size(100, 23);
            textTongdichvu.TabIndex = 37;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(230, 342);
            label17.Name = "label17";
            label17.Size = new Size(71, 15);
            label17.TabIndex = 38;
            label17.Text = "Giảm giá %:";
            // 
            // textTonggiamgia
            // 
            textTonggiamgia.Location = new Point(327, 334);
            textTonggiamgia.Name = "textTonggiamgia";
            textTonggiamgia.ReadOnly = true;
            textTonggiamgia.Size = new Size(100, 23);
            textTonggiamgia.TabIndex = 39;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(257, 371);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 40;
            label18.Text = "TỔNG:";
            // 
            // textTong
            // 
            textTong.Location = new Point(327, 363);
            textTong.Name = "textTong";
            textTong.ReadOnly = true;
            textTong.Size = new Size(100, 23);
            textTong.TabIndex = 41;
            // 
            // buttonDoiphong
            // 
            buttonDoiphong.BackColor = Color.IndianRed;
            buttonDoiphong.Cursor = Cursors.Hand;
            buttonDoiphong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDoiphong.Location = new Point(269, 393);
            buttonDoiphong.Name = "buttonDoiphong";
            buttonDoiphong.Size = new Size(85, 31);
            buttonDoiphong.TabIndex = 42;
            buttonDoiphong.Text = "Đổi phòng";
            buttonDoiphong.UseVisualStyleBackColor = false;
            // 
            // buttonTraphong
            // 
            buttonTraphong.BackColor = Color.IndianRed;
            buttonTraphong.Cursor = Cursors.Hand;
            buttonTraphong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTraphong.Location = new Point(360, 393);
            buttonTraphong.Name = "buttonTraphong";
            buttonTraphong.Size = new Size(85, 31);
            buttonTraphong.TabIndex = 43;
            buttonTraphong.Text = "Trả phòng";
            buttonTraphong.UseVisualStyleBackColor = false;
            // 
            // buttonInhoadon
            // 
            buttonInhoadon.BackColor = Color.IndianRed;
            buttonInhoadon.Cursor = Cursors.Hand;
            buttonInhoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInhoadon.Location = new Point(326, 247);
            buttonInhoadon.Name = "buttonInhoadon";
            buttonInhoadon.Size = new Size(101, 25);
            buttonInhoadon.TabIndex = 44;
            buttonInhoadon.Text = "In hóa đơn";
            buttonInhoadon.UseVisualStyleBackColor = false;
            // 
            // comboPhong
            // 
            comboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPhong.FormattingEnabled = true;
            comboPhong.Location = new Point(84, 398);
            comboPhong.Name = "comboPhong";
            comboPhong.Size = new Size(179, 23);
            comboPhong.TabIndex = 46;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(12, 406);
            label19.Name = "label19";
            label19.Size = new Size(53, 15);
            label19.TabIndex = 45;
            label19.Text = "PHÒNG:";
            label19.Click += label19_Click;
            // 
            // textQuoctich
            // 
            textQuoctich.Location = new Point(285, 99);
            textQuoctich.Name = "textQuoctich";
            textQuoctich.ReadOnly = true;
            textQuoctich.Size = new Size(160, 23);
            textQuoctich.TabIndex = 19;
            // 
            // dateNgayvao
            // 
            dateNgayvao.Format = DateTimePickerFormat.Short;
            dateNgayvao.Location = new Point(84, 70);
            dateNgayvao.Name = "dateNgayvao";
            dateNgayvao.Size = new Size(110, 23);
            dateNgayvao.TabIndex = 47;
            // 
            // dateNgayra
            // 
            dateNgayra.Format = DateTimePickerFormat.Short;
            dateNgayra.Location = new Point(84, 99);
            dateNgayra.Name = "dateNgayra";
            dateNgayra.Size = new Size(110, 23);
            dateNgayra.TabIndex = 48;
            // 
            // Thongtinphong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 436);
            Controls.Add(dateNgayra);
            Controls.Add(dateNgayvao);
            Controls.Add(comboPhong);
            Controls.Add(label19);
            Controls.Add(buttonInhoadon);
            Controls.Add(buttonTraphong);
            Controls.Add(buttonDoiphong);
            Controls.Add(textTong);
            Controls.Add(label18);
            Controls.Add(textTonggiamgia);
            Controls.Add(label17);
            Controls.Add(textTongdichvu);
            Controls.Add(label16);
            Controls.Add(textTongphong);
            Controls.Add(label15);
            Controls.Add(textGia);
            Controls.Add(label14);
            Controls.Add(textNgayo);
            Controls.Add(label13);
            Controls.Add(textGiamgia);
            Controls.Add(label12);
            Controls.Add(dgvDichvu);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(comboDichvu);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textDiachi);
            Controls.Add(label9);
            Controls.Add(textQuoctich);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textSDT);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textCCCD);
            Controls.Add(label3);
            Controls.Add(textLoaiphong);
            Controls.Add(label4);
            Controls.Add(textTenKhach);
            Controls.Add(label2);
            Controls.Add(textTenphong);
            Controls.Add(label1);
            Name = "Thongtinphong";
            Text = "Thông tin phòng";
            ((System.ComponentModel.ISupportInitialize)dgvDichvu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTenKhach;
        private Label label2;
        private TextBox textTenphong;
        private Label label1;
        private TextBox textCCCD;
        private Label label3;
        private TextBox textLoaiphong;
        private Label label4;
        private TextBox textSDT;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox10;
        private Label label12;
        private TextBox textBox11;
        private Label label13;
        private Label label14;
        private TextBox textBox12;
        private Label label15;
        private TextBox textBox13;
        private Label label16;
        private TextBox textBox14;
        private Label label17;
        private TextBox textBox15;
        private Label label18;
        private TextBox textTong;
        private Button buttonDoiphong;
        private Button buttonTraphong;
        private Button buttonInhoadon;
        private ComboBox comboPhong;
        private Label label19;
        private TextBox textQuoctich;
        private Button buttonThem;
        private Button buttonXoa;
        private ComboBox comboDichvu;
        private DataGridView dgvDichvu;
        private TextBox textDiachi;
        private TextBox textGia;
        private TextBox textGiamgia;
        private TextBox textNgayo;
        private TextBox textTongdichvu;
        private TextBox textTonggiamgia;
        private TextBox textTongphong;
        private DateTimePicker dateNgayvao;
        private DateTimePicker dateNgayra;
        private DataGridViewTextBoxColumn colTenDV;
        private DataGridViewTextBoxColumn colGia;
    }
}