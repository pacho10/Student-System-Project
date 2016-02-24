namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using StudentSystem.Data.Common;

    public class Course : BaseModel<int>
    {
        private ICollection<Material> materials;

        public Course()
        {
            this.Materials = new HashSet<Material>();
        }

        public string Title { get; set; }

        public CourseType Type { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Material> Materials 
        {
            get { return this.materials; }
            set { this.materials = value; }
        }
    }
}
