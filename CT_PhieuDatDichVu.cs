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
    public partial class CT_PhieuDatDichVu : Form
    {
        public String MaTiecCuoi { get; set; }
        public Form parent { get; set; }
        BUS_DichVu busTC = new BUS_DichVu();
        BUS_TiecCuoi TiecCuoi = new BUS_TiecCuoi();
        Image im;
        public CT_PhieuDatDichVu(String maTC)
        {
            InitializeComponent();
            this.MaTiecCuoi = maTC;
            this.CenterToScreen();
        }

        private void PhieuDatDichVu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            datagv_PhieuDatDichVu.DataSource = busTC.getDichvu();

        }
        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                datagv_PhieuDatDichVu.DataSource = busTC.TimKiemDichVu(textBoxSearch.Text);
            }

            // Reset form
            textBoxMaDichVu.Text = "";
            textBoxTenDichVu.Text = "";
            textBoxMoTa.Text = "";
            textBoxDonGia.Text = "";
            textBoxGhiChu.Text = "";
            textBoxSoLuong.Text = "";
            textBoxMaDichVu.ReadOnly = false;
        }
        private void datagv_PhieuDatDichVu_Click(object sender, EventArgs e)
        {
            int i;
            i = datagv_PhieuDatDichVu.CurrentRow.Index;
            textBoxMaDichVu.Text = datagv_PhieuDatDichVu.Rows[i].Cells[0].Value.ToString();
            textBoxTenDichVu.Text = datagv_PhieuDatDichVu.Rows[i].Cells[1].Value.ToString();
            textBoxMoTa.Text = datagv_PhieuDatDichVu.Rows[i].Cells[2].Value.ToString();
            textBoxDonGia.Text = datagv_PhieuDatDichVu.Rows[i].Cells[3].Value.ToString();
            textBoxGhiChu.Text = datagv_PhieuDatDichVu.Rows[i].Cells[4].Value.ToString();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            //datagv_DVDat.Rows.RemoveAt(this.datagv_DVDat.SelectedRows[0].Index);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //datagv_DVDat.Rows.RemoveAt(this.datagv_DVDat.SelectedRows[0].Index);
            if (textBoxSearch.Text != "")
            {
                datagv_PhieuDatDichVu.DataSource = busTC.TimKiemDichVu(textBoxSearch.Text);
            }

        }


        private void btn_Chon_Click(object sender, EventArgs e)
        {
            if (MaTiecCuoi != "" && textBoxMaDichVu.Text != "" && textBoxSoLuong.Text != "" && textBoxDonGia.Text != "")
            {
                Console.WriteLine($"MATIECCUOI {MaTiecCuoi}");
                DTO_PhieuDatDichVu PDDV = new DTO_PhieuDatDichVu(MaTiecCuoi, textBoxMaDichVu.Text, int.Parse(textBoxSoLuong.Text.ToString()), int.Parse(textBoxDonGia.Text.ToString()));

                if (busTC.themPhieuDatDV(PDDV))
                {
                    MessageBox.Show("Chọn dịch vụ thành công!");
                    textBoxMaDichVu.Text = "";
                    textBoxTenDichVu.Text = "";
                    textBoxMoTa.Text = "";
                    textBoxDonGia.Text = "";
                    textBoxGhiChu.Text = "";
                    textBoxSoLuong.Text = "";
                    textBoxMaDichVu.ReadOnly = false;
                    dgvDVDaDat.DataSource = busTC.getDichVuDaDat(MaTiecCuoi);
                    for (int i = 0; i < dgvDVDaDat.Columns.Count; i++)
                        dgvDVDaDat.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    MessageBox.Show("Chọn dịch vụ không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void huyButton(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("BẠN CÓ CHẮC MUỐN HỦY TIỆC", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (busTC.xoaCT_PhieuDatBan(MaTiecCuoi, 1) && busTC.xoaTiecCuoi(MaTiecCuoi) && TiecCuoi.xoaPhieuDatBan(MaTiecCuoi))

                {
                    MessageBox.Show("Hủy tiệc thành công");
                    this.Close();
                    this.parent.Show();
                }
                else
                    MessageBox.Show("Hủy tiệc thất bại");
            }
        }

        private void btnTinhTienCoc_Click(object sender, EventArgs e)
        {
            double TienCoc = 0;
            TienCoc = (TiecCuoi.TongTienBan(MaTiecCuoi) + TiecCuoi.TongTienDichVu(MaTiecCuoi)) / 2;
            MessageBox.Show("Số tiền cọc phải trả là: " + TienCoc);
            TiecCuoi.capnhatTienCoc(TienCoc, MaTiecCuoi);
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this.parent != null)
                parent.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTenDichVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaDichVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

