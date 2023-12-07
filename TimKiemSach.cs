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
    public partial class TimKiemSach : Form
    {
        Themxoasua t = new Themxoasua();
        public TimKiemSach()
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
            dgvSach.Columns[3].HeaderText = "Năm xuất bản";
            dgvSach.Columns[4].HeaderText = "Nhà xuất bản";
            dgvSach.Columns[5].HeaderText = "Trị giá";
            dgvSach.Columns[6].HeaderText = "Ngày nhập";
            dgvSach.Columns[7].HeaderText = "Mã thể loại";

            dgvSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgvSach.Enabled = true;
        }

        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("SELECT * FROM SACH WHERE MaSach like '%" + txtTimKiem.Text + "%'");
            DataTable dt6 = t.docdulieu("SELECT * FROM SACH WHERE TenSach like '%" + txtTimKiem.Text + "%'");

            if(rdbMaSach.Checked == true)
            {
                dgvSach.DataSource = dt5;
            }
            else
            {
                dgvSach.DataSource = dt6;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormChinh();
            f.Show();
        }
    }
}
