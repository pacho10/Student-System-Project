﻿using StudentSystem.Models;
using System;
using System.Linq;
namespace StudentSystem.Services
{
    public interface ICategoryService
    {
        IQueryable<Category> All();

        void Add(Category category);
    }
}
