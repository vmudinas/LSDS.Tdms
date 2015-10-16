namespace LSDS.CTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CtmName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TdmsCTM",
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
                .ForeignKey("dbo.CTM_MessageInfoRequest", t => t.InfoRequest_CtmId)
                .ForeignKey("dbo.CTM_MessageInvalid", t => t.Invalid_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailRequest", t => t.MultiTradeDetailRequest_CtmId)
                .ForeignKey("dbo.CTM_MultiTradeDetailResponse", t => t.MultiTradeDetailResponse_CtmId)
                .ForeignKey("dbo.CTM_", t => t.MultiTradeLevelRequest_CtmId)
                .ForeignKey("dbo.CTM_", t => t.MultiTradeLevelResponse_CtmId)
                .ForeignKey("dbo.CTM_", t => t.TradeDetail_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevel", t => t.TradeLevel_CtmId)
                .ForeignKey("dbo.CTM_", t => t.Valid_CtmId)
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
                "dbo.CTM_MessageInfoRequest",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        InfoRequestBody_CtmId = c.Int(),
                        SubmitHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBody", t => t.InfoRequestBody_CtmId)
                .ForeignKey("dbo.SubmitHeader", t => t.SubmitHeader_CtmId)
                .Index(t => t.InfoRequestBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInfoRequestInfoRequestBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ViewRequestedIndicator = c.String(),
                        QueryType = c.String(),
                        AccessPath_CtmId = c.Int(),
                        ExecutingBroker_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath", t => t.AccessPath_CtmId)
                .ForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .Index(t => t.AccessPath_CtmId)
                .Index(t => t.ExecutingBroker_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        IDOwner = c.String(),
                        TradeLevelIdentifiers_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPathTradeLevelIdentifiers", t => t.TradeLevelIdentifiers_CtmId)
                .Index(t => t.TradeLevelIdentifiers_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPathTradeLevelIdentifiers",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MasterReference = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInfoRequestInfoRequestBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.SubmitHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        SendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.SubmitHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.SubmitHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.SubmitHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.SubmitHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInvalid",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        InvalidBody_CtmId = c.Int(),
                        InvalidHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageInvalidInvalidBody", t => t.InvalidBody_CtmId)
                .ForeignKey("dbo.CTM_MessageInvalidInvalidHeader", t => t.InvalidHeader_CtmId)
                .Index(t => t.InvalidBody_CtmId)
                .Index(t => t.InvalidHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInvalidInvalidBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        OriginalMessage = c.String(),
                        SynchError_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageInvalidInvalidBodySynchError", t => t.SynchError_CtmId)
                .Index(t => t.SynchError_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInvalidInvalidBodySynchError",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ErrorId = c.Byte(nullable: false),
                        ErrorKey = c.String(),
                        ErrorText = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInvalidInvalidHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageInvalidInvalidHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInvalidInvalidHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailRequest",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailRequestBody_CtmId = c.Int(),
                        SubmitHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBody", t => t.MultiTradeDetailRequestBody_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader", t => t.SubmitHeader_CtmId)
                .Index(t => t.MultiTradeDetailRequestBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailResponseRequested = c.String(),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        SendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailRequestSubmitHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailRequestSubmitHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
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
                "dbo.CTM_ResponseHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        EchoSendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_OriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_ResponseHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_OriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_",
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
                "dbo.CTM_Header",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        SendersMessageReference = c.String(),
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
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_RecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_",
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
                "dbo.CTM_ResponseHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        EchoSendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_OriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_ResponseHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_OriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SubmitHeader_CtmId = c.Int(),
                        TradeDetailBody_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_SubmitHeader", t => t.SubmitHeader_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBody", t => t.TradeDetailBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId)
                .Index(t => t.TradeDetailBody_CtmId);
            
            CreateTable(
                "dbo.CTM_SubmitHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        SendersMessageReference = c.String(),
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
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_RecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        FunctionOfTheMessage = c.String(),
                        VersionOfTradeComponent = c.Byte(nullable: false),
                        TradeLevelExpected = c.String(),
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
                .ForeignKey("dbo.CTM_TradeDetailBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", t => t.IdentificationOfASecurity_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyInstructingParty", t => t.InstructingParty_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyIPSettlement", t => t.IPSettlement_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyPartySettlement", t => t.PartySettlement_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", t => t.TradeDetailData_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailReferences", t => t.TradeDetailReferences_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", t => t.TradeLevelInformation_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelReferences", t => t.TradeLevelReferences_CtmId)
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
                "dbo.CTM_TradeDetailBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyIdentificationOfASecurity",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SecurityCode = c.String(),
                        DescriptionOfTheSecurity = c.String(),
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
                        NumberingAgencyCode = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyInstructingParty",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
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
                        SettlementInstructionsSourceIndicator = c.String(),
                        AlertCountryCode = c.String(),
                        AlertMethodType = c.String(),
                        AlertSecurityType = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailData",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CommFeesTaxes_CtmId = c.Int(),
                        NetCashAmount_CtmId = c.Int(),
                        QuantityAllocated_CtmId = c.Int(),
                        TradeAmount_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", t => t.CommFeesTaxes_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount", t => t.NetCashAmount_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated", t => t.QuantityAllocated_CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount", t => t.TradeAmount_CtmId)
                .Index(t => t.CommFeesTaxes_CtmId)
                .Index(t => t.NetCashAmount_CtmId)
                .Index(t => t.QuantityAllocated_CtmId)
                .Index(t => t.TradeAmount_CtmId);
            
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
                        CommissionSharingBasisIndicator = c.String(),
                        CommissionType = c.String(),
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
                        Sign = c.String(),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeDetailReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ClientAllocationReference = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformation",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TypeOfTransactionIndicator = c.String(),
                        BuySellIndicator = c.String(),
                        TypeOfFinancialInstrument = c.String(),
                        DealPrice_CtmId = c.Int(),
                        QuantityOfTheBlockTrade_CtmId = c.Int(),
                        TimeZone_CtmId = c.Int(),
                        TotalTradeAmount_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice", t => t.DealPrice_CtmId)
                .Index(t => t.DealPrice_CtmId)
                .Index(t => t.QuantityOfTheBlockTrade_CtmId)
                .Index(t => t.TimeZone_CtmId)
                .Index(t => t.TotalTradeAmount_CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TradeTimeQualifier = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_TradeDetailBodyTradeLevelReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevel",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SubmitHeader_CtmId = c.Int(),
                        TradeLevelBody_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelSubmitHeader", t => t.SubmitHeader_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBody", t => t.TradeLevelBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId)
                .Index(t => t.TradeLevelBody_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelSubmitHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        SendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelSubmitHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelSubmitHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelSubmitHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelSubmitHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBody",
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
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity", t => t.IdentificationOfASecurity_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyInstructingParty", t => t.InstructingParty_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", t => t.TradeLevelInformation_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelReferences", t => t.TradeLevelReferences_CtmId)
                .Index(t => t.ExecutingBroker_CtmId)
                .Index(t => t.IdentificationOfASecurity_CtmId)
                .Index(t => t.InstructingParty_CtmId)
                .Index(t => t.TradeLevelInformation_CtmId)
                .Index(t => t.TradeLevelReferences_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SecurityCodeType_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecuritySecurityCodeType", t => t.SecurityCodeType_CtmId)
                .Index(t => t.SecurityCodeType_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecuritySecurityCodeType",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        NumberingAgencyCode = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyInstructingParty",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TypeOfTransactionIndicator = c.String(),
                        BuySellIndicator = c.String(),
                        TypeOfFinancialInstrument = c.String(),
                        DealPrice_CtmId = c.Int(),
                        QuantityOfTheBlockTrade_CtmId = c.Int(),
                        TimeZone_CtmId = c.Int(),
                        TotalTradeAmount_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationDealPrice", t => t.DealPrice_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade", t => t.QuantityOfTheBlockTrade_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTimeZone", t => t.TimeZone_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTotalTradeAmount", t => t.TotalTradeAmount_CtmId)
                .Index(t => t.DealPrice_CtmId)
                .Index(t => t.QuantityOfTheBlockTrade_CtmId)
                .Index(t => t.TimeZone_CtmId)
                .Index(t => t.TotalTradeAmount_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationDealPrice",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTimeZone",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TradeTimeQualifier = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTotalTradeAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MasterReference = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_",
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
                "dbo.CTM_ResponseHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        EchoSendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_OriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_ResponseHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_OriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_ResponseHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_ValidBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        EchoMasterReference = c.Long(nullable: false),
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
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_ValidBodyInstructingParty",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TdmsCTM", "Valid_CtmId", "dbo.CTM_");
            DropForeignKey("dbo.CTM_", "ValidBody_CtmId", "dbo.CTM_ValidBody");
            DropForeignKey("dbo.CTM_ValidBody", "InstructingParty_CtmId", "dbo.CTM_ValidBodyInstructingParty");
            DropForeignKey("dbo.CTM_ValidBody", "ExecutingBroker_CtmId", "dbo.CTM_ValidBodyExecutingBroker");
            DropForeignKey("dbo.CTM_", "ResponseHeader_CtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_ResponseHeader", "RecipientOfMessage_CtmId", "dbo.CTM_ResponseHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_ResponseHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.TdmsCTM", "TradeLevel_CtmId", "dbo.CTM_MessageTradeLevel");
            DropForeignKey("dbo.CTM_MessageTradeLevel", "TradeLevelBody_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBody");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBody", "TradeLevelReferences_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelReferences");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBody", "TradeLevelInformation_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", "TotalTradeAmount_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTotalTradeAmount");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", "TimeZone_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTimeZone");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", "QuantityOfTheBlockTrade_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", "DealPrice_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationDealPrice");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBody", "InstructingParty_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyInstructingParty");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBody", "IdentificationOfASecurity_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity", "SecurityCodeType_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecuritySecurityCodeType");
            DropForeignKey("dbo.CTM_MessageTradeLevelTradeLevelBody", "ExecutingBroker_CtmId", "dbo.CTM_MessageTradeLevelTradeLevelBodyExecutingBroker");
            DropForeignKey("dbo.CTM_MessageTradeLevel", "SubmitHeader_CtmId", "dbo.CTM_MessageTradeLevelSubmitHeader");
            DropForeignKey("dbo.CTM_MessageTradeLevelSubmitHeader", "RecipientOfMessage_CtmId", "dbo.CTM_MessageTradeLevelSubmitHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageTradeLevelSubmitHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageTradeLevelSubmitHeaderOriginatorOfMessage");
            DropForeignKey("dbo.TdmsCTM", "TradeDetail_CtmId", "dbo.CTM_");
            DropForeignKey("dbo.CTM_", "TradeDetailBody_CtmId", "dbo.CTM_TradeDetailBody");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeLevelReferences_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelReferences");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeLevelInformation_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformation");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeLevelInformation", "DealPrice_CtmId", "dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeDetailReferences_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailReferences");
            DropForeignKey("dbo.CTM_TradeDetailBody", "TradeDetailData_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailData");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "TradeAmount_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "QuantityAllocated_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "NetCashAmount_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailData", "CommFeesTaxes_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", "Commissions_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions");
            DropForeignKey("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", "Commission_CtmId", "dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission");
            DropForeignKey("dbo.CTM_TradeDetailBody", "PartySettlement_CtmId", "dbo.CTM_TradeDetailBodyPartySettlement");
            DropForeignKey("dbo.CTM_TradeDetailBody", "IPSettlement_CtmId", "dbo.CTM_TradeDetailBodyIPSettlement");
            DropForeignKey("dbo.CTM_TradeDetailBody", "InstructingParty_CtmId", "dbo.CTM_TradeDetailBodyInstructingParty");
            DropForeignKey("dbo.CTM_TradeDetailBody", "IdentificationOfASecurity_CtmId", "dbo.CTM_TradeDetailBodyIdentificationOfASecurity");
            DropForeignKey("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", "SecurityCodeType_CtmId", "dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType");
            DropForeignKey("dbo.CTM_TradeDetailBody", "ExecutingBroker_CtmId", "dbo.CTM_TradeDetailBodyExecutingBroker");
            DropForeignKey("dbo.CTM_", "SubmitHeader_CtmId", "dbo.CTM_SubmitHeader");
            DropForeignKey("dbo.CTM_SubmitHeader", "RecipientOfMessage_CtmId", "dbo.CTM_RecipientOfMessage");
            DropForeignKey("dbo.CTM_SubmitHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.TdmsCTM", "MultiTradeLevelResponse_CtmId", "dbo.CTM_");
            DropForeignKey("dbo.CTM_", "ResponseHeader_CtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_ResponseHeader", "RecipientOfMessage_CtmId", "dbo.CTM_ResponseHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_ResponseHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.CTM_", "MultiTradeLevelResponseBody_CtmId", "dbo.CTM_MultiTradeLevelResponseBody");
            DropForeignKey("dbo.TdmsCTM", "MultiTradeLevelRequest_CtmId", "dbo.CTM_");
            DropForeignKey("dbo.CTM_", "SubmitHeader_CtmId", "dbo.CTM_Header");
            DropForeignKey("dbo.CTM_Header", "RecipientOfMessage_CtmId", "dbo.CTM_RecipientOfMessage");
            DropForeignKey("dbo.CTM_Header", "OriginatorOfMessage_CtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.CTM_", "MultiTradeLevelRequestBody_CtmId", "dbo.CTM_MultiTradeLevelRequestBody");
            DropForeignKey("dbo.TdmsCTM", "MultiTradeDetailResponse_CtmId", "dbo.CTM_MultiTradeDetailResponse");
            DropForeignKey("dbo.CTM_MultiTradeDetailResponse", "ResponseHeader_CtmId", "dbo.CTM_ResponseHeader");
            DropForeignKey("dbo.CTM_ResponseHeader", "RecipientOfMessage_CtmId", "dbo.CTM_ResponseHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_ResponseHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_OriginatorOfMessage");
            DropForeignKey("dbo.CTM_MultiTradeDetailResponse", "MultiTradeDetailResponseBody_CtmId", "dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody");
            DropForeignKey("dbo.TdmsCTM", "MultiTradeDetailRequest_CtmId", "dbo.CTM_MessageMultiTradeDetailRequest");
            DropForeignKey("dbo.CTM_MessageMultiTradeDetailRequest", "SubmitHeader_CtmId", "dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader");
            DropForeignKey("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader", "RecipientOfMessage_CtmId", "dbo.CTM_MessageMultiTradeDetailRequestSubmitHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageMultiTradeDetailRequestSubmitHeaderOriginatorOfMessage");
            DropForeignKey("dbo.CTM_MessageMultiTradeDetailRequest", "MultiTradeDetailRequestBody_CtmId", "dbo.CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBody");
            DropForeignKey("dbo.TdmsCTM", "Invalid_CtmId", "dbo.CTM_MessageInvalid");
            DropForeignKey("dbo.CTM_MessageInvalid", "InvalidHeader_CtmId", "dbo.CTM_MessageInvalidInvalidHeader");
            DropForeignKey("dbo.CTM_MessageInvalidInvalidHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageInvalidInvalidHeaderOriginatorOfMessage");
            DropForeignKey("dbo.CTM_MessageInvalid", "InvalidBody_CtmId", "dbo.CTM_MessageInvalidInvalidBody");
            DropForeignKey("dbo.CTM_MessageInvalidInvalidBody", "SynchError_CtmId", "dbo.CTM_MessageInvalidInvalidBodySynchError");
            DropForeignKey("dbo.TdmsCTM", "InfoRequest_CtmId", "dbo.CTM_MessageInfoRequest");
            DropForeignKey("dbo.CTM_MessageInfoRequest", "SubmitHeader_CtmId", "dbo.SubmitHeader");
            DropForeignKey("dbo.SubmitHeader", "RecipientOfMessage_CtmId", "dbo.SubmitHeaderRecipientOfMessage");
            DropForeignKey("dbo.SubmitHeader", "OriginatorOfMessage_CtmId", "dbo.SubmitHeaderOriginatorOfMessage");
            DropForeignKey("dbo.CTM_MessageInfoRequest", "InfoRequestBody_CtmId", "dbo.CTM_MessageInfoRequestInfoRequestBody");
            DropForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBody", "ExecutingBroker_CtmId", "dbo.CTM_MessageInfoRequestInfoRequestBodyExecutingBroker");
            DropForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBody", "AccessPath_CtmId", "dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath");
            DropForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath", "TradeLevelIdentifiers_CtmId", "dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPathTradeLevelIdentifiers");
            DropIndex("dbo.CTM_ValidBody", new[] { "InstructingParty_CtmId" });
            DropIndex("dbo.CTM_ValidBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_", new[] { "ValidBody_CtmId" });
            DropIndex("dbo.CTM_", new[] { "ResponseHeader_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", new[] { "TotalTradeAmount_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", new[] { "TimeZone_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", new[] { "QuantityOfTheBlockTrade_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation", new[] { "DealPrice_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity", new[] { "SecurityCodeType_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBody", new[] { "TradeLevelReferences_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBody", new[] { "TradeLevelInformation_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBody", new[] { "InstructingParty_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBody", new[] { "IdentificationOfASecurity_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelTradeLevelBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelSubmitHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevelSubmitHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevel", new[] { "TradeLevelBody_CtmId" });
            DropIndex("dbo.CTM_MessageTradeLevel", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "TotalTradeAmount_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "TimeZone_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "QuantityOfTheBlockTrade_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeLevelInformation", new[] { "DealPrice_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", new[] { "Commission_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes", new[] { "Commissions_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "TradeAmount_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "QuantityAllocated_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "NetCashAmount_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyTradeDetailData", new[] { "CommFeesTaxes_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBodyIdentificationOfASecurity", new[] { "SecurityCodeType_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeLevelReferences_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeLevelInformation_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeDetailReferences_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "TradeDetailData_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "PartySettlement_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "IPSettlement_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "InstructingParty_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "IdentificationOfASecurity_CtmId" });
            DropIndex("dbo.CTM_TradeDetailBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_SubmitHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_SubmitHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_", new[] { "TradeDetailBody_CtmId" });
            DropIndex("dbo.CTM_", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_", new[] { "ResponseHeader_CtmId" });
            DropIndex("dbo.CTM_", new[] { "MultiTradeLevelResponseBody_CtmId" });
            DropIndex("dbo.CTM_Header", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_Header", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_", new[] { "MultiTradeLevelRequestBody_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_ResponseHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailResponse", new[] { "ResponseHeader_CtmId" });
            DropIndex("dbo.CTM_MultiTradeDetailResponse", new[] { "MultiTradeDetailResponseBody_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailRequest", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailRequest", new[] { "MultiTradeDetailRequestBody_CtmId" });
            DropIndex("dbo.CTM_MessageInvalidInvalidHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageInvalidInvalidBody", new[] { "SynchError_CtmId" });
            DropIndex("dbo.CTM_MessageInvalid", new[] { "InvalidHeader_CtmId" });
            DropIndex("dbo.CTM_MessageInvalid", new[] { "InvalidBody_CtmId" });
            DropIndex("dbo.SubmitHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.SubmitHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath", new[] { "TradeLevelIdentifiers_CtmId" });
            DropIndex("dbo.CTM_MessageInfoRequestInfoRequestBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_MessageInfoRequestInfoRequestBody", new[] { "AccessPath_CtmId" });
            DropIndex("dbo.CTM_MessageInfoRequest", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_MessageInfoRequest", new[] { "InfoRequestBody_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "Valid_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "TradeLevel_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "TradeDetail_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "MultiTradeLevelResponse_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "MultiTradeLevelRequest_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "MultiTradeDetailResponse_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "MultiTradeDetailRequest_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "Invalid_CtmId" });
            DropIndex("dbo.TdmsCTM", new[] { "InfoRequest_CtmId" });
            DropTable("dbo.CTM_ValidBodyInstructingParty");
            DropTable("dbo.CTM_ValidBodyExecutingBroker");
            DropTable("dbo.CTM_ValidBody");
            DropTable("dbo.CTM_ResponseHeaderRecipientOfMessage");
            DropTable("dbo.CTM_OriginatorOfMessage");
            DropTable("dbo.CTM_ResponseHeader");
            DropTable("dbo.CTM_");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelReferences");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTotalTradeAmount");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationTimeZone");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformationDealPrice");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyTradeLevelInformation");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyInstructingParty");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecuritySecurityCodeType");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyIdentificationOfASecurity");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBodyExecutingBroker");
            DropTable("dbo.CTM_MessageTradeLevelTradeLevelBody");
            DropTable("dbo.CTM_MessageTradeLevelSubmitHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageTradeLevelSubmitHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageTradeLevelSubmitHeader");
            DropTable("dbo.CTM_MessageTradeLevel");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelReferences");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationTimeZone");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformationDealPrice");
            DropTable("dbo.CTM_TradeDetailBodyTradeLevelInformation");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailReferences");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataTradeAmount");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataQuantityAllocated");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataNetCashAmount");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes");
            DropTable("dbo.CTM_TradeDetailBodyTradeDetailData");
            DropTable("dbo.CTM_TradeDetailBodyPartySettlement");
            DropTable("dbo.CTM_TradeDetailBodyIPSettlement");
            DropTable("dbo.CTM_TradeDetailBodyInstructingParty");
            DropTable("dbo.CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType");
            DropTable("dbo.CTM_TradeDetailBodyIdentificationOfASecurity");
            DropTable("dbo.CTM_TradeDetailBodyExecutingBroker");
            DropTable("dbo.CTM_TradeDetailBody");
            DropTable("dbo.CTM_RecipientOfMessage");
            DropTable("dbo.CTM_OriginatorOfMessage");
            DropTable("dbo.CTM_SubmitHeader");
            DropTable("dbo.CTM_");
            DropTable("dbo.CTM_ResponseHeaderRecipientOfMessage");
            DropTable("dbo.CTM_OriginatorOfMessage");
            DropTable("dbo.CTM_ResponseHeader");
            DropTable("dbo.CTM_MultiTradeLevelResponseBody");
            DropTable("dbo.CTM_");
            DropTable("dbo.CTM_RecipientOfMessage");
            DropTable("dbo.CTM_OriginatorOfMessage");
            DropTable("dbo.CTM_Header");
            DropTable("dbo.CTM_MultiTradeLevelRequestBody");
            DropTable("dbo.CTM_");
            DropTable("dbo.CTM_ResponseHeaderRecipientOfMessage");
            DropTable("dbo.CTM_OriginatorOfMessage");
            DropTable("dbo.CTM_ResponseHeader");
            DropTable("dbo.CTM_MultiTradeDetailResponseMultiTradeDetailResponseBody");
            DropTable("dbo.CTM_MultiTradeDetailResponse");
            DropTable("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader");
            DropTable("dbo.CTM_MessageMultiTradeDetailRequestMultiTradeDetailRequestBody");
            DropTable("dbo.CTM_MessageMultiTradeDetailRequest");
            DropTable("dbo.CTM_MessageInvalidInvalidHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageInvalidInvalidHeader");
            DropTable("dbo.CTM_MessageInvalidInvalidBodySynchError");
            DropTable("dbo.CTM_MessageInvalidInvalidBody");
            DropTable("dbo.CTM_MessageInvalid");
            DropTable("dbo.SubmitHeaderRecipientOfMessage");
            DropTable("dbo.SubmitHeaderOriginatorOfMessage");
            DropTable("dbo.SubmitHeader");
            DropTable("dbo.CTM_MessageInfoRequestInfoRequestBodyExecutingBroker");
            DropTable("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPathTradeLevelIdentifiers");
            DropTable("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath");
            DropTable("dbo.CTM_MessageInfoRequestInfoRequestBody");
            DropTable("dbo.CTM_MessageInfoRequest");
            DropTable("dbo.TdmsCTM");
        }
    }
}
