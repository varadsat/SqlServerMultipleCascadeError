using Microsoft.EntityFrameworkCore;
using SqlServerMultipleCascade.Models;

namespace SqlServerMultipleCascade
{
    public class EntityContext : DbContext
    {
     
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EntityDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entity>()
                .HasMany(e => e.ChildEntities)
                .WithOne(e => e.ParentEntity)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<Entity> Entities { get; set; }
    }
}
