using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
