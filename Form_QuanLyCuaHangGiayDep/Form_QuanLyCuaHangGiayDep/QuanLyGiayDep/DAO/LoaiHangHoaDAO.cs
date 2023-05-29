using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyGiayDep.DTO;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DAO
{
   public class LoaiHangHoaDAO
    {
        private static LoaiHangHoaDAO _instance;
        public static LoaiHangHoaDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoaiHangHoaDAO();
                }
                return _instance;
            }
        }
        private LoaiHangHoaDAO() { }
        public DataTable LayDSLoaiHang()
        {
            string query = "SELECT * FROM LoaiHangHoa";
            return DataProvider.Instance.ExecuteQuery(query);

        }
		public bool SuaLoaiHang(int ID, string TenLoaiHang, string MoTa)
		{
			string query = "EXEC USP_CapNhatLoaiHangHoa @ID , @TenLoaiHang , @MoTa ";
			object[] param = new object[] { ID, TenLoaiHang, MoTa };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool ThemLoaiHang( string TenLoaiHang, string MoTa)
		{
			string query = "EXEC USP_ThemLoaiHangHoa @TenLoaiHang , @MoTa ";
			object[] param = new object[] { TenLoaiHang, MoTa };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool XoaLoaiHang(int ID)
		{
			string query = "EXEC USP_XoaLoaiHangHoa @ID";
			object[] param = new object[] { ID };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	}
}
