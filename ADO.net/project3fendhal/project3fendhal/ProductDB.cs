using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Drawing;

namespace project3fendhal
{
    public static class ProductDB
    {
        private static string connectionString = "server =.\\SQLEXPRESS;integrated security=true;database=Project3";

        public static SqlConnection GetConnection()
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
        public static DataSet GetName()
        {
            string query = "SELECT Name FROM COMPUTER";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "COMPUTER");
            return ds;

        }
        public static DataSet GETDetails(string Name)
        {
            string query = "select * from COMPUTER where Name=@Name";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Name", Name);
            da.Fill(ds, "COMPUTER");
            return ds;
        }

    }
}
