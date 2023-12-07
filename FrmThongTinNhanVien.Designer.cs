namespace DA_QLThuVien
{
    partial class FrmThongTinNhanVien
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
            this.gbCapnhat = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtMabangcap = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTs = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.gbCapnhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCapnhat
            // 
            this.gbCapnhat.Controls.Add(this.dtpNgaysinh);
            this.gbCapnhat.Controls.Add(this.btnThem);
            this.gbCapnhat.Controls.Add(this.btnThoat);
            this.gbCapnhat.Controls.Add(this.btnLuu);
            this.gbCapnhat.Controls.Add(this.btnSua);
            this.gbCapnhat.Controls.Add(this.btnXoa);
            this.gbCapnhat.Controls.Add(this.txtMabangcap);
            this.gbCapnhat.Controls.Add(this.txtDienthoai);
            this.gbCapnhat.Controls.Add(this.txtHovaten);
            this.gbCapnhat.Controls.Add(this.txtDiachi);
            this.gbCapnhat.Controls.Add(this.txtManhanvien);
            this.gbCapnhat.Controls.Add(this.label6);
            this.gbCapnhat.Controls.Add(this.label3);
            this.gbCapnhat.Controls.Add(this.label5);
            this.gbCapnhat.Controls.Add(this.label2);
            this.gbCapnhat.Controls.Add(this.label4);
            this.gbCapnhat.Controls.Add(this.label1);
            this.gbCapnhat.Location = new System.Drawing.Point(34, 26);
            this.gbCapnhat.Name = "gbCapnhat";
            this.gbCapnhat.Size = new System.Drawing.Size(739, 232);
            this.gbCapnhat.TabIndex = 0;
            this.gbCapnhat.TabStop = false;
            this.gbCapnhat.Text = "Cập nhật thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã bằng cấp";
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.BackColor = System.Drawing.SystemColors.Menu;
            this.txtManhanvien.Enabled = false;
            this.txtManhanvien.Location = new System.Drawing.Point(196, 37);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(125, 27);
            this.txtManhanvien.TabIndex = 1;
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(196, 86);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(125, 27);
            this.txtHovaten.TabIndex = 1;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(512, 34);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(125, 27);
            this.txtDiachi.TabIndex = 1;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(512, 86);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(125, 27);
            this.txtDienthoai.TabIndex = 1;
            // 
            // txtMabangcap
            // 
            this.txtMabangcap.Location = new System.Drawing.Point(512, 143);
            this.txtMabangcap.Name = "txtMabangcap";
            this.txtMabangcap.Size = new System.Drawing.Size(125, 27);
            this.txtMabangcap.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(196, 197);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(356, 197);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(498, 197);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(639, 197);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 197);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(-2, 288);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 29;
            this.dgvNhanvien.Size = new System.Drawing.Size(803, 178);
            this.dgvNhanvien.TabIndex = 1;
            this.dgvNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng số nhân viên";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTs
            // 
            this.lblTs.AutoSize = true;
            this.lblTs.ForeColor = System.Drawing.Color.Red;
            this.lblTs.Location = new System.Drawing.Point(166, 261);
            this.lblTs.Name = "lblTs";
            this.lblTs.Size = new System.Drawing.Size(55, 20);
            this.lblTs.TabIndex = 0;
            this.lblTs.Text = "tongso";
            this.lblTs.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(196, 146);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(125, 27);
            this.dtpNgaysinh.TabIndex = 3;
            // 
            // FrmThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.gbCapnhat);
            this.Controls.Add(this.lblTs);
            this.Controls.Add(this.label7);
            this.Name = "FrmThongTinNhanVien";
            this.Text = "FrmThongTinNhanVien";
            this.Load += new System.EventHandler(this.FrmThongTinNhanVien_Load);
            this.gbCapnhat.ResumeLayout(false);
            this.gbCapnhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbCapnhat;
        private Button btnThem;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMabangcap;
        private TextBox txtDienthoai;
        private TextBox txtHovaten;
        private TextBox txtDiachi;
        private TextBox txtManhanvien;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
        private DataGridView dgvNhanvien;
        private Label label7;
        private Label lblTs;
        private DateTimePicker dtpNgaysinh;
    }
}