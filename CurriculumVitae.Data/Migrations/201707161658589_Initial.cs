namespace CurriculumVitae.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Career",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Summary = c.String(maxLength: 1000, unicode: false),
                        ProfileId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.ProfileId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Experience",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Period = c.String(maxLength: 1000, unicode: false),
                        StartYear = c.Int(nullable: false),
                        EndYear = c.Int(nullable: false),
                        Company = c.String(maxLength: 1000, unicode: false),
                        CareerId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Career", t => t.CareerId)
                .Index(t => t.CareerId);
            
            CreateTable(
                "dbo.ExperienceDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExperienceId = c.Int(nullable: false),
                        Value = c.String(maxLength: 1000, unicode: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Experience", t => t.ExperienceId)
                .Index(t => t.ExperienceId);
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tagline = c.String(maxLength: 1000, unicode: false),
                        ProfileURL = c.String(maxLength: 1000, unicode: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZipCode = c.String(maxLength: 1000, unicode: false),
                        Street = c.String(maxLength: 1000, unicode: false),
                        City = c.String(maxLength: 1000, unicode: false),
                        State = c.String(maxLength: 1000, unicode: false),
                        Country = c.String(maxLength: 1000, unicode: false),
                        Phone = c.String(maxLength: 1000, unicode: false),
                        ProfileId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.ProfileId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 1000, unicode: false),
                        Icon = c.String(maxLength: 1000, unicode: false),
                        Value = c.String(maxLength: 1000, unicode: false),
                        ProfileId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.ProfileId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Education",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        University = c.String(maxLength: 1000, unicode: false),
                        Years = c.String(maxLength: 1000, unicode: false),
                        StartYear = c.Int(nullable: false),
                        EndYear = c.Int(nullable: false),
                        ProfileId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.ProfileId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Interest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfileId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.ProfileId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Level = c.String(maxLength: 1000, unicode: false),
                        ProfileId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.ProfileId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectUrl = c.String(maxLength: 1000, unicode: false),
                        Value = c.String(maxLength: 1000, unicode: false),
                        CareerId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Career", t => t.CareerId)
                .Index(t => t.CareerId);
            
            CreateTable(
                "dbo.Skill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Level = c.Int(nullable: false),
                        CareerId = c.Int(nullable: false),
                        Name = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Career", t => t.CareerId)
                .Index(t => t.CareerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skill", "CareerId", "dbo.Career");
            DropForeignKey("dbo.Project", "CareerId", "dbo.Career");
            DropForeignKey("dbo.Career", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Language", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Interest", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Education", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Contact", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Address", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.ExperienceDetail", "ExperienceId", "dbo.Experience");
            DropForeignKey("dbo.Experience", "CareerId", "dbo.Career");
            DropIndex("dbo.Skill", new[] { "CareerId" });
            DropIndex("dbo.Project", new[] { "CareerId" });
            DropIndex("dbo.Language", new[] { "ProfileId" });
            DropIndex("dbo.Interest", new[] { "ProfileId" });
            DropIndex("dbo.Education", new[] { "ProfileId" });
            DropIndex("dbo.Contact", new[] { "ProfileId" });
            DropIndex("dbo.Address", new[] { "ProfileId" });
            DropIndex("dbo.ExperienceDetail", new[] { "ExperienceId" });
            DropIndex("dbo.Experience", new[] { "CareerId" });
            DropIndex("dbo.Career", new[] { "ProfileId" });
            DropTable("dbo.Skill");
            DropTable("dbo.Project");
            DropTable("dbo.Language");
            DropTable("dbo.Interest");
            DropTable("dbo.Education");
            DropTable("dbo.Contact");
            DropTable("dbo.Address");
            DropTable("dbo.Profile");
            DropTable("dbo.ExperienceDetail");
            DropTable("dbo.Experience");
            DropTable("dbo.Career");
        }
    }
}
