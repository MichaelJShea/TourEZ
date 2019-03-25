using System;
using Microsoft.EntityFrameworkCore;

namespace TourEZ.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}
        public DbSet<Event> Events {get;set;}
    }
}