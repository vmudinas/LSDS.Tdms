using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using LSDS.CTM;
using LSDS.CTM.CtmMessages;
using Microsoft.Framework.Configuration;

namespace TestApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Start");
            //  var tdInfoMsg = new InfoRequest("CM01", "813919292", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "B", "TDET", "EXEC", "BIC", "AUTOBKMAXXX", "EXEC", "-893838900000098");
            var conn = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
          
            var msg = new CTM_Message
            {
                    TradeDetail =
                    {
                                SubmitHeader =
                                {
                                    DateTimeOfSentMessage = 1111,
                                    OriginatorOfMessage =
                                    {
                                        PartyRole = "sss",
                                        PartyValue = "partyvlar",
                                        PartyType = "pType"
                                    },
                                    ProtocolVersion = "sss",
                                    RecipientOfMessage =
                                    {
                                        PartyRole = "prole",
                                        PartyValue = "partyvlar",
                                        PartyType = "pType"
                                    },
                                    SendersMessageReference = "serverRef",
                                    UserId = "testuser"
                                },
                                LastUpdated = DateTime.Now,
                                TradeDetailBody = {

                                    AdditionalDisclosures =
                                    {
                                        AssetBackedSecuritiesDisclosure = "fdsafds",
                                         AssetBacked = "asx",
                                        FINRAMember = "asd",
                                        MarkUpMarkDown =
                                        {
                                           Amount = 222,
                                           CurrencyCode = "CurrencyCode",
                                           Sign = "-"
                                        },
                                        OddLotDifferential = "oddLot",
                                        OddLotDisclosure = "OddLotDisclosure",
                                        OrderFlowDisclosure = "OrderFlowDisclosure",
                                        OtherRemuneration = "OtherRemuneration",
                                        OtherRemunerationDisclosure = "OtherRemunerationDisclosure",
                                         ReportedPrice =
                                        {
                                           Amount = 222,
                                           CurrencyCode = "CurrencyCode"
                                        },
                                        RedemptionDisclosure = "RedemptionDisclosure",
                                        MarketMaker = "marketMaker",
                                        SIPCMember = "SIPMember"
                                    },
                                    AdditionalData =
                                    {
                                        AdditionalText = "AddTextData",
                                        DataXML = "dxml"
                                    },
                                    AdditionalSecurityIdentifiers =
                                    {
                                       SecurityCode = "SecCode",
                                       SecurityCodeType =
                                    {
                                        CountryCode = "SecCpdeType",
                                        NumberingAgencyCode = "NumberingAgencyCode"
                                    }
                                    },
                                    ConfirmDisclosureData =
                                    {
                                        ConfirmDisclosureBypassIndicator = "ConDBind",
                                        UserDefinedDisclosureCode = "uDDCode"
                                    },
                                    DetailLevelPartyCapacityIndicator = "DetailLEvel",
                                    EBSettlement =
                                    {
                                        AccountID = "AccountID",
                                        AccountReference = "accRef"
                                    },
                                    ExecutingBroker =
                                    {
                                        PartyRole = "ExbroVAl",
                                        PartyType = "exPRle",
                                        PartyValue = "pvalue"
                                    },

                                        FunctionOfTheMessage = "funcMsg",
                                            IPSettlement =
                                            {
                                                AccountID = 99

                                            },
                                              IdentificationOfASecurity =
                                            {
                                                DescriptionOfTheSecurity = "descSec",
                                                SecurityCode = "SecCode",
                                                SecurityCodeType =
                                                {
                                                    CountryCode = "CCpde",
                                                    NumberingAgencyCode = "nAgencyC"
                                                }
                                            },
                                            InstructingParty =
                                            {
                                                PartyRole = "PartyRole",
                                                PartyType = "PartyType",
                                                PartyValue ="PValue"
                                            },

                                        L2MatchingProfileName = "L2MName",

                                        PartySettlement =
                                        {
                                            AlertCountryCode = "AlCode",
                                            AlertMethodType = "AMethodT",
                                            AlertSecurityType ="SecType",
                                            AlertSettlementModelName = "ASMName",
                                            FXDealCurrencyCode = "CCode",
                                            PartyFundName = "FundName",
                                            PartyIdentifier = "PIdent",
                                            PlaceOfSafekeeping =
                                            {
                                                PlaceOfSafekeepingPlace = "PSP",
                                                PlaceOfSafekeepingType = "Type",
                                               PlaceOfSafekeepingValue = "value"
                                            },
                                            SNReleaseOverride = "SNReleaseOve",
                                            SettlementInstructionProcessingNarrative = "lll",
                                            SettlementInstructionsSourceIndicator = "SInd",
                                             SettlementInstructions =
                                            {

                                                ID1 = "",
                                                ID2= "",
                                                ID3="dd",
                                                ID4="dd",
                                                ID5="dd",
                                                ParticipantName1="dd",
                                                ParticipantName2="dd",
                                                AccountRef1="dd",
                                                AccountRef2="dd",
                                                SecurityAccount="dd",
                                                SubAccountRef1="dd",
                                                SubAccountRef2="dd",
                                                SubAccountNo="dd",
                                                PaymentCurrency="dd",
                                                CashAccountNo="dd",
                                                AlternateCurrency="dd",
                                                AlternateCashAccountNo="dd",
                                                CustodianBIC="dd",
                                                CustodianName1="dd",
                                                CustodianName2="dd",
                                                CustodianAddress1="dd",
                                                CustodianAddress2="dd",
                                                CustodianCity="dd",
                                                CustodianLocality="dd",
                                                CustodianCountry="dd",
                                                CustodianPostCode="dd",
                                                SubAgentBIC="dd",
                                                SubAgentName1="dd",
                                                SubAgentName2="dd",
                                                SubAgentAddress1="dd",
                                                SubAgentAddress2="dd",
                                                SubAgentCity="dd",
                                                SubAgentLocality="dd",
                                                SubAgentCountry="dd",
                                                SubAgentPostCode="dd",
                                                CorrespBIC="dd",
                                                CorrespName1="dd",
                                                CorrespName2="dd",
                                                CorrespAddress1="dd",
                                                CorrespAddress2="dd",
                                                CorrespCity="dd",
                                                CorrespLocality="dd",
                                                CorrespCountry="dd",
                                                CorrespPostCode="dd",
                                                CorrespCashAccountNo="dd",
                                                CorrespSecAccountNo="dd",
                                                Relationship="dd",
                                                RegName1="dd",
                                                PSET="dd",
                                                RegAddress1="dd",
                                                RegAddress2="dd",
                                                RegCity="dd",
                                                RegLocality="dd",
                                                RegCountry="dd",
                                                RegPostCode="dd",
                                                SettlementContact="dd",
                                                SettlementPhone="dd",
                                                SettlementFax="dd",
                                                SettlementTelex="dd",
                                                SpecialInstr1="dd",
                                                SpecialInstr2="dd",
                                                AffirmingPartyIndicator="dd",
                                                InstitutionBIC="dd",
                                                InstitutionContact="dd",
                                                InstitutionPhone="dd",
                                                IP1ID="dd",
                                                IP1BIC="dd",
                                                IP1AccountNo="dd",
                                                IP1Name="dd",
                                                IP1Contact="dd",
                                                IP1Phone="dd",
                                                IP1SpecialInstr1="dd",
                                                IP1SpecialInstr2="dd",
                                                IP2ID="dd",
                                                IP2BIC="dd",
                                                IP2AccountNo="dd",
                                                IP2Name="dd",
                                                IP2Contact="dd",
                                                IP2Phone="dd",
                                                IP2SpecialInstr1="dd",
                                                IP2SpecialInstr2="dd",
                                                IP3ID="dd",
                                                IP3BIC="dd",
                                                IP3AccountNo="dd",
                                                IP3Name="dd",
                                                IP3Contact="dd",
                                                IP3Phone="dd",
                                                IP3SpecialInstr1="dd",
                                                IP3SpecialInstr2="dd",
                                                AgentID="dd",
                                                INSTorBrokerID="dd",
                                                ReceiverAgentBIC="dd",
                                                ReceiverAgentName="dd",
                                                LEI="dd",
                                                AccountLEI="dd",
                                                LargeTraderID="dd",

                                            }
                                    }
                     }
                }
            };







             var result = conn.SendMsg(msg);
             //var newMsg = conn.SendMsg(tdInfoMsg);
            //newMsg.CtmId = ReturnUniqInt();

          //  var dbAccess = new CTMDBContext("data source=lds-devel4;initial catalog=tdmse_devel_5;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

           // dbAccess.MyMessage.AddOrUpdate(msg);
           // dbAccess.SaveChanges();

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
