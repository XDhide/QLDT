using DTO;
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
    public partial class FormTestsControl : Form
    {
        public FormTestsControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fLogin fLogin = new fLogin();
            this.Hide();
            fLogin.ShowDialog();
            this.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fProductManagement fProductManagement = new fProductManagement();
            this.Hide(); fProductManagement.ShowDialog(); this.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fKho fKho = new fKho();
            this.Hide(); fKho.ShowDialog();this.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fQLNV fQLNV = new fQLNV();
            this.Hide(); fQLNV.ShowDialog();this.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fLichSuBan fLichSuBan = new fLichSuBan();
            this.Hide();
            fLichSuBan.ShowDialog();
            this.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fMenu fLichSuBan = new fMenu();
            this.Hide();
            fLichSuBan.ShowDialog();
            this.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fThongKeDoanhThu fLichSuBan = new fThongKeDoanhThu();
            this.Hide();
            fLichSuBan.ShowDialog();
            this.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fThongKeNhanVienvSanPham fLichSuBan = new fThongKeNhanVienvSanPham();
            this.Hide();
            fLichSuBan.ShowDialog();
            this.ShowDialog();
        }
    }
}
