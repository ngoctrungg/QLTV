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
    public partial class QuanLyDocGia : Form
    {
        Themxoasua t = new Themxoasua();
        public QuanLyDocGia()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from DOCGIA");
            lblts.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dgvDocGia.DataSource = dt;
            }
            dgvDocGia.Columns[0].HeaderText = "Mã độc giả";
            dgvDocGia.Columns[1].HeaderText = "Họ và tên";
            dgvDocGia.Columns[2].HeaderText = "Ngày sinh";
            dgvDocGia.Columns[3].HeaderText = "Địa chỉ";
            dgvDocGia.Columns[4].HeaderText = "Email";
            dgvDocGia.Columns[5].HeaderText = "Ngày lập thẻ";
            dgvDocGia.Columns[6].HeaderText = "Ngày hết hạn";
            dgvDocGia.Columns[7].HeaderText = "Tiền nợ";



            dgvDocGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvDocGia.Enabled = true;

        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmadocgia.Text = dgvDocGia.CurrentRow.Cells[0].Value.ToString();
            txttendocgia.Text = dgvDocGia.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = dgvDocGia.CurrentRow.Cells[2].Value.ToString();
            txtdiachi.Text = dgvDocGia.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgvDocGia.CurrentRow.Cells[4].Value.ToString();
            txtngaylapthe.Text = dgvDocGia.CurrentRow.Cells[5].Value.ToString();
            txtngayhethan.Text = dgvDocGia.CurrentRow.Cells[6].Value.ToString();
            txttienno.Text = dgvDocGia.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-1OVGN83\\SQLSERVER2022 ;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string insertCommand = "INSERT INTO DOCGIA (HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, TienNo) " +
                "VALUES (@HoTenDocGia, @NgaySinh, @DiaChi, @Email, @NgayLapThe, @NgayHetHan, @TienNo)";
            SqlCommand command = new SqlCommand(insertCommand, connection);

            command.Parameters.AddWithValue("@HoTenDocGia", txttendocgia.Text);
            command.Parameters.AddWithValue("@NgaySinh", ngaysinh.Value);
            command.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
            command.Parameters.AddWithValue("@Email", txtemail.Text);
            command.Parameters.AddWithValue("@NgayLapThe", txtngaylapthe.Text);
            command.Parameters.AddWithValue("@NgayHetHan", txtngayhethan.Text);
            command.Parameters.AddWithValue("@TienNo", float.Parse(txttienno.Text));


            command.ExecuteNonQuery();
            connection.Close();
            loaddata();
            connection.Close();
            MessageBox.Show("Thêm độc giả mới thành công!");
           
        }

        private void Luu_Click(object sender, EventArgs e)
        {

        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");
            
            if (btnSua.Text == "Hủy")
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvDocGia.Enabled = true;
            }
            else 
            {

                if (txttendocgia.Text == "")
                {
                    txttendocgia.Focus();

                }
                else if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtdiachi.Focus();
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Chưa nhập Email");
                    txtemail.Focus();
                }
                else if (t.thucthidulieu("update  DOCGIA set HoTenDocGia=N'" + txttendocgia.Text + "', NgaySinh=N'" + ngayhh + "', DiaChi=N'" + txtdiachi.Text + "', Email='" + txtemail.Text + "', NgayLapThe='" + txtngaylapthe.Text + "', NgayHetHan='" + txtngayhethan.Text + "', TienNo='" + txttienno.Text + "'where MaDocGia=N'" + txtmadocgia.Text + "'") == true)
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
                dgvDocGia.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả có mã số " + txtmadocgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from DOCGIA where MaDocGia='" + txtmadocgia.Text + "'") == true)
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
    }
}
