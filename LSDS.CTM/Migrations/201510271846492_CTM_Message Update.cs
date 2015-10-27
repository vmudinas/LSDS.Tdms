namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CTM_MessageUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTM_TradeDetailBodyTDReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TDReferenceType = c.String(maxLength: 4),
                        TDReferenceValue = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        DiscountRate = c.String(),
                        LegalStatus = c.String(maxLength: 4),
                        PaymentIndicator = c.String(maxLength: 4),
                        BasisIndicator = c.String(maxLength: 4),
                        BondValuationIndicator = c.String(maxLength: 4),
                        InterestAccrualDate = c.Int(nullable: false),
                        InterestPaymentDate = c.Int(nullable: false),
                        OptionCallIndicator = c.String(maxLength: 4),
                        CallPutIndicator = c.String(),
                        PutBondType = c.String(maxLength: 4),
                        PutBondDate = c.Int(nullable: false),
                        PutBondPrice = c.String(maxLength: 17),
                        BondOwnershipIndicator = c.String(maxLength: 4),
                        InterestPaymentFrequency = c.String(maxLength: 4),
                        CouponType = c.String(maxLength: 4),
                        FlatDefaultStatus = c.String(maxLength: 4),
                        BondTaxStatus = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        StipulationCodeNonStandard = c.String(maxLength: 15),
                        StipulationValueNonStandard = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationYield",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        YieldType = c.String(maxLength: 4),
                        Sign = c.String(maxLength: 1),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            AddColumn("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_CtmId", c => c.Int());
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_CtmId", c => c.Int());
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_CtmId", c => c.Int());
            AlterColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CtmId", c => c.Int());
            CreateIndex("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_CtmId");
            CreateIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CtmId");
            CreateIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_CtmId");
            CreateIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_CtmId");
            AddForeignKey("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_CtmId", "dbo.CTM_TradeDetailBodyTDReferences", "CtmId");
            AddForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData", "CtmId");
            AddForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard", "CtmId");
            AddForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationYield", "CtmId");
            DropColumn("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_TDReferenceType");
            DropColumn("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_TDReferenceValue");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_StipulationCodeNonStandard");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_StipulationValueNonStandard");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_DiscountRate");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_LegalStatus");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_PaymentIndicator");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_BasisIndicator");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_BondValuationIndicator");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_InterestAccrualDate");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_InterestPaymentDate");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_OptionCallIndicator");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CallPutIndicator");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_PutBondType");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_PutBondDate");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_PutBondPrice");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_BondOwnershipIndicator");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_InterestPaymentFrequency");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CouponType");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_FlatDefaultStatus");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_BondTaxStatus");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_YieldType");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_Sign");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_Amount", c => c.String());
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_Sign", c => c.String(maxLength: 1));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_YieldType", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_BondTaxStatus", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_FlatDefaultStatus", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CouponType", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_InterestPaymentFrequency", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_BondOwnershipIndicator", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_PutBondPrice", c => c.String(maxLength: 17));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_PutBondDate", c => c.Int(nullable: false));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_PutBondType", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CallPutIndicator", c => c.String());
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_OptionCallIndicator", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_InterestPaymentDate", c => c.Int(nullable: false));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_InterestAccrualDate", c => c.Int(nullable: false));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_BondValuationIndicator", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_BasisIndicator", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_PaymentIndicator", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_LegalStatus", c => c.String(maxLength: 4));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_DiscountRate", c => c.String());
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_StipulationValueNonStandard", c => c.String(maxLength: 35));
            AddColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_StipulationCodeNonStandard", c => c.String(maxLength: 15));
            AddColumn("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_TDReferenceValue", c => c.String(maxLength: 16));
            AddColumn("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_TDReferenceType", c => c.String(maxLength: 4));
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationYield");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_CtmId", "dbo.CTM_TradeDetailBodyTDReferences");
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "Yield_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "StipulationsNonStandard_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "AdditionalMunicipalDebtData_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailLinkages", new[] { "TDReferences_CtmId" });
            AlterColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_CtmId", c => c.Int(nullable: false));
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_CtmId");
            DropColumn("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_CtmId");
            DropColumn("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_CtmId");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationYield");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData");
            DropTable("dbo.CTM_TradeDetailBodyTDReferences");
        }
    }
}
