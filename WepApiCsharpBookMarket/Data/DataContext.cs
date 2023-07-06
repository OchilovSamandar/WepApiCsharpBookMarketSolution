using Microsoft.EntityFrameworkCore;
using WepApiCsharpBookMarket.Models;

namespace WepApiCsharpBookMarket.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
              .HasMany(u => u.Books)
              .WithOne(b => b.User);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r=> r.Users)
                .HasForeignKey(r => r.RoleId);

            modelBuilder.Entity<Role>()
                .HasMany(r => r.Permissions )
                .WithOne(p => p.Role);
        }

    }
}
