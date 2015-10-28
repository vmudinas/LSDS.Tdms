using LSDS.CTM;
using LSDS.CTM.CtmMessages;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class SendTradeDetail : ICtmProcess
    {

        //private readonly string _protocolVersion;
        //private readonly string _sendersMessageReference;
        //private readonly DateTime _dateTimeOfSentMessage;
        //private readonly string _orgPartyRole;
        //private readonly string _orgPartyType;
        //private readonly string _orgPartyValue;
        //private readonly string _receiptPartyRole;
        //private readonly string _receiptPartyType;
        //private readonly string _receiptPartyValue;
        //private readonly string _functionOfTheMessage;
        //private readonly byte _versionOfTradeComponent;
        //private readonly string _instructingPartyRole;
        //private readonly string _instructingPartyType;
        //private readonly string _instructingPartyValue;
        //private readonly string _executingBrokerPartyRole;
        //private readonly string _executingBrokerPartyType;
        //private readonly string _executingBrokerPartyValue;
        //private readonly string _masterReference;
        //private readonly string _numberingAgencyCode;
        //private readonly string _typeOfTransactionIndicator;
        //private readonly string _buySellIndicator;
        //private readonly string _typeOfFinancialInstrument;
        //private readonly DateTime _tradeDateTime;
        //private readonly uint _settlementDate;
        //private readonly string _currencyCode;
        //private readonly string _amount;
        //private readonly string _quantityTypeCode;
        //private readonly string _qTypeCodeAmount;
        //private readonly string _currencyCodeTotalTradeAmount;
        //private readonly string _currencyAmountTotalTradeAmount;
        //private readonly string _timeZoneTradeTimeQualifier;
        //private readonly string _securityCode;
        //private readonly string _descriptionOfTheSecurity;
        private readonly CTM_Message _message;

        public SendTradeDetail()
        {
        }

        public SendTradeDetail(CTM_Message message)
        {
            _message = message;
            
            //_protocolVersion = msg.TradeDetail.SubmitHeader.ProtocolVersion;
            //_sendersMessageReference = msg.TradeDetail.SubmitHeader.SendersMessageReference;
            //_dateTimeOfSentMessage = msg.TradeDetail.SubmitHeader.DateTimeOfSentMessage;
            //_orgPartyRole = msg.TradeDetail.SubmitHeader.OriginatorOfMessage.PartyRole;
            //_orgPartyType = msg.TradeDetail.SubmitHeader.OriginatorOfMessage.PartyType;
            //_orgPartyValue = msg.TradeDetail.SubmitHeader.OriginatorOfMessage.PartyValue;
            //_receiptPartyRole = msg.TradeDetail.SubmitHeader.RecipientOfMessage.PartyRole;
            //_receiptPartyType = msg.TradeDetail.SubmitHeader.RecipientOfMessage.PartyType;
            //_receiptPartyValue = msg.TradeDetail.SubmitHeader.RecipientOfMessage.PartyValue;
            //_functionOfTheMessage = msg.TradeDetail.TradeDetailBody.FunctionOfTheMessage;
            //_versionOfTradeComponent = msg.TradeDetail.TradeDetailBody.VersionOfTradeComponent;
            //_instructingPartyRole = msg.TradeDetail.TradeDetailBody.InstructingParty.PartyRole;
            //_instructingPartyType = msg.TradeDetail.TradeDetailBody.InstructingParty.PartyType;
            //_instructingPartyValue = msg.TradeDetail.TradeDetailBody.InstructingParty.PartyValue;
            //_executingBrokerPartyRole = msg.TradeDetail.TradeDetailBody.ExecutingBroker.PartyRole;
            //_executingBrokerPartyType = msg.TradeDetail.TradeDetailBody.ExecutingBroker.PartyType;
            //_executingBrokerPartyValue = msg.TradeDetail.TradeDetailBody.ExecutingBroker.PartyValue;
            //_masterReference = msg.TradeDetail.TradeDetailBody.TradeLevelReferences.MasterReference;
            //_numberingAgencyCode = msg.TradeDetail.TradeDetailBody.IdentificationOfASecurity.SecurityCodeType.NumberingAgencyCode;
            //_typeOfTransactionIndicator = typeOfTransactionIndicator;
            //_buySellIndicator = buySellIndicator;
            //_typeOfFinancialInstrument = typeOfFinancialInstrument;
            //_tradeDateTime = tradeDateTime;
            //_settlementDate = settlementDate;
            //_currencyCode = currencyCode;
            //_amount = amount;
            //_quantityTypeCode = quantityTypeCode;
            //_qTypeCodeAmount = qTypeCodeAmount;
            //_currencyCodeTotalTradeAmount = currencyCodeTotalTradeAmount;
            //_currencyAmountTotalTradeAmount = currencyAmountTotalTradeAmount;
            //_timeZoneTradeTimeQualifier = timeZoneTimeQualifier;
            //_securityCode = securityCode;
        }
/*

        public CTM_Message GenerateTradeDetailRequest()
        {
            var msg = new CTM_Message();
            var newReuqestMsg = new CTM_TradeDetail();

            var newSubmitHeaderMsg = new CTM_Header
            {
                ProtocolVersion = _protocolVersion, //"CM01",
                SendersMessageReference = _sendersMessageReference, // "ars455",
                DateTimeOfSentMessage = _dateTimeOfSentMessage // 20150202112233 // (DateTime) DateTime.Now.Ticks
            };
            var originatorOfMeessage = new CTM_OriginatorOfMessage
            {
                PartyRole = _orgPartyRole, //"MEOR",
                PartyType = _orgPartyType, //"BIC",
                PartyValue = _orgPartyValue // "LIGHTSPD"
            };

            var recipientOfMessage = new CTM_RecipientOfMessage
            {
                PartyRole = _receiptPartyRole, //"MEOR",
                PartyType = _receiptPartyType, //"BIC",
                PartyValue = _receiptPartyValue // "LIGHTSPD"
            };

            newSubmitHeaderMsg.OriginatorOfMessage = originatorOfMeessage;
            newSubmitHeaderMsg.RecipientOfMessage = recipientOfMessage;

          
           
            var newExecutingBroker = new CTM_TradeDetailBodyExecutingBroker
            {
                PartyRole = _executingBrokerPartyRole, //"EXEC",
                PartyType = _executingBrokerPartyType, //"BIC",
                PartyValue = _executingBrokerPartyValue // "TECHSOLBXXX"

            };
            var newTradeDetailReferences = new CTM_TradeDetailBodyTradeDetailReferences
            {
              //  MasterReference = _masterReference //"-893838912000000",
            };

           
            var newIdentificationOfASecuritySecurityCodeType = new CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType
            {
                NumberingAgencyCode = _numberingAgencyCode,
                 //"SEDO"
              
            };
            var newSecurityCodeType = new CTM_TradeDetailBodyIdentificationOfASecurity
            {
                SecurityCodeType = newIdentificationOfASecuritySecurityCodeType, //"v",
                SecurityCode = _securityCode,
                DescriptionOfTheSecurity = _descriptionOfTheSecurity
                //SecurityCode = _securityCode//5668287
            };
            var newDealPrice = new CTM_TradeDetailBodyTradeLevelInformationDealPrice
            {
                CurrencyCode = _currencyCode, //USD
                Amount = _amount // Ammount
            };
            var newQuantityOfTheBlockTrade = new CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade
            {
                QuantityTypeCode = _quantityTypeCode, //USD
                Amount = _qTypeCodeAmount // Ammount
            };
            var newTotalTradeAmount = new CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount
            {
                CurrencyCode = _currencyCodeTotalTradeAmount, //USD
                Amount = _currencyAmountTotalTradeAmount // Ammount
            };
            var newTimeZone = new CTM_TradeDetailBodyTradeLevelInformationTimeZone
                
            {
                TradeTimeQualifier = _timeZoneTradeTimeQualifier //LOCL

            };

            var newTradeDetailInformation = new CTM_TradeDetailBodyTradeLevelInformation
            {
                TypeOfTransactionIndicator = _typeOfTransactionIndicator, //  TRAD 
                BuySellIndicator = _buySellIndicator, // BUYI
                TypeOfFinancialInstrument = _typeOfFinancialInstrument, // COMM 
                TradeDateTime = _tradeDateTime, // 20150504094438 
                SettlementDate  = _settlementDate//,  //> 20150505
                //DealPrice = newDealPrice,
                //QuantityOfTheBlockTrade = newQuantityOfTheBlockTrade,
                //TotalTradeAmount = newTotalTradeAmount,
               // TimeZone = newTimeZone

            };

            var newInstructingParty = new CTM_TradeDetailBodyInstructingParty
            {
                PartyRole = _instructingPartyRole, //"INST",
                PartyType = _instructingPartyType, //"BIC",
                PartyValue = _instructingPartyValue // "LIGHTSPD"
            };



            var newRequestBodyMsg = new CTM_TradeDetailBody
            {
                FunctionOfTheMessage = _functionOfTheMessage, //"NEWM"
                VersionOfTradeComponent = _versionOfTradeComponent, //"001",
                IdentificationOfASecurity = newSecurityCodeType,
                InstructingParty = newInstructingParty,
                ExecutingBroker = newExecutingBroker,
                TradeDetailReferences = newTradeDetailReferences
              //  TradeDetailInformation = newTradeDetailInformation
            };

            newReuqestMsg.SubmitHeader = newSubmitHeaderMsg;
            newReuqestMsg.TradeDetailBody = newRequestBodyMsg;
            msg.TradeDetail = newReuqestMsg;

            return msg;
        }
        */


        public CTM_Message SendMsg(DCIWebSession con)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("TradeDetail", _message), false, con, "TradeDetail");

        }

        public CTM_Message SendMsgString(DCIWebSession con, string message)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("TradeDetail", message), false, con, "TradeDetail");

        }

    }
}