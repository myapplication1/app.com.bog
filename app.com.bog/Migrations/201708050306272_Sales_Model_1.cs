namespace app_com_bog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sales_Model_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_sales_transactions", "CurrencyType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_sales_transactions", "CurrencyType");
        }
    }
}
