using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;


namespace WebApplication1.Context
{

    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        //entities
        public DbSet<Course> Courses => Set<Course>(); //CRUD

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}