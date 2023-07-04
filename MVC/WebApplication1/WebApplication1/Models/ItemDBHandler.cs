using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ItemDBHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            con = new SqlConnection(constring);
        }

        // 2. ********** Get All Item List **********
        //list generic class to create collection of itemmodel objects
        public List<ItemModel> GetItemList()
        {
            connection();

            List<ItemModel> iList = new List<ItemModel>();

            string query = "SELECT * FROM ItemList";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ItemModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return iList;
        }

        // 1. ********** Insert Item **********
        public bool InsertItem(ItemModel iList)
        {
            connection();
            string query = "INSERT INTO ItemList VALUES('" + iList.Name + "','" + iList.Category + "'," + iList.Price + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

    }
}