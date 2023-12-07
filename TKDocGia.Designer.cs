namespace DA_QLThuVien
{
    partial class TKDocGia
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
            this.gbTuyChonThongKe = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cbTuyChon = new System.Windows.Forms.ComboBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.gbTuyChonThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTuyChonThongKe
            // 
            this.gbTuyChonThongKe.Controls.Add(this.btnThoat);
            this.gbTuyChonThongKe.Controls.Add(this.btnThongKe);
            this.gbTuyChonThongKe.Controls.Add(this.cbTuyChon);
            this.gbTuyChonThongKe.Location = new System.Drawing.Point(49, 59);
            this.gbTuyChonThongKe.Name = "gbTuyChonThongKe";
            this.gbTuyChonThongKe.Size = new System.Drawing.Size(683, 83);
            this.gbTuyChonThongKe.TabIndex = 0;
            this.gbTuyChonThongKe.TabStop = false;
            this.gbTuyChonThongKe.Text = "Tùy chọn thống kê";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(526, 34);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(384, 34);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(94, 29);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cbTuyChon
            // 
            this.cbTuyChon.FormattingEnabled = true;
            this.cbTuyChon.Items.AddRange(new object[] {
            "Tất cả độc giả",
            "Độc giả trễ hạn"});
            this.cbTuyChon.Location = new System.Drawing.Point(66, 35);
            this.cbTuyChon.Name = "cbTuyChon";
            this.cbTuyChon.Size = new System.Drawing.Size(247, 28);
            this.cbTuyChon.TabIndex = 0;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(-1, 198);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 29;
            this.dgvThongKe.Size = new System.Drawing.Size(801, 254);
            this.dgvThongKe.TabIndex = 1;
            // 
            // TKDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.gbTuyChonThongKe);
            this.Name = "TKDocGia";
            this.Text = "TKDocGia";
            this.Load += new System.EventHandler(this.TKDocGia_Load);
            this.gbTuyChonThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbTuyChonThongKe;
        private Button btnThoat;
        private Button btnThongKe;
        private ComboBox cbTuyChon;
        private DataGridView dgvThongKe;
    }
}