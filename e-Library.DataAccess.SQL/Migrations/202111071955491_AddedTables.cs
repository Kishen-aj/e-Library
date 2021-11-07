namespace e_Library.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BasketItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BasketId = c.String(maxLength: 128),
                        BookId = c.String(),
                        Quantity = c.Int(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Baskets", t => t.BasketId)
                .Index(t => t.BasketId);
            
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Author = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookGenres",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Genre = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 300),
                        Author = c.String(maxLength: 30),
                        Description = c.String(maxLength: 1000),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        Image = c.String(),
                        NumSales = c.Int(nullable: false),
                        NumOrders = c.Int(nullable: false),
                        TotalSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        City = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DriverName = c.String(),
                        Email = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Suburb = c.Int(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OrderId = c.String(maxLength: 128),
                        BookId = c.String(),
                        BookName = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Image = c.String(),
                        Quantity = c.Int(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        City = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        OrderStatus = c.String(),
                        Delivery = c.Int(nullable: false),
                        DeliveryMethod = c.String(),
                        BasketTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinalTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Driver = c.String(),
                        Suburb = c.String(),
                        Area = c.Int(nullable: false),
                        DeliveryDate = c.DateTime(),
                        QRCode = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderStatusModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OrderStatus = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PreOrderBooks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 300),
                        Author = c.String(maxLength: 30),
                        Description = c.String(maxLength: 1000),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        Image = c.String(),
                        NumSales = c.Int(nullable: false),
                        NumOrders = c.Int(nullable: false),
                        TotalSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReleaseDate = c.DateTime(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PreOrderItems",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OrderId = c.String(),
                        BookId = c.String(),
                        BookName = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Image = c.String(),
                        Quantity = c.Int(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        PreOrder_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PreOrders", t => t.PreOrder_Id)
                .Index(t => t.PreOrder_Id);
            
            CreateTable(
                "dbo.PreOrders",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        City = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        OrderStatus = c.String(),
                        Delivery = c.Int(nullable: false),
                        DeliveryMethod = c.String(),
                        BasketTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinalTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Driver = c.String(),
                        Suburb = c.String(),
                        Area = c.Int(nullable: false),
                        DeliveryDate = c.DateTime(),
                        QRCode = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PreOrderStatusModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OrderStatus = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PreOrderItems", "PreOrder_Id", "dbo.PreOrders");
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.BasketItems", "BasketId", "dbo.Baskets");
            DropIndex("dbo.PreOrderItems", new[] { "PreOrder_Id" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.BasketItems", new[] { "BasketId" });
            DropTable("dbo.PreOrderStatusModels");
            DropTable("dbo.PreOrders");
            DropTable("dbo.PreOrderItems");
            DropTable("dbo.PreOrderBooks");
            DropTable("dbo.OrderStatusModels");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Drivers");
            DropTable("dbo.Customers");
            DropTable("dbo.Books");
            DropTable("dbo.BookGenres");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Baskets");
            DropTable("dbo.BasketItems");
        }
    }
}
