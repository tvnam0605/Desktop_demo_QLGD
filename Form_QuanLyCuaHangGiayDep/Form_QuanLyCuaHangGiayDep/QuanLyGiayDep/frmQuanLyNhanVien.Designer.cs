namespace QuanLyGiayDep
{
    partial class frmQuanLyNhanVien
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
			this.btnDong = new System.Windows.Forms.Button();
			this.btnThemTK = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.txtSoDT = new System.Windows.Forms.TextBox();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHoVaTen = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtDiaChiEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvDSNV = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtpNgayTaoTK = new System.Windows.Forms.DateTimePicker();
			this.btnXoaTrong = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDong
			// 
			this.btnDong.BackColor = System.Drawing.Color.Red;
			this.btnDong.Location = new System.Drawing.Point(614, 110);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(75, 27);
			this.btnDong.TabIndex = 3;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = false;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnThemTK
			// 
			this.btnThemTK.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnThemTK.Location = new System.Drawing.Point(298, 64);
			this.btnThemTK.Name = "btnThemTK";
			this.btnThemTK.Size = new System.Drawing.Size(75, 27);
			this.btnThemTK.TabIndex = 3;
			this.btnThemTK.Text = "Thêm mới";
			this.btnThemTK.UseVisualStyleBackColor = false;
			this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnXoa.Location = new System.Drawing.Point(403, 64);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 27);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(125, 68);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Size = new System.Drawing.Size(153, 20);
			this.txtSoDT.TabIndex = 1;
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.Location = new System.Drawing.Point(125, 11);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Size = new System.Drawing.Size(153, 20);
			this.txtTenDangNhap.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(5, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ và tên *";
			// 
			// txtHoVaTen
			// 
			this.txtHoVaTen.Location = new System.Drawing.Point(125, 38);
			this.txtHoVaTen.Name = "txtHoVaTen";
			this.txtHoVaTen.Size = new System.Drawing.Size(153, 20);
			this.txtHoVaTen.TabIndex = 1;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(393, 9);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(119, 20);
			this.txtMatKhau.TabIndex = 1;
			// 
			// txtDiaChiEmail
			// 
			this.txtDiaChiEmail.Location = new System.Drawing.Point(393, 38);
			this.txtDiaChiEmail.Name = "txtDiaChiEmail";
			this.txtDiaChiEmail.Size = new System.Drawing.Size(320, 20);
			this.txtDiaChiEmail.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(5, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số điện thoại";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Location = new System.Drawing.Point(9, 162);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(725, 285);
			this.panel2.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvDSNV);
			this.groupBox1.Location = new System.Drawing.Point(0, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(730, 279);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách nhân viên";
			// 
			// dgvDSNV
			// 
			this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSNV.Location = new System.Drawing.Point(3, 16);
			this.dgvDSNV.Name = "dgvDSNV";
			this.dgvDSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSNV.Size = new System.Drawing.Size(722, 266);
			this.dgvDSNV.TabIndex = 0;
			this.dgvDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellContentClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(528, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Ngày tạo TK";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(284, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Mật khẩu *";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(5, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập *";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dtpNgayTaoTK);
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Controls.Add(this.btnThemTK);
			this.panel1.Controls.Add(this.btnXoaTrong);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.txtSoDT);
			this.panel1.Controls.Add(this.txtTenDangNhap);
			this.panel1.Controls.Add(this.txtHoVaTen);
			this.panel1.Controls.Add(this.txtMatKhau);
			this.panel1.Controls.Add(this.txtDiaChiEmail);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(9, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 152);
			this.panel1.TabIndex = 2;
			// 
			// dtpNgayTaoTK
			// 
			this.dtpNgayTaoTK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayTaoTK.Location = new System.Drawing.Point(614, 8);
			this.dtpNgayTaoTK.Name = "dtpNgayTaoTK";
			this.dtpNgayTaoTK.Size = new System.Drawing.Size(99, 20);
			this.dtpNgayTaoTK.TabIndex = 4;
			// 
			// btnXoaTrong
			// 
			this.btnXoaTrong.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnXoaTrong.Location = new System.Drawing.Point(603, 64);
			this.btnXoaTrong.Name = "btnXoaTrong";
			this.btnXoaTrong.Size = new System.Drawing.Size(86, 27);
			this.btnXoaTrong.TabIndex = 3;
			this.btnXoaTrong.Text = "Xóa Trống";
			this.btnXoaTrong.UseVisualStyleBackColor = false;
			this.btnXoaTrong.Click += new System.EventHandler(this.btnXoaTrong_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(284, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Địa chỉ Email";
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnSua.Location = new System.Drawing.Point(503, 64);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 27);
			this.btnSua.TabIndex = 3;
			this.btnSua.Text = "sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// frmQuanLyNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(737, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmQuanLyNhanVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhân viên";
			this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
			this.Click += new System.EventHandler(this.frmQuanLyNhanVien_Click);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtDiaChiEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.DateTimePicker dtpNgayTaoTK;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnXoaTrong;
		private System.Windows.Forms.Button btnSua;
	}
}