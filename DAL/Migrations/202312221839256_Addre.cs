namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReviewDatas = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Pid", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "Pid" });
            DropTable("dbo.Reviews");
        }
    }
}
