using Microsoft.EntityFrameworkCore;
using RelationshipsDemo.Models;

namespace RelationshipsDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Coursess { get; set; }
    }
}
