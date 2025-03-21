namespace WebApplication1.Entities
{
    public class Course(long Id,string Name,string Description)
    {
        public long Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;
    }
}
