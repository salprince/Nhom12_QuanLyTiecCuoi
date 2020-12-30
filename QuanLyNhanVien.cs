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
    public partial class QuanLyNhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public QuanLyNhanVien()
        {
            InitializeComponent();
            this.CenterToScreen();
            panel1.Enabled = false;
            btNVThuong.Enabled = false;
        }

        private void DSNV_Load(object sender, EventArgs e)
        {
            dgv_DanhSachNV.DataSource = busNV.getNhanVien();
            for (int i = 0; i < dgv_DanhSachNV.Columns.Count; i++)
            {
                dgv_DanhSachNV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void QL_Check(object sender, EventArgs e)
        {
            btNVThuong.Enabled = false;
        }

        private void Thuong_Check(object sender, EventArgs e)
        {
            btNVQL.Enabled = false;
        }

        private void them_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btNVThuong.Enabled = true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.TenDangNhap = tbTenDN.Text;
                nv.MatKhau = tbPass.Text;
                nv.TenNhanVien = tbTenNV.Text;
                if (btNVQL.Checked)
                    nv.LoaiNhanVien = "QL";
                else nv.LoaiNhanVien = "Thuong";
                if(busNV.insertNV(nv))
                {
                    dgv_DanhSachNV.DataSource = busNV.getNhanVien();
                    for (int i = 0; i < dgv_DanhSachNV.Columns.Count; i++)
                    {
                        dgv_DanhSachNV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    MessageBox.Show("Thêm Thành Công");
                }
                else MessageBox.Show("Thêm Thất Bại");

            }
            catch(Exception ea )
            {

            }
        }
    }
}
