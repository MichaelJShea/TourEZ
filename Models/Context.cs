using System;
using Microsoft.EntityFrameworkCore;

namespace TourEZ.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Event> Events {get;set;}
        public DbSet<User> Users {get; set;}
        public DbSet<Place> Places {get;set;}
        public DbSet<Trip> Trips {get;set;}
        public DbSet<Hotel> Hotels {get;set;}
        public DbSet<Group> Groups {get;set;}
        public DbSet<Member> Members {get;set;}
        public DbSet<Traveler> Travelers {get;set;}
    }
}