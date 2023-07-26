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
    public partial class viewcart : System.Web.UI.Page
    {
        string pid = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //   pid = Request.QueryString["prodid"].ToString();
            if (!Page.IsPostBack)
            {
                binddata();
            }
            //  Response.Write("pid " + pid);
        }

        public void binddata()
        {

            //Get connection string from web.config file  
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
            string sid = Session["sessionid"].ToString();
            string str1 = "select prodid,prodname,prodimage,prodprice,quantity, prodprice * quantity as totalprice from ctable3 where sessionid='" + sid + "'";

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str1, con);
            da.Fill(ds1, "ctable3");
            int gtotal = 0;
            foreach (DataRow dr in ds1.Tables["ctable3"].Rows)
            {
                gtotal = gtotal + Convert.ToInt32(dr["totalprice"].ToString());

            }
            Label6.Text = "grand total " + gtotal + " Rs.";
            DataList1.DataSource = ds1.Tables["ctable3"];
            DataList1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");

        }
    }
}