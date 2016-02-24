namespace StudentSystem.Web.ViewModel
{
    using AutoMapper;

    using StudentSystem.Models;
    using StudentSystem.Web.Infrastructure;

    public class CourseViewModel : IMapFrom<Course>, IHaveCustomMappings
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Category { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Course, CourseViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}