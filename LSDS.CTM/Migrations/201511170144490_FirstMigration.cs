namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CTM_ValidBody", "CTMTradeSideId", c => c.String(maxLength: 16));
            AddColumn("dbo.CTM_ValidBody", "CTMTradeDetailID", c => c.String(maxLength: 16));
            AlterColumn("dbo.CTM_ValidBody", "EchoMasterReference", c => c.String(maxLength: 16));
            AlterColumn("dbo.CTM_ValidBody", "EchoClientAllocationReference", c => c.String(maxLength: 16));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CTM_ValidBody", "EchoClientAllocationReference", c => c.String());
            AlterColumn("dbo.CTM_ValidBody", "EchoMasterReference", c => c.String());
            DropColumn("dbo.CTM_ValidBody", "CTMTradeDetailID");
            DropColumn("dbo.CTM_ValidBody", "CTMTradeSideId");
        }
    }
}
