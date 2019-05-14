namespace MyStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerDate : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Customers (CustName, Address, CanCharge) values ('Glenn', '8800 O', 'true')");
            Sql("Insert into Customers (CustName, Address, CanCharge) values ('George', '8801 O', 'false')");
            Sql("Insert into Customers (CustName, Address, CanCharge) values ('Sally', '7988 O', 'true')");
            Sql("Insert into Customers (CustName, Address, CanCharge) values ('Greg', '7250 O', 'false')");
        }
        
        public override void Down()
        {
        }
    }
}
