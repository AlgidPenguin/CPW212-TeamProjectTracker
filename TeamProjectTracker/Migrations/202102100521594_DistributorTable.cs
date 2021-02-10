namespace TeamProjectTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DistributorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Distributors",
                c => new
                    {
                        DistibutorID = c.Int(nullable: false, identity: true),
                        ProductId = c.String(),
                        DistributorName = c.String(),
                        Stock = c.Int(nullable: false),
                        Electronic_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.DistibutorID)
                .ForeignKey("dbo.Electronics", t => t.Electronic_ProductId)
                .Index(t => t.Electronic_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Distributors", "Electronic_ProductId", "dbo.Electronics");
            DropIndex("dbo.Distributors", new[] { "Electronic_ProductId" });
            DropTable("dbo.Distributors");
        }
    }
}
