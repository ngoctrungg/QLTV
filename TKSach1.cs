using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QLThuVien
{
    public partial class TKSach1 : Form
    {
        Themxoasua t = new Themxoasua();
        public TKSach1()
        {
            InitializeComponent();
        }

        private void Loaddata()
        {
            DataTable dt = t.docdulieu("SELECT * FROM SACH");
            if (dt != null )
            {
                dgvSach.DataSource = dt;
            }
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Tác giả";
            dgvSach.Columns[3].HeaderText = "Nhà xuất bản";
            dgvSach.Columns[4].HeaderText = "Năm xuất bản";
            dgvSach.Columns[5].HeaderText = "Trị giá";
            dgvSach.Columns[6].HeaderText = "Ngày nhập";
            dgvSach.Columns[7].HeaderText = "Mã thể loại";

            dgvSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgvSach.Enabled = true;
        }


        private void Loaddata1()
        {

            //DataTable dt = t.docdulieu("SELECT SACH.MaSach, SACH.TenSach, PHIEUMUONSACH.NgayMuon, PHIEUMUONSACH.NgayTraSach, DOCGIA.HoTenDocGia FROM SACH, CHITIETPHIEUMUON, PHIEUMUONSACH, DOCGIA WHERE SACH.MaSach = CHITIETPHIEUMUON.MaSach AND CHITIETPHIEUMUON.MaPhieuMuon = PHIEUMUONSACH.MaPhieuMuon AND PHIEUMUONSACH.MaDocGia = DOCGIA.MaDocGia AND PHIEUMUONSACH.NgayTraSach > PHIEUMUONSACH.NgayMuon");
            DataTable dt = t.docdulieu("select distinct SACH.MaSach,SACH.TenSach, NHAXB.TenNhaXB,SACH.NamXuatBan,TheLoai.TenTheLoai from SACH, NHAXB,CHITIETPHIEUMUON, TheLoai where SACH.MaTheLoai=TheLoai.MaTheLoai and SACH.MaSach=CHITIETPHIEUMUON.MaSach");
            if (dt != null)
            {
                dgvSach.DataSource = dt;
            }
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Tác giả";
            dgvSach.Columns[3].HeaderText = "Nhà xuất bản";
            dgvSach.Columns[4].HeaderText = "Năm xuất bản";
            

            dgvSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgvSach.Enabled = true;
        }


        private void Loaddata2()
        {
            DataTable dt = t.docdulieu("SELECT SACH.MaSach,SACH.TenSach,SACH.TacGia, SACH.NamXuatBan,SACH.NhaXuatBan,SACH.TriGia, SACH.NgayNhap, SACH.MaTheLoai FROM SACH, TheLoai,CHITIETPHIEUMUON, PHIEUMUONSACH WHERE (SACH.MaTheLoai=TheLoai.MaTheLoai and SACH.MaSach=CHITIETPHIEUMUON.MaSach and PHIEUMUONSACH.NgayTraSach<GETDATE())");
            if (dt != null)
            {
                dgvSach.DataSource = dt;
            }
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Tác giả";
            dgvSach.Columns[3].HeaderText = "Nhà xuất bản";
            dgvSach.Columns[4].HeaderText = "Năm xuất bản";


            dgvSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgvSach.Enabled = true;
        }



        private void TKSach1_Load(object sender, EventArgs e)
        {
            cbTuyChon.Text = "Tất cả sách";

            Loaddata();

        }

        private void btnThogKe_Click(object sender, EventArgs e)
        {
            if (cbTuyChon.Text == "Tất cả sách")
                Loaddata();
            else if (cbTuyChon.Text == "Sách đang mượn")
                Loaddata1();
            else Loaddata2();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }
    }
}
