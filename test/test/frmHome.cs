using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class frmHome : Form
    {
        bool isExit = true;
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            bool isExit = false;
            frmDatSan f = new frmDatSan();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTaiKhoang f = new frmTaiKhoang();
            f.Show();
            this.Hide();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnOrderNuoc_Click(object sender, EventArgs e)
        {
            frmDatNuoc f = new frmDatNuoc();
            f.Show();
            this.Hide();
        }

        private void btnLichDatSan_Click(object sender, EventArgs e)
        {
            frmLichDatSan f = new frmLichDatSan();
            f.Show();
            this.Hide();
        }
    }
}
