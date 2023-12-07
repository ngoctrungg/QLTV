namespace DA_QLThuVien
{
    partial class TKSach1
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
            this.cbTuyChon = new System.Windows.Forms.ComboBox();
            this.gbTuyChon = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThogKe = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.gbTuyChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTuyChon
            // 
            this.cbTuyChon.FormattingEnabled = true;
            this.cbTuyChon.Items.AddRange(new object[] {
            "Tất cả sách",
            "Sách đang mượn",
            "Sách trễ hạn"});
            this.cbTuyChon.Location = new System.Drawing.Point(105, 38);
            this.cbTuyChon.Name = "cbTuyChon";
            this.cbTuyChon.Size = new System.Drawing.Size(203, 28);
            this.cbTuyChon.TabIndex = 0;
            // 
            // gbTuyChon
            // 
            this.gbTuyChon.Controls.Add(this.btnThoat);
            this.gbTuyChon.Controls.Add(this.btnThogKe);
            this.gbTuyChon.Controls.Add(this.cbTuyChon);
            this.gbTuyChon.Location = new System.Drawing.Point(40, 57);
            this.gbTuyChon.Name = "gbTuyChon";
            this.gbTuyChon.Size = new System.Drawing.Size(713, 90);
            this.gbTuyChon.TabIndex = 1;
            this.gbTuyChon.TabStop = false;
            this.gbTuyChon.Text = "Tùy chọn thống kê";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(597, 37);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThogKe
            // 
            this.btnThogKe.Location = new System.Drawing.Point(440, 37);
            this.btnThogKe.Name = "btnThogKe";
            this.btnThogKe.Size = new System.Drawing.Size(94, 29);
            this.btnThogKe.TabIndex = 1;
            this.btnThogKe.Text = "Thống kê";
            this.btnThogKe.UseVisualStyleBackColor = true;
            this.btnThogKe.Click += new System.EventHandler(this.btnThogKe_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(-1, 208);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 29;
            this.dgvSach.Size = new System.Drawing.Size(801, 241);
            this.dgvSach.TabIndex = 2;
            // 
            // TKSach1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.gbTuyChon);
            this.Name = "TKSach1";
            this.Text = "TKSach1";
            this.Load += new System.EventHandler(this.TKSach1_Load);
            this.gbTuyChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbTuyChon;
        private GroupBox gbTuyChon;
        private Button btnThoat;
        private Button btnThogKe;
        private DataGridView dgvSach;
    }
}