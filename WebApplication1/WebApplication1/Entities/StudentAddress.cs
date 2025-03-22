namespace WebApplication1.Entities
{
    public class StudentAddress
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long StudentId { get; set; }
        public Student Student { get; set; }
    }
}