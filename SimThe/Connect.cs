using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SimThe
{
    class Connect
    {
        public SqlConnection connect()
        {
            string con_str = $"Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS ; Initial Catalog = SimTheCS ; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            return conn;
        } 
    }
}
