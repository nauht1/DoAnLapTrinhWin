using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBLayer;
using BALayer;

namespace QL_KhachSan
{
    public partial class frmQLNV : MetroFramework.Forms.MetroForm
    {
        DataTable dtNhanVien = null;
        DataTable dtChucVu = null;
        bool Them;
        DBNhanVien dbNhanVien;
        public frmQLNV()
        {
            dbNhanVien = new DBNhanVien();
            InitializeComponent();
        }
        private void frmQLNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbNhanVien.LayNhanVien().Tables[0];
                mdgvNhanVien.DataSource = dtNhanVien;

                dtChucVu = new DataTable();
                dtChucVu = dbNhanVien.LayChucVu();

                mCboChucVu.DataSource = dtChucVu;
                mCboChucVu.DisplayMember = "TenChucVu";
                mCboChucVu.ValueMember = "MaChucVu";

                (mdgvNhanVien.Columns["ChucVu"] as DataGridViewComboBoxColumn).DataSource = dtChucVu;
                (mdgvNhanVien.Columns["ChucVu"] as DataGridViewComboBoxColumn).ValueMember = "MaChucVu";
                (mdgvNhanVien.Columns["ChucVu"] as DataGridViewComboBoxColumn).DisplayMember = "TenChucVu";

                mdgvNhanVien.AutoResizeColumns();

                this.mTxtTenNhanVien.ResetText();
                this.mTxtDiaChi.ResetText();
                this.mTxtSDT.ResetText();

                this.mBtnLuu.Enabled = false;
                this.mBtnHuy.Enabled = false;

                this.mBtnThem.Enabled = true;
                this.mBtnSua.Enabled = true;
                this.mBtnXoa.Enabled = true;
                mdgvNhanVien_CellClick(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = mdgvNhanVien.CurrentCell.RowIndex;
            this.mTxtMaNhanVien.Text = mdgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.mTxtTenNhanVien.Text = mdgvNhanVien.Rows[r].Cells["TenNhanVien"].Value.ToString();
            this.mCboChucVu.SelectedValue = mdgvNhanVien.Rows[r].Cells["ChucVu"].Value;
            this.mCboGioiTinh.Text = mdgvNhanVien.Rows[r].Cells["GioiTinh"].Value.ToString();
            this.mTxtDiaChi.Text = mdgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.mTxtSDT.Text = mdgvNhanVien.Rows[r].Cells[5].Value.ToString();
        }
    }
}
