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
using MetroFramework;

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

                mTxtTenNhanVien.Enabled = false;
                mCboChucVu.Enabled = false;
                mCboGioiTinh.Enabled = false;
                mTxtDiaChi.Enabled = false;
                mTxtSDT.Enabled = false;

                this.mBtnThem.Enabled = true;
                this.mBtnSua.Enabled = true;
                this.mBtnXoa.Enabled = true;
                mdgvNhanVien.AutoResizeColumns();
                mdgvNhanVien_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = mdgvNhanVien.CurrentCell.RowIndex;
            this.mTxtMaNhanVien.Text = mdgvNhanVien.Rows[r].Cells["MaNhanVien"].Value.ToString();
            this.mTxtTenNhanVien.Text = mdgvNhanVien.Rows[r].Cells["TenNhanVien"].Value.ToString();
            this.mCboChucVu.SelectedValue = mdgvNhanVien.Rows[r].Cells["ChucVu"].Value;
            this.mCboGioiTinh.Text = mdgvNhanVien.Rows[r].Cells["GioiTinh"].Value.ToString();
            this.mTxtDiaChi.Text = mdgvNhanVien.Rows[r].Cells["DiaChi"].Value.ToString();
            this.mTxtSDT.Text = mdgvNhanVien.Rows[r].Cells["SoDienThoai"].Value.ToString();
        }

        private void mBtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void mBtnThem_Click(object sender, EventArgs e)
        {
            mTxtTenNhanVien.Enabled = true;
            mCboChucVu.Enabled = true;
            mCboGioiTinh.Enabled = true;
            mTxtDiaChi.Enabled = true;
            mTxtSDT.Enabled = true;

            mBtnSua.Enabled = false;
            mBtnXoa.Enabled = false;
            mBtnLuu.Enabled = true;
            mBtnHuy.Enabled = true;

            Them = true;

            mTxtMaNhanVien.ResetText();
            mTxtTenNhanVien.ResetText();
            mTxtDiaChi.ResetText();
            mTxtSDT.ResetText();
            mCboChucVu.SelectedIndex = -1;
            mCboGioiTinh.SelectedIndex = -1;

            mTxtMaNhanVien.Focus();

        }

        private void mBtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            mTxtTenNhanVien.Enabled = true;
            mCboChucVu.Enabled = true;
            mCboGioiTinh.Enabled = true;
            mTxtDiaChi.Enabled = true;
            mTxtSDT.Enabled = true;

            mBtnThem.Enabled = false;
            mBtnXoa.Enabled = false;
            mBtnLuu.Enabled = true;
            mBtnHuy.Enabled = true;
        }

        private void mBtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = mdgvNhanVien.CurrentCell.RowIndex;
                string strMaNV =
                mdgvNhanVien.Rows[r].Cells["MaNhanVien"].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbNhanVien.XoaNhanVien(ref err, Int32.Parse(strMaNV));
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
                    f = dbNhanVien.ThemNhanVien(ref err, mCboChucVu.SelectedIndex + 1, mTxtTenNhanVien.Text, 
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
                    f = dbNhanVien.CapNhatNhanVien(ref err, Int32.Parse(mTxtMaNhanVien.Text), mCboChucVu.SelectedIndex + 1, 
                        mTxtTenNhanVien.Text, mCboGioiTinh.SelectedItem.ToString(),mTxtDiaChi.Text, mTxtSDT.Text);
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
            mTxtTenNhanVien.Enabled = false;
            mCboChucVu.Enabled = false;
            mCboGioiTinh.Enabled = false;
            mTxtDiaChi.Enabled = false;
            mTxtSDT.Enabled = false;

            mBtnThem.Enabled = true;
            mBtnSua.Enabled = true;
            mBtnXoa.Enabled = true;
            mBtnReload.Enabled = true;

            mBtnLuu.Enabled = false;
            mBtnHuy.Enabled = false;
            
            mdgvNhanVien_CellClick(null, null);
        }
    }
}
