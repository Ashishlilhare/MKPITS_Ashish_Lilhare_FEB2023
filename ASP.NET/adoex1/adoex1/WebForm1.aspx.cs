using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace adoex1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("dtable");
            DataRow dr;
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("name",typeof(string)));
            dt.Columns.Add(new DataColumn("doa",typeof(DateTime)));
            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "pranay";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "shreya";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);


            ds.Tables.Add(dt);
            GridView1.DataSource = ds.Tables["dtable"].DefaultView;
            GridView1.DataBind();



        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int tamount = Convert.ToInt32(TextBox1.Text);
            int pamount=Convert.ToInt32(TextBox2.Text);


            int ramount = tamount - pamount;
            double eamount = 0;

            if (RadioButton1.Checked)
            {
                if(ramount>0)
                {
                    Label1.Text = "please pay full amount in cash";
                }
            }
            else if(RadioButton2.Checked)
            {

                if (ramount > 0)
                {
                    eamount = ramount / 3.0;
                }
                string pname = "mouse";

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("emitable");
                DataRow dr;
                dt.Columns.Add(new DataColumn("srno", typeof(int)));
                dt.Columns.Add(new DataColumn("productname", typeof(string)));
                dt.Columns.Add(new DataColumn("emi amount", typeof(decimal)));
                for (int i = 1; i <= 3; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = i;
                    dr[1] = pname;
                    dr[2] = eamount;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
                GridView2.DataSource = ds.Tables["emitable"].DefaultView;
                GridView2.DataBind();

            }
        }
    }
}