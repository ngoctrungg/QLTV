using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DA_QLThuVien
{
    public partial class FormMuonTra : Form
    {
        Themxoasua t = new Themxoasua();
        public int dem;
        public DateTime date1, date2;
        public TimeSpan time;
        public int day;
        public FormMuonTra()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from PHIEUMUONSACH");
            //l.Text = dt.Rows.Count.ToString();
            loadcombo();
            if (dt != null)
            {
                dgvMuonTra.DataSource = dt;
            }
            dgvMuonTra.Columns[0].HeaderText = "Mã phiếu mượn";
            dgvMuonTra.Columns[1].HeaderText = "Ngày mượn";
            dgvMuonTra.Columns[2].HeaderText = "Mã độc giả";
            dgvMuonTra.Columns[3].HeaderText = "Ngày trả sách";
            dgvMuonTra.Columns[4].HeaderText = "Mã nhân viên";

            dgvMuonTra.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            dgvMuonTra.Enabled = true;

        }

        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from DOCGIA");
            DataTable dt1 = t.docdulieu("select * from NHANVIEN");
            DataTable dt2 = t.docdulieu("select * from PHIEUMUONSACH");
            DataTable dt3 = t.docdulieu("select * from SACH");



            comdocgia.DataSource = dt;
            comdocgia.DisplayMember = "HoTenDocGia";
            comdocgia.ValueMember = "MaDocGia";

            comnhanvien.DataSource = dt1;
            comnhanvien.DisplayMember = "HoTenNhanVien";
            comnhanvien.ValueMember = "MaNhanVien";

            commaphieumuon.DataSource = dt2;
            commaphieumuon.DisplayMember = "MaPhieuMuon";
            commaphieumuon.ValueMember = "MaPhieuMuon";

            commasach.DataSource = dt3;
            commasach.DisplayMember = "MaSach";
            commasach.ValueMember = "MaSach";
        }


        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select * from CHITIETPHIEUMUON");
            lblts.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgvMuonTra2.DataSource = dt;
            }
            dgvMuonTra2.Columns[0].HeaderText = "Mã sách";
            dgvMuonTra2.Columns[1].HeaderText = "Mã phiếu mượn";
            dgvMuonTra2.Columns[2].HeaderText = "Ngày mượn";
            dgvMuonTra2.Columns[3].HeaderText = "Ngày trả";
            dgvMuonTra2.Columns[4].HeaderText = "Ghi chú";


            btnTrasach.Enabled = true;
            btnGiahan.Text = "Gia hạn";
            btnThem1.Enabled = true;
            btnGiahan.Enabled = true;
            btnTrasach.Enabled = true;
            btnLuu1.Enabled = false;
            dgvMuonTra2.Enabled = true;

        }

        private void dgvMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphieu.Text = dgvMuonTra.CurrentRow.Cells[0].Value.ToString();
            txtNgayMuon.Text = dgvMuonTra.CurrentRow.Cells[1].Value.ToString();
            comdocgia.Text = dgvMuonTra.CurrentRow.Cells[2].Value.ToString();
            txtNgayTra.Text = dgvMuonTra.CurrentRow.Cells[3].Value.ToString();
            comnhanvien.Text = dgvMuonTra.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-1OVGN83\\SQLSERVER2022 ;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string insertCommand = "INSERT INTO PHIEUMUONSACH (NgayMuon, MaDocGia, NgayTraSach, MaNhanVien) " +
                "VALUES (@NgayMuon, @MaDocGia, @NgayTraSach, @MaNhanVien)";
            SqlCommand command = new SqlCommand(insertCommand, connection);

            command.Parameters.AddWithValue("@NgayMuon", txtNgayMuon.Text);
            command.Parameters.AddWithValue("@MaDocGia", comdocgia.SelectedValue);
            command.Parameters.AddWithValue("@NgayTraSach", txtNgayTra.Text);
            command.Parameters.AddWithValue("@MaNhanVien", comnhanvien.SelectedValue);

            command.ExecuteNonQuery();
            connection.Close();
            loaddata();
            connection.Close();
            MessageBox.Show("Thêm độc giả mới thành công!");
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Hủy")
            {

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvMuonTra.Enabled = true;
            }
            else
            {

                if (comdocgia.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã độc giả");

                }
                else if (comnhanvien.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");



                }
                else if (t.thucthidulieu("update  PHIEUMUONSACH set MaDocGia=N'" + comdocgia.Text + "', MaNhanVien=N'" + comnhanvien.Text + "'where MaPhieuMuon=N'" + txtmaphieu.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Hủy")
            {


                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvMuonTra.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtmaphieu.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from PHIEUMUONSACH where MaPhieuMuon='" + txtmaphieu.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata();





            }
        }

        private void dgvMuonTra2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            commasach.Text = dgvMuonTra2.CurrentRow.Cells[0].Value.ToString();
            commaphieumuon.Text = dgvMuonTra2.CurrentRow.Cells[1].Value.ToString();
            ngaymuon.Text = dgvMuonTra2.CurrentRow.Cells[2].Value.ToString();
            ngaytra.Text = dgvMuonTra2.CurrentRow.Cells[3].Value.ToString();
            txtTinhtrang.Text = dgvMuonTra2.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            ngaymuon.Text = "";
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(-3));//lay ngay hien tai tang them 3 ngay
            ngaytra.Value = result;


            btnLuu1.Enabled = true;

            btnTrasach.Enabled = false;
            btnGiahan.Text = "Hủy";
            btnThem1.Enabled = false;
            dgvMuonTra2.Enabled = false;
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaymuon.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql
            string ngayhhh = ngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(ngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            DataTable dt = t.docdulieu("select * from CHITIETPHIEUMUON where MaSach= '" + commasach.Text + "'");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Sách đã được mượn, vui lòng chọn cuốn khác", "Thông báo");
                commasach.Focus();
            }
            else if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                ngaytra.Focus();

            }
            else if (t.thucthidulieu("INSERT INTO CHITIETPHIEUMUON VALUES ('" + commaphieumuon.Text + "','" + commasach.SelectedValue.ToString() + "','" + ngayhh + "','" + ngayhhh + "','" + txtTinhtrang.Text + "')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata1();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thực hiện được");


            }
        }

        private void btnGiahan_Click(object sender, EventArgs e)
        {
            string ngayhhh = ngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(ngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            if (btnGiahan.Text == "Hủy")
            {
                btnLuu1.Enabled = false;
                btnGiahan.Enabled = true;
                btnTrasach.Enabled = true;
                btnTrasach.Text = "Xóa";
                btnGiahan.Text = "Gia hạn";
                btnThem1.Enabled = true;
                loaddata1();
                dgvMuonTra2.Enabled = true;
            }
            else if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                ngaytra.Focus();

            }
            else if (t.thucthidulieu("update  CHITIETPHIEUMUON set NgayTra='" + ngayhhh + "'where MaSach='" + commasach.Text + "'") == true)
            {

                MessageBox.Show("Gia hạn thành công");
                loaddata1();


            }
            else MessageBox.Show("Không thể gia hạn sách");

        }

        private void btnTrasach_Click(object sender, EventArgs e)
        {
            if (btnTrasach.Text == "Hủy")
            {

                btnLuu1.Enabled = false;
                btnGiahan.Enabled = true;
                btnTrasach.Enabled = true;
                btnTrasach.Text = "Trả sách";
                btnGiahan.Text = "Gia hạn";
                btnThem1.Enabled = true;
                loaddata1();
                dgvMuonTra2.Enabled = true;
            }
            else
            {

                DialogResult chon = MessageBox.Show("Bạn có muốn xóa/trả sách có mã " + commasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                

                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from CHITIETPHIEUMUON where MaSach='" + commasach.Text + "'");
                        MessageBox.Show("Đã trả sach" + commasach.Text + "", "Thông báo");
                        loaddata1();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata1();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }

        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();
        }
    }
}
