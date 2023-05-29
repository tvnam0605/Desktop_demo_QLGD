using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyPhongKS.DTO;

namespace QuanLyPhongKS.DAO
{
	public class QuanLyKhachDAO
	{
		private QuanLyKhachDAO() { }

		private static QuanLyKhachDAO _instance;

		public static QuanLyKhachDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new QuanLyKhachDAO();
				}
				return _instance;
			}
		}
		public List<QuanLyKhach> GetDSKH()
		{
			List<QuanLyKhach> kh = new List<QuanLyKhach>();
			string query = "select * from Khach";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				kh.Add(new QuanLyKhach(row));
			}
			return kh;
		}

		public bool Themkhach(string CMT, string Hoten, string Diachi, string GT, string SDT)
		{
			string query = "EXECUTE sp_ThemKhach @CMT , @Hoten , @Diachi , @GT , @SDT";

			object[] param = new object[] { CMT, Hoten, Diachi, GT, SDT };

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
		public bool SuaKhach(string CMT, string Hoten, string Diachi, string GT, string SDT)
		{
			string query = "EXECUTE sp_CapNhatKhach @CMT , @Hoten , @Diachi , @GT , @SDT";

			object[] param = new object[] { CMT , Hoten, Diachi, GT, SDT };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public List<QuanLyKhach> TimKiemTheoTen(string Hoten)
		{
			List<QuanLyKhach> hh = new List<QuanLyKhach>();
			string query = "USP_SearchHangHoaByName @Hoten";
			object[] param = new object[] { Hoten };
			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				hh.Add(new QuanLyKhach(row));
			}
			return hh;
		}
	}
}
