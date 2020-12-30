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
    public partial class DanhSachSanh : Form
    {
        BUS_Sanh Sanh = new BUS_Sanh();
        Image im;
        public DanhSachSanh()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgvSanh.DataSource = Sanh.getSanh();
        }

        private void dgvSanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                textms.DataBindings.Clear();
                textms.Text = dgvSanh.Rows[index].Cells[0].Value.ToString();
                textts.DataBindings.Clear();
                textts.Text = dgvSanh.Rows[index].Cells[1].Value.ToString();
                textsb.DataBindings.Clear();
                textsb.Text = dgvSanh.Rows[index].Cells[2].Value.ToString();
                textSoBanToiThieu.DataBindings.Clear();
                textSoBanToiThieu.Text = dgvSanh.Rows[index].Cells[3].Value.ToString();
                txtdg.DataBindings.Clear();
                txtdg.Text = dgvSanh.Rows[index].Cells[4].Value.ToString();
                textGhiChu.DataBindings.Clear();
                textGhiChu.Text = dgvSanh.Rows[index].Cells[5].Value.ToString();
            }

            catch (Exception ex)
            {

            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btDatSanh_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            im = bt.Image;
            bt.Image = null;
        }

        private void btDatSanh_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.Image = im;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textdg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
