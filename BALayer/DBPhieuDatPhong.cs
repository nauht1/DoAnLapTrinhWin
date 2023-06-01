using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace BALayer
{
    public class DBPhieuDatPhong
    {
        DAL db = null;
        public DBPhieuDatPhong()
        {
            db = new DAL();
        }
        public bool TaoPhieuDatPhong(ref string err, string tenKhachHang, 
            string gioiTinh, string diaChi, string soDienThoai, DateTime ngayLapPhieu, decimal tongTien)
        {
            return db.MyExecuteNonQuery("spTaoPhieuDatPhong", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenKhachHang", tenKhachHang),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@soDienThoai", soDienThoai),
                new SqlParameter("@ngayLapPhieu", ngayLapPhieu),
                new SqlParameter("@tongTien", tongTien));
        }
        public bool ThemChiTietDatPhong(ref string err, int maPhong,
            DateTime ngayNhanPhong, DateTime ngayTraPhong)
        {
            return db.MyExecuteNonQuery("spThemChiTietDatPhong", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maPhong", maPhong),
                new SqlParameter("@ngayNhanPhong", ngayNhanPhong),
                new SqlParameter("@ngayTraPhong", ngayTraPhong));
        }
    }
}
