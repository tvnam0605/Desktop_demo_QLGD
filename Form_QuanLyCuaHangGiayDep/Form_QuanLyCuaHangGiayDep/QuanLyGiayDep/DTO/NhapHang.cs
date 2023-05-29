using System;
using QuanLyGiayDep.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DTO
{
   public class NhapHang
    {
        int iD;
        DateTime ngayLap;
        string nguoiLap;
        int nhaCungCapID;
        float tongTien;
        float giamGia;
        string trangThaiHoaDonNhap;

        public int ID { get => iD; set => iD = value; }
        public DateTime NgayLap { get => ngayLap ; set => ngayLap = value; }
        public string NguoiLap { get => nguoiLap; set => nguoiLap = value; }
        public int NhaCungCapID { get => nhaCungCapID; set => nhaCungCapID = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float GiamGia { get => giamGia; set => giamGia = value; }
        public string TrangThaiHoaDonNhap { get => trangThaiHoaDonNhap; set => trangThaiHoaDonNhap = value; }

        public NhapHang(int iD, DateTime ngaylap, string nguoilap, int nhaCungCapID, float tongTien, float giamGia, string trangThaiHoaDonNhap)
        {
            ID = iD;
            NgayLap = ngaylap;
            NguoiLap = nguoilap;
            NhaCungCapID = nhaCungCapID;
            TongTien = tongTien;
            GiamGia = giamGia;
            TrangThaiHoaDonNhap = trangThaiHoaDonNhap;
        }
        public NhapHang(DataRow row)
        {
            ID = (int)row["ID"];
            NgayLap = (DateTime)row["NgayLap"];
            NguoiLap = row["NguoiLap"].ToString();
            NhaCungCapID = (int)row["NhaCungCapID"];
            TongTien = (float)Convert.ToDouble(row["TongTien"]);
            GiamGia = (float)Convert.ToDouble(row["GiamGia"]);
            TrangThaiHoaDonNhap = row["TrangThangHoaDonNhap"].ToString();
        }
    }
}
