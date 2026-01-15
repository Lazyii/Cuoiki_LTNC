namespace CK.VIEW.form_phụ
{
    partial class Thietbi
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
            textTenthietbi = new TextBox();
            label1 = new Label();
            dgvThietbi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvThietbi).BeginInit();
            SuspendLayout();
            // 
            // buttonSua
            // 
            buttonSua.BackColor = SystemColors.ActiveCaption;
            buttonSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSua.Location = new Point(289, 145);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(75, 23);
            buttonSua.TabIndex = 19;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = SystemColors.ActiveCaption;
            buttonXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonXoa.Location = new Point(133, 145);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 23);
            buttonXoa.TabIndex = 18;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = SystemColors.ActiveCaption;
            buttonThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThem.Location = new Point(289, 105);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(75, 23);
            buttonThem.TabIndex = 17;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonTim
            // 
            buttonTim.BackColor = SystemColors.ActiveCaption;
            buttonTim.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTim.Location = new Point(133, 105);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(75, 23);
            buttonTim.TabIndex = 16;
            buttonTim.Text = "Tìm";
            buttonTim.UseVisualStyleBackColor = false;
            buttonTim.Click += buttonTim_Click;
            // 
            // textGia
            // 
            textGia.Location = new Point(121, 54);
            textGia.Name = "textGia";
            textGia.Size = new Size(161, 23);
            textGia.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 60);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 12;
            label2.Text = "Giá:";
            // 
            // textTenthietbi
            // 
            textTenthietbi.Location = new Point(121, 25);
            textTenthietbi.Name = "textTenthietbi";
            textTenthietbi.Size = new Size(161, 23);
            textTenthietbi.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 10;
            label1.Text = "Tên thiết bị:";
            // 
            // dgvThietbi
            // 
            dgvThietbi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietbi.Location = new Point(33, 191);
            dgvThietbi.Name = "dgvThietbi";
            dgvThietbi.Size = new Size(396, 204);
            dgvThietbi.TabIndex = 20;
            dgvThietbi.CellClick += dgvThietbi_CellClick;
            // 
            // Thietbi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 436);
            Controls.Add(dgvThietbi);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(buttonTim);
            Controls.Add(textGia);
            Controls.Add(label2);
            Controls.Add(textTenthietbi);
            Controls.Add(label1);
            Name = "Thietbi";
            Text = "Thiết bị";
            ((System.ComponentModel.ISupportInitialize)dgvThietbi).EndInit();
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
        private TextBox textTenthietbi;
        private Label label1;
        private DataGridView dgvThietbi;
    }
}