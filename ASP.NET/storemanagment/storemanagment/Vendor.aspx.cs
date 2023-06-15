using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using managmentSore;
using System.Data;

namespace storemanagment
{
    public partial class Vendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = VendorClass.insertVendor_Mast(TextBox1.Text);
            Label1.Text = res;
            getvendorid();
            TextBox1.Text = "";
        }
    }
}