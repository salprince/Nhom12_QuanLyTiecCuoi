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
    public partial class ThayDoiCa : Form
    {
        BUS_YC6 busYC6 = new BUS_YC6();
        Image im;
        public ThayDoiCa()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void YC6_2_1_Load(object sender, EventArgs e)
        {
            datagv_ca.DataSource = busYC6.getCa();

            // Load font-style
            this.datagv_ca.DefaultCellStyle.Font = new Font("Times New Roman", 12);
        }

        private void datagv_ca_Click(object sender, EventArgs e)
        {
            txtMaCa.ReadOnly = true;

            int i;
            i = datagv_ca.CurrentRow.Index;
            txtMaCa.Text = datagv_ca.Rows[i].Cells[0].Value.ToString();
            txtTenCa.Text = datagv_ca.Rows[i].Cells[1].Value.ToString();

            // Chọn hàng trống thì thêm được
            if (txtMaCa.Text == "")
            {
                txtMaCa.ReadOnly = false;
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (txtMaCa.Text != "" && txtTenCa.Text != "")
            {
                DTO_Ca ca = new DTO_Ca(txtMaCa.Text, txtTenCa.Text);

                if (busYC6.insertCa(ca))
                {
                    MessageBox.Show("Thêm thành công");
                    datagv_ca.DataSource = busYC6.getCa();

                    txtMaCa.Text = "";
                    txtTenCa.Text = "";
                    txtMaCa.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("LỖI: Thêm không thành công !");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ các trường");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (datagv_ca.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = datagv_ca.SelectedRows[0];
                if (row.Cells[0].Value != null)
                {
                    string id = row.Cells[0].Value.ToString();

                    if (busYC6.deleteCa(id))
                    {
                        MessageBox.Show("Xóa thành công");
                        datagv_ca.DataSource = busYC6.getCa();

                        txtMaCa.Text = "";
                        txtTenCa.Text = "";
                        txtMaCa.ReadOnly = false;
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
            if (txtTenCa.Text != "")
            {
                DTO_Ca ca = new DTO_Ca(txtMaCa.Text, txtTenCa.Text);

                if (busYC6.editCa(ca))
                {
                    MessageBox.Show("Sửa thành công");
                    datagv_ca.DataSource = busYC6.getCa();

                    txtMaCa.Text = "";
                    txtTenCa.Text = "";
                    txtMaCa.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("LỖI: Sửa không thành công !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống các trường");
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                datagv_ca.DataSource = busYC6.searchCa(txtSearch.Text);
            }

            // Reset form
            txtMaCa.Text = "";
            txtTenCa.Text = "";
            txtMaCa.ReadOnly = false;
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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
