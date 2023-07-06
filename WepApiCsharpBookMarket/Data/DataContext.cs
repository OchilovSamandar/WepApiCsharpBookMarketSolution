using Microsoft.EntityFrameworkCore;
using WepApiCsharpBookMarket.Models;

namespace WepApiCsharpBookMarket.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

       
        

    }
}
