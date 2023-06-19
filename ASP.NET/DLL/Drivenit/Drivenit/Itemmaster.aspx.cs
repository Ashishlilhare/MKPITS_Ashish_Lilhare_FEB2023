using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Drivenit
{
    public partial class Itemmaster : System.Web.UI.Page
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
                query = "insert into itemmaster values(@ItemDescr,@balqty,@CreatedOn)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemDescr", TextBox1.Text);
                command.Parameters.AddWithValue("@balqty", Convert.ToInt32(TextBox2.Text));
                command.Parameters.AddWithValue("@CreatedOn", TextBox3.Text);

                con.Open();
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
    }
}