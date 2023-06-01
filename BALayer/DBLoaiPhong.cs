using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace BALayer
{
    public class DBLoaiPhong
    {
        DAL db = null;
        public DBLoaiPhong()
        {
            db = new DAL();
        }
        public DataSet LayLoaiPhong()
        {
            return db.ExecuteQueryDataSet("Select * from LoaiPhong", CommandType.Text, null);
        }
    }
}
