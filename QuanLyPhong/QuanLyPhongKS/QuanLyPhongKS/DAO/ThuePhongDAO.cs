using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyPhongKS.DTO;
using System.Threading.Tasks;

namespace QuanLyPhongKS.DAO
{
	public class ThuePhongDAO
	{
		private ThuePhongDAO() { }

		private static ThuePhongDAO _instance;

		public static ThuePhongDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new ThuePhongDAO();
				}
				return _instance;
			}
		}
		public List<ThuePhong> GetDSThue()
		{
			List<ThuePhong> phong = new List<ThuePhong>();
			string query = "select * from ThueP";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				phong.Add(new ThuePhong(row));
			}
			return phong;
		}

		public bool ThemPhieuThue(string CMT, string MaP, DateTime NgayDen, DateTime NgayDi, string TenNV)
		{
			string query = "EXECUTE  USP_ThemThuePhong @CMT , @MaP , @NgayDen , @NgayDi , @TenNV";

			object[] param = new object[] { CMT, MaP, NgayDen, NgayDi, TenNV };

			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool XoaKhach(string CMT)
		{
			string query = "EXEC Sp_XoaKhach @CMT ";
			object[] param = new object[] { CMT };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

	}
}
