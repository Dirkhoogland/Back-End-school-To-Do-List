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

        public virtual DbSet<Lijstentable> Lijstentable { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Lijstentable>(entity =>
            {
                entity.HasKey(e => e.IdLijst);

                entity.HasIndex(e => e.NaamLijst, "IX_Lijstentable")
                    .IsUnique();

                entity.Property(e => e.NaamLijst)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.Property(e => e.Id);

                entity.Property(e => e.Beschrijving)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Lijst)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.LijstNavigation)
                    .WithMany(p => p.Tasks)
                    .HasPrincipalKey(p => p.NaamLijst)
                    .HasForeignKey(d => d.Lijst)
                    .HasConstraintName("FK_Tasks_Lijstentable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
