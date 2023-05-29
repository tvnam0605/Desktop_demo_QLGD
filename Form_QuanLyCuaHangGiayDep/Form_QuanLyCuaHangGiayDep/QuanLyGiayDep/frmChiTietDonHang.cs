using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using QuanLyGiayDep.DTO;
using QuanLyGiayDep.DAO;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiayDep
{
	public partial class frmChiTietDonHang : Form
	{
		private HoaDon hoaDon;
		BindingSource DSHoaDon = new BindingSource();

		public frmChiTietDonHang()
		{
			InitializeComponent();
           
            LoadDSHH();
		}
		#region Methods
		public frmChiTietDonHang(HoaDon selectedHoaDon)
		{
			InitializeComponent();
			hoaDon = selectedHoaDon;
			LoadDetail();
			DSHoaDon.DataSource = HoaDonDAO.Instance.XemChiTietHD(hoaDon.ID);
		}

		void LoadDSHH()
		{
			DSHoaDon.DataSource = HoaDonDAO.Instance.GetHoaDon();


			dgvCTHoaDon.DataSource = DSHoaDon;

		}
		public void LoadDetail()
		{


			dgvCTHoaDon.DataSource = DSHoaDon;
		}


		#endregion

		#region Event
		private void frmChiTietDonHang_Load(object sender, EventArgs e)
		{

		}


		private void dgvCTHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i;
			i = dgvCTHoaDon.CurrentRow.Index;
			dtpNgayLap.Text = dgvCTHoaDon.Rows[i].Cells[0].Value.ToString();
			txtNguoiLap.Text = dgvCTHoaDon.Rows[i].Cells[1].Value.ToString();
			txtTienHang.Text = dgvCTHoaDon.Rows[i].Cells[3].Value.ToString();
			txtGiamGia.Text = dgvCTHoaDon.Rows[i].Cells[2].Value.ToString();
			txtTrangThai.Text = dgvCTHoaDon.Rows[i].Cells[4].Value.ToString();
			txtTenKH.Text = dgvCTHoaDon.Rows[i].Cells[5].Value.ToString();
			txtSoDT.Text = dgvCTHoaDon.Rows[i].Cells[6].Value.ToString();
			txtDiaChi.Text = dgvCTHoaDon.Rows[i].Cells[7].Value.ToString();

		}

		private void dgvCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = dgvCTHoaDon.CurrentRow.Index;
			DateTime ngayLap;
			if (DateTime.TryParse(dgvCTHoaDon.Rows[i].Cells["NgayLap"].Value.ToString(), out ngayLap))
			{
				dtpNgayLap.Value = ngayLap;
			}

			txtNguoiLap.Text = dgvCTHoaDon.Rows[i].Cells["TenDangNhap"].Value.ToString();

			float tienHang;
			if (float.TryParse(dgvCTHoaDon.Rows[i].Cells["TongTien"].Value.ToString(), out tienHang))
			{
				txtTienHang.Text = tienHang.ToString();
			}

			float giamGia;
			if (float.TryParse(dgvCTHoaDon.Rows[i].Cells["GiamGia"].Value.ToString(), out giamGia))
			{
				txtGiamGia.Text = giamGia.ToString();
			}

			txtTrangThai.Text = dgvCTHoaDon.Rows[i].Cells["TrangThaiDonHang"].Value.ToString();
			txtTenKH.Text = dgvCTHoaDon.Rows[i].Cells["TenKhachHang"].Value.ToString();
			txtSoDT.Text = dgvCTHoaDon.Rows[i].Cells["SoDienThoai"].Value.ToString();
			txtDiaChi.Text = dgvCTHoaDon.Rows[i].Cells["DiaChi"].Value.ToString();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion



	}

}

