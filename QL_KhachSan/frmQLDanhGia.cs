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
    public partial class frmQLDanhGia : MetroFramework.Forms.MetroForm
    {
        DataTable dtDanhGia = null;
        DBDanhGia dbDanhGia;
        public frmQLDanhGia()
        {
            dbDanhGia = new DBDanhGia();
            InitializeComponent();
        }

        private void frmQLDanhGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtDanhGia = new DataTable();
                dtDanhGia.Clear();
                dtDanhGia = dbDanhGia.LayDanhGia().Tables[0];
                mdgvDanhGia.DataSource = dtDanhGia;


                this.mTxtMaDanhGia.ResetText();
                this.mTxtTenKhachHang.ResetText();
                this.mTxtNoiDung.ResetText();

                mTxtMaDanhGia.Enabled = false;
                mTxtTenKhachHang.Enabled = false;
                mTxtNoiDung.Enabled = false;


                mdgvDanhGia.AutoResizeColumns();
                mdgvDanhGia_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thứ tự dòng hiện hành
            int r = mdgvDanhGia.CurrentCell.RowIndex;
            this.mTxtMaDanhGia.Text = mdgvDanhGia.Rows[r].Cells["MaDanhGia"].Value.ToString();
            this.mTxtTenKhachHang.Text = mdgvDanhGia.Rows[r].Cells["TenKhachHang"].Value.ToString();
            this.mTxtNoiDung.Text = mdgvDanhGia.Rows[r].Cells["NoiDung"].Value.ToString();
            this.mTxtSDT.Text = mdgvDanhGia.Rows[r].Cells["SoDienThoai"].Value.ToString();

        }
    }
}
