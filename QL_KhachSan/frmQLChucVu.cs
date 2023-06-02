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
    public partial class frmQLChucVu : MetroFramework.Forms.MetroForm
    {
        DataTable dtChucVu;
        bool Them;
        DBNhanVien dbNhanVien;
        public frmQLChucVu()
        {
            dbNhanVien = new DBNhanVien();
            InitializeComponent();
        }

        private void frmQLChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtChucVu = new DataTable();
                dtChucVu.Clear();
                dtChucVu = dbNhanVien.LayChucVu();
                mdgvChucVu.DataSource = dtChucVu;

                mdgvChucVu.AutoResizeColumns();

                this.mTxtMaChucVu.ResetText();
                this.mTxtTenChucVu.ResetText();

                this.mBtnLuu.Enabled = false;
                this.mBtnHuy.Enabled = false;

                mTxtTenChucVu.Enabled = false;

                this.mBtnThem.Enabled = true;
                this.mBtnSua.Enabled = true;
                this.mBtnXoa.Enabled = true;
                mdgvChucVu.AutoResizeColumns();
                mdgvChucVu_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = mdgvChucVu.CurrentCell.RowIndex;
            this.mTxtMaChucVu.Text = mdgvChucVu.Rows[r].Cells[0].Value.ToString();
            this.mTxtTenChucVu.Text = mdgvChucVu.Rows[r].Cells[1].Value.ToString();
        }

        private void mBtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void mBtnThem_Click(object sender, EventArgs e)
        {

            mTxtTenChucVu.Enabled = true;

            mBtnSua.Enabled = false;
            mBtnXoa.Enabled = false;
            mBtnLuu.Enabled = true;
            mBtnHuy.Enabled = true;

            Them = true;

            mTxtMaChucVu.ResetText();
            mTxtTenChucVu.ResetText();

            mTxtTenChucVu.Focus();
        }

        private void mBtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            mTxtTenChucVu.Enabled = true;

            mBtnThem.Enabled = false;
            mBtnXoa.Enabled = false;
            mBtnLuu.Enabled = true;
            mBtnHuy.Enabled = true;
        }

        private void mBtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = mdgvChucVu.CurrentCell.RowIndex;
                string strMaChucVu =
                mdgvChucVu.Rows[r].Cells["MaChucVu"].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbNhanVien.XoaChucVu(ref err, Int32.Parse(strMaChucVu));
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
                    f = dbNhanVien.ThemChucVu(ref err, mTxtTenChucVu.Text);
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
                    f = dbNhanVien.CapNhatChucVu(ref err, Int32.Parse(mTxtMaChucVu.Text), mTxtTenChucVu.Text);
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
            mTxtTenChucVu.Enabled = false;

            mBtnThem.Enabled = true;
            mBtnSua.Enabled = true;
            mBtnXoa.Enabled = true;
            mBtnReload.Enabled = true;

            mBtnLuu.Enabled = false;
            mBtnHuy.Enabled = false;

            mdgvChucVu_CellClick(null, null);
        }
    }
}
