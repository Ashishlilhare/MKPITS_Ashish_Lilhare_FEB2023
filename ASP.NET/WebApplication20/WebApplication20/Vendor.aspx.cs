using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace WebApplication20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS; integrated security=true;database=trustDB");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            str = "Select *from Vendor_mast";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Vendor_mast");
            GridView1.DataSource = ds.Tables["Vendor_mast"].DefaultView;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Vendor_mast values(@Vendor_id,@Vendor_name)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox7.Text));
            command.Parameters.AddWithValue("@Vendor_name", TextBox8.Text);
            
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record added successfully";
            TextBox7.Text = "";

            TextBox7.Focus();
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Vendor_mast set Vendor_name=@Vendor_name where Vendor_id=@Vendor_id";
            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@Vendor_name", TextBox8.Text);
            command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox7.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record modify successfully";
            TextBox7.Text = "";
            TextBox7.Focus();
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Vendor_mast where Vendor_id=@Vendor_id";
            SqlCommand command = new SqlCommand(str, con);


            command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox7.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted successfully";
            TextBox7.Text = "";
            TextBox7.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Vendor_mast where Vendor_id=@Vendor_id";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox7.Text));
            da.Fill(ds, "Vendor_mast");

            TextBox7.Text = ds.Tables["Vendor_mast"].Rows[0].ItemArray[1].ToString();
            TextBox8.Text = ds.Tables["Vendor_mast"].Rows[0].ItemArray[2].ToString();

            GridView1.DataSource = ds.Tables["Vendor_mast"].DefaultView;

            GridView1.DataBind();
        }
    }
}