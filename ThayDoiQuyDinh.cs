using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QLTiecCuoi
{
    public partial class ThayDoiQuyDinh : Form
    {
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btYC1_Click(object sender, EventArgs e)
        {
            YC6_1_1 yc = new YC6_1_1();
            yc.ShowDialog();
        }

        private void btYC2_Click(object sender, EventArgs e)
        {

        }

        private void btYC3_Click(object sender, EventArgs e)
        {
            ThayDoiCa yc = new ThayDoiCa();
            yc.ShowDialog();
        }

        private void btYC4_Click(object sender, EventArgs e)
        {
            YC6_2_2 yc = new YC6_2_2();
            yc.ShowDialog();
        }

        private void btYC5_Click(object sender, EventArgs e)
        {
            CapNhapMonAn yc = new CapNhapMonAn();
            yc.ShowDialog();

        }

        private void btYC6_Click(object sender, EventArgs e)
        {
            ////YC6_3 yc = new YC6_3();
            //this.Dispose();
            //yc.ShowDialog();

        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien QLNV = new QuanLyNhanVien();
            QLNV.ShowDialog();
        }
    }
}
