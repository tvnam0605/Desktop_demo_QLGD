using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiayDep.DAO;
using QuanLyGiayDep.DTO;

namespace QuanLyGiayDep
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
		#region Methods
		bool Login(string userName, string password)
		{
			return AccountDAO.Instance.Login(userName, password);
		}

		#endregion
		#region Event
		private void btnThoatDN_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}

		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			string tenDangNhap = txtTenDangNhap.Text;
			string matKhau = txtMatKhai.Text;

			if (!Login(tenDangNhap, matKhau))
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
				return;
			}

			Account account = AccountDAO.Instance.GetAccountByUserName(tenDangNhap);
			frmMain f = new frmMain(account);
			this.Hide();
			f.ShowDialog();
			this.Show();

		}


		private void frmLogin_Load(object sender, EventArgs e)
		{

		}
		#endregion

	}
}
