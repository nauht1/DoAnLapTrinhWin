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
    public partial class frmHoaDonThanhToan : MetroFramework.Forms.MetroForm
    {
        DataTable dtHoaDonDaThanhToan = null;
        DataTable dtHoaDonChuaThanhToan = null;
        DBHoaDon dbHoaDon;
        public frmHoaDonThanhToan()
        {
            dbHoaDon = new DBHoaDon();
            InitializeComponent();
        }

        private void frmHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            LoadHoaDonDaThanhToan();
            LoadHoaDonChuaThanhToan();
        }
        public void LoadHoaDonDaThanhToan()
        {
            try
            {
                dtHoaDonDaThanhToan = new DataTable();
                dtHoaDonDaThanhToan.Clear();
                dtHoaDonDaThanhToan = dbHoaDon.LayHoaDonDaThanhToan().Tables[0];
                mdgvHoaDonDaThanhToan.DataSource = dtHoaDonDaThanhToan;

                mdgvHoaDonDaThanhToan.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }
        public void LoadHoaDonChuaThanhToan()
        {
            try
            {
                dtHoaDonChuaThanhToan = new DataTable();
                dtHoaDonChuaThanhToan.Clear();
                dtHoaDonChuaThanhToan = dbHoaDon.LayHoaDonChuaThanhToan().Tables[0];
                mdgvHoaDonChuaThanhToan.DataSource = dtHoaDonChuaThanhToan;

                mdgvHoaDonChuaThanhToan.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mBtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mdgvHoaDonChuaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = mdgvHoaDonChuaThanhToan.CurrentCell.RowIndex;
            mTxtMaKhachHang.Text = mdgvHoaDonChuaThanhToan.Rows[r].Cells["MaKhachHang"].Value.ToString();
            mTxtTenKhachHang.Text = mdgvHoaDonChuaThanhToan.Rows[r].Cells["TenKhachHang"].Value.ToString();
            mTxtSDT.Text = mdgvHoaDonChuaThanhToan.Rows[r].Cells["SoDienThoai"].Value.ToString();
            mTxtTienPhong.Text = mdgvHoaDonChuaThanhToan.Rows[r].Cells["TienPhong"].Value.ToString();
            if (decimal.TryParse(mdgvHoaDonChuaThanhToan.Rows[r].Cells["TienDichVu"].Value.ToString(), out decimal tienDichVuValue))
            {
                mTxtTienDichVu.Text = tienDichVuValue.ToString();
            }
            else
            {
                mTxtTienDichVu.Text = "0";
            }
            mTxtTongTien.Text = (Convert.ToDecimal(mTxtTienPhong.Text) + Convert.ToDecimal(mTxtTienDichVu.Text)).ToString();
            mTxtTienThanhToan.Text = (Convert.ToDecimal(mTxtTongTien.Text) - Convert.ToDecimal(mTxtTienCoc.Text)).ToString();
        }

        private void mBtnTaoHoaDon_Click(object sender, EventArgs e)
        {
            bool f = false;
            string err = "";
            try
            {
                f = dbHoaDon.TaoHoaDon(ref err, Int32.Parse(mTxtMaKhachHang.Text),
                    DateTime.Today.Date, Convert.ToDecimal(mTxtTongTien.Text));
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                    LoadHoaDonDaThanhToan();
                    LoadHoaDonChuaThanhToan();
                }
                else
                {
                    MessageBox.Show("Thất bại!!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không tạo được. Lỗi rồi!");
            }
        }
    }
}
