namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FeeReAG : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductOrders", "Pid", "dbo.Products");
            DropIndex("dbo.ProductOrders", new[] { "Pid" });
            DropTable("dbo.ProductOrders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ProductOrders", "Pid");
            AddForeignKey("dbo.ProductOrders", "Pid", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
