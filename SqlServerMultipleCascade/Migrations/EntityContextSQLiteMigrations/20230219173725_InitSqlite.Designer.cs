// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqlServerMultipleCascade;

#nullable disable

namespace SqlServerMultipleCascade.Migrations.EntityContextSQLiteMigrations
{
    [DbContext(typeof(EntityContextSQLite))]
    [Migration("20230219173725_InitSqlite")]
    partial class InitSqlite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("SqlServerMultipleCascade.Models.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentEntityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ParentEntityId");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("SqlServerMultipleCascade.Models.Entity", b =>
                {
                    b.HasOne("SqlServerMultipleCascade.Models.Entity", "ParentEntity")
                        .WithMany("ChildEntities")
                        .HasForeignKey("ParentEntityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("ParentEntity");
                });

            modelBuilder.Entity("SqlServerMultipleCascade.Models.Entity", b =>
                {
                    b.Navigation("ChildEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
