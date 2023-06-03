using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        public bool KiemTraiKhoan(ref string err, string username, string password)
        {
            string query = "Select Count(*) from TaiKhoanDangNhap Where TenDangNhap = @username And MatKhau = @password";
            return db.MyExcuteScalar(query, CommandType.Text, ref err,
                new SqlParameter("@username", username),
                new SqlParameter("@password", password));
        }
        public int LayMaNhanVien(ref string err, string username)
        {
            string query = "SELECT MaNhanVien FROM TaiKhoanDangNhap WHERE TenDangNhap = @username";
            object result = db.ReturnObjectScalar(query, CommandType.Text, ref err,
                new SqlParameter("@username", username));

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return -1;
        }
        public int KiemTraChucVu(ref string err, int maNhanVien)
        {
            string query = "SELECT MaChucVu FROM NhanVien WHERE MaNhanVien = @maNhanVien";


            object result = db.ReturnObjectScalar(query, CommandType.Text, ref err,
                new SqlParameter("@maNhanVien", maNhanVien));

            int maChucVu = -1;

            if (result != null && result != DBNull.Value)
            {
                maChucVu = Convert.ToInt32(result);
            }

            return maChucVu;
        }
        public bool DoiMatKhau(ref string err, int maNhanVien, string matKhauCu, string matKhauMoi)
        {
            return db.MyExecuteNonQuery("spDoiMatKhau", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maNhanVien", maNhanVien),
                new SqlParameter("@matKhauCu", matKhauCu),
                new SqlParameter("@matKhauMoi", matKhauMoi));
        }
    }
}
