namespace Demo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        SnoId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductDetail1 = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductType = c.String(),
                    })
                .PrimaryKey(t => t.SnoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductDetails");
        }
    }
}
