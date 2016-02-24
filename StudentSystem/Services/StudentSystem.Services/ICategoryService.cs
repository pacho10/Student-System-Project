namespace StudentSystem.Services
{
    using System.Linq;
    using StudentSystem.Models;

    public interface ICategoryService
    {
        IQueryable<Category> All();

        void Add(Category category);
    }
}
