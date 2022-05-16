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

        public virtual DbSet<Lijstenbackend> Lijstenbackend { get; set; }
        public virtual DbSet<Requirements> Requirements { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Lijstenbackend>(entity =>
            {
                entity.HasKey(e => e.IdLijst);

                entity.HasIndex(e => e.NaamLijst, "Ak_Naamlijsten")
                    .IsUnique();

                entity.Property(e => e.IdLijst).ValueGeneratedNever();

                entity.Property(e => e.NaamLijst)
                    .IsRequired()
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

                entity.HasOne(d => d.LijstNavigation)
                    .WithMany(p => p.Requirements)
                    .HasPrincipalKey(p => p.NaamLijst)
                    .HasForeignKey(d => d.Lijst)
                    .HasConstraintName("FK_Requirements_Lijstenbackend1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
