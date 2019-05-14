namespace MyStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStuff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stuffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stuffs");
        }
    }
}
