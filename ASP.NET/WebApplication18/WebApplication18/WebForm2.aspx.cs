using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace WebApplication18
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=fendhaldb");
        DataSet ds= new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            str = "select*from tableproduct";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds,"tableproduct");
            GridView1.DataSource = ds.Tables["tableproduct"].DefaultView; GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "insert into tableproduct values(@ProductID,@ProducttypeID,@Productname,@Product_price)";
            SqlCommand command= new SqlCommand(str, con);
            command.Parameters.AddWithValue("@ProductID", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@ProducttypeID",Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@productname", TextBox3.Text);
            command.Parameters.AddWithValue("@product_price", Convert.ToInt32(TextBox4.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved succefully";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }
    }
}