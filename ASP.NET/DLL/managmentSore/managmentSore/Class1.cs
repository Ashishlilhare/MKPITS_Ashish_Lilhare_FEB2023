using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace managmentSore
{
    public static class VendorClass
    {
        static SqlConnection con = DBconnection.getConnection();
        static string query = null;
        static SqlCommand cmd=null;
        //method to insert record in vendore table
        public static string insertVendor_Mast(string vendor_name)
        {
            string res = null;
            try
            {
                query = "insert into vendor_mast values(@vendor_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in vendor master successfully";
            }
            catch (Exception ex)
            {
                res=ex.ToString();
            }
            finally 
            { 
                con.Close(); 
            }
            return res;
        }
        //method to get vendor id 
        public static string getvendorid()
        {
            string res = null;
            try
            {
                query = "select max(vendor_id) from vendor_mast";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid=Convert.ToInt32(cmd.ExecuteScalar());

                res=vid.ToString();
            }
            catch (Exception ex) { res = ex.ToString(); }
            finally { con.Close(); }
            return res;
        }
    }
}
