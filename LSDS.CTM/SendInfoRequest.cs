﻿using System;
using LSDS.CTM.CtmMessages;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class SendInfoRequest : ICtmProcess
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
        private readonly string _viewRequestedIndicator;
        private readonly string _executingBrokerPartyRole;
        private readonly string _executingBrokerPartyType;
        private readonly string _executingBrokerPartyValue;
        private readonly string _accessPathIdOwner;
        private readonly string _accessPathTradeLevelIdentifiersMasterReference;
        private readonly string _queryType;
        private readonly string _cTMTradeDetailID;

        public SendInfoRequest(string protocolVersion, string sendersMessageReference, DateTime? dateTimeOfSentMessage, string orgPartyRole,
            string orgPartyType, string orgPartyValue, string receiptPartyRole, string receiptPartyType, string receiptPartyValue,
            string viewRequestedIndicator, string queryType,string executingBrokerPartyRole, string executingBrokerPartyType, string executingBrokerPartyValue, 
            string accessPathIdOwner, string accessPathTradeLevelIdentifiersMasterReference, string cTMTradeDetailID = "")
        {
            this._protocolVersion = protocolVersion;
            this._sendersMessageReference = sendersMessageReference;
            this._dateTimeOfSentMessage = dateTimeOfSentMessage;
            this._orgPartyRole = orgPartyRole;
            this._orgPartyType = orgPartyType;
            this._orgPartyValue = orgPartyValue;
            this._receiptPartyRole = receiptPartyRole;
            this._receiptPartyType = receiptPartyType;
            this._receiptPartyValue = receiptPartyValue;
            this._viewRequestedIndicator = viewRequestedIndicator;
            this._queryType = queryType;
            this._executingBrokerPartyRole = executingBrokerPartyRole;
            this._executingBrokerPartyType = executingBrokerPartyType;
            this._executingBrokerPartyValue = executingBrokerPartyValue;
            this._accessPathIdOwner = accessPathIdOwner;
            this._accessPathTradeLevelIdentifiersMasterReference = accessPathTradeLevelIdentifiersMasterReference;
            this._cTMTradeDetailID = cTMTradeDetailID;
        }
     

        public CTM_Message GenerateInfoRequest()
        {
            var msg = new CTM_Message();
            var newReuqestMsg = new CTM_InfoRequest();

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

            var newRequestBodyMsg = new CTM_InfoRequestBody
            {
                ViewRequestedIndicator = _viewRequestedIndicator, 
                QueryType = _queryType 
             
            };
            var newExecutingBroker = new CTM_InfoRequestBodyExecutingBroker
            {
                PartyRole = _executingBrokerPartyRole, 
                PartyType = _executingBrokerPartyType,
                PartyValue = _executingBrokerPartyValue

            };
            var newMasterReference = new CTM_InfoRequestBodyAccessPathTradeLevelIdentifiers
            {
                MasterReference = _accessPathTradeLevelIdentifiersMasterReference

            };
            var newAccessPath = new CTM_InfoRequestBodyAccessPath
            {
                IDOwner = _accessPathIdOwner,
                TradeLevelIdentifiers = newMasterReference

            };
            //if (!string.IsNullOrEmpty(_cTMTradeDetailID))
            //{
            //    var new
            //}
            //     _accessPathIdOwner
            //  _accessPathTradeLevelIdentifiersMasterReference


            newReuqestMsg.SubmitHeader = newSubmitHeaderMsg;
            newReuqestMsg.InfoRequestBody = newRequestBodyMsg;
            newReuqestMsg.InfoRequestBody.ExecutingBroker = newExecutingBroker;
            newReuqestMsg.InfoRequestBody.AccessPath = newAccessPath;
            msg.InfoRequest = newReuqestMsg;

            return msg;
        }


        public CTM_Message SendMsg(DCIWebSession con)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("InfoRequest", GenerateInfoRequest()), false, con, "InfoResponse");

        }
    }
}
