/// Saved Reports
//Initiate Saved Reports grid
function initSavedReports() {

    var userId = $("#userNameLable").val();
    $.getJSON(
        "SavedReports", { userId: userId },
        function(myData) {
            var data = { "d": myData };

            $("#gridSavedReports").kendoGrid({
                dataSource: {
                    data: data,
                    schema: {
                        data: "d",
                        type: 'json',
                        model: {
                            id: "LogId",
                            fields: {
                                Filename: { type: "string" },
                                Profile_name: { type: "string" },
                                LogId: { type: "string" },
                                CreatedUser: { type: "string" },
                                EndDateDisplay: { type: "date" },
                                EndDate: { type: "date" }
                            }
                        }
                    }
                },
                toolbar: kendo.template($("#savedReportToolBar").html()),
                height: 400,
                columns: [
                    { field: 'Profile_name', title: 'Report Profile', headerTemplate: "<div align='left' style='white-space:nowrap;'>Report Profile</div>", template: '#= LeftNowrap(SavedReportProfileName(Profile_name,Filename,LogId))#', sortable: 'true' },
                    { field: 'CreatedUser', title: 'CreatedBy', sortable: 'true' },
                    { field: 'EndDateDisplay', title: 'Date', sortable: 'true', width: 110, type: "date",format:"{0:dd MMM yyyy HH:mm}"  }
                ]
            });
        });

    //$('#gridSavedReports').data('kendoGrid').dataSource.read();
    //$('#gridSavedReports').data('kendoGrid').refresh();
}
function SavedReportProfileName(Profile_Name, Filename, LogId) {
    var baseBlobUrl = 'TDMSBlobDisplay.aspx?FileName=';
    var blobUrl = '';
    blobUrl = baseBlobUrl + Filename + '&LogId=' + LogId;

    return '<a href=' + blobUrl + ' target="_blank">' + Profile_Name + "</a>";
}
