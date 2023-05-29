using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyGiayDep.DTO;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyGiayDep.DAO
{
	public class DotHangNhapDAO
	{
		private DotHangNhapDAO() { }
		private static DotHangNhapDAO _instance;
		public static DotHangNhapDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new DotHangNhapDAO();
				}
				return _instance;
			}
		}
		public List<DotHangNhap> GetDotHangNhap()
		{
			List<DotHangNhap> dotHang = new List<DotHangNhap>();
			string query = "USP_XemAllHDNhap";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				dotHang.Add(new DotHangNhap(row));
			}
			return dotHang;

		}

	}
	
}
