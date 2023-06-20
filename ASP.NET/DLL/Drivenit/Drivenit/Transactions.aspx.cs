using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Util;


namespace Drivenit
{
    public partial class Transactions : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress;integrated security=true;database=DrivenitDB");
        SqlCommand command = null;
        string query = null;
        string res = null;



        //method to return transid 
        public string gettransid()
        {
            int res = 0;

            try
            {
                query = "select max(transid) from transactions";
                command = new SqlCommand(query, con);
                con.Open();
                int tid = Convert.ToInt32(command.ExecuteScalar());

                //res = tid.ToString();
                Response.Write("tid" + tid.ToString());
                 res = tid;
                res = res + 1;
              //  TextBox3.Text = res.ToString();
            }
            catch (Exception ex)
            {
              //  res = ex.ToString();
            }
            finally
            {
                con.Close();

            }
            return res.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            string r=    gettransid();
                TextBox3.Text = r;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Transactions values(@itemid,@transtype,@transqty,@transdate)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid",DropDownList1.SelectedValue);
                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";

                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@transtype",transt);
                command.Parameters.AddWithValue("@transqty",Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@transdate",TextBox2.Text);
                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                query = "select max(balqty) from itemmaster where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid",DropDownList1.SelectedValue);
                int bq=Convert.ToInt32(command.ExecuteScalar());
                if (transt=="I") {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }
                //updating bal qty on item master table
                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balqty",bq);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();
                Label1.Text = "record saved";
            }

            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }


        }
        
       

        static int transid = 0;
        static int oldtransqty=0;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            TextBox3.Text = GridView1.SelectedRow.Cells[1].Text;
            oldtransqty = Convert.ToInt32(TextBox1.Text);
            DateTime dd=Convert.ToDateTime( GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");
            DropDownList1.SelectedValue= GridView1.SelectedRow.Cells[1].Text;

            string res= GridView1.SelectedRow.Cells[3].Text;
            if (res == "I")
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = true;
            }
            if (res == "R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;

            }
            transid=Convert.ToInt32( GridView1.SelectedRow.Cells[1].Text);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int updatedqty = 0;
            
                Response.Write("transaction id" + transid.ToString());
                 updatedqty = Convert.ToInt32(TextBox1.Text) - oldtransqty;
            

            Response.Write("updated qty" + updatedqty.ToString());
            try
            {
                query = "update transactions set itemid=@itemid, transtype=@transtype,transqty=@transqty,transdate=@transdate where transid=@transid";
                command = new SqlCommand(query, con);

                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";

                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@transtype", transt);
                command.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@transdate", TextBox2.Text);
                command.Parameters.AddWithValue("@transid", transid);


                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                query = "select max(balqty) from itemmaster where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                Response.Write("bq " + bq.ToString());
                Response.Write("updateqty " + updatedqty.ToString());
                if(RadioButton1.Checked)
                bq = bq - updatedqty;
                if(RadioButton2.Checked)
                    bq = bq + updatedqty;

                Response.Write("<br>newupdateqty " + bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = "stock not available";
                }
                else
                {
                    //if (transt == "I")
                    //{
                    //    bq = bq - Convert.ToInt32(TextBox1.Text);
                    //}
                    //else if (transt == "R")
                    //{
                    //    bq = bq + Convert.ToInt32(TextBox1.Text);
                    //}
                    //updating bal qty on item master table
                    query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@balqty", bq);
                    command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                    command.ExecuteNonQuery();

                    Label1.Text = "record update successfully";
                }
            }

            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        //public void gettransid()
        //{
            
        //}
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from transactions where transid=@transid";
                command = new SqlCommand(query, con);
                con.Open();
                command.Parameters.AddWithValue("@transid",Convert.ToInt32(TextBox3.Text));
                // Convert.ToInt32(TextBox3.Text);

                command.ExecuteNonQuery();

                Label1.Text = "record Deleted";
            }


            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        
    }
}