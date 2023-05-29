namespace QuanLyGiayDep
{
    partial class frmChiTietDonHang
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.txtSoDT = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvCTHoaDon = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNguoiLap = new System.Windows.Forms.TextBox();
			this.txtTienHang = new System.Windows.Forms.TextBox();
			this.txtGiamGia = new System.Windows.Forms.TextBox();
			this.txtTrangThai = new System.Windows.Forms.TextBox();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên khách hàng";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTenKH);
			this.groupBox1.Controls.Add(this.txtSoDT);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(596, 87);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin khách hàng";
			// 
			// txtTenKH
			// 
			this.txtTenKH.Location = new System.Drawing.Point(104, 24);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.ReadOnly = true;
			this.txtTenKH.Size = new System.Drawing.Size(155, 20);
			this.txtTenKH.TabIndex = 2;
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(357, 24);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.ReadOnly = true;
			this.txtSoDT.Size = new System.Drawing.Size(141, 20);
			this.txtSoDT.TabIndex = 1;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(107, 55);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.ReadOnly = true;
			this.txtDiaChi.Size = new System.Drawing.Size(391, 20);
			this.txtDiaChi.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(281, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Số điện thoại";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Địa chỉ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvCTHoaDon);
			this.groupBox2.Location = new System.Drawing.Point(12, 105);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(596, 270);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chi tiết đơn hàng";
			// 
			// dgvCTHoaDon
			// 
			this.dgvCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCTHoaDon.Location = new System.Drawing.Point(6, 19);
			this.dgvCTHoaDon.Name = "dgvCTHoaDon";
			this.dgvCTHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCTHoaDon.Size = new System.Drawing.Size(584, 233);
			this.dgvCTHoaDon.TabIndex = 0;
			this.dgvCTHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHoaDon_CellClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dtpNgayLap);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txtNguoiLap);
			this.groupBox3.Controls.Add(this.txtTienHang);
			this.groupBox3.Controls.Add(this.txtGiamGia);
			this.groupBox3.Controls.Add(this.txtTrangThai);
			this.groupBox3.Location = new System.Drawing.Point(12, 381);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(596, 138);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin hóa đơn";
			// 
			// dtpNgayLap
			// 
			this.dtpNgayLap.Enabled = false;
			this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayLap.Location = new System.Drawing.Point(104, 18);
			this.dtpNgayLap.Name = "dtpNgayLap";
			this.dtpNgayLap.Size = new System.Drawing.Size(141, 20);
			this.dtpNgayLap.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(278, 54);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Giảm giá";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(278, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Trạng thái";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Người lập";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 54);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tiền hàng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Ngày lập";
			// 
			// txtNguoiLap
			// 
			this.txtNguoiLap.Location = new System.Drawing.Point(104, 81);
			this.txtNguoiLap.Name = "txtNguoiLap";
			this.txtNguoiLap.ReadOnly = true;
			this.txtNguoiLap.Size = new System.Drawing.Size(141, 20);
			this.txtNguoiLap.TabIndex = 1;
			// 
			// txtTienHang
			// 
			this.txtTienHang.Location = new System.Drawing.Point(104, 51);
			this.txtTienHang.Name = "txtTienHang";
			this.txtTienHang.ReadOnly = true;
			this.txtTienHang.Size = new System.Drawing.Size(141, 20);
			this.txtTienHang.TabIndex = 1;
			// 
			// txtGiamGia
			// 
			this.txtGiamGia.Location = new System.Drawing.Point(354, 51);
			this.txtGiamGia.Name = "txtGiamGia";
			this.txtGiamGia.ReadOnly = true;
			this.txtGiamGia.Size = new System.Drawing.Size(141, 20);
			this.txtGiamGia.TabIndex = 1;
			// 
			// txtTrangThai
			// 
			this.txtTrangThai.Location = new System.Drawing.Point(354, 22);
			this.txtTrangThai.Name = "txtTrangThai";
			this.txtTrangThai.ReadOnly = true;
			this.txtTrangThai.Size = new System.Drawing.Size(141, 20);
			this.txtTrangThai.TabIndex = 1;
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Red;
			this.btnThoat.Location = new System.Drawing.Point(533, 525);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 27);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmChiTietDonHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(623, 564);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmChiTietDonHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi tiết đơn hàng";
			this.Load += new System.EventHandler(this.frmChiTietDonHang_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dgvCTHoaDon;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTienHang;
		private System.Windows.Forms.DateTimePicker dtpNgayLap;
		private System.Windows.Forms.TextBox txtTenKH;
    }
}