using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using LSDS.CTM;
using Microsoft.Framework.Configuration;

namespace TestApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Start");
            var tdInfoMsg = new InfoRequest("CM01", "813919292", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "B", "TDET", "EXEC", "BIC", "AUTOBKMAXXX", "EXEC", "-893838900000098");
            var conn = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);

            var newMsg = conn.SendMsg(tdInfoMsg);
            //newMsg.CtmId = ReturnUniqInt();

            var dbAccess = new Model1("data source=lds-devel4;initial catalog=tdmse_devel_5;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
          
            dbAccess.MyMessage.AddOrUpdate(newMsg);
            dbAccess.SaveChanges();

            Console.WriteLine("End");
        }

        private int ReturnUniqInt()
        {
            var random = new Random();
            return random.Next();

        }

        void CreateTestMessage()
        {
            var msg = new CTM_Message();
            msg.TradeDetail.SubmitHeader.OriginatorOfMessage.PartyRole = "";
          //  msg.TradeDetail.SubmitHeader.ProtocolVersion

        }
    }
    
}
/*
TradeLevel newTradeLevelMessage;
IList<CTM_Message> resultList;
var tdInfoMsg = new InfoRequest("CM01", "813919292", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "B", "TDET", "EXEC", "BIC", "AUTOBKMAXXX", "EXEC", "-893838900000098");
var conn = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
//     var msg = conn.SendMsg(tdInfoMsg);
var msgInforResult = conn.SendMsg(tdInfoMsg);
//   var msg = conn.SendMsg(new TradeLevel("CM01", "vitas", 20150915083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "NEWM", 001, "INST",
//         "BIC", "LIGHTSPD", "EXEC", "BIC", "Vitas", -783838912000008, 5668287, "SEDO", "TRAD", "BUYI", "COMM", 20150915094438, 20150915, "USD", "1000,00",
//        "FAMT", "100,00", "USD", "1000000,00", "LOCL"));
//var submitATrade = new TradeLevel("CM01", "ars4411", 20150915083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "NEWM",001, "INST",
//    "BIC","LIGHTSPD", "EXEC", "BIC", "TECHSOLBXXX", -893838912000008, 5668287, "SEDO", "TRAD", "BUYI", "COMM", 20150915094438, 20150915, "USD", "1000,00",
//    "FAMT","100,00","USD", "1000000,00", "LOCL");

var xxx = new TradeLevel();
//  var conn = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
//var msgResult = conn.SendMsg(submitATrade);
    for (var i = 0; i < 10; i ++)
   {
       var msg = conn.SendMsg(new TradeLevel("CM01", "vitas", 20150915083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "NEWM", 001, "INST",
       "BIC", "LIGHTSPD", "EXEC", "BIC", "AUTOBKMAXXX", getMasterRef(), 5668287, "SEDO", "TRAD", "BUYI", "COMM", 20150915094438, 20150915, "USD", "1000,00",
       "FAMT", "100,00", "USD", "1000000,00", "LOCL"));
       if (msg.Valid != null)
       {
           Console.WriteLine("Valid new sell message");
       }
       else
       {
           Console.WriteLine("Message not valid");
       }
       //  Console.WriteLine(ms);
   }

               var tdLevelMsg = new MultiTradeLevel("CM01", "ars441", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "ADDD","A", 20150901175240);
               var conn = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true, tdLevelMsg);
               var msgResult = tdLevelMsg.SendMsg(conn.GetSession());
               if (msgResult.Invalid != null)
               {
                   Console.WriteLine("Messege Invalid");
               }
               else if(msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount == 0)
               {
                   Console.WriteLine("No multitrade messages available" + msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount);
               }
               else 
               {
                   Console.WriteLine(msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount + " messages available.");
                   Console.WriteLine("Getting information messages");
                   // Get Information Message
                   //  Console.WriteLine("No multitrade messages available" + msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount);
                   var tdInfoMsg = new InfoRequest("CM01", "ars441", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE","A","TLEV","EXEC","BIC","OGMATCH1","EXEC", "BD813633972");
                   var connInfor= new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true, tdInfoMsg);
                   var msgInforResult = tdInfoMsg.SendMsg(connInfor.GetSession());

                  // C
               }
               */
