using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKS.DAO;
using QuanLyPhongKS.DTO;
using System.Windows.Forms;

namespace QuanLyPhongKS
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void btn_dnhap_Click(object sender, EventArgs e)
		{
			string userName = txt_tk.Text;
			string password = txt_mk.Text;

			if (!Login(userName, password))
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
				return;
			}

			TaiKhoan account = TaiKhoanDAO.Instance.GetAccountByUserName(userName);
			frmMain f = new frmMain(account);
			this.Hide();
			f.ShowDialog();
			this.Show();

		}

		bool Login(string userName, string password)
		{
			return TaiKhoanDAO.Instance.Login(userName, password);
		}

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
