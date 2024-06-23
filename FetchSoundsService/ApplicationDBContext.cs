using FetchSoundsService.Model;
using Microsoft.EntityFrameworkCore;

namespace FetchSoundsService
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Wishlist> Wishlists { get; set; }

        public DbSet<Wishlist> Userwishlist { get; set; }

        public DbSet<SoundsData> SoundsInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Map the User entity to the right table and schema
            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.ToTable("Wishlist", "Info");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.UserID);

                entity.Property(e => e.SoundID);
            });

            modelBuilder.Entity<SoundsData>(entity =>
            {
                entity.ToTable("All_SoundBoard", "Info");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name);

                entity.Property(e => e.link);
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.ToTable("Wishlist", "Info");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.UserID);
                entity.Property(e => e.SoundID);
            });
        }
    }
}
