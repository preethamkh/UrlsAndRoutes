using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomVariable(string id)
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            ViewBag.CustomVariable = id ?? "<no value>";

            //The MVC Framework compares the list of segment variables with the list of action method parameters, and if the names match, passes the values from the URL to the method.
            //I have defined the id parameter as a string, but the MVC Framework will try to convert the URL value to whatever parameter type I define.If I declared the id parameter as an int or a DateTime, then I would receive the value from the URL parsed to an instance of that type.This is an elegant and useful feature that removes the need for me to handle the conversion myself.

            return View();
        }
    }
}