using System;
using LSDS.CTM.CtmMessages;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class SendMultiTradeLevel : ICtmProcess
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
        private readonly string _multiTradeLevelResponseIndicator;
        private readonly string _byOrAgainstFlag;
        private readonly DateTime? _minLastUpdateDateTime;
       // private readonly string[] _matchStatus;

        public SendMultiTradeLevel(string protocolVersion, string sendersMessageReference, DateTime? dateTimeOfSentMessage, string orgPartyRole, 
            string orgPartyType, string orgPartyValue, string receiptPartyRole, string receiptPartyType, string receiptPartyValue, 
            string multiTradeLevelResponseIndicator, string byOrAgainstFlag, DateTime? minLastUpdateDateTime)
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
            _multiTradeLevelResponseIndicator = multiTradeLevelResponseIndicator;
            _byOrAgainstFlag = byOrAgainstFlag;
            _minLastUpdateDateTime = minLastUpdateDateTime;
           
        }

      
   public CTM_Message GenerateMultiTradeLevelRequest()
        {
            var msg = new CTM_Message();
            var newReuqestMsg = new CTM_MultiTradeLevelRequest();
          
            var newSubmitHeaderMsg = new CTM_Header
            {
                ProtocolVersion = _protocolVersion, //"CM01",
                SendersMessageReference = _sendersMessageReference, // "ars455",
                DateTimeOfSentMessage = 20150202112233// _dateTimeOfSentMessage // 20150202112233 // (DateTime) DateTime.Now.Ticks
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

            var newRequestBodyMsg = new CTM_MultiTradeLevelRequestBody
            {
                MultiTradeLevelResponseIndicator = _multiTradeLevelResponseIndicator, //"ADDD",
                ByOrAgainstFlag = _byOrAgainstFlag, //"A",
                MinLastUpdateDateTime = _minLastUpdateDateTime //20150202112233 //(DateTime) DateTime.Now.AddDays(-10).Ticks
            };
            
            
            newReuqestMsg.SubmitHeader = newSubmitHeaderMsg;
            newReuqestMsg.MultiTradeLevelRequestBody = newRequestBodyMsg;
            msg.MultiTradeLevelRequest = newReuqestMsg;

            return msg;
        }

      
        public CTM_Message SendMsg(DCIWebSession con)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("MultiTradeLevelRequest", GenerateMultiTradeLevelRequest()), false, con, "MultiTradeLevelResponse");
             
        }
        
    }
}
