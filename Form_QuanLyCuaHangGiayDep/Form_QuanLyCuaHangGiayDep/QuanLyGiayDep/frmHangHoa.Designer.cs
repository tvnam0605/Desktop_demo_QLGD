namespace QuanLyGiayDep
{
    partial class frmHangHoa
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
            this.txtTenOrMa = new System.Windows.Forms.TextBox();
            this.btnXoaBoLoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLoaiHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSMH = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTTMa = new System.Windows.Forms.TextBox();
            this.txtTTTen = new System.Windows.Forms.TextBox();
            this.txtTTSize = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.txtLoaiHH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên cần tìm";
            // 
            // txtTenOrMa
            // 
            this.txtTenOrMa.Location = new System.Drawing.Point(322, 25);
            this.txtTenOrMa.Name = "txtTenOrMa";
            this.txtTenOrMa.Size = new System.Drawing.Size(181, 20);
            this.txtTenOrMa.TabIndex = 1;
            this.txtTenOrMa.TextChanged += new System.EventHandler(this.txtTenOrMa_TextChanged);
            // 
            // btnXoaBoLoc
            // 
            this.btnXoaBoLoc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaBoLoc.Location = new System.Drawing.Point(536, 21);
            this.btnXoaBoLoc.Name = "btnXoaBoLoc";
            this.btnXoaBoLoc.Size = new System.Drawing.Size(75, 27);
            this.btnXoaBoLoc.TabIndex = 2;
            this.btnXoaBoLoc.Text = "Xóa bộ lọc";
            this.btnXoaBoLoc.UseVisualStyleBackColor = false;
            this.btnXoaBoLoc.Click += new System.EventHandler(this.btnXoaBoLoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbLoaiHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenOrMa);
            this.groupBox1.Controls.Add(this.btnXoaBoLoc);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm mặt hàng";
            // 
            // cbbLoaiHang
            // 
            this.cbbLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiHang.FormattingEnabled = true;
            this.cbbLoaiHang.Location = new System.Drawing.Point(78, 25);
            this.cbbLoaiHang.Name = "cbbLoaiHang";
            this.cbbLoaiHang.Size = new System.Drawing.Size(128, 21);
            this.cbbLoaiHang.TabIndex = 3;
            this.cbbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiHang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSMH);
            this.groupBox2.Location = new System.Drawing.Point(26, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 265);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mặt hàng";
            // 
            // dgvDSMH
            // 
            this.dgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSMH.Location = new System.Drawing.Point(3, 16);
            this.dgvDSMH.MultiSelect = false;
            this.dgvDSMH.Name = "dgvDSMH";
            this.dgvDSMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMH.Size = new System.Drawing.Size(625, 246);
            this.dgvDSMH.TabIndex = 0;
            this.dgvDSMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên hàng hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Xuất xứ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loại hàng hóa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhà cung cấp";
            // 
            // txtTTMa
            // 
            this.txtTTMa.Location = new System.Drawing.Point(767, 124);
            this.txtTTMa.Name = "txtTTMa";
            this.txtTTMa.Size = new System.Drawing.Size(238, 20);
            this.txtTTMa.TabIndex = 1;
            // 
            // txtTTTen
            // 
            this.txtTTTen.Location = new System.Drawing.Point(767, 157);
            this.txtTTTen.Name = "txtTTTen";
            this.txtTTTen.Size = new System.Drawing.Size(238, 20);
            this.txtTTTen.TabIndex = 1;
            // 
            // txtTTSize
            // 
            this.txtTTSize.Location = new System.Drawing.Point(767, 190);
            this.txtTTSize.Name = "txtTTSize";
            this.txtTTSize.Size = new System.Drawing.Size(238, 20);
            this.txtTTSize.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(767, 228);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(238, 20);
            this.txtGia.TabIndex = 1;
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(767, 295);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(238, 20);
            this.txtXuatXu.TabIndex = 1;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(767, 328);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(238, 20);
            this.txtNCC.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThem.Location = new System.Drawing.Point(686, 375);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 27);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSua.Location = new System.Drawing.Point(767, 375);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 27);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoa.Location = new System.Drawing.Point(848, 375);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 27);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMacDinh.Location = new System.Drawing.Point(929, 375);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 27);
            this.btnMacDinh.TabIndex = 2;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = false;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // txtLoaiHH
            // 
            this.txtLoaiHH.Location = new System.Drawing.Point(767, 263);
            this.txtLoaiHH.Name = "txtLoaiHH";
            this.txtLoaiHH.Size = new System.Drawing.Size(238, 20);
            this.txtLoaiHH.TabIndex = 1;
            this.txtLoaiHH.TextChanged += new System.EventHandler(this.txtLoaiHH_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(660, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "( 1 là dép, 2 là giày)";
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1017, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.txtXuatXu);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLoaiHH);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTTSize);
            this.Controls.Add(this.txtTTTen);
            this.Controls.Add(this.txtTTMa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenOrMa;
        private System.Windows.Forms.Button btnXoaBoLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbLoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTTMa;
        private System.Windows.Forms.TextBox txtTTTen;
        private System.Windows.Forms.TextBox txtTTSize;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMacDinh;
		private System.Windows.Forms.TextBox txtLoaiHH;
        private System.Windows.Forms.Label label10;
    }
}