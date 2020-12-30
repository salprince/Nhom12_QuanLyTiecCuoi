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
using DAL;
using System.Data.SQLite;

namespace QLTiecCuoi
{
    public partial class YC5 : Form
    {
        BUS_BaoCao BaoCao = new BUS_BaoCao();
        public YC5()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void txtQuy_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNam_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void Reset()
        {
            tbQuy.Text = "";
            tbNam.Text = "";
            tbSoLuongTiecCuoi.Text = "";
            tbTongDoanhThu.Text = "";
            tbTongSoTiec.Text = "";
            tbTyLeHuy.Text = "";
            tbTyLeThanhCong.Text = "";
        }
        private void bt_BaoCao_Click(object sender, EventArgs e)
        {
            int Quy = int.Parse(tbQuy.Text);
            int Nam = int.Parse(tbNam.Text);
            double TongSoTC = 0;
            double TongSoTCThanhCong = 0;
            double TongSoTCHuy = 0;
            double TongDoanhThu = 0;
            if (Quy > 4 || Quy < 1)
            {
                MessageBox.Show("Chỉ nhập quý từ 1 đến 4.");
            }
            else
            {
                TongSoTC = BaoCao.DemTongTiecCuoi(Quy, Nam);
                if (TongSoTC != 0)
                {
                    TongSoTCThanhCong = BaoCao.TinhTiecCuoiThanhCong(Quy, Nam);
                    TongSoTCHuy = BaoCao.TinhTiecCuoiHuy(Quy, Nam);
                    TongDoanhThu = BaoCao.TinhTongThu(Quy, Nam);
                    tbTongDoanhThu.Text = TongDoanhThu.ToString();
                    tbTongSoTiec.Text = TongSoTC.ToString();
                    tbTyLeThanhCong.Text = (TongSoTCThanhCong * 100 / TongSoTC).ToString();
                    tbTyLeHuy.Text = (TongSoTCHuy * 100 / TongSoTC).ToString();
                }
                else
                {
                    tbTongDoanhThu.Text = "0";
                    tbTongSoTiec.Text = "0";
                    tbTyLeThanhCong.Text = "0";
                    tbTyLeHuy.Text = "0";
                }

                //}    

            }
        }

        private void btnLuuBaoCao_Click(object sender, EventArgs e)
        {
            string MaBaoCao = tbQuy.Text + tbNam.Text;
            if (BaoCao.TimBaoCao(MaBaoCao) != null)
            {
                MessageBox.Show("Đã có báo cáo này");
            }
            else
            {
                if (tbQuy.Text != "" && tbNam.Text != "" && tbTongDoanhThu.Text != "" && tbTongSoTiec.Text != "" && tbTyLeThanhCong.Text != "" && tbTyLeHuy.Text != "")
                {
                    DTO_BaoCao DTO_BaoCao = new DTO_BaoCao(MaBaoCao, int.Parse(tbQuy.Text), int.Parse(tbNam.Text), int.Parse(tbTongDoanhThu.Text), int.Parse(tbTongSoTiec.Text), float.Parse(tbTyLeThanhCong.Text), float.Parse(tbTyLeHuy.Text));
                    if (BaoCao.insertBaoCao(DTO_BaoCao))
                    {
                        MessageBox.Show("Lưu báo cáo thành công.");
                        Reset();
                    }
                    else
                        MessageBox.Show("Lưu báo cáo không thành công.");
                }
                else
                    MessageBox.Show("Bạn phải nhấn nút Báo Cáo trước khi lưu.");
            }

        }

        private void btnXoaBaoCao_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắn chắn muốn xóa?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BaoCao.xoaBaoCao(int.Parse(tbQuy.Text), int.Parse(tbNam.Text)))
                {
                    MessageBox.Show("Xóa thành công.");
                    Reset();
                } 
                else
                {
                    MessageBox.Show("Xóa không thành công: Chưa lưu báo cáo nên không xóa được.");
                }
            }    
        }
    }
}
