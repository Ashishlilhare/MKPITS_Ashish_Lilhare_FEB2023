using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using validationpro2.Models;

namespace validationpro2.Controllers
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
        public ActionResult StudentDetails(StudentModel sm)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = sm.Name;
                ViewBag.email = sm.Email;
                ViewBag.age = sm.Age;
                return View("Index");
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.email = "No Data";
                ViewBag.age = "No Data";
                return View("Index");
            }
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