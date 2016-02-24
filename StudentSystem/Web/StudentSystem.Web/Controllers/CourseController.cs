namespace StudentSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity;

    using StudentSystem.Services;
    using StudentSystem.Web.Infrastructure;
    using StudentSystem.Web.ViewModel;

    [Authorize]
    public class CourseController : BaseController
    {
        private ApplicationUserManager appManager;
        private ICourseService courses;
        private IUserService users;

        public CourseController(ICourseService courses, IUserService users, ApplicationUserManager manager)
        {
            this.courses = courses;
            this.users = users;
            this.appManager = manager;
        }

        // GET: Course
        public ActionResult Index()
        {
            var viewModel = this.courses.GetAll().Where(x => x.IsDeleted == false).To<CourseViewModel>().ToList();
            return View(viewModel);
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


        public ActionResult Join(int id = 1)
        {
            var currentUserId = this.User.Identity.GetUserId();
            //User currentUser = this.appManager.Users.FirstOrDefault(x => x.Id == currentUserId);
            //var context = new ApplicationDbContext();
            //var userManager = new UserManager<User>(new UserStore<User>(context));
            //var currentUser = userManager.FindById(currentUserId);
            var currentCourse = this.courses.GetAll().Where(x => x.Id == id).FirstOrDefault();
            currentCourse.UserId = currentUserId;
            //cu.Courses.Add(currentCourse);

            //this.users.Save();

            
            this.courses.Save();

            return Redirect("/");
        }
    }
}