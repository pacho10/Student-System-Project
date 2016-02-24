namespace StudentSystem.Services
{
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;

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

        public void Add(Course course)
        {
            this.courses.Add(course);
            this.courses.Save();
        }

        public void Update(Course course)
        {
            this.courses.Update(course);
            this.courses.Save();
        }

        public void Delete(Course course)
        {
            this.courses.Delete(course);
        }

        public void Save()
        {
            this.courses.Save();
        }

        public void Dispose()
        {
            this.courses.Dispose();
        }
    }
}
