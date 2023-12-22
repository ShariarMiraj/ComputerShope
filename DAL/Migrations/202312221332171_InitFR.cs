namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitFR : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ReviewFeedBack = c.String(nullable: false, maxLength: 150),
                        Rid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reviews", t => t.Rid, cascadeDelete: true)
                .Index(t => t.Rid);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        review = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Pid);
            
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductOrders", "Pid", "dbo.Products");
            DropForeignKey("dbo.FeedBacks", "Rid", "dbo.Reviews");
            DropForeignKey("dbo.Reviews", "Pid", "dbo.Products");
            DropIndex("dbo.ProductOrders", new[] { "Pid" });
            DropIndex("dbo.Reviews", new[] { "Pid" });
            DropIndex("dbo.FeedBacks", new[] { "Rid" });
            DropTable("dbo.ProductOrders");
            DropTable("dbo.Reviews");
            DropTable("dbo.FeedBacks");
        }
    }
}
