﻿using System;
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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Đăng ký thành công");
            frmLogin f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void btnHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
