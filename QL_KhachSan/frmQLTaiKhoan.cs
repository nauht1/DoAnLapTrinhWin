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
    public partial class frmQLTaiKhoan : MetroFramework.Forms.MetroForm
    {
        DataTable dtTaiKhoan;
        DBTaiKhoan dbTaiKhoan;
        int maSo;
        public frmQLTaiKhoan()
        {
            dbTaiKhoan = new DBTaiKhoan();
            InitializeComponent();
        }

        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtTaiKhoan = new DataTable();
                dtTaiKhoan.Clear();
                dtTaiKhoan = dbTaiKhoan.LayTaiKhoanDangNhap().Tables[0];
                mdgvTaiKhoan.DataSource = dtTaiKhoan;

                mdgvTaiKhoan.AutoResizeColumns();

                mdgvTaiKhoan_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = mdgvTaiKhoan.CurrentCell.RowIndex;
            maSo = Int32.Parse(mdgvTaiKhoan.Rows[r].Cells[0].Value.ToString());
        }

        private void mBtnReset_Click(object sender, EventArgs e)
        {
            bool f = false;
            string err = "";
            try
            {
                f = dbTaiKhoan.ResetMatKhau(ref err, maSo);
                if (f)
                {
                    MessageBox.Show("Đã reset thành công!");
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
    }
}
