using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Author
    {
        public long Id { get; set; }
        public List<Course> Courses { get; set; }
    }
}
