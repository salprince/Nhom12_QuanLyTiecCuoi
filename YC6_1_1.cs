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
    public partial class YC6_1_1 : Form
    {
        BUS_Sanh Sanh = new BUS_Sanh();
        Image im;
        public YC6_1_1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        // Load data
        private void YC6_1_1_Load(object sender, EventArgs e)
        {
            datagv_sanh.DataSource = Sanh.getSanh();

            // Load Combobox
            // Load font-style
            this.datagv_sanh.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            for (int i = 0; i < datagv_sanh.Columns.Count; i++)
            {
                datagv_sanh.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void datagv_sanh_Click(object sender, EventArgs e)
        {
            txtMaSanh.ReadOnly = true;

            int i;
            i = datagv_sanh.CurrentRow.Index;
            txtMaSanh.Text = datagv_sanh.Rows[i].Cells[0].Value.ToString();
            txtTenSanh.Text = datagv_sanh.Rows[i].Cells[1].Value.ToString();
            txtSoLuongBanToiDa.Text = datagv_sanh.Rows[i].Cells[2].Value.ToString();
            tbSoLuongBanToiThieu.Text = datagv_sanh.Rows[i].Cells[3].Value.ToString();
            tbDonGiaBanToiThieu.Text = datagv_sanh.Rows[i].Cells[4].Value.ToString();
            txtGhiChu.Text = datagv_sanh.Rows[i].Cells[5].Value.ToString();

            if (txtMaSanh.Text == "")
            {
                txtMaSanh.ReadOnly = false;
            }
        }

        // Display ComboBox
        

        // txtSoLuongBanToiDa chỉ nhận giá trị số
        private void txtSoLuongBanToiDa_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // Nút thêm
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (txtMaSanh.Text != "" && txtTenSanh.Text != "" && txtSoLuongBanToiDa.Text != "" && tbSoLuongBanToiThieu.Text != ""&& tbDonGiaBanToiThieu.Text!="")
            {
                int SoLuongBanToiDa = Convert.ToInt32(txtSoLuongBanToiDa.Text);
                int SoLuongBanToiThieu = Convert.ToInt32(tbSoLuongBanToiThieu.Text);
                int DonGiaBanToiThieu = Convert.ToInt32(tbDonGiaBanToiThieu.Text);
                if (SoLuongBanToiDa <= 0)
                    MessageBox.Show("Số lượng bàn tối đa không hợp lệ");
                else
                    if (SoLuongBanToiThieu <= 0)
                    MessageBox.Show("Số lượng bàn tối thiểu không hợp lệ");
                    else
                        if (DonGiaBanToiThieu <= 0)
                        MessageBox.Show("Đơn giá bàn tối thiểu không hợp lệ");
                else
                if (SoLuongBanToiThieu >= SoLuongBanToiDa)
                    MessageBox.Show("Số lượng bàn tối thiểu phải nhỏ hơn số lượng bàn tối đa");
                else
                {
                    DTO_Sanh sanh = new DTO_Sanh(txtMaSanh.Text, txtTenSanh.Text, SoLuongBanToiDa, SoLuongBanToiThieu, DonGiaBanToiThieu, txtGhiChu.Text);

                    if (Sanh.insertSanh(sanh))
                    {
                        MessageBox.Show("Thêm thành công");
                        datagv_sanh.DataSource = Sanh.getSanh(); // Refresh datagridview

                        //Refresh textform
                        txtMaSanh.Text = "";
                        txtTenSanh.Text = "";
                        txtSoLuongBanToiDa.Text = "";
                        tbSoLuongBanToiThieu.Text = "";
                        tbDonGiaBanToiThieu.Text = "";
                        txtGhiChu.Text = "";
                        txtMaSanh.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }

            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ các trường (Ghi Chú có thể không nhập)");
            }
        }

        // Nút xóa
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (datagv_sanh.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = datagv_sanh.SelectedRows[0];
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells[0].Value.ToString();

                    if (Sanh.deleteSanh(id))
                    {
                        MessageBox.Show("Xóa thành công");
                        datagv_sanh.DataSource = Sanh.getSanh(); // Refresh datagridview

                        // Refresh textform
                        txtMaSanh.Text = "";
                        txtTenSanh.Text = "";
                        txtSoLuongBanToiDa.Text = "";
                        tbSoLuongBanToiThieu.Text = "";
                        tbDonGiaBanToiThieu.Text = "";
                        txtGhiChu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bấm cột đầu tiên để tô đậm hàng muốn xóa");
            }
        }

        // Nút sửa
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (txtTenSanh.Text != "" && txtSoLuongBanToiDa.Text != "")
            {
                int SoLuongBanToiDa = Convert.ToInt32(txtSoLuongBanToiDa.Text);
                int SoLuongBanToiThieu = Convert.ToInt32(tbSoLuongBanToiThieu.Text);
                int DonGiaBanToiThieu = Convert.ToInt32(tbDonGiaBanToiThieu.Text);
                if (SoLuongBanToiDa <= 0)
                    MessageBox.Show("Số lượng bàn tối đa không hợp lệ");
                else
                    if (SoLuongBanToiThieu <= 0)
                    MessageBox.Show("Số lượng bàn tối thiểu không hợp lệ");
                else
                        if (DonGiaBanToiThieu <= 0)
                    MessageBox.Show("Đơn giá bàn tối thiểu không hợp lệ");
                else
                if (SoLuongBanToiThieu >= SoLuongBanToiDa)
                    MessageBox.Show("Số lượng bàn tối thiểu phải nhỏ hơn số lượng bàn tối đa");
                else
                {     
                    DTO_Sanh sanh = new DTO_Sanh(txtMaSanh.Text, txtTenSanh.Text, SoLuongBanToiDa, SoLuongBanToiThieu, DonGiaBanToiThieu, txtGhiChu.Text);

                    if (Sanh.editSanh(sanh))
                    {
                        MessageBox.Show("Sửa thành công");
                       datagv_sanh.DataSource = Sanh.getSanh(); // Refresh datagridview

                        // Refresh textform
                    txtMaSanh.Text = "";
                    txtTenSanh.Text = "";
                    txtSoLuongBanToiDa.Text = "";
                    tbSoLuongBanToiThieu.Text = "";
                    tbDonGiaBanToiThieu.Text = "";
                    txtGhiChu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống các trường (Ghi Chú có thể để trống)");
            }
        }

        // Nút tìm kiếm
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                datagv_sanh.DataSource = Sanh.searchSanh(txtSearch.Text);
            }

            txtMaSanh.Text = "";
            txtTenSanh.Text = "";
            txtSoLuongBanToiDa.Text = "";
            tbSoLuongBanToiThieu.Text = "";
            tbDonGiaBanToiThieu.Text = "";
            txtGhiChu.Text = "";
            txtMaSanh.ReadOnly = false;
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

        private void tbSoLuongBanToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDonGiaBanToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
