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
    public partial class frmChiTietDichVu : MetroFramework.Forms.MetroForm
    {
        DataTable dtChiTietDichVu = null;
        DBPhieuDichVu dbPhieuDichVu;
        public frmChiTietDichVu()
        {
            dbPhieuDichVu = new DBPhieuDichVu();
            InitializeComponent();
        }

        private void frmChiTietDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtChiTietDichVu = new DataTable();
                dtChiTietDichVu.Clear();
                dtChiTietDichVu = dbPhieuDichVu.LayChiTietDichVu().Tables[0];
                mdgvChiTietDichVu.DataSource = dtChiTietDichVu;
                mdgvChiTietDichVu.AutoResizeColumns();
                mdgvChiTietDichVu_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi !!!", "Thông báo");
            }
        }

        private void mBtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void mBtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mBtnTimKiem_Click(object sender, EventArgs e)
        {
            string sdtCanTim = mTxtSoDienThoai.Text.Trim();

            mdgvChiTietDichVu.ClearSelection();
            mdgvChiTietDichVu.CurrentCell = null;

            foreach (DataGridViewRow row in mdgvChiTietDichVu.Rows)
            {
                if (row.Cells["SoDienThoai"].Value != null && row.Cells["SoDienThoai"].Value.ToString() == sdtCanTim)
                {
                    row.Selected = true;
                    mdgvChiTietDichVu.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void mdgvChiTietDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
