using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Globaldev.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "This is Index action method of StudentController";
        }


        [HttpPost]
        public ActionResult PostAction()
        {
            return View("Index");
        }
    }
}