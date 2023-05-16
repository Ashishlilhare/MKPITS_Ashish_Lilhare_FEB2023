using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace connection_insert
{
    //creating a static class
    public static class DatabaseConnection 
    {
        //creating a static variable 
        public static string connectionString = "server=.\\SQLEXPRESS;integrated security=true;database=RAW";

        //creating a static method 
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try 
            {
            conn.Open();
                return conn;
            }
            catch (SqlException ex) 
            {
                return null;
            }
        }

        //creating a stating method to insert recored into user table
        public static string Insertrecord(string username, string Password)
        {
            SqlConnection conn= GetConnection();
            //creating a insert command
            string query = "insert into login values(@username,@password)";
            //@username,@password are sql parameters
            try 
            { 
            //creating an object to creating sqlcommand class
            SqlCommand command = new SqlCommand(query,conn);
            // defining sqlparameters
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", Password);
            //exicuting a command using executenonquery method
            command.ExecuteNonQuery();
                return ("record inserted succssfully");
            }
            catch (SqlException ex) 
            {
                return ex.ToString();
            }
            finally 
            { conn.Close(); }
        }
    }
    
}
