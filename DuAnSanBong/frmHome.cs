using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnSanBong
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadChildForm(Form childForm)
        {
            // 1. Xóa hết các Controls đang có trong Panel (nếu có)
            pnlHienThi.Controls.Clear();

            // 2. Thiết lập Form Con
            childForm.TopLevel = false; // Thiết lập Form Con không phải là cấp cao nhất
            childForm.FormBorderStyle = FormBorderStyle.None; // Xóa viền Form Con
            childForm.Dock = DockStyle.Fill; // Làm Form Con tự động lấp đầy Panel

            // 3. Thêm Form Con vào Panel
            pnlHienThi.Controls.Add(childForm);
            pnlHienThi.Tag = childForm; // Lưu trữ tham chiếu Form

            // 4. Hiển thị
            childForm.Show();
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmDatSan());
        }

        private void btnDatNuoc_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmDatNuoc());
        }

        private void btnLichSan_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmLichSan());
        }
    }
}
