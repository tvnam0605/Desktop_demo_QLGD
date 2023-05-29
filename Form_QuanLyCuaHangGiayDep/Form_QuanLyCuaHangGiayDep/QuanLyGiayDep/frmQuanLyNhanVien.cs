using System;
using QuanLyGiayDep.DAO;
using QuanLyGiayDep.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiayDep
{
    public partial class frmQuanLyNhanVien : Form
    {
        BindingSource DSNhanVien = new BindingSource();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            LoadState();
        }
		#region Methods
		void LoadState()
		{
			dgvDSNV.DataSource = DSNhanVien;
		}
		void LoadDSNV()
		{
			DSNhanVien.DataSource = AccountDAO.Instance.LayDSTaiKhoan();
		}
		private event EventHandler themTaiKhoan;
		public event EventHandler ThemTaiKhoan
		{
			add { themTaiKhoan += value; }
			remove { themTaiKhoan -= value; }
		}

		private event EventHandler suaTaiKhoan;
		public event EventHandler SuaTaiKhoan
		{
			add { suaTaiKhoan += value; }
			remove { suaTaiKhoan -= value; }
		}

		private event EventHandler xoaTaiKhoan;
		public event EventHandler XoaTaiKhoan
		{
			add { xoaTaiKhoan += value; }
			remove { xoaTaiKhoan -= value; }
		}

		#endregion
		#region Event
		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
		{
			LoadDSNV();
		}

		private void frmQuanLyNhanVien_Click(object sender, EventArgs e)
		{

		}

		private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtTenDangNhap.ReadOnly = true;
			dtpNgayTaoTK.Enabled = false;

			int i;
			i = dgvDSNV.CurrentRow.Index;
			txtTenDangNhap.Text = dgvDSNV.Rows[i].Cells[0].Value.ToString();
			txtMatKhau.Text = dgvDSNV.Rows[i].Cells[1].Value.ToString();
			txtHoVaTen.Text = dgvDSNV.Rows[i].Cells[2].Value.ToString();

			txtDiaChiEmail.Text = dgvDSNV.Rows[i].Cells[3].Value.ToString();
			txtSoDT.Text = dgvDSNV.Rows[i].Cells[4].Value.ToString();
			DateTime ngayTao;
			if (DateTime.TryParse(dgvDSNV.Rows[i].Cells[5].Value.ToString(), out ngayTao))
			{
				dtpNgayTaoTK.Value = ngayTao;
			}
			else
			{
				// Xử lý lỗi chuyển đổi giá trị chuỗi sang kiểu DateTime
			}


		}

		private void btnXoaTrong_Click(object sender, EventArgs e)
		{
			txtDiaChiEmail.Text = "";
			txtHoVaTen.Text = "";
			txtMatKhau.Text = "";
			txtSoDT.Text = "";
			txtTenDangNhap.Text = "";
			dtpNgayTaoTK.Text = "";
		}

		private void btnThemTK_Click(object sender, EventArgs e)
		{
			string TenDangNhap = txtTenDangNhap.Text;
			string MatKhau = txtMatKhau.Text;
			string HoTen = txtHoVaTen.Text;
			string Email = txtDiaChiEmail.Text;
			string DienThoai = txtSoDT.Text;
			DateTime NgayTaoTaiKhoan = dtpNgayTaoTK.Value;

			if (AccountDAO.Instance.ThemTaiKhoan(TenDangNhap, MatKhau, HoTen, Email, DienThoai, NgayTaoTaiKhoan))
			{
				MessageBox.Show("Thêm tài khoản thành công!");
				LoadDSNV();
				themTaiKhoan?.Invoke(this, new EventArgs());


			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm tài khoản");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string TenDangNhap = txtTenDangNhap.Text;
			string MatKhau = txtMatKhau.Text;
			string HoTen = txtHoVaTen.Text;
			string Email = txtDiaChiEmail.Text;
			string DienThoai = txtSoDT.Text;
			DateTime NgayTaoTaiKhoan = dtpNgayTaoTK.Value;
		
			if (AccountDAO.Instance.SuaTaiKhoan(TenDangNhap, MatKhau, HoTen, Email, DienThoai,NgayTaoTaiKhoan))
			{
				MessageBox.Show("Sửa tài khoản thành công!");
				LoadDSNV();
				suaTaiKhoan?.Invoke(this, new EventArgs());


			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa tài khoản");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string TenDangNhap = txtTenDangNhap.Text;
			if (AccountDAO.Instance.XoaTaiKhoan(TenDangNhap))
			{
				MessageBox.Show("Xóa tài khoản thành công");
				LoadDSNV();
				xoaTaiKhoan?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa tài khoản ");
			}
		}
	}
	#endregion

}
