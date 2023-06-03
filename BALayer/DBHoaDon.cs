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
    public class DBHoaDon
    {
        DAL db = null;
        public DBHoaDon()
        {
            db = new DAL();
        }
        public DataSet LayHoaDonDaThanhToan()
        {
            return db.ExecuteQueryDataSet("Select * from viewHoaDonDaThanhToan", CommandType.Text, null);
        }
        public DataSet LayHoaDonChuaThanhToan()
        {
            return db.ExecuteQueryDataSet("Select * from viewHoaDon", CommandType.Text, null);
        }
        public bool TaoHoaDon(ref string err, int maKhachHang, DateTime ngayThanhToan, decimal tongTien)
        {
            return db.MyExecuteNonQuery("spTaoHoaDon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maKhachHang", maKhachHang),
                new SqlParameter("@ngayThanhToan", ngayThanhToan),
                new SqlParameter("@tongTien", tongTien));
        }
    }
}
