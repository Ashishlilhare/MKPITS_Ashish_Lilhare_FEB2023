using ConnectionString.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnectionString.Controllers
{
    public class itemcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // 1. *********** Add New Item ***********
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(ItemModel ilist)
        {
            if (ModelState.IsValid)
            {
                ItemDBHandler db = new ItemDBHandler();
                if (db.InsertItem(ilist))
                {
                    ViewBag.message = "item saved successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
    }
}
