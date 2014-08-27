namespace RowRegatta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        RaceID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Start = c.DateTime(nullable: false),
                        Categories_CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.RaceID)
                .ForeignKey("dbo.Categories", t => t.Categories_CategoryID)
                .Index(t => t.Categories_CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Couch = c.String(),
                    })
                .PrimaryKey(t => t.TeamID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Races", new[] { "Categories_CategoryID" });
            DropForeignKey("dbo.Races", "Categories_CategoryID", "dbo.Categories");
            DropTable("dbo.Teams");
            DropTable("dbo.People");
            DropTable("dbo.Events");
            DropTable("dbo.Categories");
            DropTable("dbo.Races");
        }
    }
}
