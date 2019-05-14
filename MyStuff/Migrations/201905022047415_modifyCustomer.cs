namespace MyStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
            AddColumn("dbo.Customers", "CanCharge", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CanCharge");
            DropColumn("dbo.Customers", "Address");
        }
    }
}
