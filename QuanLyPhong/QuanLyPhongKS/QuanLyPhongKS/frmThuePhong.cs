using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using QuanLyPhongKS.DAO;
using QuanLyPhongKS.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKS
{
	public partial class frmThuePhong : Form
	{
		int index;
		private TaiKhoan tk;

		BindingSource DSKhachHang = new BindingSource();
		BindingSource DSPhong = new BindingSource();
		BindingSource DSThuePhong = new BindingSource();
		BindingSource DSNhanVien = new BindingSource();


		public frmThuePhong()
		{
			InitializeComponent();
			LoadState();

		}


		public void ThongTinNV()
		{
			//txtManv.Text = tk.aCC;
		}
		private event EventHandler themDatPhong;
		public event EventHandler ThemDatPhong
		{
			add { themDatPhong += value; }
			remove { themDatPhong -= value; }
		}
		private event EventHandler xoaKhach;
		public event EventHandler XoaKhach
		{
			add { xoaKhach += value; }
			remove { xoaKhach -= value; }
		}
		private void dgvKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			index = dgvKhach.CurrentRow.Index;
			txtMaKH.Text = dgvKhach.Rows[index].Cells[0].Value.ToString();
		}
		void LoadState()
		{

			dgvKhach.DataSource = DSKhachHang;
			dgvPhong.DataSource = DSPhong;
			dgvThuephong.DataSource = DSThuePhong;
			cbbMaNv.DataSource = DSNhanVien;

			DateTime tn = DateTime.Now;
			txtNgayden.Text = tn.ToShortDateString();
			LoadDS();


		}
		void LoadDS()
		{
			DSKhachHang.DataSource = QuanLyKhachDAO.Instance.GetDSKH();
			DSPhong.DataSource = QuanLyPhongDAO.Instance.GetPhong();
			DSThuePhong.DataSource = ThuePhongDAO.Instance.GetDSThue();
			DSNhanVien.DataSource = TaiKhoanDAO.Instance.GetDSNV();
			cbbMaNv.ValueMember = "Acc";
			cbbMaNv.DisplayMember = "TenND";

		}

		private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			index = dgvPhong.CurrentRow.Index;
			txtMaphong.Text = dgvPhong.Rows[index].Cells[0].Value.ToString();
			txtGiaphong.Text = dgvPhong.Rows[index].Cells[3].Value.ToString();
		}

		List<QuanLyKhach> TimTheoTen(string TenHangHoa)
		{
			List<QuanLyKhach> hh = QuanLyKhachDAO.Instance.TimKiemTheoTen(TenHangHoa);
			return hh;
		}
		List<QuanLyPhong> TimTheoLoai(string LoaiP)
		{
			List<QuanLyPhong> lp = QuanLyPhongDAO.Instance.TimKiemTheoTen(LoaiP);
			return lp;
		}



		private void txtNhapTen_TextChanged(object sender, EventArgs e)
		{
			DSKhachHang.DataSource = TimTheoTen(txtNhapTen.Text);
		}

		private void btnThemKhach_Click(object sender, EventArgs e)
		{
			frmQuanLyKH t = new frmQuanLyKH();
			t.ShowDialog();
		}

		private void txtNhapPhong_TextChanged(object sender, EventArgs e)
		{
			DSPhong.DataSource = TimTheoLoai(txtNhapPhong.Text);
		}

		private void btnThuePhong_Click(object sender, EventArgs e)
		{
			string CMT = txtMaKH.Text;
			string MaP = txtMaphong.Text;
			DateTime NgayDen = DateTime.Parse(txtNgayden.Text);
			DateTime NgayDi = DateTime.Parse(dtpNgayDi.Text);
			string TenNV = cbbMaNv.Text;

			if (ThuePhongDAO.Instance.ThemPhieuThue(CMT, MaP, NgayDen, NgayDi, TenNV))
			{
				if (QuanLyPhongDAO.Instance.SuaTTPhong(MaP, "Có khách"))
				{
					MessageBox.Show("Thêm thành công!");
					LoadDS();
					themDatPhong?.Invoke(this, EventArgs.Empty);
				}
				else
				{
					MessageBox.Show("Có lỗi khi cập nhật trạng thái phòng!");
				}
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm phiếu thuê!");
			}
			LoadDS();
		}

		private void cbbMaNv_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string CMT = txtMaKH.Text;
			if (ThuePhongDAO.Instance.XoaKhach(CMT))
			{

				MessageBox.Show("Có lỗi khi Xóa ");
			}
			else
			{
				MessageBox.Show("Xóa Khách thành công");

				xoaKhach?.Invoke(this, new EventArgs());
				LoadDS();
			}


		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
