namespace MyStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyStuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stuffs", "PurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Stuffs", "PurchaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Stuffs", "Desc", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stuffs", "Desc", c => c.String());
            DropColumn("dbo.Stuffs", "PurchaseDate");
            DropColumn("dbo.Stuffs", "PurchasePrice");
        }
    }
}
