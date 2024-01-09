namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INitAttrnINcount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AttendanceReports", "Count", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AttendanceReports", "Count");
        }
    }
}
