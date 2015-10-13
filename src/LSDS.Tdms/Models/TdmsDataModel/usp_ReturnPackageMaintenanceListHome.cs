
namespace LSDS.Tdms.Models.TdmsDataModel
{
    public class usp_ReturnPackageMaintenanceListHome
    {
        public int PackageMaintenanceId { get; set; }
        public int? PackagePrimary { get; set; }
        public string PackageName { get; set; }
        public string PackageType { get; set; }
        public string PartyDescription { get; set; }
        public string PackageMethod { get; set; }
        public string PackageFormat { get; set; }
        public string PackageTemplate { get; set; }
        public string PackageDelivery { get; set; }
        public string PackageTiming { get; set; }
        public string PackageEdit { get; set; }
        public System.DateTime? PackageLastRun { get; set; }
        public string PackageLastRunDisplay { get; set; }
        public System.DateTime? PackageNextRun { get; set; }
        public string PackageNextRunDisplay { get; set; }
        public int? PackageSent { get; set; }
        public int? PackagePending { get; set; }
        public int? PackageHold { get; set; }
        public int? PackageErrors { get; set; }
        public int? FlagRecap { get; set; }
        public System.DateTime? RecapTime { get; set; }
        public string Status { get; set; }
        public int? AsOfCan { get; set; }
        public int? LastMasterLogId { get; set; }
        public int? ErrorLogCount { get; set; }
        public bool? Edit { get; set; }
        public int? tdUserGroupID { get; set; }
    }
}