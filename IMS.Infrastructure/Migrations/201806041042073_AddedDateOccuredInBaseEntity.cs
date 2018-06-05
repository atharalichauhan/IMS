namespace IMS.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateOccuredInBaseEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.Countries", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.StateProvinces", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.Categories", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.Manufacturers", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.Suppliers", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.LineItems", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.PurchaseOrders", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.Taxes", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.SalesOrders", "DateOccurred", c => c.DateTime(nullable: false));
            AddColumn("dbo.PaymentTerms", "DateOccurred", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PaymentTerms", "DateOccurred");
            DropColumn("dbo.SalesOrders", "DateOccurred");
            DropColumn("dbo.Taxes", "DateOccurred");
            DropColumn("dbo.PurchaseOrders", "DateOccurred");
            DropColumn("dbo.LineItems", "DateOccurred");
            DropColumn("dbo.Customers", "DateOccurred");
            DropColumn("dbo.Suppliers", "DateOccurred");
            DropColumn("dbo.Manufacturers", "DateOccurred");
            DropColumn("dbo.Products", "DateOccurred");
            DropColumn("dbo.Categories", "DateOccurred");
            DropColumn("dbo.StateProvinces", "DateOccurred");
            DropColumn("dbo.Countries", "DateOccurred");
            DropColumn("dbo.Addresses", "DateOccurred");
        }
    }
}
