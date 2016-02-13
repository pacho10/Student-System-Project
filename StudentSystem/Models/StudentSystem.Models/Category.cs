using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Category
    {
        private ICollection<Course> courses;

        public Category()
        {
            this.Courses = new HashSet<Course>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses 
        {
            get { return this.courses; }
            set { this.courses = value; } 
        }
    }
}
