namespace StudentSystem.Models
{
    using StudentSystem.Data.Common;

    public class Material : BaseModel<int>
    {
        public string Name { get; set; }

        public byte[] Content { get; set; }

        public string FileExtention { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
