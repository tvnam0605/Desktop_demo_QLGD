using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiayDep.DTO;

namespace QuanLyGiayDep.DAO
{
    public class AccountDAO
    {
		private AccountDAO() { }

		private static AccountDAO _instance;

		public static AccountDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new AccountDAO();
				}
				return _instance;
			}
		}

        public bool Login(string tenDangNhap, string matKhau)
        {
            string query = "EXEC USP_Login @userName , @password";
            object[] param = new object[] { tenDangNhap, matKhau };
            DataTable result = DataProvider.Instance.ExecuteQuery(query, param);
            return result.Rows.Count > 0;
        }


        public bool SuaTaiKhoan (string TenDangNhap, string MatKhau, string HoTen, string Email, string DienThoai, DateTime NgayTaoTaiKhoan)
        {
            string query = "EXEC USP_SuaTaiKhoan @TenDangNhap , @MatKhau , @HoTen , @Email , @DienThoai , @NgayTaoTaiKhoan ";
            object[] param = new object[] { TenDangNhap, MatKhau, HoTen, Email, DienThoai, NgayTaoTaiKhoan };
            int result = DataProvider.Instance.ExecuteNonQuery(query, param);
            return result > 0;
        }
		public bool ThemTaiKhoan(string TenDangNhap, string MatKhau, string HoTen, string Email, string DienThoai, DateTime NgayTaoTaiKhoan)
		{
			string query = "EXEC USP_ThemTaiKhoan @TenDangNhap , @MatKhau , @HoTen , @Email , @DienThoai , @NgayTaoTaiKhoan ";
			object[] param = new object[] { TenDangNhap, MatKhau, HoTen, Email, DienThoai, NgayTaoTaiKhoan };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool XoaTaiKhoan(string TenDangNhap)
		{
			string query = "EXEC USP_XoaTaiKhoan @TenDangNhap";
			object[] param = new object[] { TenDangNhap };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public DataTable LayDSTaiKhoan()
        {
            string query = "EXEC USP_XemAllTaiKhoan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public Account GetAccountByUserName(string userName)
        {
            string query = "EXEC dbo.GetAccountNameByUsername @Username";
            object[] param = new object[] { userName };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
            foreach (DataRow row in table.Rows)
            {
                return new Account(row);
            }

            return null;
        }
		//public bool SuaTaiKhoan(string tenDangNhap, string matKhau, string hoTen, string eMail, string dienThoai, DateTime ngayTaoTaiKhoan)
		//{
		//	string query = "EXEC USP_SuaHangHoa @TenDangNhap , @MatKhau , @HoTen , @Email , @DienThoai , @NgayTaoTaiKhoan";
		//	object[] param = new object[] { tenDangNhap,matKhau,hoTen,eMail, dienThoai, ngayTaoTaiKhoan};
		//	int result = DataProvider.Instance.ExecuteNonQuery(query, param);
		//	return result > 0;
		//}
		
	}
}
