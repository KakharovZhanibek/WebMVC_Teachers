using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult News(int? id)
        {
            Country country = new Country() { Id = 1, Name = "USA", Population = 340000000 };

            ViewBag.Data123 = "Hello world";
            ViewData["Var1"] = "Var1";

            return View();
        }

      
    }
}