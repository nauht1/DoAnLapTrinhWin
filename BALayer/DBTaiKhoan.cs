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
    public class DBTaiKhoan
    {
        DAL db = null;
        public DBTaiKhoan()
        {
            db = new DAL();
        }
        public DataSet LayTaiKhoanDangNhap()
        {
            return db.ExecuteQueryDataSet("Select * from TaiKhoanDangNhap", CommandType.Text, null);
        }
        public bool ResetMatKhau(ref string err, int maSo)
        {
            return db.MyExecuteNonQuery("Update TaiKhoanDangNhap Set MatKhau = '123456' Where MaSo = @maSo", 
                CommandType.Text, ref err,
                new SqlParameter("@maSo", maSo));
        }
    }
}
