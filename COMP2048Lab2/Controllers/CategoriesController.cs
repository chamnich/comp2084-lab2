using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2048Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(String CategoryName)
        {
            ViewBag.CategoryName = "You selected category: " + CategoryName;
            return View();
        }
    }
 
}