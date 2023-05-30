using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class DAL
    {
        string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
            "Initial Catalog = QLKhachSan; " + 
            "Integrated Security = True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DAL()
        {
            conn = new SqlConnection(sqlStringConnection);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        // Truy van ActionQuery
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct; // StoredProcedure
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery(); // Action query
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public SqlDataAdapter ReturnDataAdapter(string comm)
        {
            return new SqlDataAdapter(comm, conn);
        }
    }
}
