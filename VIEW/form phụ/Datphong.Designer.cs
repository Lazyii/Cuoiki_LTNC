namespace CK.VIEW.form_phụ
{
    partial class Datphong
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
            textTenkhach = new TextBox();
            label2 = new Label();
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
            textGia = new TextBox();
            label10 = new Label();
            textNgayo = new TextBox();
            label11 = new Label();
            buttonNhanphong = new Button();
            comboQuoctich = new ComboBox();
            dateNgayVao = new DateTimePicker();
            dateNgayRa = new DateTimePicker();
            textTenphong = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên phòng:";
            // 
            // textTenkhach
            // 
            textTenkhach.Location = new Point(287, 30);
            textTenkhach.Name = "textTenkhach";
            textTenkhach.Size = new Size(160, 23);
            textTenkhach.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 38);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên khách:";
            label2.Click += label2_Click;
            // 
            // textCCCD
            // 
            textCCCD.Location = new Point(287, 71);
            textCCCD.Name = "textCCCD";
            textCCCD.Size = new Size(160, 23);
            textCCCD.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(215, 79);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "CCCD:";
            label3.Click += label3_Click;
            // 
            // textLoaiphong
            // 
            textLoaiphong.Location = new Point(86, 71);
            textLoaiphong.Name = "textLoaiphong";
            textLoaiphong.ReadOnly = true;
            textLoaiphong.Size = new Size(110, 23);
            textLoaiphong.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 79);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "Loại phòng:";
            // 
            // textSDT
            // 
            textSDT.Location = new Point(287, 114);
            textSDT.Name = "textSDT";
            textSDT.Size = new Size(160, 23);
            textSDT.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(215, 122);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "SĐT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 122);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 8;
            label6.Text = "Ngày vào:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(215, 164);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 14;
            label7.Text = "Quốc tịch:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 164);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 12;
            label8.Text = "Ngày ra:";
            // 
            // textDiachi
            // 
            textDiachi.Location = new Point(287, 199);
            textDiachi.Multiline = true;
            textDiachi.Name = "textDiachi";
            textDiachi.Size = new Size(160, 52);
            textDiachi.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(215, 207);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 18;
            label9.Text = "Địa chỉ:";
            // 
            // textGia
            // 
            textGia.Location = new Point(86, 199);
            textGia.Name = "textGia";
            textGia.ReadOnly = true;
            textGia.Size = new Size(110, 23);
            textGia.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 207);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 16;
            label10.Text = "Giá:";
            // 
            // textNgayo
            // 
            textNgayo.Location = new Point(86, 228);
            textNgayo.Name = "textNgayo";
            textNgayo.ReadOnly = true;
            textNgayo.Size = new Size(110, 23);
            textNgayo.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 236);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 20;
            label11.Text = "Ngày ở:";
            // 
            // buttonNhanphong
            // 
            buttonNhanphong.BackColor = Color.IndianRed;
            buttonNhanphong.Cursor = Cursors.Hand;
            buttonNhanphong.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNhanphong.Location = new Point(144, 293);
            buttonNhanphong.Name = "buttonNhanphong";
            buttonNhanphong.Size = new Size(163, 51);
            buttonNhanphong.TabIndex = 22;
            buttonNhanphong.Text = "Nhận phòng";
            buttonNhanphong.UseVisualStyleBackColor = false;
            buttonNhanphong.Click += buttonNhanphong_Click;
            // 
            // comboQuoctich
            // 
            comboQuoctich.FormattingEnabled = true;
            comboQuoctich.Location = new Point(287, 156);
            comboQuoctich.Name = "comboQuoctich";
            comboQuoctich.Size = new Size(160, 23);
            comboQuoctich.TabIndex = 23;
            // 
            // dateNgayVao
            // 
            dateNgayVao.Format = DateTimePickerFormat.Short;
            dateNgayVao.Location = new Point(86, 116);
            dateNgayVao.Name = "dateNgayVao";
            dateNgayVao.Size = new Size(110, 23);
            dateNgayVao.TabIndex = 25;
            dateNgayVao.ValueChanged += dateNgayvao_ValueChanged;
            // 
            // dateNgayRa
            // 
            dateNgayRa.Format = DateTimePickerFormat.Short;
            dateNgayRa.Location = new Point(86, 158);
            dateNgayRa.Name = "dateNgayRa";
            dateNgayRa.Size = new Size(110, 23);
            dateNgayRa.TabIndex = 26;
            dateNgayRa.ValueChanged += dateNgayra_ValueChanged;
            // 
            // textTenphong
            // 
            textTenphong.Location = new Point(86, 30);
            textTenphong.Name = "textTenphong";
            textTenphong.ReadOnly = true;
            textTenphong.Size = new Size(110, 23);
            textTenphong.TabIndex = 27;
            // 
            // Datphong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 436);
            Controls.Add(textTenphong);
            Controls.Add(dateNgayRa);
            Controls.Add(dateNgayVao);
            Controls.Add(comboQuoctich);
            Controls.Add(buttonNhanphong);
            Controls.Add(textNgayo);
            Controls.Add(label11);
            Controls.Add(textDiachi);
            Controls.Add(label9);
            Controls.Add(textGia);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textSDT);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textCCCD);
            Controls.Add(label3);
            Controls.Add(textLoaiphong);
            Controls.Add(label4);
            Controls.Add(textTenkhach);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Datphong";
            Text = "Đặt phòng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textTenkhach;
        private Label label2;
        private TextBox textCCCD;
        private Label label3;
        private TextBox textLoaiphong;
        private Label label4;
        private TextBox textSDT;
        private Label label5;
        private TextBox textNgayvao;
        private Label label6;
        private Label label7;
        private TextBox textNgayra;
        private Label label8;
        private TextBox textDiachi;
        private Label label9;
        private TextBox textGia;
        private Label label10;
        private TextBox textNgayo;
        private Label label11;
        private Button buttonNhanphong;
        private ComboBox comboQuoctich;
        private DateTimePicker dateNgayVao;
        private DateTimePicker dateNgayRa;
        private TextBox textTenphong;
    }
}