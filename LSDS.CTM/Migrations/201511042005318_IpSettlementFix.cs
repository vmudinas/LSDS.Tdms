namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IpSettlementFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CTM_TradeDetailBodyIPSettlement", "AccountID", c => c.String(maxLength: 35));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CTM_TradeDetailBodyIPSettlement", "AccountID", c => c.Byte(nullable: false));
        }
    }
}
