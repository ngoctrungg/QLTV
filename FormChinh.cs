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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Form m = new Formchinh();
            //m.Hide();
            Form f = new FrmLogin();
            f.Show();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuDocGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new QuanLyDocGia();
            f.Show();
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FrmThongTinNhanVien();
            f.Show();
        }

        private void menuQuanLySach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FrmSach();
            f.Show();
        }

        private void menuMuonTra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMuonTra();
            f.Show();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new TimKiemSach();
            f.Show();
        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new TimKiemDocGia();
            f.Show();
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new TKSach1();
            f.Show();
        }

        private void thốngKêĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new TKDocGia();
            f.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new CNNhaXuatBan();
            f.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new CNTacGia();
            f.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FrmAbout();
            f.Show();
        }
    }
}
