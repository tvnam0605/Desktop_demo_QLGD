using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using QuanLyGiayDep.DAO;
using QuanLyGiayDep.DTO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiayDep
{
	public partial class frmLoaiHangHoa : Form
	{
		BindingSource DSLoaiHang = new BindingSource();
		public frmLoaiHangHoa()
		{
			InitializeComponent();
			LoadState();
		}
		#region Method
		void LoadState()
		{
			dgvDSLoaiHang.DataSource = DSLoaiHang;
			LoadDSLH();
		}

		void LoadDSLH()
		{
			DSLoaiHang.DataSource = LoaiHangHoaDAO.Instance.LayDSLoaiHang();
		}
		private event EventHandler themLoaiHang;
		public event EventHandler ThemLoaiHang
		{
			add { themLoaiHang += value; }
			remove { themLoaiHang -= value; }
		}

		private event EventHandler suaLoaiHang;
		public event EventHandler SuaLoaiHang
		{
			add { suaLoaiHang += value; }
			remove { suaLoaiHang -= value; }
		}

		private event EventHandler xoaLoaiHang;
		public event EventHandler XoaLoaiHang
		{
			add { xoaLoaiHang += value; }
			remove { xoaLoaiHang -= value; }
		}

		#endregion
		#region Event
		private void txtMaLoaiHang_TextChanged(object sender, EventArgs e)
		{

		}

		private void dgvDSLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMaLoaiHang.ReadOnly = true;
			int i;
			i = dgvDSLoaiHang.CurrentRow.Index;
			txtMaLoaiHang.Text = dgvDSLoaiHang.Rows[i].Cells[0].Value.ToString();
			txtTenLoaiHang.Text = dgvDSLoaiHang.Rows[i].Cells[1].Value.ToString();
			txtMoTa.Text = dgvDSLoaiHang.Rows[i].Cells[2].Value.ToString();
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			//int ID = int.Parse(txtMaLoaiHang.Text);

			string TenLoaiHang = txtTenLoaiHang.Text;
			string MoTa = txtMoTa.Text;

			if (LoaiHangHoaDAO.Instance.ThemLoaiHang(TenLoaiHang, MoTa))
			{
				MessageBox.Show("Thêm loại hàng hóa thành công!");
				LoadDSLH();
				themLoaiHang?.Invoke(this, new EventArgs());

			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm loại hàng hóa");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(txtMaLoaiHang.Text);

			string TenLoaiHang = txtTenLoaiHang.Text;
			string MoTa = txtMoTa.Text;

			if (LoaiHangHoaDAO.Instance.SuaLoaiHang(ID, TenLoaiHang, MoTa))
			{
				MessageBox.Show("Sửa loại hàng hóa thành công!");
				LoadDSLH();
				suaLoaiHang?.Invoke(this, new EventArgs());

			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa loại hàng hóa");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(txtMaLoaiHang.Text);



			if (LoaiHangHoaDAO.Instance.XoaLoaiHang(ID))
			{
				MessageBox.Show("Xóa loại hàng hóa thành công!");
				LoadDSLH();
				xoaLoaiHang?.Invoke(this, new EventArgs());

			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa loại hàng hóa");
			}
		}

		private void btnXoaTrong_Click(object sender, EventArgs e)
		{
			txtMaLoaiHang.ReadOnly = false;
			txtMaLoaiHang.Text = "";
			txtTenLoaiHang.Text = "";
			txtMoTa.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion


	}
}
