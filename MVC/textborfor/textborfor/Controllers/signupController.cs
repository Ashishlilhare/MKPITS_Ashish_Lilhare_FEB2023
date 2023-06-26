using Microsoft.AspNetCore.Mvc;
using textborfor.Models;

namespace textborfor.Controllers
{
    public class signupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(signup s)
        {
            ViewBag.username = s.Name;
            ViewBag.password = s.password;
            ViewBag.Email = s.Email;
            return View(s);
        }
    }
}
