namespace EComm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        OrderDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductId = c.String(maxLength: 5, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Description = c.String(maxLength: 20),
                        Price = c.Int(),
                        Stock = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
        }
    }
}
