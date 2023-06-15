using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using storelibrary;
using System.Data;

namespace WebApplication20
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getvendorid();   
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = VendorClass.insertVendor_Mast(TextBox1.Text);
            Label1.Text= res;
            getvendorid();
            TextBox1.Text = "";
        }
        public void getvendorid()
        {
            int res = Convert.ToInt32(VendorClass.getVendor_id());
            res = res + 1;
            TextBox2.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res=VendorClass.updateVendor_Mast(TextBox1.Text,Convert.ToInt32(TextBox2.Text));
            Label1.Text= res;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = VendorClass.deleteVendor_Mast( Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.searcVendor_Mast(Convert.ToInt32(TextBox2.Text));
           if( ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }

        }
    }
}