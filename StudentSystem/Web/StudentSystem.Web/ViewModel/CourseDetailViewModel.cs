namespace StudentSystem.Web.ViewModel
{
    using System.Collections.Generic;

    using StudentSystem.Models;
    using StudentSystem.Web.Infrastructure;

    public class CourseDetailViewModel : IMapFrom<Course>, IHaveCustomMappings
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public ICollection<Material> Materials { get; set; }

        public void CreateMappings(AutoMapper.IMapperConfiguration configuration)
        {
            configuration.CreateMap<Course, CourseViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}