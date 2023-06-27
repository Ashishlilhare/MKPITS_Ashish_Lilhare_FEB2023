using Microsoft.AspNetCore.Mvc;
using pro4.Models;

namespace pro4.Controllers
{
    public class calculateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(calculate c)
        {
            ViewBag.num1 = c.num1;
            ViewBag.num2 = c.num2;
             if(c.add == true)
                {
                    c.result1 = c.num1 + c.num2;
                    ViewBag.result1 = c.result1;
                }
            if (c.substract == true)
            {
                c.result2 = c.num1 - c.num2;
                ViewBag.result2 = c.result2;
            }
            if (c.multiply == true)
            {
                c.result3 = c.num1 * c.num2;
                ViewBag.result3 = c.result3;
            }
            return View();
        }
    }
}
