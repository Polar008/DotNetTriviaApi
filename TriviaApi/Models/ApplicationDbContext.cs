using Microsoft.EntityFrameworkCore;

namespace TriviaApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<User>()
        //        .HasMany(g => g.Games)
        //        .WithOne(u => u.User)
        //        .HasForeignKey(u => u.UserId);
        //}
    }
}
