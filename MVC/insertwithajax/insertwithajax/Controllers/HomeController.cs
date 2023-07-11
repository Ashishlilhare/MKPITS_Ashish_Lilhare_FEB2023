using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using insertwithajax.Models;

namespace insertwithajax.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection con;
        //to handlle connection related Activities
        private void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security =true; database=MVCDb";
            con= new SqlConnection(constr);
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //Post Method to add detail
        [HttpPost]
        public ActionResult Index(EmpModel obj)
        {
            AddDetails(obj);
            return View();
        }
        private void AddDetails(EmpModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("AddEmp", con);
            //AddEmp is the name Stored Procedure
            com.Parameters.AddWithValue("@Name",obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);
            com.CommandType= CommandType.StoredProcedure;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}