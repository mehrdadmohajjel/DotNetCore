using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;


namespace WebApplication1.Context
{

    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        //entities
        public DbSet<Course> Courses => Set<Course>(); //CRUD
        public DbSet<Author> Authors => Set<Author>(); //CRUD

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().Property(x=>x.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}