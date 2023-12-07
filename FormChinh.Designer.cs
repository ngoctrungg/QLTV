namespace DA_QLThuVien
{
    partial class FormChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DA_QLThuVien.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuDanhMuc,
            this.menuMuonTra,
            this.menuTimKiem,
            this.menuTroGiup,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangXuat,
            this.menuThoat});
            this.menuHeThong.Image = global::DA_QLThuVien.Properties.Resources.system;
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(115, 34);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Image = global::DA_QLThuVien.Properties.Resources.logout;
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(160, 26);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Image = global::DA_QLThuVien.Properties.Resources.esc1;
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(160, 26);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien,
            this.menuDocGia,
            this.menuQuanLySach,
            this.nhàXuấtBảnToolStripMenuItem,
            this.tácGiảToolStripMenuItem});
            this.menuDanhMuc.Image = global::DA_QLThuVien.Properties.Resources.menu;
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(120, 34);
            this.menuDanhMuc.Text = "Danh mục";
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Image = global::DA_QLThuVien.Properties.Resources.staff;
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(180, 26);
            this.menuNhanVien.Text = "Nhân viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuDocGia
            // 
            this.menuDocGia.Image = global::DA_QLThuVien.Properties.Resources.user;
            this.menuDocGia.Name = "menuDocGia";
            this.menuDocGia.Size = new System.Drawing.Size(180, 26);
            this.menuDocGia.Text = "Độc giả";
            this.menuDocGia.Click += new System.EventHandler(this.menuDocGia_Click);
            // 
            // menuQuanLySach
            // 
            this.menuQuanLySach.Image = global::DA_QLThuVien.Properties.Resources.mamage;
            this.menuQuanLySach.Name = "menuQuanLySach";
            this.menuQuanLySach.Size = new System.Drawing.Size(180, 26);
            this.menuQuanLySach.Text = "Sách";
            this.menuQuanLySach.Click += new System.EventHandler(this.menuQuanLySach_Click);
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            this.nhàXuấtBảnToolStripMenuItem.Image = global::DA_QLThuVien.Properties.Resources.update;
            this.nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            this.nhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.nhàXuấtBảnToolStripMenuItem.Text = "Nhà xuất bản";
            this.nhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.nhàXuấtBảnToolStripMenuItem_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tácGiảToolStripMenuItem.Image")));
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // menuMuonTra
            // 
            this.menuMuonTra.Image = global::DA_QLThuVien.Properties.Resources.borrow;
            this.menuMuonTra.Name = "menuMuonTra";
            this.menuMuonTra.Size = new System.Drawing.Size(157, 34);
            this.menuMuonTra.Text = "Mượn / trả sách";
            this.menuMuonTra.Click += new System.EventHandler(this.menuMuonTra_Click);
            // 
            // menuTimKiem
            // 
            this.menuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmSáchToolStripMenuItem,
            this.tìmKiếmĐộcGiảToolStripMenuItem});
            this.menuTimKiem.Image = global::DA_QLThuVien.Properties.Resources.search;
            this.menuTimKiem.Name = "menuTimKiem";
            this.menuTimKiem.Size = new System.Drawing.Size(114, 34);
            this.menuTimKiem.Text = "Tìm kiếm";
            // 
            // tìmKiếmSáchToolStripMenuItem
            // 
            this.tìmKiếmSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmSáchToolStripMenuItem.Image")));
            this.tìmKiếmSáchToolStripMenuItem.Name = "tìmKiếmSáchToolStripMenuItem";
            this.tìmKiếmSáchToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.tìmKiếmSáchToolStripMenuItem.Text = "Tìm kiếm sách";
            this.tìmKiếmSáchToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmSáchToolStripMenuItem_Click);
            // 
            // tìmKiếmĐộcGiảToolStripMenuItem
            // 
            this.tìmKiếmĐộcGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmĐộcGiảToolStripMenuItem.Image")));
            this.tìmKiếmĐộcGiảToolStripMenuItem.Name = "tìmKiếmĐộcGiảToolStripMenuItem";
            this.tìmKiếmĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.tìmKiếmĐộcGiảToolStripMenuItem.Text = "Tìm kiếm độc giả";
            this.tìmKiếmĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmĐộcGiảToolStripMenuItem_Click);
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChucNang});
            this.menuTroGiup.Image = global::DA_QLThuVien.Properties.Resources.Statistic_all;
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(169, 34);
            this.menuTroGiup.Text = "Báo cáo thống kê";
            // 
            // menuChucNang
            // 
            this.menuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêSáchToolStripMenuItem,
            this.thốngKêĐộcGiảToolStripMenuItem});
            this.menuChucNang.Image = global::DA_QLThuVien.Properties.Resources.Statistic___;
            this.menuChucNang.Name = "menuChucNang";
            this.menuChucNang.Size = new System.Drawing.Size(174, 26);
            this.menuChucNang.Text = "Các báo cáo";
            // 
            // thốngKêSáchToolStripMenuItem
            // 
            this.thốngKêSáchToolStripMenuItem.Image = global::DA_QLThuVien.Properties.Resources.Statistic_lbr;
            this.thốngKêSáchToolStripMenuItem.Name = "thốngKêSáchToolStripMenuItem";
            this.thốngKêSáchToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.thốngKêSáchToolStripMenuItem.Text = "Thống kê sách";
            this.thốngKêSáchToolStripMenuItem.Click += new System.EventHandler(this.thốngKêSáchToolStripMenuItem_Click);
            // 
            // thốngKêĐộcGiảToolStripMenuItem
            // 
            this.thốngKêĐộcGiảToolStripMenuItem.Image = global::DA_QLThuVien.Properties.Resources.Statistic_person;
            this.thốngKêĐộcGiảToolStripMenuItem.Name = "thốngKêĐộcGiảToolStripMenuItem";
            this.thốngKêĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.thốngKêĐộcGiảToolStripMenuItem.Text = "Thống kê độc giả";
            this.thốngKêĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thốngKêĐộcGiảToolStripMenuItem_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.hỗTrợToolStripMenuItem.Image = global::DA_QLThuVien.Properties.Resources.spt;
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormChinh";
            this.Text = "FormChinh";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuDangXuat;
        private ToolStripMenuItem menuThoat;
        private ToolStripMenuItem menuDanhMuc;
        private ToolStripMenuItem menuNhanVien;
        private ToolStripMenuItem menuDocGia;
        private ToolStripMenuItem menuQuanLySach;
        private ToolStripMenuItem menuMuonTra;
        private ToolStripMenuItem menuTimKiem;
        private ToolStripMenuItem menuTroGiup;
        private ToolStripMenuItem menuChucNang;
        private ToolStripMenuItem tìmKiếmSáchToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmĐộcGiảToolStripMenuItem;
        private ToolStripMenuItem thốngKêSáchToolStripMenuItem;
        private ToolStripMenuItem thốngKêĐộcGiảToolStripMenuItem;
        private ToolStripMenuItem hỗTrợToolStripMenuItem;
        private ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem tácGiảToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}