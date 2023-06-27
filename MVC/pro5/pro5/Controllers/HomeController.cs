using Microsoft.AspNetCore.Mvc;
using pro5.Models;
using System.Diagnostics;

namespace pro5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(caltype c)
        {
            ViewBag.number1=c.number1;
            ViewBag.number2=c.number2;
            string b =c.cal.ToString();
            int result = c.result;
            if (b == "add")
            {
                result = c.number1 + c.number2;

            }
            else if (b == "sub")
            {
                result = c.number1 - c.number2;

            }
            else if (b == "multi")
            {
                result = c.number1 * c.number2;

            }
            ViewBag.res = result;

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}