namespace GUI
{
    partial class fMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btOpenMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btExit = new System.Windows.Forms.ToolStripButton();
            this.btHidemenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuTranstion = new System.Windows.Forms.Timer(this.components);
            this.MenuBarTranstion = new System.Windows.Forms.Timer(this.components);
            this.MenuTask = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btlis1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btQuanly = new System.Windows.Forms.Button();
            this.btQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btQuanLySanPham = new System.Windows.Forms.Button();
            this.btQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.MenuTask.SuspendLayout();
            this.btlis1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btOpenMenu,
            this.toolStripSeparator1,
            this.btExit,
            this.btHidemenu,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1920, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Cửa hàng điện thoại";
            // 
            // btOpenMenu
            // 
            this.btOpenMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOpenMenu.Image = ((System.Drawing.Image)(resources.GetObject("btOpenMenu.Image")));
            this.btOpenMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpenMenu.Name = "btOpenMenu";
            this.btOpenMenu.Size = new System.Drawing.Size(29, 24);
            this.btOpenMenu.Text = "toolStripButton1";
            this.btOpenMenu.Click += new System.EventHandler(this.btOpenMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btExit
            // 
            this.btExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExit.Name = "btExit";
            this.btExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btExit.Size = new System.Drawing.Size(29, 24);
            this.btExit.Text = "toolStripButton2";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btHidemenu
            // 
            this.btHidemenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btHidemenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btHidemenu.Image = ((System.Drawing.Image)(resources.GetObject("btHidemenu.Image")));
            this.btHidemenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btHidemenu.Name = "btHidemenu";
            this.btHidemenu.Size = new System.Drawing.Size(29, 24);
            this.btHidemenu.Text = "toolStripButton3";
            this.btHidemenu.Click += new System.EventHandler(this.btHidemenu_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // menuTranstion
            // 
            this.menuTranstion.Interval = 10;
            this.menuTranstion.Tick += new System.EventHandler(this.menuTranstion_Tick);
            // 
            // MenuBarTranstion
            // 
            this.MenuBarTranstion.Interval = 10;
            this.MenuBarTranstion.Tick += new System.EventHandler(this.MenuBarTranstion_Tick);
            // 
            // MenuTask
            // 
            this.MenuTask.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MenuTask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuTask.Controls.Add(this.button1);
            this.MenuTask.Controls.Add(this.button5);
            this.MenuTask.Controls.Add(this.btlis1);
            this.MenuTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuTask.ForeColor = System.Drawing.Color.White;
            this.MenuTask.Location = new System.Drawing.Point(0, 27);
            this.MenuTask.Name = "MenuTask";
            this.MenuTask.Size = new System.Drawing.Size(293, 853);
            this.MenuTask.TabIndex = 3;
            this.MenuTask.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuTask_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(276, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "      Trang chủ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 67);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(276, 66);
            this.button5.TabIndex = 9;
            this.button5.Text = "         Lịch sử bán";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btlis1
            // 
            this.btlis1.Controls.Add(this.btQuanly);
            this.btlis1.Controls.Add(this.btQuanLyNhanVien);
            this.btlis1.Controls.Add(this.btQuanLySanPham);
            this.btlis1.Controls.Add(this.btQuanLyTaiKhoan);
            this.btlis1.Controls.Add(this.button2);
            this.btlis1.Location = new System.Drawing.Point(3, 139);
            this.btlis1.Name = "btlis1";
            this.btlis1.Size = new System.Drawing.Size(288, 348);
            this.btlis1.TabIndex = 6;
            // 
            // btQuanly
            // 
            this.btQuanly.BackColor = System.Drawing.SystemColors.Control;
            this.btQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btQuanly.Image = ((System.Drawing.Image)(resources.GetObject("btQuanly.Image")));
            this.btQuanly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanly.Location = new System.Drawing.Point(3, 3);
            this.btQuanly.Name = "btQuanly";
            this.btQuanly.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btQuanly.Size = new System.Drawing.Size(276, 58);
            this.btQuanly.TabIndex = 12;
            this.btQuanly.Text = "      Quản Lý";
            this.btQuanly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanly.UseVisualStyleBackColor = false;
            this.btQuanly.Click += new System.EventHandler(this.btQuanly_Click);
            // 
            // btQuanLyNhanVien
            // 
            this.btQuanLyNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.btQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btQuanLyNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btQuanLyNhanVien.Image")));
            this.btQuanLyNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLyNhanVien.Location = new System.Drawing.Point(3, 67);
            this.btQuanLyNhanVien.Name = "btQuanLyNhanVien";
            this.btQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btQuanLyNhanVien.Size = new System.Drawing.Size(276, 69);
            this.btQuanLyNhanVien.TabIndex = 11;
            this.btQuanLyNhanVien.Text = "         Quản lý nhân viên";
            this.btQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btQuanLyNhanVien.Click += new System.EventHandler(this.btQuanLyNhanVien_Click);
            // 
            // btQuanLySanPham
            // 
            this.btQuanLySanPham.BackColor = System.Drawing.SystemColors.Control;
            this.btQuanLySanPham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btQuanLySanPham.Image = ((System.Drawing.Image)(resources.GetObject("btQuanLySanPham.Image")));
            this.btQuanLySanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLySanPham.Location = new System.Drawing.Point(3, 142);
            this.btQuanLySanPham.Name = "btQuanLySanPham";
            this.btQuanLySanPham.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btQuanLySanPham.Size = new System.Drawing.Size(276, 63);
            this.btQuanLySanPham.TabIndex = 10;
            this.btQuanLySanPham.Text = "         Quản lý sản phẩm";
            this.btQuanLySanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLySanPham.UseVisualStyleBackColor = false;
            this.btQuanLySanPham.Click += new System.EventHandler(this.button6_Click);
            // 
            // btQuanLyTaiKhoan
            // 
            this.btQuanLyTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.btQuanLyTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btQuanLyTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btQuanLyTaiKhoan.Image")));
            this.btQuanLyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLyTaiKhoan.Location = new System.Drawing.Point(3, 211);
            this.btQuanLyTaiKhoan.Name = "btQuanLyTaiKhoan";
            this.btQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btQuanLyTaiKhoan.Size = new System.Drawing.Size(276, 65);
            this.btQuanLyTaiKhoan.TabIndex = 12;
            this.btQuanLyTaiKhoan.Text = "         Quản lý tài khoản";
            this.btQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btQuanLyTaiKhoan.Click += new System.EventHandler(this.btQuanLyTaiKhoan_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 282);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(276, 71);
            this.button2.TabIndex = 8;
            this.button2.Text = "         Thống kê doanh thu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Điện Thoại";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 880);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuTask);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMenu_FormClosing);
            this.Load += new System.EventHandler(this.fMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MenuTask.ResumeLayout(false);
            this.btlis1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btHidemenu;
        private System.Windows.Forms.ToolStripButton btExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer menuTranstion;
        private System.Windows.Forms.Timer MenuBarTranstion;
        private System.Windows.Forms.ToolStripButton btOpenMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.FlowLayoutPanel MenuTask;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btQuanLySanPham;
        private System.Windows.Forms.Button btQuanLyNhanVien;
        private System.Windows.Forms.Button btQuanLyTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel btlis1;
        private System.Windows.Forms.Button btQuanly;
    }
}