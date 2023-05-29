namespace QuanLyGiayDep
{
    public partial class frmDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.btnTim = new System.Windows.Forms.Button();
            this.cbbLapBoi = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongDoanhThuChu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.btnXoaBoLoc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaBoLoc);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.cbbLapBoi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTongDoanhThu);
            this.groupBox1.Controls.Add(this.lblTongDoanhThuChu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(38, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo điều kiện";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(440, 50);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm người lập";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbbLapBoi
            // 
            this.cbbLapBoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLapBoi.FormattingEnabled = true;
            this.cbbLapBoi.Location = new System.Drawing.Point(440, 24);
            this.cbbLapBoi.Name = "cbbLapBoi";
            this.cbbLapBoi.Size = new System.Drawing.Size(222, 21);
            this.cbbLapBoi.TabIndex = 3;
            this.cbbLapBoi.SelectedIndexChanged += new System.EventHandler(this.cbbLapBoi_SelectedIndexChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(110, 52);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(203, 20);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(110, 24);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(203, 20);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lập bởi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(151, 88);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(51, 15);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "0 đồng";
            // 
            // lblTongDoanhThuChu
            // 
            this.lblTongDoanhThuChu.AutoSize = true;
            this.lblTongDoanhThuChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThuChu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThuChu.Location = new System.Drawing.Point(583, 88);
            this.lblTongDoanhThuChu.Name = "lblTongDoanhThuChu";
            this.lblTongDoanhThuChu.Size = new System.Drawing.Size(11, 15);
            this.lblTongDoanhThuChu.TabIndex = 0;
            this.lblTongDoanhThuChu.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(381, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng doanh thu bằng chứ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(18, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng doanh thu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(38, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 342);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doanh thu";
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(3, 16);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(846, 326);
            this.dgvDSHoaDon.TabIndex = 0;
            this.dgvDSHoaDon.DoubleClick += new System.EventHandler(this.dgvDSHoaDon_DoubleClick);
            // 
            // btnXoaBoLoc
            // 
            this.btnXoaBoLoc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaBoLoc.Location = new System.Drawing.Point(580, 50);
            this.btnXoaBoLoc.Name = "btnXoaBoLoc";
            this.btnXoaBoLoc.Size = new System.Drawing.Size(81, 23);
            this.btnXoaBoLoc.TabIndex = 5;
            this.btnXoaBoLoc.Text = "Xóa bộ lọc";
            this.btnXoaBoLoc.UseVisualStyleBackColor = false;
            this.btnXoaBoLoc.Click += new System.EventHandler(this.btnXoaBoLoc_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.TextBox txtTenKH;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbbLapBoi;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblTongDoanhThu;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvDSHoaDon;
		public System.Windows.Forms.Label lblTongDoanhThuChu;
		public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoaBoLoc;
    }
}