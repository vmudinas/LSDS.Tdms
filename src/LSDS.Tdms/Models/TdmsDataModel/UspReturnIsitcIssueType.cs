namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class UspReturnIsitcIssueType
    {
            public int tdxSecurityType { get; set; } //(int, not null)
            public string TypeCode { get; set; } //(varchar(3), null)
            public string Description { get; set; } //(varchar(36), null)
            public int? FlagBond1 { get; set; } //(int, null)
            public int? FlagBond2 { get; set; } //(int, null)
            public int? FlagBond3 { get; set; } //(int, null)
            public int? FlagType1 { get; set; } //(int, null)
            public int? FlagType2 { get; set; } //(int, null)
            public int? FlagType3 { get; set; } //(int, null)
            public string TypeCodeAlt { get; set; } //(varchar(12), null)
            public string TradeSource { get; set; } //(varchar(12), null)
            public string SettlementLoc { get; set; } //(varchar(12), null)
            public string SecurityTypeDisplay { get; set; } //(varchar(54), null)
        }

    }
