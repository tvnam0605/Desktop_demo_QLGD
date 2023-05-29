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
	public partial class frmMain : Form
	{
		BindingSource DSKhachHang = new BindingSource();
		private TaiKhoan account;
		public frmMain()
		{
			InitializeComponent();
			
		}
		public frmMain(TaiKhoan acc)
		{
			account = acc;
			InitializeComponent();
			LoadPhong();
			LoadState();
		}
		public void TaiKhoanHienTai()
		{
			tsmTaiKhoan.Text += $" ({account.tenND})";
		}
		void LoadState()
		{
			TaiKhoanHienTai();
			LoadDSKH();
		}
		void LoadDSKH()
		{
			DSKhachHang.DataSource = QuanLyKhachDAO.Instance.GetDSKH();

		}
		void LoadPhong()
		{
			ftPhong.Controls.Clear();
			List<QuanLyPhong> tableList = QuanLyPhongDAO.Instance.GetPhong();

			foreach (QuanLyPhong table in tableList)
			{
				Button btn = new Button()
				{
					Width = QuanLyPhongDAO.TableWidth,
					Height = QuanLyPhongDAO.TableHeight
				};
				btn.Text = table.TenP + Environment.NewLine + table.TinhTrang;
				btn.Tag = table;

				switch (table.TinhTrang)
				{
					case "Trống":
						btn.BackColor = Color.Aqua;
						break;

					default:
						btn.BackColor = Color.LightPink;
						break;
				}

				//btn.Click += Btn_Click;
				ftPhong.Controls.Add(btn);
				//LoadPhong();
			}
		}

		private void btnXemDSKH_Click(object sender, EventArgs e)
		{
			frmQuanLyKH frm = new frmQuanLyKH();
			frm.ShowDialog();
		}

		private void tsmThuePhong_Click(object sender, EventArgs e)
		{
			frmThuePhong frm = new frmThuePhong();
			this.Hide();
			frm.ShowDialog();
			this.Show();
			LoadPhong();
		}

		private void tsmQLKH_Click(object sender, EventArgs e)
		{
			var frm = new frmQuanLyKH();
			frm.ShowDialog();
		}

		private void tsmQLPhong_Click(object sender, EventArgs e)
		{
			var frm = new frmQuanLyPhong();
			frm.ShowDialog();
		}

		private void tsmTaiKhoan_Click(object sender, EventArgs e)
		{

		}

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmDangXuat_Click(object sender, EventArgs e)
        {
          
            
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
                frmDangNhap frm = new frmDangNhap();

                this.Hide();
                frm.ShowDialog();
                this.Show();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tsmTraPhong_Click(object sender, EventArgs e)
        {
			frmTraPhong frm = new frmTraPhong();
			this.Hide();
			frm.ShowDialog();
			this.Show();
        }

		private void ftPhong_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
