using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLTiecCuoi
{
    public partial class CT_PhieuDatBan : Form
    {
        public string MaTiecCuoi { get; set; }

        public int DonGiaBanToiThieu { get; set; }
        public Form parent { get; set; }
        public int SoLuong { get; set; }
        private string maMonAn = "";
        private string donGia = "";
        private string ghiChu = "";
        BUS_TiecCuoi BusTiecCuoi = new BUS_TiecCuoi();
        BUS_DichVu busTC = new BUS_DichVu();
        DAL.DAL_YC2 dalTiecCuoi = new DAL_YC2();
        public CT_PhieuDatBan(String maTC)
        {
            InitializeComponent();
            this.MaTiecCuoi = maTC;
            this.CenterToScreen();
            List<DTO_CT_PhieuDatBan> list = dalTiecCuoi.LoadDuLieuMA();
        }

       
        public void resetForm()
        {
            textBoxMaMonAn.Text = "";
            textBoxTenMonAn.Text = "";
            textBoxDonGia.Text = "";
            textBoxGhiChu.Text = "";
        }

        private void dgvTD_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvTD.CurrentRow.Index;
            textBoxMaMonAn.Text = dgvTD.Rows[i].Cells[0].Value.ToString();
            textBoxTenMonAn.Text = dgvTD.Rows[i].Cells[1].Value.ToString();
            textBoxDonGia.Text = dgvTD.Rows[i].Cells[2].Value.ToString();
        }

        private void Thongtintieccuoi_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dgvTD.DataSource = busTC.getMonAn();
            dgv_DaDat.DataSource = busTC.getMonAnDaDat(MaTiecCuoi);
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {    
            DTO_CT_PhieuDatBan r = new DTO_CT_PhieuDatBan(MaTiecCuoi, textBoxMaMonAn.Text, textBoxGhiChu.Text);
            //Console.WriteLine($" ma tiec cuoi = {this.MaTiecCuoi}");
            if (busTC.themCT_PhieuDatBan(r))
            {
                maMonAn = "";
                donGia = "";
                ghiChu = "";
                dgv_DaDat.DataSource = busTC.getMonAnDaDat(MaTiecCuoi);
                
                //MessageBox.Show("Đặt món ăn thành công");
                resetForm();
            }
            else
                MessageBox.Show("Món đã được đặt rồi");
        }

        
        private void CT_PhieuDatBan_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvTD.CurrentRow.Index;

            textBoxMaMonAn.Text = dgvTD.Rows[i].Cells[0].Value.ToString();
            textBoxTenMonAn.Text = dgvTD.Rows[i].Cells[1].Value.ToString();
            textBoxDonGia.Text = dgvTD.Rows[i].Cells[2].Value.ToString();
        }

        private void dgvTD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTD.SelectedRows.Count == 0)
                return;
            //00 Mã, 10 tên, 20 giá

            textBoxDonGia.Text = dgvTD[2, dgvTD.SelectedRows[0].Index].Value.ToString();
            textBoxTenMonAn.Text = dgvTD[1, dgvTD.SelectedRows[0].Index].Value.ToString();
            textBoxMaMonAn.Text = dgvTD[0, dgvTD.SelectedRows[0].Index].Value.ToString();
        }

        private void buttonTimKiem_Click_1(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                dgvTD.DataSource = busTC.TimKiemMonAn(textBoxSearch.Text);
            }

        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            //datagv_MADat.Rows.RemoveAt(this.datagv_MADat.SelectedRows[0].Index);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            CT_PhieuDatDichVu pDatDV = new CT_PhieuDatDichVu(MaTiecCuoi);
            pDatDV.parent = this;
            this.Hide();
            pDatDV.ShowDialog();
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("BẠN CÓ CHẮC MUỐN HỦY TIỆC", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (busTC.xoaCT_PhieuDatBan(MaTiecCuoi, 1) && busTC.xoaTiecCuoi(MaTiecCuoi)&&BusTiecCuoi.xoaPhieuDatBan(MaTiecCuoi))
                {
                    MessageBox.Show("Hủy tiệc thành công");
                    this.Close();
                    this.parent.Show();
                }
                else
                    MessageBox.Show("Huy tiec that bai");
            }           
        }

        private void quayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this.parent != null)
                parent.Show();
        }
    }
}
