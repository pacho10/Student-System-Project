namespace StudentSystem.Web.Areas.Administration.ViewModels
{
    using StudentSystem.Models;
    using StudentSystem.Web.Infrastructure;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }
    }
}