using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DAOPerson: DAO
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            conn.Open();
            string sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            dt.Load(reader);
            conn.Close();

            return dt;
        }

        public DataTable SearchPerson(string input)
        {
            DataTable dt = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SearchPersonInGeneral";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@input";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = input;

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            return dt;
        }
    }
}
