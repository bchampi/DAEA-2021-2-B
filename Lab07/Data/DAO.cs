using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DAO
    {
        public SqlConnection conn;

        public DAO() {
            string connection = "Server=DESKTOP-96DA1NJ\\LOCAL; DataBase=School; Integrated Security=true;";
            conn = new SqlConnection(connection);
        }
    }
}
