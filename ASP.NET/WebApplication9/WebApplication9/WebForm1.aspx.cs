﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("name :-" + TextBox1.Text + "<br>");
            sb.Append("password :-" + TextBox2.Text + "<br>");
            sb.Append("address :-" + TextBox3.Text + "<br>");
            sb.Append("mobile no :-" + TextBox4.Text + "<br>");
            sb.Append("date of birth :-" + TextBox5.Text + "<br>");
            if (RadioButton1.Checked)
                sb.Append("gender  :-" + RadioButton1.Text + "<br>");
            else if (RadioButton2.Checked)
                sb.Append("gender  :-" + RadioButton2.Text + "<br>");
            if (CheckBox1.Checked)
                sb.Append("hobby  :-" + CheckBox1.Text + "<br>");
            if (CheckBox2.Checked)
                sb.Append("hobby :- " + CheckBox2.Text + "<br>");
            sb.Append("city  :-" + DropDownList1.Text + "<br>");

            Label1.Text = sb.ToString();

        }
    }
}