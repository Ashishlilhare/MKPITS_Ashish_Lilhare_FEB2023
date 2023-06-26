using calculate.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculate.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(calculatemodel c)
        {
            int n1 = c.num1;
            int n2 = c.num2;
            int res = n1+ n2;
            ViewBag.result = res;

            return View();

        }
    }
}
