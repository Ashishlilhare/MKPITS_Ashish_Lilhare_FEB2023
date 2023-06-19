using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication20
{
    public partial class Item : System.Web.UI.Page
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
            str = "Select *from item_master";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "item_master");
            GridView1.DataSource = ds.Tables["item_master"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into item_master values(@item_id,@item_name,@category,@Rate,@balance_quantity)";
            SqlCommand command =new SqlCommand(str,con);
            command.Parameters.AddWithValue("@item_id",Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@item_name", TextBox2.Text);
            command.Parameters.AddWithValue("@category", DropDownList1.Text);
            command.Parameters.AddWithValue("@Rate", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@balance_quantity", Convert.ToInt32(TextBox4.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record added successfully";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update item_master set item_name=@item_name,category=@category,Rate=@Rate,balance_quantity=@balance_quantity where item_id=@item_id";
            SqlCommand command = new SqlCommand(str, con);
            
            command.Parameters.AddWithValue("@item_name", TextBox2.Text);
            command.Parameters.AddWithValue("@category", DropDownList1.Text);
            command.Parameters.AddWithValue("@Rate", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@balance_quantity", Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("@item_id", Convert.ToInt32(TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record modify successfully";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from item_master where item_id=@item_id";
            SqlCommand command = new SqlCommand(str, con);

            
            command.Parameters.AddWithValue("@item_id", Convert.ToInt32(TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted successfully";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from item_master where item_id=@item_id";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@item_id", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "item_master");

            TextBox2.Text = ds.Tables["item_master"].Rows[0].ItemArray[1].ToString();
            DropDownList1.Text = ds.Tables["item_master"].Rows[0].ItemArray[2].ToString();
            TextBox3.Text = ds.Tables["item_master"].Rows[0].ItemArray[3].ToString();
            TextBox4.Text = ds.Tables["item_master"].Rows[0].ItemArray[4].ToString();

            GridView1.DataSource = ds.Tables["item_master"].DefaultView;

            GridView1.DataBind();
        }
    }
}