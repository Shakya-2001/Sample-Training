namespace EComm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Ouantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Ouantity", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Quantity");
        }
    }
}
