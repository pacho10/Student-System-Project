namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using StudentSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Roles.Any())
            {
                const string adminUsername = "admin@admin.com";
                const string adminPass = "Administrator1!";
                const string roleName = "Administrator";

                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var role = new IdentityRole { Name = roleName };
                roleManager.Create(role);

                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);
                var admin = new User { Email = adminUsername, UserName = adminUsername };
                userManager.Create(admin, adminPass);

                userManager.AddToRole(admin.Id, roleName);
            }

            if (!context.Categories.Any())
            {
                List<Category> categories = new List<Category>()
                {
                    new Category{ Name = "C# Programing", CreatedOn = DateTime.Now, IsDeleted = false },
                    new Category{ Name = "Java Programing", CreatedOn = DateTime.Now, IsDeleted = false },
                    new Category{ Name = "Windows Administration", CreatedOn = DateTime.Now, IsDeleted = false },
                    new Category{ Name = "Linyx Administration", CreatedOn = DateTime.Now, IsDeleted = false },
                    new Category{ Name = "Quality Assurance", CreatedOn = DateTime.Now, IsDeleted = false },
                };

                context.Categories.AddOrUpdate(categories.ToArray());

                List<Course> courses = new List<Course>()
                {
                    new Course{ Category = categories[0], CreatedOn = DateTime.Now, IsDeleted = false, 
                        Title = "C# Part1", Type = CourseType.Public},
                    new Course{ Category = categories[0], CreatedOn = DateTime.Now, IsDeleted = false, 
                        Title = "C# Part2", Type = CourseType.Public},
                    new Course{ Category = categories[0], CreatedOn = DateTime.Now, IsDeleted = false, 
                        Title = "C# OOP", Type = CourseType.Public},
                    new Course{ Category = categories[1], CreatedOn = DateTime.Now, IsDeleted = false, 
                        Title = "Java Basics", Type = CourseType.Public},
                    new Course{ Category = categories[1], CreatedOn = DateTime.Now, IsDeleted = false, 
                        Title = "Java Advanced", Type = CourseType.Public},
                    new Course{ Category = categories[2], CreatedOn = DateTime.Now, IsDeleted = false, 
                        Title = "Active Directory", Type = CourseType.Public},
                    new Course{ Category = categories[3], CreatedOn = DateTime.Now, IsDeleted = false, 
                        Title = "File Systems", Type = CourseType.Public},
                         new Course{ Category = categories[4], CreatedOn = DateTime.Now, IsDeleted = false, 
                        Title = "Quality Assurance Part1", Type = CourseType.Public},
                };

                context.Courses.AddOrUpdate(courses.ToArray());
                context.SaveChanges();
            }
        }
    }
}
