namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTM_Trade",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        InfoRequest_CtmId = c.Int(),
                        Invalid_CtmId = c.Int(),
                        MultiTradeDetailRequest_CtmId = c.Int(),
                        MultiTradeDetailResponse_CtmId = c.Int(),
                        MultiTradeLevelRequest_CtmId = c.Int(),
                        MultiTradeLevelResponse_CtmId = c.Int(),
                        TradeDetail_CtmId = c.Int(),
                        TradeLevel_CtmId = c.Int(),
                        Valid_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_InfoRequest", t => t.InfoRequest_CtmId)
                .ForeignKey("dbo.CTM_Invalid", t => t.Invalid_CtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailRequest", t => t.MultiTradeDetailRequest_CtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailResponse", t => t.MultiTradeDetailResponse_CtmId)
                .ForeignKey("dbo.CTM_MultiTradeLevelRequest", t => t.MultiTradeLevelRequest_CtmId)
                .ForeignKey("dbo.CTM_MultiTradeLevelResponse", t => t.MultiTradeLevelResponse_CtmId)
                .ForeignKey("dbo.CTM_TradeDetail", t => t.TradeDetail_CtmId)
                .ForeignKey("dbo.CTM_TradeLevel", t => t.TradeLevel_CtmId)
                .ForeignKey("dbo.CTM_Valid", t => t.Valid_CtmId)
                .Index(t => t.InfoRequest_CtmId)
                .Index(t => t.Invalid_CtmId)
                .Index(t => t.MultiTradeDetailRequest_CtmId)
                .Index(t => t.MultiTradeDetailResponse_CtmId)
                .Index(t => t.MultiTradeLevelRequest_CtmId)
                .Index(t => t.MultiTradeLevelResponse_CtmId)
                .Index(t => t.TradeDetail_CtmId)
                .Index(t => t.TradeLevel_CtmId)
                .Index(t => t.Valid_CtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequest",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        InfoRequestBody_CtmId = c.Int(),
                        SubmitHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_InfoRequestBody", t => t.InfoRequestBody_CtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_CtmId)
                .Index(t => t.InfoRequestBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequestBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ViewRequestedIndicator = c.String(),
                        QueryType = c.String(),
                        AccessPath_CtmId = c.Int(),
                        ExecutingBroker_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_InfoRequestBodyAccessPath", t => t.AccessPath_CtmId)
                .ForeignKey("dbo.CTM_InfoRequestBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .Index(t => t.AccessPath_CtmId)
                .Index(t => t.ExecutingBroker_CtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequestBodyAccessPath",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        IDOwner = c.String(),
                        TradeLevelIdentifiers_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers", t => t.TradeLevelIdentifiers_CtmId)
                .Index(t => t.TradeLevelIdentifiers_CtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MasterReference = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequestBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_Header",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 32),
                        ProtocolVersion = c.String(maxLength: 4),
                        SendersMessageReference = c.String(maxLength: 16),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_OriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_RecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_OriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_RecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_Invalid",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        InvalidBody_CtmId = c.Int(),
                        InvalidHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_InvalidBody", t => t.InvalidBody_CtmId)
                .ForeignKey("dbo.CTM_ResponseHeader", t => t.InvalidHeader_CtmId)
                .Index(t => t.InvalidBody_CtmId)
                .Index(t => t.InvalidHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_InvalidBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        OriginalMessage = c.String(),
                        SynchError_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_InvalidBodySynchError", t => t.SynchError_CtmId)
                .Index(t => t.SynchError_CtmId);
            
            CreateTable(
                "dbo.CTM_InvalidBodySynchError",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ErrorId = c.Byte(nullable: false),
                        ErrorKey = c.String(),
                        ErrorText = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        EchoUserId = c.String(maxLength: 32),
                        ProtocolVersion = c.String(maxLength: 4),
                        EchoSendersMessageReference = c.String(maxLength: 16),
                        AuditEvent_CtmId = c.Int(),
                        AuditTrail_CtmId = c.Int(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_ResponseHeaderAuditEvent", t => t.AuditEvent_CtmId)
                .ForeignKey("dbo.CTM_ResponseHeaderAuditTrail", t => t.AuditTrail_CtmId)
                .ForeignKey("dbo.CTM_OriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_RecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.AuditEvent_CtmId)
                .Index(t => t.AuditTrail_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeaderAuditEvent",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        AuditEventDepth = c.Int(nullable: false),
                        AuditEventTag = c.String(maxLength: 255),
                        AuditEventName = c.String(maxLength: 255),
                        AuditEventArg = c.String(maxLength: 255),
                        AuditEventStart = c.Int(nullable: false),
                        AuditEventEnd = c.Int(nullable: false),
                        AuditEventInclMs = c.Int(nullable: false),
                        AuditEventExclIMs = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeaderAuditTrail",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        AuditReason = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeDetailRequest",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailRequestBody_CtmId = c.Int(),
                        SubmitHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailRequestBody", t => t.MultiTradeDetailRequestBody_CtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_CtmId)
                .Index(t => t.MultiTradeDetailRequestBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeDetailRequestBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailResponseRequested = c.String(),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeDetailResponse",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailResponseBody_CtmId = c.Int(),
                        ResponseHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody", t => t.MultiTradeDetailResponseBody_CtmId)
                .ForeignKey("dbo.CTM_ResponseHeader", t => t.ResponseHeader_CtmId)
                .Index(t => t.MultiTradeDetailResponseBody_CtmId)
                .Index(t => t.ResponseHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        RecordsReturnedCount = c.Byte(nullable: false),
                        MoreFlag = c.String(),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeLevelRequest",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelRequestBody_CtmId = c.Int(),
                        SubmitHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MultiTradeLevelRequestBody", t => t.MultiTradeLevelRequestBody_CtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_CtmId)
                .Index(t => t.MultiTradeLevelRequestBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeLevelRequestBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelResponseIndicator = c.String(),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeLevelResponse",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelResponseBody_CtmId = c.Int(),
                        ResponseHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MultiTradeLevelResponseBody", t => t.MultiTradeLevelResponseBody_CtmId)
                .ForeignKey("dbo.CTM_ResponseHeader", t => t.ResponseHeader_CtmId)
                .Index(t => t.MultiTradeLevelResponseBody_CtmId)
                .Index(t => t.ResponseHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeLevelResponseBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        RecordsReturnedCount = c.Byte(nullable: false),
                        MoreFlag = c.String(),
                        MultiTradeLevelResponseIndicator = c.String(),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetail",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        LastUpdated = c.DateTime(nullable: false),
                        SubmitHeader_CtmId = c.Int(),
                        TradeDetailBody_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBody", t => t.TradeDetailBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId)
                .Index(t => t.TradeDetailBody_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TDUpdateGuard = c.String(maxLength: 35),
                        L2MatchingProfileName = c.String(maxLength: 35),
                        ShowHiddenFieldsIndicator = c.String(maxLength: 35),
                        ProcessingIndicator = c.String(maxLength: 4),
                        ReportingIndicator = c.String(maxLength: 4),
                        DetailLevelPartyCapacityIndicator = c.String(maxLength: 4),
                        FunctionOfTheMessage = c.String(maxLength: 4),
                        VersionOfTradeComponent = c.Byte(nullable: false),
                        TradeLevelExpected = c.String(maxLength: 1),
                        AdditionalData_CtmId = c.Int(),
                        AdditionalDataIPSettlement_CtmId = c.Int(),
                        AdditionalDisclosures_CtmId = c.Int(),
                        AdditionalSecurityIdentifiers_CtmId = c.Int(),
                        ConfirmDisclosureData_CtmId = c.Int(),
                        EBSettlement_CtmId = c.Int(),
                        ExecutingBroker_CtmId = c.Int(),
                        IdentificationOfASecurity_CtmId = c.Int(),
                        InstructingParty_CtmId = c.Int(),
                        IPSettlement_CtmId = c.Int(),
                        PartySettlement_CtmId = c.Int(),
                        TradeDetailData_CtmId = c.Int(),
                        TradeDetailReferences_CtmId = c.Int(),
                        TradeLevelInformation_CtmId = c.Int(),
                        TradeLevelReferences_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalData", t => t.AdditionalData_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDataIPSettlement", t => t.AdditionalDataIPSettlement_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosures", t => t.AdditionalDisclosures_CtmId)
                .ForeignKey("dbo.CTM_AdditionalSecurityIdentifiers", t => t.AdditionalSecurityIdentifiers_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyConfirmDisclosureData", t => t.ConfirmDisclosureData_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDataEBSettlement", t => t.EBSettlement_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", t => t.IdentificationOfASecurity_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyInstructingParty", t => t.InstructingParty_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyIPSettlement", t => t.IPSettlement_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyPartySettlement", t => t.PartySettlement_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", t => t.TradeDetailData_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailReferences", t => t.TradeDetailReferences_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", t => t.TradeLevelInformation_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelReferences", t => t.TradeLevelReferences_CtmId)
                .Index(t => t.AdditionalData_CtmId)
                .Index(t => t.AdditionalDataIPSettlement_CtmId)
                .Index(t => t.AdditionalDisclosures_CtmId)
                .Index(t => t.AdditionalSecurityIdentifiers_CtmId)
                .Index(t => t.ConfirmDisclosureData_CtmId)
                .Index(t => t.EBSettlement_CtmId)
                .Index(t => t.ExecutingBroker_CtmId)
                .Index(t => t.IdentificationOfASecurity_CtmId)
                .Index(t => t.InstructingParty_CtmId)
                .Index(t => t.IPSettlement_CtmId)
                .Index(t => t.PartySettlement_CtmId)
                .Index(t => t.TradeDetailData_CtmId)
                .Index(t => t.TradeDetailReferences_CtmId)
                .Index(t => t.TradeLevelInformation_CtmId)
                .Index(t => t.TradeLevelReferences_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalData",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        AdditionalText = c.String(maxLength: 35),
                        DataXML = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDataIPSettlement",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        AccountID = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDisclosures",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        OddLotDifferential = c.String(maxLength: 1),
                        OtherRemuneration = c.String(maxLength: 1),
                        AssetBacked = c.String(maxLength: 1),
                        MarketMaker = c.String(maxLength: 1),
                        SIPCMember = c.String(maxLength: 1),
                        FINRAMember = c.String(maxLength: 1),
                        OtherRemunerationDisclosure = c.String(maxLength: 500),
                        OddLotDisclosure = c.String(maxLength: 500),
                        OrderFlowDisclosure = c.String(maxLength: 500),
                        RedemptionDisclosure = c.String(maxLength: 500),
                        AssetBackedSecuritiesDisclosure = c.String(maxLength: 500),
                        MarkUpMarkDown_CtmId = c.Int(),
                        ReportedPrice_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown", t => t.MarkUpMarkDown_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice", t => t.ReportedPrice_CtmId)
                .Index(t => t.MarkUpMarkDown_CtmId)
                .Index(t => t.ReportedPrice_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_AdditionalSecurityIdentifiers",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SecurityCode = c.String(maxLength: 30),
                        SecurityCodeType_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_AdditionalSecurityIdentifiersSecurityCodeType", t => t.SecurityCodeType_CtmId)
                .Index(t => t.SecurityCodeType_CtmId);
            
            CreateTable(
                "dbo.CTM_AdditionalSecurityIdentifiersSecurityCodeType",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        NumberingAgencyCode = c.String(maxLength: 4),
                        CountryCode = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyConfirmDisclosureData",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        UserDefinedDisclosureCode = c.String(maxLength: 16),
                        ConfirmDisclosureBypassIndicator = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDataEBSettlement",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        AccountReference = c.String(maxLength: 35),
                        AccountID = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyIdentificationOfASecurity",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SecurityCode = c.String(maxLength: 30),
                        DescriptionOfTheSecurity = c.String(maxLength: 35),
                        SecurityCodeType_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType", t => t.SecurityCodeType_CtmId)
                .Index(t => t.SecurityCodeType_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CountryCode = c.String(maxLength: 4),
                        NumberingAgencyCode = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyInstructingParty",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyIPSettlement",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        AccountID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyPartySettlement",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SettlementInstructionProcessingNarrative = c.String(maxLength: 2100),
                        AlertCountryCode = c.String(maxLength: 3),
                        AlertMethodType = c.String(maxLength: 12),
                        AlertSecurityType = c.String(maxLength: 3),
                        AlertSettlementModelName = c.String(maxLength: 12),
                        SNReleaseOverride = c.String(maxLength: 4),
                        FXDealCurrencyCode = c.String(maxLength: 3),
                        PartyFundName = c.String(maxLength: 35),
                        PartyIdentifier = c.String(maxLength: 4),
                        SettlementInstructionsSourceIndicator = c.String(maxLength: 4),
                        PlaceOfSafekeeping_CtmId = c.Int(),
                        SettlementInstructions_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping", t => t.PlaceOfSafekeeping_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyPartySettlementSettlementInstructions", t => t.SettlementInstructions_CtmId)
                .Index(t => t.PlaceOfSafekeeping_CtmId)
                .Index(t => t.SettlementInstructions_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PlaceOfSafekeepingType = c.String(maxLength: 35),
                        PlaceOfSafekeepingValue = c.String(maxLength: 14),
                        PlaceOfSafekeepingPlace = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyPartySettlementSettlementInstructions",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ID1 = c.String(maxLength: 35),
                        ID2 = c.String(maxLength: 35),
                        ID3 = c.String(maxLength: 35),
                        ID4 = c.String(maxLength: 35),
                        ID5 = c.String(maxLength: 35),
                        AgentID = c.String(maxLength: 35),
                        INSTorBrokerID = c.String(maxLength: 35),
                        ParticipantName1 = c.String(maxLength: 35),
                        ParticipantName2 = c.String(maxLength: 35),
                        AccountRef1 = c.String(maxLength: 35),
                        AccountRef2 = c.String(maxLength: 35),
                        SecurityAccount = c.String(maxLength: 35),
                        SubAccountRef1 = c.String(maxLength: 35),
                        SubAccountRef2 = c.String(maxLength: 35),
                        SubAccountNo = c.String(maxLength: 35),
                        PaymentCurrency = c.String(maxLength: 3),
                        CashAccountNo = c.String(maxLength: 35),
                        AlternateCurrency = c.String(maxLength: 3),
                        AlternateCashAccountNo = c.String(maxLength: 35),
                        CustodianBIC = c.String(maxLength: 11),
                        CustodianName1 = c.String(maxLength: 35),
                        CustodianName2 = c.String(maxLength: 35),
                        CustodianAddress1 = c.String(maxLength: 35),
                        CustodianAddress2 = c.String(maxLength: 35),
                        CustodianCity = c.String(maxLength: 35),
                        CustodianLocality = c.String(maxLength: 35),
                        CustodianCountry = c.String(maxLength: 2),
                        CustodianPostCode = c.String(maxLength: 15),
                        SubAgentBIC = c.String(maxLength: 11),
                        SubAgentName1 = c.String(maxLength: 35),
                        SubAgentName2 = c.String(maxLength: 35),
                        SubAgentAddress1 = c.String(maxLength: 35),
                        SubAgentAddress2 = c.String(maxLength: 35),
                        SubAgentCity = c.String(maxLength: 35),
                        SubAgentLocality = c.String(maxLength: 35),
                        SubAgentCountry = c.String(maxLength: 2),
                        SubAgentPostCode = c.String(maxLength: 15),
                        CorrespBIC = c.String(maxLength: 11),
                        CorrespName1 = c.String(maxLength: 35),
                        CorrespName2 = c.String(maxLength: 35),
                        CorrespAddress1 = c.String(maxLength: 35),
                        CorrespAddress2 = c.String(maxLength: 35),
                        CorrespCity = c.String(maxLength: 35),
                        CorrespLocality = c.String(maxLength: 35),
                        CorrespCountry = c.String(maxLength: 2),
                        CorrespPostCode = c.String(maxLength: 15),
                        CorrespCashAccountNo = c.String(maxLength: 35),
                        CorrespSecAccountNo = c.String(maxLength: 35),
                        Relationship = c.String(maxLength: 1),
                        RegName1 = c.String(maxLength: 35),
                        PSET = c.String(maxLength: 14),
                        RegAddress1 = c.String(maxLength: 35),
                        RegAddress2 = c.String(maxLength: 35),
                        RegCity = c.String(maxLength: 35),
                        RegLocality = c.String(maxLength: 35),
                        RegCountry = c.String(maxLength: 2),
                        RegPostCode = c.String(maxLength: 15),
                        SettlementContact = c.String(maxLength: 35),
                        SettlementPhone = c.String(maxLength: 20),
                        SettlementFax = c.String(maxLength: 20),
                        SettlementTelex = c.String(maxLength: 20),
                        SpecialInstr1 = c.String(maxLength: 35),
                        SpecialInstr2 = c.String(maxLength: 35),
                        AffirmingPartyIndicator = c.String(maxLength: 1),
                        InstitutionBIC = c.String(maxLength: 11),
                        InstitutionContact = c.String(maxLength: 35),
                        InstitutionPhone = c.String(maxLength: 20),
                        IP1ID = c.String(maxLength: 8),
                        IP1BIC = c.String(maxLength: 11),
                        IP1AccountNo = c.String(maxLength: 25),
                        IP1Name = c.String(maxLength: 35),
                        IP1Contact = c.String(maxLength: 35),
                        IP1Phone = c.String(maxLength: 20),
                        IP1SpecialInstr1 = c.String(maxLength: 35),
                        IP1SpecialInstr2 = c.String(maxLength: 35),
                        IP2ID = c.String(maxLength: 8),
                        IP2BIC = c.String(maxLength: 11),
                        IP2AccountNo = c.String(maxLength: 25),
                        IP2Name = c.String(maxLength: 35),
                        IP2Contact = c.String(maxLength: 35),
                        IP2Phone = c.String(maxLength: 20),
                        IP2SpecialInstr1 = c.String(maxLength: 35),
                        IP2SpecialInstr2 = c.String(maxLength: 35),
                        IP3ID = c.String(maxLength: 8),
                        IP3BIC = c.String(maxLength: 11),
                        IP3AccountNo = c.String(maxLength: 25),
                        IP3Name = c.String(maxLength: 35),
                        IP3Contact = c.String(maxLength: 35),
                        IP3Phone = c.String(maxLength: 20),
                        IP3SpecialInstr1 = c.String(maxLength: 35),
                        IP3SpecialInstr2 = c.String(maxLength: 35),
                        ReceiverAgentBIC = c.String(maxLength: 11),
                        ReceiverAgentName = c.String(maxLength: 35),
                        LEI = c.String(maxLength: 20),
                        AccountLEI = c.String(maxLength: 35),
                        LargeTraderID = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailData",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TradeRegulator = c.String(maxLength: 34),
                        SettlementTransactionConditionIndicator = c.String(),
                        AdditionalFixedIncome_CtmId = c.Int(),
                        CommFeesTaxes_CtmId = c.Int(),
                        DirectedCommission_CtmId = c.Int(),
                        ExchangeRate_CtmId = c.Int(),
                        NetCashAmount_CtmId = c.Int(),
                        QuantityAllocated_CtmId = c.Int(),
                        SettlementAmount_CtmId = c.Int(),
                        TradeAmount_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome", t => t.AdditionalFixedIncome_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", t => t.CommFeesTaxes_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission", t => t.DirectedCommission_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataExchangeRate", t => t.ExchangeRate_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount", t => t.NetCashAmount_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated", t => t.QuantityAllocated_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataSettlementAmount", t => t.SettlementAmount_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount", t => t.TradeAmount_CtmId)
                .Index(t => t.AdditionalFixedIncome_CtmId)
                .Index(t => t.CommFeesTaxes_CtmId)
                .Index(t => t.DirectedCommission_CtmId)
                .Index(t => t.ExchangeRate_CtmId)
                .Index(t => t.NetCashAmount_CtmId)
                .Index(t => t.QuantityAllocated_CtmId)
                .Index(t => t.SettlementAmount_CtmId)
                .Index(t => t.TradeAmount_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrentFaceValue = c.Double(nullable: false),
                        OriginalFaceAmount = c.Double(nullable: false),
                        AccruedInterestAmount_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount", t => t.AccruedInterestAmount_CtmId)
                .Index(t => t.AccruedInterestAmount_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Commissions_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", t => t.Commissions_CtmId)
                .Index(t => t.Commissions_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CommissionSharingBasisIndicator = c.String(maxLength: 4),
                        CommissionType = c.String(maxLength: 4),
                        Commission_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission", t => t.Commission_CtmId)
                .Index(t => t.Commission_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CommissionSharingTypeIndicator = c.String(maxLength: 4),
                        BeneficiaryofCommissions_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions", t => t.BeneficiaryofCommissions_CtmId)
                .Index(t => t.BeneficiaryofCommissions_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ClearingSystemID = c.String(maxLength: 35),
                        PartyFundName = c.String(maxLength: 35),
                        BrokerOfCredit_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit", t => t.BrokerOfCredit_CtmId)
                .Index(t => t.BrokerOfCredit_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataExchangeRate",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ExchangeRateAmount = c.Double(nullable: false),
                        ToCurrency = c.String(maxLength: 3),
                        FromCurrency = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(maxLength: 4),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataSettlementAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TradeDetailProcessingReference = c.String(maxLength: 16),
                        CTMTradeDetailID = c.String(maxLength: 16),
                        ClientAllocationReference = c.String(maxLength: 16),
                        TradeDetailLinkages_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailLinkages", t => t.TradeDetailLinkages_CtmId)
                .Index(t => t.TradeDetailLinkages_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailLinkages",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TDReferences_TDReferenceType = c.String(maxLength: 4),
                        TDReferences_TDReferenceValue = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformation",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyCapacityIndicator = c.String(maxLength: 4),
                        OMNIExpected = c.String(maxLength: 1),
                        StipulationsNonStandard_StipulationCodeNonStandard = c.String(maxLength: 15),
                        StipulationsNonStandard_StipulationValueNonStandard = c.String(maxLength: 35),
                        AdditionalMunicipalDebtData_CtmId = c.Int(nullable: false),
                        AdditionalMunicipalDebtData_DiscountRate = c.Double(nullable: false),
                        AdditionalMunicipalDebtData_LegalStatus = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_PaymentIndicator = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_BasisIndicator = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_BondValuationIndicator = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_InterestAccrualDate = c.Int(nullable: false),
                        AdditionalMunicipalDebtData_InterestPaymentDate = c.Int(nullable: false),
                        AdditionalMunicipalDebtData_OptionCallIndicator = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_CallPutIndicator = c.String(),
                        AdditionalMunicipalDebtData_PutBondType = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_PutBondDate = c.Int(nullable: false),
                        AdditionalMunicipalDebtData_PutBondPrice = c.String(maxLength: 17),
                        AdditionalMunicipalDebtData_BondOwnershipIndicator = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_InterestPaymentFrequency = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_CouponType = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_FlatDefaultStatus = c.String(maxLength: 4),
                        AdditionalMunicipalDebtData_BondTaxStatus = c.String(maxLength: 4),
                        FactorEffectiveDate = c.Int(nullable: false),
                        RecordDate = c.Int(nullable: false),
                        AlternativeMinimumTax = c.String(maxLength: 4),
                        FederalTax = c.String(maxLength: 4),
                        IssueDate = c.Int(nullable: false),
                        WhenIssue = c.String(maxLength: 4),
                        PoolNumber = c.String(maxLength: 30),
                        CurrentFaceValue = c.String(maxLength: 17),
                        CallType = c.String(maxLength: 35),
                        DatedDate = c.Int(nullable: false),
                        Yield_YieldType = c.String(maxLength: 4),
                        Yield_Sign = c.String(maxLength: 1),
                        Yield_Amount = c.Double(nullable: false),
                        MaturityDate = c.Int(nullable: false),
                        CallDate = c.Int(nullable: false),
                        NumberOfDaysAccrued = c.Int(nullable: false),
                        IPOFlag = c.String(maxLength: 4),
                        BookEntry = c.String(maxLength: 4),
                        TradeTransactionConditionIndicator = c.String(maxLength: 4),
                        Issuer = c.String(maxLength: 35),
                        Listed = c.String(maxLength: 1),
                        PlaceOfClearing = c.String(maxLength: 8),
                        LotSize = c.String(maxLength: 15),
                        BestExecution = c.String(maxLength: 4),
                        TypeOfTransactionIndicator = c.String(maxLength: 4),
                        TypeOfPriceIndicator = c.String(maxLength: 4),
                        BuySellIndicator = c.String(maxLength: 4),
                        TypeOfFinancialInstrument = c.String(maxLength: 4),
                        CallPrice_CtmId = c.Int(),
                        CouponRate_CtmId = c.Int(),
                        CurrentFactor_CtmId = c.Int(),
                        DealPrice_CtmId = c.Int(),
                        PlaceOfTrade_CtmId = c.Int(),
                        QuantityOfTheBlockTrade_CtmId = c.Int(),
                        Rating_CtmId = c.Int(),
                        StipulationsStandard_CtmId = c.Int(),
                        TimeZone_CtmId = c.Int(),
                        TotalTradeAmount_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationCallPrice", t => t.CallPrice_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationCouponRate", t => t.CouponRate_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationCurrentFactor", t => t.CurrentFactor_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice", t => t.DealPrice_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade", t => t.PlaceOfTrade_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade", t => t.QuantityOfTheBlockTrade_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationRating", t => t.Rating_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard", t => t.StipulationsStandard_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone", t => t.TimeZone_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount", t => t.TotalTradeAmount_CtmId)
                .Index(t => t.CallPrice_CtmId)
                .Index(t => t.CouponRate_CtmId)
                .Index(t => t.CurrentFactor_CtmId)
                .Index(t => t.DealPrice_CtmId)
                .Index(t => t.PlaceOfTrade_CtmId)
                .Index(t => t.QuantityOfTheBlockTrade_CtmId)
                .Index(t => t.Rating_CtmId)
                .Index(t => t.StipulationsStandard_CtmId)
                .Index(t => t.TimeZone_CtmId)
                .Index(t => t.TotalTradeAmount_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationCallPrice",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        CurrencyCode = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationCouponRate",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationCurrentFactor",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PlaceCode = c.String(maxLength: 4),
                        PlaceNarrative = c.String(maxLength: 30),
                        OrgName = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(maxLength: 4),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationRating",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        RatingType = c.String(maxLength: 4),
                        RatingVendor = c.String(maxLength: 15),
                        RatingValue = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        StipulationCodeStandard = c.String(maxLength: 15),
                        StipulationValueStandard_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard", t => t.StipulationValueStandard_CtmId)
                .Index(t => t.StipulationValueStandard_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        StipulationStateCode = c.String(maxLength: 2),
                        StipulationY = c.String(maxLength: 1),
                        StipulationDate = c.Int(nullable: false),
                        StipulationAlphaNumeric = c.String(maxLength: 17),
                        StipulationNumeric = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TradeTimeQualifier = c.String(maxLength: 4),
                        CountryTimeZone_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_CountryTimeZone", t => t.CountryTimeZone_CtmId)
                .Index(t => t.CountryTimeZone_CtmId);
            
            CreateTable(
                "dbo.CTM_CountryTimeZone",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CountryCode = c.String(maxLength: 2),
                        TradeTimeQualifier = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CTMTradeSideId = c.String(maxLength: 16),
                        MasterReference = c.String(maxLength: 16),
                        TLReferences_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TLReferences", t => t.TLReferences_CtmId)
                .Index(t => t.TLReferences_CtmId);
            
            CreateTable(
                "dbo.CTM_TLReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TLReferenceType = c.String(maxLength: 4),
                        TLReferenceValue = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevel",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SubmitHeader_CtmId = c.Int(),
                        TradeLevelBody_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBody", t => t.TradeLevelBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId)
                .Index(t => t.TradeLevelBody_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        FunctionOfTheMessage = c.String(),
                        VersionOfTradeComponent = c.Byte(nullable: false),
                        ExecutingBroker_CtmId = c.Int(),
                        IdentificationOfASecurity_CtmId = c.Int(),
                        InstructingParty_CtmId = c.Int(),
                        TradeLevelInformation_CtmId = c.Int(),
                        TradeLevelReferences_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyIdentificationOfASecurity", t => t.IdentificationOfASecurity_CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyInstructingParty", t => t.InstructingParty_CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", t => t.TradeLevelInformation_CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelReferences", t => t.TradeLevelReferences_CtmId)
                .Index(t => t.ExecutingBroker_CtmId)
                .Index(t => t.IdentificationOfASecurity_CtmId)
                .Index(t => t.InstructingParty_CtmId)
                .Index(t => t.TradeLevelInformation_CtmId)
                .Index(t => t.TradeLevelReferences_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyIdentificationOfASecurity",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SecurityCodeType_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType", t => t.SecurityCodeType_CtmId)
                .Index(t => t.SecurityCodeType_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        NumberingAgencyCode = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyInstructingParty",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformation",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TypeOfTransactionIndicator = c.String(maxLength: 4),
                        BuySellIndicator = c.String(maxLength: 4),
                        TypeOfFinancialInstrument = c.String(maxLength: 4),
                        DealPrice_CtmId = c.Int(),
                        QuantityOfTheBlockTrade_CtmId = c.Int(),
                        TimeZone_CtmId = c.Int(),
                        TotalTradeAmount_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformationDealPrice", t => t.DealPrice_CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade", t => t.QuantityOfTheBlockTrade_CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformationTimeZone", t => t.TimeZone_CtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount", t => t.TotalTradeAmount_CtmId)
                .Index(t => t.DealPrice_CtmId)
                .Index(t => t.QuantityOfTheBlockTrade_CtmId)
                .Index(t => t.TimeZone_CtmId)
                .Index(t => t.TotalTradeAmount_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformationDealPrice",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(maxLength: 4),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformationTimeZone",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TradeTimeQualifier = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MasterReference = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_Valid",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ResponseHeader_CtmId = c.Int(),
                        ValidBody_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_ResponseHeader", t => t.ResponseHeader_CtmId)
                .ForeignKey("dbo.CTM_ValidBody", t => t.ValidBody_CtmId)
                .Index(t => t.ResponseHeader_CtmId)
                .Index(t => t.ValidBody_CtmId);
            
            CreateTable(
                "dbo.CTM_ValidBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        EchoMasterReference = c.Long(nullable: false),
                        CTMTradeSideId = c.String(maxLength: 16),
                        ExecutingBroker_CtmId = c.Int(),
                        InstructingParty_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_ValidBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .ForeignKey("dbo.CTM_ValidBodyInstructingParty", t => t.InstructingParty_CtmId)
                .Index(t => t.ExecutingBroker_CtmId)
                .Index(t => t.InstructingParty_CtmId);
            
            CreateTable(
                "dbo.CTM_ValidBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_ValidBodyInstructingParty",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.CtmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CTM_Trade", "Valid_CtmId", "dbo.CTM_Valid");
            DropForeignKey("dbo.CTM_Valid", "ValidBody_CtmId", "dbo.CTM_ValidBody");
            DropForeignKey("dbo.CTM_ValidBody", "InstructingParty_CtmId", "dbo.CTM_ValidBodyInstructingParty");
            DropForeignKey("dbo.CTM_ValidBody", "ExecutingBroker_CtmId", "dbo.CTM_ValidBodyExecutingBroker");
            DropForeignKey("dbo.CTM_Valid", "ResponseHeader_CtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_Trade", "TradeLevel_CtmId", "dbo.CTM_TradeLevel");
            DropForeignKey("dbo.CTM_TradeLevel", "TradeLevelBody_CtmId", "dbo.CTM_TradeLevelBody");
            DropForeignKey("dbo.CTM_TradeLevelBody", "TradeLevelReferences_CtmId", "dbo.CTM_TradeLevelBodyTradeLevelReferences");
            DropForeignKey("dbo.CTM_TradeLevelBody", "TradeLevelInformation_CtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformation");
            DropForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", "TotalTradeAmount_CtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount");
            DropForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", "TimeZone_CtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformationTimeZone");
            DropForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", "QuantityOfTheBlockTrade_CtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", "DealPrice_CtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformationDealPrice");
            DropForeignKey("dbo.CTM_TradeLevelBody", "InstructingParty_CtmId", "dbo.CTM_TradeLevelBodyInstructingParty");
            DropForeignKey("dbo.CTM_TradeLevelBody", "IdentificationOfASecurity_CtmId", "dbo.CTM_TradeLevelBodyIdentificationOfASecurity");
            DropForeignKey("dbo.CTM_TradeLevelBodyIdentificationOfASecurity", "SecurityCodeType_CtmId", "dbo.CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType");
            DropForeignKey("dbo.CTM_TradeLevelBody", "ExecutingBroker_CtmId", "dbo.CTM_TradeLevelBodyExecutingBroker");
            DropForeignKey("dbo.CTM_TradeLevel", "SubmitHeader_CtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_Trade", "TradeDetail_CtmId", "dbo.CTM_TradeDetail");
            DropForeignKey("dbo.CTM_TradeDetail", "TradeDetailBody_CtmId", "dbo.CTM_TradeDetailBody");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeLevelReferences_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelReferences");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelReferences", "TLReferences_CtmId", "dbo.CTM_TLReferences");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeLevelInformation_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformation");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "TotalTradeAmount_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "TimeZone_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone", "CountryTimeZone_CtmId", "dbo.CTM_CountryTimeZone");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsStandard_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard", "StipulationValueStandard_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Rating_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationRating");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "QuantityOfTheBlockTrade_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "PlaceOfTrade_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "DealPrice_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "CurrentFactor_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationCurrentFactor");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "CouponRate_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationCouponRate");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "CallPrice_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationCallPrice");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeDetailReferences_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailReferences");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailReferences", "TradeDetailLinkages_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailLinkages");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeDetailData_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailData");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "TradeAmount_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "SettlementAmount_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataSettlementAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "QuantityAllocated_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "NetCashAmount_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "ExchangeRate_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataExchangeRate");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "DirectedCommission_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission", "BeneficiaryofCommissions_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions", "BrokerOfCredit_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "CommFeesTaxes_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", "Commissions_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", "Commission_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "AdditionalFixedIncome_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome", "AccruedInterestAmount_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount");
            DropForeignKey("dbo.CTM_TradeDetailBody", "PartySettlement_CtmId", "dbo.CTM_TradeDetailBodyPartySettlement");
            DropForeignKey("dbo.CTM_TradeDetailBodyPartySettlement", "SettlementInstructions_CtmId", "dbo.CTM_TradeDetailBodyPartySettlementSettlementInstructions");
            DropForeignKey("dbo.CTM_TradeDetailBodyPartySettlement", "PlaceOfSafekeeping_CtmId", "dbo.CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping");
            DropForeignKey("dbo.CTM_TradeDetailBody", "IPSettlement_CtmId", "dbo.CTM_TradeDetailBodyIPSettlement");
            DropForeignKey("dbo.CTM_TradeDetailBody", "InstructingParty_CtmId", "dbo.CTM_TradeDetailBodyInstructingParty");
            DropForeignKey("dbo.CTM_TradeDetailBody", "IdentificationOfASecurity_CtmId", "dbo.CTM_TradeDetailBodyIdentificationOfASecurity");
            DropForeignKey("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", "SecurityCodeType_CtmId", "dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType");
            DropForeignKey("dbo.CTM_TradeDetailBody", "ExecutingBroker_CtmId", "dbo.CTM_TradeDetailBodyExecutingBroker");
            DropForeignKey("dbo.CTM_TradeDetailBody", "EBSettlement_CtmId", "dbo.CTM_TradeDetailBodyAdditionalDataEBSettlement");
            DropForeignKey("dbo.CTM_TradeDetailBody", "ConfirmDisclosureData_CtmId", "dbo.CTM_TradeDetailBodyConfirmDisclosureData");
            DropForeignKey("dbo.CTM_TradeDetailBody", "AdditionalSecurityIdentifiers_CtmId", "dbo.CTM_AdditionalSecurityIdentifiers");
            DropForeignKey("dbo.CTM_AdditionalSecurityIdentifiers", "SecurityCodeType_CtmId", "dbo.CTM_AdditionalSecurityIdentifiersSecurityCodeType");
            DropForeignKey("dbo.CTM_TradeDetailBody", "AdditionalDisclosures_CtmId", "dbo.CTM_TradeDetailBodyAdditionalDisclosures");
            DropForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosures", "ReportedPrice_CtmId", "dbo.CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice");
            DropForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosures", "MarkUpMarkDown_CtmId", "dbo.CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown");
            DropForeignKey("dbo.CTM_TradeDetailBody", "AdditionalDataIPSettlement_CtmId", "dbo.CTM_TradeDetailBodyAdditionalDataIPSettlement");
            DropForeignKey("dbo.CTM_TradeDetailBody", "AdditionalData_CtmId", "dbo.CTM_TradeDetailBodyAdditionalData");
            DropForeignKey("dbo.CTM_TradeDetail", "SubmitHeader_CtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_Trade", "MultiTradeLevelResponse_CtmId", "dbo.CTM_MultiTradeLevelResponse");
            DropForeignKey("dbo.CTM_MultiTradeLevelResponse", "ResponseHeader_CtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_MultiTradeLevelResponse", "MultiTradeLevelResponseBody_CtmId", "dbo.CTM_MultiTradeLevelResponseBody");
            DropForeignKey("dbo.CTM_Trade", "MultiTradeLevelRequest_CtmId", "dbo.CTM_MultiTradeLevelRequest");
            DropForeignKey("dbo.CTM_MultiTradeLevelRequest", "SubmitHeader_CtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_MultiTradeLevelRequest", "MultiTradeLevelRequestBody_CtmId", "dbo.CTM_MultiTradeLevelRequestBody");
            DropForeignKey("dbo.CTM_Trade", "MultiTradeDetailResponse_CtmId", "dbo.CTM_MultiTradeDetailResponse");
            DropForeignKey("dbo.CTM_MultiTradeDetailResponse", "ResponseHeader_CtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_MultiTradeDetailResponse", "MultiTradeDetailResponseBody_CtmId", "dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody");
            DropForeignKey("dbo.CTM_Trade", "MultiTradeDetailRequest_CtmId", "dbo.CTM_MultiTradeDetailRequest");
            DropForeignKey("dbo.CTM_MultiTradeDetailRequest", "SubmitHeader_CtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_MultiTradeDetailRequest", "MultiTradeDetailRequestBody_CtmId", "dbo.CTM_MultiTradeDetailRequestBody");
            DropForeignKey("dbo.CTM_Trade", "Invalid_CtmId", "dbo.CTM_Invalid");
            DropForeignKey("dbo.CTM_Invalid", "InvalidHeader_CtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_ResponseHeader", "RecipientOfMessage_CtmId", "dbo.CTM_RecipientOfMessage");
            DropForeignKey("dbo.CTM_ResponseHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.CTM_ResponseHeader", "AuditTrail_CtmId", "dbo.CTM_ResponseHeaderAuditTrail");
            DropForeignKey("dbo.CTM_ResponseHeader", "AuditEvent_CtmId", "dbo.CTM_ResponseHeaderAuditEvent");
            DropForeignKey("dbo.CTM_Invalid", "InvalidBody_CtmId", "dbo.CTM_InvalidBody");
            DropForeignKey("dbo.CTM_InvalidBody", "SynchError_CtmId", "dbo.CTM_InvalidBodySynchError");
            DropForeignKey("dbo.CTM_Trade", "InfoRequest_CtmId", "dbo.CTM_InfoRequest");
            DropForeignKey("dbo.CTM_InfoRequest", "SubmitHeader_CtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_Header", "RecipientOfMessage_CtmId", "dbo.CTM_RecipientOfMessage");
            DropForeignKey("dbo.CTM_Header", "OriginatorOfMessage_CtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.CTM_InfoRequest", "InfoRequestBody_CtmId", "dbo.CTM_InfoRequestBody");
            DropForeignKey("dbo.CTM_InfoRequestBody", "ExecutingBroker_CtmId", "dbo.CTM_InfoRequestBodyExecutingBroker");
            DropForeignKey("dbo.CTM_InfoRequestBody", "AccessPath_CtmId", "dbo.CTM_InfoRequestBodyAccessPath");
            DropForeignKey("dbo.CTM_InfoRequestBodyAccessPath", "TradeLevelIdentifiers_CtmId", "dbo.CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers");
            DropIndex("dbo.CTM_ValidBody", new[] { "InstructingParty_CtmId" });
            DropIndex("dbo.CTM_ValidBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_Valid", new[] { "ValidBody_CtmId" });
            DropIndex("dbo.CTM_Valid", new[] { "ResponseHeader_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyTradeLevelInformation", new[] { "TotalTradeAmount_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyTradeLevelInformation", new[] { "TimeZone_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyTradeLevelInformation", new[] { "QuantityOfTheBlockTrade_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyTradeLevelInformation", new[] { "DealPrice_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyIdentificationOfASecurity", new[] { "SecurityCodeType_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "TradeLevelReferences_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "TradeLevelInformation_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "InstructingParty_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "IdentificationOfASecurity_CtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_TradeLevel", new[] { "TradeLevelBody_CtmId" });
            DropIndex("dbo.CTM_TradeLevel", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelReferences", new[] { "TLReferences_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone", new[] { "CountryTimeZone_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard", new[] { "StipulationValueStandard_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "TotalTradeAmount_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "TimeZone_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "StipulationsStandard_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "Rating_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "QuantityOfTheBlockTrade_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "PlaceOfTrade_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "DealPrice_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "CurrentFactor_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "CouponRate_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "CallPrice_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailReferences", new[] { "TradeDetailLinkages_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions", new[] { "BrokerOfCredit_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission", new[] { "BeneficiaryofCommissions_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", new[] { "Commission_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", new[] { "Commissions_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome", new[] { "AccruedInterestAmount_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "TradeAmount_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "SettlementAmount_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "QuantityAllocated_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "NetCashAmount_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "ExchangeRate_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "DirectedCommission_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "CommFeesTaxes_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "AdditionalFixedIncome_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyPartySettlement", new[] { "SettlementInstructions_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyPartySettlement", new[] { "PlaceOfSafekeeping_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", new[] { "SecurityCodeType_CtmId" });
            DropIndex("dbo.CTM_AdditionalSecurityIdentifiers", new[] { "SecurityCodeType_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyAdditionalDisclosures", new[] { "ReportedPrice_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyAdditionalDisclosures", new[] { "MarkUpMarkDown_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeLevelReferences_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeLevelInformation_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeDetailReferences_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeDetailData_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "PartySettlement_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "IPSettlement_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "InstructingParty_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "IdentificationOfASecurity_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "EBSettlement_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "ConfirmDisclosureData_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "AdditionalSecurityIdentifiers_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "AdditionalDisclosures_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "AdditionalDataIPSettlement_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "AdditionalData_CtmId" });
            DropIndex("dbo.CTM_TradeDetail", new[] { "TradeDetailBody_CtmId" });
            DropIndex("dbo.CTM_TradeDetail", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_MultiTradeLevelResponse", new[] { "ResponseHeader_CtmId" });
            DropIndex("dbo.CTM_MultiTradeLevelResponse", new[] { "MultiTradeLevelResponseBody_CtmId" });
            DropIndex("dbo.CTM_MultiTradeLevelRequest", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_MultiTradeLevelRequest", new[] { "MultiTradeLevelRequestBody_CtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailResponse", new[] { "ResponseHeader_CtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailResponse", new[] { "MultiTradeDetailResponseBody_CtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailRequest", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailRequest", new[] { "MultiTradeDetailRequestBody_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "AuditTrail_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "AuditEvent_CtmId" });
            DropIndex("dbo.CTM_InvalidBody", new[] { "SynchError_CtmId" });
            DropIndex("dbo.CTM_Invalid", new[] { "InvalidHeader_CtmId" });
            DropIndex("dbo.CTM_Invalid", new[] { "InvalidBody_CtmId" });
            DropIndex("dbo.CTM_Header", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_Header", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_InfoRequestBodyAccessPath", new[] { "TradeLevelIdentifiers_CtmId" });
            DropIndex("dbo.CTM_InfoRequestBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_InfoRequestBody", new[] { "AccessPath_CtmId" });
            DropIndex("dbo.CTM_InfoRequest", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_InfoRequest", new[] { "InfoRequestBody_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "Valid_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "TradeLevel_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "TradeDetail_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "MultiTradeLevelResponse_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "MultiTradeLevelRequest_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "MultiTradeDetailResponse_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "MultiTradeDetailRequest_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "Invalid_CtmId" });
            DropIndex("dbo.CTM_Trade", new[] { "InfoRequest_CtmId" });
            DropTable("dbo.CTM_ValidBodyInstructingParty");
            DropTable("dbo.CTM_ValidBodyExecutingBroker");
            DropTable("dbo.CTM_ValidBody");
            DropTable("dbo.CTM_Valid");
            DropTable("dbo.CTM_TradeLevelBodyTradeLevelReferences");
            DropTable("dbo.CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount");
            DropTable("dbo.CTM_TradeLevelBodyTradeLevelInformationTimeZone");
            DropTable("dbo.CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropTable("dbo.CTM_TradeLevelBodyTradeLevelInformationDealPrice");
            DropTable("dbo.CTM_TradeLevelBodyTradeLevelInformation");
            DropTable("dbo.CTM_TradeLevelBodyInstructingParty");
            DropTable("dbo.CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType");
            DropTable("dbo.CTM_TradeLevelBodyIdentificationOfASecurity");
            DropTable("dbo.CTM_TradeLevelBodyExecutingBroker");
            DropTable("dbo.CTM_TradeLevelBody");
            DropTable("dbo.CTM_TradeLevel");
            DropTable("dbo.CTM_TLReferences");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelReferences");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount");
            DropTable("dbo.CTM_CountryTimeZone");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationRating");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationCurrentFactor");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationCouponRate");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationCallPrice");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformation");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailLinkages");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailReferences");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataSettlementAmount");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataExchangeRate");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailData");
            DropTable("dbo.CTM_TradeDetailBodyPartySettlementSettlementInstructions");
            DropTable("dbo.CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping");
            DropTable("dbo.CTM_TradeDetailBodyPartySettlement");
            DropTable("dbo.CTM_TradeDetailBodyIPSettlement");
            DropTable("dbo.CTM_TradeDetailBodyInstructingParty");
            DropTable("dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType");
            DropTable("dbo.CTM_TradeDetailBodyIdentificationOfASecurity");
            DropTable("dbo.CTM_TradeDetailBodyExecutingBroker");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDataEBSettlement");
            DropTable("dbo.CTM_TradeDetailBodyConfirmDisclosureData");
            DropTable("dbo.CTM_AdditionalSecurityIdentifiersSecurityCodeType");
            DropTable("dbo.CTM_AdditionalSecurityIdentifiers");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDisclosures");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDataIPSettlement");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalData");
            DropTable("dbo.CTM_TradeDetailBody");
            DropTable("dbo.CTM_TradeDetail");
            DropTable("dbo.CTM_MultiTradeLevelResponseBody");
            DropTable("dbo.CTM_MultiTradeLevelResponse");
            DropTable("dbo.CTM_MultiTradeLevelRequestBody");
            DropTable("dbo.CTM_MultiTradeLevelRequest");
            DropTable("dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody");
            DropTable("dbo.CTM_MultiTradeDetailResponse");
            DropTable("dbo.CTM_MultiTradeDetailRequestBody");
            DropTable("dbo.CTM_MultiTradeDetailRequest");
            DropTable("dbo.CTM_ResponseHeaderAuditTrail");
            DropTable("dbo.CTM_ResponseHeaderAuditEvent");
            DropTable("dbo.CTM_ResponseHeader");
            DropTable("dbo.CTM_InvalidBodySynchError");
            DropTable("dbo.CTM_InvalidBody");
            DropTable("dbo.CTM_Invalid");
            DropTable("dbo.CTM_RecipientOfMessage");
            DropTable("dbo.CTM_OriginatorOfMessage");
            DropTable("dbo.CTM_Header");
            DropTable("dbo.CTM_InfoRequestBodyExecutingBroker");
            DropTable("dbo.CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers");
            DropTable("dbo.CTM_InfoRequestBodyAccessPath");
            DropTable("dbo.CTM_InfoRequestBody");
            DropTable("dbo.CTM_InfoRequest");
            DropTable("dbo.CTM_Trade");
        }
    }
}
