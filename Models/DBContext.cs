using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Petition> Petitions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure foreign key for News
            modelBuilder.Entity<News>()
                .HasOne(n => n.User)
                .WithMany(u => u.News)
                .HasForeignKey(n => n.Author)
                .HasPrincipalKey(u => u.Username);

            // Configure foreign key for Petition
            modelBuilder.Entity<Petition>()
                .HasOne(p => p.User)
                .WithMany(u => u.Petitions)
                .HasForeignKey(p => p.Author)
                .HasPrincipalKey(u => u.Username);

           
        }
    }
}
