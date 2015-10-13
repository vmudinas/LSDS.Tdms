using System;
using System.Collections.Generic;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    public partial class TdmsConfirmData
    {
        public string mInstitutionNo { get; set; }
        public string shawportno { get; set; }
        public string custagentid { get; set; }
        public string custagentinternalAccount { get; set; }
        public string mtransactioncode { get; set; }
        public Nullable<System.DateTime> mtradedate { get; set; }
        public string cusipno { get; set; }
        public Nullable<double> mnumberofshares { get; set; }
        public Nullable<double> munitprice { get; set; }
        public Nullable<double> mcommission { get; set; }
        public Nullable<double> msecfees { get; set; }
        public Nullable<double> mnetamount { get; set; }
        public Nullable<System.DateTime> msettlementdate { get; set; }
        public string brokerfinno { get; set; }
        public string brokeragentinternalaccount { get; set; }
        public string stockname { get; set; }
        public string confirmrefno { get; set; }
        public Nullable<short> confirmmatchstatus { get; set; }
        public Nullable<System.DateTime> transactionloaddate { get; set; }
        public string traderefno { get; set; }
        public Nullable<System.DateTime> tradematchdate { get; set; }
        public int tdtrade { get; set; }
    }
}
