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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void titleDatPhong_Click(object sender, EventArgs e)
        {
            frmQLDatPhong frmQLDatPhong = new frmQLDatPhong();
            frmQLDatPhong.ShowDialog();
        }

        private void titleQLPhong_Click(object sender, EventArgs e)
        {
            frmQLPhong frmQLPhong = new frmQLPhong();
            frmQLPhong.ShowDialog();
        }

        private void titleLoaiPhong_Click(object sender, EventArgs e)
        {
            frmQLLoaiPhong frmQLLoaiPhong = new frmQLLoaiPhong();
            frmQLLoaiPhong.ShowDialog();
        }

        private void titleNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();
            frmQLNV.ShowDialog();
        }

        private void titleKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKH frmQLKH = new frmQLKH();
            frmQLKH.ShowDialog();
        }

        private void titleDanhGia_Click(object sender, EventArgs e)
        {
            frmQLDanhGia frmQLDG = new frmQLDanhGia();
            frmQLDG.ShowDialog();
        }

        private void titleChucVu_Click(object sender, EventArgs e)
        {
            frmQLChucVu frmQLChucVu = new frmQLChucVu();
            frmQLChucVu.ShowDialog();
        }

        private void TileTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQLTaiKhoan frmQLTK = new frmQLTaiKhoan();
            frmQLTK.ShowDialog();
        }

        private void titleDichVu_Click(object sender, EventArgs e)
        {
            frmQLDichVu frmQLDV = new frmQLDichVu();
            frmQLDV.ShowDialog();
        }

        private void TitlePhieuDichVu_Click(object sender, EventArgs e)
        {
            frmQLPhieuDichVu frmQLPhieuDichVu = new frmQLPhieuDichVu();
            frmQLPhieuDichVu.ShowDialog();
        }

        private void mBtnThongTin_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan frmThongTin = new frmThongTinCaNhan();
            frmThongTin.ShowDialog();
        }

        private void mBtnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog(); 
        }
    }
}
