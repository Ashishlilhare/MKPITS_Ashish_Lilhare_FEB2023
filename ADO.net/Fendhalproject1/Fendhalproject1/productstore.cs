using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.Design;
using System.Runtime.Remoting.Messaging;

namespace Fendhalproject1
{
    public static class productstore
    {
        private static string connectionString = "server=.\\SQLEXPRESS;integrated security=true;database=FendhalDb";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch(Exception ee)
            {
                return null;
            }
            finally 
            { //conn.Close();
            }
        }
        //method to return product category 
        public static DataSet GetTableProductCategory()
        { 
            SqlConnection conn = GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,conn);
            da.Fill(ds,"TableProductCategory");
            return ds;
        }
        //method to return product name from product category 
        public static DataSet GettableProductName(string Product_type_name)
        {
            SqlConnection conn = GetConnection();
            string query = "select p.productid,p.ProductName from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID  where t.Product_Type_Name = @product_type_name";

            DataSet ds= new DataSet();
            SqlDataAdapter da= new SqlDataAdapter( query,conn);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", Product_type_name);
            da.Fill(ds, "tableProduct");
            return ds;
        }
        //method to return GSTdetail for given product type
        public static DataSet GetGstDetail(string Product_type_name)
        {
            SqlConnection conn = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from tableproductGSTDetails a inner join TableProductCategory b on a.product_gst_id=b.product_gst_id where b.product_type_name=@Product_type_name";
            //string query = "select cgst,sgst,igst from tableproductGSTDetails  where product_type_name='Computer'";
            DataSet ds2= new DataSet();
            SqlDataAdapter da1= new SqlDataAdapter(query,conn);
            da1.SelectCommand.Parameters.AddWithValue("@Product_type_name", Product_type_name);
            da1.Fill(ds2, "tableproductGSTDetail");
            return ds2;  
        }
        //method to return product price for given product_name
        public static DataSet GetProductprice(string Product_name) 
        {
            SqlConnection conn = GetConnection();
            string query = "  select Product_price from TableProduct where ProductName=@Product_name"; 
            DataSet ds1= new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_name", Product_name);
            da.Fill(ds1, "tableproduct");
            return ds1;
        }
        //method to save record inside invoice table
        public static string saveTableInvoiceDetails1(string Customer_Name, string Customer_Contact, int Product_Category_ID, int Product_ID,int Residential_type_ID,DateTime Invoice_Date,decimal Quantity,decimal price,decimal CGST,decimal SGST,decimal IGST,decimal CGST_value,decimal SGST_value, decimal IGST_value,decimal Total_Amount)
        {
            string result = null;

            string query = "insert into TableInvoiceDetails1 values(@Customer_Name, @Customer_Contact, @Product_Category_ID, @Product_ID, @Residential_type_ID, @Invoice_Date, @Quantity, @price, @CGST,@SGST,@IGST,@CGST_value,@SGST_value,@IGST_value,@Total_Amount)";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(query,conn);
            command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
            command.Parameters.AddWithValue("@Customer_Contact", Customer_Contact);
            command.Parameters.AddWithValue("@Product_Category_ID", Product_Category_ID);
            command.Parameters.AddWithValue("@Product_ID", Product_ID);
            command.Parameters.AddWithValue("@Residential_type_ID", Residential_type_ID);
            command.Parameters.AddWithValue("@Invoice_Date", Invoice_Date);
            command.Parameters.AddWithValue("@Quantity",Quantity);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@CGST",CGST);
            command.Parameters.AddWithValue("@SGST", SGST);
            command.Parameters.AddWithValue("@IGST", IGST);
            command.Parameters.AddWithValue("@CGST_value", CGST_value);
            command.Parameters.AddWithValue("@SGST_value", SGST_value);
            command.Parameters.AddWithValue("@IGST_value", IGST_value);
            command.Parameters.AddWithValue("@Total_Amount", Total_Amount);

            try
            {
                command.ExecuteNonQuery();
                result=("record saved sussefully");
            }
            catch (Exception ex)
            {
                result=(ex.ToString());
            }
            finally 
            { 
                conn.Close();
            }
                return result;
        }
        

    }
}
