using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(TextBox1.Text);
            int n2=Convert.ToInt32(TextBox2.Text);
            int Add = n1 + n2;
            Label1.Text=Convert.ToString(Add);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);
            int subs = n1 - n2;
            Label1.Text = Convert.ToString(subs);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);
            int Multi = n1 * n2;
            Label1.Text = Convert.ToString(Multi);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);
            int Div = n1 / n2;
            Label1.Text = Convert.ToString(Div);

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int n3 = Convert.ToInt32(TextBox3.Text);
            int n4 = Convert.ToInt32(TextBox4.Text);
            int res = 0;
            if (TextBox5.Text == "+") 
            {
                res = n3 + n4;
                Label2.Text = Convert.ToString(res);
             }
            else if (TextBox5.Text == "-")
            {
                res = n3 - n4;
                Label2.Text = Convert.ToString(res);
            }
            else if (TextBox5.Text == "*")
            {
                res = n3 * n4;
                Label2.Text = Convert.ToString(res);
            }
            else if (TextBox5.Text == "/")
            {
                res = n3 / n4;
                Label2.Text = Convert.ToString(res);
            }
            else
            {
                Label2.Text = "Invalide Oprators";
            }
        }
    }
}