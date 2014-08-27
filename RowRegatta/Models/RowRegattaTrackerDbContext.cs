using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RowRegattaTracker.Models
{
    public class RowRegattaTrackerDbContext : DbContext
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}