using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biluthyrning.Data;

public class RentalDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public RentalDbContext(DbContextOptions<RentalDbContext> options)
        : base(options)
        
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //ANVÄNDS EJ JUST NU
        //modelBuilder.Entity<UserVehicleBooking>()
        //    .HasKey(uvb => new { uvb.UserId, uvb.VehicleId, uvb.BookingId });

        //modelBuilder.Entity<UserVehicleBooking>()
        //    .HasOne(uvb => uvb.User)
        //    .WithMany(u => u.UserVehicleBookings)
        //    .HasForeignKey(uvb => uvb.UserId)
        //    .OnDelete(DeleteBehavior.Cascade);

        //modelBuilder.Entity<UserVehicleBooking>()
        //    .HasOne(uvb => uvb.Vehicle)
        //    .WithMany(v => v.UserVehicleBookings)
        //    .HasForeignKey(uvb => uvb.VehicleId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<UserVehicleBooking>()
        //    .HasOne(uvb => uvb.Booking)
        //    .WithMany(b => b.UserVehicleBookings)
        //    .HasForeignKey(uvb => uvb.BookingId)
        //    .OnDelete(DeleteBehavior.Cascade);

    }

    public DbSet<Biluthyrning.Data.Vehicle> Vehicle { get; set; }
    public DbSet<Biluthyrning.Data.VehicleType> VehicleType { get; set; }
    public DbSet<Biluthyrning.Data.Booking> Booking { get; set; }
    public DbSet<Biluthyrning.Data.User> User { get; set; }

    //public DbSet<UserVehicleBooking> UserVehicleBookings { get; set; }
}
