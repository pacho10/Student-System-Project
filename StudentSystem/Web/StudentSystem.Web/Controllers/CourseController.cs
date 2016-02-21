using StudentSystem.Data;
using StudentSystem.Models;
using StudentSystem.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentSystem.Web.Infrastructure;
using AutoMapper.QueryableExtensions;

namespace StudentSystem.Web.Controllers
{
    public class CourseController : BaseController
    {
        private IDbRepository<Course> courses;

        public CourseController(IDbRepository<Course> courses)
        {
            this.courses = courses;
        }

        // GET: Course
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id = 1)
        {
            var course = this.courses.GetById(id);
            var viewModel = new CourseDetailViewModel
            {
                Title = course.Title,
                Category = course.Category.Name,
                Materials = course.Materials
            };

            return View(viewModel);
        }
    }
}