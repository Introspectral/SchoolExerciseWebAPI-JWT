using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BilAPI.Data
{ 
    public class RentalDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public RentalDbContext(DbContextOptions<RentalDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Models.Vehicle> Vehicle { get; set; }
        public DbSet<Models.VehicleType> VehicleType { get; set; }
        public DbSet<Models.Booking> Booking { get; set; }
        public DbSet<Models.User> User { get; set; }

        //public DbSet<UserVehicleBooking> UserVehicleBookings { get; set; }
    }
}