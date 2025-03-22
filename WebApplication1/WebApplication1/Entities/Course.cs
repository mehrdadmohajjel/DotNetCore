using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities
{
    public class Course(long Id, string Name, string Description)
    {
         public long Id { get; set; } = Id;
        public long? AuthorId { get; set; }
      
        public Author Author { get; set; }
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;
        public List<string> Tags { get; set; } = new();
    }
}
