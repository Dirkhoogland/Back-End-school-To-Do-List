using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Back_End_school_To_Do_List.Models.Database
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LijstenBackend> LijstenBackend { get; set; }
        public virtual DbSet<Requirements> Requirements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<LijstenBackend>(entity =>
            {
                entity.ToTable("Lijsten-backend");

                entity.Property(e => e.Naam)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Requirements>(entity =>
            {
                entity.Property(e => e.Beschrijving)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("beschrijving");

                entity.Property(e => e.Lijst)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
