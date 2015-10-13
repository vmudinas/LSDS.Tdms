using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LSDS.Tdms.Models.TdmsDataModel
{
        public class TradeListModel
        {
           // [DisplayName("tdTrade")]
            public int tdTrade { get; set; }

           // [DisplayName("tdConfirm")]
            public int tdConfirm { get; set; }

            [DataType(DataType.Date)]
           // [DisplayName("TransactionLoadDate")]
            public DateTime TransactionLoadDate { get; set; }

            [StringLength(12)]
           // [DisplayName("PortNo")]
            public string PortNo { get; set; }

            [StringLength(4)]
           // [DisplayName("UserCode")]
            public string UserCode { get; set; }

            [DataType(DataType.Date)]
           // [DisplayName("Traded")]
            public DateTime Traded { get; set; }

            [DataType(DataType.Date)]
           // [DisplayName("Settlement")]
            public DateTime Settlement { get; set; }

           // [DisplayName("TN")]
            public int TN { get; set; }

            [StringLength(21)]
           // [DisplayName("Ticker")]
            public string Ticker { get; set; }

            [StringLength(50)]
           // [DisplayName("CUSIP")]
            public string CUSIP { get; set; }

            [StringLength(24)]
           // [DisplayName("Security")]
            public string Security { get; set; }

            [StringLength(24)]
           // [DisplayName("IssueDesc")]
            public string IssueDesc { get; set; }

            [StringLength(1)]
           // [DisplayName("mTransactionCode")]
            public string mTransactionCode { get; set; }

            [StringLength(12)]
           // [DisplayName("BCode")]
            public string BCode { get; set; }

            [StringLength(5)]
           // [DisplayName("BFin")]
            public string BFin { get; set; }

            [StringLength(36)]
           // [DisplayName("BrokerName")]
            public string BrokerName { get; set; }

            [StringLength(1)]
           // [DisplayName("ReasonCode")]
            public string ReasonCode { get; set; }

            [StringLength(15)]
           // [DisplayName("TdRef")]
            public string TdRef { get; set; }

            [StringLength(16)]
           // [DisplayName("ConfirmRefNo")]
            public string ConfirmRefNo { get; set; }

           // [DisplayName("Shares")]
            public float Shares { get; set; }

           // [DisplayName("UnitPrice")]
            public float UnitPrice { get; set; }

           // [DisplayName("Principal")]
            public float Principal { get; set; }

           // [DisplayName("SECFees")]
            public float SECFees { get; set; }

           // [DisplayName("Income")]
            public float Income { get; set; }

           // [DisplayName("FederalTax")]
            public float FederalTax { get; set; }

           // [DisplayName("Commission")]
            public float Commission { get; set; }

           // [DisplayName("OtherFee")]
            public float OtherFee { get; set; }

           // [DisplayName("NetAmount")]
            public float NetAmount { get; set; }

           // [DisplayName("UnitCost")]
            public float UnitCost { get; set; }

           // [DisplayName("mOriginalFace")]
            public float mOriginalFace { get; set; }

            [StringLength(36)]
           // [DisplayName("SecurityType")]
            public string SecurityType { get; set; }

            [StringLength(64)]
           // [DisplayName("Status")]
            public string Status { get; set; }

            [DataType(DataType.Date)]
           // [DisplayName("MatchDate")]
            public DateTime MatchDate { get; set; }

           // [DisplayName("Bond")]
            [StringLength(3)]
            public string Bond { get; set; }

           // [DisplayName("TranDate")]
            [DataType(DataType.Date)]
            public DateTime TranDate { get; set; }

           // [DisplayName("PDiscrepancy")]
            [StringLength(16)]
            public string PDiscrepancy { get; set; }

           // [DisplayName("IAID")]
            [StringLength(2)]
            public string IAID { get; set; }

           // [DisplayName("ProbCd")]
            [StringLength(1)]
            public string ProbCd { get; set; }

           // [DisplayName("TradeComments")]
            [StringLength(64)]
            public string TradeComments { get; set; }

           // [DisplayName("NotifyCode")]
            [StringLength(128)]
            public string NotifyCode { get; set; }

           // [DisplayName("Deleted")]
            [StringLength(3)]
            public string Deleted { get; set; }

           // [DisplayName("TradeSource")]
            [StringLength(6)]
            public string TradeSource { get; set; }

           // [DisplayName("CurrencyCode")]
            [StringLength(3)]
            public string CurrencyCode { get; set; }

           // [DisplayName("UnitCommission")]
            public decimal UnitCommission { get; set; }

            [StringLength(3)]
           // [DisplayName("Affirmed")]
            public string Affirmed { get; set; }

           // [DisplayName("Notified")]
            [StringLength(3)]
            public string Notified { get; set; }

           // [DisplayName("DTCAgentId")]
            [StringLength(5)]
            public string DTCAgentId { get; set; }

           // [DisplayName("DTCAgentInternalAccountNo")]
            [StringLength(20)]
            public string DTCAgentInternalAccountNo { get; set; }

           // [DisplayName("Archived")]
            public int Archived { get; set; }

           // [DisplayName("Side2")]
            [StringLength(64)]
            public string Side2 { get; set; }

           // [DisplayName("History")]
            public int History { get; set; }

           // [DisplayName("InstitutionNo")]
            [StringLength(8)]
            public string InstitutionNo { get; set; }

           // [DisplayName("tblShawPort")]
            public int tblShawPort { get; set; }

           // [DisplayName("Failed")]
            public int Failed { get; set; }

           // [DisplayName("ActualSettle")]
            [StringLength(10)]
            public string ActualSettle { get; set; }

           // [DisplayName("SN")]
            public int SN { get; set; }

           // [DisplayName("RelatedTradeRefNo")]
            [StringLength(35)]
            public string RelatedTradeRefNo { get; set; }

            [StringLength(16)]
            public string PairOffIndicator { get; set; }

           // [DisplayName("tdMasterLog")]
            public int tdMasterLog { get; set; }

           // [DisplayName("ISIN")]
            [StringLength(12)]
            public string ISIN { get; set; }

           // [DisplayName("PortNo2")]
            [StringLength(15)]
            public string PortNo2 { get; set; }

           // [DisplayName("trade_block")]
            public int trade_block { get; set; }

           // [DisplayName("FxRate")]
            public float FxRate { get; set; }

           // [DisplayName("mtm_confirm_type")]
            [StringLength(35)]
            public string mtm_confirm_type { get; set; }

           // [DisplayName("Age")]
            public int Age { get; set; }

           // [DisplayName("IsOnHold")]
            [StringLength(5)]
            public string IsOnHold { get; set; }

           // [DisplayName("Date_Stamp")]
            [DataType(DataType.Date)]
            public DateTime Date_Stamp { get; set; }

           // [DisplayName("LoanXId")]
            [StringLength(10)]
            public string LoanXId { get; set; }

            public string AlertAcronym { get; set; }
        }
    }