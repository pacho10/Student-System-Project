using StudentSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService categories;

        public HomeController(ICategoryService categories)
        {
            this.categories = categories;
        }

        public ActionResult Index()
        {
            
            return View();
        }
    }
}