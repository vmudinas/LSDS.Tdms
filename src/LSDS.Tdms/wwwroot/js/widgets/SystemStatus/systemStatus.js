/// System Status
function SystemStatusRunNow() {
    // alert('run all now!!');
    SystemStatusRunNow();
}


function SystemStatusLink(value, idLog) {
    //alert('status' + value);
    var color = "";
    var status = "";
    switch (value) {
        case 0:
            status = "Success";
            color += "color:green;";
            break;

        case -1:
            status = "Failed";
            color += "color:red;";
            break;

        case 1:
            status = "Running";
            color += "color:orange;";
            break;

        case 2:
            status = "Queued";
            color += "color:orange;";
            break;
    }
    return "<a  href='TDMSLogViewer.aspx?MasterLogIDN=" + idLog + "' align='left' style='white-space:nowrap;" + color + "' >" + status + "</a>";
}
//Initiate System Status grid
function initSystemStatusGrid() {

    $.getJSON(
        "SystemStatus", { },
        function (myData) {
            var data = { "d": myData };

            $("#gridSystemStatus").kendoGrid({
                dataSource: {
                    data: data,
                    schema: {
                        data: "d",
                        type: 'json',
                        model: {
                            id: "tdSystemStatus",
                            fields: {
                                tdSystemStatus: { type: "string" },
                                StatusType: { type: "string" },
                                LastRun: { type: "string" },
                                LastRunDisplay : { type: "date" },
                                LastRunTimingType: { type: "string" },
                                LastRunTimingTypeDesc: { type: "string" },
                                NextRun: { type: "string" },
                                NextRunDisplay : { type: "date" },
                                NextRunTimingType: { type: "string" },
                                NextRunTimingTypeDesc: { type: "string" },
                                New: { type: "string" },
                                Cancel: { type: "string" },
                                Matched: { type: "string" },
                                Affirmed: { type: "string" },
                                LastRunStatus: { type: "int" },
                                LastRunStatusDesc: { type: "string" },
                                tblFundAccounting: { type: "string" },
                                LastMasterLogId: { type: "string" },
                                ErrorLogCount : { type: "string" },
                                User_Group_Description: { type: "string" },
                                Edit: { type: "string" }
                            }
                        }
                    }
                },
                toolbar: kendo.template($("#systemStatusToolBar").html()),
                height: 400,
                columns: [
                   { field: "Edit", title: "<div  align='center'><input  align='center' type='checkbox'  style='text-align:center;' id='idSystemStatusRunAllNow' class='MainChckSystemStatus' /></div>", template: "#= SystemStatusCheckBox(Edit,tdSystemStatus)#", width: 40, sortable: "true" },
                   { field: "StatusType", headerTemplate: "<div align='left' style='white-space:nowrap;'>Type</div>", template: "#= LeftNowrap(StatusType)#", width: 100, sortable: "true" },
                   { field: "LastRunDisplay", title: "LastRun", sortable: "true", type: "date", format: "{0:dd MMM yyyy HH:mm}" },
                   { field: "LastRunStatus", title: "Status", template: "#= SystemStatusLink(LastRunStatus,LastMasterLogId)#", width: 80, sortable: "true" },
                   { field: "New", title: "Last Count", width: 80, sortable: "true" },
                   { field: "NextRunDisplay", title: "Next Run", sortable: "true", type: "date", format: "{0:dd MMM yyyy HH:mm}" },
                   { field: "NextRunTimingTypeDesc", title: "Next Run Method", width: 100, sortable: "true" }
                ]
            });
        });


   //// console.log("y", systemStatusData);
   // $("#gridSystemStatus").kendoGrid({
   //     dataSource: {
   //         transport: {
   //             type: "json",
   //             read: {
   //                 read: "Home/BrokerPerformance"
   //             }
   //         }
   //     },
   //     height: 230,
   //     columns: [
   //                 { field: 'Edit', title: '<div  align=\'left\'><input  align=\'left\' type=\'checkbox\'  style=\'text-align:left;\' id=\'idSystemStatusRunAllNow\' class=\'MainChckSystemStatus\' /></div>', template: '#= SystemStatusCheckBox(Edit,tdSystemStatus)#', width: 25, sortable: 'true' },
   //                 { field: 'StatusType', headerTemplate: "<div align='left' style='white-space:nowrap;'>Type</div>", template: '#= LeftNowrap(StatusType)#', width: 100, sortable: 'true' },
   //                 { field: 'LastRunDisplay', title: 'LastRun', sortable: 'true' },
   //                 { field: 'LastRunStatus', title: 'Status', template: '#= SystemStatusLink(LastRunStatus,LastMasterLogId)#', width: 80, sortable: 'true' },
   //                 { field: 'New', title: 'Last Count', width: 80, sortable: 'true' },
   //                 { field: 'NextRunDisplay', title: 'Next Run', sortable: 'true' },
   //                 { field: 'NextRunTimingTypeDesc', title: 'Next Run Method', width: 100, sortable: 'true' }
   //     ]
   // });

  //  $('#gridSystemStatus').data('kendoGrid').dataSource.read();
  //  $('#gridSystemStatus').data('kendoGrid').refresh();

}
//System Status CheckBox created
function SystemStatusCheckBox(Edit, tdSystemStatus) {
    if (!Edit) {
        return "";
    }
    else {
        return "<div><input type=\'checkbox\'  style=\'text-align:center;\' id=\'" + tdSystemStatus + "\' class=\'systenStatusRun\' data='" + tdSystemStatus + "' /></div>";
    }
}


SystemStatusRunNow = function () {
    //find all selected checkboxes in relevant widget
    var jobIDs = '';
    var zoneId = this._zoneId;
    $('.systenStatusRun:checked').each(function () {
        if (jobIDs != '') {
            jobIDs += ',';
        }
        jobIDs += ($(this).attr('id'));
       // console.log('jobid' + $(this).attr('id'));
    });

    if (jobIDs != '') {

        if (confirm('Run ' + jobIDs.split(',').length + ' System Job(s)?')) {
            //Call SystemJobRun
            $.get("~/../TDMS_AJAX_Response.asmx/SystemJobRunById",
            { jobIDs: jobIDs },
            function (data) {
                var returnMessage = $(data).find('TDMSResponseText').text();
                //Refresh
                //var SSW = new SystemStatusWidget(instanceId, zoneId);
                //SSW.load(instanceId, zoneId);
                //alert(returnMessage);
                initSystemStatusGrid();
                ///reset checkboxes
                if (returnMessage.toLowerCase().indexOf('success') != -1) {
                    $('.systenStatusRun').prop('checked', false);
                    $('.MainChckSystemStatus').prop('checked', false);
                }
            },
            "xml");
        }

    }
    else {
        alert('No System Jobs selected to run.');
    }

    initSystemStatusGrid();
};