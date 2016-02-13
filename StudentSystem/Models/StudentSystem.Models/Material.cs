using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        public byte[] Content { get; set; }

        public string FileExtention { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
