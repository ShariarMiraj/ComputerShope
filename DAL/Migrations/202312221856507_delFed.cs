namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delFed : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.FeedBacks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ReviewFeedBack = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
