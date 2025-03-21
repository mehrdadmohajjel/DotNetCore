using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Context
{
    public class MyDbContext(DbContextOptions<MyDbContext> options):DbContext(options)
    {
        public DbSet<Course> Courses => Set<Course>();

    }
}
