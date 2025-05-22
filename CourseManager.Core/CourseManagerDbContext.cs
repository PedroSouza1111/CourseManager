using CourseManager.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManager.Core
{
    public class CourseManagerDbContext : DbContext
    {
        public CourseManagerDbContext(DbContextOptions<CourseManagerDbContext> options)
            : base(options) { }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("COURSES");
        }
    }
}