using BUS;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QLTiecCuoi
{
    public partial class SuaTiecCuoi : Form
    {
        public String MaTiecCuoi { get; set; }
        BUS_TiecCuoi busTC = new BUS_TiecCuoi();
        BUS_YC6 busYC6 = new BUS_YC6();
        BUS_DichVu busDV = new BUS_DichVu();
        public SuaTiecCuoi()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void SuaTiecCuoi_Load(object sender, EventArgs e)
        {
            DataTable ca = busYC6.getCa();
            comboBoxMaCa.DataSource = ca;
            comboBoxMaCa.DisplayMember = "TenCa";
            comboBoxMaCa.ValueMember = "MaCa";

            DataTable sanh = busYC6.getSanh();
            comboBoxMaSanh.DataSource = sanh;
            comboBoxMaSanh.DisplayMember = "TenSanh";
            comboBoxMaSanh.ValueMember = "MaSanh";
            DataTable dtTiecCuoi= busTC.getTiecCuoi(MaTiecCuoi);
            textBoxTenChuRe.Text = dtTiecCuoi.Rows[0][1].ToString();
            textBoxTenCoDau.Text = dtTiecCuoi.Rows[0][2].ToString();
            textBoxDienThoai.Text = dtTiecCuoi.Rows[0][3].ToString();           
            textBoxTienDatCoc.Text = dtTiecCuoi.Rows[0][6].ToString();
            textBoxSoLuongKhach.Text = dtTiecCuoi.Rows[0][10].ToString();
            textBoxSoLuongBan.Text = dtTiecCuoi.Rows[0][11].ToString();
            string NgayDai = dtTiecCuoi.Rows[0][9].ToString();
            string NgayDat = dtTiecCuoi.Rows[0][8].ToString();
            DateTime dtNgayDai = new DateTime();
            DateTime dtNgayDat = new DateTime();
            try
            {
                dtNgayDai = DateTime.ParseExact(NgayDai, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dtNgayDat = DateTime.ParseExact(NgayDat, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtpNgayDaiTiec.Value = dtNgayDai;
            dtpNgayDatTiec.Value = dtNgayDat;
            tbTienDo.Text = dtTiecCuoi.Rows[0][12].ToString();
            dgvDV.DataSource = busDV.getPhieuDatDV(MaTiecCuoi);
            dgvMonAn.DataSource = busDV.getMonAnDaDat(MaTiecCuoi);
            for (int i = 0; i < dgvDV.Columns.Count; i++)
                dgvDV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i < dgvMonAn.Columns.Count; i++)
                dgvMonAn.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtpNgayDatTiec.Enabled = false;
        }

        private void btThemMA_Click(object sender, EventArgs e)
        {
            CT_PhieuDatBan pdb = new CT_PhieuDatBan(MaTiecCuoi);
            this.Hide();
            pdb.parent = this;
            pdb.ShowDialog();
            if(!pdb.Focus())
                this.dgvMonAn.DataSource = busDV.getMonAnDaDat(MaTiecCuoi);
        }

        private void btThemDV_Click(object sender, EventArgs e)
        {
            CT_PhieuDatDichVu pDatDV = new CT_PhieuDatDichVu(MaTiecCuoi);
            this.Hide();
            pDatDV.parent = this;
            pDatDV.ShowDialog();
            if (!pDatDV.Focus())
                dgvDV.DataSource = busDV.getPhieuDatDV(MaTiecCuoi);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn lưu những thay đổi trên?",null, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TimeSpan tsSoNgayDai = dtpNgayDaiTiec.Value - dtpNgayDatTiec.Value;
                if (tsSoNgayDai.TotalDays<7)
                {
                    MessageBox.Show("Ngày đãi tiệc phải sau ngày đặt tiệc ít nhất 7 ngày.");
                } 
                else
                {
                    if (textBoxTenChuRe.Text != "" && textBoxTenCoDau.Text != "" && textBoxDienThoai.Text != "" && comboBoxMaSanh.Text != "" && comboBoxMaCa.Text != "")
                    {
                        int TienDatCoc = Convert.ToInt32(textBoxTienDatCoc.Text);
                        int SoLuongBan = Convert.ToInt32(textBoxSoLuongBan.Text);
                        int SoLuongKhach = Convert.ToInt32(textBoxSoLuongKhach.Text);
                        string NgayDai = String.Format("{0:dd/MM/yyyy}", dtpNgayDaiTiec.Value);
                        string NgayDat = String.Format("{0:dd/MM/yyyy}", dtpNgayDatTiec.Value);
                        DTO_TiecCuoi t = new DTO_TiecCuoi(MaTiecCuoi, textBoxTenChuRe.Text, textBoxTenCoDau.Text, textBoxDienThoai.Text, comboBoxMaCa.Text, comboBoxMaSanh.Text, TienDatCoc, "", NgayDat, NgayDai, SoLuongKhach, SoLuongBan, tbTienDo.Text);
                        if (busTC.suaTiecCuoi(t))
                        {
                            MessageBox.Show("Sửa thành công.");
                        }
                        else
                            MessageBox.Show("Sửa không thành công.");
                    }
                    else
                        MessageBox.Show("Vui lòng nhập đầy đủ");
                }
                
            }
            else
                this.Dispose();
        }

    }
        
}
