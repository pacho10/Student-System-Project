using StudentSystem.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Material : BaseModel<int>
    {
        public byte[] Content { get; set; }

        public string FileExtention { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
