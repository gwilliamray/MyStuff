namespace MyStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYeartoIdenity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "GradYear", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "GradYear");
        }
    }
}
