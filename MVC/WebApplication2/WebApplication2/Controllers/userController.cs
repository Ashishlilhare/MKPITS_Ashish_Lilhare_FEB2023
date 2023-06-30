using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class userController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
