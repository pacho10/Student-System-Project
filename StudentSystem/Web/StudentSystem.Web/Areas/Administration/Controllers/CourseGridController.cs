﻿namespace StudentSystem.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using Microsoft.AspNet.Identity;

    using StudentSystem.Models;
    using StudentSystem.Services;
    using StudentSystem.Web.Controllers;

    [Authorize(Roles="Administrator")]
    public class CourseGridController : BaseController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        private ICourseService courses;

        public CourseGridController(ICourseService courses)
        {
            this.courses = courses;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Courses_Read([DataSourceRequest]DataSourceRequest request)
        {
            //IQueryable<Course> courses = db.Courses;
            DataSourceResult result = this.courses.GetAll().Where(x => x.IsDeleted == false).ToDataSourceResult(request, course => new
            {
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
            var newId = 0;
            if (ModelState.IsValid)
            {
                var entity = new Course
                {
                    Title = course.Title,
                    Type = course.Type,
                    CategoryId = 1,
                    CreatedOn = course.CreatedOn,
                    ModifiedOn = course.ModifiedOn,
                    IsDeleted = course.IsDeleted,
                    DeletedOn = course.DeletedOn,
                    UserId = this.User.Identity.GetUserId()
                };

                this.courses.Add(entity);
                this.courses.Save();
                newId = entity.Id;
            }

            var courseToDisplay = this.courses.GetAll().FirstOrDefault(x => x.Id == newId);

            return Json(new[] { courseToDisplay }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Courses_Update([DataSourceRequest]DataSourceRequest request, Course course)
        {
            //if (ModelState.IsValid)
            //{
                var entity = this.courses.GetById(course.Id);
                entity.Title = course.Title;
                entity.Type = course.Type;
                entity.CreatedOn = course.CreatedOn;
                entity.ModifiedOn = course.ModifiedOn;
                entity.IsDeleted = course.IsDeleted;
                entity.DeletedOn = course.DeletedOn;
                entity.UserId = this.User.Identity.GetUserId();

                //var entity = new Course
                //{
                //    Id = course.Id,
                //    Title = course.Title,
                //    Type = course.Type,
                //    CreatedOn = course.CreatedOn,
                //    ModifiedOn = course.ModifiedOn,
                //    IsDeleted = course.IsDeleted,
                //    DeletedOn = course.DeletedOn
                //};

                this.courses.Update(entity);
            //}

            var courseToDisplay = this.courses.GetAll().FirstOrDefault(x => x.Id == course.Id);

            return Json(new[] { courseToDisplay }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Courses_Destroy([DataSourceRequest]DataSourceRequest request, Course course)
        {
            if (ModelState.IsValid)
            {
                var entityToDelete = this.courses.GetById(course.Id);
                this.courses.Delete(entityToDelete);
                this.courses.Save();

                //var entity = new Course
                //{
                //    Id = course.Id,
                //    Title = course.Title,
                //    Type = course.Type,
                //    CreatedOn = course.CreatedOn,
                //    ModifiedOn = course.ModifiedOn,
                //    IsDeleted = course.IsDeleted,
                //    DeletedOn = course.DeletedOn
                //};
            }

            return Json(new[] { course }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            this.courses.Dispose();
            base.Dispose(disposing);
        }
    }
}
