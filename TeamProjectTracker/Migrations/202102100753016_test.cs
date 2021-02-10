namespace TeamProjectTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Distributors", "ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Distributors", "ProductId", c => c.String());
        }
    }
}
