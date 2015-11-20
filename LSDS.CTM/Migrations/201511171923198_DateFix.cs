namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CTM_Message", "LastUpdated", c => c.DateTime());
            AlterColumn("dbo.CTM_Header", "DateTimeOfSentMsg", c => c.DateTime());
            AlterColumn("dbo.CTM_ResponseHeader", "EchoDateTimeOfSentMsg", c => c.DateTime());
            AlterColumn("dbo.CTM_MultiTradeDetailRequestBody", "MinLastUpdateDateTime", c => c.DateTime());
            AlterColumn("dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody", "GoodThroughDateTime", c => c.DateTime());
            AlterColumn("dbo.CTM_MultiTradeLevelRequestBody", "MinLastUpdateDateTime", c => c.DateTime());
            AlterColumn("dbo.CTM_MultiTradeLevelResponseBody", "GoodThroughDateTime", c => c.DateTime());
            AlterColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "TradeDT", c => c.DateTime());
            AlterColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "SettlementDt", c => c.DateTime());
            AlterColumn("dbo.CTM_TradeLevelBodyTradeLevelInformation", "TradeDT", c => c.DateTime());
            AlterColumn("dbo.CTM_TradeLevelBodyTradeLevelInformation", "SettlementDt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CTM_TradeLevelBodyTradeLevelInformation", "SettlementDt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_TradeLevelBodyTradeLevelInformation", "TradeDT", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "SettlementDt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "TradeDT", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_MultiTradeLevelResponseBody", "GoodThroughDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_MultiTradeLevelRequestBody", "MinLastUpdateDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody", "GoodThroughDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_MultiTradeDetailRequestBody", "MinLastUpdateDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_ResponseHeader", "EchoDateTimeOfSentMsg", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_Header", "DateTimeOfSentMsg", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CTM_Message", "LastUpdated", c => c.DateTime(nullable: false));
        }
    }
}
