using StudentSystem.Models;
using System;
using System.Data.Entity;
namespace StudentSystem.Data
{
    public interface IApplicationDbContext
    {
        IDbSet<Category> Categories { get; set; }
        IDbSet<Course> Courses { get; set; }
        IDbSet<Mark> Marks { get; set; }
        IDbSet<Material> Materials { get; set; }
    }
}
