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
    public partial class frmQLPhieuDichVu : MetroFramework.Forms.MetroForm
    {
        DataTable dtKhachHang = null;
        DBKhachHang dbKhachHang;

        DataTable dtDichVu = null;
        DBDichVu dbDichVu;

        DBPhieuDichVu dbPhieuDichVu;
        public frmQLPhieuDichVu()
        {
            dbKhachHang = new DBKhachHang();
            dbDichVu = new DBDichVu();
            dbPhieuDichVu = new DBPhieuDichVu();
            InitializeComponent();
        }

        private void mdgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = mdgvKhachHang.CurrentCell.RowIndex;
            this.mTxtMaKhachHang.Text = mdgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.mTxtTenKhachHang.Text = mdgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.mTxtGioiTinh.Text = mdgvKhachHang.Rows[r].Cells[2].Value.ToString();
            this.mTxtDiaChi.Text = mdgvKhachHang.Rows[r].Cells[3].Value.ToString();
            this.mTxtSoDienThoai.Text = mdgvKhachHang.Rows[r].Cells[4].Value.ToString();

        }
        public void LoadDataKH()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbKhachHang.LayKhachHang().Tables[0];
                mdgvKhachHang.DataSource = dtKhachHang;

                this.mTxtMaKhachHang.ResetText();
                this.mTxtTenKhachHang.ResetText();
                this.mTxtGioiTinh.ResetText();
                this.mTxtDiaChi.ResetText();
                this.mTxtSoDienThoai.ResetText();
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi !!!", "Thông báo");
            }
        }
        public void LoadDataDV()
        {
            try
            {
                dtDichVu = new DataTable();
                dtDichVu.Clear();
                dtDichVu = dbDichVu.LayDichVu().Tables[0];
                mdgvDichVu.DataSource = dtDichVu;
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi !!!", "Thông báo");
            }
        }

        private void frmQLPhieuDichVu_Load(object sender, EventArgs e)
        {
            LoadDataKH();
            LoadDataDV();
        }

        private void mdgvDichVuDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mdgvDichVuDaChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                DataGridViewRow row = mdgvDichVuDaChon.Rows[i];
                row.Cells["STT"].Value = i + 1;
            }
        }

        private void mdgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mdgvDichVu.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (mdgvDichVuDaChon.DataSource == null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("STT");
                    dt.Columns.Add("MaDichVuDC");
                    dt.Columns.Add("TenDichVuDC");
                    dt.Columns.Add("GiaDichVuDC");
                    dt.Columns.Add("SoLuongDC");
                    dt.Columns.Add("ThanhTienDC");
                    mdgvDichVuDaChon.DataSource = dt;
                }
                // Lấy thông tin của dòng đó
                DataGridViewRow row = mdgvDichVu.Rows[e.RowIndex];
                int rowIndex = -1;
                foreach (DataGridViewRow r in mdgvDichVuDaChon.Rows)
                {
                    if (r.Cells["MaDichVuDC"].Value != null && r.Cells["MaDichVuDC"].Value.ToString() == row.Cells["MaDichVu"].Value.ToString())
                    {
                        rowIndex = r.Index;
                        break;
                    }
                }
                //Chưa tồn tại
                if (rowIndex == -1)
                {
                    DataRow newRow = ((DataTable)mdgvDichVuDaChon.DataSource).NewRow();
                    newRow["MaDichVuDC"] = row.Cells["MaDichVu"].Value;
                    newRow["TenDichVuDC"] = row.Cells["TenDichVu"].Value;
                    newRow["GiaDichVuDC"] = row.Cells["GiaDichVu"].Value;
                    newRow["SoLuongDC"] = 1;

                    decimal giaDichVu = Convert.ToDecimal(row.Cells["GiaDichVu"].Value);
                    decimal thanhTien = giaDichVu * 1;
                    newRow["ThanhTienDC"] = thanhTien;
                    ((DataTable)mdgvDichVuDaChon.DataSource).Rows.Add(newRow);
                }
                else 
                {
                    DataGridViewRow r = mdgvDichVuDaChon.Rows[rowIndex];
                    int soLuong = Convert.ToInt32(r.Cells["SoLuongDC"].Value);
                    soLuong++;
                    r.Cells["SoLuongDC"].Value = soLuong;

                    // Tính toán ThanhTien
                    decimal giaDichVu = Convert.ToDecimal(r.Cells["GiaDichVuDC"].Value);
                    decimal thanhTien = giaDichVu * soLuong;
                    r.Cells["ThanhTienDC"].Value = thanhTien;
                }

                mdgvDichVuDaChon.Columns["MaDichVuDC"].HeaderText = "Mã DV";
                mdgvDichVuDaChon.Columns["TenDichVuDC"].HeaderText = "Tên DV";
                mdgvDichVuDaChon.Columns["GiaDichVuDC"].HeaderText = "Giá DV";
                mdgvDichVuDaChon.Columns["SoLuongDC"].HeaderText = "Số lượng";
                mdgvDichVuDaChon.Columns["ThanhTienDC"].HeaderText = "Thành tiền";

                mdgvDichVuDaChon.Columns["MaDichVuDC"].Visible = false;

                mdgvDichVuDaChon.Columns["STT"].ReadOnly = true;
                mdgvDichVuDaChon.Columns["TenDichVuDC"].ReadOnly = true;
                mdgvDichVuDaChon.Columns["GiaDichVuDC"].ReadOnly = true;
                mdgvDichVuDaChon.Columns["ThanhTienDC"].ReadOnly = true;

                mdgvDichVuDaChon.Columns["SoLuongDC"].ReadOnly = false;
                mdgvDichVuDaChon.AutoResizeColumns();
                tinhTongTien(mdgvDichVuDaChon);

            }
        }

        private void mdgvDichVuDaChon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (mdgvDichVuDaChon.Columns[e.ColumnIndex].Name == "SoLuongDC")
            {
                DataGridViewRow row = mdgvDichVuDaChon.Rows[e.RowIndex];
                int soLuongMoi = Convert.ToInt32(row.Cells["SoLuongDC"].Value);

                decimal giaDichVu = Convert.ToDecimal(row.Cells["GiaDichVuDC"].Value);
                decimal thanhTien = giaDichVu * soLuongMoi;
                row.Cells["ThanhTienDC"].Value = thanhTien;
                tinhTongTien(mdgvDichVuDaChon);
            }
        }
        public void tinhTongTien(DataGridView mdgvDichVuDaChon)
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in mdgvDichVuDaChon.Rows)
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

        private void mBtnXoa_Click(object sender, EventArgs e)
        {
            if (mdgvDichVuDaChon.SelectedCells.Count > 0)
            {
                int selectedRowIndex = mdgvDichVuDaChon.SelectedCells[0].OwningRow.Index;
                mdgvDichVuDaChon.Rows.RemoveAt(selectedRowIndex); // xóa dòng chứa cell được chọn
                tinhTongTien(mdgvDichVuDaChon);
            }
        }

        private void mBtnTim_Click(object sender, EventArgs e)
        {
            string sdtCanTim = mTxtSDT.Text.Trim();

            mdgvKhachHang.ClearSelection();
            mdgvKhachHang.CurrentCell = null;

            foreach (DataGridViewRow row in mdgvKhachHang.Rows)
            {
                if (row.Cells["SoDienThoai"].Value != null && row.Cells["SoDienThoai"].Value.ToString() == sdtCanTim)
                {
                    row.Selected = true;
                    mdgvKhachHang.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void mBtnHuy_Click(object sender, EventArgs e)
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
                f = dbPhieuDichVu.TaoPhieuDatDichVu(ref err, Int32.Parse(mTxtMaKhachHang.Text),
                    DateTime.Today.Date, Convert.ToDecimal(mTxtTongTien.Text));
                if (f)
                {
                    foreach (DataGridViewRow row in mdgvDichVuDaChon.Rows)
                    {
                        int maDichVu = Int32.Parse(row.Cells["MaDichVuDC"].Value.ToString());
                        int soLuong = Int32.Parse(row.Cells["SoLuongDC"].Value.ToString());
                        h = dbPhieuDichVu.ThemChiTietDichVu(ref err, maDichVu, soLuong);
                    }
                    if (h)
                    {
                        MessageBox.Show("Đã thêm xong!");
                        LoadDataKH();
                        LoadDataDV();
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

        private void mBtnReload_Click(object sender, EventArgs e)
        {
            mdgvDichVuDaChon.DataSource = null;
            this.mTxtMaKhachHang.ResetText();
            this.mTxtTenKhachHang.ResetText();
            this.mTxtGioiTinh.ResetText();
            this.mTxtDiaChi.ResetText();
            this.mTxtSoDienThoai.ResetText();
            mTxtTongTien.Text = "0";
        }
    }
}
