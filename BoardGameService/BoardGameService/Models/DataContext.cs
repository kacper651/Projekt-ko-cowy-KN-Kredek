using Microsoft.EntityFrameworkCore;

namespace BoardGameService.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardGame>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Comment>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<BoardGame>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.BoardGame)
                .HasForeignKey(x => x.BoardGameId);
        }

        public DbSet<BoardGame> Boards { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
