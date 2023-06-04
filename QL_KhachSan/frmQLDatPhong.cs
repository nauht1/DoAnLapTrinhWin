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
using System.Globalization;
using System.Data.SqlClient;

namespace QL_KhachSan
{
    public partial class frmQLDatPhong : MetroFramework.Forms.MetroForm
    {
        bool Them;
        bool isNgayNhanPhongEdited = false;
        bool isNgayTraPhongEdited = false;
        DataTable dtPhong = null;
        DBPhong dbPhong;
        DBPhieuDatPhong dbPhieuDatPhong;
        public frmQLDatPhong()
        {
            dbPhong = new DBPhong();
            dbPhieuDatPhong = new DBPhieuDatPhong();
            InitializeComponent();
        }

        private void frmQLDatPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
        }
        public void LoadPhong()
        {
            try
            {
                dtPhong = new DataTable();
                dtPhong.Clear();
                dtPhong = dbPhong.LayPhong().Tables[0];
                mdgvPhong.DataSource = dtPhong;

                mdgvPhong.AutoResizeColumns();

            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void mdgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mdgvPhong.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (mdgvPhongDaChon.DataSource == null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("STT");
                    dt.Columns.Add("MaPhongDC");
                    dt.Columns.Add("TenPhongDC");
                    dt.Columns.Add("TenLoaiPhongDC");
                    dt.Columns.Add("GiaPhongDC");
                    dt.Columns.Add("NgayNhanDC");
                    dt.Columns.Add("NgayTraDC");
                    dt.Columns.Add("SoDemDC");
                    dt.Columns.Add("ThanhTienDC");
                    mdgvPhongDaChon.DataSource = dt;
                }
                // Lấy thông tin của dòng đó
                DataGridViewRow row = mdgvPhong.Rows[e.RowIndex];
                int rowIndex = -1;
                foreach (DataGridViewRow r in mdgvPhongDaChon.Rows)
                {
                    if (r.Cells["MaPhongDC"].Value != null && r.Cells["MaPhongDC"].Value.ToString() == row.Cells["MaPhong"].Value.ToString())
                    {
                        rowIndex = r.Index;
                        break;
                    }
                }
                //Chưa tồn tại
                if (rowIndex == -1)
                {
                    DataRow newRow = ((DataTable)mdgvPhongDaChon.DataSource).NewRow();
                    newRow["MaPhongDC"] = row.Cells["MaPhong"].Value;
                    newRow["TenPhongDC"] = row.Cells["TenPhong"].Value;
                    newRow["TenLoaiPhongDC"] = row.Cells["TenLoaiPhong"].Value;
                    newRow["GiaPhongDC"] = row.Cells["GiaPhong"].Value;

                    ((DataTable)mdgvPhongDaChon.DataSource).Rows.Add(newRow);
                }

                mdgvPhongDaChon.Columns["MaPhongDC"].HeaderText = "Mã Phòng";
                mdgvPhongDaChon.Columns["TenPhongDC"].HeaderText = "Tên phòng";
                mdgvPhongDaChon.Columns["TenLoaiPhongDC"].HeaderText = "Tên loại phòng";
                mdgvPhongDaChon.Columns["GiaPhongDC"].HeaderText = "Giá phòng";
                mdgvPhongDaChon.Columns["NgayNhanDC"].HeaderText = "Ngày nhận";
                mdgvPhongDaChon.Columns["NgayTraDC"].HeaderText = "Ngày trả";
                mdgvPhongDaChon.Columns["SoDemDC"].HeaderText = "Số đêm";
                mdgvPhongDaChon.Columns["ThanhTienDC"].HeaderText = "Thành tiền";

                mdgvPhongDaChon.Columns["MaPhongDC"].Visible = false;

                mdgvPhongDaChon.Columns["STT"].ReadOnly = true;
                mdgvPhongDaChon.Columns["TenPhongDC"].ReadOnly = true;
                mdgvPhongDaChon.Columns["TenLoaiPhongDC"].ReadOnly = true;
                mdgvPhongDaChon.Columns["GiaPhongDC"].ReadOnly = true;
                mdgvPhongDaChon.Columns["SoDemDC"].ReadOnly = true;
                mdgvPhongDaChon.Columns["ThanhTienDC"].ReadOnly = true;

                mdgvPhongDaChon.Columns["NgayNhanDC"].ReadOnly = false;
                mdgvPhongDaChon.Columns["NgayTraDC"].ReadOnly = false;
                mdgvPhongDaChon.AutoResizeColumns();

            }
        }

        private void mdgvPhongDaChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                DataGridViewRow row = mdgvPhongDaChon.Rows[i];
                row.Cells["STT"].Value = i + 1;
            }
        }
        public void tinhTongTien(DataGridView mdgvPhongDaChon)
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in mdgvPhongDaChon.Rows)
            {
                object value = row.Cells["ThanhTienDC"].Value;
                if (value != null && value != DBNull.Value)
                {
                    decimal giaPhong = Convert.ToDecimal(value);
                    tongTien += giaPhong;
                }
            }
            mTxtTongTien.Text = tongTien.ToString();
        }

        private void mdgvPhongDaChon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = mdgvPhongDaChon.CurrentCell.RowIndex;

            string columnName = mdgvPhongDaChon.Columns[e.ColumnIndex].Name;

            if (columnName == "NgayNhanDC")
            {
                isNgayNhanPhongEdited = true;
                string ngayNhanPhongStr = mdgvPhongDaChon.Rows[rowIndex].Cells["NgayNhanDC"].Value.ToString();
                DateTime ngayNhanPhong;

                // Chuyển đổi định dạng ngày
                if (DateTime.TryParseExact(ngayNhanPhongStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayNhanPhong))
                {
                    mdgvPhongDaChon.Rows[rowIndex].Cells["NgayNhanDC"].Value = ngayNhanPhong.ToString("MM/dd/yyyy");
                }
            }
            if (columnName == "NgayTraDC")
            {
                isNgayTraPhongEdited = true;
                string ngayTraPhongStr = mdgvPhongDaChon.Rows[rowIndex].Cells["NgayTraDC"].Value.ToString();
                DateTime ngayTraPhong;

                // Chuyển đổi định dạng ngày
                if (DateTime.TryParseExact(ngayTraPhongStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayTraPhong))
                {
                    mdgvPhongDaChon.Rows[rowIndex].Cells["NgayTraDC"].Value = ngayTraPhong.ToString("MM/dd/yyyy");
                }
            }

            if (isNgayNhanPhongEdited && isNgayTraPhongEdited)
            {
                int soDemValue = 1;
                decimal giaPhong = Convert.ToDecimal(mdgvPhongDaChon.Rows[rowIndex].Cells["GiaPhongDC"].Value);
                string ngayNhanPhongStr = mdgvPhongDaChon.Rows[rowIndex].Cells["NgayNhanDC"].Value.ToString();
                string ngayTraPhongStr = mdgvPhongDaChon.Rows[rowIndex].Cells["NgayTraDC"].Value.ToString();

                // Kiểm tra định dạng ngày tháng hợp lệ
                DateTime ngayNhanPhong, ngayTraPhong;
                if (DateTime.TryParse(ngayNhanPhongStr, out ngayNhanPhong) && DateTime.TryParse(ngayTraPhongStr, out ngayTraPhong))
                {
                    TimeSpan soDem = ngayTraPhong.Date - ngayNhanPhong.Date;
                    soDemValue = soDem.Days;

                    mdgvPhongDaChon.Rows[rowIndex].Cells["SoDemDC"].Value = soDemValue;
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ!");
                    mdgvPhongDaChon.Rows[rowIndex].Cells["NgayNhanDC"].Value = DateTime.Today;
                    mdgvPhongDaChon.Rows[rowIndex].Cells["NgayTraDC"].Value = DateTime.Today.AddDays(1);
                    mdgvPhongDaChon.Rows[rowIndex].Cells["SoDemDC"].Value = soDemValue;

                }
                mdgvPhongDaChon.Rows[rowIndex].Cells["ThanhTienDC"].Value = soDemValue * giaPhong;
                tinhTongTien(mdgvPhongDaChon);
                mTxtTienThanhToan.Text = (Convert.ToDecimal(mTxtTongTien.Text) - Convert.ToDecimal(mTxtTienCoc.Text)).ToString();
                isNgayNhanPhongEdited = false;
                isNgayTraPhongEdited = false;
                mBtnXacNhan.Enabled = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mBtnXacNhan_Click(object sender, EventArgs e)
        {
            bool f = false;
            bool h = false;
            string err = "";
            try
            {
                f = dbPhieuDatPhong.TaoPhieuDatPhong(ref err, mTxtTenKhachHang.Text,
                    mCboGioiTinh.SelectedItem.ToString(), mTxtDiaChi.Text, mTxtSDT.Text, DateTime.Today.Date, Convert.ToDecimal(mTxtTongTien.Text));
                if (f)
                {
                    foreach (DataGridViewRow row in mdgvPhongDaChon.Rows)
                    {
                        int maPhong = Int32.Parse(row.Cells["MaPhongDC"].Value.ToString());
                        string ngayNhanPhong = row.Cells["NgayNhanDC"].Value.ToString();
                        string ngayTraPhong = row.Cells["NgayTraDC"].Value.ToString();
                        h = dbPhieuDatPhong.ThemChiTietDatPhong(ref err, maPhong, Convert.ToDateTime(ngayNhanPhong), Convert.ToDateTime(ngayTraPhong));
                    }
                    if (h)
                    {
                        MessageBox.Show("Đã thêm xong!");
                        LoadPhong();
                    }
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

        private void mBtnXoa_Click(object sender, EventArgs e)
        {
            if (mdgvPhongDaChon.SelectedCells.Count > 0)
            {
                int selectedRowIndex = mdgvPhongDaChon.SelectedCells[0].OwningRow.Index;
                mdgvPhongDaChon.Rows.RemoveAt(selectedRowIndex); // xóa dòng chứa cell được chọn
                tinhTongTien(mdgvPhongDaChon);
                mTxtTienThanhToan.Text = (Convert.ToDecimal(mTxtTongTien.Text) - Convert.ToDecimal(mTxtTienCoc.Text)).ToString();

            }
        }

        private void mBtnReload_Click(object sender, EventArgs e)
        {
            mdgvPhongDaChon.DataSource = null;

            this.mTxtTenKhachHang.ResetText();
            this.mCboGioiTinh.SelectedIndex = -1;
            this.mTxtDiaChi.ResetText();
            this.mTxtSDT.ResetText();
        }

        private void mBtnChiTietDatPhong_Click(object sender, EventArgs e)
        {
            frmChiTietDatPhong frm = new frmChiTietDatPhong();
            frm.ShowDialog();
        }
    }
}
