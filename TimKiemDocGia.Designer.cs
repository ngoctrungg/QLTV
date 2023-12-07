namespace DA_QLThuVien
{
    partial class TimKiemDocGia
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
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.rdbTenDocGia = new System.Windows.Forms.RadioButton();
            this.rdbMaDocGia = new System.Windows.Forms.RadioButton();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.lblTongSoDocGia = new System.Windows.Forms.Label();
            this.lblTS = new System.Windows.Forms.Label();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.txtTimKiem);
            this.gbTimKiem.Controls.Add(this.btnThoat);
            this.gbTimKiem.Controls.Add(this.btnTim);
            this.gbTimKiem.Controls.Add(this.rdbTenDocGia);
            this.gbTimKiem.Controls.Add(this.rdbMaDocGia);
            this.gbTimKiem.Location = new System.Drawing.Point(78, 63);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(632, 128);
            this.gbTimKiem.TabIndex = 1;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            this.gbTimKiem.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(135, 64);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(234, 27);
            this.txtTimKiem.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(521, 64);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 27);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(401, 64);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 27);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rdbTenDocGia
            // 
            this.rdbTenDocGia.AutoSize = true;
            this.rdbTenDocGia.Location = new System.Drawing.Point(0, 81);
            this.rdbTenDocGia.Name = "rdbTenDocGia";
            this.rdbTenDocGia.Size = new System.Drawing.Size(107, 24);
            this.rdbTenDocGia.TabIndex = 1;
            this.rdbTenDocGia.TabStop = true;
            this.rdbTenDocGia.Text = "Tên độc giả";
            this.rdbTenDocGia.UseVisualStyleBackColor = true;
            this.rdbTenDocGia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbMaDocGia
            // 
            this.rdbMaDocGia.AutoSize = true;
            this.rdbMaDocGia.Location = new System.Drawing.Point(0, 42);
            this.rdbMaDocGia.Name = "rdbMaDocGia";
            this.rdbMaDocGia.Size = new System.Drawing.Size(105, 24);
            this.rdbMaDocGia.TabIndex = 1;
            this.rdbMaDocGia.TabStop = true;
            this.rdbMaDocGia.Text = "Mã độc giả";
            this.rdbMaDocGia.UseVisualStyleBackColor = true;
            this.rdbMaDocGia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(-2, 234);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 29;
            this.dgvDocGia.Size = new System.Drawing.Size(803, 216);
            this.dgvDocGia.TabIndex = 2;
            // 
            // lblTongSoDocGia
            // 
            this.lblTongSoDocGia.AutoSize = true;
            this.lblTongSoDocGia.Location = new System.Drawing.Point(5, 208);
            this.lblTongSoDocGia.Name = "lblTongSoDocGia";
            this.lblTongSoDocGia.Size = new System.Drawing.Size(132, 20);
            this.lblTongSoDocGia.TabIndex = 3;
            this.lblTongSoDocGia.Text = "Tổng số độc giả là";
            // 
            // lblTS
            // 
            this.lblTS.AutoSize = true;
            this.lblTS.ForeColor = System.Drawing.Color.Red;
            this.lblTS.Location = new System.Drawing.Point(153, 208);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(57, 20);
            this.lblTS.TabIndex = 3;
            this.lblTS.Text = "Tongso";
            // 
            // TimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTS);
            this.Controls.Add(this.lblTongSoDocGia);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.gbTimKiem);
            this.Name = "TimKiemDocGia";
            this.Text = "TimKiemDocGia";
            this.Load += new System.EventHandler(this.TimKiemDocGia_Load);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox gbTimKiem;
        private RadioButton rdbMaDocGia;
        private Button btnThoat;
        private Button btnTim;
        private RadioButton rdbTenDocGia;
        private DataGridView dgvDocGia;
        private Label lblTongSoDocGia;
        private Label lblTS;
        private TextBox txtTimKiem;
    }
}