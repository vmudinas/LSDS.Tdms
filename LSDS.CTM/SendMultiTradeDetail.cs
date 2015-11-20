using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSDS.CTM;
using LSDS.CTM.CtmMessages;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class SendMultiTradeDetail : ICtmProcess
    {
        public CTM_Message SendMultiTradeDetailRequest(string protocolVersion, string sendersMessageReference, DateTime? dateTimeOfSentMessage, string orgPartyRole, string orgPartyType, string orgPartyValue,
            string receiptPartyRole, string receiptPartyType, string receiptPartyValue,
            string multiTradeDetailResponseRequested, string byOrAgainstFlag, DateTime? minLastUpdateDateTime, string[] matchStatus)
        {
            var msg = new CTM_Message();
            var newReuqestMsg = new CTM_MultiTradeDetailRequest();
            var newSubmitHeaderMsg = new CTM_Header
            {
                ProtocolVersion = protocolVersion, //"CM01",
                SendersMessageReference = sendersMessageReference, // "ars455",
                DateTimeOfSentMessage = 20150202112233//dateTimeOfSentMessage // 20150202112233 // (DateTime) DateTime.Now.Ticks
            };
            var originatorOfMeessage = new CTM_OriginatorOfMessage
            {
                PartyRole = orgPartyRole, //"MEOR",
                PartyType = orgPartyType, //"BIC",
                PartyValue = orgPartyValue // "LIGHTSPD"
            };

            var receiptOfMessage = new CTM_RecipientOfMessage
            { 
                PartyRole = receiptPartyRole, //"MERE",
                PartyType = receiptPartyType, //"TFID",
                PartyValue = receiptPartyValue //"CTMSERVICE"
            };
            newSubmitHeaderMsg.OriginatorOfMessage = originatorOfMeessage;
            newSubmitHeaderMsg.RecipientOfMessage = receiptOfMessage;

            var newRequestBodyMsg = new CTM_MultiTradeDetailRequestBody
            {
                MultiTradeDetailResponseRequested = multiTradeDetailResponseRequested, //"ADDD",
                ByOrAgainstFlag = byOrAgainstFlag, //"A",
                MinLastUpdateDateTime = minLastUpdateDateTime //20150202112233 //(DateTime) DateTime.Now.AddDays(-10).Ticks
            };

            var newStatusQuery =
                new CTM_MultiTradeDetailRequestBodyMultiTradeDetailStatusQuery
                {
                    TDMatchStatusValues = matchStatus
                };

            // var newMatch  = new string[3];
            // newMatch[0] = "NMAT";
            //newMatch[1] = "CAND";

            // newRequestBodyMsg.MultiTradeDetailStatusQuery = newStatusQuery;
            newReuqestMsg.SubmitHeader = newSubmitHeaderMsg;
            newReuqestMsg.MultiTradeDetailRequestBody = newRequestBodyMsg;
            msg.MultiTradeDetailRequest = newReuqestMsg;

            //var newWebSession = new CTM.CtmMessages("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "cmacl33", "speed$deeps323","","","","",30,10,true);
            //newWebSession.OpenWebSession();

           // var strMsg = Seralizer.SerializeObject<CTM_Message>(msg).Replace("<CTM_Message>", "<!DOCTYPE CTM_Message PUBLIC \"-//TFN//DTD MultiTradeDetailRequest 1.3//EN\" \"MultiTradeDetailRequest.dtd\"><CTM_Message>").Replace("\r\n","");
         
            return msg;
        }

       

        public CTM_Message SendMsg(DCIWebSession conn)
        {
            throw new NotImplementedException();
        }
    }
}
