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
    public partial class CapNhapMonAn : Form
    {
        BUS_MonAn busMonan = new BUS_MonAn();
        Image im;
        public CapNhapMonAn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void YC6_2_3_Load(object sender, EventArgs e)
        {
            datagv_monan.DataSource = busMonan.getMonAn();

            // Load font-style
            this.datagv_monan.DefaultCellStyle.Font = new Font("Times New Roman", 12);
        }

        private void datagv_monan_Click(object sender, EventArgs e)
        {
            txtMaMonAn.ReadOnly = true;

            int i;
            i = datagv_monan.CurrentRow.Index;
            txtMaMonAn.Text = datagv_monan.Rows[i].Cells[0].Value.ToString();
            txtTenMonAn.Text = datagv_monan.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = datagv_monan.Rows[i].Cells[3].Value.ToString();
            txtMoTa.Text = datagv_monan.Rows[i].Cells[2].Value.ToString();
            txtGhiChu.Text = datagv_monan.Rows[i].Cells[4].Value.ToString();

            if (txtMaMonAn.Text == "")
            {
                txtMaMonAn.ReadOnly = false;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (txtMaMonAn.Text != "" && txtTenMonAn.Text != "" && txtDonGia.Text != "")
            {
                int DonGia = Convert.ToInt32(txtDonGia.Text);
                if (DonGia <= 0)
                    MessageBox.Show("LỖI: Đơn giá không hợp lệ !");
                else
                {
                    DTO_MonAn man = new DTO_MonAn(txtMaMonAn.Text, txtTenMonAn.Text, txtMoTa.Text, DonGia, txtGhiChu.Text);

                    if (busMonan.insertMonAn(man))
                    {
                        MessageBox.Show("Thêm thành công");
                        datagv_monan.DataSource = busMonan.getMonAn();

                        txtMaMonAn.Text = "";
                        txtTenMonAn.Text = "";
                        txtDonGia.Text = "";
                        txtMoTa.Text = "";
                        txtGhiChu.Text = "";
                        txtMaMonAn.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("LỖI: Thêm không thành công !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ các trường (Ghi Chú, Mô Tả có thể không nhập)");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (datagv_monan.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = datagv_monan.SelectedRows[0];
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells[0].Value.ToString();

                    if (busMonan.deleteMonAn(id))
                    {
                        MessageBox.Show("Xóa thành công");
                        datagv_monan.DataSource = busMonan.getMonAn();

                        txtMaMonAn.Text = "";
                        txtTenMonAn.Text = "";
                        txtDonGia.Text = "";
                        txtMoTa.Text = "";
                        txtGhiChu.Text = "";
                        txtMaMonAn.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("LỖI: Xóa không thành công !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bấm cột đầu tiên để tô đậm hàng muốn xóa");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenMonAn.Text != "" && txtDonGia.Text != "")
                {
                    int DonGia = Convert.ToInt32(txtDonGia.Text);
                    if (DonGia <= 0)
                        MessageBox.Show("LỖI: Đơn giá không hợp lệ !");
                    else
                    {
                        DTO_MonAn man = new DTO_MonAn(txtMaMonAn.Text, txtTenMonAn.Text, txtMoTa.Text, DonGia, txtGhiChu.Text);

                        if (busMonan.editMonAn(man))
                        {
                            MessageBox.Show("Sửa thành công");
                            datagv_monan.DataSource = busMonan.getMonAn();

                            txtMaMonAn.Text = "";
                            txtTenMonAn.Text = "";
                            txtDonGia.Text = "";
                            txtMoTa.Text = "";
                            txtGhiChu.Text = "";
                            txtMaMonAn.ReadOnly = false;
                        }
                        else
                        {
                            MessageBox.Show("LỖI: Sửa không thành công !");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống các trường (Ghi Chú, Mô Tả có thể để trống)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                datagv_monan.DataSource = busMonan.searchMonAn(txtSearch.Text);
            }

            // Reset form
            txtMaMonAn.Text = "";
            txtTenMonAn.Text = "";
            txtDonGia.Text = "";
            txtMoTa.Text = "";
            txtGhiChu.Text = "";
            txtMaMonAn.ReadOnly = false;
        }

       

        private void bt_trangchu_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            im = bt.Image;
            bt.Image = null;
        }

        private void bt_trangchu_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.Image = im;
        }

    }
}
