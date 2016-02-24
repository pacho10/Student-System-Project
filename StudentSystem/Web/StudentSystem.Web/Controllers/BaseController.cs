namespace StudentSystem.Web.Controllers
{
    using System.Web.Mvc;

    using AutoMapper;

    using StudentSystem.Web.App_Start;

    public class BaseController : Controller
    {
       protected IMapper Mapper
        {
           get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}