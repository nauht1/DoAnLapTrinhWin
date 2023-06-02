using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DBLayer;

namespace BALayer
{
    public class DBNhanVien
    {
        DAL db = null;
        public DBNhanVien()
        {
            db = new DAL();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("Select * from NhanVien", CommandType.Text, null);
        }
        public DataTable LayChucVu()
        {
            SqlDataAdapter da = db.ReturnDataAdapter("SELECT * FROM ChucVu");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool XoaChucVu(ref string err, int maChucVu) 
        {
            return db.MyExecuteNonQuery("spXoaChucVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maChucVu", maChucVu));
        }
        public bool ThemChucVu(ref string err, string tenChucVu)
        {
            return db.MyExecuteNonQuery("spThemChucVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenChucVu", tenChucVu));
        }
        public bool CapNhatChucVu(ref string err, int maChucVu, string tenChucVu)
        {
            return db.MyExecuteNonQuery("spCapNhatChucVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maChucVu", maChucVu),
                new SqlParameter("@tenChucVu", tenChucVu));
        }
        public bool ThemNhanVien(ref string err, int maChucVu, string tenNhanVien, 
            string gioiTinh, string diaChi, string soDienThoai)
        {
            return db.MyExecuteNonQuery("spThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maChucVu", maChucVu),
                new SqlParameter("@tenNhanVien", tenNhanVien),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@soDienThoai", soDienThoai));
        }
        public bool CapNhatNhanVien(ref string err, int maNhanVien, int maChucVu, string tenNhanVien,
            string gioiTinh, string diaChi, string soDienThoai)
        {
            return db.MyExecuteNonQuery("spCapNhatNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maNhanVien", maNhanVien),
                new SqlParameter("@maChucVu", maChucVu),
                new SqlParameter("@tenNhanVien", tenNhanVien),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@soDienThoai", soDienThoai));
        }
        public bool XoaNhanVien(ref string err, int maNhanVien)
        {
            return db.MyExecuteNonQuery("spXoaNhanVien", CommandType.StoredProcedure, 
                ref err, new SqlParameter("@maNhanVien", maNhanVien));
        }
    }
}
