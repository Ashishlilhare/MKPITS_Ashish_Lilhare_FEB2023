using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Number1 = Convert.ToInt32(TextBox1.Text);
            int Number2 = Convert.ToInt32(TextBox2.Text);
            int Totalamount= Number1+ Number2;
            Label1.Text= Totalamount.ToString();
        }
    }
}