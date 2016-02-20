using StudentSystem.Models;
using StudentSystem.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystem.Web.ViewModel
{
    public class MaterialViewModel : IMapFrom<Material>
    {
        public string Name { get; set; }
    }
}