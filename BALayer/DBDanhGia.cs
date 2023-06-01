using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBDanhGia
    {
        DAL db = null;
        public DBDanhGia()
        {
            db = new DAL();
        }
        public DataSet LayDanhGia()
        {
            return db.ExecuteQueryDataSet("SELECT MaDanhGia, SoDienThoai, TenKhachHang, NoiDung FROM dbo.DanhGia " +
                                        "JOIN dbo.KhachHang " +
                                        "ON KhachHang.MaKhachHang = DanhGia.MaKhachHang", 
                                        CommandType.Text, null);
        }
    }
}
