namespace CK.VIEW.Uc
{
    partial class UcDatphong
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
            dgvDatphong = new DataGridView();
            label1 = new Label();
            textTimkiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatphong).BeginInit();
            SuspendLayout();
            // 
            // dgvDatphong
            // 
            dgvDatphong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatphong.Location = new Point(30, 73);
            dgvDatphong.Name = "dgvDatphong";
            dgvDatphong.Size = new Size(503, 265);
            dgvDatphong.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            // 
            // textTimkiem
            // 
            textTimkiem.Location = new Point(114, 35);
            textTimkiem.Name = "textTimkiem";
            textTimkiem.Size = new Size(419, 23);
            textTimkiem.TabIndex = 2;
            // 
            // UcDatphong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textTimkiem);
            Controls.Add(label1);
            Controls.Add(dgvDatphong);
            Name = "UcDatphong";
            Size = new Size(563, 392);
            ((System.ComponentModel.ISupportInitialize)dgvDatphong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatphong;
        private Label label1;
        private TextBox textTimkiem;
    }
}
