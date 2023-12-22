namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FeRe25 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Reviews", "Pid", "dbo.Products");
            DropForeignKey("dbo.Reviews", "Product_Id1", "dbo.Products");
            DropForeignKey("dbo.FeedBacks", "Rid", "dbo.Reviews");
            DropIndex("dbo.FeedBacks", new[] { "Rid" });
            DropIndex("dbo.Reviews", new[] { "Pid" });
            DropIndex("dbo.Reviews", new[] { "Product_Id" });
            DropIndex("dbo.Reviews", new[] { "Product_Id1" });
            DropColumn("dbo.FeedBacks", "Rid");
            DropTable("dbo.Reviews");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        review = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Pid = c.Int(nullable: false),
                        Product_Id = c.Int(),
                        Product_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.FeedBacks", "Rid", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "Product_Id1");
            CreateIndex("dbo.Reviews", "Product_Id");
            CreateIndex("dbo.Reviews", "Pid");
            CreateIndex("dbo.FeedBacks", "Rid");
            AddForeignKey("dbo.FeedBacks", "Rid", "dbo.Reviews", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "Product_Id1", "dbo.Products", "Id");
            AddForeignKey("dbo.Reviews", "Pid", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "Product_Id", "dbo.Products", "Id");
        }
    }
}
