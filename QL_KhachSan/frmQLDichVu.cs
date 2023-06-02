using BALayer;
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

namespace QL_KhachSan
{
    public partial class frmQLDichVu : MetroFramework.Forms.MetroForm
    {
        DataTable dtDichVu = null;
        bool Them;
        DBDichVu dbDichVu;
        public frmQLDichVu()
        {
            dbDichVu = new DBDichVu();
            InitializeComponent();
        }

        private void frmQLDichVu_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        public void LoadData()
        {
            try
            {
                dtDichVu = new DataTable();
                dtDichVu.Clear();
                dtDichVu = dbDichVu.LayDichVu().Tables[0];
                mdgvDichVu.DataSource = dtDichVu;

                this.mTxtMaDichVu.ResetText();
                this.mTxtTenDichVu.ResetText();
                this.mTxtMoTa.ResetText();
                this.mTxtGiaDichVu.ResetText();

                mdgvDichVu.AutoResizeColumns();

                this.mBtnLuu.Enabled = false;
                this.mBtnHuy.Enabled = false;

                this.mBtnThem.Enabled = true;
                this.mBtnSua.Enabled = true;
                this.mBtnXoa.Enabled = true;

                mdgvDichVu_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi !!!", "Thông báo");
            }
        }

        private void mdgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = mdgvDichVu.CurrentCell.RowIndex;
            this.mTxtMaDichVu.Text = mdgvDichVu.Rows[r].Cells[0].Value.ToString();
            this.mTxtTenDichVu.Text = mdgvDichVu.Rows[r].Cells[1].Value.ToString();
            this.mTxtMoTa.Text = mdgvDichVu.Rows[r].Cells[2].Value.ToString();
            this.mTxtGiaDichVu.Text = mdgvDichVu.Rows[r].Cells[3].Value.ToString();
        }

        private void mBtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void mBtnThem_Click(object sender, EventArgs e)
        {
            mTxtTenDichVu.Enabled = true;
            mTxtMoTa.Enabled = true;
            mTxtGiaDichVu.Enabled = true;

            mBtnSua.Enabled = false;
            mBtnXoa.Enabled = false;
            mBtnLuu.Enabled = true;
            mBtnHuy.Enabled = true;

            Them = true;

            mTxtMaDichVu.ResetText();
            mTxtTenDichVu.ResetText();
            mTxtMoTa.ResetText();
            mTxtGiaDichVu.ResetText();

            mTxtMaDichVu.Focus();
        }

        private void mBtnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            mTxtTenDichVu.Enabled = true;
            mTxtMoTa.Enabled = true;
            mTxtGiaDichVu.Enabled = true;

            mBtnThem.Enabled = false;
            mBtnXoa.Enabled = false;
            mBtnLuu.Enabled = true;
            mBtnHuy.Enabled = true;
        }

        private void mBtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = mdgvDichVu.CurrentCell.RowIndex;
                string strMaDV =
                mdgvDichVu.Rows[r].Cells["MaDichVu"].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbDichVu.XoaDichVu(ref err, Int32.Parse(strMaDV));
                    if (f)
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!\n\r" + "Lỗi:" + err);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
        }

        private void mBtnLuu_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (Them)
            {
                string err = "";
                try
                {
                    f = dbDichVu.ThemDichVu(ref err, mTxtTenDichVu.Text, mTxtMoTa.Text, decimal.Parse(mTxtGiaDichVu.Text));
                    if (f)
                    {
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                string err = "";
                try
                {
                    f = dbDichVu.CapNhatDichVu(ref err, Int32.Parse(mTxtMaDichVu.Text),
                        mTxtTenDichVu.Text, mTxtMoTa.Text, decimal.Parse(mTxtGiaDichVu.Text));
                    if (f)
                    {
                        LoadData();
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không cập nhật được. Lỗi rồi!");
                }
            }
        }

        private void mBtnHuy_Click(object sender, EventArgs e)
        {
            mTxtTenDichVu.Enabled = false;
            mTxtMoTa.Enabled = false;
            mTxtGiaDichVu.Enabled = false;

            mBtnThem.Enabled = true;
            mBtnSua.Enabled = true;
            mBtnXoa.Enabled = true;
            mBtnReload.Enabled = true;

            mBtnLuu.Enabled = false;
            mBtnHuy.Enabled = false;

            mdgvDichVu_CellClick(null, null);
        }
    }
}
