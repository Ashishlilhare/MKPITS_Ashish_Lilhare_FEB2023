using Microsoft.AspNetCore.Mvc;
using pro1.Models;

namespace pro1.Controllers
{
    public class oddevenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(oddeven oe)
        {
            int num = oe.num;
            string res = "";
            if (num % 2 == 0)
            {
                res = "even";
            }
            else
            {
                res = "odd";
            }
            ViewBag.result = res;
            return View(oe);
        }
    }
}
