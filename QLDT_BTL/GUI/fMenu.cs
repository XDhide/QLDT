using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fMenu : Form
    {
        public static string Role {  get; set; }
        public fMenu()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        bool buttonTranssion = false;
        private void menuTranstion_Tick(object sender, EventArgs e)
        {
            if (buttonTranssion)
            {
                btlis1.Height += 5;
                if (btlis1.Height >= 270)
                {
                    menuTranstion.Stop();
                    buttonTranssion = false;
                }
            }
            else
            {
                btlis1.Height -= 5;
                if (btlis1.Height <= 50)
                {
                    menuTranstion.Stop();
                    buttonTranssion = true;
                }
            }
        }

        private void btOpenMenu_Click(object sender, EventArgs e)
        {
            MenuBarTranstion.Start();
        }
        bool menuBarExpand = true;
        private void MenuBarTranstion_Tick(object sender, EventArgs e)
        {
            if(menuBarExpand)
            {
                MenuTask.Width -= 5;
                if(MenuTask.Width <= 0)
                {
                    MenuBarTranstion.Stop();
                    menuBarExpand = false;
                }
            }else
            {
                MenuTask.Width += 5;
                if (MenuTask.Width >= 230)
                {
                    MenuBarTranstion.Stop();
                    menuBarExpand = true;
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btHidemenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            if(Role == "ADMIN")
            {
                btlis1.Enabled = true;
            }
            else if(Role == "STAFF")
            {
                btlis1.Enabled=false;
            }
            else
            {
                btlis1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham qlsp = new frmQuanLySanPham();
            qlsp.MdiParent = this;
            qlsp.Dock = DockStyle.Fill;
            qlsp.Show();
        }

        private void btQuanly_Click(object sender, EventArgs e)
        {
            menuTranstion.Start();
        }

        private void fMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Role = null;
        }

        private void MenuTask_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien qlnv = new frmQuanLyNhanVien();
            qlnv.MdiParent = this;
            qlnv.Dock = DockStyle.Fill;
            qlnv.Show();
        }

        private void btQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan qlnv = new fQuanLyTaiKhoan();
            qlnv.MdiParent = this;
            qlnv.Dock = DockStyle.Fill;
            qlnv.Show();
        }
    }
}
