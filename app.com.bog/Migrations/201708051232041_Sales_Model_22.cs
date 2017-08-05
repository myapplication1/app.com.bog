namespace app_com_bog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sales_Model_22 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_sales_transactions", "US_Dollars");
            DropColumn("dbo.tb_sales_transactions", "BritishPounds");
            DropColumn("dbo.tb_sales_transactions", "Yen");
            DropColumn("dbo.tb_sales_transactions", "CFA");
            DropColumn("dbo.tb_sales_transactions", "Euro");
            DropColumn("dbo.tb_sales_transactions", "CanDollar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_sales_transactions", "CanDollar", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_sales_transactions", "Euro", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_sales_transactions", "CFA", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_sales_transactions", "Yen", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_sales_transactions", "BritishPounds", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_sales_transactions", "US_Dollars", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
