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
    public partial class frmDatNuoc : Form
    {
        public frmDatNuoc()
        {
            InitializeComponent();
        }

        private void frmDatNuoc_Load(object sender, EventArgs e)
        {
            SanBongDB db = new SanBongDB();
            List<Nuoc> listNuoc = db.Nuocs.ToList();
            List<HoaDon> listHoaDon = db.HoaDons.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDatNuoc_Click(object sender, EventArgs e)
        {
            SanBongDB db = new SanBongDB();
            List<Nuoc> listNuoc = db.Nuocs.ToList();
            List<HoaDon> listHoaDon = db.HoaDons.ToList();



            frmTinhTien f = new frmTinhTien();
            f.Show();
            this.Hide();
        }
    }
}
