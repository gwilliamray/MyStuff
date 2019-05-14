namespace MyStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerNameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustName", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustName", c => c.String());
        }
    }
}
