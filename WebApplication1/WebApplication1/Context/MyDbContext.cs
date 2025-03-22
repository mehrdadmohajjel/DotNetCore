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
            modelBuilder.Entity<Author>().HasKey(x => x.Id);
            modelBuilder.Entity<Author>().HasMany(x=>x.Courses).WithOne(x=>x.Author).HasForeignKey(x=>x.AuthorId);

            modelBuilder.Entity<Course>().HasKey(x => x.Id);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}