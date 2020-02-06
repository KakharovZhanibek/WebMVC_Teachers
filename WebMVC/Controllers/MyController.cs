using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class MyController : Controller
    {

        //public ActionResult Index(string st1, string st2)
        //{
        //    ViewData["par1"] = st1 + st2;
        //    return View();            
        //}
        [HttpGet]
        public string Index(string id)
        {
            return id;
        }

        [HttpPost]
        public List<Country> PostTest(Country country)
        {
            List<Country> lst = new List<Country>();
            lst.Add(country);
            lst.Add(country);
            lst.Add(country);
            return lst;
            
        }

        [HttpPost]
        public JsonResult PostTest2(Country country)
        {
            List<Country> lst = new List<Country>();
            lst.Add(country);
            lst.Add(country);
            lst.Add(country);
            return Json(lst, JsonRequestBehavior.AllowGet); ;

        }


        public FileResult GetFile_1()
        {
            // Путь к файлу
            string file_path = Server.MapPath("~/Files/Задание.txt");
            // Тип файла - content-type
            string file_type = "application/text";
            // Имя файла - необязательно
            string file_name = "test.txt";
            return File(file_path, file_type, file_name);
        }

        public FileResult GetFile_2()
        {
            string path = Server.MapPath("~/Files/Задание.txt");
            byte[] mas = System.IO.File.ReadAllBytes(path);
            string file_type = "application/text";
            string file_name = "test.txt";
            return File(mas, file_type, file_name);
        }

        public FileResult GetFile_3()
        {
            string path = Server.MapPath("~/Files/Задание.txt");
            // Объект Stream
            FileStream fs = new FileStream(path, FileMode.Open);
            string file_type = "application/text";
            string file_name = "test.txt";
            return File(fs, file_type, file_name);
        }


    }
}