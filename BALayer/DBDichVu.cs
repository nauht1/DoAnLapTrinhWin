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
    public class DBDichVu
    {
        DAL db = null;
        public DBDichVu()
        {
            db = new DAL();
        }
        public DataSet LayDichVu()
        {
            return db.ExecuteQueryDataSet("Select * from DichVu Where TrangThai <> 0", CommandType.Text, null);
        }
        public bool ThemDichVu(ref string err, string tenDichVu, string moTa, decimal giaDichVu)
        {
            return db.MyExecuteNonQuery("spThemDichVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenDichVu", tenDichVu),
                new SqlParameter("@moTa", moTa),
                new SqlParameter("@giaDichVu", giaDichVu));
        }
        public bool CapNhatDichVu(ref string err, int maDichVu, string tenDichVu, string moTa, decimal giaDichVu)
        {
            return db.MyExecuteNonQuery("spCapNhatDichVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDichVu", maDichVu),
                new SqlParameter("@tenDichVu", tenDichVu),
                new SqlParameter("@moTa", moTa),
                new SqlParameter("@giaDichVu", giaDichVu));
        }
        public bool XoaDichVu(ref string err, int maDichVu)
        {
            return db.MyExecuteNonQuery("spXoaDichVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDichVu", maDichVu));
        }
    }
}
