namespace WebApplication1.Entities
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public StudentAddress StudentAddress { get; set; }
    }
}
