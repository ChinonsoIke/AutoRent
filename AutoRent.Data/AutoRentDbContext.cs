using AutoRent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRent.Data
{
    public class AutoRentDbContext : DbContext 
    {
        public AutoRentDbContext(DbContextOptions<AutoRentDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Rating> Ratings { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
