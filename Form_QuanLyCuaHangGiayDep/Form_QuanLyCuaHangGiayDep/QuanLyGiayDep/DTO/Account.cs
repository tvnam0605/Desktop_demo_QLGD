using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DTO
{
    public class Account
    {
//		[TenDangNhap] [nvarchar] (100) primary key NOT NULL,
// --	[MatKhau] [nvarchar] (200) NOT NULL,
//  --	[HoVaTen] [nvarchar] (1000) NOT NULL,
//   --	[Email] [nvarchar] (1000) NULL,
//--	[DienThoai] [nvarchar] (200) NULL,
//--	[NgayTaoTK] [smalldatetime] NULL,

		public string tenDangNhap;
		private string matKhau;
		private string hoVaTen;
		private string eMail;
		private string dienThoai;
		private DateTime ngayTaoTaiKhoan;
		

		public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
		public string MatKhau { get => matKhau; set => matKhau = value; }
		public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
		public string Email { get => eMail; set => eMail = value; }
		public string DienThoai { get => dienThoai; set => dienThoai = value; }
		public DateTime NgayTaoTaiKhoan { get => ngayTaoTaiKhoan; set => ngayTaoTaiKhoan = value; }


		public Account(string tenDangNhap, string matKhau , string hoVaTen, string eMail, string dienThoai, DateTime ngayTaoTK)
		{
			TenDangNhap = tenDangNhap;
			MatKhau = matKhau;
			HoVaTen = hoVaTen;
			Email = eMail;
			DienThoai = dienThoai;
			NgayTaoTaiKhoan = ngayTaoTK;
		}

		public Account(DataRow row)
		{
			TenDangNhap = row["TenDangNhap"].ToString();
			MatKhau = row["MatKhau"].ToString();
			HoVaTen = row["HoTen"].ToString();
			Email = (string)row["Email"];
			DienThoai = row["DienThoai"].ToString();
            NgayTaoTaiKhoan = (DateTime)row["NgayTaoTaiKhoan"];

        }
	}
}
