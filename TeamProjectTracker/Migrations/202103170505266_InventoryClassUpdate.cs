namespace TeamProjectTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InventoryClassUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Distributors", "Electronic_ProductId", "dbo.Electronics");
            DropIndex("dbo.Distributors", new[] { "Electronic_ProductId" });
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        Stock = c.Int(nullable: false),
                        DistributorID_DistibutorID = c.Int(),
                        ProductId_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.StockId)
                .ForeignKey("dbo.Distributors", t => t.DistributorID_DistibutorID)
                .ForeignKey("dbo.Electronics", t => t.ProductId_ProductId)
                .Index(t => t.DistributorID_DistibutorID)
                .Index(t => t.ProductId_ProductId);
            
            AddColumn("dbo.Distributors", "Inventory_StockId", c => c.Int());
            AddColumn("dbo.Electronics", "Inventory_StockId", c => c.Int());
            CreateIndex("dbo.Distributors", "Inventory_StockId");
            CreateIndex("dbo.Electronics", "Inventory_StockId");
            AddForeignKey("dbo.Distributors", "Inventory_StockId", "dbo.Inventories", "StockId");
            AddForeignKey("dbo.Electronics", "Inventory_StockId", "dbo.Inventories", "StockId");
            DropColumn("dbo.Distributors", "Electronic_ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Distributors", "Electronic_ProductId", c => c.Int());
            DropForeignKey("dbo.Inventories", "ProductId_ProductId", "dbo.Electronics");
            DropForeignKey("dbo.Electronics", "Inventory_StockId", "dbo.Inventories");
            DropForeignKey("dbo.Inventories", "DistributorID_DistibutorID", "dbo.Distributors");
            DropForeignKey("dbo.Distributors", "Inventory_StockId", "dbo.Inventories");
            DropIndex("dbo.Inventories", new[] { "ProductId_ProductId" });
            DropIndex("dbo.Inventories", new[] { "DistributorID_DistibutorID" });
            DropIndex("dbo.Electronics", new[] { "Inventory_StockId" });
            DropIndex("dbo.Distributors", new[] { "Inventory_StockId" });
            DropColumn("dbo.Electronics", "Inventory_StockId");
            DropColumn("dbo.Distributors", "Inventory_StockId");
            DropTable("dbo.Inventories");
            CreateIndex("dbo.Distributors", "Electronic_ProductId");
            AddForeignKey("dbo.Distributors", "Electronic_ProductId", "dbo.Electronics", "ProductId");
        }
    }
}
