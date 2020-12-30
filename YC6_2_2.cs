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
    public partial class YC6_2_2 : Form
    {
        BUS_YC6 busYC6 = new BUS_YC6();
        Image im;
        public YC6_2_2()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void YC6_2_2_Load(object sender, EventArgs e)
        {
            datagv_dichvu.DataSource = busYC6.getDichVu();

            // Load font-style
            this.datagv_dichvu.DefaultCellStyle.Font = new Font("Times New Roman", 12);
        }

        private void datagv_dichvu_Click(object sender, EventArgs e)
        {
            txtMaDichVu.ReadOnly = true;

            int i;
            i = datagv_dichvu.CurrentRow.Index;
            txtMaDichVu.Text = datagv_dichvu.Rows[i].Cells[0].Value.ToString();
            txtTenDichVu.Text = datagv_dichvu.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = datagv_dichvu.Rows[i].Cells[3].Value.ToString();
            txtMoTa.Text = datagv_dichvu.Rows[i].Cells[2].Value.ToString();
            txtGhiChu.Text = datagv_dichvu.Rows[i].Cells[4].Value.ToString();

            if (txtMaDichVu.Text == "")
            {
                txtMaDichVu.ReadOnly = false;
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
            if (txtMaDichVu.Text != "" && txtTenDichVu.Text != "" && txtDonGia.Text != "")
            {
                int DonGia = Convert.ToInt32(txtDonGia.Text);
                if (DonGia <= 0)
                    MessageBox.Show("LỖI: Đơn giá không hợp lệ !");
                else
                {
                    DTO_DichVu dvu = new DTO_DichVu(txtMaDichVu.Text, txtTenDichVu.Text, txtMoTa.Text, DonGia, txtGhiChu.Text);

                    if (busYC6.insertDichVu(dvu))
                    {
                        MessageBox.Show("Thêm thành công");
                        datagv_dichvu.DataSource = busYC6.getDichVu();

                        txtMaDichVu.Text = "";
                        txtTenDichVu.Text = "";
                        txtDonGia.Text = "";
                        txtMoTa.Text = "";
                        txtGhiChu.Text = "";
                        txtMaDichVu.ReadOnly = false;
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
            if (datagv_dichvu.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = datagv_dichvu.SelectedRows[0];
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells[0].Value.ToString();

                    if (busYC6.deleteDichVu(id))
                    {
                        MessageBox.Show("Xóa thành công");
                        datagv_dichvu.DataSource = busYC6.getDichVu();

                        txtMaDichVu.Text = "";
                        txtTenDichVu.Text = "";
                        txtDonGia.Text = "";
                        txtMoTa.Text = "";
                        txtGhiChu.Text = "";
                        txtMaDichVu.ReadOnly = false;
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
            if (txtTenDichVu.Text != "" && txtDonGia.Text != "")
            {
                int DonGia = Convert.ToInt32(txtDonGia.Text);
                if (DonGia <= 0)
                    MessageBox.Show("LỖI: Đơn giá không hợp lệ !");
                else
                {
                    DTO_DichVu dvu = new DTO_DichVu(txtMaDichVu.Text, txtTenDichVu.Text, txtMoTa.Text, DonGia, txtGhiChu.Text);

                    if (busYC6.editDichVu(dvu))
                    {
                        MessageBox.Show("Sửa thành công");
                        datagv_dichvu.DataSource = busYC6.getDichVu();

                        txtMaDichVu.Text = "";
                        txtTenDichVu.Text = "";
                        txtDonGia.Text = "";
                        txtMoTa.Text = "";
                        txtGhiChu.Text = "";
                        txtMaDichVu.ReadOnly = false;
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

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                datagv_dichvu.DataSource = busYC6.searchDichVu(txtSearch.Text);
            }

            // Reset form
            txtMaDichVu.Text = "";
            txtTenDichVu.Text = "";
            txtDonGia.Text = "";
            txtMoTa.Text = "";
            txtGhiChu.Text = "";
            txtMaDichVu.ReadOnly = false;
        }

    }
}
