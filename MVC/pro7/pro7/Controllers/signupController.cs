using Microsoft.AspNetCore.Mvc;
using pro7.Models;

namespace pro7.Controllers
{
    public class signupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(signup s) 
        {
            ViewBag.username = s.username;
            

            return View();

        }
    }
}
