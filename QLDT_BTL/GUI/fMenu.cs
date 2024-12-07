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
        public fMenu()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void menuTranstion_Tick(object sender, EventArgs e)
        {
            
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
                if (MenuTask.Width >= 350)
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
    }
}
