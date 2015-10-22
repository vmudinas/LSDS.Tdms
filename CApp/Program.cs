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

            //var tdLevelMsg = new SendMultiTradeLevel("CM01", "ars441", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "ADDD", "A", 20150901175240);
            //var conn2 = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
            //var msgResult = conn2.SendMsg(tdLevelMsg);//.SendMsg(conn.GetSession());
            //if (msgResult.Invalid != null)
            //{
            //    Console.WriteLine("Messege Invalid");
            //}
            //else if (msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount == 0)
            //{
            //    Console.WriteLine("No multitrade messages available" + msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount);
            //}
            //else
            //{
            //    Console.WriteLine(msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount + " messages available.");
            //    Console.WriteLine("Getting information messages");
            //    // Get Information Message
            //    //  Console.WriteLine("No multitrade messages available" + msgResult.MultiTradeLevelResponse.MultiTradeLevelResponseBody.RecordsReturnedCount);
            //    var tdInfoMsg2 = new SendInfoRequest("CM01", "ars441", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "A", "TLEV", "EXEC", "BIC", "OGMATCH1", "EXEC", "BD813633972");
            //    var connInfor = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
            //    var msgInforResult = connInfor.SendMsg(tdInfoMsg2);//.SendMsg(connInfor.GetSession());

            //    // C
            //}

            //var tdInfoMsg = new SendInfoRequest("CM01", "813919292", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "B", "TDET", "EXEC", "BIC", "AUTOBKMAXXX", "EXEC", "-893838900000098","g");
            //var conn1 = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);
            //var msg3 = conn1.SendMsg(tdInfoMsg);


            //CTM_TradeDetailBody b = new CTM_TradeDetailBody();
            
            ////  var tdInfoMsg = new InfoRequest("CM01", "813919292", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "B", "TDET", "EXEC", "BIC", "AUTOBKMAXXX", "EXEC", "-893838900000098");
            var conn = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);

            var stringMessage = "<CTM_Message><TradeDetail>" +
                                "<SubmitHeader><ProtocolVersion>CM01</ProtocolVersion>" +
                                "<OriginatorOfMessage><PartyRole>MEOR</PartyRole>" +
                                "<PartyType>BIC</PartyType>" +
                                "<PartyValue>LIGHTSPD</PartyValue></OriginatorOfMessage>" +
                                "<RecipientOfMessage><PartyRole>MERE</PartyRole>" +
                                "<PartyType>TFID</PartyType>" +
                                "<PartyValue>CTMSERVICE</PartyValue></RecipientOfMessage>" +
                                "<SendersMessageReference>RLAMD0714144852</SendersMessageReference></SubmitHeader>" +
                                "<TradeDetailBody>" +
                                "<FunctionOfTheMessage>NEWM</FunctionOfTheMessage>" +
                                "<VersionOfTradeComponent>001</VersionOfTradeComponent>" +
                                "<InstructingParty><PartyRole>INST</PartyRole><PartyType>BIC</PartyType>" +
                                "<PartyValue>LIGHTSPD</PartyValue></InstructingParty>" +
                                "<ExecutingBroker><PartyRole>EXEC</PartyRole>" +
                                "<PartyType>OG</PartyType><PartyValue>CTMTST01</PartyValue>" +
                                "</ExecutingBroker><TradeLevelReferences>" +
                                "<MasterReference>20150917224111</MasterReference>" +
                                "</TradeLevelReferences>" +
                                "<TradeDetailReferences>" +
                                "<ClientAllocationReference>RLAMD0714144811</ClientAllocationReference>" +
                                "</TradeDetailReferences>" +
                                "<TradeLevelExpected>N</TradeLevelExpected>" +
                                "<IdentificationOfASecurity><SecurityCodeType>" +
                                "<NumberingAgencyCode>SEDO</NumberingAgencyCode>" +
                                "</SecurityCodeType><SecurityCode>TWELLS</SecurityCode>" +
                                "<DescriptionOfTheSecurity>TWELLS" +
                                "</DescriptionOfTheSecurity>" +
                                "</IdentificationOfASecurity>" +
                                "<TradeLevelInformation>" +
                                "<TypeOfTransactionIndicator>TRAD</TypeOfTransactionIndicator>" +
                                "<BuySellIndicator>BUYI</BuySellIndicator>" +
                                "<TypeOfFinancialInstrument>COMM" +
                                "</TypeOfFinancialInstrument><DealPrice>" +
                                "<CurrencyCode>GBP</CurrencyCode><Amount>12,</Amount>" +
                                "</DealPrice><QuantityOfTheBlockTrade>" +
                                "<QuantityTypeCode>UNIT</QuantityTypeCode>" +
                                "<Amount>100,</Amount></QuantityOfTheBlockTrade>" +
                                "<TotalTradeAmount><CurrencyCode>GBP</CurrencyCode>" +
                                "<Amount>1200,00</Amount></TotalTradeAmount>" +
                                "<TradeDateTime>20151021144825</TradeDateTime>" +
                                "<TimeZone><TradeTimeQualifier>LOCL</TradeTimeQualifier>" +
                                "</TimeZone><SettlementDate>20151021</SettlementDate>" +
                                "</TradeLevelInformation><TradeDetailData>" +
                                "<TradeAmount><CurrencyCode>GBP</CurrencyCode>" +
                                "<Amount>1200,00</Amount></TradeAmount>" +
                                "<QuantityAllocated><QuantityTypeCode>UNIT</QuantityTypeCode>" +
                                "<Amount>100,</Amount></QuantityAllocated>" +
                                "<NetCashAmount><CurrencyCode>GBP</CurrencyCode>" +
                                "<Amount>1200,00</Amount></NetCashAmount><CommFeesTaxes>" +
                                "<Commissions><CommissionSharingBasisIndicator>FLAT</CommissionSharingBasisIndicator>" +
                                "<CommissionType>TCOM</CommissionType><Commission>" +
                                "<Sign>+</Sign><CurrencyCode>GBP</CurrencyCode>" +
                                "<Amount>0,00</Amount></Commission></Commissions>" +
                                "<ChargesOrTaxes><ChargeTaxType>LOCL</ChargeTaxType>" +
                                "<ChargeAmount><Sign>+</Sign><CurrencyCode>GBP</CurrencyCode>" +
                                "<Amount>0,00</Amount></ChargeAmount></ChargesOrTaxes>" +
                                "<ChargesOrTaxes><ChargeTaxType>CHAR</ChargeTaxType>" +
                                "<ChargeAmount><Sign>+</Sign><CurrencyCode>GBP</CurrencyCode><Amount>0,00</Amount>" +
                                "</ChargeAmount></ChargesOrTaxes><ChargesOrTaxes>" +
                                "<ChargeTaxType>OTHR</ChargeTaxType><ChargeAmount>" +
                                "<Sign>+</Sign><CurrencyCode>GBP</CurrencyCode>" +
                                "<Amount>0,00</Amount></ChargeAmount></ChargesOrTaxes>" +
                                "</CommFeesTaxes></TradeDetailData>" +
                                "<IPSettlement>" +
                                "<AccountID>0108</AccountID>" +
                                "</IPSettlement>" +
                                //"<PartySettlement>" +
                                //"<SettlementInstructionsSourceIndicator>ALRT</SettlementInstructionsSourceIndicator>" +
                                //    "<AlertCountryCode>GBR</AlertCountryCode>" +
                                //    "<AlertMethodType>CREST</AlertMethodType>" +
                                //    "<AlertSecurityType>EQU</AlertSecurityType>" +
                                //"</PartySettlement>" +
                                "</TradeDetailBody></TradeDetail>" +
                                "</CTM_Message>";


         


         

           
            //[Key]
            //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
           
            var msg = new SendTradeDetail(tdMessage);
            // var msgx = msg.SendMsgString(conn.GetSession(), stringMessage);
         //   var message = msg.SendMsg(conn.GetSession());

             var dbAccess = new CTMDBContext("data source=lds-devel4;initial catalog=tdmse_devel_5;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

             dbAccess.MyMessage.Add(tdMessage);
             dbAccess.SaveChanges();






            //var result = conn.SendMsg(msg);
            //var newMsg = conn.SendMsg(tdInfoMsg);
            //newMsg.CtmId = ReturnUniqInt();

            //  var dbAccess = new CTMDBContext("data source=lds-devel4;initial catalog=tdmse_devel_5;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

            // dbAccess.MyMessage.AddOrUpdate(msg);
            // dbAccess.SaveChanges();

            Console.WriteLine("End");
        }
        private static CTM_Message GenerateTradeDetails()
        {
            //var msg = new CTM_Message();
            //var newReuqestMsg = new CTM_TradeDetail();

            //var newSubmitHeaderMsg = new CTM_Header
            //{
            //    ProtocolVersion = "CM01",
            //    SendersMessageReference = "ars425",
            //    DateTimeOfSentMessage = 20150202112233 // (ulong) DateTime.Now.Ticks
            //};
            //var originatorOfMeessage = new CTM_OriginatorOfMessage
            //{
            //    PartyRole = "MEOR",
            //    PartyType = "BIC",
            //    PartyValue = "LIGHTSPD"
            //};

            //var recipientOfMessage = new CTM_RecipientOfMessage
            //{
            //    PartyRole = "MEOR",
            //    PartyType = "BIC",
            //    PartyValue = "LIGHTSPD"
            //};

            //newSubmitHeaderMsg.OriginatorOfMessage = originatorOfMeessage;
            //newSubmitHeaderMsg.RecipientOfMessage = recipientOfMessage;



            //var newExecutingBroker = new CTM_TradeDetailBodyExecutingBroker
            //{
            //    PartyRole = "EXEC",
            //    PartyType = "BIC",
            //    PartyValue = "TECHSOLBXXX"

            //};

            //var newTradeLevelReferences = new CTM_TradeDetailBodyTradeLevelReferences
            //{

            //    MasterReference = "-793838912000001"
            //};

            //var newTradeDetailReferences = new CTM_TradeDetailBodyTradeDetailReferences
            //{
            //    ClientAllocationReference = "-793838912000001"
            //};

            //var newIdentificationOfASecuritySecurityCodeType = new CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType
            //{
            //    NumberingAgencyCode = "SEDO"//_numberingAgencyCode,
            //    //"SEDO"

            //};
            //var newSecurityCodeType = new CTM_TradeDetailBodyIdentificationOfASecurity
            //{
            //    SecurityCodeType = newIdentificationOfASecuritySecurityCodeType, //"v",
            //    SecurityCode = "_securityCode",
            //    DescriptionOfTheSecurity = "_descriptionOfTheSecurity"
            //    //SecurityCode = _securityCode//5668287
            //};
            //var newDealPrice = new CTM_TradeDetailBodyTradeLevelInformationDealPrice
            //{
            //    CurrencyCode = "USD", //USD
            //    Amount = "33,33" // Ammount
            //};
            //var newQuantityOfTheBlockTrade = new CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade
            //{
            //    QuantityTypeCode = "EU", //USD
            //    Amount = "2,2" // Ammount
            //};
            //var newTotalTradeAmount = new CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount
            //{
            //    CurrencyCode = "USD", //USD
            //    Amount = "123," // Ammount
            //};
            //var newTimeZone = new CTM_TradeDetailBodyTradeLevelInformationTimeZone

            //{
            //    TradeTimeQualifier = "LOCL" //LOCL

            //};

            //var newTradeDetailInformation = new CTM_TradeDetailBodyTradeLevelInformation
            //{
            //    TypeOfTransactionIndicator = "TRAD", //  TRAD 
            //    BuySellIndicator = "BUYI", // BUYI
            //    TypeOfFinancialInstrument = "COMM", // COMM 
            //    TradeDateTime = 20150504094438, // 20150504094438 
            //    SettlementDate = 20150505//,  //>20150505
            //                             //DealPrice = newDealPrice,
            //                             //QuantityOfTheBlockTrade = newQuantityOfTheBlockTrade,
            //                             //TotalTradeAmount = newTotalTradeAmount,
            //                             // TimeZone = newTimeZone

            //};

            //var newInstructingParty = new CTM_TradeDetailBodyInstructingParty
            //{
            //    PartyRole = "INST", //"INST",
            //    PartyType = "BIC", //"BIC",
            //    PartyValue = "LIGHTSPD" // "LIGHTSPD"
            //};
            //var newCpTyTIdent = new CTM_TradeDetailBodyCPTYTradeLevelIdentifiers
            //{
            //   CTMTradeSideId = "CtmTradeSideId",
            //   MasterReference = "-793838912000001",
            //};


            //var newRequestBodyMsg = new CTM_TradeDetailBody
            //{
            //    TDUpdateGuard = "TDUpdateGuard",
            //    FunctionOfTheMessage = "NEWM", //"NEWM"
            //    VersionOfTradeComponent = 001, //"001",
            //    TradeLevelReferences = newTradeLevelReferences,
            //    TradeDetailReferences = newTradeDetailReferences,
            //    L2MatchingProfileName = "PName",
            //    InstructingParty = newInstructingParty,
            //    TradeLevelExpected = "N",
            //    CPTYTradeLevelIdentifiers = newCpTyTIdent,
            //    IdentificationOfASecurity = newSecurityCodeType,
            //    ExecutingBroker = newExecutingBroker

            //    //  TradeDetailInformation = newTradeDetailInformation
            //};

            //newReuqestMsg.SubmitHeader = newSubmitHeaderMsg;
            //newReuqestMsg.TradeDetailBody = newRequestBodyMsg;
            //msg.TradeDetail = newReuqestMsg;
            var tdMessage = new CTM_Message
            {
                TradeDetail = new CTM_TradeDetail
                {

                    SubmitHeader = new CTM_Header
                    {
                        ProtocolVersion = "CM01",
                        OriginatorOfMessage = new CTM_OriginatorOfMessage
                        {
                            PartyRole = "MEOR",
                            PartyType = "BIC",
                            PartyValue = "LIGHTSPD"
                        },
                        RecipientOfMessage = new CTM_RecipientOfMessage
                        {
                            PartyRole = "MERE",
                            PartyType = "TFID",
                            PartyValue = "CTMSERVICE"
                        },
                        SendersMessageReference = "VitasRef4417",
                        DateTimeOfSentMessage = 20151022143030
                    },
                    TradeDetailBody = new CTM_TradeDetailBody
                    {
                        FunctionOfTheMessage = "NEWM",
                        VersionOfTradeComponent = 001,
                        InstructingParty = new CTM_TradeDetailBodyInstructingParty
                        {
                            PartyRole = "INST",
                            PartyType = "BIC",
                            PartyValue = "LIGHTSPD"
                        },
                        ExecutingBroker = new CTM_TradeDetailBodyExecutingBroker
                        {
                            PartyRole = "EXEC",
                            PartyType = "OG",
                            PartyValue = "CTMTST01"
                        },
                        TradeLevelReferences = new CTM_TradeDetailBodyTradeLevelReferences
                        {
                            MasterReference = "20150917224155"
                        },
                        TradeDetailReferences = new CTM_TradeDetailBodyTradeDetailReferences
                        {
                            ClientAllocationReference = "Vitas0714144828"
                        },
                        TradeLevelExpected = "N",
                        IdentificationOfASecurity = new CTM_TradeDetailBodyIdentificationOfASecurity
                        {
                            SecurityCodeType = new CTM_TradeDetailBodyIdentificationOfASecuritySecurityCodeType
                            {
                                NumberingAgencyCode = "SEDO"
                            },
                            SecurityCode = "TWELLS",
                            DescriptionOfTheSecurity = "TWELLS"
                        },
                        TradeLevelInformation = new CTM_TradeDetailBodyTradeLevelInformation
                        {
                            TypeOfTransactionIndicator = "TRAD",
                            BuySellIndicator = "BUYI",
                            TypeOfFinancialInstrument = "COMM",
                            DealPrice = new CTM_TradeDetailBodyTradeLevelInformationDealPrice
                            {
                                CurrencyCode = "GBP",
                                Amount = "12,"
                            },
                            QuantityOfTheBlockTrade = new CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade
                            {
                                QuantityTypeCode = "UNIT",
                                Amount = "100,"
                            },
                            TotalTradeAmount = new CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount
                            {

                                CurrencyCode = "GBP",
                                Amount = "1200,"
                            },
                            TradeDateTime = 20151021144825,
                            TimeZone = new CTM_TradeDetailBodyTradeLevelInformationTimeZone
                            {
                                TradeTimeQualifier = "LOCL"
                            },
                            SettlementDate = 20151021
                        },
                        TradeDetailData = new CTM_TradeDetailBodyTradeDetailData
                        {
                            TradeAmount = new CTM_TradeDetailBodyTradeDetailDataTradeAmount
                            {
                                CurrencyCode = "GBP",
                                Amount = "1200,"
                            },
                            QuantityAllocated = new CTM_TradeDetailBodyTradeDetailDataQuantityAllocated
                            {
                                QuantityTypeCode = "UNIT",
                                Amount = "100,"
                            },
                            NetCashAmount = new CTM_TradeDetailBodyTradeDetailDataNetCashAmount
                            {
                                CurrencyCode = "GBP",
                                Amount = "1200,"
                            },
                            CommFeesTaxes = new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxes
                            {
                                Commissions = new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissions
                                {
                                    CommissionSharingBasisIndicator = "FLAT",
                                    CommissionType = "TCOM",
                                    Commission = new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesCommissionsCommission
                                    {
                                        Sign = "+",
                                        CurrencyCode = "GBP",
                                        Amount = "0,"
                                    }
                                },
                                ChargesOrTaxes = new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes[]
                             {
                                      new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes
                                        {
                                            ChargeTaxType = "LOCL",
                                            ChargeAmount = new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxesChargeAmount
                                            {
                                                Sign = "+",
                                                CurrencyCode = "GBP",
                                                Amount = "0,"
                                            }
                                        },
                                        new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes
                                        {
                                            ChargeTaxType = "CHAR",
                                            ChargeAmount = new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxesChargeAmount
                                            {
                                                Sign = "+",
                                                CurrencyCode = "GBP",
                                                Amount = "0,"
                                            }
                                        },
                                        new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxes
                                        {
                                            ChargeTaxType = "OTHR",
                                            ChargeAmount = new CTM_TradeDetailBodyTradeDetailDataCommFeesTaxesChargesOrTaxesChargeAmount
                                            {
                                                Sign = "+",
                                                CurrencyCode = "GBP",
                                                Amount = "0,"
                                            }
                                        }
                             }
                            }

                        },
                        IPSettlement = new CTM_TradeDetailBodyIPSettlement
                        {
                            AccountID = 0108
                        }

                    }
                }
            };
            return tdMessage;
        }

    }
}
