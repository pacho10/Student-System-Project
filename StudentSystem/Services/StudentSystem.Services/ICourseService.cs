using StudentSystem.Models;
using System;
using System.Linq;
namespace StudentSystem.Services
{
    public interface ICourseService
    {
        IQueryable<Course> GetAll();

        Course GetById(int id);

        void Add(Course course);

        void Update(Course course);

        void Delete(Course course);

        void Save();
    }
}
