using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyPhongKS.DTO;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyPhongKS.DAO
{
	public class TaiKhoanDAO
	{
		private TaiKhoanDAO() { }

		private static TaiKhoanDAO _instance;

		public static TaiKhoanDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new TaiKhoanDAO();
				}
				return _instance;
			}
		}
		public bool Login(string userName, string password)
		{
			string query = "EXEC USP_Login @userName , @password";
			object[] param = new object[] { userName, password };
			DataTable result = DataProvider.Instance.ExecuteQuery(query, param);
			return result.Rows.Count > 0;
		}
		public TaiKhoan GetAccountByUserName(string userName)
		{
			string query = "EXEC USP_GetAccountByUserName @userName";
			object[] param = new object[] { userName };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				return new TaiKhoan(row);
			}

			return null;
		}
		public List<TaiKhoan> GetDSNV()
		{
			List<TaiKhoan> nv = new List<TaiKhoan>();
			string query = "select * from Taikhoan";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				nv.Add(new TaiKhoan(row));
			}
			return nv;
		}

	}
}
