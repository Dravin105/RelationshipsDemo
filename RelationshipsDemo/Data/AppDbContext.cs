using Microsoft.EntityFrameworkCore;
using RelationshipsDemo.Models;
using RelationshipsDemo.OneToOneRelationShipModel;

namespace RelationshipsDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Coursess { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profiles> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profiles)
                .WithOne(p => p.User)
                .HasForeignKey<Profiles>(u => u.UserId);

        }

    }
}
