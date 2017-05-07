using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FavoritesApi.Models
{
    public partial class FavoritesContext : DbContext
    {
        public FavoritesContext(DbContextOptions<FavoritesContext> options) : base(options)
        {
                
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Dog> Dog { get; set; }
        public virtual DbSet<User> User { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Make).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnType("date");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Car_User1");
            });

            modelBuilder.Entity<Dog>(entity =>
            {
                entity.Property(e => e.Breed).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Dog)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Dog_User1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });
        }
    }
}