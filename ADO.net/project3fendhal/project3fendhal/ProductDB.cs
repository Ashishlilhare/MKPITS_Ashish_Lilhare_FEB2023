using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project3fendhal
{
    public static class ProductDB
    {
        private static string connectionString = "server =.\\SQLEXPRESS;integrated security=true;database=Project3";

        public static SqlConnection Getconnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                //conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
