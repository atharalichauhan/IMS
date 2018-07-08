namespace IMS.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsActiveToStateProvince : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StateProvinces", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StateProvinces", "IsActive");
        }
    }
}
