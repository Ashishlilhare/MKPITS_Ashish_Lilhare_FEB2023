using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace update_and_delete
{
    public static class DataConnection
    {
        //creating static variable
        private static string connectionstring= "server=.\\SQLEXPRESS;integrated security=true;database=Employdb";
        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }

        }
        //creating a static method to insert record into users table
        public static string InsertRecord(string name, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into users values(@name,@password)";
            //@name and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }

        //creating a static method to update record into users table
        public static string UpdateUser(string name, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "update users set password=@password where name=@username";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters

                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", name);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record updated successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }
        //creating a static method to delete record from users table
        public static string DeleteUsers(string name)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "delete from users  where name=@username";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters


                command.Parameters.AddWithValue("@username", name);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record deleted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }
    }
}
