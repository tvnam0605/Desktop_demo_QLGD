namespace QuanLyPhongKS
{
    partial class frmTraPhong
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtHoTenKH = new System.Windows.Forms.TextBox();
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.cboMaKH = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.lblNgayThanhToan = new System.Windows.Forms.Label();
			this.lblTenKH = new System.Windows.Forms.Label();
			this.lblPhong = new System.Windows.Forms.Label();
			this.lblSoNgayO = new System.Windows.Forms.Label();
			this.lblMaKH = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtMaHoaDon = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lbNgayThanhToan = new System.Windows.Forms.Label();
			this.lbPhong = new System.Windows.Forms.Label();
			this.lbSoNgayO = new System.Windows.Forms.Label();
			this.lbMaKH = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnThemHoaDon = new System.Windows.Forms.Button();
			this.btnXemDanhSachHoaDon = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dgvDanhSachThue = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThue)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtHoTenKH);
			this.groupBox1.Controls.Add(this.btnTimkiem);
			this.groupBox1.Controls.Add(this.cboMaKH);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(28, 82);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(539, 123);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// txtHoTenKH
			// 
			this.txtHoTenKH.Location = new System.Drawing.Point(69, 51);
			this.txtHoTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtHoTenKH.Name = "txtHoTenKH";
			this.txtHoTenKH.Size = new System.Drawing.Size(186, 20);
			this.txtHoTenKH.TabIndex = 4;
			this.txtHoTenKH.TextChanged += new System.EventHandler(this.txtHoTenKH_TextChanged);
			// 
			// btnTimkiem
			// 
			this.btnTimkiem.Location = new System.Drawing.Point(366, 26);
			this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnTimkiem.Name = "btnTimkiem";
			this.btnTimkiem.Size = new System.Drawing.Size(120, 19);
			this.btnTimkiem.TabIndex = 3;
			this.btnTimkiem.Text = "Tìm kiếm theo mã khách hàng";
			this.btnTimkiem.UseVisualStyleBackColor = true;
			this.btnTimkiem.Click += new System.EventHandler(this.button1_Click);
			// 
			// cboMaKH
			// 
			this.cboMaKH.FormattingEnabled = true;
			this.cboMaKH.Location = new System.Drawing.Point(69, 24);
			this.cboMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cboMaKH.Name = "cboMaKH";
			this.cboMaKH.Size = new System.Drawing.Size(154, 21);
			this.cboMaKH.TabIndex = 2;
			this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 28);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã KH:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 54);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ Tên:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SteelBlue;
			this.label1.Location = new System.Drawing.Point(187, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "THANH TOÁN";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.lblTongTien);
			this.groupBox2.Controls.Add(this.lblNgayThanhToan);
			this.groupBox2.Controls.Add(this.lblTenKH);
			this.groupBox2.Controls.Add(this.lblPhong);
			this.groupBox2.Controls.Add(this.lblSoNgayO);
			this.groupBox2.Controls.Add(this.lblMaKH);
			this.groupBox2.Controls.Add(this.btnThoat);
			this.groupBox2.Controls.Add(this.btnTinhTien);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(28, 227);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Size = new System.Drawing.Size(539, 174);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thanh Toán";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(241, 124);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "VND";
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Location = new System.Drawing.Point(210, 124);
			this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(16, 13);
			this.lblTongTien.TabIndex = 5;
			this.lblTongTien.Text = "...";
			// 
			// lblNgayThanhToan
			// 
			this.lblNgayThanhToan.AutoSize = true;
			this.lblNgayThanhToan.Location = new System.Drawing.Point(112, 94);
			this.lblNgayThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNgayThanhToan.Name = "lblNgayThanhToan";
			this.lblNgayThanhToan.Size = new System.Drawing.Size(16, 13);
			this.lblNgayThanhToan.TabIndex = 5;
			this.lblNgayThanhToan.Text = "...";
			// 
			// lblTenKH
			// 
			this.lblTenKH.AutoSize = true;
			this.lblTenKH.Location = new System.Drawing.Point(112, 67);
			this.lblTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTenKH.Name = "lblTenKH";
			this.lblTenKH.Size = new System.Drawing.Size(16, 13);
			this.lblTenKH.TabIndex = 5;
			this.lblTenKH.Text = "...";
			// 
			// lblPhong
			// 
			this.lblPhong.AutoSize = true;
			this.lblPhong.Location = new System.Drawing.Point(306, 58);
			this.lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPhong.Name = "lblPhong";
			this.lblPhong.Size = new System.Drawing.Size(16, 13);
			this.lblPhong.TabIndex = 5;
			this.lblPhong.Text = "...";
			// 
			// lblSoNgayO
			// 
			this.lblSoNgayO.AutoSize = true;
			this.lblSoNgayO.Location = new System.Drawing.Point(306, 35);
			this.lblSoNgayO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSoNgayO.Name = "lblSoNgayO";
			this.lblSoNgayO.Size = new System.Drawing.Size(16, 13);
			this.lblSoNgayO.TabIndex = 5;
			this.lblSoNgayO.Text = "...";
			// 
			// lblMaKH
			// 
			this.lblMaKH.AutoSize = true;
			this.lblMaKH.Location = new System.Drawing.Point(112, 32);
			this.lblMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMaKH.Name = "lblMaKH";
			this.lblMaKH.Size = new System.Drawing.Size(16, 13);
			this.lblMaKH.TabIndex = 5;
			this.lblMaKH.Text = "...";
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(366, 62);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(120, 19);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(366, 32);
			this.btnTinhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(120, 19);
			this.btnTinhTien.TabIndex = 4;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(243, 58);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "Phòng:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(81, 124);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(138, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Tổng tiền phải thanh toán : ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 94);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ngày thanh toán:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 67);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tên Khách hàng:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(241, 32);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Số ngày ở:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 32);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mã khách hàng:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtMaHoaDon);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.lbNgayThanhToan);
			this.groupBox3.Controls.Add(this.lbPhong);
			this.groupBox3.Controls.Add(this.lbSoNgayO);
			this.groupBox3.Controls.Add(this.lbMaKH);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.btnThemHoaDon);
			this.groupBox3.Controls.Add(this.btnXemDanhSachHoaDon);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.label24);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.label23);
			this.groupBox3.Location = new System.Drawing.Point(28, 227);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Size = new System.Drawing.Size(539, 174);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thanh Toán";
			// 
			// txtMaHoaDon
			// 
			this.txtMaHoaDon.Location = new System.Drawing.Point(149, 143);
			this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtMaHoaDon.Name = "txtMaHoaDon";
			this.txtMaHoaDon.Size = new System.Drawing.Size(122, 20);
			this.txtMaHoaDon.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(291, 124);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(37, 17);
			this.label11.TabIndex = 5;
			this.label11.Text = "VND";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(244, 127);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 17);
			this.label12.TabIndex = 5;
			this.label12.Text = "...";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// lbNgayThanhToan
			// 
			this.lbNgayThanhToan.AutoSize = true;
			this.lbNgayThanhToan.Location = new System.Drawing.Point(112, 68);
			this.lbNgayThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbNgayThanhToan.Name = "lbNgayThanhToan";
			this.lbNgayThanhToan.Size = new System.Drawing.Size(16, 13);
			this.lbNgayThanhToan.TabIndex = 5;
			this.lbNgayThanhToan.Text = "...";
			// 
			// lbPhong
			// 
			this.lbPhong.AutoSize = true;
			this.lbPhong.Location = new System.Drawing.Point(306, 58);
			this.lbPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbPhong.Name = "lbPhong";
			this.lbPhong.Size = new System.Drawing.Size(16, 13);
			this.lbPhong.TabIndex = 5;
			this.lbPhong.Text = "...";
			// 
			// lbSoNgayO
			// 
			this.lbSoNgayO.AutoSize = true;
			this.lbSoNgayO.Location = new System.Drawing.Point(306, 35);
			this.lbSoNgayO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbSoNgayO.Name = "lbSoNgayO";
			this.lbSoNgayO.Size = new System.Drawing.Size(16, 13);
			this.lbSoNgayO.TabIndex = 5;
			this.lbSoNgayO.Text = "...";
			this.lbSoNgayO.Click += new System.EventHandler(this.lbSoNgayO_Click);
			// 
			// lbMaKH
			// 
			this.lbMaKH.AutoSize = true;
			this.lbMaKH.Location = new System.Drawing.Point(112, 32);
			this.lbMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbMaKH.Name = "lbMaKH";
			this.lbMaKH.Size = new System.Drawing.Size(16, 13);
			this.lbMaKH.TabIndex = 5;
			this.lbMaKH.Text = "...";
			this.lbMaKH.Click += new System.EventHandler(this.lbMaKH_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(366, 62);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 19);
			this.button2.TabIndex = 4;
			this.button2.Text = "Thoát";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnThemHoaDon
			// 
			this.btnThemHoaDon.Location = new System.Drawing.Point(322, 142);
			this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnThemHoaDon.Name = "btnThemHoaDon";
			this.btnThemHoaDon.Size = new System.Drawing.Size(101, 19);
			this.btnThemHoaDon.TabIndex = 4;
			this.btnThemHoaDon.Text = "Thêm Hóa đơn";
			this.btnThemHoaDon.UseVisualStyleBackColor = true;
			// 
			// btnXemDanhSachHoaDon
			// 
			this.btnXemDanhSachHoaDon.Location = new System.Drawing.Point(443, 142);
			this.btnXemDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnXemDanhSachHoaDon.Name = "btnXemDanhSachHoaDon";
			this.btnXemDanhSachHoaDon.Size = new System.Drawing.Size(77, 19);
			this.btnXemDanhSachHoaDon.TabIndex = 4;
			this.btnXemDanhSachHoaDon.Text = "Xem danh sách hóa đơn";
			this.btnXemDanhSachHoaDon.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(366, 32);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 19);
			this.button3.TabIndex = 4;
			this.button3.Text = "Tính tiền";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(243, 58);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(41, 13);
			this.label18.TabIndex = 1;
			this.label18.Text = "Phòng:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(82, 148);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(68, 13);
			this.label24.TabIndex = 0;
			this.label24.Text = "Mã hóa đơn:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(81, 124);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(183, 17);
			this.label19.TabIndex = 0;
			this.label19.Text = "Tổng tiền phải thanh toán : ";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(19, 65);
			this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(89, 13);
			this.label20.TabIndex = 0;
			this.label20.Text = "Ngày thanh toán:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(241, 32);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(58, 13);
			this.label22.TabIndex = 0;
			this.label22.Text = "Số ngày ở:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(16, 32);
			this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(85, 13);
			this.label23.TabIndex = 0;
			this.label23.Text = "Mã khách hàng:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dgvDanhSachThue);
			this.groupBox4.Location = new System.Drawing.Point(28, 429);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox4.Size = new System.Drawing.Size(520, 219);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Thông tin khách hàng thanh toán";
			// 
			// dgvDanhSachThue
			// 
			this.dgvDanhSachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachThue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDanhSachThue.Location = new System.Drawing.Point(2, 15);
			this.dgvDanhSachThue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvDanhSachThue.Name = "dgvDanhSachThue";
			this.dgvDanhSachThue.RowHeadersWidth = 51;
			this.dgvDanhSachThue.RowTemplate.Height = 24;
			this.dgvDanhSachThue.Size = new System.Drawing.Size(516, 202);
			this.dgvDanhSachThue.TabIndex = 1;
			this.dgvDanhSachThue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThue_CellContentClick);
			// 
			// frmTraPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 602);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmTraPhong";
			this.Text = "frmTraPhong";
			this.Load += new System.EventHandler(this.frmTraPhong_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNgayThanhToan;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblSoNgayO;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbNgayThanhToan;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbSoNgayO;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button btnXemDanhSachHoaDon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDanhSachThue;
    }
}