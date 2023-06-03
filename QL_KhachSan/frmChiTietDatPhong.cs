using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmChiTietDatPhong : MetroFramework.Forms.MetroForm
    {
        DataTable dtPhieuDatPhong = null;
        DBPhieuDatPhong dBPhieuDatPhong;
        public frmChiTietDatPhong()
        {
            dBPhieuDatPhong = new DBPhieuDatPhong();
            InitializeComponent();
        }

        private void frmChiTietDatPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtPhieuDatPhong = new DataTable();
                dtPhieuDatPhong.Clear();
                dtPhieuDatPhong = dBPhieuDatPhong.LayDanhSachDatPhong().Tables[0];
                mdgvKhachHang.DataSource = dtPhieuDatPhong;

                mdgvKhachHang.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mBtnReload_Click(object sender, EventArgs e)
        {
            this.mTxtSDT.ResetText();
        }

        private void mBtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mBtnTim_Click(object sender, EventArgs e)
        {
            string sdtCanTim = mTxtSDT.Text.Trim();

            mdgvKhachHang.ClearSelection();
            mdgvKhachHang.CurrentCell = null;

            foreach (DataGridViewRow row in mdgvKhachHang.Rows)
            {
                if (row.Cells["SoDienThoai"].Value != null && row.Cells["SoDienThoai"].Value.ToString() == sdtCanTim)
                {
                    row.Selected = true;
                    mdgvKhachHang.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }
    }
}
