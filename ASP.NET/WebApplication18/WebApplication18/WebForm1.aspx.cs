using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication18
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
            dt.Columns.Add(new DataColumn("Name",typeof(string)));
            dt.Columns.Add(new DataColumn("DOA",typeof(DateTime)));
            dr = dt.NewRow();
            dr[0] = 002;
            dr[1] = "satan";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 003;
            dr[1] = "samuel";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);

            ds.Tables.Add(dt);
            GridView1.DataSource = ds.Tables["dtable"].DefaultView;
            GridView1.DataBind();
        }
    }
}