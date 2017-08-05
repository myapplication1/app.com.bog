namespace app_com_bog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sales_Model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_currency",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DatePosted = c.DateTime(nullable: false),
                        UserPosted = c.String(),
                        UserModified = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        Label = c.String(),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Symbol = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_purchases_transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DatePosted = c.DateTime(nullable: false),
                        RecNo = c.String(),
                        US_Dollars = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BritishPounds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Yen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CFA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Euro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CanDollar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserPosted = c.String(),
                        UserModified = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_sales_transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DatePosted = c.DateTime(nullable: false),
                        RecNo = c.String(),
                        US_Dollars = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BritishPounds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Yen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CFA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Euro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CanDollar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserPosted = c.String(),
                        UserModified = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_sales_transactions");
            DropTable("dbo.tb_purchases_transactions");
            DropTable("dbo.tb_currency");
        }
    }
}
