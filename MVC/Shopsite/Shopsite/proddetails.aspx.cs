using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopsite
{
    public partial class proddetails : System.Web.UI.Page
    {
        string pid = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            pid = Request.QueryString["prodid"].ToString();
            binddata();

        }

        //user defined function
        public void binddata()
        {

            //Get connection string from web.config file  
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
            string str = "select * from products where prodid='" + pid + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds, "products");

            DataList1.DataSource = ds.Tables["products"];
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //get the button

            Button Button1 = (Button)sender;

            //handle it

            //  Button1.ImageUrl = ...;
            //Get the Parent witch its a DatalistItem in this case

            DataListItem item = (DataListItem)Button1.Parent;
            //find controls in the parent

            Label l = (Label)item.FindControl("lblprodid");
            // Response.Write(lpid.Text);
            string pid = l.Text;

            Label l1 = (Label)item.FindControl("Label1");
            // Response.Write(l.Text);
            string pname = l1.Text;
            Label l2 = (Label)item.FindControl("lblproddescription");
            // Response.Write(l.Text);
            string pdescription = l2.Text;
            Label l3 = (Label)item.FindControl("lblprodimage");
            // Response.Write(l.Text);
            string pimage = l3.Text;
            Label l4 = (Label)item.FindControl("lblprodprice");
            // Response.Write(l.Text);
            string pprice = l4.Text;
            string sid = Session.SessionID.ToString();
            Session["sessionid"] = sid;
            Response.Write(Session["sessionid"].ToString());

            // Response.Redirect("proddetails.aspx?prodid=" + pid);
            //Get connection string from web.config file  
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
            string str = null;
            str = "select count(*) from ctable3 where prodid='" + pid + "' and sessionid='" + Session["sessionid"].ToString() + "' ";
            SqlCommand com1 = new SqlCommand(str, con);
            con.Open();
            int r = Convert.ToInt32(com1.ExecuteScalar());
            int qty = 1;
            con.Close();

            if (r == 0)
            {
                str = "insert into ctable3 values('" + pid + "','" + pname + "','" + pdescription + "','" + pprice + "','" + pimage + "','" + Session["sessionid"].ToString() + "'," + qty + ")";
                SqlCommand command = new SqlCommand(str, con);
                con.Open();
                command.ExecuteNonQuery();
                //   Response.Write("saved");
                con.Close();
                Response.Redirect("viewcart.aspx");
            }
            else
            {
                str = "update ctable3 set quantity=quantity+1 where prodid='" + pid + "' and sessionid='" + Session["sessionid"].ToString() + "'";

                SqlCommand command = new SqlCommand(str, con);
                con.Open();
                command.ExecuteNonQuery();
                //   Response.Write("saved");
                con.Close();
                Response.Redirect("viewcart.aspx");

            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
