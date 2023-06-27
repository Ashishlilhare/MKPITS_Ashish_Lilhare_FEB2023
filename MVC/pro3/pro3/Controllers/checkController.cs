using Microsoft.AspNetCore.Mvc;
using pro3.Models;

namespace pro3.Controllers
{
    public class checkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(check c)
        {
            if (c.tea == true)
                ViewBag.Tea = "You selected Tea";
            //ViewBag.Tea = c.tea.ToString();
            ViewBag.coffie=c.coffie.ToString();
            ViewBag.breakfast = c.breakfast.ToString();
            ViewBag.grocery = c.grocery.ToString();

            return View();
        }
    }
}
