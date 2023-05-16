using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eample_2
{
    
        public static class DatabaseConnection
        {
        //creating a static variable
        public static string connectionString = "server=.\\SQLEXPRESS;integrated security=true;database=practice;";
            //creating a static method
            public static SqlConnection GetConnection()
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    return conn;
                }
                catch(SqlException ee) 
                {
                    return null;
                }

            }

        }

    
}
