using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace fen1
{
    public static class ProStore
    {
        private static string connectionString = "server=.\\SQLEXPRESS;integrated security=true; database=FendhalDb";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally { conn.Close(); }

        }
        //method for returning the product category 
        public static DataSet Gettableproductcategory()
        {
            SqlConnection con = GetConnection();
            string query = "select  * from tableproductcategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "tableproductcategory");
            return ds;
        }
        //method for returning the product name 
        public static DataSet GettableProductName(string Product_Type_Name)

        {
            SqlConnection con = GetConnection();
            string query = "select  p.productid, p.ProductName from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID  where t.Product_Type_Name=@Product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "tableProduct");
            return ds;

        }
        //method for returning the GST Detail
        public static DataSet GetGstdetails(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from tableproductgstdetails a inner join TableProductCategory b on a.Product_GST_ID=b.Product_GST_ID where Product_Type_Name=@product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "tableProductGSTDetail");
            return ds;
        }
        // methhod for returnning the price for given product
        public static DataSet GetProductprice(string product_name)
        {
            SqlConnection con = GetConnection();
            string query = "  select Product_price from TableProduct where ProductName=@Product_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_name", product_name);
            da.Fill(ds, "tableProduct");
            return ds;
            
        }
        
    }

}
