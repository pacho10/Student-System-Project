using StudentSystem.Data.Repositories;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    public interface IDbRepository
    {
        DbContext Context { get; }
        IRepository<User> Users { get; }
        IRepository<Category> Categories { get; }
        IRepository<Course> Courses { get; }
        IRepository<Material> Materials { get; }
        IRepository<Mark> Marks { get; }
        void Dispose();
        int SaveChanges();
    }
}
