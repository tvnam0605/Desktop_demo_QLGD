using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyPhongKS.DAO;
using System.Threading.Tasks;

namespace QuanLyPhongKS.DTO
{
	public class QuanLyPhong
	{
		string maPhong;
		string tenPhong;
		string loaiPhong;
		int giaPhong;
		string tinhTrang;

		public string MaP { get => maPhong; set => maPhong = value; }
		public string TenP { get => tenPhong; set => tenPhong = value; }
		public string LoaiP { get => loaiPhong; set => loaiPhong = value; }
		public int GiaP { get => giaPhong; set => giaPhong = value; }
		public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

		public QuanLyPhong(string maPhong, string tenPhong, string loaiPhong, int giaPhong, string tinhTrang)
		{
			MaP = maPhong;
			TenP = tenPhong;
			LoaiP = loaiPhong;
			GiaP = giaPhong;
			TinhTrang = tinhTrang;

		}
		public QuanLyPhong(DataRow row)
		{
			MaP = row["MaP"].ToString();
			TenP = row["TenP"].ToString();
			LoaiP = row["LoaiP"].ToString();
			GiaP = (int)row["GiaP"];
			TinhTrang = row["TinhTrang"].ToString();
		}
	}
}
