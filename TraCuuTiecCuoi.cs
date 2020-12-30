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
using FontAwesome.Sharp;
namespace QLTiecCuoi
{
    public partial class TraCuuTiecCuoi : Form
    {
        public static string layMaTiecCuoi;
        public static string hoTenCoDau;
        public static string hoTenChuRe;
        public static string dienThoai;
        public static int tienDatCoc;
        public static float soLuongKhach;
        public static float soLuongBan;
        public static string tienDo;
        public static string maSanh;
        public static string maca;
        public static string ghiChu;
        public static string ngayDatTiec;
        public static string ngayDaiTiec;
        public String MaTiecCuoi { get; set; }

        DTO_TiecCuoi tc;
        Image im;
        BUS_DichVu busTC = new BUS_DichVu();
        BUS_TiecCuoi busTiecCuoi = new BUS_TiecCuoi();
        BUS_Sanh sanh = new BUS_Sanh();
        BUS_YC6 busYC6 = new BUS_YC6();
        private string matieccuoi = "";
        public TraCuuTiecCuoi()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dgvTC.DataSource = busTC.getTiecCuoi();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxTimkiem.Text != "")
            {
                dgvTC.DataSource = busTiecCuoi.SearchTiecCuoi(textBoxTimkiem.Text);
            }
        }

        //private void dataGridViewDanhSachTiecCuoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    int row = e.RowIndex;
        //    int ID = Convert.ToInt16(dgvTC.Rows[row].Cells[8].Value.ToString());
        //    tc = new DTO_TiecCuoi(dgvTC.Rows[row].Cells[0].Value.ToString(), dgvTC.Rows[row].Cells[1].Value.ToString(), dgvTC.Rows[row].Cells[2].Value.ToString(), dgvTC.Rows[row].Cells[3].Value.ToString(), dgvTC.Rows[row].Cells[4].Value.ToString(), dgvTC.Rows[row].Cells[5].Value.ToString(), dgvTC.Rows[row].Cells[6].Value.ToString(), dgvTC.Rows[row].Cells[7].Value.ToString(), ID, dgvTC.Rows[row].Cells[9].Value.ToString(), dgvTC.Rows[row].Cells[10].Value.ToString(), dgvTC.Rows[row].Cells[11].Value.ToString(), dgvTC.Rows[row].Cells[12].Value.ToString());

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBoxTimkiem.Text != "")
            //{
            dgvTC.DataSource = busTiecCuoi.SearchTiecCuoi(txtTimKiem.Text);
            // }
        }

       
        private void btnSua_Click(object sender, EventArgs e)
        {            
            try
            {
                layMaTiecCuoi = dgvTC[0, dgvTC.SelectedRows[0].Index].Value.ToString();
                SuaTiecCuoi yc = new SuaTiecCuoi();
                yc.MaTiecCuoi = layMaTiecCuoi;
                yc.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Vui lòng chọn tiệc cưới cần sửa.");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉ được hủy tiệc trong vòng thời gian 7 ngày");
        }

        private void btnHuyTiec_Click(object sender, EventArgs e)
        {           
            DialogResult dialogResult = MessageBox.Show("BẠN CÓ CHẮC MUỐN HỦY TIỆC", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (busTiecCuoi.HuyTiecCuoi(MaTiecCuoi))
                {                   
                    double TienCoc = busTiecCuoi.GetTiecCoc(MaTiecCuoi) * ((double)(100 - busTiecCuoi.getTienDo(MaTiecCuoi)) / 100);
                    var result = MessageBox.Show("Số tiền cọc còn lại là: " +/* busTiecCuoi.CapNhatHuyTiec(MaTiecCuoi)*/TienCoc, null, MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        DateTime dateTime = DateTime.UtcNow.Date;
                        DTO_HoaDon HD = new DTO_HoaDon(MaTiecCuoi, MaTiecCuoi, dateTime.ToString("dd/MM/yyyy"), 0, 0, (int)TienCoc, 0, 1);
                        BUS_HoaDon BHD = new BUS_HoaDon();
                        if (BHD.insertHoaDon(HD))
                        {

                            MessageBox.Show("Hủy Tiệc Thành Công");
                            this.dgvTC.DataSource = busTiecCuoi.getTiecCuoi();
                        }    

                    }
                     
                }
                else
                    MessageBox.Show("Hủy tiệc thất bại");

            }
        }

        private void TraCuuTiecCuoi_Load(object sender, EventArgs e)
        {

        }

        private void dgvTC_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvTC.SelectedRows.Count == 0)
                return;
            //00 Mã, 10 tên, 20 giá
            this.MaTiecCuoi= dgvTC[0, dgvTC.SelectedRows[0].Index].Value.ToString();

        }


        private void btThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.MaTiecCuoi = MaTiecCuoi;
            thanhToan.parent = this;
            thanhToan.ShowDialog();
        }
    }
}
