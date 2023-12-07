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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sql = $"SELECT * FROM NguoiDung WHERE Username = '{txtUsername.Text}' AND  Password = '{txtPassword.Text}'";
            //MessageBox.Show(sql); 
            var data = DataProvider.TruyVan_LayDuLieu(sql);
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                Form f = new FormChinh();
                f.Show();

            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
