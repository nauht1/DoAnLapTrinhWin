using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmQLLoaiPhong : MetroFramework.Forms.MetroForm
    {
        DataTable dtLoaiPhong = null;
        bool Them;
        DBPhong dbPhong;
        public frmQLLoaiPhong()
        {
            dbPhong = new DBPhong();
            InitializeComponent();
        }

        private void frmQLLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtLoaiPhong = new DataTable();
                dtLoaiPhong.Clear();
                dtLoaiPhong = dbPhong.LayLoaiPhong().Tables[0];
                mdgvLoaiPhong.DataSource = dtLoaiPhong;

                mdgvLoaiPhong.AutoResizeColumns();

                this.mTxtMaLoaiPhong.ResetText();
                this.mTxtTenLoaiPhong.ResetText();
                this.mTxtMoTa.ResetText();
                this.mTxtGiaPhong.ResetText();

                this.mBtnLuu.Enabled = false;
                this.mBtnHuy.Enabled = false;

                mTxtMoTa.Enabled = false;
                mTxtTenLoaiPhong.Enabled = false;
                mTxtGiaPhong.Enabled = false;

                this.mBtnThem.Enabled = true;
                this.mBtnSua.Enabled = true;
                this.mBtnXoa.Enabled = true;
                mdgvLoaiPhong.AutoResizeColumns();
                mdgvLoaiPhong_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = mdgvLoaiPhong.CurrentCell.RowIndex;
            this.mTxtMaLoaiPhong.Text = mdgvLoaiPhong.Rows[r].Cells[0].Value.ToString();
            this.mTxtTenLoaiPhong.Text = mdgvLoaiPhong.Rows[r].Cells[1].Value.ToString();
            this.mTxtMoTa.Text = mdgvLoaiPhong.Rows[r].Cells[2].Value.ToString();
            this.mTxtGiaPhong.Text = mdgvLoaiPhong.Rows[r].Cells[3].Value.ToString();
        }

        private void mBtnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            mTxtTenLoaiPhong.Enabled = true;
            mTxtMoTa.Enabled = true;
            mTxtGiaPhong.Enabled = true;

            mTxtMaLoaiPhong.ResetText();
            mTxtTenLoaiPhong.ResetText();
            mTxtMoTa.ResetText();
            mTxtGiaPhong.ResetText();

            mTxtTenLoaiPhong.Focus();

            this.mBtnLuu.Enabled = true;
            this.mBtnHuy.Enabled = true;
        }

        private void mBtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            mTxtTenLoaiPhong.Enabled = true;
            mTxtMoTa.Enabled = true;
            mTxtGiaPhong.Enabled = true;

            this.mBtnLuu.Enabled = true;
            this.mBtnHuy.Enabled = true;
            mTxtTenLoaiPhong.Focus();
        }

        private void mBtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = mdgvLoaiPhong.CurrentCell.RowIndex;
                string strMaLoaiPhong =
                mdgvLoaiPhong.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbPhong.XoaLoaiPhong(ref err, Int32.Parse(strMaLoaiPhong));
                    if (f)
                    {
                        MessageBox.Show("Đã xóa xong!");
                        LoadData();
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
                    f = dbPhong.ThemLoaiPhong(ref err, mTxtTenLoaiPhong.Text, mTxtMoTa.Text, Convert.ToDecimal(mTxtGiaPhong.Text));
                    if (f)
                    {
                        MessageBox.Show("Đã thêm xong!");
                        LoadData();
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
                    f = dbPhong.CapNhatLoaiPhong(ref err, Int32.Parse(mTxtMaLoaiPhong.Text), 
                        mTxtTenLoaiPhong.Text, mTxtMoTa.Text, Convert.ToDecimal(mTxtGiaPhong.Text));
                    if (f)
                    {
                        MessageBox.Show("Đã cập nhật xong!");
                        LoadData();
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
            mTxtTenLoaiPhong.Enabled = false;
            mTxtMoTa.Enabled = false;
            mTxtGiaPhong.Enabled = false;

            mBtnThem.Enabled = true;
            mBtnSua.Enabled = true;
            mBtnXoa.Enabled = true;

            mBtnLuu.Enabled = false;
            mBtnHuy.Enabled = false;

            mdgvLoaiPhong_CellClick(null, null);
        }
    }
}
