using Microsoft.EntityFrameworkCore;
using WebAppiUsers.Models;

namespace WebAppiUsers.Context
{
    public class MainApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MainApplicationContext(DbContextOptions options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=.\\Database\\MainAppDb.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Seed();            
        }
    }
}
