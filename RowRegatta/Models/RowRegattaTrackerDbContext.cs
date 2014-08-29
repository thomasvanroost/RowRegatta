using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RowRegatta.Models;

namespace RowRegattaTracker.Models
{
    public class RowRegattaTrackerDbContext : DbContext
    {
        public RowRegattaTrackerDbContext()
            : base("RowRegattaTrackerDbContext")
        {

        }
       
        public DbSet<Race> Races { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Team> Teams { get; set; }
        //public DbSet<ChangePasswordModel> ChangePasswordModels { get; set; }
        //public DbSet<LogOnModel> LogOnModels { get; set; }
        //public DbSet<RegisterModel> RegisterModel { get; set; }
        public DbSet<Result> Results { get; set; }
    
    }
}