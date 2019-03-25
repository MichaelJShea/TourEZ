using System;
using Microsoft.EntityFrameworkCore;

namespace TourEZ.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Event> Events {get;set;}
    }
}