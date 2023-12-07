using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace DA_QLThuVien
{
    public partial class TKDocGia : Form
    {
        Themxoasua t = new Themxoasua();
        public TKDocGia()
        {
            InitializeComponent();
        }

        private void loaddata() {
            DataTable dt = t.docdulieu("SELECT * FROM DOCGIA");
            if (dt != null )
            {
                dgvThongKe.DataSource = dt;
            }
            dgvThongKe.Columns[0].HeaderText = "Mã độc giả";
            dgvThongKe.Columns[1].HeaderText = "Tên độc giả";
            dgvThongKe.Columns[2].HeaderText = "Ngày sinh";
            dgvThongKe.Columns[3].HeaderText = "Địa chỉ";
            dgvThongKe.Columns[4].HeaderText = "Email";
            dgvThongKe.Columns[5].HeaderText = "Ngày lập thẻ";
            dgvThongKe.Columns[6].HeaderText = "Ngày hết hạn";
            dgvThongKe.Columns[7].HeaderText = "Tiền nợ";
            dgvThongKe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgvThongKe.Enabled = true;
        }

        private void loaddata2()
        {
            DataTable dt = t.docdulieu("SELECT DOCGIA.MaDocGia, DOCGIA.HoTenDocGia, DOCGIA.NgaySinh, DOCGIA.DiaChi, DOCGIA.Email, DOCGIA.NgayLapThe, DOCGIA.NgayHetHan, DOCGIA.TienNo FROM DOCGIA, PHIEUMUONSACH, CHITIETPHIEUMUON, SACH, TheLoai WHERE DOCGIA.MaDocGia = PHIEUMUONSACH.MaDocGia AND CHITIETPHIEUMUON.MaPhieuMuon = PHIEUMUONSACH.MaPhieuMuon AND SACH.MaTheLoai = TheLoai.MaTheLoai AND SACH.MaSach = CHITIETPHIEUMUON.MaSach");


            if (dt != null)
            {
                dgvThongKe.DataSource = dt;
            }
            
            dgvThongKe.Columns[0].HeaderText = "Mã độc giả";
            dgvThongKe.Columns[1].HeaderText = "Tên độc giả";
            dgvThongKe.Columns[2].HeaderText = "Ngày sinh";
            dgvThongKe.Columns[3].HeaderText = "Địa chỉ";
            dgvThongKe.Columns[4].HeaderText = "Email";
            dgvThongKe.Columns[5].HeaderText = "Ngày lập thẻ";
            dgvThongKe.Columns[6].HeaderText = "Ngày hết hạn";
            dgvThongKe.Columns[7].HeaderText = "Tiền nợ";
            
            

            dgvThongKe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgvThongKe.Enabled = true;
        }
            private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbTuyChon.Text == "Tất cả độc giả")
                loaddata();
            else loaddata2();
        }

        private void LoadTen()
        {
           
        }

        private void TKDocGia_Load(object sender, EventArgs e)
        {
            loaddata();
            cbTuyChon.Text = "Tất cả độc giả";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }
    }
}
