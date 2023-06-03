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
    public class DBThongTinCaNhan
    {
        DAL db = null;
        public DBThongTinCaNhan()
        {
            db = new DAL();
        }
        public DataTable LayThongTinDangNhap(int maNhanVien)
        {
            SqlDataAdapter da = db.ReturnDataAdapter($"SELECT * FROM NhanVien Where MaNhanVien = {maNhanVien}");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
