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
using DBLayer;
using System.Data.SqlClient;

namespace QL_KhachSan
{
    public partial class frmQLPhong : MetroFramework.Forms.MetroForm
    {
        DataTable dtPhong = null;
        DataTable dtLoaiPhong = null;
        DBPhong dbPhong;
        bool Them;
        public frmQLPhong()
        {
            dbPhong = new DBPhong();
            InitializeComponent();

        }
        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtPhong = new DataTable();
                dtPhong.Clear();
                dtPhong = dbPhong.LayTatCaCacPhong().Tables[0];
                mdgvPhong.DataSource = dtPhong;


                dtLoaiPhong = new DataTable();
                dtLoaiPhong = dbPhong.LayLoaiPhong().Tables[0];

                mCboLoaiPhong.DataSource = dtLoaiPhong;
                mCboLoaiPhong.DisplayMember = "TenLoaiPhong";
                mCboLoaiPhong.ValueMember = "MaLoaiPhong";

                (mdgvPhong.Columns["LoaiPhong"] as DataGridViewComboBoxColumn).DataSource = dtLoaiPhong;
                (mdgvPhong.Columns["LoaiPhong"] as DataGridViewComboBoxColumn).ValueMember = "MaLoaiPhong";
                (mdgvPhong.Columns["LoaiPhong"] as DataGridViewComboBoxColumn).DisplayMember = "TenLoaiPhong";


                mdgvPhong.AutoResizeColumns();

                this.mTxtMaPhong.ResetText();
                this.mTxtTenPhong.ResetText();
                this.mCboLoaiPhong.ResetText();
                this.mCboTrangThai.ResetText();

                this.mBtnLuu.Enabled = false;
                this.mBtnHuy.Enabled = false;

                mTxtTenPhong.Enabled = false;
                mCboLoaiPhong.Enabled = false;
                mCboTrangThai.Enabled = false;

                this.mBtnThem.Enabled = true;
                this.mBtnSua.Enabled = true;
                this.mBtnXoa.Enabled = true;
                mdgvPhong.AutoResizeColumns();
                mdgvPhong_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = mdgvPhong.CurrentCell.RowIndex;
            this.mTxtMaPhong.Text = mdgvPhong.Rows[r].Cells[0].Value.ToString();
            this.mCboLoaiPhong.SelectedValue = mdgvPhong.Rows[r].Cells["LoaiPhong"].Value.ToString();
            this.mTxtTenPhong.Text = mdgvPhong.Rows[r].Cells[2].Value.ToString();
            this.mCboTrangThai.Text = mdgvPhong.Rows[r].Cells[3].Value.ToString();
        }

        private void mBtnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            mTxtTenPhong.Enabled = true;
            mCboLoaiPhong.Enabled = true;
            mCboTrangThai.Enabled = true;

            mTxtMaPhong.ResetText();
            mTxtTenPhong.ResetText();
            mCboLoaiPhong.SelectedIndex = -1;
            mCboTrangThai.SelectedIndex = -1;

            mCboLoaiPhong.Focus();

            this.mBtnLuu.Enabled = true;
            this.mBtnHuy.Enabled = true;
        }

        private void mBtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            mTxtTenPhong.Enabled = true;
            mCboLoaiPhong.Enabled = true;
            mCboTrangThai.Enabled = true;

            this.mBtnLuu.Enabled = true;
            this.mBtnHuy.Enabled = true;
            mCboLoaiPhong.Focus();
        }

        private void mBtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = mdgvPhong.CurrentCell.RowIndex;
                string strMaPhong =
                mdgvPhong.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbPhong.XoaPhong(ref err, Int32.Parse(strMaPhong));
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
                    f = dbPhong.ThemPhong(ref err, mCboLoaiPhong.SelectedIndex + 1, mTxtTenPhong.Text, mCboTrangThai.SelectedItem.ToString());
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
                    f = dbPhong.CapNhatPhong(ref err, Int32.Parse(mTxtMaPhong.Text),mCboLoaiPhong.SelectedIndex + 1, 
                        mTxtTenPhong.Text, mCboTrangThai.SelectedItem.ToString());
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
            mTxtTenPhong.Enabled = false;
            mCboLoaiPhong.Enabled = false;
            mCboTrangThai.Enabled = false;

            mBtnThem.Enabled = true;
            mBtnSua.Enabled = true;
            mBtnXoa.Enabled = true;

            mBtnLuu.Enabled = false;
            mBtnHuy.Enabled = false;

            mdgvPhong_CellClick(null, null);
        }
    }
}
