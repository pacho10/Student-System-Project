namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using StudentSystem.Data.Common;

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
