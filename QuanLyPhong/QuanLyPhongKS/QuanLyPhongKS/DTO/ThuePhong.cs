using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using QuanLyPhongKS.DAO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKS.DTO
{
	public class ThuePhong
	{
		//	[MaHD] [int] IDENTITY(1,1) NOT NULL,
		//[CMT] [nvarchar] (12) NOT NULL,

		// [MaP] [nvarchar] (5) NOT NULL,

		//  [Ngayden] [date]
		//	NOT NULL,

		//  [Ngaydi] [date] NULL,
		//[TenNV] [nvarchar] (30) NOT NULL,
		public int maHD;
		public string cMT;
		public string maP;
		DateTime ngayDen;
		DateTime ngayDi;
		string tenNV;
		public int MaHD { get => maHD; set => maHD = value; }
		public string CMT { get => cMT; set => cMT = value; }
		public string MaP { get => maP; set => maP = value; }
		public DateTime NgayDen { get => ngayDen; set => ngayDen = value; }
		public DateTime NgayDi { get => ngayDi; set => ngayDi = value; }
		public string TenNV { get => tenNV; set => tenNV = value; }
		public ThuePhong(int maHD, string cMT,string maP, DateTime ngayDen, DateTime ngayDi, string tenNV)
		{
			MaHD = maHD;
			CMT = cMT;
			MaP = maP;
			NgayDen = ngayDen;
			NgayDi = NgayDi;
			TenNV = tenNV;


		}
		public ThuePhong(DataRow row)
		{
			MaHD = (int)row["MaHD"];
			CMT = row["CMT"].ToString();
			MaP = row["MaP"].ToString();
			NgayDen = DateTime.Parse(row["Ngayden"].ToString());
			NgayDi = DateTime.Parse(row["Ngaydi"].ToString());
			TenNV = row["TenNV"].ToString();
		}

	}
}
