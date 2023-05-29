using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DTO
{
    public class ChiTietHoaDon
    {
        //      MaHD INT REFERENCES HoaDon(ID),
        //MaHangHoa INT REFERENCES HangHoa(ID),
        //SoLuong INT,
        //DonGia FLOAT,
        int maHD;
        int maHangHoa;
        int soLuong;
        float donGia;
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaHangHoa { get => maHangHoa; set => MaHangHoa = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public ChiTietHoaDon(int maHD,
        int maHangHoa,
        int soLuong,
        float donGia)
        {
            MaHD = maHD;
            MaHangHoa = maHangHoa;
            SoLuong = soLuong;
            DonGia = donGia;
        }
        public ChiTietHoaDon(DataRow row)
        {
            MaHD = (int)row["MaHD"];
            MaHangHoa = (int)row["MaHangHoa"];
            SoLuong = (int)row["SoLuong"];
            DonGia = (float)Convert.ToDouble(row["DonGia"]);
        }
    }
}
