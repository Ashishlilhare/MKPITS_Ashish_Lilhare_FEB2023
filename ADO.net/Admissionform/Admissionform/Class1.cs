using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admissionform
{
    public static class Admissiondata
    {
        private static string connectionString = "server=.\\SQLEXPRESS;integrated security=true;database=country_data";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
               // conn.Open();
                return conn;
            }
            catch (Exception ee)
            {
                return null;
            }
        }
        //creating method to to get country name 
        public static DataSet GetTableCountry()
        {
            SqlConnection conn = GetConnection();
            string query = "Select country from sheet1$";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "Sheet1$");
            return ds;
        }
        public static DataSet GetTablestate(string country)
        {
            SqlConnection conn =GetConnection();
            string query = "  select admin_name from sheet1$ where country=@country";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@country", country);
            da.Fill(ds, "sheet1$");
            return ds;
        }
        public static DataSet GetTableCity(string admin_name)
        {
            SqlConnection conn = GetConnection();
            string query = "  select city from sheet1$ where admin_name=@admin_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@admin_name", admin_name);
            da.Fill(ds, "sheet1$");
            return ds;
        }
    }
}
