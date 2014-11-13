namespace Reporter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SitReps", "ReporterId", "dbo.Users");
            DropIndex("dbo.SitReps", new[] { "ReporterId" });
            DropTable("dbo.SitReps");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SitReps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReporterId = c.Int(),
                        Description = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.SitReps", "ReporterId");
            AddForeignKey("dbo.SitReps", "ReporterId", "dbo.Users", "Id");
        }
    }
}
