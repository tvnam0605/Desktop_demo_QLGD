using System;
using QuanLyGiayDep.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DAO
{
   public class NhapHangDAO
    {
        private static NhapHangDAO _instance;
        public static NhapHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NhapHangDAO();
                }
                return _instance;
            }
        }
        private NhapHangDAO() { }
        public List<HangHoa> GetHangHoa()
        {
            List<HangHoa> hanghoa = new List<HangHoa>();
            string query = "Exec USP_ViewAllHangHoa";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                hanghoa.Add(new HangHoa(row));
            }
            return hanghoa;
        }
    }
}
