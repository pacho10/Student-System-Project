namespace StudentSystem.Web.ViewModel
{
    using StudentSystem.Models;
    using StudentSystem.Web.Infrastructure;

    public class MaterialViewModel : IMapFrom<Material>
    {
        public string Name { get; set; }
    }
}