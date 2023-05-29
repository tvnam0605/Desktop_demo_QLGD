using System;
using QuanLyGiayDep.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Threading.Tasks;

namespace QuanLyGiayDep.DAO
{
    public class HangHoaDAO
    {
        private static HangHoaDAO _instance;
        public static HangHoaDAO Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new HangHoaDAO();
                }
                return _instance;
            }
        }
        private HangHoaDAO() { }
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
        public List<HangHoa>TimKiemTheoTen(string TenHangHoa)
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

        public bool ThemHangHoa(string tenHH, float donGia, float size, int loaiHH, string xuatXu, int nhaCC)
        {
            string query = "EXEC USP_ThemHangHoa @TenHangHoa , @DonGia , @Size , @LoaiHangHoaID , @XuatXu , @NhaCungCapID";
         
            object[] param = new object[] { tenHH, donGia,size, loaiHH,xuatXu,nhaCC};
            
            int result = DataProvider.Instance.ExecuteNonQuery(query, param);
            return result > 0;
        }    

        public bool SuaHangHoa(int MaSanPham,string TenHH, float DonGia, float Size, int LoaiHH, string XuatXu, int NhaCC)
        {
            string query = "EXEC USP_SuaHangHoa @MaSanPham , @TenHH , @DonGia , @Size , @LoaiHH , @XuatXu , @NhaCC";
            object[] param = new object[] { MaSanPham, TenHH, DonGia, Size, LoaiHH, XuatXu, NhaCC };
            int result = DataProvider.Instance.ExecuteNonQuery(query, param);
            return result > 0;
        }
        public bool XoaHangHoa(int maSanPham)
        {
            string query = "EXEC USP_XoaHangHoa @maHangHoa";
            object[] param = new object[] { maSanPham };
            int result = DataProvider.Instance.ExecuteNonQuery(query, param);
            return result > 0;
        }
    }
}
