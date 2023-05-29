namespace QuanLyPhongKS
{
	partial class frmQuanLyPhong
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
			System.Windows.Forms.Label tinhtrangLabel;
			System.Windows.Forms.Label giaPLabel1;
			System.Windows.Forms.Label loaiPLabel1;
			System.Windows.Forms.Label maPLabel1;
			System.Windows.Forms.Label tenPLabel1;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbb_tinhtrang = new System.Windows.Forms.ComboBox();
			this.btn_thoat = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.txt_gia = new System.Windows.Forms.TextBox();
			this.cbb_loaip = new System.Windows.Forms.ComboBox();
			this.txt_map = new System.Windows.Forms.TextBox();
			this.txt_ten = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvPhong = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			tinhtrangLabel = new System.Windows.Forms.Label();
			giaPLabel1 = new System.Windows.Forms.Label();
			loaiPLabel1 = new System.Windows.Forms.Label();
			maPLabel1 = new System.Windows.Forms.Label();
			tenPLabel1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(tinhtrangLabel);
			this.groupBox1.Controls.Add(this.cbb_tinhtrang);
			this.groupBox1.Controls.Add(this.btn_thoat);
			this.groupBox1.Controls.Add(this.btn_xoa);
			this.groupBox1.Controls.Add(this.btn_sua);
			this.groupBox1.Controls.Add(this.btn_them);
			this.groupBox1.Controls.Add(giaPLabel1);
			this.groupBox1.Controls.Add(this.txt_gia);
			this.groupBox1.Controls.Add(loaiPLabel1);
			this.groupBox1.Controls.Add(this.cbb_loaip);
			this.groupBox1.Controls.Add(maPLabel1);
			this.groupBox1.Controls.Add(this.txt_map);
			this.groupBox1.Controls.Add(tenPLabel1);
			this.groupBox1.Controls.Add(this.txt_ten);
			this.groupBox1.Location = new System.Drawing.Point(43, 62);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(858, 238);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin phòng";
			// 
			// tinhtrangLabel
			// 
			tinhtrangLabel.AutoSize = true;
			tinhtrangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			tinhtrangLabel.Location = new System.Drawing.Point(476, 86);
			tinhtrangLabel.Name = "tinhtrangLabel";
			tinhtrangLabel.Size = new System.Drawing.Size(67, 16);
			tinhtrangLabel.TabIndex = 12;
			tinhtrangLabel.Text = "Tình trạng";
			// 
			// cbb_tinhtrang
			// 
			this.cbb_tinhtrang.FormattingEnabled = true;
			this.cbb_tinhtrang.Items.AddRange(new object[] {
            "Trống",
            "Có khách"});
			this.cbb_tinhtrang.Location = new System.Drawing.Point(578, 81);
			this.cbb_tinhtrang.Name = "cbb_tinhtrang";
			this.cbb_tinhtrang.Size = new System.Drawing.Size(236, 21);
			this.cbb_tinhtrang.TabIndex = 13;
			// 
			// btn_thoat
			// 
			this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_thoat.Location = new System.Drawing.Point(668, 184);
			this.btn_thoat.Name = "btn_thoat";
			this.btn_thoat.Size = new System.Drawing.Size(114, 33);
			this.btn_thoat.TabIndex = 8;
			this.btn_thoat.Text = "Thoát";
			this.btn_thoat.UseVisualStyleBackColor = true;
			// 
			// btn_xoa
			// 
			this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoa.Location = new System.Drawing.Point(471, 184);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(114, 33);
			this.btn_xoa.TabIndex = 8;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sua.Location = new System.Drawing.Point(274, 184);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(114, 33);
			this.btn_sua.TabIndex = 8;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_them
			// 
			this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_them.Location = new System.Drawing.Point(77, 184);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(114, 33);
			this.btn_them.TabIndex = 8;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// giaPLabel1
			// 
			giaPLabel1.AutoSize = true;
			giaPLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			giaPLabel1.Location = new System.Drawing.Point(473, 31);
			giaPLabel1.Name = "giaPLabel1";
			giaPLabel1.Size = new System.Drawing.Size(70, 16);
			giaPLabel1.TabIndex = 0;
			giaPLabel1.Text = "Giá phòng";
			// 
			// txt_gia
			// 
			this.txt_gia.Location = new System.Drawing.Point(578, 27);
			this.txt_gia.Name = "txt_gia";
			this.txt_gia.Size = new System.Drawing.Size(236, 20);
			this.txt_gia.TabIndex = 1;
			// 
			// loaiPLabel1
			// 
			loaiPLabel1.AutoSize = true;
			loaiPLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			loaiPLabel1.Location = new System.Drawing.Point(52, 136);
			loaiPLabel1.Name = "loaiPLabel1";
			loaiPLabel1.Size = new System.Drawing.Size(75, 16);
			loaiPLabel1.TabIndex = 2;
			loaiPLabel1.Text = "Loại phòng";
			// 
			// cbb_loaip
			// 
			this.cbb_loaip.FormattingEnabled = true;
			this.cbb_loaip.Items.AddRange(new object[] {
            "Đơn thường",
            "Đôi thường",
            "Ba thường",
            "VIP đơn",
            "VIP đôi",
            "VIP ba"});
			this.cbb_loaip.Location = new System.Drawing.Point(175, 131);
			this.cbb_loaip.Name = "cbb_loaip";
			this.cbb_loaip.Size = new System.Drawing.Size(236, 21);
			this.cbb_loaip.TabIndex = 3;
			// 
			// maPLabel1
			// 
			maPLabel1.AutoSize = true;
			maPLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			maPLabel1.Location = new System.Drawing.Point(52, 31);
			maPLabel1.Name = "maPLabel1";
			maPLabel1.Size = new System.Drawing.Size(68, 16);
			maPLabel1.TabIndex = 4;
			maPLabel1.Text = "Mã phòng";
			// 
			// txt_map
			// 
			this.txt_map.Location = new System.Drawing.Point(175, 27);
			this.txt_map.Name = "txt_map";
			this.txt_map.Size = new System.Drawing.Size(236, 20);
			this.txt_map.TabIndex = 5;
			// 
			// tenPLabel1
			// 
			tenPLabel1.AutoSize = true;
			tenPLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			tenPLabel1.Location = new System.Drawing.Point(52, 86);
			tenPLabel1.Name = "tenPLabel1";
			tenPLabel1.Size = new System.Drawing.Size(73, 16);
			tenPLabel1.TabIndex = 6;
			tenPLabel1.Text = "Tên phòng";
			// 
			// txt_ten
			// 
			this.txt_ten.Location = new System.Drawing.Point(175, 78);
			this.txt_ten.Name = "txt_ten";
			this.txt_ten.Size = new System.Drawing.Size(236, 20);
			this.txt_ten.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(229, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(383, 36);
			this.label1.TabIndex = 16;
			this.label1.Text = "QUẢN LÝ PHÒNG THUÊ";
			// 
			// dgvPhong
			// 
			this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhong.Location = new System.Drawing.Point(123, 28);
			this.dgvPhong.Name = "dgvPhong";
			this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPhong.Size = new System.Drawing.Size(635, 252);
			this.dgvPhong.TabIndex = 0;
			this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvPhong);
			this.groupBox2.Location = new System.Drawing.Point(43, 317);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(858, 337);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách phòng thuê";
			// 
			// frmQuanLyPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 611);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmQuanLyPhong";
			this.Text = "frmQuanLyPhong";
			this.Load += new System.EventHandler(this.frmQuanLyPhong_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbb_tinhtrang;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.TextBox txt_gia;
		private System.Windows.Forms.ComboBox cbb_loaip;
		private System.Windows.Forms.TextBox txt_map;
		private System.Windows.Forms.TextBox txt_ten;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvPhong;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}