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
    public partial class CNNhaXuatBan : Form
    {
        Themxoasua t = new Themxoasua();
        public CNNhaXuatBan()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from NHAXB");

            if (dt != null)
            {
                dgvNhaXuatBan.DataSource = dt;
            }
            dgvNhaXuatBan.Columns[0].HeaderText = "Mã nhà Xuất Bản";
            dgvNhaXuatBan.Columns[1].HeaderText = "Tên nhà Xuất Bản";
            dgvNhaXuatBan.Columns[2].HeaderText = "Địa chỉ";
            dgvNhaXuatBan.Columns[3].HeaderText = "Số Điện Thoại";
            dgvNhaXuatBan.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvNhaXuatBan.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
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
                dgvNhaXuatBan.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtMaNhaXuatBan.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from NHAXB where MaNhaXB='" + txtMaNhaXuatBan.Text + "'") == true)
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

        private void CNNhaXuatBan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgvNhaXuatBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhaXuatBan.Text = dgvNhaXuatBan.CurrentRow.Cells[0].Value.ToString();
            txtTenNhaXuatBan.Text = dgvNhaXuatBan.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaXuatBan.CurrentRow.Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvNhaXuatBan.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNhaXuatBan.Text = "";
            txtTenNhaXuatBan.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvNhaXuatBan.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "hủy")
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvNhaXuatBan.Enabled = true;
            }
            else
            {
                if (txtTenNhaXuatBan.Text == "")
                {
                    MessageBox.Show("Nhà xuất bản chưa có thông tin");
                    txtTenNhaXuatBan.Focus();

                }
                else if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtDiaChi.Focus();


                }
                else if (t.thucthidulieu("update  nhaxb set TenNhaXB=N'" + txtTenNhaXuatBan.Text + "', DiaChi=N'" + txtDiaChi.Text + "', DienThoai='" + txtSoDienThoai.Text + "'where MaNhaXB=N'" + txtMaNhaXuatBan.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            if (txtMaNhaXuatBan.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà xuất bản");
                txtMaNhaXuatBan.Focus();

            }
            else if (txtTenNhaXuatBan.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhà xuất bản");
                txtTenNhaXuatBan.Focus();


            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtDiaChi.Focus();


            }
            else if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txtSoDienThoai.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO NHAXB VALUES ('" + txtMaNhaXuatBan.Text + "','" + txtTenNhaXuatBan.Text + "','" + txtDiaChi.Text + "','" + txtSoDienThoai.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }
    }
}
