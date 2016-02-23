using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class Category : BaseModel<int>
    {
        private ICollection<Course> courses;

        public Category()
        {
            this.Courses = new HashSet<Course>();
        }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses 
        {
            get { return this.courses; }
            set { this.courses = value; } 
        }
    }
}
