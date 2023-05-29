using System;
using QuanLyGiayDep.DAO;
using QuanLyGiayDep.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiayDep
{
    public partial class frmDoanhThu : Form
    {
        BindingSource DSHoaDon = new BindingSource();
		BindingSource DSNhanVien = new BindingSource();
		public frmDoanhThu()
        {
            InitializeComponent();
            LoadState();
        }
		public DataGridView HoaDonGridView
		{
			get { return dgvDSHoaDon; }
		}
		#region Methods
		void LoadState()
		{
			dgvDSHoaDon.DataSource = DSHoaDon;
			cbbLapBoi.DataSource = DSNhanVien;

		}
		void LoadDSHD()
		{
			DSHoaDon.DataSource = HoaDonDAO.Instance.GetHoaDon();
			DSNhanVien.DataSource = AccountDAO.Instance.LayDSTaiKhoan();
			cbbLapBoi.ValueMember = "TenDangNhap";
			cbbLapBoi.DisplayMember = "TenDangNhap";
			//cbbLapBoi.Text = "";

        }
        public void TinhTongTienHang()
		{
			decimal totalAmount = 0;
			foreach (DataGridViewRow row in dgvDSHoaDon.Rows)
			{
				if (row.Cells["TongTien"].Value != null && row.Cells["TongTien"].Value != DBNull.Value)
				{
					decimal rowAmount = Convert.ToDecimal(row.Cells["TongTien"].Value);
					totalAmount += rowAmount;
				}
			}
			// Cập nhật kết quả vào label
			lblTongDoanhThu.Text = totalAmount.ToString();
		}
		private string DocSoTienRaChu(decimal soTien)
		{
			string[] chuSo = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
			string[] donVi = new string[] { "", "nghìn", "triệu", "tỷ" };

			string chuoiChu = "";

			if (soTien == 0)
			{
				chuoiChu = chuSo[0];
			}
			else
			{
				int donViIndex = 0;

				while (soTien > 0)
				{
					int group = (int)(soTien % 1000);
					int hangDonVi = group / 100;
					int hangChuc = (group % 100) / 10;
					int hangDonViNho = group % 10;

					string chuoiGroup = "";

					if (hangDonVi > 0)
					{
						chuoiGroup += chuSo[hangDonVi] + " trăm ";
					}

					if (hangChuc == 0 && hangDonViNho > 0)
					{
						chuoiGroup += "" + chuSo[hangDonViNho];
					}
					else if (hangChuc == 1 && hangDonViNho > 0)
					{
						chuoiGroup += "mười " + chuSo[hangDonViNho];
					}
					else if (hangChuc > 1 && hangDonViNho == 1)
					{
						chuoiGroup += chuSo[hangChuc] + " mươi mốt";
					}
					else if (hangChuc > 1 && hangDonViNho > 1)
					{
						chuoiGroup += chuSo[hangChuc] + " mươi " + chuSo[hangDonViNho];
					}
					else if (hangChuc == 0 && hangDonViNho == 0 && hangDonVi == 0 && donViIndex == 0)
					{
						chuoiGroup += "";
					}
					else if (hangChuc == 0 && hangDonViNho == 0)
					{
						chuoiGroup += chuSo[hangDonVi];
					}

					if (group > 0)
					{
						chuoiGroup += " " + donVi[donViIndex];
					}

					chuoiChu = chuoiGroup + " " + chuoiChu;

					soTien = (int)(soTien / 1000);
					donViIndex++;
				}
			}

			return chuoiChu.Trim();
		}
		#endregion
		#region Event
		private void frmHoaDon_Load(object sender, EventArgs e)
		{
			LoadDSHD();
			TinhTongTienHang();
			decimal soTien = decimal.Parse(lblTongDoanhThu.Text);
			string chuoiChu = DocSoTienRaChu(soTien);
			lblTongDoanhThuChu.Text = chuoiChu;

		}
		

		private void dgvDSHoaDon_DoubleClick(object sender, EventArgs e)
		{
			if (dgvDSHoaDon.SelectedRows.Count > 0)
			{
				if (!dgvDSHoaDon.SelectedRows[0].Cells[0].IsInEditMode)
				{
					string billID = dgvDSHoaDon.SelectedRows[0].Cells[0].Value.ToString();
					if (int.TryParse(billID, out int parsedBillID))
					{
						frmChiTietDonHang billDetails = new frmChiTietDonHang();
						billDetails.LoadDetail();
						billDetails.Show();
					}
					else
					{
						MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
        List<HoaDon> TimTheoTen(string TenKhachHang)
        {
            List<HoaDon> hh = HoaDonDAO.Instance.TimKiemTheoTen(TenKhachHang);
            return hh;
        }
        List<HoaDon> TimTheoSDT(string SoDienThoai)
        {
            List<HoaDon> hh = HoaDonDAO.Instance.TimKiemTheoSDT(SoDienThoai);
            return hh;
        }
        List<HoaDon> TimTheoNV(string TenDangNhap)
        {
            List<HoaDon> hh = HoaDonDAO.Instance.TimKiemTheoNV(TenDangNhap);
            return hh;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            DSHoaDon.DataSource = TimTheoTen(txtTenKH.Text);
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
			DSHoaDon.DataSource = TimTheoSDT(txtSDT.Text);
        }

        private void cbbLapBoi_SelectedIndexChanged(object sender, EventArgs e)
        {
			
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //cbbLapBoi.Items.Clear();	
            DSHoaDon.DataSource = TimTheoNV(cbbLapBoi.Text);
        }

        private void btnXoaBoLoc_Click(object sender, EventArgs e)
        {
			txtTenKH.Text = "a";
			txtTenKH.Text = "";
			txtSDT.Text = "";
        }
        #endregion
    }

}
