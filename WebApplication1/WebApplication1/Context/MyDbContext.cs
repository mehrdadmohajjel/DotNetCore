using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;


namespace WebApplication1.Context
{

    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        //entities
        public DbSet<Course> Courses => Set<Course>(); //CRUD
        public DbSet<Author> Authors => Set<Author>(); //CRUD
        public DbSet<Student> Students => Set<Student>(); //CRUD
        public DbSet<StudentAddress> StudentAddresses => Set<StudentAddress>(); //CRUD

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasKey(x => x.Id);
            modelBuilder.Entity<Author>().HasMany(x=>x.Courses).WithOne(x=>x.Author).HasForeignKey(x=>x.AuthorId);

            modelBuilder.Entity<Course>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            modelBuilder.Entity<StudentAddress>().HasKey(x => x.Id);

            modelBuilder.Entity<Student>().HasOne(x => x.StudentAddress)
                .WithOne(x=>x.Student).HasForeignKey<StudentAddress>(x=>x.StudentId).HasPrincipalKey<Student>(x=>x.Id);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}