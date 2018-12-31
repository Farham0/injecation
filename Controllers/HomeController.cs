using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Filters;

namespace WebApplication2.Controllers
{

   // [CustomActionFilter] for all method of this class , there is a way to run in in whole system . 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        //[CustomActionFilter (Order =2)]   //for this action only 
        //[CustomActionFilter (Order =2)]
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
    }
}