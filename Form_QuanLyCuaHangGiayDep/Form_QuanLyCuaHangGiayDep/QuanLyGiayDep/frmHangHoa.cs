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
using System.Data.SqlClient;

namespace QuanLyGiayDep
{

    public partial class frmHangHoa : Form
    {
        BindingSource DSHangHoa = new BindingSource();
        BindingSource DSLoaiHang = new BindingSource();

        public frmHangHoa()
        {
            InitializeComponent();
            LoadState();
        }
		#region Methods
		void LoadState()
		{
			dgvDSMH.DataSource = DSHangHoa;
			cbbLoaiHang.DataSource = DSLoaiHang;
		}
		void LoadDSHH()
		{
			DSHangHoa.DataSource = HangHoaDAO.Instance.GetHangHoa();
		}
		void LoadDSLH()
		{
			DSLoaiHang.DataSource = LoaiHangHoaDAO.Instance.LayDSLoaiHang();

			cbbLoaiHang.DisplayMember = "TenLoaiHang";
			cbbLoaiHang.ValueMember = "ID";
			
		}
		private event EventHandler themHangHoa;
		public event EventHandler ThemHangHoa
		{
			add { themHangHoa += value; }
			remove { themHangHoa -= value; }
		}

		private event EventHandler suaHangHoa;
		public event EventHandler SuaHangHoa
		{
			add { suaHangHoa += value; }
			remove { suaHangHoa -= value; }
		}

		private event EventHandler xoaHangHoa;
		public event EventHandler XoaHangHoa
		{
			add { xoaHangHoa += value; }
			remove { xoaHangHoa -= value; }
		}

		#endregion
		#region Event
		

		private void frmHangHoa_Load(object sender, EventArgs e)
		{
			LoadDSHH();
			LoadDSLH();

		}
		List<HangHoa> TimTheoTen(string TenHangHoa)
		{
			List<HangHoa> hh = HangHoaDAO.Instance.TimKiemTheoTen(TenHangHoa);
			return hh;
		}

		private void dgvDSMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtTTMa.ReadOnly = true;
			int i;
			i = dgvDSMH.CurrentRow.Index;
			txtTTMa.Text = dgvDSMH.Rows[i].Cells[0].Value.ToString();
			txtTTTen.Text = dgvDSMH.Rows[i].Cells[1].Value.ToString();
			txtTTSize.Text = dgvDSMH.Rows[i].Cells[3].Value.ToString();
			txtGia.Text = dgvDSMH.Rows[i].Cells[2].Value.ToString();
			txtLoaiHH.Text = dgvDSMH.Rows[i].Cells[4].Value.ToString();
			//txtLoaiHH.Text = dgvDSMH.Rows[i].Cells[4].Value== "1" ? "Giày" : "Dép";
			

			txtXuatXu.Text = dgvDSMH.Rows[i].Cells[5].Value.ToString();
			txtNCC.Text = dgvDSMH.Rows[i].Cells[6].Value.ToString();


		}
		

		private void btnThem_Click(object sender, EventArgs e)
		{

			string TenHH = txtTTTen.Text;
			float DonGia = float.Parse(txtGia.Text);
			float Size = float.Parse(txtTTSize.Text);
			int LoaiHH = int.Parse(txtLoaiHH.Text);
			string XuatXu = txtXuatXu.Text;
			int NhaCC = int.Parse(txtNCC.Text);
			if (HangHoaDAO.Instance.ThemHangHoa(TenHH, DonGia, Size, LoaiHH, XuatXu, NhaCC))
			{
				MessageBox.Show("Thêm hàng hóa thành công!");
				LoadDSHH();
				themHangHoa?.Invoke(this, new EventArgs());


			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm hàng hóa");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			int MaSanPham = int.Parse(txtTTMa.Text);
			string TenHH = txtTTTen.Text;
			float DonGia = float.Parse(txtGia.Text);
			float Size = float.Parse(txtTTSize.Text);
			int LoaiHH = int.Parse(txtLoaiHH.Text);
            string XuatXu = txtXuatXu.Text;
			int NhaCC = int.Parse(txtNCC.Text);
			if (HangHoaDAO.Instance.SuaHangHoa(MaSanPham, TenHH, DonGia, Size, LoaiHH, XuatXu, NhaCC))
			{
				MessageBox.Show("Cập nhật hàng hóa thành công!");
				LoadDSHH();
				suaHangHoa?.Invoke(this, new EventArgs());

			}
			else
			{
				MessageBox.Show("Có lỗi khi cập nhật hàng hóa");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int MaSanPham = int.Parse(txtTTMa.Text);
			if (HangHoaDAO.Instance.XoaHangHoa(MaSanPham))
			{
				MessageBox.Show("Xóa hàng hóa thành công");
				LoadDSHH();
				xoaHangHoa?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi hàng hóa");
			}
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			txtTTMa.Text = "";
			txtTTTen.Text = "";
			txtTTSize.Text = "";
			txtXuatXu.Text = "";
			txtGia.Text = "";
			txtNCC.Text = "";
			txtLoaiHH.Text = "";

		}
		private void btnTimTheoDK_Click(object sender, EventArgs e)
		{
			DSHangHoa.DataSource = TimTheoTen(txtTenOrMa.Text);
		}

		private void cbbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbbLoaiHang.DisplayMember = "TenLoaiHang";
			cbbLoaiHang.ValueMember = "ID";
		}
		private void txtLoaiHH_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtTenOrMa_TextChanged(object sender, EventArgs e)
		{
			DSHangHoa.DataSource = TimTheoTen(txtTenOrMa.Text);
		}
		private void btnXoaBoLoc_Click(object sender, EventArgs e)
		{
			txtTenOrMa.Text = "";
		}
		#endregion


	}
}
