using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class User : IdentityUser
    {
        private ICollection<Mark> marks;
        private ICollection<Course> courses;

        public User()
        {
            this.Marks = new HashSet<Mark>();
            this.Courses = new HashSet<Course>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Avatar { get; set; }

        //public DateTime CreatedOn { get; set; }

        public virtual ICollection<Mark> Marks 
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public virtual ICollection<Course> Courses 
        {
            get { return this.courses; }
            set { this.courses = value; } 
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
