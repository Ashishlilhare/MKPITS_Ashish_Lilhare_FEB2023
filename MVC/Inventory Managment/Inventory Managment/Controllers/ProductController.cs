using Inventory_Managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_Managment.Controllers
{
    public class ProductController : Controller
    {
        Inventory_managmentEntities db= new Inventory_managmentEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DisplayProduct()
        {

            return View();
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct( Product pro)
        {
            db.Products.Add(pro);
            db.SaveChanges(); 
            return View();
        }
    }
}