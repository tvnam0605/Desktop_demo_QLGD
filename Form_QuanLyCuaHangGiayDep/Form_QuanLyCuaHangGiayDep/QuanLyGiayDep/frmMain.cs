using QuanLyGiayDep.DTO;
using QuanLyGiayDep.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiayDep
{
    public partial class frmMain : Form
    {
        BindingSource DSHangHoa = new BindingSource();
		BindingSource tenDangNhap = new BindingSource();
		private Account account;
        public Main CurerntMain { get => dgvDSHH.Tag as Main; }


        #region Methods	
        void LoadState()
        {
            dgvDSHH.DataSource = DSHangHoa;
			ChangeAccount();
			

		}
		void TaiDSHH()
		{
			DSHangHoa.DataSource = MainDAO.Instance.LoadHangHoa();
		}
		void ChangeAccount()
		{
			txtTenDN.Text = account.TenDangNhap;
		}
		private void frmMain_Load(object sender, EventArgs e)
        {
            TaiDSHH();
        }
		private event EventHandler themHoaDon;
		public event EventHandler ThemHoaDon
		{
			add { themHoaDon += value; }
			remove { themHoaDon -= value; }
		}

		public frmMain(Account acc)
        {
            account = acc;
            InitializeComponent();

            LoadState();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (dgvDSHH.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dgvDSHH.SelectedRows[0];

               
                ListViewItem item = new ListViewItem(selectedRow.Cells[0].Value.ToString());
                for (int i = 1; i < selectedRow.Cells.Count; i++)
                {
                    item.SubItems.Add(selectedRow.Cells[i].Value.ToString());
                }

           
                lvCTDonHang.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách hàng hóa trước khi thêm vào hóa đơn.");
            }
            TinhTongTienHang();
            TinhTongThanhToan();
            decimal soTien = decimal.Parse(txtTongThanhToan.Text);
            string chuoiChu = DocSoTienRaChu(soTien);
            lblSTChu.Text = chuoiChu;
        }

        private void btnXoaKhoiHD_Click(object sender, EventArgs e)
        {
            
            var selectedItems = lvCTDonHang.SelectedItems; 
            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem selectedItem = selectedItems[i];
                lvCTDonHang.Items.Remove(selectedItem);
            }
            TinhTongTienHang();
            TinhTongThanhToan();
            decimal soTien = decimal.Parse(txtTongThanhToan.Text);
            string chuoiChu = DocSoTienRaChu(soTien);
            lblSTChu.Text = chuoiChu;
        }
        private void TinhTongTienHang()
        {
            float tongTien = 0;

          
            foreach (ListViewItem item in lvCTDonHang.Items)
            {
                int soLuong = int.Parse(item.SubItems[4].Text);
                float giaBan = float.Parse(item.SubItems[2].Text); 
                float thanhTien = soLuong * giaBan;
                tongTien += thanhTien;
            }

           
            txtTongTienHang.Text = tongTien.ToString();
        }
        private void TinhTongThanhToan()
        {
            decimal tongTienHang = decimal.Parse(txtTongTienHang.Text);
            decimal giamGiaPhanTram = decimal.Parse(nmudGiamGia.Text);
            decimal thueVATPhanTram = decimal.Parse(txtThueVAT.Text);

            decimal giamGia = (giamGiaPhanTram / 100) * tongTienHang;
            decimal thueVAT = (thueVATPhanTram / 100) * tongTienHang;

            decimal tongThanhToan = tongTienHang - giamGia + thueVAT;

            txtTongThanhToan.Text = tongThanhToan.ToString();
        }

        private string DocSoTienRaChu(decimal soTien)
        {
            string[] chuSo = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] donVi = new string[] { "", "nghìn", "triệu", "tỷ" };

            string chuoiChu = "";

            if (soTien == 0)
            {
                chuoiChu = chuSo[0];
            }
            else
            {
                int donViIndex = 0;

                while (soTien > 0)
                {
                    int group = (int)(soTien % 1000);
                    int hangDonVi = group / 100;
                    int hangChuc = (group % 100) / 10;
                    int hangDonViNho = group % 10;

                    string chuoiGroup = "";

                    if (hangDonVi > 0)
                    {
                        chuoiGroup += chuSo[hangDonVi] + " trăm ";
                    }

                    if (hangChuc == 0 && hangDonViNho > 0)
                    {
                        chuoiGroup += "" + chuSo[hangDonViNho];
                    }
                    else if (hangChuc == 1 && hangDonViNho > 0)
                    {
                        chuoiGroup += "mười " + chuSo[hangDonViNho];
                    }
                    else if (hangChuc > 1 && hangDonViNho == 1)
                    {
                        chuoiGroup += chuSo[hangChuc] + " mươi mốt";
                    }
                    else if (hangChuc > 1 && hangDonViNho > 1)
                    {
                        chuoiGroup += chuSo[hangChuc] + " mươi " + chuSo[hangDonViNho];
                    }
                    else if (hangChuc == 0 && hangDonViNho == 0 && hangDonVi == 0 && donViIndex == 0)
                    {
                        chuoiGroup += "";
                    }
                    else if (hangChuc == 0 && hangDonViNho == 0)
                    {
                        chuoiGroup += chuSo[hangDonVi];
                    }

                    if (group > 0)
                    {
                        chuoiGroup += " " + donVi[donViIndex];
                    }

                    chuoiChu = chuoiGroup + " " + chuoiChu;

                    soTien = (int)(soTien / 1000);
                    donViIndex++;
                }
            }

            return chuoiChu.Trim();
        }
		
		List<HangHoa> TimTheoTen(string TenHangHoa)
		{
			List<HangHoa> hh = HangHoaDAO.Instance.TimKiemTheoTen(TenHangHoa);
			return hh;
		}

		#endregion

		#region Event

		private void btnXoanBoLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void tsmQLNVien_Click(object sender, EventArgs e)
        {
            var frm = new frmQuanLyNhanVien();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmHangHoa_Click(object sender, EventArgs e)
        {
            var frm = new frmHangHoa();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tsmHoaDon_Click(object sender, EventArgs e)
        {
            var frm = new frmDoanhThu();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
		private void tsmLoaiHang_Click(object sender, EventArgs e)
		{
			var frm = new frmLoaiHangHoa();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}
        private void btnThoat_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void btnLuuVaIn_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "") { MessageBox.Show("Nhập tên khách hàng"); }
            else if (txtDiaChi.Text == "") { MessageBox.Show("Nhập địa chỉ khách hàng"); }
            else if (txtSoDT.Text == "") { MessageBox.Show("Nhập SDT khách hàng"); }
            else if (txtTongTienHang.Text == "") { MessageBox.Show("Danh Sách trống, vui lòng thêm hàng hóa"); }
            else
            {
                DateTime NgayLap = dtpNgayLapHD.Value;
                string TenDangNhap = txtTenDN.Text;
                float TongTien = float.Parse(txtTongThanhToan.Text);
                float GiamGia = float.Parse(nmudGiamGia.Text);
                string TenKhachHang = txtHoTen.Text;
                string SoDienThoai = txtSoDT.Text;
                string DiaChi = txtDiaChi.Text;
                string TrangThaiDonHang = "Đã Thanh Toán";
                if (HoaDonDAO.Instance.ThemHoaDon(NgayLap, TenDangNhap, TongTien, GiamGia, TenKhachHang, SoDienThoai, DiaChi, TrangThaiDonHang))
                {
                    MessageBox.Show("Thêm thành công vào hóa đơn");
                    themHoaDon?.Invoke(this, new EventArgs());
                    dtpNgayLapHD.Text = "";
                    txtHoTen.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDT.Text = "";
                    txtTongThanhToan.Text = "";
                    txtTongTienHang.Text = "";
                    lblSTChu.Text = "0 đồng";
                    lvCTDonHang.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            
		}
		private void btnHuyDon_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Hủy đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				lvCTDonHang.Items.Clear();
				txtTongThanhToan.Text = "";
				txtTongTienHang.Text = "";
				lblSTChu.Text = "0 đồng";
			}
			
        }
		private void tsmDangXuat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{	
				this.Close();
				frmLogin loginForm = new frmLogin();
				loginForm.Show();
			}
		}

		private void txtTaiLai_Click(object sender, EventArgs e)
		{
			TaiDSHH();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			dgvDSHH.DataSource = TimTheoTen(txtTimKiem.Text);
		}
		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			DSHangHoa.DataSource = TimTheoTen(txtTimKiem.Text);
		}
		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void tsmTaiKhoan_Click(object sender, EventArgs e)
		{

		}

		#endregion


	}
}
