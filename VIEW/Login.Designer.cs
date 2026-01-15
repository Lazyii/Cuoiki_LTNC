namespace CK.VIEW
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            textTaikhoan = new TextBox();
            textMatkhau = new TextBox();
            buttonDangnhap = new Button();
            quenpass = new LinkLabel();
            label4 = new Label();
            thoat = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 130);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 215);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(204, 59);
            label3.Name = "label3";
            label3.Size = new Size(381, 37);
            label3.TabIndex = 1;
            label3.Text = "Login to your account";
            // 
            // textTaikhoan
            // 
            textTaikhoan.Location = new Point(236, 168);
            textTaikhoan.Name = "textTaikhoan";
            textTaikhoan.Size = new Size(332, 23);
            textTaikhoan.TabIndex = 2;
            // 
            // textMatkhau
            // 
            textMatkhau.Location = new Point(236, 253);
            textMatkhau.Name = "textMatkhau";
            textMatkhau.Size = new Size(332, 23);
            textMatkhau.TabIndex = 3;
            // 
            // buttonDangnhap
            // 
            buttonDangnhap.BackColor = SystemColors.MenuHighlight;
            buttonDangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDangnhap.ForeColor = SystemColors.MenuText;
            buttonDangnhap.Location = new Point(295, 293);
            buttonDangnhap.Name = "buttonDangnhap";
            buttonDangnhap.Size = new Size(220, 35);
            buttonDangnhap.TabIndex = 4;
            buttonDangnhap.Text = "Đăng nhập";
            buttonDangnhap.UseVisualStyleBackColor = false;
            buttonDangnhap.Click += buttonDangnhap_Click;
            // 
            // quenpass
            // 
            quenpass.AutoSize = true;
            quenpass.Location = new Point(326, 342);
            quenpass.Name = "quenpass";
            quenpass.Size = new Size(94, 15);
            quenpass.TabIndex = 5;
            quenpass.TabStop = true;
            quenpass.Text = "Quên mật khẩu?";
            quenpass.LinkClicked += quenpass_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 342);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 6;
            label4.Text = "//";
            // 
            // thoat
            // 
            thoat.AutoSize = true;
            thoat.Location = new Point(449, 342);
            thoat.Name = "thoat";
            thoat.Size = new Size(35, 15);
            thoat.TabIndex = 7;
            thoat.TabStop = true;
            thoat.Text = "thoát";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thoat);
            Controls.Add(label4);
            Controls.Add(quenpass);
            Controls.Add(buttonDangnhap);
            Controls.Add(textMatkhau);
            Controls.Add(textTaikhoan);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textTaikhoan;
        private TextBox textMatkhau;
        private Button buttonDangnhap;
        private LinkLabel quenpass;
        private Label label4;
        private LinkLabel thoat;
    }
}