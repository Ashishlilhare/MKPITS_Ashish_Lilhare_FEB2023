using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace update_and_delete
{
    class Staticconnection
    {
        public static string connectionstring = "server=.\\SQLEXPRESS;integrated security=true;database=Employdb";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                    conn.Open();
                    return conn;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }
        public static SqlDataReader GetCity ()
        { 
            SqlConnection conn=GetConnection();
            string query = "select * from City";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch { return null; }
        }
        public static string InsertRecord(int ,string name, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into users values(@name,@password)";
            //@name and @password are sqlparameters
            try
            {

            }
    }

}
