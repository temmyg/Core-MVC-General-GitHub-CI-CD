using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core_MVC_General.EFContext
{
    public class LaunchCompanyContext : DbContext
    {
        public LaunchCompanyContext(DbContextOptions<LaunchCompanyContext> options) : base(options)
        {

        }

        public DbSet<LaunchCenter> LaunchCenters { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Staff>(stfbuilder => {
            //    stfbuilder.OwnsOne(
            //        s => s.StaffProfile,
            //        sp =>
            //        {
            //            sp.ToTable("StaffProfile");
            //            sp.Property(p => p.SerialNo).IsRequired();
            //        });
            //    });

            //modelBuilder.Entity<Staff>().ToTable("Staff").HasOne(s => s.WorkForCenter).WithMany(l => l.Personnel).HasForeignKey(s => s.WorkForCenter);

            //modelBuilder.Entity<LaunchCenter>().ToTable("LaunchCenter");
        }
    }
}
