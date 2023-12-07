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
    public partial class TimKiemDocGia : Form
    {
        Themxoasua t = new Themxoasua();
        public TimKiemDocGia()
        {
            InitializeComponent();
        }

        private void Loaddata()
        {
            DataTable dt = t.docdulieu("SELECT * FROM DOCGIA");
            lblTS.Text = dt.Rows.Count.ToString();

            if (dt !=null )
            {
                dgvDocGia.DataSource = dt;
            }
            dgvDocGia.Columns[0].HeaderText = "Mã độc giả";
            dgvDocGia.Columns[1].HeaderText = "Họ và tên";
            dgvDocGia.Columns[2].HeaderText = "Ngày Sinh";
            dgvDocGia.Columns[3].HeaderText = "Địa chỉ";
            dgvDocGia.Columns[4].HeaderText = "Email";
            dgvDocGia.Columns[5].HeaderText = "Ngày lập thẻ";
            dgvDocGia.Columns[6].HeaderText = "Ngày hết hạn";
            dgvDocGia.Columns[7].HeaderText = "Tiền nợ";

            dgvDocGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            dgvDocGia.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TimKiemDocGia_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("SELECT * FROM DOCGIA WHERE MaDocGia like '%" + txtTimKiem.Text + "%'");
            DataTable dt6 = t.docdulieu("SELECT * FROM DOCGIA WHERE HoTenDocGia like '%" + txtTimKiem.Text + "%'");

            if (rdbMaDocGia.Checked == true)
            {
                dgvDocGia.DataSource = dt5;
            }
            else
            {
                dgvDocGia.DataSource = dt6;
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
