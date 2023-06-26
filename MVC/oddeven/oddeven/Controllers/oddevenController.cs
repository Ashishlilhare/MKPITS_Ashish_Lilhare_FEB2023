using Microsoft.AspNetCore.Mvc;
using oddeven.Models;

namespace oddeven.Controllers
{
    public class oddevenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(oddevenm oe)
        {
            int num=oe.num;
            string res = "";
            if (num % 2 == 0)
            {
                res = "Even";
            }
            else
            {
                res = "Odd";
            }

            ViewBag.result = res;
            return View(oe);
        }
    }
}
