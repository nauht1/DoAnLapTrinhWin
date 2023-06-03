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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_KhachSan
{
    public partial class frmThongTinCaNhan : MetroFramework.Forms.MetroForm
    {
        private int maNhanVien = frmDangNhap.maNhanVien;
        DBThongTinCaNhan dbThongTinCaNhan;
        DBTaiKhoan dbTaiKhoan;
        DBNhanVien dbNhanVien;
        DataTable dtChucVu = null;
        DataTable dtThongTin = null;
        public frmThongTinCaNhan()
        {
            dbTaiKhoan = new DBTaiKhoan();
            dbThongTinCaNhan = new DBThongTinCaNhan();
            dbNhanVien = new DBNhanVien();
            InitializeComponent();
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtThongTin = dbThongTinCaNhan.LayThongTinDangNhap(maNhanVien);
                DataRow row = dtThongTin.Rows[0];
                mTxtMaNhanVien.Text = row["MaNhanVien"].ToString();
                mTxtTenNhanVien.Text = row["TenNhanVien"].ToString();
                mTxtGioiTinh.Text = row["GioiTinh"].ToString();
                mTxtDiaChi.Text = row["DiaChi"].ToString();
                mTxtSDT.Text = row["SoDienThoai"].ToString();

                dtChucVu = dbNhanVien.LayChucVu();

                int maChucVu = Convert.ToInt32(row["MaChucVu"]);

                string tenChucVu = "";
                foreach (DataRow rowChucVu in dtChucVu.Rows)
                {
                    int maChucVuGoc = Convert.ToInt32(rowChucVu["MaChucVu"]);
                    if (maChucVu == maChucVuGoc)
                    {
                        tenChucVu = rowChucVu["TenChucVu"].ToString();
                        break;
                    }
                }
                mTxtChucVu.Text = tenChucVu;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mTxtMatKhauCu.PasswordChar = '\0';
                mTxtMatKhauMoi.PasswordChar = '\0';
                mTxtXacNhanMatKhau.PasswordChar = '\0';
            }
            else
            {
                mTxtMatKhauCu.PasswordChar = '*';
                mTxtMatKhauMoi.PasswordChar = '*';
                mTxtXacNhanMatKhau.PasswordChar = '*';
            }
        }

        private void mBtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            bool f;
            string err = "";
            try
            {
                if (mTxtXacNhanMatKhau.Text == mTxtMatKhauMoi.Text)
                {
                    f = dbTaiKhoan.DoiMatKhau(ref err, maNhanVien, mTxtMatKhauCu.Text, mTxtMatKhauMoi.Text);
                    if (f)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!! Lỗi: " + err);
            }
        }
    }
}
