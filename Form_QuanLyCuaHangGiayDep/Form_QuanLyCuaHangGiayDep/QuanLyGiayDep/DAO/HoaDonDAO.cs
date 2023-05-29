using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyGiayDep.DTO;

namespace QuanLyGiayDep.DAO
{
   public class HoaDonDAO
   {
		private HoaDonDAO() { }
        private static HoaDonDAO _instance;
		public static HoaDonDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new HoaDonDAO();
				}
				return _instance;
			}
		}
		public List<HoaDon> GetHoaDon()
        {
			List<HoaDon> hoadon = new List<HoaDon>();
			string query = "EXEC USP_XemAllHoaDon";
			//string query = "select ID, NgayLap, TenDangNhap, TongTien, GiamGia, TrangThaiDonHang, TenKhachHang, SoDienThoai, DiaChi "
			//	+ "from HoaDon join KhachHang on HoaDon.MaKH = KhachHang.MaKH";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				hoadon.Add(new HoaDon(row));
			}
			return hoadon;

		}
		public List<HoaDon> XemChiTietHD(int ID)
		{
			List<HoaDon> cthoadon = new List<HoaDon>();
			string query = "exec dbo.USP_XemHDByMaHD @MaHD";
			object[] param = new object[] { ID };
			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				cthoadon.Add(new HoaDon(row));
			}
			return cthoadon;
		}
		public bool ThemHoaDon(DateTime ngayLap, string tenDangNhap, float tongTien, float giamGia, string tenKhachHang, string soDienThoai, string diaChi, string trangThaiDonHang)
		{
			string query = "exec  USP_ThemHoaDon @NgayLap , @TenDangNhap , @TongTien , @GiamGia , @TenKhachHang , @SoDienThoai , @DiaChi , @TrangThaiDonHang";

			object[] param = new object[] { ngayLap, tenDangNhap, tongTien, giamGia,tenKhachHang,soDienThoai,diaChi,trangThaiDonHang};

			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

        public List<HoaDon> TimKiemTheoTen(string TenKhachHang)
        {
            List<HoaDon> hh = new List<HoaDon>();
            string query = "EXEC USP_SearchKhachHangByName @TenKhachHang";
            object[] param = new object[] { TenKhachHang };
            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
            foreach (DataRow row in table.Rows)
            {
                hh.Add(new HoaDon(row));
            }
            return hh;
        }

        public List<HoaDon> TimKiemTheoSDT(string SoDienThoai)
        {
            List<HoaDon> hh = new List<HoaDon>();
            string query = "EXEC USP_SearchHoaDonBySDT @soDienThoai";
            object[] param = new object[] { SoDienThoai };
            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
            foreach (DataRow row in table.Rows)
            {
                hh.Add(new HoaDon(row));
            }
            return hh;
        }

        public List<HoaDon> TimKiemTheoNV(string TenDangNhap)
        {
            List<HoaDon> hh = new List<HoaDon>();
            string query = "EXEC USP_SearchHoaDonByNV @tenNhanVien";
            object[] param = new object[] { TenDangNhap };
            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
            foreach (DataRow row in table.Rows)
            {
                hh.Add(new HoaDon(row));
            }
            return hh;
        }

    }
}
