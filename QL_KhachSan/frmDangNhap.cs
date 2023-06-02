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
    public partial class frmDangNhap : MetroFramework.Forms.MetroForm
    {
        public static int maNhanVien;
        private string username;
        private string password;
        public frmDangNhap()
        {
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
            username = mTxtTaiKhoan.Text;
            password = mTxtMatKhau.Text;

        }
    }
}
