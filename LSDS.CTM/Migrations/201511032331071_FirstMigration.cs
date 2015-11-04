namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTM_Message",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        LastUpdated = c.DateTime(nullable: false),
                        InfoRequest_InfoRequestCtmId = c.Int(),
                        Invalid_InvalidCtmId = c.Int(),
                        MultiTradeDetailRequest_MultiTradeDetailRequestCtmId = c.Int(),
                        MultiTradeDetailResponse_TradeDetailResponseCtmId = c.Int(),
                        MultiTradeLevelRequest_TradeLevelRequestCtmId = c.Int(),
                        MultiTradeLevelResponse_ResponseCtmId = c.Int(),
                        TradeDetail_TradeDetailCtmId = c.Int(),
                        TradeLevel_TradeLevelCtmId = c.Int(),
                        Valid_ValidCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_InfoRequest", t => t.InfoRequest_InfoRequestCtmId)
                .ForeignKey("dbo.CTM_Invalid", t => t.Invalid_InvalidCtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailRequest", t => t.MultiTradeDetailRequest_MultiTradeDetailRequestCtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailResponse", t => t.MultiTradeDetailResponse_TradeDetailResponseCtmId)
                .ForeignKey("dbo.CTM_MultiTradeLevelRequest", t => t.MultiTradeLevelRequest_TradeLevelRequestCtmId)
                .ForeignKey("dbo.CTM_MultiTradeLevelResponse", t => t.MultiTradeLevelResponse_ResponseCtmId)
                .ForeignKey("dbo.CTM_TradeDetail", t => t.TradeDetail_TradeDetailCtmId)
                .ForeignKey("dbo.CTM_TradeLevel", t => t.TradeLevel_TradeLevelCtmId)
                .ForeignKey("dbo.CTM_Valid", t => t.Valid_ValidCtmId)
                .Index(t => t.InfoRequest_InfoRequestCtmId)
                .Index(t => t.Invalid_InvalidCtmId)
                .Index(t => t.MultiTradeDetailRequest_MultiTradeDetailRequestCtmId)
                .Index(t => t.MultiTradeDetailResponse_TradeDetailResponseCtmId)
                .Index(t => t.MultiTradeLevelRequest_TradeLevelRequestCtmId)
                .Index(t => t.MultiTradeLevelResponse_ResponseCtmId)
                .Index(t => t.TradeDetail_TradeDetailCtmId)
                .Index(t => t.TradeLevel_TradeLevelCtmId)
                .Index(t => t.Valid_ValidCtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequest",
                c => new
                    {
                        InfoRequestCtmId = c.Int(nullable: false, identity: true),
                        InfoRequestBody_InfoRequestBodyCtmId = c.Int(),
                        SubmitHeader_HeaderCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.InfoRequestCtmId)
                .ForeignKey("dbo.CTM_InfoRequestBody", t => t.InfoRequestBody_InfoRequestBodyCtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_HeaderCtmId)
                .Index(t => t.InfoRequestBody_InfoRequestBodyCtmId)
                .Index(t => t.SubmitHeader_HeaderCtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequestBody",
                c => new
                    {
                        InfoRequestBodyCtmId = c.Int(nullable: false, identity: true),
                        ViewRequestedIndicator = c.String(),
                        QueryType = c.String(),
                        AccessPath_InfoRequestBodyAccessPathCtmId = c.Int(),
                        ExecutingBroker_ExecutingBrokerCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.InfoRequestBodyCtmId)
                .ForeignKey("dbo.CTM_InfoRequestBodyAccessPath", t => t.AccessPath_InfoRequestBodyAccessPathCtmId)
                .ForeignKey("dbo.CTM_InfoRequestBodyExecutingBroker", t => t.ExecutingBroker_ExecutingBrokerCtmId)
                .Index(t => t.AccessPath_InfoRequestBodyAccessPathCtmId)
                .Index(t => t.ExecutingBroker_ExecutingBrokerCtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequestBodyAccessPath",
                c => new
                    {
                        InfoRequestBodyAccessPathCtmId = c.Int(nullable: false, identity: true),
                        IDOwner = c.String(),
                        TradeLevelIdentifiers_AccessPathTradeLevelIdentifiersCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.InfoRequestBodyAccessPathCtmId)
                .ForeignKey("dbo.CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers", t => t.TradeLevelIdentifiers_AccessPathTradeLevelIdentifiersCtmId)
                .Index(t => t.TradeLevelIdentifiers_AccessPathTradeLevelIdentifiersCtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers",
                c => new
                    {
                        AccessPathTradeLevelIdentifiersCtmId = c.Int(nullable: false, identity: true),
                        MasterReference = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.AccessPathTradeLevelIdentifiersCtmId);
            
            CreateTable(
                "dbo.CTM_InfoRequestBodyExecutingBroker",
                c => new
                    {
                        ExecutingBrokerCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.ExecutingBrokerCtmId);
            
            CreateTable(
                "dbo.CTM_Header",
                c => new
                    {
                        HeaderCtmId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 32),
                        ProtocolVersion = c.String(maxLength: 4),
                        SendersMessageReference = c.String(maxLength: 16),
                        DateTimeOfSentMsg = c.DateTime(nullable: false),
                        OriginatorOfMessage_OriginatorOfMessageCtmId = c.Int(),
                        RecipientOfMessage_RecipientOfMessageCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.HeaderCtmId)
                .ForeignKey("dbo.CTM_OriginatorOfMessage", t => t.OriginatorOfMessage_OriginatorOfMessageCtmId)
                .ForeignKey("dbo.CTM_RecipientOfMessage", t => t.RecipientOfMessage_RecipientOfMessageCtmId)
                .Index(t => t.OriginatorOfMessage_OriginatorOfMessageCtmId)
                .Index(t => t.RecipientOfMessage_RecipientOfMessageCtmId);
            
            CreateTable(
                "dbo.CTM_OriginatorOfMessage",
                c => new
                    {
                        OriginatorOfMessageCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.OriginatorOfMessageCtmId);
            
            CreateTable(
                "dbo.CTM_RecipientOfMessage",
                c => new
                    {
                        RecipientOfMessageCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.RecipientOfMessageCtmId);
            
            CreateTable(
                "dbo.CTM_Invalid",
                c => new
                    {
                        InvalidCtmId = c.Int(nullable: false, identity: true),
                        InvalidBody_InvalidBodyCtmId = c.Int(),
                        InvalidHeader_ResponseHeaderCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.InvalidCtmId)
                .ForeignKey("dbo.CTM_InvalidBody", t => t.InvalidBody_InvalidBodyCtmId)
                .ForeignKey("dbo.CTM_ResponseHeader", t => t.InvalidHeader_ResponseHeaderCtmId)
                .Index(t => t.InvalidBody_InvalidBodyCtmId)
                .Index(t => t.InvalidHeader_ResponseHeaderCtmId);
            
            CreateTable(
                "dbo.CTM_InvalidBody",
                c => new
                    {
                        InvalidBodyCtmId = c.Int(nullable: false, identity: true),
                        OriginalMessage = c.String(),
                        SynchError_InvalidBodySynchErrorCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.InvalidBodyCtmId)
                .ForeignKey("dbo.CTM_InvalidBodySynchError", t => t.SynchError_InvalidBodySynchErrorCtmId)
                .Index(t => t.SynchError_InvalidBodySynchErrorCtmId);
            
            CreateTable(
                "dbo.CTM_InvalidBodySynchError",
                c => new
                    {
                        InvalidBodySynchErrorCtmId = c.Int(nullable: false, identity: true),
                        ErrorId = c.Byte(nullable: false),
                        ErrorKey = c.String(),
                        ErrorText = c.String(),
                    })
                .PrimaryKey(t => t.InvalidBodySynchErrorCtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeader",
                c => new
                    {
                        ResponseHeaderCtmId = c.Int(nullable: false, identity: true),
                        EchoUserId = c.String(maxLength: 32),
                        ProtocolVersion = c.String(maxLength: 4),
                        EchoSendersMessageReference = c.String(maxLength: 16),
                        EchoDateTimeOfSentMsg = c.DateTime(nullable: false),
                        AuditEvent_AuditEventCtmId = c.Int(),
                        AuditTrail_AuditTrailCtmId = c.Int(),
                        OriginatorOfMessage_OriginatorOfMessageCtmId = c.Int(),
                        RecipientOfMessage_RecipientOfMessageCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.ResponseHeaderCtmId)
                .ForeignKey("dbo.CTM_ResponseHeaderAuditEvent", t => t.AuditEvent_AuditEventCtmId)
                .ForeignKey("dbo.CTM_ResponseHeaderAuditTrail", t => t.AuditTrail_AuditTrailCtmId)
                .ForeignKey("dbo.CTM_OriginatorOfMessage", t => t.OriginatorOfMessage_OriginatorOfMessageCtmId)
                .ForeignKey("dbo.CTM_RecipientOfMessage", t => t.RecipientOfMessage_RecipientOfMessageCtmId)
                .Index(t => t.AuditEvent_AuditEventCtmId)
                .Index(t => t.AuditTrail_AuditTrailCtmId)
                .Index(t => t.OriginatorOfMessage_OriginatorOfMessageCtmId)
                .Index(t => t.RecipientOfMessage_RecipientOfMessageCtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeaderAuditEvent",
                c => new
                    {
                        AuditEventCtmId = c.Int(nullable: false, identity: true),
                        AuditEventDepth = c.Int(nullable: false),
                        AuditEventTag = c.String(maxLength: 255),
                        AuditEventName = c.String(maxLength: 255),
                        AuditEventArg = c.String(maxLength: 255),
                        AuditEventStart = c.Int(nullable: false),
                        AuditEventEnd = c.Int(nullable: false),
                        AuditEventInclMs = c.Int(nullable: false),
                        AuditEventExclIMs = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuditEventCtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeaderAuditTrail",
                c => new
                    {
                        AuditTrailCtmId = c.Int(nullable: false, identity: true),
                        AuditReason = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.AuditTrailCtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeDetailRequest",
                c => new
                    {
                        MultiTradeDetailRequestCtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailRequestBody_RequestBodyCtmId = c.Int(),
                        SubmitHeader_HeaderCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.MultiTradeDetailRequestCtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailRequestBody", t => t.MultiTradeDetailRequestBody_RequestBodyCtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_HeaderCtmId)
                .Index(t => t.MultiTradeDetailRequestBody_RequestBodyCtmId)
                .Index(t => t.SubmitHeader_HeaderCtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeDetailRequestBody",
                c => new
                    {
                        RequestBodyCtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailResponseRequested = c.String(),
                        ByOrAgainstFlag = c.String(),
                        MinLastUpdateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RequestBodyCtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeDetailResponse",
                c => new
                    {
                        TradeDetailResponseCtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailResponseBody_TradeDetailResponseBodyCtmId = c.Int(),
                        ResponseHeader_ResponseHeaderCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeDetailResponseCtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody", t => t.MultiTradeDetailResponseBody_TradeDetailResponseBodyCtmId)
                .ForeignKey("dbo.CTM_ResponseHeader", t => t.ResponseHeader_ResponseHeaderCtmId)
                .Index(t => t.MultiTradeDetailResponseBody_TradeDetailResponseBodyCtmId)
                .Index(t => t.ResponseHeader_ResponseHeaderCtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody",
                c => new
                    {
                        TradeDetailResponseBodyCtmId = c.Int(nullable: false, identity: true),
                        RecordsReturnedCount = c.Byte(nullable: false),
                        MoreFlag = c.String(),
                        GoodThroughDateTime = c.DateTime(nullable: false),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.TradeDetailResponseBodyCtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeLevelRequest",
                c => new
                    {
                        TradeLevelRequestCtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelRequestBody_TradeLevelRequestBodyCtmId = c.Int(),
                        SubmitHeader_HeaderCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeLevelRequestCtmId)
                .ForeignKey("dbo.CTM_MultiTradeLevelRequestBody", t => t.MultiTradeLevelRequestBody_TradeLevelRequestBodyCtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_HeaderCtmId)
                .Index(t => t.MultiTradeLevelRequestBody_TradeLevelRequestBodyCtmId)
                .Index(t => t.SubmitHeader_HeaderCtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeLevelRequestBody",
                c => new
                    {
                        TradeLevelRequestBodyCtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelResponseIndicator = c.String(),
                        ByOrAgainstFlag = c.String(),
                        MinLastUpdateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TradeLevelRequestBodyCtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeLevelResponse",
                c => new
                    {
                        ResponseCtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelResponseBody_MultiTradeLevelResponseBodyCtmId = c.Int(),
                        ResponseHeader_ResponseHeaderCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.ResponseCtmId)
                .ForeignKey("dbo.CTM_MultiTradeLevelResponseBody", t => t.MultiTradeLevelResponseBody_MultiTradeLevelResponseBodyCtmId)
                .ForeignKey("dbo.CTM_ResponseHeader", t => t.ResponseHeader_ResponseHeaderCtmId)
                .Index(t => t.MultiTradeLevelResponseBody_MultiTradeLevelResponseBodyCtmId)
                .Index(t => t.ResponseHeader_ResponseHeaderCtmId);
            
            CreateTable(
                "dbo.CTM_MultiTradeLevelResponseBody",
                c => new
                    {
                        MultiTradeLevelResponseBodyCtmId = c.Int(nullable: false, identity: true),
                        RecordsReturnedCount = c.Byte(nullable: false),
                        MoreFlag = c.String(),
                        GoodThroughDateTime = c.DateTime(nullable: false),
                        MultiTradeLevelResponseIndicator = c.String(),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.MultiTradeLevelResponseBodyCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetail",
                c => new
                    {
                        TradeDetailCtmId = c.Int(nullable: false, identity: true),
                        SubmitHeader_HeaderCtmId = c.Int(),
                        TradeDetailBody_TradeDetailBodyCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeDetailCtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_HeaderCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBody", t => t.TradeDetailBody_TradeDetailBodyCtmId)
                .Index(t => t.SubmitHeader_HeaderCtmId)
                .Index(t => t.TradeDetailBody_TradeDetailBodyCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBody",
                c => new
                    {
                        TradeDetailBodyCtmId = c.Int(nullable: false, identity: true),
                        TDUpdateGuard = c.String(maxLength: 35),
                        L2MatchingProfileName = c.String(maxLength: 35),
                        ShowHiddenFieldsIndicator = c.String(maxLength: 35),
                        ProcessingIndicator = c.String(maxLength: 4),
                        ReportingIndicator = c.String(maxLength: 4),
                        DetailLevelPartyCapacityIndicator = c.String(maxLength: 4),
                        FunctionOfTheMessage = c.String(maxLength: 4),
                        VersionOfTradeComponent = c.Byte(nullable: false),
                        TradeLevelExpected = c.String(maxLength: 1),
                        AdditionalData_AdditionalDataCtmId = c.Int(),
                        AdditionalDisclosures_DisclosuresCtmId = c.Int(),
                        AdditionalSecurityIdentifiers_SecurityIdentifiersCtmId = c.Int(),
                        ConfirmDisclosureData_DisclosureDataCtmId = c.Int(),
                        CPTYTradeLevelIdentifiers_IdentifiersCtmId = c.Int(),
                        EBSettlement_EBSettlementCtmId = c.Int(),
                        ExecutingBroker_ExecutingBrokerCtmId = c.Int(),
                        IdentificationOfASecurity_IdentificationOfASecurityCtmId = c.Int(),
                        InstructingParty_InstructingPartyCtmId = c.Int(),
                        IPSettlement_IPSettlementCtmId = c.Int(),
                        PartySettlement_PartySettlementCtmId = c.Int(),
                        ThirdPartyToTrade_ThirdPartyToTradeCtmId = c.Int(),
                        TradeDetailData_TradeDetailDataCtmId = c.Int(),
                        TradeDetailReferences_TradeDetailReferencesCtmId = c.Int(),
                        TradeLevelInformation_TradeLevelInformationCtmId = c.Int(),
                        TradeLevelReferences_ReferencesCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeDetailBodyCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalData", t => t.AdditionalData_AdditionalDataCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosures", t => t.AdditionalDisclosures_DisclosuresCtmId)
                .ForeignKey("dbo.CTM_AdditionalSecurityIdentifiers", t => t.AdditionalSecurityIdentifiers_SecurityIdentifiersCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyConfirmDisclosureData", t => t.ConfirmDisclosureData_DisclosureDataCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyCPTYTradeLevelIdentifiers", t => t.CPTYTradeLevelIdentifiers_IdentifiersCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDataEBSettlement", t => t.EBSettlement_EBSettlementCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyExecutingBroker", t => t.ExecutingBroker_ExecutingBrokerCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", t => t.IdentificationOfASecurity_IdentificationOfASecurityCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyInstructingParty", t => t.InstructingParty_InstructingPartyCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyIPSettlement", t => t.IPSettlement_IPSettlementCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyPartySettlement", t => t.PartySettlement_PartySettlementCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyThirdPartyToTrade", t => t.ThirdPartyToTrade_ThirdPartyToTradeCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", t => t.TradeDetailData_TradeDetailDataCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailReferences", t => t.TradeDetailReferences_TradeDetailReferencesCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", t => t.TradeLevelInformation_TradeLevelInformationCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelReferences", t => t.TradeLevelReferences_ReferencesCtmId)
                .Index(t => t.AdditionalData_AdditionalDataCtmId)
                .Index(t => t.AdditionalDisclosures_DisclosuresCtmId)
                .Index(t => t.AdditionalSecurityIdentifiers_SecurityIdentifiersCtmId)
                .Index(t => t.ConfirmDisclosureData_DisclosureDataCtmId)
                .Index(t => t.CPTYTradeLevelIdentifiers_IdentifiersCtmId)
                .Index(t => t.EBSettlement_EBSettlementCtmId)
                .Index(t => t.ExecutingBroker_ExecutingBrokerCtmId)
                .Index(t => t.IdentificationOfASecurity_IdentificationOfASecurityCtmId)
                .Index(t => t.InstructingParty_InstructingPartyCtmId)
                .Index(t => t.IPSettlement_IPSettlementCtmId)
                .Index(t => t.PartySettlement_PartySettlementCtmId)
                .Index(t => t.ThirdPartyToTrade_ThirdPartyToTradeCtmId)
                .Index(t => t.TradeDetailData_TradeDetailDataCtmId)
                .Index(t => t.TradeDetailReferences_TradeDetailReferencesCtmId)
                .Index(t => t.TradeLevelInformation_TradeLevelInformationCtmId)
                .Index(t => t.TradeLevelReferences_ReferencesCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalData",
                c => new
                    {
                        AdditionalDataCtmId = c.Int(nullable: false, identity: true),
                        AdditionalText = c.String(maxLength: 35),
                        DataXML = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.AdditionalDataCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDisclosures",
                c => new
                    {
                        DisclosuresCtmId = c.Int(nullable: false, identity: true),
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
                        MarkUpMarkDown_MarkUpMarkDownCtmId = c.Int(),
                        ReportedPrice_ReportedPriceCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.DisclosuresCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown", t => t.MarkUpMarkDown_MarkUpMarkDownCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice", t => t.ReportedPrice_ReportedPriceCtmId)
                .Index(t => t.MarkUpMarkDown_MarkUpMarkDownCtmId)
                .Index(t => t.ReportedPrice_ReportedPriceCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown",
                c => new
                    {
                        MarkUpMarkDownCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.MarkUpMarkDownCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice",
                c => new
                    {
                        ReportedPriceCtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.ReportedPriceCtmId);
            
            CreateTable(
                "dbo.CTM_AdditionalSecurityIdentifiers",
                c => new
                    {
                        SecurityIdentifiersCtmId = c.Int(nullable: false, identity: true),
                        SecurityCode = c.String(maxLength: 30),
                        SecurityCodeType_SecurityCodeTypeCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.SecurityIdentifiersCtmId)
                .ForeignKey("dbo.CTM_AdditionalSecurityIdentifiersSecurityCodeType", t => t.SecurityCodeType_SecurityCodeTypeCtmId)
                .Index(t => t.SecurityCodeType_SecurityCodeTypeCtmId);
            
            CreateTable(
                "dbo.CTM_AdditionalSecurityIdentifiersSecurityCodeType",
                c => new
                    {
                        SecurityCodeTypeCtmId = c.Int(nullable: false, identity: true),
                        NumberingAgencyCode = c.String(maxLength: 4),
                        CountryCode = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.SecurityCodeTypeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyConfirmDisclosureData",
                c => new
                    {
                        DisclosureDataCtmId = c.Int(nullable: false, identity: true),
                        UserDefinedDisclosureCode = c.String(maxLength: 16),
                        ConfirmDisclosureBypassIndicator = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.DisclosureDataCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyCPTYTradeLevelIdentifiers",
                c => new
                    {
                        IdentifiersCtmId = c.Int(nullable: false, identity: true),
                        MasterReference = c.String(maxLength: 16),
                        CTMTradeSideId = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.IdentifiersCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyAdditionalDataEBSettlement",
                c => new
                    {
                        EBSettlementCtmId = c.Int(nullable: false, identity: true),
                        AccountReference = c.String(maxLength: 35),
                        AccountID = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.EBSettlementCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyExecutingBroker",
                c => new
                    {
                        ExecutingBrokerCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.ExecutingBrokerCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyIdentificationOfASecurity",
                c => new
                    {
                        IdentificationOfASecurityCtmId = c.Int(nullable: false, identity: true),
                        SecurityCode = c.String(maxLength: 30),
                        DescriptionOfTheSecurity = c.String(maxLength: 35),
                        SecurityCodeType_SecurityCodeTypeCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.IdentificationOfASecurityCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType", t => t.SecurityCodeType_SecurityCodeTypeCtmId)
                .Index(t => t.SecurityCodeType_SecurityCodeTypeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType",
                c => new
                    {
                        SecurityCodeTypeCtmId = c.Int(nullable: false, identity: true),
                        CountryCode = c.String(maxLength: 4),
                        NumberingAgencyCode = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.SecurityCodeTypeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyInstructingParty",
                c => new
                    {
                        InstructingPartyCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.InstructingPartyCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyIPSettlement",
                c => new
                    {
                        IPSettlementCtmId = c.Int(nullable: false, identity: true),
                        AccountID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.IPSettlementCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyPartySettlement",
                c => new
                    {
                        PartySettlementCtmId = c.Int(nullable: false, identity: true),
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
                        PlaceOfSafekeeping_PlaceOfSafekeepingCtmId = c.Int(),
                        SettlementInstructions_SettlementInstructionsCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.PartySettlementCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping", t => t.PlaceOfSafekeeping_PlaceOfSafekeepingCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyPartySettlementSettlementInstructions", t => t.SettlementInstructions_SettlementInstructionsCtmId)
                .Index(t => t.PlaceOfSafekeeping_PlaceOfSafekeepingCtmId)
                .Index(t => t.SettlementInstructions_SettlementInstructionsCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping",
                c => new
                    {
                        PlaceOfSafekeepingCtmId = c.Int(nullable: false, identity: true),
                        PlaceOfSafekeepingType = c.String(maxLength: 35),
                        PlaceOfSafekeepingValue = c.String(maxLength: 14),
                        PlaceOfSafekeepingPlace = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.PlaceOfSafekeepingCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyPartySettlementSettlementInstructions",
                c => new
                    {
                        SettlementInstructionsCtmId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.SettlementInstructionsCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyThirdPartyToTrade",
                c => new
                    {
                        ThirdPartyToTradeCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.ThirdPartyToTradeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailData",
                c => new
                    {
                        TradeDetailDataCtmId = c.Int(nullable: false, identity: true),
                        TradeRegulator = c.String(maxLength: 34),
                        SettlementTransactionConditionIndicator = c.String(),
                        AdditionalFixedIncome_FixedIncomeCtmId = c.Int(),
                        CommFeesTaxes_CommFeesTaxesCtmId = c.Int(),
                        DirectedCommission_CommissionCtmId = c.Int(),
                        ExchangeRate_ExchangeRateCtmId = c.Int(),
                        NetCashAmount_NetCashAmountCtmId = c.Int(),
                        QuantityAllocated_QuantityAllocatedCtmId = c.Int(),
                        SettlementAmount_SettlementAmountCtmId = c.Int(),
                        TradeAmount_TradeAmountCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeDetailDataCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome", t => t.AdditionalFixedIncome_FixedIncomeCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", t => t.CommFeesTaxes_CommFeesTaxesCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission", t => t.DirectedCommission_CommissionCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataExchangeRate", t => t.ExchangeRate_ExchangeRateCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount", t => t.NetCashAmount_NetCashAmountCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated", t => t.QuantityAllocated_QuantityAllocatedCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataSettlementAmount", t => t.SettlementAmount_SettlementAmountCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount", t => t.TradeAmount_TradeAmountCtmId)
                .Index(t => t.AdditionalFixedIncome_FixedIncomeCtmId)
                .Index(t => t.CommFeesTaxes_CommFeesTaxesCtmId)
                .Index(t => t.DirectedCommission_CommissionCtmId)
                .Index(t => t.ExchangeRate_ExchangeRateCtmId)
                .Index(t => t.NetCashAmount_NetCashAmountCtmId)
                .Index(t => t.QuantityAllocated_QuantityAllocatedCtmId)
                .Index(t => t.SettlementAmount_SettlementAmountCtmId)
                .Index(t => t.TradeAmount_TradeAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome",
                c => new
                    {
                        FixedIncomeCtmId = c.Int(nullable: false, identity: true),
                        CurrentFaceValue = c.String(),
                        OriginalFaceAmount = c.String(),
                        AccruedInterestAmount_InterestAmountCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.FixedIncomeCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount", t => t.AccruedInterestAmount_InterestAmountCtmId)
                .Index(t => t.AccruedInterestAmount_InterestAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount",
                c => new
                    {
                        InterestAmountCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.InterestAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes",
                c => new
                    {
                        CommFeesTaxesCtmId = c.Int(nullable: false, identity: true),
                        Commissions_CommissionsCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CommFeesTaxesCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", t => t.Commissions_CommissionsCtmId)
                .Index(t => t.Commissions_CommissionsCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions",
                c => new
                    {
                        CommissionsCtmId = c.Int(nullable: false, identity: true),
                        CommissionSharingBasisIndicator = c.String(maxLength: 4),
                        CommissionType = c.String(maxLength: 4),
                        Commission_CommissionCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CommissionsCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission", t => t.Commission_CommissionCtmId)
                .Index(t => t.Commission_CommissionCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission",
                c => new
                    {
                        CommissionCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CommissionCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission",
                c => new
                    {
                        CommissionCtmId = c.Int(nullable: false, identity: true),
                        CommissionSharingTypeIndicator = c.String(maxLength: 4),
                        BeneficiaryofCommissions_BeneficiaryofCommissionsCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CommissionCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions", t => t.BeneficiaryofCommissions_BeneficiaryofCommissionsCtmId)
                .Index(t => t.BeneficiaryofCommissions_BeneficiaryofCommissionsCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions",
                c => new
                    {
                        BeneficiaryofCommissionsCtmId = c.Int(nullable: false, identity: true),
                        ClearingSystemID = c.String(maxLength: 35),
                        PartyFundName = c.String(maxLength: 35),
                        BrokerOfCredit_BrokerOfCreditCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.BeneficiaryofCommissionsCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit", t => t.BrokerOfCredit_BrokerOfCreditCtmId)
                .Index(t => t.BrokerOfCredit_BrokerOfCreditCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit",
                c => new
                    {
                        BrokerOfCreditCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.BrokerOfCreditCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataExchangeRate",
                c => new
                    {
                        ExchangeRateCtmId = c.Int(nullable: false, identity: true),
                        ExchangeRateAmount = c.String(),
                        ToCurrency = c.String(maxLength: 3),
                        FromCurrency = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.ExchangeRateCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount",
                c => new
                    {
                        NetCashAmountCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.NetCashAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated",
                c => new
                    {
                        QuantityAllocatedCtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(maxLength: 4),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.QuantityAllocatedCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataSettlementAmount",
                c => new
                    {
                        SettlementAmountCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.SettlementAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount",
                c => new
                    {
                        TradeAmountCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.TradeAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailReferences",
                c => new
                    {
                        TradeDetailReferencesCtmId = c.Int(nullable: false, identity: true),
                        TradeDetailProcessingReference = c.String(maxLength: 16),
                        CTMTradeDetailID = c.String(maxLength: 16),
                        ClientAllocationReference = c.String(maxLength: 16),
                        TradeDetailLinkages_LinkagesCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeDetailReferencesCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailLinkages", t => t.TradeDetailLinkages_LinkagesCtmId)
                .Index(t => t.TradeDetailLinkages_LinkagesCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailLinkages",
                c => new
                    {
                        LinkagesCtmId = c.Int(nullable: false, identity: true),
                        TDReferences_TDReferencesCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.LinkagesCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTDReferences", t => t.TDReferences_TDReferencesCtmId)
                .Index(t => t.TDReferences_TDReferencesCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTDReferences",
                c => new
                    {
                        TDReferencesCtmId = c.Int(nullable: false, identity: true),
                        TDReferenceType = c.String(maxLength: 4),
                        TDReferenceValue = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.TDReferencesCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformation",
                c => new
                    {
                        TradeLevelInformationCtmId = c.Int(nullable: false, identity: true),
                        PartyCapacityIndicator = c.String(maxLength: 4),
                        OMNIExpected = c.String(maxLength: 1),
                        AlternativeMinimumTax = c.String(maxLength: 4),
                        FederalTax = c.String(maxLength: 4),
                        WhenIssue = c.String(maxLength: 4),
                        PoolNumber = c.String(maxLength: 30),
                        CurrentFaceValue = c.String(maxLength: 17),
                        CallType = c.String(maxLength: 35),
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
                        TradeDT = c.DateTime(nullable: false),
                        SettlementDt = c.DateTime(nullable: false),
                        AdditionalMunicipalDebtData_AdditionalMunicipalDebtDataCtmId = c.Int(),
                        CallPrice_InformationCallPriceCtmId = c.Int(),
                        CouponRate_InformationCouponRateCtmId = c.Int(),
                        CurrentFactor_CurrentFactorCtmId = c.Int(),
                        DealPrice_DealPriceCtmId = c.Int(),
                        PlaceOfTrade_PlaceOfTradeCtmId = c.Int(),
                        QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId = c.Int(),
                        Rating_InformationRatingCtmId = c.Int(),
                        StipulationsNonStandard_StipulationsNonStandardCtmId = c.Int(),
                        StipulationsStandard_StandardCtmId = c.Int(),
                        TimeZone_TradeLevelInformationTimeZoneCtmId = c.Int(),
                        TotalTradeAmount_TotalTradeAmountCtmId = c.Int(),
                        Yield_YieldCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeLevelInformationCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData", t => t.AdditionalMunicipalDebtData_AdditionalMunicipalDebtDataCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationCallPrice", t => t.CallPrice_InformationCallPriceCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationCouponRate", t => t.CouponRate_InformationCouponRateCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationCurrentFactor", t => t.CurrentFactor_CurrentFactorCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice", t => t.DealPrice_DealPriceCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade", t => t.PlaceOfTrade_PlaceOfTradeCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade", t => t.QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationRating", t => t.Rating_InformationRatingCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard", t => t.StipulationsNonStandard_StipulationsNonStandardCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard", t => t.StipulationsStandard_StandardCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone", t => t.TimeZone_TradeLevelInformationTimeZoneCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount", t => t.TotalTradeAmount_TotalTradeAmountCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationYield", t => t.Yield_YieldCtmId)
                .Index(t => t.AdditionalMunicipalDebtData_AdditionalMunicipalDebtDataCtmId)
                .Index(t => t.CallPrice_InformationCallPriceCtmId)
                .Index(t => t.CouponRate_InformationCouponRateCtmId)
                .Index(t => t.CurrentFactor_CurrentFactorCtmId)
                .Index(t => t.DealPrice_DealPriceCtmId)
                .Index(t => t.PlaceOfTrade_PlaceOfTradeCtmId)
                .Index(t => t.QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId)
                .Index(t => t.Rating_InformationRatingCtmId)
                .Index(t => t.StipulationsNonStandard_StipulationsNonStandardCtmId)
                .Index(t => t.StipulationsStandard_StandardCtmId)
                .Index(t => t.TimeZone_TradeLevelInformationTimeZoneCtmId)
                .Index(t => t.TotalTradeAmount_TotalTradeAmountCtmId)
                .Index(t => t.Yield_YieldCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData",
                c => new
                    {
                        AdditionalMunicipalDebtDataCtmId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.AdditionalMunicipalDebtDataCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationCallPrice",
                c => new
                    {
                        InformationCallPriceCtmId = c.Int(nullable: false, identity: true),
                        Amount = c.String(),
                        CurrencyCode = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.InformationCallPriceCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationCouponRate",
                c => new
                    {
                        InformationCouponRateCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.InformationCouponRateCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationCurrentFactor",
                c => new
                    {
                        CurrentFactorCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CurrentFactorCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice",
                c => new
                    {
                        DealPriceCtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.DealPriceCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade",
                c => new
                    {
                        PlaceOfTradeCtmId = c.Int(nullable: false, identity: true),
                        PlaceCode = c.String(maxLength: 4),
                        PlaceNarrative = c.String(maxLength: 30),
                        OrgName = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.PlaceOfTradeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade",
                c => new
                    {
                        QuantityOfTheBlockTradeCtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(maxLength: 4),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.QuantityOfTheBlockTradeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationRating",
                c => new
                    {
                        InformationRatingCtmId = c.Int(nullable: false, identity: true),
                        RatingType = c.String(maxLength: 4),
                        RatingVendor = c.String(maxLength: 15),
                        RatingValue = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.InformationRatingCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard",
                c => new
                    {
                        StipulationsNonStandardCtmId = c.Int(nullable: false, identity: true),
                        StipulationCodeNonStandard = c.String(maxLength: 15),
                        StipulationValueNonStandard = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.StipulationsNonStandardCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard",
                c => new
                    {
                        StandardCtmId = c.Int(nullable: false, identity: true),
                        StipulationCodeStandard = c.String(maxLength: 15),
                        StipulationValueStandard_SStipulationValueCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.StandardCtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard", t => t.StipulationValueStandard_SStipulationValueCtmId)
                .Index(t => t.StipulationValueStandard_SStipulationValueCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard",
                c => new
                    {
                        SStipulationValueCtmId = c.Int(nullable: false, identity: true),
                        StipulationStateCode = c.String(maxLength: 2),
                        StipulationY = c.String(maxLength: 1),
                        StipulationDate = c.Int(nullable: false),
                        StipulationAlphaNumeric = c.String(maxLength: 17),
                        StipulationNumeric = c.String(),
                    })
                .PrimaryKey(t => t.SStipulationValueCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone",
                c => new
                    {
                        TradeLevelInformationTimeZoneCtmId = c.Int(nullable: false, identity: true),
                        TradeTimeQualifier = c.String(maxLength: 4),
                        CountryTimeZone_CountryTimeZoneCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeLevelInformationTimeZoneCtmId)
                .ForeignKey("dbo.CTM_CountryTimeZone", t => t.CountryTimeZone_CountryTimeZoneCtmId)
                .Index(t => t.CountryTimeZone_CountryTimeZoneCtmId);
            
            CreateTable(
                "dbo.CTM_CountryTimeZone",
                c => new
                    {
                        CountryTimeZoneCtmId = c.Int(nullable: false, identity: true),
                        CountryCode = c.String(maxLength: 2),
                        TradeTimeQualifier = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.CountryTimeZoneCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount",
                c => new
                    {
                        TotalTradeAmountCtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(maxLength: 1),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.TotalTradeAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationYield",
                c => new
                    {
                        YieldCtmId = c.Int(nullable: false, identity: true),
                        YieldType = c.String(maxLength: 4),
                        Sign = c.String(maxLength: 1),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.YieldCtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelReferences",
                c => new
                    {
                        ReferencesCtmId = c.Int(nullable: false, identity: true),
                        CTMTradeSideId = c.String(maxLength: 16),
                        MasterReference = c.String(maxLength: 16),
                        TLReferences_TLReferencesCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.ReferencesCtmId)
                .ForeignKey("dbo.CTM_TLReferences", t => t.TLReferences_TLReferencesCtmId)
                .Index(t => t.TLReferences_TLReferencesCtmId);
            
            CreateTable(
                "dbo.CTM_TLReferences",
                c => new
                    {
                        TLReferencesCtmId = c.Int(nullable: false, identity: true),
                        TLReferenceType = c.String(maxLength: 4),
                        TLReferenceValue = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.TLReferencesCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevel",
                c => new
                    {
                        TradeLevelCtmId = c.Int(nullable: false, identity: true),
                        SubmitHeader_HeaderCtmId = c.Int(),
                        TradeLevelBody_TradeLevelBodyCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeLevelCtmId)
                .ForeignKey("dbo.CTM_Header", t => t.SubmitHeader_HeaderCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBody", t => t.TradeLevelBody_TradeLevelBodyCtmId)
                .Index(t => t.SubmitHeader_HeaderCtmId)
                .Index(t => t.TradeLevelBody_TradeLevelBodyCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBody",
                c => new
                    {
                        TradeLevelBodyCtmId = c.Int(nullable: false, identity: true),
                        FunctionOfTheMessage = c.String(),
                        VersionOfTradeComponent = c.Byte(nullable: false),
                        ExecutingBroker_ExecutingBrokerCtmId = c.Int(),
                        IdentificationOfASecurity_IdentificationOfASecurityCtmId = c.Int(),
                        InstructingParty_InstructingPartyCtmId = c.Int(),
                        TradeLevelInformation_InformationCtmId = c.Int(),
                        TradeLevelReferences_ReferencesCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.TradeLevelBodyCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyExecutingBroker", t => t.ExecutingBroker_ExecutingBrokerCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyIdentificationOfASecurity", t => t.IdentificationOfASecurity_IdentificationOfASecurityCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyInstructingParty", t => t.InstructingParty_InstructingPartyCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", t => t.TradeLevelInformation_InformationCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelReferences", t => t.TradeLevelReferences_ReferencesCtmId)
                .Index(t => t.ExecutingBroker_ExecutingBrokerCtmId)
                .Index(t => t.IdentificationOfASecurity_IdentificationOfASecurityCtmId)
                .Index(t => t.InstructingParty_InstructingPartyCtmId)
                .Index(t => t.TradeLevelInformation_InformationCtmId)
                .Index(t => t.TradeLevelReferences_ReferencesCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyExecutingBroker",
                c => new
                    {
                        ExecutingBrokerCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.ExecutingBrokerCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyIdentificationOfASecurity",
                c => new
                    {
                        IdentificationOfASecurityCtmId = c.Int(nullable: false, identity: true),
                        SecurityCode = c.String(maxLength: 30),
                        SecurityCodeType_SecurityCodeTypeCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.IdentificationOfASecurityCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType", t => t.SecurityCodeType_SecurityCodeTypeCtmId)
                .Index(t => t.SecurityCodeType_SecurityCodeTypeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType",
                c => new
                    {
                        SecurityCodeTypeCtmId = c.Int(nullable: false, identity: true),
                        NumberingAgencyCode = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.SecurityCodeTypeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyInstructingParty",
                c => new
                    {
                        InstructingPartyCtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(maxLength: 4),
                        PartyType = c.String(maxLength: 35),
                        PartyValue = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.InstructingPartyCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformation",
                c => new
                    {
                        InformationCtmId = c.Int(nullable: false, identity: true),
                        TypeOfTransactionIndicator = c.String(maxLength: 4),
                        BuySellIndicator = c.String(maxLength: 4),
                        TypeOfFinancialInstrument = c.String(maxLength: 4),
                        TradeDT = c.DateTime(nullable: false),
                        SettlementDt = c.DateTime(nullable: false),
                        DealPrice_DealPriceCtmId = c.Int(),
                        QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId = c.Int(),
                        TimeZone_InformationTimeZoneCtmId = c.Int(),
                        TotalTradeAmount_TotalTradeAmountCtmId = c.Int(),
                    })
                .PrimaryKey(t => t.InformationCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformationDealPrice", t => t.DealPrice_DealPriceCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade", t => t.QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformationTimeZone", t => t.TimeZone_InformationTimeZoneCtmId)
                .ForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount", t => t.TotalTradeAmount_TotalTradeAmountCtmId)
                .Index(t => t.DealPrice_DealPriceCtmId)
                .Index(t => t.QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId)
                .Index(t => t.TimeZone_InformationTimeZoneCtmId)
                .Index(t => t.TotalTradeAmount_TotalTradeAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformationDealPrice",
                c => new
                    {
                        DealPriceCtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.DealPriceCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade",
                c => new
                    {
                        QuantityOfTheBlockTradeCtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(maxLength: 4),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.QuantityOfTheBlockTradeCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformationTimeZone",
                c => new
                    {
                        InformationTimeZoneCtmId = c.Int(nullable: false, identity: true),
                        TradeTimeQualifier = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.InformationTimeZoneCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount",
                c => new
                    {
                        TotalTradeAmountCtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(maxLength: 3),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.TotalTradeAmountCtmId);
            
            CreateTable(
                "dbo.CTM_TradeLevelBodyTradeLevelReferences",
                c => new
                    {
                        ReferencesCtmId = c.Int(nullable: false, identity: true),
                        MasterReference = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.ReferencesCtmId);
            
            CreateTable(
                "dbo.CTM_Valid",
                c => new
                    {
                        ValidCtmId = c.Int(nullable: false, identity: true),
                        ResponseHeader_ValidResponseHeaderId = c.Int(),
                        ValidBody_ValidBodyId = c.Int(),
                    })
                .PrimaryKey(t => t.ValidCtmId)
                .ForeignKey("dbo.CTM_MessageValidResponseHeader", t => t.ResponseHeader_ValidResponseHeaderId)
                .ForeignKey("dbo.CTM_MessageValidValidBody", t => t.ValidBody_ValidBodyId)
                .Index(t => t.ResponseHeader_ValidResponseHeaderId)
                .Index(t => t.ValidBody_ValidBodyId);
            
            CreateTable(
                "dbo.CTM_MessageValidResponseHeader",
                c => new
                    {
                        ValidResponseHeaderId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        EchoSendersMessageReference = c.String(),
                        OriginatorOfMessage_OriginatorOfMessageId = c.Int(),
                        RecipientOfMessage_RecipientOfMessageId = c.Int(),
                    })
                .PrimaryKey(t => t.ValidResponseHeaderId)
                .ForeignKey("dbo.CTM_MessageValidResponseHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_OriginatorOfMessageId)
                .ForeignKey("dbo.CTM_MessageValidResponseHeaderRecipientOfMessage", t => t.RecipientOfMessage_RecipientOfMessageId)
                .Index(t => t.OriginatorOfMessage_OriginatorOfMessageId)
                .Index(t => t.RecipientOfMessage_RecipientOfMessageId);
            
            CreateTable(
                "dbo.CTM_MessageValidResponseHeaderOriginatorOfMessage",
                c => new
                    {
                        OriginatorOfMessageId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.OriginatorOfMessageId);
            
            CreateTable(
                "dbo.CTM_MessageValidResponseHeaderRecipientOfMessage",
                c => new
                    {
                        RecipientOfMessageId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.RecipientOfMessageId);
            
            CreateTable(
                "dbo.CTM_MessageValidValidBody",
                c => new
                    {
                        ValidBodyId = c.Int(nullable: false, identity: true),
                        EchoMasterReference = c.String(),
                        EchoClientAllocationReference = c.String(),
                        ExecutingBroker_ExecutingBrokerId = c.Int(),
                        InstructingParty_InstructingPartyId = c.Int(),
                    })
                .PrimaryKey(t => t.ValidBodyId)
                .ForeignKey("dbo.CTM_MessageValidValidBodyExecutingBroker", t => t.ExecutingBroker_ExecutingBrokerId)
                .ForeignKey("dbo.CTM_MessageValidValidBodyInstructingParty", t => t.InstructingParty_InstructingPartyId)
                .Index(t => t.ExecutingBroker_ExecutingBrokerId)
                .Index(t => t.InstructingParty_InstructingPartyId);
            
            CreateTable(
                "dbo.CTM_MessageValidValidBodyExecutingBroker",
                c => new
                    {
                        ExecutingBrokerId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.ExecutingBrokerId);
            
            CreateTable(
                "dbo.CTM_MessageValidValidBodyInstructingParty",
                c => new
                    {
                        InstructingPartyId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.InstructingPartyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CTM_Message", "Valid_ValidCtmId", "dbo.CTM_Valid");
            DropForeignKey("dbo.CTM_Valid", "ValidBody_ValidBodyId", "dbo.CTM_MessageValidValidBody");
            DropForeignKey("dbo.CTM_MessageValidValidBody", "InstructingParty_InstructingPartyId", "dbo.CTM_MessageValidValidBodyInstructingParty");
            DropForeignKey("dbo.CTM_MessageValidValidBody", "ExecutingBroker_ExecutingBrokerId", "dbo.CTM_MessageValidValidBodyExecutingBroker");
            DropForeignKey("dbo.CTM_Valid", "ResponseHeader_ValidResponseHeaderId", "dbo.CTM_MessageValidResponseHeader");
            DropForeignKey("dbo.CTM_MessageValidResponseHeader", "RecipientOfMessage_RecipientOfMessageId", "dbo.CTM_MessageValidResponseHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageValidResponseHeader", "OriginatorOfMessage_OriginatorOfMessageId", "dbo.CTM_MessageValidResponseHeaderOriginatorOfMessage");
            DropForeignKey("dbo.CTM_Message", "TradeLevel_TradeLevelCtmId", "dbo.CTM_TradeLevel");
            DropForeignKey("dbo.CTM_TradeLevel", "TradeLevelBody_TradeLevelBodyCtmId", "dbo.CTM_TradeLevelBody");
            DropForeignKey("dbo.CTM_TradeLevelBody", "TradeLevelReferences_ReferencesCtmId", "dbo.CTM_TradeLevelBodyTradeLevelReferences");
            DropForeignKey("dbo.CTM_TradeLevelBody", "TradeLevelInformation_InformationCtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformation");
            DropForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", "TotalTradeAmount_TotalTradeAmountCtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount");
            DropForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", "TimeZone_InformationTimeZoneCtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformationTimeZone");
            DropForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", "QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropForeignKey("dbo.CTM_TradeLevelBodyTradeLevelInformation", "DealPrice_DealPriceCtmId", "dbo.CTM_TradeLevelBodyTradeLevelInformationDealPrice");
            DropForeignKey("dbo.CTM_TradeLevelBody", "InstructingParty_InstructingPartyCtmId", "dbo.CTM_TradeLevelBodyInstructingParty");
            DropForeignKey("dbo.CTM_TradeLevelBody", "IdentificationOfASecurity_IdentificationOfASecurityCtmId", "dbo.CTM_TradeLevelBodyIdentificationOfASecurity");
            DropForeignKey("dbo.CTM_TradeLevelBodyIdentificationOfASecurity", "SecurityCodeType_SecurityCodeTypeCtmId", "dbo.CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType");
            DropForeignKey("dbo.CTM_TradeLevelBody", "ExecutingBroker_ExecutingBrokerCtmId", "dbo.CTM_TradeLevelBodyExecutingBroker");
            DropForeignKey("dbo.CTM_TradeLevel", "SubmitHeader_HeaderCtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_Message", "TradeDetail_TradeDetailCtmId", "dbo.CTM_TradeDetail");
            DropForeignKey("dbo.CTM_TradeDetail", "TradeDetailBody_TradeDetailBodyCtmId", "dbo.CTM_TradeDetailBody");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeLevelReferences_ReferencesCtmId", "dbo.CTM_TradeDetailBodyTradeLevelReferences");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelReferences", "TLReferences_TLReferencesCtmId", "dbo.CTM_TLReferences");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeLevelInformation_TradeLevelInformationCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformation");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Yield_YieldCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationYield");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "TotalTradeAmount_TotalTradeAmountCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "TimeZone_TradeLevelInformationTimeZoneCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone", "CountryTimeZone_CountryTimeZoneCtmId", "dbo.CTM_CountryTimeZone");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsStandard_StandardCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard", "StipulationValueStandard_SStipulationValueCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "StipulationsNonStandard_StipulationsNonStandardCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "Rating_InformationRatingCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationRating");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "PlaceOfTrade_PlaceOfTradeCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "DealPrice_DealPriceCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "CurrentFactor_CurrentFactorCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationCurrentFactor");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "CouponRate_InformationCouponRateCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationCouponRate");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "CallPrice_InformationCallPriceCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationCallPrice");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "AdditionalMunicipalDebtData_AdditionalMunicipalDebtDataCtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeDetailReferences_TradeDetailReferencesCtmId", "dbo.CTM_TradeDetailBodyTradeDetailReferences");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailReferences", "TradeDetailLinkages_LinkagesCtmId", "dbo.CTM_TradeDetailBodyTradeDetailLinkages");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailLinkages", "TDReferences_TDReferencesCtmId", "dbo.CTM_TradeDetailBodyTDReferences");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeDetailData_TradeDetailDataCtmId", "dbo.CTM_TradeDetailBodyTradeDetailData");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "TradeAmount_TradeAmountCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "SettlementAmount_SettlementAmountCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataSettlementAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "QuantityAllocated_QuantityAllocatedCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "NetCashAmount_NetCashAmountCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "ExchangeRate_ExchangeRateCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataExchangeRate");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "DirectedCommission_CommissionCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission", "BeneficiaryofCommissions_BeneficiaryofCommissionsCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions", "BrokerOfCredit_BrokerOfCreditCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissionsBrokerOfCredit");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "CommFeesTaxes_CommFeesTaxesCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", "Commissions_CommissionsCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", "Commission_CommissionCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "AdditionalFixedIncome_FixedIncomeCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome", "AccruedInterestAmount_InterestAmountCtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncomeAccruedInterestAmount");
            DropForeignKey("dbo.CTM_TradeDetailBody", "ThirdPartyToTrade_ThirdPartyToTradeCtmId", "dbo.CTM_TradeDetailBodyThirdPartyToTrade");
            DropForeignKey("dbo.CTM_TradeDetailBody", "PartySettlement_PartySettlementCtmId", "dbo.CTM_TradeDetailBodyPartySettlement");
            DropForeignKey("dbo.CTM_TradeDetailBodyPartySettlement", "SettlementInstructions_SettlementInstructionsCtmId", "dbo.CTM_TradeDetailBodyPartySettlementSettlementInstructions");
            DropForeignKey("dbo.CTM_TradeDetailBodyPartySettlement", "PlaceOfSafekeeping_PlaceOfSafekeepingCtmId", "dbo.CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping");
            DropForeignKey("dbo.CTM_TradeDetailBody", "IPSettlement_IPSettlementCtmId", "dbo.CTM_TradeDetailBodyIPSettlement");
            DropForeignKey("dbo.CTM_TradeDetailBody", "InstructingParty_InstructingPartyCtmId", "dbo.CTM_TradeDetailBodyInstructingParty");
            DropForeignKey("dbo.CTM_TradeDetailBody", "IdentificationOfASecurity_IdentificationOfASecurityCtmId", "dbo.CTM_TradeDetailBodyIdentificationOfASecurity");
            DropForeignKey("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", "SecurityCodeType_SecurityCodeTypeCtmId", "dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType");
            DropForeignKey("dbo.CTM_TradeDetailBody", "ExecutingBroker_ExecutingBrokerCtmId", "dbo.CTM_TradeDetailBodyExecutingBroker");
            DropForeignKey("dbo.CTM_TradeDetailBody", "EBSettlement_EBSettlementCtmId", "dbo.CTM_TradeDetailBodyAdditionalDataEBSettlement");
            DropForeignKey("dbo.CTM_TradeDetailBody", "CPTYTradeLevelIdentifiers_IdentifiersCtmId", "dbo.CTM_TradeDetailBodyCPTYTradeLevelIdentifiers");
            DropForeignKey("dbo.CTM_TradeDetailBody", "ConfirmDisclosureData_DisclosureDataCtmId", "dbo.CTM_TradeDetailBodyConfirmDisclosureData");
            DropForeignKey("dbo.CTM_TradeDetailBody", "AdditionalSecurityIdentifiers_SecurityIdentifiersCtmId", "dbo.CTM_AdditionalSecurityIdentifiers");
            DropForeignKey("dbo.CTM_AdditionalSecurityIdentifiers", "SecurityCodeType_SecurityCodeTypeCtmId", "dbo.CTM_AdditionalSecurityIdentifiersSecurityCodeType");
            DropForeignKey("dbo.CTM_TradeDetailBody", "AdditionalDisclosures_DisclosuresCtmId", "dbo.CTM_TradeDetailBodyAdditionalDisclosures");
            DropForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosures", "ReportedPrice_ReportedPriceCtmId", "dbo.CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice");
            DropForeignKey("dbo.CTM_TradeDetailBodyAdditionalDisclosures", "MarkUpMarkDown_MarkUpMarkDownCtmId", "dbo.CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown");
            DropForeignKey("dbo.CTM_TradeDetailBody", "AdditionalData_AdditionalDataCtmId", "dbo.CTM_TradeDetailBodyAdditionalData");
            DropForeignKey("dbo.CTM_TradeDetail", "SubmitHeader_HeaderCtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_Message", "MultiTradeLevelResponse_ResponseCtmId", "dbo.CTM_MultiTradeLevelResponse");
            DropForeignKey("dbo.CTM_MultiTradeLevelResponse", "ResponseHeader_ResponseHeaderCtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_MultiTradeLevelResponse", "MultiTradeLevelResponseBody_MultiTradeLevelResponseBodyCtmId", "dbo.CTM_MultiTradeLevelResponseBody");
            DropForeignKey("dbo.CTM_Message", "MultiTradeLevelRequest_TradeLevelRequestCtmId", "dbo.CTM_MultiTradeLevelRequest");
            DropForeignKey("dbo.CTM_MultiTradeLevelRequest", "SubmitHeader_HeaderCtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_MultiTradeLevelRequest", "MultiTradeLevelRequestBody_TradeLevelRequestBodyCtmId", "dbo.CTM_MultiTradeLevelRequestBody");
            DropForeignKey("dbo.CTM_Message", "MultiTradeDetailResponse_TradeDetailResponseCtmId", "dbo.CTM_MultiTradeDetailResponse");
            DropForeignKey("dbo.CTM_MultiTradeDetailResponse", "ResponseHeader_ResponseHeaderCtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_MultiTradeDetailResponse", "MultiTradeDetailResponseBody_TradeDetailResponseBodyCtmId", "dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody");
            DropForeignKey("dbo.CTM_Message", "MultiTradeDetailRequest_MultiTradeDetailRequestCtmId", "dbo.CTM_MultiTradeDetailRequest");
            DropForeignKey("dbo.CTM_MultiTradeDetailRequest", "SubmitHeader_HeaderCtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_MultiTradeDetailRequest", "MultiTradeDetailRequestBody_RequestBodyCtmId", "dbo.CTM_MultiTradeDetailRequestBody");
            DropForeignKey("dbo.CTM_Message", "Invalid_InvalidCtmId", "dbo.CTM_Invalid");
            DropForeignKey("dbo.CTM_Invalid", "InvalidHeader_ResponseHeaderCtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_ResponseHeader", "RecipientOfMessage_RecipientOfMessageCtmId", "dbo.CTM_RecipientOfMessage");
            DropForeignKey("dbo.CTM_ResponseHeader", "OriginatorOfMessage_OriginatorOfMessageCtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.CTM_ResponseHeader", "AuditTrail_AuditTrailCtmId", "dbo.CTM_ResponseHeaderAuditTrail");
            DropForeignKey("dbo.CTM_ResponseHeader", "AuditEvent_AuditEventCtmId", "dbo.CTM_ResponseHeaderAuditEvent");
            DropForeignKey("dbo.CTM_Invalid", "InvalidBody_InvalidBodyCtmId", "dbo.CTM_InvalidBody");
            DropForeignKey("dbo.CTM_InvalidBody", "SynchError_InvalidBodySynchErrorCtmId", "dbo.CTM_InvalidBodySynchError");
            DropForeignKey("dbo.CTM_Message", "InfoRequest_InfoRequestCtmId", "dbo.CTM_InfoRequest");
            DropForeignKey("dbo.CTM_InfoRequest", "SubmitHeader_HeaderCtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_Header", "RecipientOfMessage_RecipientOfMessageCtmId", "dbo.CTM_RecipientOfMessage");
            DropForeignKey("dbo.CTM_Header", "OriginatorOfMessage_OriginatorOfMessageCtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.CTM_InfoRequest", "InfoRequestBody_InfoRequestBodyCtmId", "dbo.CTM_InfoRequestBody");
            DropForeignKey("dbo.CTM_InfoRequestBody", "ExecutingBroker_ExecutingBrokerCtmId", "dbo.CTM_InfoRequestBodyExecutingBroker");
            DropForeignKey("dbo.CTM_InfoRequestBody", "AccessPath_InfoRequestBodyAccessPathCtmId", "dbo.CTM_InfoRequestBodyAccessPath");
            DropForeignKey("dbo.CTM_InfoRequestBodyAccessPath", "TradeLevelIdentifiers_AccessPathTradeLevelIdentifiersCtmId", "dbo.CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers");
            DropIndex("dbo.CTM_MessageValidValidBody", new[] { "InstructingParty_InstructingPartyId" });
            DropIndex("dbo.CTM_MessageValidValidBody", new[] { "ExecutingBroker_ExecutingBrokerId" });
            DropIndex("dbo.CTM_MessageValidResponseHeader", new[] { "RecipientOfMessage_RecipientOfMessageId" });
            DropIndex("dbo.CTM_MessageValidResponseHeader", new[] { "OriginatorOfMessage_OriginatorOfMessageId" });
            DropIndex("dbo.CTM_Valid", new[] { "ValidBody_ValidBodyId" });
            DropIndex("dbo.CTM_Valid", new[] { "ResponseHeader_ValidResponseHeaderId" });
            DropIndex("dbo.CTM_TradeLevelBodyTradeLevelInformation", new[] { "TotalTradeAmount_TotalTradeAmountCtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyTradeLevelInformation", new[] { "TimeZone_InformationTimeZoneCtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyTradeLevelInformation", new[] { "QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyTradeLevelInformation", new[] { "DealPrice_DealPriceCtmId" });
            DropIndex("dbo.CTM_TradeLevelBodyIdentificationOfASecurity", new[] { "SecurityCodeType_SecurityCodeTypeCtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "TradeLevelReferences_ReferencesCtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "TradeLevelInformation_InformationCtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "InstructingParty_InstructingPartyCtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "IdentificationOfASecurity_IdentificationOfASecurityCtmId" });
            DropIndex("dbo.CTM_TradeLevelBody", new[] { "ExecutingBroker_ExecutingBrokerCtmId" });
            DropIndex("dbo.CTM_TradeLevel", new[] { "TradeLevelBody_TradeLevelBodyCtmId" });
            DropIndex("dbo.CTM_TradeLevel", new[] { "SubmitHeader_HeaderCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelReferences", new[] { "TLReferences_TLReferencesCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone", new[] { "CountryTimeZone_CountryTimeZoneCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard", new[] { "StipulationValueStandard_SStipulationValueCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "Yield_YieldCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "TotalTradeAmount_TotalTradeAmountCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "TimeZone_TradeLevelInformationTimeZoneCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "StipulationsStandard_StandardCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "StipulationsNonStandard_StipulationsNonStandardCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "Rating_InformationRatingCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "QuantityOfTheBlockTrade_QuantityOfTheBlockTradeCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "PlaceOfTrade_PlaceOfTradeCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "DealPrice_DealPriceCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "CurrentFactor_CurrentFactorCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "CouponRate_InformationCouponRateCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "CallPrice_InformationCallPriceCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "AdditionalMunicipalDebtData_AdditionalMunicipalDebtDataCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailLinkages", new[] { "TDReferences_TDReferencesCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailReferences", new[] { "TradeDetailLinkages_LinkagesCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommissionBeneficiaryofCommissions", new[] { "BrokerOfCredit_BrokerOfCreditCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataDirectedCommission", new[] { "BeneficiaryofCommissions_BeneficiaryofCommissionsCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", new[] { "Commission_CommissionCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", new[] { "Commissions_CommissionsCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataAdditionalFixedIncome", new[] { "AccruedInterestAmount_InterestAmountCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "TradeAmount_TradeAmountCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "SettlementAmount_SettlementAmountCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "QuantityAllocated_QuantityAllocatedCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "NetCashAmount_NetCashAmountCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "ExchangeRate_ExchangeRateCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "DirectedCommission_CommissionCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "CommFeesTaxes_CommFeesTaxesCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "AdditionalFixedIncome_FixedIncomeCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyPartySettlement", new[] { "SettlementInstructions_SettlementInstructionsCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyPartySettlement", new[] { "PlaceOfSafekeeping_PlaceOfSafekeepingCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", new[] { "SecurityCodeType_SecurityCodeTypeCtmId" });
            DropIndex("dbo.CTM_AdditionalSecurityIdentifiers", new[] { "SecurityCodeType_SecurityCodeTypeCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyAdditionalDisclosures", new[] { "ReportedPrice_ReportedPriceCtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyAdditionalDisclosures", new[] { "MarkUpMarkDown_MarkUpMarkDownCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeLevelReferences_ReferencesCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeLevelInformation_TradeLevelInformationCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeDetailReferences_TradeDetailReferencesCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeDetailData_TradeDetailDataCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "ThirdPartyToTrade_ThirdPartyToTradeCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "PartySettlement_PartySettlementCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "IPSettlement_IPSettlementCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "InstructingParty_InstructingPartyCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "IdentificationOfASecurity_IdentificationOfASecurityCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "ExecutingBroker_ExecutingBrokerCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "EBSettlement_EBSettlementCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "CPTYTradeLevelIdentifiers_IdentifiersCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "ConfirmDisclosureData_DisclosureDataCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "AdditionalSecurityIdentifiers_SecurityIdentifiersCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "AdditionalDisclosures_DisclosuresCtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "AdditionalData_AdditionalDataCtmId" });
            DropIndex("dbo.CTM_TradeDetail", new[] { "TradeDetailBody_TradeDetailBodyCtmId" });
            DropIndex("dbo.CTM_TradeDetail", new[] { "SubmitHeader_HeaderCtmId" });
            DropIndex("dbo.CTM_MultiTradeLevelResponse", new[] { "ResponseHeader_ResponseHeaderCtmId" });
            DropIndex("dbo.CTM_MultiTradeLevelResponse", new[] { "MultiTradeLevelResponseBody_MultiTradeLevelResponseBodyCtmId" });
            DropIndex("dbo.CTM_MultiTradeLevelRequest", new[] { "SubmitHeader_HeaderCtmId" });
            DropIndex("dbo.CTM_MultiTradeLevelRequest", new[] { "MultiTradeLevelRequestBody_TradeLevelRequestBodyCtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailResponse", new[] { "ResponseHeader_ResponseHeaderCtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailResponse", new[] { "MultiTradeDetailResponseBody_TradeDetailResponseBodyCtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailRequest", new[] { "SubmitHeader_HeaderCtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailRequest", new[] { "MultiTradeDetailRequestBody_RequestBodyCtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "RecipientOfMessage_RecipientOfMessageCtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "OriginatorOfMessage_OriginatorOfMessageCtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "AuditTrail_AuditTrailCtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "AuditEvent_AuditEventCtmId" });
            DropIndex("dbo.CTM_InvalidBody", new[] { "SynchError_InvalidBodySynchErrorCtmId" });
            DropIndex("dbo.CTM_Invalid", new[] { "InvalidHeader_ResponseHeaderCtmId" });
            DropIndex("dbo.CTM_Invalid", new[] { "InvalidBody_InvalidBodyCtmId" });
            DropIndex("dbo.CTM_Header", new[] { "RecipientOfMessage_RecipientOfMessageCtmId" });
            DropIndex("dbo.CTM_Header", new[] { "OriginatorOfMessage_OriginatorOfMessageCtmId" });
            DropIndex("dbo.CTM_InfoRequestBodyAccessPath", new[] { "TradeLevelIdentifiers_AccessPathTradeLevelIdentifiersCtmId" });
            DropIndex("dbo.CTM_InfoRequestBody", new[] { "ExecutingBroker_ExecutingBrokerCtmId" });
            DropIndex("dbo.CTM_InfoRequestBody", new[] { "AccessPath_InfoRequestBodyAccessPathCtmId" });
            DropIndex("dbo.CTM_InfoRequest", new[] { "SubmitHeader_HeaderCtmId" });
            DropIndex("dbo.CTM_InfoRequest", new[] { "InfoRequestBody_InfoRequestBodyCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "Valid_ValidCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "TradeLevel_TradeLevelCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "TradeDetail_TradeDetailCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "MultiTradeLevelResponse_ResponseCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "MultiTradeLevelRequest_TradeLevelRequestCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "MultiTradeDetailResponse_TradeDetailResponseCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "MultiTradeDetailRequest_MultiTradeDetailRequestCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "Invalid_InvalidCtmId" });
            DropIndex("dbo.CTM_Message", new[] { "InfoRequest_InfoRequestCtmId" });
            DropTable("dbo.CTM_MessageValidValidBodyInstructingParty");
            DropTable("dbo.CTM_MessageValidValidBodyExecutingBroker");
            DropTable("dbo.CTM_MessageValidValidBody");
            DropTable("dbo.CTM_MessageValidResponseHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageValidResponseHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageValidResponseHeader");
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
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationYield");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount");
            DropTable("dbo.CTM_CountryTimeZone");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandardStipulationValueStandard");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationRating");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationCurrentFactor");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationCouponRate");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationCallPrice");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformation");
            DropTable("dbo.CTM_TradeDetailBodyTDReferences");
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
            DropTable("dbo.CTM_TradeDetailBodyThirdPartyToTrade");
            DropTable("dbo.CTM_TradeDetailBodyPartySettlementSettlementInstructions");
            DropTable("dbo.CTM_TradeDetailBodyPartySettlementPlaceOfSafekeeping");
            DropTable("dbo.CTM_TradeDetailBodyPartySettlement");
            DropTable("dbo.CTM_TradeDetailBodyIPSettlement");
            DropTable("dbo.CTM_TradeDetailBodyInstructingParty");
            DropTable("dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType");
            DropTable("dbo.CTM_TradeDetailBodyIdentificationOfASecurity");
            DropTable("dbo.CTM_TradeDetailBodyExecutingBroker");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDataEBSettlement");
            DropTable("dbo.CTM_TradeDetailBodyCPTYTradeLevelIdentifiers");
            DropTable("dbo.CTM_TradeDetailBodyConfirmDisclosureData");
            DropTable("dbo.CTM_AdditionalSecurityIdentifiersSecurityCodeType");
            DropTable("dbo.CTM_AdditionalSecurityIdentifiers");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDisclosuresReportedPrice");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDisclosuresMarkUpMarkDown");
            DropTable("dbo.CTM_TradeDetailBodyAdditionalDisclosures");
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
            DropTable("dbo.CTM_Message");
        }
    }
}
