//ImportSummary/// Import Summary Status
function initImportSummaryGrid() {


    var userId = $("#userNameLable").val();
   // var daysTime = 100;
    $.getJSON(
        "ImportSummary", { userId: userId, days: $('#idImportDays option:selected').val() },
        function(myData) {
            var data = { "d": myData };

            $("#gridImportSummary").kendoGrid({
                dataSource: {
                    data: data,
                    schema: {
                        data: "d",
                        type: 'json',
                        model: {
                            id: "tdMasterLog",
                            fields: {
                                tdMasterLog: { type: "string" },
                                LogType: { type: "string" },
                                LogTypeAlt: { type: "string" },
                                StartDate: { type: "date" },
                                EndDate: { type: "date" },
                                TotalRecordCount: { type: "string" },
                                Source: { type: "string" },
                                Status: { type: "string" },
                                StatusDesc: { type: "string" },
                                SysComment: { type: "string" },
                                tdUserGroupId: { type: "string" }

                            }
                        }
                    }
                },
                toolbar: kendo.template($("#importToolBar").html()),
                height: 400,
                columns: [
                    { field: 'LogTypeAlt', template: '#= LeftNowrap(LogTypeAlt)#', headerTemplate: "<div align='left' style='white-space:nowrap;'>Import Type</div>", width: 75, sortable: 'true' },
                    { field: 'StatusDesc', title: 'Status', template: '#= ImportStatusLink(StatusDesc,tdMasterLog)#', width: 60, sortable: 'true' },
                    { field: 'StartDate', title: 'Start',  width: 110, sortable: 'true', type: "date", format: "{0:dd MMM yyyy HH:mm}" },
                    { field: 'EndDate', title: 'End', width: 110, sortable: 'true', type: "date", format: "{0:dd MMM yyyy HH:mm}" },
                    { field: 'TotalRecordCount', title: 'Total', width: 40, sortable: 'true' },
                    { field: 'SysComment', title: 'Summary', sortable: 'true' }
                ]
            });
        });
  
}
function ImportStatusLink(value, idLog) {

    var color = "";
    var status = "";

    if (value === "Failed") {

        status = "Failed";
        color += "color:red;";
    }
    else {
        status = "Success";
        color += "color:green;";
    }
    return "<a  href='TDMSLogViewer.aspx?MasterLogIDN=" + idLog + "' align='left' style='white-space:nowrap;" + color + "' >" + status + "</a>";
  }


function importChangeDays() {
    // alert();
    initImportSummaryGrid();
}