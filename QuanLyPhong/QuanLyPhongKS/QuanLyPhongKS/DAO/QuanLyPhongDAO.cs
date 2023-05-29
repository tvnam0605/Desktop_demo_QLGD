using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyPhongKS.DTO;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyPhongKS.DAO
{
	public class QuanLyPhongDAO
	{
		private QuanLyPhongDAO() { }

		private static QuanLyPhongDAO _instance;

		public static QuanLyPhongDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new QuanLyPhongDAO();
				}
				return _instance;
			}
		}
		public static int TableWidth = 100;
		public static int TableHeight = 100;
		public List<QuanLyPhong> GetPhong()
		{
			List<QuanLyPhong> phong = new List<QuanLyPhong>();
			string query = "exec LayDSPhong";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				phong.Add(new QuanLyPhong(row));
			}
			return phong;
		}
		public bool ThemPhong(string MaP, string TenP, string LoaiP, int GiaP, string Tinhtrang)
		{
			string query = "EXECUTE sp_ThemPhong @MaP , @TenP , @LoaiP , @GiaP , @Tinhtrang";

			object[] param = new object[] { MaP, TenP, LoaiP, GiaP, Tinhtrang };

			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool XoaPhong(string MaP)
		{
			string query = "EXEC Sp_XoaPhong @maP";
			object[] param = new object[] { MaP };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool SuaPhong(string MaP, string TenP, string LoaiP, int GiaP, string Tinhtrang)
		{
			string query = "EXECUTE sp_ThemPhong @MaP , @TenP , @LoaiP , @GiaP , @Tinhtrang";

			object[] param = new object[] { MaP, TenP, LoaiP, GiaP, Tinhtrang };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool SuaTTPhong(string MaP, string tinhTrang)
		{
			string query = "EXECUTE sp_SuaTinhTrangPhong @MaPhong , @TinhTrang";

			object[] param = new object[] { MaP, tinhTrang };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public List<QuanLyPhong> TimKiemTheoTen(string LoaiP)
		{
			List<QuanLyPhong> hh = new List<QuanLyPhong>();
			string query = "exec USP_SearchPhongByType @LoaiP";
			object[] param = new object[] { LoaiP };
			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				hh.Add(new QuanLyPhong(row));
			}
			return hh;
		}

	}
}
