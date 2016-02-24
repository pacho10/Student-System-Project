namespace StudentSystem.Models
{
    using StudentSystem.Data.Common;

    public class Mark : BaseModel<int>
    {
        public string CourseName { get; set; }

        public int Value { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
