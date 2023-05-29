using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiayDep.DTO
{

    public class Main
    {
        private int maSanPham;
        private string tenHH;
		private float donGia;
		private string size;
		private int loaiHH;
		private string xuatXu;
		private int nhaCC;

		public int MaSanPham { get => maSanPham; set => maSanPham = value; }
		public string TenHH { get => tenHH; set => tenHH = value; }
		public float DonGia { get => donGia; set => donGia = value; }
		public string Size { get => size; set => size = value; }
		public int LoaiHH { get => loaiHH; set => loaiHH = value; }
		public string XuatXu { get => xuatXu; set => xuatXu = value; }
		public int NhaCC { get => nhaCC; set => nhaCC = value; }
        public Main(int maSanPham, string tenHH, float donGia, string size, int loaiHH, string xuatXu, int nhaCC)
        {
			MaSanPham = maSanPham;
			TenHH = tenHH;
			DonGia = donGia;
			Size = size;
			LoaiHH = loaiHH;
			XuatXu = xuatXu;
			NhaCC = nhaCC;
        }
		public Main(DataRow row)
        {
			MaSanPham = (int)row["ID"];
			TenHH = row["TenHangHoa"].ToString();
			DonGia = (float)Convert.ToDouble(row["DonGia"]);
			Size = row["Size"].ToString();
			LoaiHH = (int)row["LoaiHangHoaID"];
			XuatXu = row["XuatXu"].ToString();
			NhaCC = (int)row["NhaCungCapID"];
        }


	}
}
