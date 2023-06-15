using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace storelibrary
{
    internal static class DbConnection
    {
        public static SqlConnection con;
        public static SqlConnection getConnection()
        {
            con= new SqlConnection("server=.\\sqlexpress;integrated security=true;database=trustdb1");
           
            return con;
        }

    }
}
