using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Services
{
    public class CourseService : ICourseService
    {
        private IDbRepository<Course> courses;

        public CourseService(IDbRepository<Course> courses)
        {
            this.courses = courses;
        }

        public IQueryable<Course> GetAll()
        {
            return this.courses.All().Where(x => x.Type == CourseType.Public);
        }

        public Course GetById(int id)
        {
            return this.courses.GetById(id);
        }
    }
}
