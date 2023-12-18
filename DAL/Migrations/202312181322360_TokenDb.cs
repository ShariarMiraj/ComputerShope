namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        TId = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 20),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                        MId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tokens");
        }
    }
}
