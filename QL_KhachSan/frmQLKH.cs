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
using BALayer;
using System.Data.SqlClient;

namespace QL_KhachSan
{
    public partial class frmQLKH : MetroFramework.Forms.MetroForm
    {
        DataTable dtKhachHang = null;
        bool Them;
        DBKhachHang dbKhachHang;
        public frmQLKH()
        {
            dbKhachHang = new DBKhachHang();
            InitializeComponent();
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbKhachHang.LayKhachHang().Tables[0];
                mdgvKhachHang.DataSource = dtKhachHang;

                mdgvKhachHang.AutoResizeColumns();

                this.mTxtTenKhachHang.ResetText();
                this.mTxtDiaChi.ResetText();
                this.mTxtSDT.ResetText();

                this.mBtnLuu.Enabled = false;
                this.mBtnHuy.Enabled = false;

                mTxtTenKhachHang.Enabled = false;
                mCboGioiTinh.Enabled = false;
                mTxtDiaChi.Enabled = false;
                mTxtSDT.Enabled = false;

                this.mBtnThem.Enabled = true;
                this.mBtnSua.Enabled = true;
                mdgvKhachHang.AutoResizeColumns();
                mdgvKhachHang_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = mdgvKhachHang.CurrentCell.RowIndex;
            this.mTxtMaKhachHang.Text = mdgvKhachHang.Rows[r].Cells["MaKhachHang"].Value.ToString();
            this.mTxtTenKhachHang.Text = mdgvKhachHang.Rows[r].Cells["TenKhachHang"].Value.ToString();
            this.mCboGioiTinh.Text = mdgvKhachHang.Rows[r].Cells["GioiTinh"].Value.ToString();
            this.mTxtDiaChi.Text = mdgvKhachHang.Rows[r].Cells["DiaChi"].Value.ToString();
            this.mTxtSDT.Text = mdgvKhachHang.Rows[r].Cells["SoDienThoai"].Value.ToString();
        }

        private void mBtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void mBtnThem_Click(object sender, EventArgs e)
        {
            mTxtTenKhachHang.Enabled = true;
            mCboGioiTinh.Enabled = true;
            mTxtDiaChi.Enabled = true;
            mTxtSDT.Enabled = true;

            mBtnSua.Enabled = false;
            mBtnLuu.Enabled = true;
            mBtnHuy.Enabled = true;

            Them = true;

            mTxtMaKhachHang.ResetText();
            mTxtTenKhachHang.ResetText();
            mTxtDiaChi.ResetText();
            mTxtSDT.ResetText();
            mCboGioiTinh.SelectedIndex = -1;

            mTxtMaKhachHang.Focus();
        }

        private void mBtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            mTxtTenKhachHang.Enabled = true;
            mCboGioiTinh.Enabled = true;
            mTxtDiaChi.Enabled = true;
            mTxtSDT.Enabled = true;

            mBtnThem.Enabled = false;
            mBtnLuu.Enabled = true;
            mBtnHuy.Enabled = true;

            mdgvKhachHang_CellClick(null, null);
        }

        private void mBtnLuu_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (Them)
            {
                string err = "";
                try
                {
                    f = dbKhachHang.ThemKhachHang(ref err, mTxtTenKhachHang.Text,
                        mCboGioiTinh.SelectedItem.ToString(), mTxtDiaChi.Text, mTxtSDT.Text);
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
                    f = dbKhachHang.CapNhatKhachHang(ref err, Int32.Parse(mTxtMaKhachHang.Text),
                        mTxtTenKhachHang.Text, mCboGioiTinh.SelectedItem.ToString(), mTxtDiaChi.Text, mTxtSDT.Text);
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
            mTxtTenKhachHang.Enabled = false;
            mCboGioiTinh.Enabled = false;
            mTxtDiaChi.Enabled = false;
            mTxtSDT.Enabled = false;

            mBtnThem.Enabled = true;
            mBtnSua.Enabled = true;
            mBtnReload.Enabled = true;

            mBtnLuu.Enabled = false;
            mBtnHuy.Enabled = false;

            mdgvKhachHang_CellClick(null, null);
        }
    }
}
