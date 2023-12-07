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
    public partial class QuanLySach : Form
    {
        Themxoasua t = new Themxoasua();
        public QuanLySach()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from SACH");

            if (dt != null)
            {
                dgvQuanLySach.DataSource = dt;
            }
            dgvQuanLySach.Columns[0].HeaderText = "Mã Sách";
            dgvQuanLySach.Columns[1].HeaderText = "Tên Sách";
            dgvQuanLySach.Columns[2].HeaderText = "Tác Giả";
            dgvQuanLySach.Columns[3].HeaderText = "Năm Xuất Bản";
            dgvQuanLySach.Columns[4].HeaderText = "Nhà Xuất Bản";
            dgvQuanLySach.Columns[5].HeaderText = "Trị Giá";
            dgvQuanLySach.Columns[6].HeaderText = "Ngày Nhập";
            dgvQuanLySach.Columns[7].HeaderText = "Mã thể loại";

            dgvQuanLySach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvQuanLySach.Enabled = true;

        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from SACH where MaSach like '%" + txtTimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from SACH where TenSach like '%" + txtTimkiem.Text + "%'");
            if (rdbMaSach.Checked == true)
            {
                dgvQuanLySach.DataSource = dt5;
            }
            else dgvQuanLySach.DataSource = dt6;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMasach.Text = "";
            txtTensach.Text = "";
            txtTentacgia.Text = "";
            txtNamxb.Text = "";
            txtNhaxb.Text = "";
            txtTrigia.Text = "";
            txtNgaynhap.Text = "";
            txtMatl.Text = "";

            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Text = "Hủy";
            btnThem.Enabled = false;
            dgvQuanLySach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Hủy")
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvQuanLySach.Enabled = true;
            }

            else
            {
                if (txtTensach.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên sách");
                    txtTensach.Focus();

                }
                else if (txtTentacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tác giả");
                    txtTentacgia.Focus();
                }
                else if (txtNamxb.Text == "")
                {
                    MessageBox.Show("Chưa nhập năm xuất bản");
                    txtNamxb.Focus();
                }
                else if (txtNhaxb.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên nhà xuất bản");
                    txtNhaxb.Focus();
                }
                else if (txtMatl.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã thể loại");
                    txtMatl.Focus();
                }
                else if (t.thucthidulieu("update  SACH set TenSach=N'" + txtTensach.Text + "', Tacgia=N'" + txtTentacgia.Text + "', NamXuatBan='" + txtNamxb.Text + "', NhaXuatBan='" + txtNhaxb.Text + "', Matheloai='" + txtMatl.Text + "'where MaSach=N'" + txtMasach.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();

                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "hủy")
            {

                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvQuanLySach.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtMasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from SACH where MaSach='" + txtMasach.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo");
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

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtTensach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sách");
                txtTensach.Focus();

            }
            else if (txtTentacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tác giả");
                txtTentacgia.Focus();
            }
            else if (txtNamxb.Text == "")
            {
                MessageBox.Show("Chưa nhập năm xuất bản");
                txtNamxb.Focus();
            }
            else if (txtNhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhà xuất bản");
                txtNhaxb.Focus();
            }
            else if (txtMatl.Text == "")
            {
                MessageBox.Show("Chưa nhập mã thể loại");
                txtMatl.Focus();
            }
            //else if (t.thucthidulieu("insert  SACH set TenSach=N'" + txtTensach.Text + "', Tacgia=N'" + txtTentacgia.Text + "', NamXuatBan='" + txtNamxb.Text + "', NhaXuatBan='" + txtTennxb.Text + "', NamXuatBan='" + txtNamxb.Text + "', TriGia='" + txtTrigia.Text + "',NgayNhap=N'" + txtNgaynhap.Text + "', Matheloai='" + txtMatl.Text + "'where MaSach=N'" + txtMasach.Text + "'") == true)

            else if (t.thucthidulieu("INSERT INTO SACH VALUES (N'" + txtTensach.Text + "','" + txtTentacgia.Text + "','" + txtNamxb.Text + "','" + txtNhaxb + "','" + txtTrigia + "','" + txtNgaynhap + "','" + txtMatl + "')") == true)
            
            {

                MessageBox.Show("Thêm Thành Công");
                loaddata();
                //txtmasach.Enabled = true;

            }
            else MessageBox.Show("Lỗi");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }

        private void dgvQuanLySach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasach.Text = dgvQuanLySach.CurrentRow.Cells[0].Value.ToString();
            txtTensach.Text = dgvQuanLySach.CurrentRow.Cells[1].Value.ToString();
            txtTentacgia.Text = dgvQuanLySach.CurrentRow.Cells[2].Value.ToString();
            txtNamxb.Text = dgvQuanLySach.CurrentRow.Cells[3].Value.ToString();
            txtNhaxb.Text = dgvQuanLySach.CurrentRow.Cells[4].Value.ToString();
            txtTrigia.Text = dgvQuanLySach.CurrentRow.Cells[5].Value.ToString();
            txtNgaynhap.Text = dgvQuanLySach.CurrentRow.Cells[6].Value.ToString();
            txtMatl.Text = dgvQuanLySach.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
