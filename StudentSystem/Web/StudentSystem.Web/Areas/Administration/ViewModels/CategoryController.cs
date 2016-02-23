using StudentSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentSystem.Models;

namespace StudentSystem.Web.Areas.Administration.ViewModels
{
    public class CategoryController : Controller
    {
        private ICategoryService categories;

        public CategoryController(ICategoryService categories)
        {
            this.categories = categories;
        }

        // GET: Administration/Category
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newCategory = new Category()
                {
                    Name = model.Name
                };

                this.categories.Add(newCategory);

                return Redirect("~/Home/Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}