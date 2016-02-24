namespace StudentSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using StudentSystem.Services;
    using StudentSystem.Web.Infrastructure;
    using StudentSystem.Web.ViewModel;

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
            var viewModel = this.courses.GetAll().Where(x => x.IsDeleted == false).To<CourseViewModel>().ToList();

            return View(viewModel);
        }
    }
}