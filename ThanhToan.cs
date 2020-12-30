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
    public partial class ThanhToan : Form
    {
        public String MaTiecCuoi { get; set; }
        public static string matc;
        public Form parent { get; set; }
        BUS_HoaDon HoaDon = new BUS_HoaDon();
        public ThanhToan()
        {
            InitializeComponent();
            this.CenterToScreen();
           // if (MaTiecCuoi !="")
                tbMaTiecCuoi.Text = MaTiecCuoi;
        }

        public void resetForm()
        {
            txtSoLuongBan.Text = "";
            txtTongTienBan.Text = "";
            txtTongTienDichVu.Text = "";
            txtTongTienHoaDon.Text = "";
            txtTienDatCoc.Text = "";
            txtConLai.Text = "";
            txtNgayDaiTiec.Text = "";
            tbMaTiecCuoi.Text = MaTiecCuoi;
        }

        private void bt_Tinh_Click(object sender, EventArgs e)
        {
            if (HoaDon.searchHoaDon(tbMaTiecCuoi.Text) != null)
            {
                DataTable dtHoaDon = HoaDon.searchHoaDon(tbMaTiecCuoi.Text);
                txtNgayDaiTiec.Text = "Đã hủy";
                txtTongTienBan.Text = dtHoaDon.Rows[0][2].ToString();
                txtTongTienDichVu.Text = dtHoaDon.Rows[0][3].ToString();
                txtTongTienHoaDon.Text = dtHoaDon.Rows[0][4].ToString();
                txtConLai.Text = dtHoaDon.Rows[0][5].ToString();
                txtTienDatCoc.Text = HoaDon.getTienDatCoc(tbMaTiecCuoi.Text).ToString();
                txtTongThanhToan.Text = txtConLai.Text;

            }
            else    
            try
            {
                txtSoLuongBan.Text = (HoaDon.getSoLuongBan(tbMaTiecCuoi.Text)).ToString();
                double TongTienBan = HoaDon.TongTienBan(tbMaTiecCuoi.Text);
                double TongTienDichVu = HoaDon.TongTienDichVu(tbMaTiecCuoi.Text);
                double TienDatCoc = HoaDon.getTienDatCoc(tbMaTiecCuoi.Text);
                txtNgayDaiTiec.Text = HoaDon.getNgayDaiTiec(tbMaTiecCuoi.Text);
                txtTongTienHoaDon.Text = (TongTienBan + TongTienDichVu).ToString();
                txtTongTienBan.Text = TongTienBan.ToString();
                txtTongTienDichVu.Text = TongTienDichVu.ToString();
                txtTienDatCoc.Text = TienDatCoc.ToString();
                txtConLai.Text = ((TongTienBan + TongTienDichVu) - TienDatCoc).ToString();
                datagv_chitietdichvu.DataSource = HoaDon.getChiTietDichVu(tbMaTiecCuoi.Text);
                txtTongThanhToan.Text = txtConLai.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
                DataTable temp = HoaDon.searchHoaDon(tbMaTiecCuoi.Text);
                int t = temp.Rows.Count;
                if (t == 0)
                {
                    // Tạo SoHoaDon
                    string SoHoaDon = "";
                    DataTable hd = HoaDon.getHoaDon();
                    int totalRow = hd.Rows.Count;
                    if (totalRow < 9)
                    {
                        SoHoaDon = "HD0" + (totalRow + 1).ToString();
                    }
                    else SoHoaDon = "HD" + (totalRow + 1).ToString();
                    string NgayThanhToan = string.Format("{0:dd/MM/yyyy}",dtpNgayThanhToan.Value);

                    DTO_HoaDon hoadon = new DTO_HoaDon(SoHoaDon, tbMaTiecCuoi.Text, NgayThanhToan, int.Parse(txtTongTienBan.Text.ToString()), int.Parse(txtTongTienDichVu.Text.ToString()), int.Parse(txtTongTienHoaDon.Text.ToString()), int.Parse(txtConLai.Text.ToString()), 1);

                    if (HoaDon.insertHoaDon(hoadon))
                    {

                    HoaDon.CapNhatTiecCuoi(hoadon.MaTiecCuoi);
                    MessageBox.Show("Lưu thành công");
                        resetForm();
                        //tbMaTiecCuoi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại !");
                    }
                }
                else
                {
                    MessageBox.Show("Đã có Hóa Đơn cho tiệc cưới này");
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            LapHopDong yc = new LapHopDong();
            //this.Dispose();
            yc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TraCuuTiecCuoi yc = new TraCuuTiecCuoi();
            //this.Dispose();
            yc.ShowDialog();
        }

        private void btQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this.parent != null)
                parent.Show();
        }
    }
}
