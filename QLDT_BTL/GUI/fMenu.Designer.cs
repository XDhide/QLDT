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
            this.MenuTask = new System.Windows.Forms.FlowLayoutPanel();
            this.menuTranstion = new System.Windows.Forms.Timer(this.components);
            this.MenuBarTranstion = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btOpenMenu,
            this.toolStripSeparator1,
            this.btExit,
            this.btHidemenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1920, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // MenuTask
            // 
            this.MenuTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuTask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuTask.Location = new System.Drawing.Point(0, 27);
            this.MenuTask.Name = "MenuTask";
            this.MenuTask.Size = new System.Drawing.Size(350, 1053);
            this.MenuTask.TabIndex = 3;
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
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.MenuTask);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btOpenMenu;
        private System.Windows.Forms.ToolStripButton btHidemenu;
        private System.Windows.Forms.ToolStripButton btExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel MenuTask;
        private System.Windows.Forms.Timer menuTranstion;
        private System.Windows.Forms.Timer MenuBarTranstion;
    }
}