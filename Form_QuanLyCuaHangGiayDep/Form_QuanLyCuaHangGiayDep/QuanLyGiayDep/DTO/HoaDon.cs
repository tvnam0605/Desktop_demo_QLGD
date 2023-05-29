using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyGiayDep.DAO;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DTO
{
    public class HoaDon
    {
		int iD;
        DateTime ngayLap;
        string tenDangNhap;
        float tongTien;
        float giamGia;
        string trangThaiDonHang;
		string tenKhachHang;
		string soDienThoai;
		string diaChi;
		public int ID { get => iD; set => iD = value; }
		public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
		public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
		public float TongTien { get => tongTien; set => tongTien = value; }
		public float GiamGia { get => giamGia; set => giamGia = value; }
		public string TrangThaiDonHang { get => trangThaiDonHang; set => trangThaiDonHang = value; }
		public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
		public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
		public string DiaChi { get => diaChi; set => diaChi = value; }

		public HoaDon(int iD, DateTime ngayLap, string tenDangNhap, float tongTien, float giamGia, string trangThaiDonHang, string tenKhachHang, string soDienThoai, string diaChi)
		{
			ID = ID;
			NgayLap = ngayLap;
			TenDangNhap = tenDangNhap;
			TongTien = tongTien;
			GiamGia = giamGia;
			TrangThaiDonHang = trangThaiDonHang;
			TenKhachHang = tenKhachHang;
			SoDienThoai = soDienThoai;
			DiaChi = diaChi;
		}

		public HoaDon(DataRow row)
		{
			ID = (int)row["ID"];
			NgayLap = (DateTime)row["NgayLap"];
			TenDangNhap = row["TenDangNhap"].ToString();
			TongTien = (float)Convert.ToDouble(row["TongTien"]);
			GiamGia = (float)Convert.ToDouble(row["GiamGia"]);
			TrangThaiDonHang = row["TrangThaiDonHang"].ToString();
			TenKhachHang = row["TenKhachHang"].ToString();
			SoDienThoai = row["SoDienThoai"].ToString();
			DiaChi = row["DiaChi"].ToString();
		}
	}
}
