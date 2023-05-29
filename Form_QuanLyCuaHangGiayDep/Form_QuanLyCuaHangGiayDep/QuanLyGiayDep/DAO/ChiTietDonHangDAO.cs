using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyGiayDep.DTO;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyGiayDep.DAO
{
    public class ChiTietDonHangDAO
    {
        private static ChiTietDonHangDAO _instance;
        public static ChiTietDonHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChiTietDonHangDAO();
                }
                return _instance;
            }
        }
        private ChiTietDonHangDAO() { }
		public List<ChiTietHoaDon> GetCT_HoaDon()
		{
			List<ChiTietHoaDon> hanghoa = new List<ChiTietHoaDon>();
			string query = "select * from CT_HoaDon";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				hanghoa.Add(new ChiTietHoaDon(row));
			}
			return hanghoa;
		}
		public List<ChiTietHoaDon> XemChiTietHD(int MaHD)
		{
			List<ChiTietHoaDon> cthoadon = new List<ChiTietHoaDon>();
			string query = "exec dbo.USP_XemHDByMaHD @MaHD";
			object[] param = new object[] { MaHD };
			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				cthoadon.Add(new ChiTietHoaDon(row));
			}
			return cthoadon;
		}
	}

	}

