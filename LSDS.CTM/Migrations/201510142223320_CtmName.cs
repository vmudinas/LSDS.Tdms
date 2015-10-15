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
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailResponse", t => t.MultiTradeDetailResponse_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelRequest", t => t.MultiTradeLevelRequest_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelResponse", t => t.MultiTradeLevelResponse_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetail", t => t.TradeDetail_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeLevel", t => t.TradeLevel_CtmId)
                .ForeignKey("dbo.CTM_MessageValid", t => t.Valid_CtmId)
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
                .ForeignKey("dbo.CTM_MessageInfoRequestSubmitHeader", t => t.SubmitHeader_CtmId)
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
                "dbo.CTM_MessageInfoRequestSubmitHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        SendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageInfoRequestSubmitHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_MessageInfoRequestSubmitHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInfoRequestSubmitHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageInfoRequestSubmitHeaderRecipientOfMessage",
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
                "dbo.CTM_MessageMultiTradeDetailResponse",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeDetailResponseBody_CtmId = c.Int(),
                        ResponseHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailResponseMultiTradeDetailResponseBody", t => t.MultiTradeDetailResponseBody_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailResponseResponseHeader", t => t.ResponseHeader_CtmId)
                .Index(t => t.MultiTradeDetailResponseBody_CtmId)
                .Index(t => t.ResponseHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailResponseMultiTradeDetailResponseBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        RecordsReturnedCount = c.Byte(nullable: false),
                        MoreFlag = c.String(),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailResponseResponseHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        EchoSendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailResponseResponseHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeDetailResponseResponseHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailResponseResponseHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeDetailResponseResponseHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelRequest",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelRequestBody_CtmId = c.Int(),
                        SubmitHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelRequestMultiTradeLevelRequestBody", t => t.MultiTradeLevelRequestBody_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeader", t => t.SubmitHeader_CtmId)
                .Index(t => t.MultiTradeLevelRequestBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelRequestMultiTradeLevelRequestBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelResponseIndicator = c.String(),
                        ByOrAgainstFlag = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelRequestSubmitHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        SendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelRequestSubmitHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelRequestSubmitHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelResponse",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        MultiTradeLevelResponseBody_CtmId = c.Int(),
                        ResponseHeader_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBody", t => t.MultiTradeLevelResponseBody_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelResponseResponseHeader", t => t.ResponseHeader_CtmId)
                .Index(t => t.MultiTradeLevelResponseBody_CtmId)
                .Index(t => t.ResponseHeader_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBody",
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
                "dbo.CTM_MessageMultiTradeLevelResponseResponseHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        EchoSendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelResponseResponseHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_MessageMultiTradeLevelResponseResponseHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelResponseResponseHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageMultiTradeLevelResponseResponseHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetail",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SubmitHeader_CtmId = c.Int(),
                        TradeDetailBody_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailSubmitHeader", t => t.SubmitHeader_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", t => t.TradeDetailBody_CtmId)
                .Index(t => t.SubmitHeader_CtmId)
                .Index(t => t.TradeDetailBody_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailSubmitHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        SendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailSubmitHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailSubmitHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailSubmitHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailSubmitHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBody",
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
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity", t => t.IdentificationOfASecurity_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyInstructingParty", t => t.InstructingParty_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyIPSettlement", t => t.IPSettlement_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyPartySettlement", t => t.PartySettlement_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", t => t.TradeDetailData_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailReferences", t => t.TradeDetailReferences_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation", t => t.TradeLevelInformation_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelReferences", t => t.TradeLevelReferences_CtmId)
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
                "dbo.CTM_MessageTradeDetailTradeDetailBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        SecurityCode = c.String(),
                        DescriptionOfTheSecurity = c.String(),
                        SecurityCodeType_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecuritySecurityCodeType", t => t.SecurityCodeType_CtmId)
                .Index(t => t.SecurityCodeType_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecuritySecurityCodeType",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        NumberingAgencyCode = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyInstructingParty",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyIPSettlement",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        AccountID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyPartySettlement",
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
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CommFeesTaxes_CtmId = c.Int(),
                        NetCashAmount_CtmId = c.Int(),
                        QuantityAllocated_CtmId = c.Int(),
                        TradeAmount_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes", t => t.CommFeesTaxes_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataNetCashAmount", t => t.NetCashAmount_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataQuantityAllocated", t => t.QuantityAllocated_CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataTradeAmount", t => t.TradeAmount_CtmId)
                .Index(t => t.CommFeesTaxes_CtmId)
                .Index(t => t.NetCashAmount_CtmId)
                .Index(t => t.QuantityAllocated_CtmId)
                .Index(t => t.TradeAmount_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Commissions_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", t => t.Commissions_CtmId)
                .Index(t => t.Commissions_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CommissionSharingBasisIndicator = c.String(),
                        CommissionType = c.String(),
                        Commission_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission", t => t.Commission_CtmId)
                .Index(t => t.Commission_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        Sign = c.String(),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataNetCashAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataQuantityAllocated",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataTradeAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailReferences",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ClientAllocationReference = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation",
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
                .ForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationDealPrice", t => t.DealPrice_CtmId)
                .Index(t => t.DealPrice_CtmId)
                .Index(t => t.QuantityOfTheBlockTrade_CtmId)
                .Index(t => t.TimeZone_CtmId)
                .Index(t => t.TotalTradeAmount_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationDealPrice",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        QuantityTypeCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTimeZone",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        TradeTimeQualifier = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTotalTradeAmount",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        CurrencyCode = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelReferences",
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
                "dbo.CTM_MessageValid",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ResponseHeader_CtmId = c.Int(),
                        ValidBody_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageValidResponseHeader", t => t.ResponseHeader_CtmId)
                .ForeignKey("dbo.CTM_MessageValidValidBody", t => t.ValidBody_CtmId)
                .Index(t => t.ResponseHeader_CtmId)
                .Index(t => t.ValidBody_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageValidResponseHeader",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        ProtocolVersion = c.String(),
                        EchoSendersMessageReference = c.String(),
                        OriginatorOfMessage_CtmId = c.Int(),
                        RecipientOfMessage_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageValidResponseHeaderOriginatorOfMessage", t => t.OriginatorOfMessage_CtmId)
                .ForeignKey("dbo.CTM_MessageValidResponseHeaderRecipientOfMessage", t => t.RecipientOfMessage_CtmId)
                .Index(t => t.OriginatorOfMessage_CtmId)
                .Index(t => t.RecipientOfMessage_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageValidResponseHeaderOriginatorOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageValidResponseHeaderRecipientOfMessage",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageValidValidBody",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        EchoMasterReference = c.Long(nullable: false),
                        ExecutingBroker_CtmId = c.Int(),
                        InstructingParty_CtmId = c.Int(),
                    })
                .PrimaryKey(t => t.CtmId)
                .ForeignKey("dbo.CTM_MessageValidValidBodyExecutingBroker", t => t.ExecutingBroker_CtmId)
                .ForeignKey("dbo.CTM_MessageValidValidBodyInstructingParty", t => t.InstructingParty_CtmId)
                .Index(t => t.ExecutingBroker_CtmId)
                .Index(t => t.InstructingParty_CtmId);
            
            CreateTable(
                "dbo.CTM_MessageValidValidBodyExecutingBroker",
                c => new
                    {
                        CtmId = c.Int(nullable: false, identity: true),
                        PartyRole = c.String(),
                        PartyType = c.String(),
                        PartyValue = c.String(),
                    })
                .PrimaryKey(t => t.CtmId);
            
            CreateTable(
                "dbo.CTM_MessageValidValidBodyInstructingParty",
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
            DropForeignKey("dbo.TdmsCTM", "Valid_CtmId", "dbo.CTM_MessageValid");
            DropForeignKey("dbo.CTM_MessageValid", "ValidBody_CtmId", "dbo.CTM_MessageValidValidBody");
            DropForeignKey("dbo.CTM_MessageValidValidBody", "InstructingParty_CtmId", "dbo.CTM_MessageValidValidBodyInstructingParty");
            DropForeignKey("dbo.CTM_MessageValidValidBody", "ExecutingBroker_CtmId", "dbo.CTM_MessageValidValidBodyExecutingBroker");
            DropForeignKey("dbo.CTM_MessageValid", "ResponseHeader_CtmId", "dbo.CTM_MessageValidResponseHeader");
            DropForeignKey("dbo.CTM_MessageValidResponseHeader", "RecipientOfMessage_CtmId", "dbo.CTM_MessageValidResponseHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageValidResponseHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageValidResponseHeaderOriginatorOfMessage");
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
            DropForeignKey("dbo.TdmsCTM", "TradeDetail_CtmId", "dbo.CTM_MessageTradeDetail");
            DropForeignKey("dbo.CTM_MessageTradeDetail", "TradeDetailBody_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBody");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "TradeLevelReferences_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelReferences");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "TradeLevelInformation_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation", "DealPrice_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationDealPrice");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "TradeDetailReferences_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailReferences");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "TradeDetailData_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", "TradeAmount_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataTradeAmount");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", "QuantityAllocated_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataQuantityAllocated");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", "NetCashAmount_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataNetCashAmount");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", "CommFeesTaxes_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes", "Commissions_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", "Commission_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "PartySettlement_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyPartySettlement");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "IPSettlement_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyIPSettlement");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "InstructingParty_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyInstructingParty");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "IdentificationOfASecurity_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity", "SecurityCodeType_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecuritySecurityCodeType");
            DropForeignKey("dbo.CTM_MessageTradeDetailTradeDetailBody", "ExecutingBroker_CtmId", "dbo.CTM_MessageTradeDetailTradeDetailBodyExecutingBroker");
            DropForeignKey("dbo.CTM_MessageTradeDetail", "SubmitHeader_CtmId", "dbo.CTM_MessageTradeDetailSubmitHeader");
            DropForeignKey("dbo.CTM_MessageTradeDetailSubmitHeader", "RecipientOfMessage_CtmId", "dbo.CTM_MessageTradeDetailSubmitHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageTradeDetailSubmitHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageTradeDetailSubmitHeaderOriginatorOfMessage");
            DropForeignKey("dbo.TdmsCTM", "MultiTradeLevelResponse_CtmId", "dbo.CTM_MessageMultiTradeLevelResponse");
            DropForeignKey("dbo.CTM_MessageMultiTradeLevelResponse", "ResponseHeader_CtmId", "dbo.CTM_MessageMultiTradeLevelResponseResponseHeader");
            DropForeignKey("dbo.CTM_MessageMultiTradeLevelResponseResponseHeader", "RecipientOfMessage_CtmId", "dbo.CTM_MessageMultiTradeLevelResponseResponseHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageMultiTradeLevelResponseResponseHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageMultiTradeLevelResponseResponseHeaderOriginatorOfMessage");
            DropForeignKey("dbo.CTM_MessageMultiTradeLevelResponse", "MultiTradeLevelResponseBody_CtmId", "dbo.CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBody");
            DropForeignKey("dbo.TdmsCTM", "MultiTradeLevelRequest_CtmId", "dbo.CTM_MessageMultiTradeLevelRequest");
            DropForeignKey("dbo.CTM_MessageMultiTradeLevelRequest", "SubmitHeader_CtmId", "dbo.CTM_MessageMultiTradeLevelRequestSubmitHeader");
            DropForeignKey("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeader", "RecipientOfMessage_CtmId", "dbo.CTM_MessageMultiTradeLevelRequestSubmitHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageMultiTradeLevelRequestSubmitHeaderOriginatorOfMessage");
            DropForeignKey("dbo.CTM_MessageMultiTradeLevelRequest", "MultiTradeLevelRequestBody_CtmId", "dbo.CTM_MessageMultiTradeLevelRequestMultiTradeLevelRequestBody");
            DropForeignKey("dbo.TdmsCTM", "MultiTradeDetailResponse_CtmId", "dbo.CTM_MessageMultiTradeDetailResponse");
            DropForeignKey("dbo.CTM_MessageMultiTradeDetailResponse", "ResponseHeader_CtmId", "dbo.CTM_MessageMultiTradeDetailResponseResponseHeader");
            DropForeignKey("dbo.CTM_MessageMultiTradeDetailResponseResponseHeader", "RecipientOfMessage_CtmId", "dbo.CTM_MessageMultiTradeDetailResponseResponseHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageMultiTradeDetailResponseResponseHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageMultiTradeDetailResponseResponseHeaderOriginatorOfMessage");
            DropForeignKey("dbo.CTM_MessageMultiTradeDetailResponse", "MultiTradeDetailResponseBody_CtmId", "dbo.CTM_MessageMultiTradeDetailResponseMultiTradeDetailResponseBody");
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
            DropForeignKey("dbo.CTM_MessageInfoRequest", "SubmitHeader_CtmId", "dbo.CTM_MessageInfoRequestSubmitHeader");
            DropForeignKey("dbo.CTM_MessageInfoRequestSubmitHeader", "RecipientOfMessage_CtmId", "dbo.CTM_MessageInfoRequestSubmitHeaderRecipientOfMessage");
            DropForeignKey("dbo.CTM_MessageInfoRequestSubmitHeader", "OriginatorOfMessage_CtmId", "dbo.CTM_MessageInfoRequestSubmitHeaderOriginatorOfMessage");
            DropForeignKey("dbo.CTM_MessageInfoRequest", "InfoRequestBody_CtmId", "dbo.CTM_MessageInfoRequestInfoRequestBody");
            DropForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBody", "ExecutingBroker_CtmId", "dbo.CTM_MessageInfoRequestInfoRequestBodyExecutingBroker");
            DropForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBody", "AccessPath_CtmId", "dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath");
            DropForeignKey("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath", "TradeLevelIdentifiers_CtmId", "dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPathTradeLevelIdentifiers");
            DropIndex("dbo.CTM_MessageValidValidBody", new[] { "InstructingParty_CtmId" });
            DropIndex("dbo.CTM_MessageValidValidBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_MessageValidResponseHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageValidResponseHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageValid", new[] { "ValidBody_CtmId" });
            DropIndex("dbo.CTM_MessageValid", new[] { "ResponseHeader_CtmId" });
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
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation", new[] { "TotalTradeAmount_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation", new[] { "TimeZone_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation", new[] { "QuantityOfTheBlockTrade_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation", new[] { "DealPrice_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions", new[] { "Commission_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes", new[] { "Commissions_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", new[] { "TradeAmount_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", new[] { "QuantityAllocated_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", new[] { "NetCashAmount_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData", new[] { "CommFeesTaxes_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity", new[] { "SecurityCodeType_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "TradeLevelReferences_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "TradeLevelInformation_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "TradeDetailReferences_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "TradeDetailData_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "PartySettlement_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "IPSettlement_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "InstructingParty_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "IdentificationOfASecurity_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailTradeDetailBody", new[] { "ExecutingBroker_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailSubmitHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetailSubmitHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetail", new[] { "TradeDetailBody_CtmId" });
            DropIndex("dbo.CTM_MessageTradeDetail", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeLevelResponseResponseHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeLevelResponseResponseHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeLevelResponse", new[] { "ResponseHeader_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeLevelResponse", new[] { "MultiTradeLevelResponseBody_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeLevelRequest", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeLevelRequest", new[] { "MultiTradeLevelRequestBody_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailResponseResponseHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailResponseResponseHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailResponse", new[] { "ResponseHeader_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailResponse", new[] { "MultiTradeDetailResponseBody_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailRequestSubmitHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailRequest", new[] { "SubmitHeader_CtmId" });
            DropIndex("dbo.CTM_MessageMultiTradeDetailRequest", new[] { "MultiTradeDetailRequestBody_CtmId" });
            DropIndex("dbo.CTM_MessageInvalidInvalidHeader", new[] { "OriginatorOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageInvalidInvalidBody", new[] { "SynchError_CtmId" });
            DropIndex("dbo.CTM_MessageInvalid", new[] { "InvalidHeader_CtmId" });
            DropIndex("dbo.CTM_MessageInvalid", new[] { "InvalidBody_CtmId" });
            DropIndex("dbo.CTM_MessageInfoRequestSubmitHeader", new[] { "RecipientOfMessage_CtmId" });
            DropIndex("dbo.CTM_MessageInfoRequestSubmitHeader", new[] { "OriginatorOfMessage_CtmId" });
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
            DropTable("dbo.CTM_MessageValidValidBodyInstructingParty");
            DropTable("dbo.CTM_MessageValidValidBodyExecutingBroker");
            DropTable("dbo.CTM_MessageValidValidBody");
            DropTable("dbo.CTM_MessageValidResponseHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageValidResponseHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageValidResponseHeader");
            DropTable("dbo.CTM_MessageValid");
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
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelReferences");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTotalTradeAmount");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationTimeZone");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformationDealPrice");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeLevelInformation");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailReferences");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataTradeAmount");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataQuantityAllocated");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataNetCashAmount");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxesCommissions");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailDataCommFeesTaxes");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyTradeDetailData");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyPartySettlement");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyIPSettlement");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyInstructingParty");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecuritySecurityCodeType");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyIdentificationOfASecurity");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBodyExecutingBroker");
            DropTable("dbo.CTM_MessageTradeDetailTradeDetailBody");
            DropTable("dbo.CTM_MessageTradeDetailSubmitHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageTradeDetailSubmitHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageTradeDetailSubmitHeader");
            DropTable("dbo.CTM_MessageTradeDetail");
            DropTable("dbo.CTM_MessageMultiTradeLevelResponseResponseHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageMultiTradeLevelResponseResponseHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageMultiTradeLevelResponseResponseHeader");
            DropTable("dbo.CTM_MessageMultiTradeLevelResponseMultiTradeLevelResponseBody");
            DropTable("dbo.CTM_MessageMultiTradeLevelResponse");
            DropTable("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageMultiTradeLevelRequestSubmitHeader");
            DropTable("dbo.CTM_MessageMultiTradeLevelRequestMultiTradeLevelRequestBody");
            DropTable("dbo.CTM_MessageMultiTradeLevelRequest");
            DropTable("dbo.CTM_MessageMultiTradeDetailResponseResponseHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageMultiTradeDetailResponseResponseHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageMultiTradeDetailResponseResponseHeader");
            DropTable("dbo.CTM_MessageMultiTradeDetailResponseMultiTradeDetailResponseBody");
            DropTable("dbo.CTM_MessageMultiTradeDetailResponse");
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
            DropTable("dbo.CTM_MessageInfoRequestSubmitHeaderRecipientOfMessage");
            DropTable("dbo.CTM_MessageInfoRequestSubmitHeaderOriginatorOfMessage");
            DropTable("dbo.CTM_MessageInfoRequestSubmitHeader");
            DropTable("dbo.CTM_MessageInfoRequestInfoRequestBodyExecutingBroker");
            DropTable("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPathTradeLevelIdentifiers");
            DropTable("dbo.CTM_MessageInfoRequestInfoRequestBodyAccessPath");
            DropTable("dbo.CTM_MessageInfoRequestInfoRequestBody");
            DropTable("dbo.CTM_MessageInfoRequest");
            DropTable("dbo.TdmsCTM");
        }
    }
}
