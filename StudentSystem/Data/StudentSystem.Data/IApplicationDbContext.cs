﻿namespace StudentSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using StudentSystem.Models;

    public interface IApplicationDbContext : IDisposable
    {
        int SaveChanges();
        IDbSet<Category> Categories { get; set; }
        IDbSet<Course> Courses { get; set; }
        IDbSet<Mark> Marks { get; set; }
        IDbSet<Material> Materials { get; set; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
