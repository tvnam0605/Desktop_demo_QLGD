using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyPhongKS.DAO;
using System.Threading.Tasks;

namespace QuanLyPhongKS.DTO
{
	public class QuanLyKhach
	{
		string cmt;
		string hoTen;
		string diaChi;
		string gt;
		string sdt;

		public string CMT { get => cmt; set => cmt = value; }
		public string Hoten { get => hoTen; set => hoTen = value; }
		public string Diachi { get => diaChi; set => diaChi = value; }
		public string GT { get => gt; set => gt = value; }
		public string SDT { get => sdt; set => sdt = value; }

		public QuanLyKhach(string cmt, string hoTen, string diachi, string gt, string sdt)
		{
			CMT = cmt;
			Hoten = hoTen;
			Diachi = Diachi;
			GT = gt;
			SDT = sdt;

		}
		public QuanLyKhach(DataRow row)
		{
			CMT = row["CMT"].ToString();
			Hoten = row["Hoten"].ToString();
			Diachi = row["Diachi"].ToString();
			GT = row["GT"].ToString();
			SDT = row["SDT"].ToString();
		}
	}
}
