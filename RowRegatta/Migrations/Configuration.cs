namespace RowRegatta.Migrations
{
    using RowRegattaTracker.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RowRegattaTracker.Models.RowRegattaTrackerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RowRegattaTracker.Models.RowRegattaTrackerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Events.AddOrUpdate(
                e => e.Name,
                new Event { Name = "Masters WorldChampionship", Description = "Wereld Kampioenschap voor Master roeiers vanaf 27 jaar.", Location = "Hazelwinkel, Belgie", StartTime = new DateTime(2014, 6, 10), EndTime = new DateTime(2014, 6, 12)},
                new Event { Name = "Juniours Europeen Championship", Description="Europees kampioenschap voor roeiers van 12 - 27 jaar", Location = "Watersportbaan, Belgie" }
                //new Event 
                //{ 
                //    Name = "Europees Kampioenschap", 
                //    Description="Europeens Kampioenschap voor alle klassen", 
                //    Location = "Bosbaan, Nederland"
                //    // Race aanmaken binnen een event.
                //    // Race = 
                //    //    new List<Race>{
                //    //        new Race { Categories = new List<Category> = new Category{ Name = "M1x"} , Start=2/10/2014 0;00;00, };
                //    //    }  
                //}

                );

            context.Categories.AddOrUpdate(
                c => c.Name,
                new Category { Name = "M1x" },
                new Category { Name = "D1x" },
                new Category { Name = "M2x" },
                new Category { Name = "D2x" },
                new Category { Name = "M4x" },
                new Category { Name = "D4x" },
                new Category { Name = "M4-" },
                new Category { Name = "D4-" }
                );
       

        }
    }
}
