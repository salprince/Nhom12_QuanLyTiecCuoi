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
    public partial class YC4_Search : Form
    {
        BUS_YC4 busYC4 = new BUS_YC4();
        Image im;
        public YC4_Search()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void YC4_Search_Load(object sender, EventArgs e)
        {
            datagv_hoadon.DataSource = busYC4.getHoaDon();

            // Load Combobox
            for (int i = 1; i <= 31; i++)
            {
                comboboxNgay.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                comboboxThang.Items.Add(i);
            }
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            if (comboboxNgay.Text != "" && comboboxThang.Text != "" && txtNam.Text != "")
            {
                int ngaytt = int.Parse(comboboxNgay.Text.ToString());
                int thangtt = int.Parse(comboboxThang.Text.ToString());
                int namtt = int.Parse(txtNam.Text.ToString());

                if (busYC4.KTNgay(ngaytt, thangtt, namtt) == true)
                {
                    string NgayThanhToan = "";
                    if (ngaytt < 10)
                    {
                        NgayThanhToan += "0" + ngaytt.ToString() + "/";
                    }
                    else NgayThanhToan += ngaytt.ToString() + "/";
                    if (thangtt < 10)
                    {
                        NgayThanhToan += "0" + thangtt.ToString() + "/";
                    }
                    else NgayThanhToan += thangtt.ToString() + "/";
                    NgayThanhToan += namtt.ToString();

                    datagv_hoadon.DataSource = busYC4.searchHoaDon_NgayTT(NgayThanhToan);
                }
                else
                {
                    MessageBox.Show("Ngày tháng năm không hợp lệ !");
                }
            }
        }

        // Reset lại datagv
        private void button1_Click(object sender, EventArgs e)
        {
            datagv_hoadon.DataSource = busYC4.getHoaDon();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void bt_trangchu_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.Image = im;
        }

        private void btVeTrangChu_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            im = bt.Image;
            bt.Image = null;
        }
    }
}
