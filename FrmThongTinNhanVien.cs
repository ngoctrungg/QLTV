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
    public partial class FrmThongTinNhanVien : Form
    {
        Themxoasua t = new Themxoasua();
        public FrmThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtManhanvien.Text = "";
            txtHovaten.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtMabangcap.Text = "";
            btnLuu.Enabled = true;
            //sua.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Text = "Hủy";
            btnThem.Enabled = false;
            dgvNhanvien.Enabled = false;
        }

        private void loaddata()
        {
            DataTable dt = t.docdulieu("select MaNhanVien,HoTenNhanVien,NgaySinh,DiaChi,DienThoai,MaBangCap from NHANVIEN");
            lblTs.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgvNhanvien.DataSource = dt;
            }
            dgvNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns[1].HeaderText = "Họ và tên";
            dgvNhanvien.Columns[2].HeaderText = "Ngày sinh";
            dgvNhanvien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanvien.Columns[4].HeaderText = "Điện thoại";
            dgvNhanvien.Columns[5].HeaderText = "Mã bằng cấp";


            dgvNhanvien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvNhanvien.Enabled = true;

        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManhanvien.Text = dgvNhanvien.CurrentRow.Cells[0].Value.ToString();
            txtHovaten.Text = dgvNhanvien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaysinh.Text = dgvNhanvien.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvNhanvien.CurrentRow.Cells[3].Value.ToString();
            txtDienthoai.Text = dgvNhanvien.CurrentRow.Cells[4].Value.ToString();
            txtMabangcap.Text = dgvNhanvien.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngayhh = dtpNgaysinh.Value.ToString("yyyy/MM/dd");
            
            if (txtHovaten.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txtHovaten.Focus();


            }
            else if (txtDiachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtDiachi.Focus();


            }
            else if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập điện thoại");
                txtDienthoai.Focus();
            }
            else if (txtMabangcap.Text == "")
            {
                MessageBox.Show("Chưa nhập điện thoại");
                txtMabangcap.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO NHANVIEN(HoTenNhanVien,NgaySinh,DiaChi,DienThoai,MaBangCap) VALUES (N'" + txtHovaten.Text + "','" + ngayhh + "','" + txtDiachi.Text + "','" + txtDienthoai.Text + "','" + txtMabangcap.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else
            {
                MessageBox.Show("Lỗi");

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
                dgvNhanvien.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtManhanvien.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from NHANVIEN where MaNhanVien='" + txtManhanvien.Text + "'") == true)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngayhh = dtpNgaysinh.Value.ToString("yyyy/MM/dd");

            if (btnSua.Text == "Hủy")
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvNhanvien.Enabled = true;
            }
            else
            {

                if (txtHovaten.Text == "")
                {
                    txtHovaten.Focus();

                }
                else if (txtDiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtDiachi.Focus();


                }
                else if (txtDienthoai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại");
                    txtDienthoai.Focus();


                }
                else if (txtMabangcap.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại");
                    txtMabangcap.Focus();


                }
                else if (t.thucthidulieu("update  NHANVIEN set HoTenNhanVien=N'" + txtHovaten.Text + "', NgaySinh=N'" + ngayhh + "', DiaChi=N'" + txtDiachi.Text + "', DienThoai='" + txtDienthoai.Text + "'where MaNhanVien=N'" + txtManhanvien.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }
    }
}
