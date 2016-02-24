namespace StudentSystem.Services
{
    using System.Linq;
    using StudentSystem.Models;

    public interface ICourseService
    {
        IQueryable<Course> GetAll();

        Course GetById(int id);

        void Add(Course course);

        void Update(Course course);

        void Delete(Course course);

        void Save();

        void Dispose();
    }
}
