namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aging : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "ModeratorID", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "MId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tokens", "MId", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "ModeratorID");
        }
    }
}
