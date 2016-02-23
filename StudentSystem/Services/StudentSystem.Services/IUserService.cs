using StudentSystem.Models;
using System;
using System.Linq;
namespace StudentSystem.Services
{
    public interface IUserService
    {
        IQueryable<User> All();
    }
}
