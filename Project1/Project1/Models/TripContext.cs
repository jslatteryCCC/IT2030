using System;

using Microsoft.EntityFrameworkCore;

namespace Project1.Models {
    public class TripContext : DbContext {

        public TripContext(DbContextOptions<TripContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    TripId = 1,
                    Destination = "Boise",
                    StartDate = new DateTime(2020, 6, 6),
                    EndDate = new DateTime(2020, 6, 14),
                    ThingToDo1 = "Visit Tammy"
                },
                new Trip
                {
                    TripId = 2,
                    Destination = "Portland",
                    StartDate = new DateTime(2021, 1, 1),
                    EndDate = new DateTime(2021, 1, 7),
                    AccommodationName = "The Benson Hotel",
                    AccommodationPhone = "503-555-1234",
                    AccommodationEmail = "staff@bensonhotel.com",
                    ThingToDo1 = "Go to Voodoo Doughnuts",
                    ThingToDo2 = "Walk in the rain",
                    ThingToDo3 = "Go to Powell's"
                },
                new Trip
                {
                    TripId = 3,
                    Destination = "New York",
                    StartDate = new DateTime(2020, 10, 25),
                    EndDate = new DateTime(2020, 11, 1),
                    AccommodationName = "The Ritz",
                    AccommodationPhone = "555-123-4567",
                    AccommodationEmail = "contact@theritz.com",
                    ThingToDo1 = "Go to a show",
                    ThingToDo2 = "Ride the subway"
                }
            );
        }
    }
}
