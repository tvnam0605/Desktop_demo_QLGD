using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using QuanLyPhongKS.DAO;
using QuanLyPhongKS.DTO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKS
{
	public partial class frmQuanLyPhong : Form
	{
		BindingSource DSPhong = new BindingSource();
		public frmQuanLyPhong()
		{
			InitializeComponent();
			LoadState();
		}
		void LoadState()
		{

			dgvPhong.DataSource = DSPhong;
			LoadDSP();

		}
		void LoadDSP()
		{
			DSPhong.DataSource = QuanLyPhongDAO.Instance.GetPhong();
		}
		private event EventHandler themPhong;
		public event EventHandler ThemPhong
		{
			add { themPhong += value; }
			remove { themPhong -= value; }
		}

		private event EventHandler suaPhong;
		public event EventHandler SuaPhong
		{
			add { suaPhong += value; }
			remove { suaPhong -= value; }
		}

		private event EventHandler xoaPhong;
		public event EventHandler XoaPhong
		{
			add { xoaPhong += value; }
			remove { xoaPhong -= value; }
		}




		private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_map.ReadOnly = true;
			int i;
			i = dgvPhong.CurrentRow.Index;
			txt_map.Text = dgvPhong.Rows[i].Cells[0].Value.ToString();
			txt_ten.Text = dgvPhong.Rows[i].Cells[1].Value.ToString();
			cbb_loaip.Text = dgvPhong.Rows[i].Cells[2].Value.ToString();
			txt_gia.Text = dgvPhong.Rows[i].Cells[3].Value.ToString();
			cbb_tinhtrang.Text = dgvPhong.Rows[i].Cells[4].Value.ToString();
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			string MaP = txt_map.Text;
			string TenP = txt_ten.Text;
			string LoaiP = cbb_loaip.Text;
			int GiaP = int.Parse(txt_gia.Text);
			string Tinhtrang = cbb_tinhtrang.Text;

			if (QuanLyPhongDAO.Instance.ThemPhong(MaP, TenP, LoaiP, GiaP, Tinhtrang))
			{
				MessageBox.Show("Thêm  thành công!");
				LoadDSP();
				themPhong?.Invoke(this, new EventArgs());


			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm ");
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			string MaPhong = txt_map.Text;
			if (QuanLyPhongDAO.Instance.XoaPhong(MaPhong))
			{
				MessageBox.Show("Xóa Phòng thành công");
				LoadDSP();
				xoaPhong?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi Xóa ");
			}
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			string MaP = txt_map.Text;
			string TenP = txt_ten.Text;
			string LoaiP = cbb_loaip.Text;
			int GiaP = int.Parse(txt_gia.Text);
			string Tinhtrang = cbb_tinhtrang.Text;

			if (QuanLyPhongDAO.Instance.ThemPhong(MaP, TenP, LoaiP, GiaP, Tinhtrang))
			{
				MessageBox.Show("Sửa thành công!");
				LoadDSP();
				suaPhong?.Invoke(this, new EventArgs());


			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa ");
			}
		}

		private void frmQuanLyPhong_Load(object sender, EventArgs e)
		{

		}
	}
}
