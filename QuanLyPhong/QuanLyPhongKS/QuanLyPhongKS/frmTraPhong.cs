using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKS.DAO;

namespace QuanLyPhongKS
{
    public partial class frmTraPhong : Form
    {
        BindingSource DSTraPhong = new BindingSource();

        public frmTraPhong()
        {
            InitializeComponent();
            LoadState();
			TinhNgay();
		}
        void LoadState()
        {

            dgvDanhSachThue.DataSource = DSTraPhong;
            cboMaKH.DataSource = DSTraPhong;
            LoadDSKH();
			TinhNgay();

		}
        void LoadDSKH()
        {
            DSTraPhong.DataSource = ThuePhongDAO.Instance.GetDSThue();
            cboMaKH.ValueMember = "CMT";
            cboMaKH.DisplayMember = "CMT";
			



		}
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {

        }
        public void SoNgay()
        {
            float soNgay;
           
        }
        private void dgvDanhSachThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dgvDanhSachThue.CurrentRow.Index;
            lblMaKH.Text = dgvDanhSachThue.Rows[i].Cells[0].Value.ToString();
			
		}
		private void TinhNgay()
		{
			double tongNgay = 0;

			foreach (DataGridViewRow row in dgvDanhSachThue.Rows)
			{
				// Kiểm tra nếu dòng không phải là dòng trống
				if (!row.IsNewRow)
				{
					DateTime ngayDi = DateTime.Parse(row.Cells[4].Value.ToString());
					DateTime ngayO = DateTime.Parse(row.Cells[3].Value.ToString());
					TimeSpan tinhNgay = ngayDi - ngayO;
					tongNgay += tinhNgay.TotalDays;
				}
			}

			txtHoTenKH.Text = tongNgay.ToString();
		}

		private void lbMaKH_Click(object sender, EventArgs e)
        {
		
		}

		private void txtHoTenKH_TextChanged(object sender, EventArgs e)
		{

		}

		private void lbSoNgayO_Click(object sender, EventArgs e)
		{

		}
	}
}
