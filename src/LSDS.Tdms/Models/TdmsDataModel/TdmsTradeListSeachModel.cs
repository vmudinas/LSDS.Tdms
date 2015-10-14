using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class TdmsTradeListSeachModel
    {
        [Key]
        public string txtPortfolio { get; set; }
        public string txtCUSIP { get; set; }
        public string txtBrokerFIN { get; set; }
        public string txtUserCode { get; set; }
        public DateTime txtTradeDate { get; set; }
        public DateTime txtSettleDate { get; set; }
        public DateTime txtTranDate { get; set; }
        public DateTime txtLoadDate { get; set; }

        public DateTime txtTradeDate1 { get; set; }
        public DateTime txtSettleDate1 { get; set; }
        public DateTime txtTranDate1 { get; set; }
        public DateTime txtLoadDate1 { get; set; }
        public string txtCurrencyCode { get; set; }
        public string txtTradeRef { get; set; }
        public string txtConfirmRef { get; set; }
        public string txtStockSymbol { get; set; }
        public string txtBrokerCode { get; set; }

        public string txtDTCAgentId { get; set; }
        public string txtDTCAgentInternalAccountNo { get; set; }
        public string drpTradeRefOp { get; set; }
        public string drpConfirmRefOp { get; set; }
        public string drpStockSymbolOp { get; set; }
        public string drpBrokerCodeOp { get; set; }
        public string drpDTCAgentIdOp { get; set; }
        public string drpDTCAgentInternalAccountNoOp { get; set; }
        public string drpDeleted { get; set; }
        public string drpPortfolioOp { get; set; }

        public string drpCUSIPOp { get; set; }
        public string drpBrokerFINOp { get; set; }
        public string drpUserCodeOp { get; set; }
        public string drpMatchStatusOp { get; set; }
        public string drpCurrCodeOp { get; set; }
        public string drpTransactionCode { get; set; }
        public string drpMatchStatus { get; set; }
        public string historyArchiveCurrent { get; set; }
 

    }
}
