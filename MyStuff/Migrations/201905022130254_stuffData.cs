namespace MyStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stuffData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Stuffs ([Desc], PurchasePrice) values ('Bat', 2.99)");
            Sql("Insert into Stuffs ([Desc], PurchasePrice) values ('Ball', 14.63)");
            Sql("Insert into Stuffs ([Desc], PurchasePrice) values ('Frizbe', .99)");
        }
        
        public override void Down()
        {
        }
    }
}
