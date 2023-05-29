using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Policy;
using System.Drawing;
using static System.Windows.Forms.AxHost;

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
        //method for saving the user data into TableCourseRegDetail
        public static string saveTableCourseRegDetail(int categoryid,string fullname,int genderid)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            string query = "insert into tablecourseregdetail values(@categoryid,@fullname,@genderid)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@categoryid", categoryid);
            command.Parameters.AddWithValue("@fullname", fullname);
            command.Parameters.AddWithValue("@genderid", genderid);


            command.ExecuteNonQuery();
            conn.Close();
            return "record saved in TableCourseRegDetail";
        }
        //method for saving the user data into TableRegAddress
        static int courseid = 0;

        public static string saveTableRegAddress(int nationID,int stateID,int cityID)
        {
            SqlConnection conn = GetConnection();
            conn.Open();

            string query = "SELECT top 1  courseregid FROM TableCourseRegDetail ORDER BY courseregid DESC ";
            SqlCommand command = new SqlCommand(query, conn);
            courseid = Convert.ToInt32(command.ExecuteScalar());

            query = "insert into TableRegAddress values(@courseregid,@nationID,@stateID,@cityid)";
            command=new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@courseregid", courseid);
            command.Parameters.AddWithValue("@nationid", nationID);
            command.Parameters.AddWithValue("@stateid", stateID);
            command.Parameters.AddWithValue("@cityid", cityID);
            command.ExecuteNonQuery();
            conn.Close();
            return "record saved in tableREGAdress";

        }
        //method for saving the userdata into TableFessDetail
        public static string saveTableFeeDetail(double totalamount, double minper, double paidamount, double balamount, DateTime paiddate)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            string query = "insert into TableFeeDetail values(@courseregid,@totalamount,@minper,@paidamount,@balamount,@paiddate)";
            SqlCommand command= new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@courseregid", courseid);
            command.Parameters.AddWithValue("@totalamount", totalamount);
            command.Parameters.AddWithValue("@minper", minper);
            command.Parameters.AddWithValue("@paidamount", paidamount);
            command.Parameters.AddWithValue("@balamount", balamount);
            command.Parameters.AddWithValue("@paiddate", paiddate);

            command.ExecuteNonQuery();
            conn.Close();
            return "record saved in tablefeedetail";
        }

    }
}