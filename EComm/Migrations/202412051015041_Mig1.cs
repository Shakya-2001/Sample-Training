namespace EComm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "OrderId", c => c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.Orders", "OrderId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "OrderId", c => c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.Orders", "OrderId");
        }
    }
}
