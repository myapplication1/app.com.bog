namespace app_com_bog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sales_Model_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_sales_transactions", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.tb_sales_transactions", "Rate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_sales_transactions", "Rate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.tb_sales_transactions", "Amount");
        }
    }
}
