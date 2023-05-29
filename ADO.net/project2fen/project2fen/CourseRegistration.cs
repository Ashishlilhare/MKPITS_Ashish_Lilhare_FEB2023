using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project2fen
{
    static class CourseRegistration
    {
        public static string connectionString = "server=.\\SQLEXPRESS;integrated security=true;database=Project2";
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch(Exception ex) 
            {
                return null;
            }
        }
        public static DataSet GetNation() 
        {
            string query = "select * from TableNation";
            SqlConnection conn = GetConnection();
            DataSet ds= new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,conn);
            da.Fill(ds, "TableNation");
            return ds;
        }
        public static DataSet GetState(string NationaName) 
        {
            string query = "select s.stateID,s.statename from tablestate s inner join tablenation n on s.NationID=n.NationID where n.NationaName=@Nationaname";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,conn);
            da.SelectCommand.Parameters.AddWithValue("@NationaName", NationaName);
            da.Fill(ds,"tableState");
            return ds;
        }
    }
}
