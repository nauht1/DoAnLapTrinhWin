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
    public class DBKhachHang
    {
        DAL db = null;
        public DBKhachHang()
        {
            db = new DAL();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("Select * from KhachHang", CommandType.Text, null);
        }
        public bool ThemKhachHang(ref string err, string tenKhachHang,
            string gioiTinh, string diaChi, string soDienThoai)
        {
            return db.MyExecuteNonQuery("spThemKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenKhachHang", tenKhachHang),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@soDienThoai", soDienThoai));
        }
        public bool CapNhatKhachHang(ref string err, int maKhachHang, string tenKhachHang,
            string gioiTinh, string diaChi, string soDienThoai)
        {
            return db.MyExecuteNonQuery("spCapNhatKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maKhachHang", maKhachHang),
                new SqlParameter("@tenKhachHang", tenKhachHang),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@soDienThoai", soDienThoai));
        }
    }
}
