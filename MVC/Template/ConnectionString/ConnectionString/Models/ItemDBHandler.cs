using System.Data;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ConnectionString.Models
{
    public class ItemDBHandler
    {
        SqlConnection con;
        public void connection()
        {
            //string constr= System.Configuration.ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            string constr = "server=.\\sqlexpress;integrated security=true;database=compshopdbwithoutef";

            con = new SqlConnection(constr);  

        }
        //insert Itemmethod to insert record into itemlist table 

        public bool InsertItem(ItemModel ilist) 
        {
            connection();
            String query = "insert into itemlist values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand command = new SqlCommand(query,con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

