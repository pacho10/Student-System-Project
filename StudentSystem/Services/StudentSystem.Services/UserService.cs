using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace StudentSystem.Services
{
    public class UserService : IUserService
    {
        ApplicationDbContext db = new ApplicationDbContext();

        //public UserService(IDbRepository<User>users)
        //{
        //    this.users = users;
        //}

        public IQueryable<User> All()
        {
            return this.db.Users;
        }
    }
}
