namespace CK.VIEW.Uc
{
    partial class UcNhanvien
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
            label1 = new Label();
            label2 = new Label();
            textHoten = new TextBox();
            textSdt = new TextBox();
            label3 = new Label();
            textEmail = new TextBox();
            dgvNhanvien = new DataGridView();
            label4 = new Label();
            textDiachi = new TextBox();
            label5 = new Label();
            textChucvu = new TextBox();
            buttonCapnhat = new Button();
            buttonTimkiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 60);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 1;
            label2.Text = "SĐT:";
            // 
            // textHoten
            // 
            textHoten.Location = new Point(91, 25);
            textHoten.Name = "textHoten";
            textHoten.Size = new Size(172, 23);
            textHoten.TabIndex = 2;
            // 
            // textSdt
            // 
            textSdt.Location = new Point(91, 54);
            textSdt.Name = "textSdt";
            textSdt.Size = new Size(172, 23);
            textSdt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 89);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(91, 83);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(172, 23);
            textEmail.TabIndex = 5;
            textEmail.TextChanged += textBox3_TextChanged;
            // 
            // dgvNhanvien
            // 
            dgvNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanvien.Location = new Point(31, 195);
            dgvNhanvien.Name = "dgvNhanvien";
            dgvNhanvien.Size = new Size(509, 176);
            dgvNhanvien.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(281, 31);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 7;
            label4.Text = "Địa chỉ:";
            label4.Click += label4_Click;
            // 
            // textDiachi
            // 
            textDiachi.Location = new Point(349, 25);
            textDiachi.Multiline = true;
            textDiachi.Name = "textDiachi";
            textDiachi.Size = new Size(191, 52);
            textDiachi.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(281, 89);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 9;
            label5.Text = "Chức vụ:";
            // 
            // textChucvu
            // 
            textChucvu.Location = new Point(349, 83);
            textChucvu.Name = "textChucvu";
            textChucvu.Size = new Size(191, 23);
            textChucvu.TabIndex = 10;
            // 
            // buttonCapnhat
            // 
            buttonCapnhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCapnhat.Location = new Point(145, 150);
            buttonCapnhat.Name = "buttonCapnhat";
            buttonCapnhat.Size = new Size(75, 23);
            buttonCapnhat.TabIndex = 11;
            buttonCapnhat.Text = "Cập nhật";
            buttonCapnhat.UseVisualStyleBackColor = true;
            // 
            // buttonTimkiem
            // 
            buttonTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTimkiem.Location = new Point(306, 150);
            buttonTimkiem.Name = "buttonTimkiem";
            buttonTimkiem.Size = new Size(75, 23);
            buttonTimkiem.TabIndex = 12;
            buttonTimkiem.Text = "Tìm kiếm";
            buttonTimkiem.UseVisualStyleBackColor = true;
            // 
            // UcNhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonTimkiem);
            Controls.Add(buttonCapnhat);
            Controls.Add(textChucvu);
            Controls.Add(label5);
            Controls.Add(textDiachi);
            Controls.Add(label4);
            Controls.Add(dgvNhanvien);
            Controls.Add(textEmail);
            Controls.Add(label3);
            Controls.Add(textSdt);
            Controls.Add(textHoten);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UcNhanvien";
            Size = new Size(563, 392);
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textHoten;
        private TextBox textSdt;
        private Label label3;
        private TextBox textEmail;
        private DataGridView dgvNhanvien;
        private Label label4;
        private TextBox textDiachi;
        private Label label5;
        private TextBox textChucvu;
        private Button buttonCapnhat;
        private Button buttonTimkiem;
    }
}
