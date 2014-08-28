using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RowRegattaTracker.Models
{
    public class RowRegattaTrackerDbContext : DbContext
    {
        public  RowRegattaTrackerDbContext() : base("RowRegattaTrackerDbContext")
        {

        }
       
        public DbSet<Race> Races { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}