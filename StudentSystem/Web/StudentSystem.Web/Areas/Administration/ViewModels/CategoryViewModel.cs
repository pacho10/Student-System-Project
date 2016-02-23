using StudentSystem.Models;
using StudentSystem.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystem.Web.Areas.Administration.ViewModels
{
    public class CategoryViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }
    }
}