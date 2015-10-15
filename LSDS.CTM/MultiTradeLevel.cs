using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSDS.CTM;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class MultiTradeLevel : ICtmProcess
    {

        private readonly string _protocolVersion;
        private readonly string _sendersMessageReference;
        private readonly ulong _dateTimeOfSentMessage;
        private readonly string _orgPartyRole;
        private readonly string _orgPartyType;
        private readonly string _orgPartyValue;
        private readonly string _receiptPartyRole;
        private readonly string _receiptPartyType;
        private readonly string _receiptPartyValue;
        private readonly string _multiTradeLevelResponseIndicator;
        private readonly string _byOrAgainstFlag;
        private readonly ulong _minLastUpdateDateTime;
        private readonly string[] _matchStatus;

        public MultiTradeLevel(string protocolVersion, string sendersMessageReference, ulong dateTimeOfSentMessage, string orgPartyRole, 
            string orgPartyType, string orgPartyValue, string receiptPartyRole, string receiptPartyType, string receiptPartyValue, 
            string multiTradeLevelResponseIndicator, string byOrAgainstFlag, ulong minLastUpdateDateTime)
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
            this._multiTradeLevelResponseIndicator = multiTradeLevelResponseIndicator;
            this._byOrAgainstFlag = byOrAgainstFlag;
            this._minLastUpdateDateTime = minLastUpdateDateTime;
           
        }

      
   public CTM_Message GenerateMultiTradeLevelRequest()
        {
            var msg = new CTM_Message();
            var newReuqestMsg = new CTM_MessageMultiTradeLevelRequest();
          
            var newSubmitHeaderMsg = new CTM_MessageMultiTradeLevelRequestSubmitHeader
            {
                ProtocolVersion = _protocolVersion, //"CM01",
                SendersMessageReference = _sendersMessageReference, // "ars455",
                DateTimeOfSentMessage = _dateTimeOfSentMessage // 20150202112233 // (ulong) DateTime.Now.Ticks
            };
            var originatorOfMeessage = new CTM_MessageMultiTradeLevelRequestSubmitHeaderOriginatorOfMessage
            {
                PartyRole = _orgPartyRole, //"MEOR",
                PartyType = _orgPartyType, //"BIC",
                PartyValue = _orgPartyValue // "LIGHTSPD"
            };

            var recipientOfMessage = new CTM_MessageMultiTradeLevelRequestSubmitHeaderRecipientOfMessage
            {
                PartyRole = _receiptPartyRole, //"MEOR",
                PartyType = _receiptPartyType, //"BIC",
                PartyValue = _receiptPartyValue // "LIGHTSPD"
            };

            newSubmitHeaderMsg.OriginatorOfMessage = originatorOfMeessage;
            newSubmitHeaderMsg.RecipientOfMessage = recipientOfMessage;

            var newRequestBodyMsg = new CTM_MessageMultiTradeLevelRequestMultiTradeLevelRequestBody
            {
                MultiTradeLevelResponseIndicator = _multiTradeLevelResponseIndicator, //"ADDD",
                ByOrAgainstFlag = _byOrAgainstFlag, //"A",
                MinLastUpdateDateTime = _minLastUpdateDateTime //20150202112233 //(ulong) DateTime.Now.AddDays(-10).Ticks
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
