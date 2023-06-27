using Microsoft.AspNetCore.Mvc;
using pro6.Models;

namespace pro6.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SignUp u)
        {
            ViewBag.username = u.username;
            ViewBag.password = u.password;
            ViewBag.email = u.email;
            ViewBag.gender = u.gender;
            ViewBag.subject1 = null;
            ViewBag.subject2 = null;
            if (u.subject1 == true)
            {
                ViewBag.subject1 = "dotnet";
            }
            if (u.subject2 == true)
            {
                ViewBag.subject2 = "java";
            }



            return View();
        }
    }
}
