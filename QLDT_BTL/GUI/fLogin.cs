using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class fLogin : Form
    {
        LoginCheck LoginCheck = new LoginCheck();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnThoatfLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btsmall_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        fMenu menu = new fMenu();
        private void btLogin_Click(object sender, EventArgs e)
        {

            if (LoginCheck.Login(tbTaiKhoan.Text, tbMatKhau.Text) == "Dang Nhap Thanh Cong voi quyen Admin")
            {
                fMenu.Role = "ADMIN";
                this.Hide();
                menu.ShowDialog();
                this.Show();
                
            }
            else if (LoginCheck.Login(tbTaiKhoan.Text, tbMatKhau.Text) == "Dang Nhap Thanh Cong voi quyen Staff")
            {
                fMenu.Role = "STAFF";
                this.Hide();
                menu.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Dang Nhap That Bai");
            }
        }
        
        private void fLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
