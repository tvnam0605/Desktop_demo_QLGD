using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyPhongKS.DAO;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyPhongKS.DTO
{
	public class TaiKhoan
	{
	
		public string aCC;
		public string pass;
		public string tenND;
		

		public string Acc { get => aCC; set => aCC = value; }
		public string Pass { get => pass; set => pass = value; }
		public string TenND { get => tenND; set => tenND = value; }
		

		public TaiKhoan(string aCC, string pass,string tenND)
		{
			Acc = aCC;
			Pass = pass;
			TenND = tenND;
			
		}

		public TaiKhoan(DataRow row)
		{
			Acc = row["Acc"].ToString();
			Pass = row["Pass"].ToString();
			TenND = row["TenND"].ToString();
		}
	}
}
