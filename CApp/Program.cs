using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSDS.CTM;
using LSDS.CTM.CtmMessages;

namespace CApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var tdLevelMsg = new SendMultiTradeLevel("CM01", "ars441", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "ADDD", "A", 20150901175240);
            var conn2 = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
            var msgResult = conn2.SendMsg(tdLevelMsg);//.SendMsg(conn.GetSession());
            if (msgResult.Invalid != null)
            {
                Console.WriteLine("Messege Invalid");
            }
            else if (msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount == 0)
            {
                Console.WriteLine("No multitrade messages available" + msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount);
            }
            else
            {
                Console.WriteLine(msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount + " messages available.");
                Console.WriteLine("Getting information messages");
                // Get Information Message
                //  Console.WriteLine("No multitrade messages available" + msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount);
                var tdInfoMsg2 = new SendInfoRequest("CM01", "ars441", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "A", "TLEV", "EXEC", "BIC", "OGMATCH1", "EXEC", "BD813633972");
                var connInfor = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
                var msgInforResult = connInfor.SendMsg(tdInfoMsg2);//.SendMsg(connInfor.GetSession());

                // C
            }

            var tdInfoMsg = new SendInfoRequest("CM01", "813919292", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "B", "TDET", "EXEC", "BIC", "AUTOBKMAXXX", "EXEC", "-893838900000098","g");
            var conn1 = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
            var msg3 = conn1.SendMsg(tdInfoMsg);



            //  var tdInfoMsg = new InfoRequest("CM01", "813919292", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "B", "TDET", "EXEC", "BIC", "AUTOBKMAXXX", "EXEC", "-893838900000098");
            var conn = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
            var msg = new SendTradeDetail(GenerateTradeDetails());









            var result = conn.SendMsg(msg);
            //var newMsg = conn.SendMsg(tdInfoMsg);
            //newMsg.CtmId = ReturnUniqInt();

            //  var dbAccess = new CTMDBContext("data source=lds-devel4;initial catalog=tdmse_devel_5;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

            // dbAccess.MyMessage.AddOrUpdate(msg);
            // dbAccess.SaveChanges();

            Console.WriteLine("End");
        }
        private static CTM_Message GenerateTradeDetails()
        {
            var msg = new CTM_Message();
            var newReuqestMsg = new CTM_TradeDetail();

            var newSubmitHeaderMsg = new CTM_Header
            {
                ProtocolVersion = "CM01",
                SendersMessageReference = "ars425",
                DateTimeOfSentMessage = 20150202112233 // (ulong) DateTime.Now.Ticks
            };
            var originatorOfMeessage = new CTM_OriginatorOfMessage
            {
                PartyRole = "MEOR",
                PartyType = "BIC",
                PartyValue = "LIGHTSPD"
            };

            var recipientOfMessage = new CTM_RecipientOfMessage
            {
                PartyRole = "MEOR",
                PartyType = "BIC",
                PartyValue = "LIGHTSPD"
            };

            newSubmitHeaderMsg.OriginatorOfMessage = originatorOfMeessage;
            newSubmitHeaderMsg.RecipientOfMessage = recipientOfMessage;



            var newExecutingBroker = new CTM_TradeDetailBodyExecutingBroker
            {
                PartyRole = "EXEC",
                PartyType = "BIC",
                PartyValue = "TECHSOLBXXX"

            };

            var newTradeLevelReferences = new CTM_TradeDetailBodyTradeLevelReferences
            {

                MasterReference = "-793838912000001"
            };

            var newTradeDetailReferences = new CTM_TradeDetailBodyTradeDetailReferences
            {
                ClientAllocationReference = "-793838912000001"
            };

            var newIdentificationOfASecuritySecurityCodeType = new CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType
            {
                NumberingAgencyCode = "SEDO"//_numberingAgencyCode,
                //"SEDO"

            };
            var newSecurityCodeType = new CTM_TradeDetailBodyIdentificationOfASecurity
            {
                SecurityCodeType = newIdentificationOfASecuritySecurityCodeType, //"v",
                SecurityCode = "_securityCode",
                DescriptionOfTheSecurity = "_descriptionOfTheSecurity"
                //SecurityCode = _securityCode//5668287
            };
            var newDealPrice = new CTM_TradeDetailBodyTradeLevelInformationDealPrice
            {
                CurrencyCode = "USD", //USD
                Amount = 33.33 // Ammount
            };
            var newQuantityOfTheBlockTrade = new CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade
            {
                QuantityTypeCode = "EU", //USD
                Amount = 2.2 // Ammount
            };
            var newTotalTradeAmount = new CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount
            {
                CurrencyCode = "USD", //USD
                Amount = 123 // Ammount
            };
            var newTimeZone = new CTM_TradeDetailBodyTradeLevelInformationTimeZone

            {
                TradeTimeQualifier = "LOCL" //LOCL

            };

            var newTradeDetailInformation = new CTM_TradeDetailBodyTradeLevelInformation
            {
                TypeOfTransactionIndicator = "TRAD", //  TRAD 
                BuySellIndicator = "BUYI", // BUYI
                TypeOfFinancialInstrument = "COMM", // COMM 
                TradeDateTime = 20150504094438, // 20150504094438 
                SettlementDate = 20150505//,  //> 20150505
                                         //DealPrice = newDealPrice,
                                         //QuantityOfTheBlockTrade = newQuantityOfTheBlockTrade,
                                         //TotalTradeAmount = newTotalTradeAmount,
                                         // TimeZone = newTimeZone

            };

            var newInstructingParty = new CTM_TradeDetailBodyInstructingParty
            {
                PartyRole = "INST", //"INST",
                PartyType = "BIC", //"BIC",
                PartyValue = "LIGHTSPD" // "LIGHTSPD"
            };
            var newCpTyTIdent = new CTM_TradeDetailBodyCPTYTradeLevelIdentifiers
            {
               CTMTradeSideId = "CtmTradeSideId",
               MasterReference = "-793838912000001",
            };


            var newRequestBodyMsg = new CTM_TradeDetailBody
            {
                TDUpdateGuard = "TDUpdateGuard",
                FunctionOfTheMessage = "NEWM", //"NEWM"
                VersionOfTradeComponent = 001, //"001",
                TradeLevelReferences = newTradeLevelReferences,
                TradeDetailReferences = newTradeDetailReferences,
                L2MatchingProfileName = "PName",
                InstructingParty = newInstructingParty,
                TradeLevelExpected = "N",
                CPTYTradeLevelIdentifiers = newCpTyTIdent,
                IdentificationOfASecurity = newSecurityCodeType,
                ExecutingBroker = newExecutingBroker
                
                //  TradeDetailInformation = newTradeDetailInformation
            };

            newReuqestMsg.SubmitHeader = newSubmitHeaderMsg;
            newReuqestMsg.TradeDetailBody = newRequestBodyMsg;
            msg.TradeDetail = newReuqestMsg;
            return msg;
        }

    }
}
