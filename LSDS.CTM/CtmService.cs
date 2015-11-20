using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSDS.CTM.CtmMessages;

namespace LSDS.CTM
{
    public class CtmService
    {
        private string _connectionString
        { get; set; }

        private CTMDBContext _dbAccess { get; set; }
        private ConnectionManager _connManager { get; set; }

        public CtmService(string connectionString,string protocoldName, string host, string port, string loginPath,
            string userName, string password, string sslProxyHost, string sslProxyPort, string sslProxyUserName,
            string sslProxyPassword, int circuitTimeout, int idleTimeout, bool trace)
        {
            _connectionString = connectionString;

            _dbAccess = new CTMDBContext(connectionString);
            // "data source=lds-devel4;initial catalog=tdmse_sei_5;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

            _connManager = new ConnectionManager(protocoldName, host, port, loginPath, userName,
                password, sslProxyHost, sslProxyPort, sslProxyUserName, sslProxyPassword, circuitTimeout, idleTimeout, trace);
        }

        public int TradeDetailService()
        {
           // var msgList = new List<CTM_Message>();
            var trades = _dbAccess.MyMessage
                         .Include("TradeDetail.SubmitHeader")
                         .Include("TradeDetail.TradeDetailBody")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelReferences")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.Yield")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.TotalTradeAmount")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.TimeZone")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.StipulationsStandard")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.StipulationsNonStandard")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.QuantityOfTheBlockTrade")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.DealPrice")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.AdditionalMunicipalDebtData")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailReferences")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.TradeAmount")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.QuantityAllocated")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.NetCashAmount")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.CommFeesTaxes")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.CommFeesTaxes.Commissions")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.CommFeesTaxes.Commissions.Commission")
                         .Include("TradeDetail.TradeDetailBody.InstructingParty")
                         .Include("TradeDetail.TradeDetailBody.IdentificationOfASecurity")
                         .Include("TradeDetail.TradeDetailBody.IdentificationOfASecurity.SecurityCodeType")
                         .Include("TradeDetail.TradeDetailBody.IPSettlement")
                         .Include("TradeDetail.TradeDetailBody.ExecutingBroker")
                         .Include("TradeDetail.SubmitHeader.RecipientOfMessage")
                         .Include("TradeDetail.SubmitHeader.OriginatorOfMessage")
                         .Include("Cancel.SubmitHeader")
                         .Include("Cancel.CancelBody")
                         .Include("Cancel.CancelBody.InstructingParty")
                         .Include("Cancel.CancelBody.ExecutingBroker")
                         .Include("Cancel.CancelBody.ClearingBroker")
                         .Include("Cancel.CancelBody.TradeLevelIdentifiers")
                         .Include("Cancel.CancelBody.TradeDetailIdentifiers")
                         .Include("Cancel.SubmitHeader.RecipientOfMessage")
                         .Include("Cancel.SubmitHeader.OriginatorOfMessage")
                         .Include("Valid")
                         .Include("Valid.ValidBody")
                         .Where(t => t.Invalid == null && t.Valid == null && t.LastUpdated > DateTime.Now.AddDays(-4)).OrderBy(t => t.CtmId).ToList();

            foreach (var message in trades.Where(message => message.TradeDetail != null && message.Valid == null && message.Invalid == null))
            {
                ICtmProcess msg = new SendTradeDetail(message);
                message.TradeDetail.SubmitHeader.DateTimeOfSentMsg = DateTime.Now;
                message.TradeDetail.SubmitHeader.DateTimeOfSentMessage = ulong.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));

                var tempMessage = msg?.SendMsg(_connManager.GetSession());
                message.Invalid = tempMessage?.Invalid;
                message.Valid = tempMessage?.Valid;
            }
            return _dbAccess.SaveChanges();
        }

        public int CancelService()
        {
           // var msgList = new List<CTM_Message>();
            var trades = _dbAccess.MyMessage
                         .Include("TradeDetail.SubmitHeader")
                         .Include("TradeDetail.TradeDetailBody")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelReferences")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.Yield")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.TotalTradeAmount")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.TimeZone")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.StipulationsStandard")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.StipulationsNonStandard")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.QuantityOfTheBlockTrade")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.DealPrice")
                         .Include("TradeDetail.TradeDetailBody.TradeLevelInformation.AdditionalMunicipalDebtData")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailReferences")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.TradeAmount")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.QuantityAllocated")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.NetCashAmount")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.CommFeesTaxes")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.CommFeesTaxes.Commissions")
                         .Include("TradeDetail.TradeDetailBody.TradeDetailData.CommFeesTaxes.Commissions.Commission")
                         .Include("TradeDetail.TradeDetailBody.InstructingParty")
                         .Include("TradeDetail.TradeDetailBody.IdentificationOfASecurity")
                         .Include("TradeDetail.TradeDetailBody.IdentificationOfASecurity.SecurityCodeType")
                         .Include("TradeDetail.TradeDetailBody.IPSettlement")
                         .Include("TradeDetail.TradeDetailBody.ExecutingBroker")
                         .Include("TradeDetail.SubmitHeader.RecipientOfMessage")
                         .Include("TradeDetail.SubmitHeader.OriginatorOfMessage")
                         .Include("Cancel.SubmitHeader")
                         .Include("Cancel.CancelBody")
                         .Include("Cancel.CancelBody.InstructingParty")
                         .Include("Cancel.CancelBody.ExecutingBroker")
                         .Include("Cancel.CancelBody.ClearingBroker")
                         .Include("Cancel.CancelBody.TradeLevelIdentifiers")
                         .Include("Cancel.CancelBody.TradeDetailIdentifiers")
                         .Include("Cancel.SubmitHeader.RecipientOfMessage")
                         .Include("Cancel.SubmitHeader.OriginatorOfMessage")
                         .Include("Valid")
                         .Include("Valid.ValidBody")
                                                 .Where(t => t.Invalid == null && t.Valid == null && t.LastUpdated > DateTime.Now.AddDays(-4)).OrderBy(t => t.CtmId).ToList();

            foreach (var message in trades.Where(message => message.Cancel != null && message.Valid == null && message.Invalid == null))
            {
                ICtmProcess msg = new SendTradeCancel(message);
                message.Cancel.SubmitHeader.DateTimeOfSentMsg = DateTime.Now;
                message.Cancel.SubmitHeader.DateTimeOfSentMessage = ulong.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));

                var tempMessage = msg?.SendMsg(_connManager.GetSession());
                message.Invalid = tempMessage?.Invalid;
                message.Valid = tempMessage?.Valid;
            }
            return _dbAccess.SaveChanges();
        }
    }
}
