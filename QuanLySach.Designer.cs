namespace DA_QLThuVien
{
    partial class QuanLySach
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
            this.gbTimKiemSach = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.rdbTenSach = new System.Windows.Forms.RadioButton();
            this.rdbMaSach = new System.Windows.Forms.RadioButton();
            this.gbCapNhatSach = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtNgaynhap = new System.Windows.Forms.TextBox();
            this.txtNhaxb = new System.Windows.Forms.TextBox();
            this.txtNamxb = new System.Windows.Forms.TextBox();
            this.txtTrigia = new System.Windows.Forms.TextBox();
            this.txtTentacgia = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtMatl = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTriGia = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.dgvQuanLySach = new System.Windows.Forms.DataGridView();
            this.gbTimKiemSach.SuspendLayout();
            this.gbCapNhatSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySach)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTimKiemSach
            // 
            this.gbTimKiemSach.Controls.Add(this.btnTimKiem);
            this.gbTimKiemSach.Controls.Add(this.txtTimkiem);
            this.gbTimKiemSach.Controls.Add(this.rdbTenSach);
            this.gbTimKiemSach.Controls.Add(this.rdbMaSach);
            this.gbTimKiemSach.Location = new System.Drawing.Point(92, 33);
            this.gbTimKiemSach.Name = "gbTimKiemSach";
            this.gbTimKiemSach.Size = new System.Drawing.Size(528, 125);
            this.gbTimKiemSach.TabIndex = 0;
            this.gbTimKiemSach.TabStop = false;
            this.gbTimKiemSach.Text = "Tìm kiếm sách";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(376, 56);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 40);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(159, 63);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(154, 27);
            this.txtTimkiem.TabIndex = 1;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdbTenSach
            // 
            this.rdbTenSach.AutoSize = true;
            this.rdbTenSach.Location = new System.Drawing.Point(25, 85);
            this.rdbTenSach.Name = "rdbTenSach";
            this.rdbTenSach.Size = new System.Drawing.Size(86, 24);
            this.rdbTenSach.TabIndex = 0;
            this.rdbTenSach.TabStop = true;
            this.rdbTenSach.Text = "Tên sách";
            this.rdbTenSach.UseVisualStyleBackColor = true;
            // 
            // rdbMaSach
            // 
            this.rdbMaSach.AutoSize = true;
            this.rdbMaSach.Location = new System.Drawing.Point(25, 44);
            this.rdbMaSach.Name = "rdbMaSach";
            this.rdbMaSach.Size = new System.Drawing.Size(84, 24);
            this.rdbMaSach.TabIndex = 0;
            this.rdbMaSach.TabStop = true;
            this.rdbMaSach.Text = "Mã sách";
            this.rdbMaSach.UseVisualStyleBackColor = true;
            // 
            // gbCapNhatSach
            // 
            this.gbCapNhatSach.Controls.Add(this.btnThoat);
            this.gbCapNhatSach.Controls.Add(this.btnLuu);
            this.gbCapNhatSach.Controls.Add(this.btnSua);
            this.gbCapNhatSach.Controls.Add(this.btnXoa);
            this.gbCapNhatSach.Controls.Add(this.btnThem);
            this.gbCapNhatSach.Controls.Add(this.lblNgayNhap);
            this.gbCapNhatSach.Controls.Add(this.txtNgaynhap);
            this.gbCapNhatSach.Controls.Add(this.txtNhaxb);
            this.gbCapNhatSach.Controls.Add(this.txtNamxb);
            this.gbCapNhatSach.Controls.Add(this.txtTrigia);
            this.gbCapNhatSach.Controls.Add(this.txtTentacgia);
            this.gbCapNhatSach.Controls.Add(this.txtTensach);
            this.gbCapNhatSach.Controls.Add(this.txtMatl);
            this.gbCapNhatSach.Controls.Add(this.txtMasach);
            this.gbCapNhatSach.Controls.Add(this.lblNamXuatBan);
            this.gbCapNhatSach.Controls.Add(this.lblNhaXuatBan);
            this.gbCapNhatSach.Controls.Add(this.lblTenSach);
            this.gbCapNhatSach.Controls.Add(this.lblTriGia);
            this.gbCapNhatSach.Controls.Add(this.lblTheLoai);
            this.gbCapNhatSach.Controls.Add(this.lblMaSach);
            this.gbCapNhatSach.Controls.Add(this.lblTenTacGia);
            this.gbCapNhatSach.Location = new System.Drawing.Point(12, 204);
            this.gbCapNhatSach.Name = "gbCapNhatSach";
            this.gbCapNhatSach.Size = new System.Drawing.Size(800, 223);
            this.gbCapNhatSach.TabIndex = 1;
            this.gbCapNhatSach.TabStop = false;
            this.gbCapNhatSach.Text = "Cập nhật sách";
            this.gbCapNhatSach.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(645, 139);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(706, 89);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(587, 89);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(700, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(587, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(312, 168);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(81, 20);
            this.lblNgayNhap.TabIndex = 0;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Location = new System.Drawing.Point(419, 168);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(154, 27);
            this.txtNgaynhap.TabIndex = 1;
            this.txtNgaynhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNhaxb
            // 
            this.txtNhaxb.Location = new System.Drawing.Point(419, 77);
            this.txtNhaxb.Name = "txtNhaxb";
            this.txtNhaxb.Size = new System.Drawing.Size(154, 27);
            this.txtNhaxb.TabIndex = 1;
            this.txtNhaxb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNamxb
            // 
            this.txtNamxb.Location = new System.Drawing.Point(122, 168);
            this.txtNamxb.Name = "txtNamxb";
            this.txtNamxb.Size = new System.Drawing.Size(154, 27);
            this.txtNamxb.TabIndex = 1;
            this.txtNamxb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTrigia
            // 
            this.txtTrigia.Location = new System.Drawing.Point(419, 125);
            this.txtTrigia.Name = "txtTrigia";
            this.txtTrigia.Size = new System.Drawing.Size(154, 27);
            this.txtTrigia.TabIndex = 1;
            this.txtTrigia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTentacgia
            // 
            this.txtTentacgia.Location = new System.Drawing.Point(419, 37);
            this.txtTentacgia.Name = "txtTentacgia";
            this.txtTentacgia.Size = new System.Drawing.Size(154, 27);
            this.txtTentacgia.TabIndex = 1;
            this.txtTentacgia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(122, 80);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(154, 27);
            this.txtTensach.TabIndex = 1;
            this.txtTensach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMatl
            // 
            this.txtMatl.Location = new System.Drawing.Point(122, 125);
            this.txtMatl.Name = "txtMatl";
            this.txtMatl.Size = new System.Drawing.Size(154, 27);
            this.txtMatl.TabIndex = 1;
            this.txtMatl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMasach
            // 
            this.txtMasach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMasach.Enabled = false;
            this.txtMasach.Location = new System.Drawing.Point(122, 34);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(154, 27);
            this.txtMasach.TabIndex = 1;
            this.txtMasach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Location = new System.Drawing.Point(14, 171);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(102, 20);
            this.lblNamXuatBan.TabIndex = 0;
            this.lblNamXuatBan.Text = "Năm xuất bản";
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Location = new System.Drawing.Point(313, 80);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(97, 20);
            this.lblNhaXuatBan.TabIndex = 0;
            this.lblNhaXuatBan.Text = "Nhà xuất bản";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(6, 77);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(65, 20);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách";
            // 
            // lblTriGia
            // 
            this.lblTriGia.AutoSize = true;
            this.lblTriGia.Location = new System.Drawing.Point(313, 122);
            this.lblTriGia.Name = "lblTriGia";
            this.lblTriGia.Size = new System.Drawing.Size(50, 20);
            this.lblTriGia.TabIndex = 0;
            this.lblTriGia.Text = "Trị giá";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(14, 125);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(84, 20);
            this.lblTheLoai.TabIndex = 0;
            this.lblTheLoai.Text = "Mã thể loại";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(6, 34);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(63, 20);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách";
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Location = new System.Drawing.Point(313, 37);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(81, 20);
            this.lblTenTacGia.TabIndex = 0;
            this.lblTenTacGia.Text = "Tên tác giả";
            // 
            // dgvQuanLySach
            // 
            this.dgvQuanLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLySach.Location = new System.Drawing.Point(-16, 453);
            this.dgvQuanLySach.Name = "dgvQuanLySach";
            this.dgvQuanLySach.RowHeadersWidth = 51;
            this.dgvQuanLySach.RowTemplate.Height = 29;
            this.dgvQuanLySach.Size = new System.Drawing.Size(842, 224);
            this.dgvQuanLySach.TabIndex = 2;
            this.dgvQuanLySach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLySach_CellContentClick);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 676);
            this.Controls.Add(this.dgvQuanLySach);
            this.Controls.Add(this.gbCapNhatSach);
            this.Controls.Add(this.gbTimKiemSach);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.gbTimKiemSach.ResumeLayout(false);
            this.gbTimKiemSach.PerformLayout();
            this.gbCapNhatSach.ResumeLayout(false);
            this.gbCapNhatSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbTimKiemSach;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private RadioButton rdbTenSach;
        private RadioButton rdbMaSach;
        private GroupBox gbCapNhatSach;
        private Label lblNgayNhap;
        private Label lblNamXuatBan;
        private Label lblNhaXuatBan;
        private Label lblTenSach;
        private Label lblTriGia;
        private Label lblTheLoai;
        private Label lblMaSach;
        private Label lblTenTacGia;
        private TextBox txtNhaxb;
        private TextBox txtNamxb;
        private TextBox txtTentacgia;
        private TextBox txtTensach;
        private TextBox txtMatl;
        private TextBox txtMasach;
        private TextBox txtNgaynhap;
        private TextBox txtTrigia;
        private DataGridView dgvQuanLySach;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}