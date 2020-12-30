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
    public partial class LapHopDong : Form
    {
        public static string LayMaTiecCuoi;
        BUS_DichVu busTC = new BUS_DichVu();
        BUS_TiecCuoi busTiecCuoi = new BUS_TiecCuoi();
        BUS_Sanh sanh = new BUS_Sanh();
        BUS_YC6 busYC6 = new BUS_YC6(); Image im;
        private string matieccuoi = "";
        DAL.DAL_YC2 dalTiecCuoi = new DAL_YC2();
        public LapHopDong()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void FormLapHopDong_Load(object sender, EventArgs e)
        {
            //dgvTC.DataSource = busTC.getTiecCuoi();
            DataTable ca = busYC6.getCa();
            comboBoxMaCa.DataSource = ca;
            comboBoxMaCa.DisplayMember = "MaCa";
            comboBoxMaCa.ValueMember = "MaCa";

            DataTable sanh = busYC6.getSanh();
            comboBoxMaSanh.DataSource = sanh;
            comboBoxMaSanh.DisplayMember = "MaSanh";
            comboBoxMaSanh.ValueMember = "MaSanh";

            tbNgayDat.Text = $"{DateTime.Now.Day.ToString()}/{DateTime.Now.Month.ToString()}/{DateTime.Now.Year.ToString()}";
        }

        private void textBoxTenChuRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                e.Handled = true;
            }
        }

        private void textBoxTenCoDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {

                e.Handled = true;
            }
        }

        private void textBoxDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }


        private void textBoxTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonChinhsua_Click(object sender, EventArgs e)
        {
            if (textBoxTenChuRe.Text != "" && textBoxTenCoDau.Text != "" && textBoxDienThoai.Text != "" &&  comboBoxMaSanh.Text != "" && comboBoxMaCa.Text != "" )
            {
                DataTable tc = busTiecCuoi.getTiecCuoi();
                int i = tc.Rows.Count;
                if (i < 9)
                {
                    matieccuoi = "TC0" + (i + 1).ToString();
                }
                else
                {
                    matieccuoi = "TC" + (i + 1).ToString();
                }

                int dayt = int.Parse(DateTime.Now.Day.ToString());
                int montht = int.Parse(DateTime.Now.Month.ToString());
                int yeart = int.Parse(DateTime.Now.Year.ToString());


                int dayi = int.Parse(dtpNgayDai.Value.Day.ToString());
                int monthi = int.Parse(dtpNgayDai.Value.Month.ToString());
                int yeari = int.Parse(dtpNgayDai.Value.Year.ToString());

                if (busTC.KTNgay(dayt, montht, yeart) == true && busTC.KTNgay(dayi, monthi, yeari) == true)
                {
                    if (busTC.DayMonthYear_to_Day(dayi, monthi, yeari) - busTC.DayMonthYear_to_Day(dayt, montht, yeart) > 0)
                    {
                        string NgayDai = busTC.GopNgay(dayi, monthi, yeari);
                        string NgayDat = busTC.GopNgay(dayt, montht, yeart);
                        int TienDatCoc = 0; //Convert.ToInt32(textBoxTienDatCoc.Text);
                        int SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
                        int SoLuongKhach = Convert.ToInt32(txtSoLuongKhach.Text);
                        if (busTC.checkSanh_Ca(NgayDai, comboBoxMaSanh.Text, comboBoxMaCa.Text) == true)
                        {
                            DTO_TiecCuoi t = new DTO_TiecCuoi(matieccuoi, textBoxTenChuRe.Text, textBoxTenCoDau.Text, textBoxDienThoai.Text, comboBoxMaCa.Text, comboBoxMaSanh.Text, TienDatCoc, textBoxGhiChu.Text, NgayDat, NgayDai, SoLuongBan, SoLuongKhach, txtTienDo.Text);
                            if (busTiecCuoi.suaTiecCuoi(t))
                            {
                                MessageBox.Show("Sửa thành công!");
                                //dgvTC.DataSource = busTC.getTiecCuoi();
                            }
                            else
                            {
                                MessageBox.Show("Sửa không thành công!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sảnh đã có người đặt");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày đãi phải sau ngày đặt!");
                    }
                }
                else
                {
                    MessageBox.Show("Ngày tháng năm không hợp lệ!");
                }

            }
            else
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin!");
            }
        }



        // private void button1_Click(object sender, EventArgs e)
        // {
        ////    if (textBoxTenChuRe.Text != "" && textBoxTenCoDau.Text != "" && textBoxDienThoai.Text != "" && comboBoxNgayDat.Text != "" && comboBoxThangDat.Text != "" && textBoxNamDat.Text != "" && comboBoxNgayDai.Text != "" && comboBoxThangDai.Text != "" && textBoxNamDai.Text != "" && comboBoxMaSanh.Text != "" && comboBoxMaCa.Text != "" && textBoxTienDatCoc.Text != "")
        ////    {
        ////        DataTable tc = busTiecCuoi.getTiecCuoi();
        ////        int i = tc.Rows.Count;
        ////        if (i < 9)
        ////        {
        ////            matieccuoi = "TC00" + (i + 1).ToString();
        ////        }
        ////        else
        ////        {
        ////            matieccuoi = "TC" + (i + 1).ToString();
        ////        }

        ////        int dayt = int.Parse(comboBoxNgayDat.Text.ToString());
        ////        int montht = int.Parse(comboBoxThangDat.Text.ToString());
        ////        int yeart = int.Parse(textBoxNamDat.Text.ToString());

        ////        int dayi = int.Parse(comboBoxNgayDai.Text.ToString());
        ////        int monthi = int.Parse(comboBoxThangDai.Text.ToString());
        ////        int yeari = int.Parse(textBoxNamDai.Text.ToString());

        ////        if (busTC.KTNgay(dayt, montht, yeart) == true && busTC.KTNgay(dayi, monthi, yeari) == true)
        ////        {
        ////            if (busTC.DayMonthYear_to_Day(dayi, monthi, yeari) - busTC.DayMonthYear_to_Day(dayt, montht, yeart) > 0)
        ////            {
        ////                string NgayDai = busTC.GopNgay(dayi, monthi, yeari);
        ////                string NgayDat = busTC.GopNgay(dayt, montht, yeart);
        ////                int TienDatCoc = Convert.ToInt32(textBoxTienDatCoc.Text);
        ////                int SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
        ////                int SoLuongKhach = Convert.ToInt32(txtSoLuongKhach.Text);

        ////                if (busTC.checkSanh_Ca(NgayDai, comboBoxMaSanh.Text, comboBoxMaCa.Text) == true)
        ////                {
        ////                    DTO_TiecCuoi t = new DTO_TiecCuoi(matieccuoi, textBoxTenChuRe.Text, textBoxTenCoDau.Text, textBoxDienThoai.Text, NgayDat, NgayDai, comboBoxMaCa.Text, comboBoxMaSanh.Text, TienDatCoc, textBoxGhiChu.Text, SoLuongBan, SoLuongKhach, txtTienDo.Text);
        ////                    if (busTiecCuoi.themTiecCuoi(t))
        ////                    {
        ////                        DataTable lsanh = busTC.getLoaiSanh(comboBoxMaSanh.Text);
        ////                        DataRow row = lsanh.Rows[0];
        ////                        int temp = int.Parse(row["DonGiaBanToiThieu"].ToString());
        ////                        MessageBox.Show("Thêm thành công");
        ////                        //dgvTC.DataSource = busTC.getTiecCuoi();
        ////                        PhieuDatTiec frm = new PhieuDatTiec();
        ////                        frm.MaTiecCuoi = matieccuoi;
        ////                        frm.DonGiaBanToiThieu = temp;
        ////                        frm.MaSanh = comboBoxMaSanh.Text;
        ////                        frm.ShowDialog();
        ////                    }
        ////                    else
        ////                    {
        ////                        MessageBox.Show("Thêm không thành công!");
        ////                    }
        ////                }
        ////                else
        ////                {
        ////                    MessageBox.Show("Sảnh đã có người đặt");
        ////                }
        ////            }
        ////            else
        ////            {
        ////                MessageBox.Show("Ngày đãi phải sau ngày đặt!");
        ////            }
        ////        }
        ////        else
        ////        {
        ////            MessageBox.Show("Ngày tháng năm không hợp lệ!");
        ////        }

        ////    }
        ////    else
        ////    {
        ////        MessageBox.Show("vui lòng nhập đầy đủ thông tin!");
        ////    }
        ////}

        private void textBoxNamDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNamDai_KeyPress(object sender, KeyPressEventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = System.Drawing.Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        /*private void btnThem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            if (textBoxTenChuRe.Text != "" && textBoxTenCoDau.Text != "" && textBoxDienThoai.Text != ""   && comboBoxMaSanh.Text != "" && comboBoxMaCa.Text != "")
            {
                DataTable tc = busTiecCuoi.getTiecCuoi();
                int i = tc.Rows.Count;
                if (i < 9)
                {
                    matieccuoi = "TC00" + (i + 1).ToString();
                }
                else
                {
                    matieccuoi = "TC" + (i + 1).ToString();
                }

                int dayt = int.Parse(DateTime.Now.Day.ToString());
                int montht = int.Parse(DateTime.Now.Month.ToString());
                int yeart = int.Parse(DateTime.Now.Year.ToString());

                int dayi = int.Parse(DatePicker.Value.Day.ToString());
                int monthi = int.Parse(DatePicker.Value.Month.ToString());
                int yeari = int.Parse(DatePicker.Value.Year.ToString());

                if (busTC.KTNgay(dayt, montht, yeart) == true && busTC.KTNgay(dayi, monthi, yeari) == true)
                {
                    if (busTC.DayMonthYear_to_Day(dayi, monthi, yeari) - busTC.DayMonthYear_to_Day(dayt, montht, yeart) > 0)
                    {
                        string NgayDai = busTC.GopNgay(dayi, monthi, yeari);
                        string NgayDat = busTC.GopNgay(dayt, montht, yeart);
                        int TienDatCoc = 0;//Convert.ToInt32(textBoxTienDatCoc.Text);
                        int SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
                        int SoLuongKhach = Convert.ToInt32(txtSoLuongKhach.Text);
                        //int TienDo = Convert.ToInt32(txtTienDo.Text);

                        if (busTC.checkSanh_Ca(NgayDai, comboBoxMaSanh.Text, comboBoxMaCa.Text) == true)
                        {
                            DTO_TiecCuoi t = new DTO_TiecCuoi(matieccuoi, textBoxTenChuRe.Text, textBoxTenCoDau.Text, textBoxDienThoai.Text, comboBoxMaCa.Text, comboBoxMaSanh.Text, TienDatCoc, textBoxGhiChu.Text, NgayDat, NgayDai, SoLuongKhach, SoLuongBan, txtTienDo.Text);
                            if (busTiecCuoi.themTiecCuoi(t))
                            {
                                DataTable lsanh = busTC.getLoaiSanh(comboBoxMaSanh.Text);
                                DataRow row = lsanh.Rows[0];
                                //int temp = int.Parse(row["DonGiaBanToiThieu"].ToString());
                                MessageBox.Show("Thêm thành công");
                                //dgvTC.DataSource = busTC.getTiecCuoi();
                                PhieuDatTiec frm = new PhieuDatTiec();
                                frm.MaTiecCuoi = matieccuoi;
                                //frm.DonGiaBanToiThieu = temp;
                                frm.MaSanh = comboBoxMaSanh.Text;
                                frm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Thêm không thành công!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sảnh đã có người đặt");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày đãi phải sau ngày đặt!");
                    }
                }
                else
                {
                    MessageBox.Show("Ngày tháng năm không hợp lệ!");
                }

            }
            else
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin!");
            }
        }*/

        

       

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            DialogResult d;
            d = MessageBox.Show("Bạn chắc chắn xóa tiệc cưới này", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {

                if (busTiecCuoi.xoaTiecCuoi(matieccuoi))
                {
                    MessageBox.Show("Xóa thành công");

                }
                else
                {
                    MessageBox.Show("LỖI: Xóa không thành công !");
                }


            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxThangDat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (textBoxTenChuRe.Text != "" && textBoxTenCoDau.Text != "" && textBoxDienThoai.Text != "" && comboBoxMaSanh.Text != "" && comboBoxMaCa.Text != "")
            {
                DataTable tc = busTiecCuoi.getTiecCuoi();
                int i = tc.Rows.Count;
                if (i < 9)
                {
                    matieccuoi = "TC0" + (i + 1).ToString();
                }
                else
                {
                    matieccuoi = "TC" + (i + 1).ToString();
                }

                int dayt = int.Parse(DateTime.Now.Day.ToString());
                int montht = int.Parse(DateTime.Now.Month.ToString());
                int yeart = int.Parse(DateTime.Now.Year.ToString());

                int dayi = int.Parse(dtpNgayDai.Value.Day.ToString());
                int monthi = int.Parse(dtpNgayDai.Value.Month.ToString());
                int yeari = int.Parse(dtpNgayDai.Value.Year.ToString());

                if (busTC.KTNgay(dayt, montht, yeart) == true && busTC.KTNgay(dayi, monthi, yeari) == true)
                {
                    if (busTC.DayMonthYear_to_Day(dayi, monthi, yeari) - busTC.DayMonthYear_to_Day(dayt, montht, yeart) > 0)
                    {
                        string NgayDai = String.Format("{0:dd/MM/yyyy}", dtpNgayDai.Value);
                        string NgayDat = busTC.GopNgay(dayt, montht, yeart);
                        int TienDatCoc = 0;// Convert.ToInt32(textBoxTienDatCoc.Text);
                        int SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
                        int SoLuongKhach = Convert.ToInt32(txtSoLuongKhach.Text);

                        if (busTC.checkSanh_Ca(NgayDai, comboBoxMaSanh.Text, comboBoxMaCa.Text) == true)
                        {
                            DTO_TiecCuoi t = new DTO_TiecCuoi(matieccuoi, textBoxTenChuRe.Text, textBoxTenCoDau.Text, textBoxDienThoai.Text, comboBoxMaCa.Text, comboBoxMaSanh.Text, TienDatCoc, textBoxGhiChu.Text, NgayDat, NgayDai, SoLuongKhach, SoLuongBan, txtTienDo.Text); ; ;
                            if (busTiecCuoi.themTiecCuoi(t))
                            {
                                Console.WriteLine($"MATIECCUOI {matieccuoi}");
                                CT_PhieuDatBan pdb = new CT_PhieuDatBan(matieccuoi);
                                pdb.parent = this;
                                this.Hide();
                                pdb.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Thêm không thành công!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sảnh đã có người đặt");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày đãi phải sau ngày đặt!");
                    }
                }
                else
                {
                    MessageBox.Show("Ngày tháng năm không hợp lệ!");
                }

            }
            else
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class DAL_YC2 : DAL.DAL_YC2
    {
    }
}
