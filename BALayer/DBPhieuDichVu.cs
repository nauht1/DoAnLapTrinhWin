using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBPhieuDichVu
    {
        DAL db = null;
        public DBPhieuDichVu()
        {
            db = new DAL();
        }
        public bool TaoPhieuDatDichVu(ref string err, int maKhachHang, DateTime ngaySuDung, decimal tongTien)
        {
            return db.MyExecuteNonQuery("spTaoPhieuDatDichVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maKhachHang", maKhachHang),
                new SqlParameter("@ngaySuDung", ngaySuDung),
                new SqlParameter("@tongTien", tongTien));
        }
        public bool ThemChiTietDichVu(ref string err, int maDichVu, int soLuong)
        {
            return db.MyExecuteNonQuery("spThemChiTietDichVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDichVu", maDichVu),
                new SqlParameter("@soLuong", soLuong));
        }
    }
}
