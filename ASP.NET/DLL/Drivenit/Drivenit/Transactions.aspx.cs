using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Drivenit
{
    public partial class Transactions : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress;integrated security=true;database=DrivenitDB");
        SqlCommand command = null;
        string query = null;

        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[5].Text;
            DropDownList1.SelectedValue= GridView1.SelectedRow.Cells[1].Text;
            RadioButton1.Text= GridView1.SelectedRow.Cells[2].Text;
            RadioButton2.Text = GridView1.SelectedRow.Cells[2].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update transactions set transtype=@transtype,transqty=@transqty,transdate=@transdate where itemid=@itemid";
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
                command.Parameters.AddWithValue("@transtype", transt);
                command.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@transdate", TextBox2.Text);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);

                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                query = "select max(balqty) from itemmaster where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }
                //updating bal qty on item master table
                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balqty", bq);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record update successfully";
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

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}