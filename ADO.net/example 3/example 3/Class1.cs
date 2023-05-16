using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace example_3
{
    public static class Class1
        {
        //creating static variable 
        private static string connectionstring = "server=.\\SQLEXPRESS;integrated security=true;database=RAW";
        //creating static method 
        public static SqlConnection GetConnection() 
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                return conn;
            }
            catch 
            { 
                return null;
            }
            
        }
        //creating a static method to insert record into users table
        public static string stud(int rollno,string name,string course)

        {
            SqlConnection conn = GetConnection();
            //creating a insert command

            string query = "insert into stud values(@rollno,@name,@course)";
            try 
            {
                //craeting a object sqlcommand class
                SqlCommand command = new SqlCommand(query, conn);
                //defining sqlparameters
                command.Parameters.AddWithValue("@rollno", rollno);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@course", course);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record inserted successfully";

            }
            catch(Exception ee) 
            {
                return ee.ToString();
            }
            finally 
            { conn.Close(); }
        }         
    }
}
