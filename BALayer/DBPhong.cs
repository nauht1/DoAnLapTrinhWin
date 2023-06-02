using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace BALayer
{
    public class DBPhong
    {
        DAL db = null;
        public DBPhong()
        {
            db = new DAL();
        }
        public DataSet LayPhong()
        {
            return db.ExecuteQueryDataSet("Select * from viewPhong", CommandType.Text, null);
        }
        public DataSet LayLoaiPhong()
        {
            return db.ExecuteQueryDataSet("Select * from LoaiPhong", CommandType.Text, null);
        }
        public DataSet LayTatCaCacPhong()
        {
            return db.ExecuteQueryDataSet("Select * from Phong", CommandType.Text, null);
        }
        public bool ThemLoaiPhong(ref string err, string tenLoaiPhong, string moTa, decimal giaPhong)
        {
            return db.MyExecuteNonQuery("spThemLoaiPhong", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenLoaiPhong", tenLoaiPhong),
                new SqlParameter("@moTa", moTa),
                new SqlParameter("@giaPhong", giaPhong));
        }
        public bool XoaLoaiPhong(ref string err, int maLoaiPhong)
        {
            return db.MyExecuteNonQuery("spXoaLoaiPhong", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maLoaiPhong", maLoaiPhong));
        }
        public bool CapNhatLoaiPhong(ref string err, int maLoaiPhong, string tenLoaiPhong, string moTa, decimal giaPhong)
        {
            return db.MyExecuteNonQuery("spCapNhatLoaiPhong", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maLoaiPhong", maLoaiPhong),
                new SqlParameter("@tenLoaiPhong", tenLoaiPhong),
                new SqlParameter("@moTa", moTa),
                new SqlParameter("@giaPhong", giaPhong));
        }
        public bool ThemPhong(ref string err, int maLoaiPhong, string tenPhong, string trangThai)
        {
            return db.MyExecuteNonQuery("spThemPhong", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maLoaiPhong", maLoaiPhong),
                new SqlParameter("@tenPhong", tenPhong),
                new SqlParameter("@trangThai", trangThai));
        }
        public bool CapNhatPhong(ref string err, int maPhong, int maLoaiPhong, string tenPhong, string trangThai)
        {
            return db.MyExecuteNonQuery("spCapNhatPhong", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maPhong", maPhong),
                new SqlParameter("@maLoaiPhong", maLoaiPhong),
                new SqlParameter("@tenPhong", tenPhong),
                new SqlParameter("@trangThai", trangThai));
        }
        public bool XoaPhong(ref string err, int maPhong)
        {
            return db.MyExecuteNonQuery("spXoaPhong", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maPhong", maPhong));
        }


    }
}
