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
	public partial class frmQuanLyKH : Form
	{
		BindingSource DSKhachHang = new BindingSource();
		
		public frmQuanLyKH()
		{
			InitializeComponent();
			LoadState();
		}
		void LoadState()
		{

			dgvDSKH.DataSource = DSKhachHang;
			LoadDSKH();

		}
		void LoadDSKH()
		{	
			DSKhachHang.DataSource = QuanLyKhachDAO.Instance.GetDSKH();

		}
		private event EventHandler themKhach;
		public event EventHandler ThemKhach
		{
			add { themKhach += value; }
			remove { themKhach -= value; }
		}
		private event EventHandler suaKhach;
		public event EventHandler SuaKhach
		{
			add { suaKhach += value; }
			remove { suaKhach -= value; }
		}

		private event EventHandler xoaKhach;
		public event EventHandler XoaKhach
		{
			add { xoaKhach += value; }
			remove { xoaKhach -= value; }
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			string CMT = txt_cmt.Text;
			string Hoten = txt_ten.Text;
			string Diachi = txt_dchi.Text;
			string GT = cbb_gtinh.Text;
			string SDT = txt_dt.Text;
			if (QuanLyKhachDAO.Instance.Themkhach(CMT, Hoten, Diachi, GT, SDT))
			{
				MessageBox.Show("Thêm  thành công!");
				LoadDSKH();
				themKhach?.Invoke(this, new EventArgs());


			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm ");
			}
		}

		private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			txt_cmt.ReadOnly = true;
			int i;
			i = dgvDSKH.CurrentRow.Index;
			txt_cmt.Text = dgvDSKH.Rows[i].Cells[0].Value.ToString();
			txt_ten.Text = dgvDSKH.Rows[i].Cells[1].Value.ToString();
			txt_dchi.Text = dgvDSKH.Rows[i].Cells[2].Value.ToString();
			cbb_gtinh.Text = dgvDSKH.Rows[i].Cells[3].Value.ToString();
			txt_dt.Text = dgvDSKH.Rows[i].Cells[4].Value.ToString();
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			string CMT = txt_cmt.Text;
			string Hoten = txt_ten.Text;
			string Diachi = txt_dchi.Text;
			string GT = cbb_gtinh.Text;
			string SDT = txt_dt.Text;

			if (QuanLyKhachDAO.Instance.SuaKhach(CMT, Hoten, Diachi, GT, SDT))
			{
				MessageBox.Show("Sửa thành công!");
				LoadDSKH();
				suaKhach?.Invoke(this, new EventArgs());


			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa ");
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			string CMT = txt_cmt.Text;
			if (QuanLyKhachDAO.Instance.XoaKhach(CMT))
			{

                MessageBox.Show("Có lỗi khi Xóa ");
            }
			else
			{
                MessageBox.Show("Xóa Khách thành công");
               
                xoaKhach?.Invoke(this, new EventArgs());
                LoadDSKH();
            }
		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void frmQuanLyKH_Load(object sender, EventArgs e)
        {

        }
    }
}
