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
    }
}
