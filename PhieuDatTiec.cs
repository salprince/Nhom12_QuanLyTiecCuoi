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
    public partial class PhieuDatTiec : Form
    {
        BUS_DichVu busTC = new BUS_DichVu(); Image im;
        private string _MaTiecCuoi;
        private int _DonGiaBanToiThieu;
        private string _MaSanh;

        public string MaSanh
        {
            get { return this._MaSanh; }
            set { this._MaSanh = value; }
        }
        public PhieuDatTiec()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string MaTiecCuoi
        {
            get { return this._MaTiecCuoi; }
            set { this._MaTiecCuoi = value; }
        }

        public int DonGiaBanToiThieu
        {
            get { return this._DonGiaBanToiThieu; }
            set { this._DonGiaBanToiThieu = value; }
        }

        public void resetForm()
        {
            textBoxLoaiBan.Text = "";
            textBoxSoLuongBan.Text = "";
            textBoxSoLuongBanDuTru.Text = "";
            textBoxGhiChu.Text = "";
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaTiecCuoi.Text != "" && textBoxLoaiBan.Text != "" && textBoxSoLuongBan.Text != "" && textBoxSoLuongBanDuTru.Text != "")
            {
                int sluong = int.Parse(textBoxSoLuongBan.Text.ToString()) + int.Parse(textBoxSoLuongBanDuTru.Text.ToString());

                if (busTC.checkSoLuongBanToiDa(MaSanh, sluong) == true)
                {
                    DataTable pdb = busTC.getPhieuDatBan();
                    int t = pdb.Rows.Count;
                    string maphieudatban = "";
                    if (t < 9)
                    {
                        maphieudatban = "DB0" + (t + 1).ToString();
                    }
                    else
                    {
                        maphieudatban = "DB" + (t + 1).ToString();
                    }
                    DTO_PhieuDatBan PDB = new DTO_PhieuDatBan(maphieudatban, textBoxMaTiecCuoi.Text, textBoxLoaiBan.Text, int.Parse(textBoxSoLuongBan.Text.ToString()), int.Parse(textBoxSoLuongBanDuTru.Text.ToString()), 0, textBoxGhiChu.Text);

                    if (busTC.themPhieuDatBan(PDB))
                    {
                        MessageBox.Show("Thêm thành công!");
                        dgvban.DataSource = busTC.getPhieuDatBan(textBoxMaTiecCuoi.Text);

                        CT_PhieuDatBan frm = new CT_PhieuDatBan(MaTiecCuoi);
                        resetForm();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vượt quá số lượng bàn cho phép!");
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void PhieuDat_Load(object sender, EventArgs e)
        {
            textBoxMaTiecCuoi.Text = _MaTiecCuoi;
        }


        private void textBoxSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSoLuongBanDuTru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            im = bt.Image;
            bt.Image = null;
        }

        private void bt_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.Image = im;
        }

    }
}
