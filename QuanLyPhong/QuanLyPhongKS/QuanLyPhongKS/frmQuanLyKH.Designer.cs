namespace QuanLyPhongKS
{
	partial class frmQuanLyKH
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
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cMTLabel = new System.Windows.Forms.Label();
            this.txt_cmt = new System.Windows.Forms.TextBox();
            this.diachiLabel = new System.Windows.Forms.Label();
            this.txt_dchi = new System.Windows.Forms.TextBox();
            this.gTLabel = new System.Windows.Forms.Label();
            this.cbb_gtinh = new System.Windows.Forms.ComboBox();
            this.hotenLabel = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.sDTLabel = new System.Windows.Forms.Label();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.AllowUserToAddRows = false;
            this.dgvDSKH.AllowUserToDeleteRows = false;
            this.dgvDSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSKH.Location = new System.Drawing.Point(4, 23);
            this.dgvDSKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.ReadOnly = true;
            this.dgvDSKH.RowHeadersWidth = 51;
            this.dgvDSKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKH.Size = new System.Drawing.Size(1079, 247);
            this.dgvDSKH.TabIndex = 0;
            this.dgvDSKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKH_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSKH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 292);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1087, 274);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // cMTLabel
            // 
            this.cMTLabel.AutoSize = true;
            this.cMTLabel.Location = new System.Drawing.Point(49, 37);
            this.cMTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cMTLabel.Name = "cMTLabel";
            this.cMTLabel.Size = new System.Drawing.Size(92, 20);
            this.cMTLabel.TabIndex = 6;
            this.cMTLabel.Text = "Số CMND";
            // 
            // txt_cmt
            // 
            this.txt_cmt.Location = new System.Drawing.Point(191, 33);
            this.txt_cmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmt.MaxLength = 12;
            this.txt_cmt.Name = "txt_cmt";
            this.txt_cmt.Size = new System.Drawing.Size(307, 26);
            this.txt_cmt.TabIndex = 0;
            // 
            // diachiLabel
            // 
            this.diachiLabel.AutoSize = true;
            this.diachiLabel.Location = new System.Drawing.Point(49, 130);
            this.diachiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diachiLabel.Name = "diachiLabel";
            this.diachiLabel.Size = new System.Drawing.Size(68, 20);
            this.diachiLabel.TabIndex = 8;
            this.diachiLabel.Text = "Địa chỉ";
            // 
            // txt_dchi
            // 
            this.txt_dchi.Location = new System.Drawing.Point(191, 127);
            this.txt_dchi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dchi.Name = "txt_dchi";
            this.txt_dchi.Size = new System.Drawing.Size(307, 26);
            this.txt_dchi.TabIndex = 2;
            // 
            // gTLabel
            // 
            this.gTLabel.AutoSize = true;
            this.gTLabel.Location = new System.Drawing.Point(565, 37);
            this.gTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gTLabel.Name = "gTLabel";
            this.gTLabel.Size = new System.Drawing.Size(80, 20);
            this.gTLabel.TabIndex = 10;
            this.gTLabel.Text = "Giới tính";
            // 
            // cbb_gtinh
            // 
            this.cbb_gtinh.FormattingEnabled = true;
            this.cbb_gtinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gtinh.Location = new System.Drawing.Point(717, 33);
            this.cbb_gtinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_gtinh.Name = "cbb_gtinh";
            this.cbb_gtinh.Size = new System.Drawing.Size(307, 28);
            this.cbb_gtinh.TabIndex = 3;
            // 
            // hotenLabel
            // 
            this.hotenLabel.AutoSize = true;
            this.hotenLabel.Location = new System.Drawing.Point(49, 84);
            this.hotenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hotenLabel.Name = "hotenLabel";
            this.hotenLabel.Size = new System.Drawing.Size(65, 20);
            this.hotenLabel.TabIndex = 12;
            this.hotenLabel.Text = "Họ tên";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(191, 80);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(307, 26);
            this.txt_ten.TabIndex = 1;
            // 
            // sDTLabel
            // 
            this.sDTLabel.AutoSize = true;
            this.sDTLabel.Location = new System.Drawing.Point(565, 84);
            this.sDTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sDTLabel.Name = "sDTLabel";
            this.sDTLabel.Size = new System.Drawing.Size(119, 20);
            this.sDTLabel.TabIndex = 14;
            this.sDTLabel.Text = "Số điện thoại";
            // 
            // txt_dt
            // 
            this.txt_dt.Location = new System.Drawing.Point(717, 80);
            this.txt_dt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(307, 26);
            this.txt_dt.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(152, 171);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(112, 33);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(372, 171);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 33);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(812, 171);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(112, 33);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(592, 171);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 33);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 45);
            this.label6.TabIndex = 8;
            this.label6.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cMTLabel);
            this.groupBox1.Controls.Add(this.txt_cmt);
            this.groupBox1.Controls.Add(this.diachiLabel);
            this.groupBox1.Controls.Add(this.txt_dchi);
            this.groupBox1.Controls.Add(this.gTLabel);
            this.groupBox1.Controls.Add(this.cbb_gtinh);
            this.groupBox1.Controls.Add(this.hotenLabel);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.sDTLabel);
            this.groupBox1.Controls.Add(this.txt_dt);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1075, 225);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // frmQuanLyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyKH";
            this.Text = "frmQuanLyKH";
            this.Load += new System.EventHandler(this.frmQuanLyKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDSKH;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label cMTLabel;
		private System.Windows.Forms.TextBox txt_cmt;
		private System.Windows.Forms.Label diachiLabel;
		private System.Windows.Forms.TextBox txt_dchi;
		private System.Windows.Forms.Label gTLabel;
		private System.Windows.Forms.ComboBox cbb_gtinh;
		private System.Windows.Forms.Label hotenLabel;
		private System.Windows.Forms.TextBox txt_ten;
		private System.Windows.Forms.Label sDTLabel;
		private System.Windows.Forms.TextBox txt_dt;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}