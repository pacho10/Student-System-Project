using StudentSystem.Services;
using StudentSystem.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentSystem.Web.Infrastructure;

namespace StudentSystem.Web.Controllers
{
    public class HomeController : BaseController
    {
        //private ICategoryService categories;
        private ICourseService courses;

        public HomeController(ICourseService courses)
        {
            //this.categories = categories;
            this.courses = courses;
        }

        public ActionResult Index()
        {
            var viewModel = this.courses.GetAll().To<CourseViewModel>().ToList();

            return View(viewModel);
        }
    }
}