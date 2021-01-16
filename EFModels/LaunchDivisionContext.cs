using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core_MVC_General.Models
{
    public partial class LaunchDivisionContext : DbContext
    {
        public LaunchDivisionContext()
        {
        }

        public LaunchDivisionContext(DbContextOptions<LaunchDivisionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LaunchCenter> LaunchCenter { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=TrueServer=DESKTOP-H8IMEBU\\\\SQLEXPRESS;Database=LaunchDivision;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LaunchCenter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasIndex(e => e.LaunchCenterId);

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LaunchCenterId).HasColumnName("LaunchCenterID");

                entity.HasOne(d => d.LaunchCenter)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.LaunchCenterId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
