﻿namespace StudentSystem.Web.Areas.Administration.ViewModels
{
    using System;
    using StudentSystem.Models;
    using StudentSystem.Web.Infrastructure;

    public class CourseGridViewModel : IMapFrom<Course>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public CourseType Type { get; set; }

        public string Category { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public void CreateMappings(AutoMapper.IMapperConfiguration configuration)
        {
            configuration.CreateMap<Course, CourseGridViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));

        }
    }
}