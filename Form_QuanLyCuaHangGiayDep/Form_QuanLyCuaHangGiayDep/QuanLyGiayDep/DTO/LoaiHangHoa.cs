using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DTO
{
    public class LoaiHangHoa
    {
         int iD;
         string tenLoaiHang;
         string moTa;
        public int ID { get => iD; set => iD = value; }
     
        public string TenLoaiHang { get => tenLoaiHang; set => tenLoaiHang = value; }
        public string MoTa { get => moTa; set =>  moTa = value; }

        public LoaiHangHoa(int iD, string tenLoaiHang, string moTa)
        {
            ID = iD;
            TenLoaiHang = tenLoaiHang;
            MoTa = moTa;
        }
        public LoaiHangHoa(DataRow row)
        {
            ID = (int)row["ID"];
            TenLoaiHang = row["TenDangNhap"].ToString();
            MoTa = row["MoTa"].ToString();
        }


    }
}
