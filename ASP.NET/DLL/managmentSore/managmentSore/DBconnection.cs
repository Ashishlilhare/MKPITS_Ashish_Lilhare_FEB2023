using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace managmentSore
{
    internal class DBconnection
    {
        public static SqlConnection con;

        public static SqlConnection getConnection()
        {
            con = new SqlConnection("server=.\\SQLEXPRESS; integrated security=true;database=trustdb1");
            return con;
        }
    }
}
