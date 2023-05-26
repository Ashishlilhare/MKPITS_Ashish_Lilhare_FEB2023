using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projectfendhal1
{
    public static class Class_DB
    {
        private static string connectionString=("server = .\\SQLEXPRESS; integrated security=true;database=Project2");

        public static SqlConnection GetConnection( )
        {
            try
            {
                SqlConnection conn=new SqlConnection(connectionString);
                return conn;
            } 
            catch (Exception ex) 
            {
                return null;
            }
        }
        public static DataSet GetNation()
        {
            string query = "select * from TableNation";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "TableNation");
            return ds;

        }
        public static DataSet GetState(string NationaName) 
        {
            string query = "select s.stateID,s.StateName from tableState s inner join tableNation n on s.NationID=n.NationID where n.NationaName =@NationaName ";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter( query, conn);
            da.SelectCommand.Parameters.AddWithValue("@NationaName", NationaName);
            da.Fill(ds, "tableState");
            return ds;
        }
        public static DataSet GetCity(string StateName)
        {
            string query = "select c.cityID,c.cityname from tablecity c inner join tableState s on c.stateID=s.stateID where s.statename=@statename ";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds, "tablecity");
            return ds;

        } 

    }
}