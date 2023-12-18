namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletTT : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Tokens");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        TId = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 20),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                        ModeratorID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TId);
            
        }
    }
}
