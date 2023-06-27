using Microsoft.AspNetCore.Mvc;
using pro2.Models;

namespace pro2.Controllers
{
    public class resultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(result r)
        {
            int m = r.maths;
            int p = r.physics;
            int c = r.chemishtry;
            int b = r.Biology;
            int e = r.English;
            int total = m + p + c + b + e;
            ViewBag.total = total;
            //float percentage = (total /500) * 100 ;
            //ViewBag.percentage = percentage;
            //string grade = "";
            //if (percentage < 35)
            //{
            //    grade="Fail";
            //}
            //else if (percentage >= 35 && percentage <= 50)
            //{
            //   grade="Pass class";
            //}
            //else if (percentage > 50 && percentage <= 60)
            //{
            //    grade = "second class";
            //}
            //else if (percentage > 60 && percentage <= 70)
            //{
            //    grade = "first class";
            //}
            //else     //or else if(result>70)
            //{
            //    grade = "distinstion class";
            //}
            //ViewBag.grade = grade;

            //return View();
           
            float percentage = (total / 500f) * 100f;
            ViewBag.percentage = percentage;
            string grade = "";
            if (percentage < 35)
            {
                grade = "Fail";
            }
            else if (percentage >= 35 && percentage <= 50)
            {
                grade = "Pass class";
            }
            else if (percentage > 50 && percentage <= 60)
            {
                grade = "Second class";
            }
            else if (percentage > 60 && percentage <= 70)
            {
                grade = "First class";
            }
            else
            {
                grade = "Distinction class";
            }
            ViewBag.grade = grade;

            return View();

        }
    }
}
