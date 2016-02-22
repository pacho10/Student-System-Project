﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using StudentSystem.Models;
using StudentSystem.Data;

namespace StudentSystem.Web.Areas.Administration.Controllers
{
    public class CourseGridController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Courses_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Course> courses = db.Courses;
            DataSourceResult result = courses.ToDataSourceResult(request, course => new {
                Id = course.Id,
                Title = course.Title,
                Type = course.Type,
                CreatedOn = course.CreatedOn,
                ModifiedOn = course.ModifiedOn,
                IsDeleted = course.IsDeleted,
                DeletedOn = course.DeletedOn
            });

            return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Courses_Create([DataSourceRequest]DataSourceRequest request, Course course)
        {
            if (ModelState.IsValid)
            {
                var entity = new Course
                {
                    Title = course.Title,
                    Type = course.Type,
                    CreatedOn = course.CreatedOn,
                    ModifiedOn = course.ModifiedOn,
                    IsDeleted = course.IsDeleted,
                    DeletedOn = course.DeletedOn
                };

                db.Courses.Add(entity);
                db.SaveChanges();
                course.Id = entity.Id;
            }

            return Json(new[] { course }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Courses_Update([DataSourceRequest]DataSourceRequest request, Course course)
        {
            if (ModelState.IsValid)
            {
                var entity = new Course
                {
                    Id = course.Id,
                    Title = course.Title,
                    Type = course.Type,
                    CreatedOn = course.CreatedOn,
                    ModifiedOn = course.ModifiedOn,
                    IsDeleted = course.IsDeleted,
                    DeletedOn = course.DeletedOn
                };

                db.Courses.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(new[] { course }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Courses_Destroy([DataSourceRequest]DataSourceRequest request, Course course)
        {
            if (ModelState.IsValid)
            {
                var entity = new Course
                {
                    Id = course.Id,
                    Title = course.Title,
                    Type = course.Type,
                    CreatedOn = course.CreatedOn,
                    ModifiedOn = course.ModifiedOn,
                    IsDeleted = course.IsDeleted,
                    DeletedOn = course.DeletedOn
                };

                db.Courses.Attach(entity);
                db.Courses.Remove(entity);
                db.SaveChanges();
            }

            return Json(new[] { course }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
