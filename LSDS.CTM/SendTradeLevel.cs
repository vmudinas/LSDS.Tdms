using System;
using LSDS.CTM;
using LSDS.CTM.CtmMessages;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class SendTradeLevel : ICtmProcess
    {

        private readonly string _protocolVersion;
        private readonly string _sendersMessageReference;
        private readonly DateTime? _dateTimeOfSentMessage;
        private readonly string _orgPartyRole;
        private readonly string _orgPartyType;
        private readonly string _orgPartyValue;
        private readonly string _receiptPartyRole;
        private readonly string _receiptPartyType;
        private readonly string _receiptPartyValue;
        private readonly string _functionOfTheMessage;
        private readonly byte _versionOfTradeComponent;
        private readonly string _instructingPartyRole;
        private readonly string _instructingPartyType;
        private readonly string _instructingPartyValue;
        private readonly string _executingBrokerPartyRole;
        private readonly string _executingBrokerPartyType;
        private readonly string _executingBrokerPartyValue;
        private readonly string _masterReference;
        private readonly string _numberingAgencyCode;
        private readonly string _typeOfTransactionIndicator;
        private readonly string _buySellIndicator;
        private readonly string _typeOfFinancialInstrument;
        private readonly ulong _tradeDateTime;
        private readonly uint _settlementDate;
        private readonly string _currencyCode;
        private readonly string _amount;
        private readonly string _quantityTypeCode;
        private readonly string _qTypeCodeAmount;
        private readonly string _currencyCodeTotalTradeAmount;
        private readonly string _currencyAmountTotalTradeAmount;
        private readonly string _timeZoneTradeTimeQualifier;
        private readonly string _securityCode;


        public SendTradeLevel(string protocolVersion, string sendersMessageReference, DateTime? dateTimeOfSentMessage, string orgPartyRole,
            string orgPartyType, string orgPartyValue, string receiptPartyRole, string receiptPartyType, string receiptPartyValue,
            string functionOfTheMessage, byte versionOfTradeComponent, string instructingPartyRole, string instructingPartyType, 
            string instructingPartyValue, string executingBrokerPartyRole, string executingBrokerPartyType, string executingBrokerPartyValue, 
            string masterReference, string securityCode, string numberingAgencyCode, string typeOfTransactionIndicator, string buySellIndicator,
            string typeOfFinancialInstrument, ulong tradeDateTime, uint settlementDate, string currencyCode, string amount, string quantityTypeCode,
            string qTypeCodeAmount, string currencyCodeTotalTradeAmount, string currencyAmountTotalTradeAmount, 
            string timeZoneTimeQualifier)
        {
            _protocolVersion = protocolVersion;
            _sendersMessageReference = sendersMessageReference;
            _dateTimeOfSentMessage = dateTimeOfSentMessage;
            _orgPartyRole = orgPartyRole;
            _orgPartyType = orgPartyType;
            _orgPartyValue = orgPartyValue;
            _receiptPartyRole = receiptPartyRole;
            _receiptPartyType = receiptPartyType;
            _receiptPartyValue = receiptPartyValue;
            _functionOfTheMessage = functionOfTheMessage;
            _versionOfTradeComponent = versionOfTradeComponent;
            _instructingPartyRole = instructingPartyRole;
            _instructingPartyType = instructingPartyType;
            _instructingPartyValue = instructingPartyValue;
            _executingBrokerPartyRole = executingBrokerPartyRole;
            _executingBrokerPartyType = executingBrokerPartyType;
            _executingBrokerPartyValue = executingBrokerPartyValue;
            _masterReference = masterReference;
            _numberingAgencyCode = numberingAgencyCode;
            _typeOfTransactionIndicator = typeOfTransactionIndicator;
            _buySellIndicator = buySellIndicator;
            _typeOfFinancialInstrument = typeOfFinancialInstrument;
            _tradeDateTime = tradeDateTime;
            _settlementDate = settlementDate;
            _currencyCode = currencyCode;
            _amount = amount;
            _quantityTypeCode = quantityTypeCode;
            _qTypeCodeAmount = qTypeCodeAmount;
            _currencyCodeTotalTradeAmount = currencyCodeTotalTradeAmount;
            _currencyAmountTotalTradeAmount = currencyAmountTotalTradeAmount;
            _timeZoneTradeTimeQualifier = timeZoneTimeQualifier;
            _securityCode = securityCode;
        }


        public CTM_Message GenerateTradeLevelRequest()
        {
            var msg = new CTM_Message();
            var newReuqestMsg = new CTM_TradeLevel();

            var newSubmitHeaderMsg = new CTM_Header
            {
                ProtocolVersion = _protocolVersion, //"CM01",
                SendersMessageReference = _sendersMessageReference, // "ars455",
                DateTimeOfSentMessage = 20150202112233//_dateTimeOfSentMessage // 20150202112233 // (DateTime) DateTime.Now.Ticks
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

          
           
            var newExecutingBroker = new CTM_TradeLevelBodyExecutingBroker
            {
                PartyRole = _executingBrokerPartyRole, //"EXEC",
                PartyType = _executingBrokerPartyType, //"BIC",
                PartyValue = _executingBrokerPartyValue // "TECHSOLBXXX"

            };
            var newTradeLevelReferences = new CTM_TradeLevelBodyTradeLevelReferences
            {
                MasterReference = _masterReference //"-893838912000000",
            };

           
            var newIdentificationOfASecuritySecurityCodeType = new CTM_TradeLevelBodyIdentificationOfASecuritySecurityCodeType
            {
                NumberingAgencyCode = _numberingAgencyCode,
                 //"SEDO"
              
            };
            var newSecurityCodeType = new CTM_TradeLevelBodyIdentificationOfASecurity
            {
                SecurityCodeType = newIdentificationOfASecuritySecurityCodeType, //"v",
                SecurityCode = _securityCode//5668287
            };
            var newDealPrice = new CTM_TradeLevelBodyTradeLevelInformationDealPrice
            {
                CurrencyCode = _currencyCode, //USD
                Amount = _amount // Ammount
            };
            var newQuantityOfTheBlockTrade = new CTM_TradeLevelBodyTradeLevelInformationQuantityOfTheBlockTrade
            {
                QuantityTypeCode = _quantityTypeCode, //USD
                Amount = _qTypeCodeAmount // Ammount
            };
            var newTotalTradeAmount = new CTM_TradeLevelBodyTradeLevelInformationTotalTradeAmount
            {
                CurrencyCode = _currencyCodeTotalTradeAmount, //USD
                Amount = _currencyAmountTotalTradeAmount // Ammount
            };
            var newTimeZone = new CTM_TradeLevelBodyTradeLevelInformationTimeZone
            {
                TradeTimeQualifier = _timeZoneTradeTimeQualifier //LOCL

            };

            var newTradeLevelInformation = new CTM_TradeLevelBodyTradeLevelInformation
            {
                TypeOfTransactionIndicator = _typeOfTransactionIndicator, //  TRAD 
                BuySellIndicator = _buySellIndicator, // BUYI
                TypeOfFinancialInstrument = _typeOfFinancialInstrument, // COMM 
                TradeDateTime = _tradeDateTime, // 20150504094438 
                SettlementDate  = _settlementDate,  //> 20150505
                DealPrice = newDealPrice,
                QuantityOfTheBlockTrade = newQuantityOfTheBlockTrade,
                TotalTradeAmount = newTotalTradeAmount,
                TimeZone = newTimeZone

            };

            var newInstructingParty = new CTM_TradeLevelBodyInstructingParty
            {
                PartyRole = _instructingPartyRole, //"INST",
                PartyType = _instructingPartyType, //"BIC",
                PartyValue = _instructingPartyValue // "LIGHTSPD"
            };



            var newRequestBodyMsg = new CTM_TradeLevelBody
            {
                FunctionOfTheMessage = _functionOfTheMessage, //"NEWM"
                VersionOfTradeComponent = _versionOfTradeComponent, //"001",
                IdentificationOfASecurity = newSecurityCodeType,
                InstructingParty = newInstructingParty,
                ExecutingBroker = newExecutingBroker,
                TradeLevelReferences = newTradeLevelReferences,
                TradeLevelInformation = newTradeLevelInformation
            };

            newReuqestMsg.SubmitHeader = newSubmitHeaderMsg;
            newReuqestMsg.TradeLevelBody = newRequestBodyMsg;
            msg.TradeLevel = newReuqestMsg;

            return msg;
        }


        public CTM_Message SendMsg(DCIWebSession con)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("TradeLevel", GenerateTradeLevelRequest()), true, con, "TradeLevel");

        }

    }
}