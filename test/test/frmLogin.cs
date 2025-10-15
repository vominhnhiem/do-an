using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Models;

namespace test
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            NguoiDungDB context = new NguoiDungDB();
            List<NguoiDung> list = context.NguoiDungs.ToList();
            if (txtTK.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                frmHome frmHome = new frmHome();
                frmHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy f = new frmDangKy();
            f.Show();
            this.Hide();
        }
    }
}
