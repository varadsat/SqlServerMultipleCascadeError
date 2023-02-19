using Microsoft.EntityFrameworkCore;
using SqlServerMultipleCascade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerMultipleCascade
{
    public class EntityContextSQLite : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=EntityContext.db");
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
