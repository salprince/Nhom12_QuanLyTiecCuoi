using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLTiecCuoi
{
    public partial class LogIn : Form
    {
        BUS_NhanVien bus = new BUS_NhanVien();
        Image im;
        public static bool LogOut = false;
        public LogIn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus.checkUser(Username.Text, Password.Text))
                {
                    MainMenu mainMenu = new MainMenu();
                    this.Hide();
                    mainMenu.ShowDialog();
                }
                else MessageBox.Show("Sai Tài Khoản/Mật khẩu");
                
            }
            catch (Exception ea)
            {

            }
            
        }
       

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
