namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revinitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Revenues",
                c => new
                    {
                        RevId = c.Int(nullable: false, identity: true),
                        EventRev = c.Int(nullable: false),
                        SponsorRev = c.Int(nullable: false),
                        EventId = c.Int(nullable: false),
                        SponsorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RevId)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Sponsors", t => t.SponsorId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.SponsorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Revenues", "SponsorId", "dbo.Sponsors");
            DropForeignKey("dbo.Revenues", "EventId", "dbo.Events");
            DropIndex("dbo.Revenues", new[] { "SponsorId" });
            DropIndex("dbo.Revenues", new[] { "EventId" });
            DropTable("dbo.Revenues");
        }
    }
}
