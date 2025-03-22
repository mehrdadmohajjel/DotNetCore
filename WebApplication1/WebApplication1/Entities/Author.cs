using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Author
    {
        public long Id { get; set; }
        [InverseProperty(nameof(Author))]
        public List<Course> Courses { get; set; }
    }
}
