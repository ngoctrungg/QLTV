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

namespace DA_QLThuVien
{
    public partial class FrmSach : Form
    {
        Themxoasua t = new Themxoasua();

        public FrmSach()
        {
            InitializeComponent();
            
        }

        private void loaddata()
        {
            dgvSach.DataSource = DataProvider.TruyVan_LayDuLieu("SELECT MaSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap, MaTheLoai FROM SACH");
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-1OVGN83\\SQLSERVER2022 ;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string insertCommand = "INSERT INTO SACH (TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap, MaTheLoai) " +
                "VALUES (@TenSach, @TacGia, @NamXuatBan, @NhaXuatBan, @TriGia, @NgayNhap, @MaTheLoai)";
            SqlCommand command = new SqlCommand(insertCommand, connection);

            command.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
            command.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
            command.Parameters.AddWithValue("@NamXuatBan", int.Parse(txtNamXB.Text));
            command.Parameters.AddWithValue("@NhaXuatBan", txtNhaXb.Text);
            command.Parameters.AddWithValue("@TriGia", float.Parse(txtTriGia.Text));
            command.Parameters.AddWithValue("@NgayNhap", dtNhap.Value);
            command.Parameters.AddWithValue("@MaTheLoai", int.Parse(txtMatl.Text));


            command.ExecuteNonQuery();
            connection.Close();
            loaddata();
            connection.Close();
            MessageBox.Show("Thêm sách mới thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtMaSach.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    if (t.thucthidulieu("delete from SACH where MaSach='" + txtMaSach.Text + "'") == true)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
            txtTacGia.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
            txtNamXB.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
            txtNhaXb.Text = dgvSach.CurrentRow.Cells[4].Value.ToString();
            txtTriGia.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
            dtNhap.Text = dgvSach.CurrentRow.Cells[6].Value.ToString();
            txtMatl.Text = dgvSach.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "hủy")
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvSach.Enabled = true;


            }
            else
            {
                //txtMasach.Enabled = false;


                if (txtTenSach.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên sách");
                    txtTenSach.Focus();

                }
                else if (txtTacGia.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tác giả");
                    txtTacGia.Focus();
                }
                else if (txtNamXB.Text == "")
                {
                    MessageBox.Show("Chưa nhập năm xuất bản");
                    txtNamXB.Focus();
                }
                else if (txtNhaXb.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên nhà xuất bản");
                    txtNhaXb.Focus();
                }
                else if (txtMatl.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã thể loại");
                    txtMatl.Focus();
                }
                else if (t.thucthidulieu("update  SACH set TenSach=N'" + txtTenSach.Text + "', Tacgia=N'" + txtTacGia.Text + "', NamXuatBan='" + txtNamXB.Text + "', NhaXuatBan='" + txtNhaXb.Text + "', Matheloai='" + txtMatl.Text + "'where MaSach=N'" + txtMaSach.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                    //txtmasach.Enabled = true;

                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");

            }
        }
    }
}
