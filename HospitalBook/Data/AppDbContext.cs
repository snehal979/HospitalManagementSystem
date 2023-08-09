using HospitalBook.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace HospitalBook.Data
{
    public class AppDbContext : DbContext
    {

        private readonly object Location_Hospital;

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location_Hospital>().HasKey(am => new
            {
                am.LocationId,
                am.HospitalId
            });
            modelBuilder.Entity<Location_Hospital>().HasOne(am => am.Hospitals).WithMany(am => am.Location_Hospital).HasForeignKey(a =>
            a.HospitalId);
            modelBuilder.Entity<Location_Hospital>().HasOne(am => am.Location).WithMany(am => am.Location_Hospital).HasForeignKey(a =>
           a.LocationId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorDetatil> DoctorDetatils { get; set; }
       
        public DbSet<Hospitals> Hospitalses { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Location_Hospital> Location_Hospitals { get; set; }



    }
}
