namespace app_com_bog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sales_5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_sales_transactions", "RecNo", c => c.String(nullable: false));
            DropColumn("dbo.tb_sales_transactions", "TotalAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_sales_transactions", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tb_sales_transactions", "RecNo", c => c.String());
        }
    }
}
