namespace IMS.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablesFromEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateProvinceId = c.Int(),
                        CountryId = c.Int(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        ZipPostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.StateProvinces", t => t.StateProvinceId)
                .Index(t => t.StateProvinceId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abbreviation = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StateProvinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        Name = c.String(),
                        Abbreviation = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        ProductCode = c.String(),
                        Barcode = c.String(),
                        BatchNumber = c.String(),
                        AvgCostPrice = c.Decimal(precision: 18, scale: 2),
                        AvgSellingPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Website = c.String(),
                        Email = c.String(),
                        ContactNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressId = c.Int(nullable: false),
                        Name = c.String(),
                        ContactNumber = c.String(),
                        Email = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.AddressId)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressId = c.Int(nullable: false),
                        Name = c.String(),
                        ContactNumber = c.String(),
                        Email = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.LineItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SalesOrderId = c.Int(),
                        PurchaseOrderId = c.Int(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantityReceived = c.Decimal(precision: 18, scale: 2),
                        QuantityDelivered = c.Decimal(precision: 18, scale: 2),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseOrders", t => t.PurchaseOrderId)
                .ForeignKey("dbo.SalesOrders", t => t.SalesOrderId)
                .Index(t => t.ProductId)
                .Index(t => t.SalesOrderId)
                .Index(t => t.PurchaseOrderId);
            
            CreateTable(
                "dbo.PurchaseOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        TaxId = c.Int(nullable: false),
                        Remark = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Taxes", t => t.TaxId, cascadeDelete: true)
                .Index(t => t.SupplierId)
                .Index(t => t.TaxId);
            
            CreateTable(
                "dbo.Taxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TaxId = c.Int(nullable: false),
                        Status = c.String(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Taxes", t => t.TaxId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.TaxId);
            
            CreateTable(
                "dbo.PaymentTerms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ManufacturerProducts",
                c => new
                    {
                        Manufacturer_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Manufacturer_Id, t.Product_Id })
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesOrders", "TaxId", "dbo.Taxes");
            DropForeignKey("dbo.LineItems", "SalesOrderId", "dbo.SalesOrders");
            DropForeignKey("dbo.SalesOrders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.PurchaseOrders", "TaxId", "dbo.Taxes");
            DropForeignKey("dbo.PurchaseOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.LineItems", "PurchaseOrderId", "dbo.PurchaseOrders");
            DropForeignKey("dbo.LineItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Customers", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Suppliers", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Suppliers", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.ManufacturerProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ManufacturerProducts", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Addresses", "StateProvinceId", "dbo.StateProvinces");
            DropForeignKey("dbo.Addresses", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.StateProvinces", "CountryId", "dbo.Countries");
            DropIndex("dbo.ManufacturerProducts", new[] { "Product_Id" });
            DropIndex("dbo.ManufacturerProducts", new[] { "Manufacturer_Id" });
            DropIndex("dbo.SalesOrders", new[] { "TaxId" });
            DropIndex("dbo.SalesOrders", new[] { "CustomerId" });
            DropIndex("dbo.PurchaseOrders", new[] { "TaxId" });
            DropIndex("dbo.PurchaseOrders", new[] { "SupplierId" });
            DropIndex("dbo.LineItems", new[] { "PurchaseOrderId" });
            DropIndex("dbo.LineItems", new[] { "SalesOrderId" });
            DropIndex("dbo.LineItems", new[] { "ProductId" });
            DropIndex("dbo.Customers", new[] { "AddressId" });
            DropIndex("dbo.Suppliers", new[] { "Product_Id" });
            DropIndex("dbo.Suppliers", new[] { "AddressId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.StateProvinces", new[] { "CountryId" });
            DropIndex("dbo.Addresses", new[] { "CountryId" });
            DropIndex("dbo.Addresses", new[] { "StateProvinceId" });
            DropTable("dbo.ManufacturerProducts");
            DropTable("dbo.PaymentTerms");
            DropTable("dbo.SalesOrders");
            DropTable("dbo.Taxes");
            DropTable("dbo.PurchaseOrders");
            DropTable("dbo.LineItems");
            DropTable("dbo.Customers");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.StateProvinces");
            DropTable("dbo.Countries");
            DropTable("dbo.Addresses");
        }
    }
}
