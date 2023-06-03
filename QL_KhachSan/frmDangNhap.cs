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
    public partial class frmDangNhap : MetroFramework.Forms.MetroForm
    {
        public static int maNhanVien;
        private string username;
        private string password;
        DBTaiKhoan dbTaiKhoan;
        public frmDangNhap()
        {
            dbTaiKhoan = new DBTaiKhoan();
            InitializeComponent();
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked)
                mTxtMatKhau.PasswordChar = '\0';
            else
                mTxtMatKhau.PasswordChar = '*';
        }

        private void mBtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mBtnDangNhap_Click(object sender, EventArgs e)
        {
            bool f;
            username = mTxtTaiKhoan.Text;
            password = mTxtMatKhau.Text;
            string err = "";
            try
            {
                f = dbTaiKhoan.KiemTraiKhoan(ref err, username, password);
                if (f)
                {
                    frmMain frm = new frmMain();
                    maNhanVien = dbTaiKhoan.LayMaNhanVien(ref err, username);
                    if (maNhanVien != -1)
                    {
                        int maChucVu = dbTaiKhoan.KiemTraChucVu(ref err, maNhanVien);
                        if (maChucVu != -1)
                        {
                            if (maChucVu == 3)
                            {
                                frm.TileTaiKhoan.Visible = false;
                                frm.titleChucVu.Visible = false;
                                frm.titleNhanVien.Visible = false;
                            }
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        } 
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai rồi!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Đăng nhập thất bại!!\n\r" + "Lỗi:" + err);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            mTxtTaiKhoan.Focus();
        }
    }
}
