using StudentSystem.Models;
using System;
using System.Linq;
namespace StudentSystem.Services
{
    public interface ICourseService
    {
        IQueryable<Course> GetAll();

        Course GetById(int id);
    }
}
