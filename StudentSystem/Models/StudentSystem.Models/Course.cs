using StudentSystem.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace StudentSystem.Models
{
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
