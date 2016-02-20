using StudentSystem.Models;
using StudentSystem.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystem.Web.ViewModel
{
    public class CourseDetailViewModel : IMapFrom<Course>
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public ICollection<Material> Materials { get; set; }
    }
}