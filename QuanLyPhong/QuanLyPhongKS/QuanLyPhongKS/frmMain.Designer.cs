namespace QuanLyPhongKS
{
	partial class frmMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmQLKH = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmQLPhong = new System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmThuePhong = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmTraPhong = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ftPhong = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.tsmTaiKhoan});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDangXuat});
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
			this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
			// 
			// tsmDangXuat
			// 
			this.tsmDangXuat.Name = "tsmDangXuat";
			this.tsmDangXuat.Size = new System.Drawing.Size(129, 22);
			this.tsmDangXuat.Text = "Đăng Xuất";
			this.tsmDangXuat.Click += new System.EventHandler(this.tsmDangXuat_Click);
			// 
			// quảnLýToolStripMenuItem
			// 
			this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQLKH,
            this.tsmQLPhong});
			this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
			this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.quảnLýToolStripMenuItem.Text = "Quản Lý";
			// 
			// tsmQLKH
			// 
			this.tsmQLKH.Name = "tsmQLKH";
			this.tsmQLKH.Size = new System.Drawing.Size(186, 22);
			this.tsmQLKH.Text = "Quản Lý Khách Hàng";
			this.tsmQLKH.Click += new System.EventHandler(this.tsmQLKH_Click);
			// 
			// tsmQLPhong
			// 
			this.tsmQLPhong.Name = "tsmQLPhong";
			this.tsmQLPhong.Size = new System.Drawing.Size(186, 22);
			this.tsmQLPhong.Text = "Quản Lý Phòng";
			this.tsmQLPhong.Click += new System.EventHandler(this.tsmQLPhong_Click);
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThuePhong,
            this.tsmTraPhong});
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
			// 
			// tsmThuePhong
			// 
			this.tsmThuePhong.Name = "tsmThuePhong";
			this.tsmThuePhong.Size = new System.Drawing.Size(139, 22);
			this.tsmThuePhong.Text = "Thuê Phòng";
			this.tsmThuePhong.Click += new System.EventHandler(this.tsmThuePhong_Click);
			// 
			// tsmTraPhong
			// 
			this.tsmTraPhong.Name = "tsmTraPhong";
			this.tsmTraPhong.Size = new System.Drawing.Size(139, 22);
			this.tsmTraPhong.Text = "Trả Phòng";
			this.tsmTraPhong.Click += new System.EventHandler(this.tsmTraPhong_Click);
			// 
			// tsmTaiKhoan
			// 
			this.tsmTaiKhoan.Name = "tsmTaiKhoan";
			this.tsmTaiKhoan.Size = new System.Drawing.Size(72, 20);
			this.tsmTaiKhoan.Text = "Tài Khoản";
			this.tsmTaiKhoan.Click += new System.EventHandler(this.tsmTaiKhoan_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1022, 427);
			this.panel1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ftPhong);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1022, 427);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sơ đồ khách sạn";
			// 
			// ftPhong
			// 
			this.ftPhong.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ftPhong.Location = new System.Drawing.Point(3, 16);
			this.ftPhong.Name = "ftPhong";
			this.ftPhong.Size = new System.Drawing.Size(1016, 408);
			this.ftPhong.TabIndex = 2;
			this.ftPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.ftPhong_Paint);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 451);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmQLKH;
		private System.Windows.Forms.ToolStripMenuItem tsmQLPhong;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem tsmThuePhong;
		private System.Windows.Forms.ToolStripMenuItem tsmTaiKhoan;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel ftPhong;
        private System.Windows.Forms.ToolStripMenuItem tsmDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsmTraPhong;
    }
}