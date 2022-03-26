using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Travel_Api.Models
{
    public partial class TRAVELContext : DbContext
    {
        public TRAVELContext()
        {
        }

        public TRAVELContext(DbContextOptions<TRAVELContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Travel> Travel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;database=TRAVEL;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Travel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EMail)
                    .HasColumnName("E-mail")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone Number");

                entity.Property(e => e.TravelLocation)
                    .HasColumnName("Travel Location")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
