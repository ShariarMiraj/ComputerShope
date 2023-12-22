namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFeedAg : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FeedBacks", "Rid", "dbo.Reviews");
            DropIndex("dbo.FeedBacks", new[] { "Rid" });
            DropTable("dbo.FeedBacks");
        }
    }
}
