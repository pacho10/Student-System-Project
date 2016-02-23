using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Services
{
    public class CategoryService : ICategoryService
    {
        private IDbRepository<Category> categories;

        public CategoryService(IDbRepository<Category> categories)
        {
            this.categories = categories;
        }

        public IQueryable<Category> All()
        {
            return this.categories.All();
        }

        public void Add(Category category)
        {
            this.categories.Add(category);
            this.categories.Save();
        }
    }
}
