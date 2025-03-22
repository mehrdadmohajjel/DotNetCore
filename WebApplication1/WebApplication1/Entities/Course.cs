using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities
{
    [Index(nameof(Name),nameof(Id), IsUnique = true, Name = "Multiple_Index")]
    public class Course(long Id, string Name, string Description)
    {
        [Key] public long Id { get; set; } = Id;
        public long? AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;
        public List<string> Tags { get; set; } = new();
    }
}
