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

    public partial class CNTacGia : Form
    {
        public CNTacGia()
        {
            InitializeComponent();
        }
        Themxoasua t = new Themxoasua();

        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from TACGIA");

            if (dt != null)
            {
                dgvTacGia.DataSource = dt;
            }
            dgvTacGia.Columns[0].HeaderText = "Mã tác giả";
            dgvTacGia.Columns[1].HeaderText = "Tên tác giả";

            dgvTacGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvTacGia.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmatacgia.Text = "";
            txttentacgia.Text = "";
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Text = "Hủy";
            btnThem.Enabled = false;
            dgvTacGia.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Hủy")
            {

                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                loaddata();
                dgvTacGia.Enabled = true;


            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmatacgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from tacgia where matacgia='" + txtmatacgia.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Không thể xóa", "Thông báo");
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
            if (txtmatacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã tác giả");
                txtmatacgia.Focus();

            }
            else if (txttentacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tác giả");
                txttentacgia.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO TACGIA VALUES ('" + txtmatacgia.Text + "', '" + txttentacgia.Text + "')") == true)
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
                dgvTacGia.Enabled = true;


            }
            else
            {


                if (txtmatacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã tác giả");
                    txtmatacgia.Focus();

                }
                else if (txttentacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tác giả");
                    txttentacgia.Focus();


                }
                else if (t.thucthidulieu("update  TACGIA set Tentacgia=N'" + txttentacgia.Text + "'where Matacgia=N'" + txtmatacgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void CNTacGia_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
