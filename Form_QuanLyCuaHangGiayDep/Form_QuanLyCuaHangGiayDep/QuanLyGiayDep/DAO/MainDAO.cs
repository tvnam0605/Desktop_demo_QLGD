using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using QuanLyGiayDep.DTO;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DAO
{
    
   public class MainDAO
    {
        private static MainDAO _instance;

        public static MainDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainDAO();
                }
                return _instance;
            }
        }
        private MainDAO() { }
        public List<Main> LoadHangHoa()
        {
            List<Main> tables = new List<Main>();
            string query = "select * from HangHoa";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Main table = new Main(row);
                tables.Add(table);
            }
            return tables;
        }
		public List<HangHoa> TimKiem(string TenHangHoa)
		{
			List<HangHoa> hh = new List<HangHoa>();
			string query = "EXEC USP_SearchHangHoaByName @TenHangHoa";
			object[] param = new object[] { TenHangHoa };
			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				hh.Add(new HangHoa(row));
			}
			return hh;
		}
	}
}
