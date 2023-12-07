﻿using System;
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
    public partial class FrmCapnhatsach : Form
    {
        Themxoasua t = new Themxoasua();
        public FrmCapnhatsach()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from SACH");

            if (dt != null)
            {
                dgvSach.DataSource = dt;
            }
            dgvSach.Columns[0].HeaderText = "Mã Sách";
            dgvSach.Columns[1].HeaderText = "Tên Sách";
            dgvSach.Columns[2].HeaderText = "Tác Giả";
            dgvSach.Columns[3].HeaderText = "Năm Xuất Bản";
            dgvSach.Columns[4].HeaderText = "Nhà Xuất Bản";
            dgvSach.Columns[5].HeaderText = "Trị Giá";
            dgvSach.Columns[6].HeaderText = "Ngày Nhập";
            dgvSach.Columns[7].HeaderText = "Mã thể loại";



            dgvSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btnXoa.Enabled = true;
            btnSua.Text = "Sửa";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dgvSach.Enabled = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCapnhatsach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from SACH where MaSach like '%" + txtTimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from SACH where TenSach like '%" + txtTimkiem.Text + "%'");
            if (rdbMasach.Checked == true)
            {
                dgvSach.DataSource = dt5;
            }
            else dgvSach.DataSource = dt6;
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
            btnSua.Text = "hủy";
            btnThem.Enabled = false;
            dgvSach.Enabled = false;
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
                dgvSach.Enabled = true;


            }
            else
            {
                //txtMasach.Enabled = false;


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
                    //txtmasach.Enabled = true;

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
                dgvSach.Enabled = true;




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
            else if (t.thucthidulieu("INSERT INTO SACH VALUES (N'" + txtMasach.Text + "','" + txtTensach.Text + "','" + txtTentacgia.Text + "','" + txtNamxb.Text + "','" + txtNhaxb + "','" + txtTrigia + "','" + txtNgaynhap + "','" + txtMatl + "')") == true)
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

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
            txtTensach.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
            txtTentacgia.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
            txtNamxb.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
            txtNhaxb.Text = dgvSach.CurrentRow.Cells[4].Value.ToString();
            txtMatl.Text = dgvSach.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
