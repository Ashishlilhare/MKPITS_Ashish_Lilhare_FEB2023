using Microsoft.AspNetCore.Mvc;
using textboxexample.Models;

namespace textboxexample.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index1(Signup s)
        {
            ViewBag.username = s.Name;
            ViewBag.password = s.password;
            ViewBag.Email = s.Email;
            return View();
        }
    }
}
