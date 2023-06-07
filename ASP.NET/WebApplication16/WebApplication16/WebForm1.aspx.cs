using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = new HttpCookie("cook1");
            cookie1.Values.Add("username",TextBox1.Text);
            Response.Cookies.Add(cookie1);
            Label1.Text = "Temp cookie added to client machine";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = Request.Cookies["cook1"];
            if (cookie1 != null)
            {
                string name = cookie1.Values["username"].ToString();
                Label1.Text = "username :" + name;
            }
            else
            {
                Label1.Text = "no cookies exist";
            }
        }
    }
}