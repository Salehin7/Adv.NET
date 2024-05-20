namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Janitor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Janitors",
                c => new
                    {
                        JId = c.Int(nullable: false, identity: true),
                        JName = c.String(nullable: false),
                        Task = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.JId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Janitors");
        }
    }
}
