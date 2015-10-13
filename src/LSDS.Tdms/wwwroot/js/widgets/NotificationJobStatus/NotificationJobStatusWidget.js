var NotificationJobStatusWidgetService = function () {
    NotificationJobStatusWidgetService.initializeBase(this);

    this._timeout = 0;
    this._userContext = null;
    this._succeeded = null;
    this._failed = null;
}

NotificationJobStatusWidgetService.prototype = {
    _get_path: function () {
        var p = this.get_path();

        if (p) return p;
        else return NotificationJobStatusWidgetService._staticInstance.get_path();

    },

    GetNotificationJobStatusData: function (succeededCallback, failedCallback) {
        //  use AJAX via jQuery
        return $.get(this._get_path() + "/ReturnNotificationJobStatusData", {},
 succeededCallback, "xml");

    }

}


var NotificationJobStatusWidget = function (instanceId, zoneId) {
    this._instanceId = instanceId;
    this._zoneId = zoneId;
    this._widgetState = null;
    this._interval = 300000;
}

NotificationJobStatusWidget.prototype = {
    init: function (instanceId, zoneId) {
        var wgt = this;
        if ($("#Widget" + instanceId + "_Widget").data("loaded") != true) {
            $("#Widget" + instanceId + "_Widget").data("loaded", true);

            wgt.load(instanceId, zoneId);

        }

    },


    load: function (instanceId, zoneId) {
        this._instanceId = instanceId;
        this._zoneId = zoneId;

        $("#btnRunNow" + instanceId).hover(function () {
            $(this).attr("src", "images/Run_over.gif");
        },
 function () {
     $(this).attr("src", "images/Run.gif");
 });

        $("#btnRunNow" + instanceId).unbind("click");

        $("#btnRunNow" + instanceId).click(function () {
            NotificationJobStatusRunNow(instanceId);
        });

        $("#btnRunNow" + instanceId).css("cursor", "pointer");

        this.ShowLoading();

        /// Set the settings panel to display on client (no postback)
        $("#Widget" + instanceId + "_EditWidget").attr("href", "");

        $("#Widget" + instanceId + "_EditWidget").unbind("click");

        $("#Widget" + instanceId + "_EditWidget").click(function () {
            var atw = new NotificationJobStatusWidget(instanceId, zoneId);
            atw.toggleSettings(this);
            return false;
        });


        ///bind save button to saveSettings fn
        $("#btnSaveSettings_" + instanceId).addClass("floatbutton");

        $("#btnSaveSettings_" + instanceId).hover(function () { this.className = "floatbuttonover"; },
 function () { this.className = "floatbutton"; });

        $("#btnSaveSettings_" + instanceId).unbind("click");

        $("#btnSaveSettings_" + instanceId).click(function () {
            var atw = new NotificationJobStatusWidget(instanceId, zoneId);
            atw.saveSettings();
            return false;
        });


        ///bind widget box controls to load fn
        $("#Widget" + instanceId + "_MaximizeWidget").click(function () {
            var wgt = new NotificationJobStatusWidget(instanceId, zoneId);
            wgt.load(instanceId, zoneId);
            return false;
        });

        $("#Widget" + instanceId + "_RestoreWidget").click(function () {
            var wgt = new NotificationJobStatusWidget(instanceId, zoneId);
            wgt.load(instanceId, zoneId);
            return false;
        });

        $("#Widget" + instanceId + "_ExpandWidget").click(function () {
            var wgt = new NotificationJobStatusWidget(instanceId, zoneId);
            wgt.load(instanceId, zoneId);
            return false;
        });

        $("#Widget" + instanceId + "_CollapseWidget").click(function () {
            var wgt = new NotificationJobStatusWidget(instanceId, zoneId);
            wgt.load(instanceId, zoneId);
            return false;
        });


        this.loadSettings();

        /// hide progress indicator
        $("#Widget" + instanceId + "_Widget").data("loaded", true);

    },


    toggleSettings: function (e) {
        if ($(e).text() == "edit") {
            $(e).text("close edit");

            $("#W" + this._instanceId + "_SettingsPanel").show();

        }

        else {
            $(e).text("edit");

            $("#W" + this._instanceId + "_SettingsPanel").hide();

        }

    },


    loadSettings: function () {
        var wgt = this;
        var instanceId = this._instanceId;
        Dropthings.Web.Framework.WidgetService.GetWidgetState(instanceId, function (stateXml) {
            wgt._widgetState = Utility.getXMLDocument(stateXml);

            try {
                if (wgt._widgetState.getElementsByTagName("state")[0] != null) {
                    wgt.setOptions();

                }

                else {
                    wgt.setDefaults();

                }

            }

            catch (e) {
                wgt.load(this._instanceId, this._zoneId);

            }

        });

    },


    setOptions: function () {
        if (this._widgetState.getElementsByTagName("state")[0].getElementsByTagName("interval")[0].firstChild != null) {
            this._interval = this._widgetState.getElementsByTagName("state")[0].getElementsByTagName("interval")[0].firstChild.nodeValue;
        }


        //Set settings options here
        $("#drpInterval" + this._instanceId).val(this._interval);


        this.loadContent();

    },


    loadContent: function () {
        //Content settings

        $("#W" + this._instanceId + "_EmptyContent").html("");

        //Remove any residual timeout
        if ($("#W" + this._instanceId + "_EmptyContent").data("timeout") != null && $("#W" + this._instanceId + "_EmptyContent").data("timeout") != "") {
            window.clearTimeout($("#W" + this._instanceId + "_EmptyContent").data("timeout"));

        }

        //load content
        var wgt = this;

        NotificationJobStatusWidgetService.GetNotificationJobStatusData(function (resp) {
            wgt.BuildStatuses(resp);

        },

        function (msg) {
            wgt.ParseError(msg);

        });


        //set timeout to refresh, if necessary & store timeout id to remove it later (above)
        var instanceId = this._instanceId;
        var zoneId = this._zoneId;
        $("#W" + this._instanceId + "_EmptyContent").data("timeout", setTimeout(function () {
            var aew = new NotificationJobStatusWidget();
            aew.load(instanceId, zoneId);
        },
 this._interval * 1000));

    },


    BuildStatuses: function (data) {
        var widgetControlID = this._instanceId;
        var widgetZoneId = this._zoneId;
        //List view
        var wgt = this;
        var statusTypes = "";
        var sysStatusTableHead = $("#W" + widgetControlID + "_NotificationJobStatusWidgetContent .notificationJobStatusTable thead tr");

        var sysStatusTableBody = $("#W" + widgetControlID + "_NotificationJobStatusWidgetContent .notificationJobStatusTable tbody");

        if ($("#W" + widgetControlID + "_NotificationJobStatusWidgetContent .notificationJobStatusTable thead th").length == 0 && $("#W" + widgetControlID + "_NotificationJobStatusWidgetContent .tablescroll th").length == 0) {
            BindKendo();


            $("#" + this._instanceId + "_StatusTypes").val(statusTypes);


            var controlWidth = $("#W" + this._instanceId + "_Content").width() - 30;
            var wHeight = $("#W" + this._instanceId + "_Content").height() - 30;
            /// Add scrolling too!
            $("#W" + widgetControlID + "_NotificationJobStatusWidgetContent .notificationJobStatusTable").tablesorter({ widgets: ["zebra"] });

            $("#W" + widgetControlID + "_NotificationJobStatusWidgetContent .notificationJobStatusTable").dataGridScroll({ height: wHeight, width: controlWidth, flush: true, recheckWidths: true });

        }

        else {
            BindKendo();

        }


        wgt.HideLoading();

    },


    setDefaults: function () {
        // Set settings default options here

        this._interval = 30; //default interval

        this.loadContent();

    },


    saveSettings: function () {
        this._interval = $("#drpInterval" + this._instanceId).val();

        var updateState = true; //validate first

        if (updateState) {
            //save widget state
            this.saveWidgetState();

            // show progress indicator
            $("#WidgetPage_WidgetZone" + this._zoneId + "_WidgetContainer" + this._instanceId + "_UpdateProgress1").show();

        }

        else {
            // alert user action is required before saving state
            //alert('');

        }

    },


    XmlReturn: function () {
        var wgt = this;
        var xmlReturn = "";
        NotificationJobStatusWidgetService.XmlReturn(function (data) {
            xmlReturn = $(data).find("XmlContent").text().trim();


            //Process here
        },

        function (msg) {
        });

    },


    failStateSave: function (err) {
        jQuery("#W" + this._widgetID + "_TwUpdateError").html("Failed to save your credentials").css("display", "");

    },


    saveWidgetState: function () {
        //save the widget state
        var wgt = this;
        var instanceId = this._instanceId;
        var zoneId = this._zoneId;
        Dropthings.Web.Framework.WidgetService.SaveWidgetState(instanceId, wgt.prepareState(),
 function (msg) {
     wgt.load(instanceId, zoneId);

 },

        function (err) {
            wgt.failStateSave(err);

        });

    },


    prepareState: function () {
        // create the widget state string
        return "<state><interval>" + this._interval + "</interval></state>";
    },


    ShowLoading: function () {
        $("#NotificationJobStatusBar" + this._instanceId + " .widgetLoader").show();

    },

    HideLoading: function () {
        $("#NotificationJobStatusBar" + this._instanceId + " .widgetLoader").hide();

    }

};


NotificationJobStatusLog = function (e, id, logId) {
};

function __doPostBack(eventTarget, eventArgument) {
    if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
        theForm.__EVENTTARGET.value = eventTarget;
        theForm.__EVENTARGUMENT.value = eventArgument;
        theForm.submit();

    }

}

NotificationJobStatusRunNow = function (instanceId) {
    //find all selected checkboxes in relevant widget
    var packageIDs = "";
    var zoneId = this._zoneId;
    $("[name=\"checkBoxNotif\"]:checked").each(function () {
        if (packageIDs != "") {
            packageIDs += ",";
        }

        packageIDs += ($(this).attr("id"));

    });


    if (packageIDs != "") {
        if (confirm("Run " + packageIDs.split(",").length + " Notification Job(s)?")) {
            //Call SystemJobRun
            $.get("~/../TDMS_AJAX_Response.asmx/NotificationJobRun",
            { jobIDs: packageIDs },

            function (data) {
                var returnMessage = $(data).find("TDMSResponseText").text();


                alert(returnMessage);


                // /reset checkboxes
                if (returnMessage.toLowerCase().indexOf("success") != -1) {
                    $("." + instanceId + "RunNow").removeAttr("checked");

                    UncheckBoxes();

                }

            },

            "xml");

        }

    }

    else {
        alert("No Notification Jobs selected to run.");

    }

};

var ids = "";

function UncheckBoxes() {
    $("[name=\"checkBoxNotif\"]").each(function () {
        $(this).attr("checked", false);

        $(".MainChck").attr("checked", false);

    });

    ids = "";
    window.idsMain = "";
}

function CheckBoxes(idsMainX) {
    if (typeof (window.idsMain) != "undefined" && window.idsMain != null) {
        var idsSplit = idsMainX.split(",");

        var i;
        for (i = 0; i < idsSplit.length; ++i) {
            $("[name=\"checkBoxNotif\"]").each(function () {
                if (this.id === idsSplit[i]) {
                    $(this).attr("checked", "checked");

                }

            });

        };

    }

    ids = idsMainX;
    window.idsMain = idsMainX;
}


function BindKendo() {
    var viewModel = kendo.observable({
        isVisible: true,
        notificationWidgetStatus: new kendo.data.DataSource({
            schema: {
                model: {
                    id: "PackageMaintenanceId"
                }

            },

            transport: {
                type: "json",
                read: {
                    read: "Home/BrokerPerformance"
                }

            }

        })
    });


    kendo.bind($("#gridNotificationJobStatus"),
 viewModel);

    CheckBoxes(ids);

}

function NotificationStatusError(packageErrors) {
    if (packageErrors > 0) {
        return "<div style='color:red;text-align:center;'>" + packageErrors + "</div>";
    }

    return "<div style='text-align:center;'>" + packageErrors + "</div>";
}

function NotificationStatusHold(hold) {
    if (hold > 0) {
        return "<div style='text-align:center;color:#FF7F00;'>" + hold + "</div>";
    }

    return "<div style='text-align:center;'>" + hold + "</div>";
}

function NotificationStatus(status, ErrorLogCount, id, logId) {
    var result = "";

    switch (status) {
        case "Success":
        case "Printed":
        case "Received":
        case "Sent":
        case "Sent/Ack":
            result = "<a  href='TDMSLogViewer.aspx?MasterLogIDN=" + logId + "' align='left' style='white-space:nowrap;color:green;' >" + status + "</a>";
            break;
        case "Excluded":
        case "Not Sent":
        case "Partial ACK":
        case "Queued":
        case "Ready":
        case "Running":
        case "Sending":
        case "Transmitting":
            result = "<a  href='TDMSLogViewer.aspx?MasterLogIDN=" + logId + "' align='left' style='white-space:nowrap;color:orange;' >" + status;
            break;
        case "Failed":
        case "Partial NAK":
            result = "<div style='display: inline;color:tomato;cursor:pointer;text-align:center;text-decoration:underline;' onclick=' NotificationJobStatusLog(this," + id + "," + logId + ")'>";
            result = "<a  href='TDMSLogViewer.aspx?MasterLogIDN=" + logId + "' align='left' style='white-space:nowrap;color:tomato;' >" + status;
            break;
        default:
            result = "<a  href='TDMSLogViewer.aspx?MasterLogIDN=" + logId + "' align='left' style='white-space:nowrap;color:green;' >" + status;
    }


    var error = NotificationStatusIcon(ErrorLogCount);

    if (error.length > 1)
        return "<div style='display: inline;padding-left:12px;'>" + result + NotificationStatusIcon(ErrorLogCount) + "</a>" + "</div>";
    else
        return result + "</a>";
}

function NotificationStatusIcon(ErrorLogCOunt) {
    if (ErrorLogCOunt > 0) {
        return "<img src='" + window.contentImages + "Error.gif' style='display: inline;cursor:pointer;border=0;margin-right:0px;margin-left:0px;margin-top:1px;float:right;'></img>"
    }
    return "";
}

function NotificationAlignCenter(value) {
    return "<div style='text-align:center;' height='10px' >" + value + "</div>";
}

function NotificationCheckBox(edit, packageMaintenanceId) {
    // alert('te');

    if (edit) {
        return "<input type='checkbox'  style='text-align:center;text-overflow:clip;'  name='checkBoxNotif' id='" + packageMaintenanceId + "' class='RunNowChck'    />";
    }

    return "<div>&nbsp;</div>";
}

function CheckIfColumnIsEmpty(value) {
    try {
        if (value.length > 0) {
            return value;
        }

    }

    catch (err) {
        console.log(err.Message);

    }


    return "<div>&nbsp;</div>";
}


function initNotificationJobStatusGrid() {
    var userId = $("#userNameLable").val();


    $.getJSON(
        "NotificationJobStatus", { userId: userId },

        function (myData) {
            var data = { "d": myData };


            $("#gridNotificationJobStatus").kendoGrid({
                dataSource: {
                    data: data,
                    schema: {
                        data: "d",
                        type: "json",
                        model: {
                            id: "PackageMaintenanceId",
                            fields: {
                                Edit: { type: "string" },

                                PackageMaintenanceId: { type: "string" },

                                PartyDescription: { type: "string" },

                                Status: { type: "string" },

                                PackageDelivery: { type: "string" },

                                PackageFormat: { type: "string" },

                                PackageTiming: { type: "string" },

                                PackageSent: { type: "string" },

                                PackagePending: { type: "string" },

                                PackageHold: { type: "string" },

                                AsOfCan: { type: "string" },

                                PackageErrors: { type: "string" },

                                PackageLastRunDisplay: { type: "date" },

                                PackageNextRunDisplay: { type: "date" }

                            }

                        }

                    }

                },

                toolbar: kendo.template($("#notificationStatusToolBar").html()),

                height: 400,
                columns: [
            { field: "PackageMaintenanceId", title: "<input type='checkbox'  style='text-align:center;' id='idNotificationJobStatusRunAllNow' class='MainChck' /></div>", template: "#= NotificationCheckBox(Edit,PackageMaintenanceId)#", width: 35, sortable: false },

            { field: "PartyDescription", headerTemplate: "<div align='left' style='white-space:nowrap;'>Recipient</div>", template: "#= LeftNowrap(PartyDescription)#", height: 50, sortable: "true" },

            { field: "Status", title: "Status", template: "#= NotificationStatus(Status, ErrorLogCount,PackageMaintenanceId,LastMasterLogId) #", width: 85, height: 50, sortable: "true" },

            { field: "PackageDelivery", title: "Delivery", width: 75, sortable: "true" },

            { field: "PackageFormat", title: "Format", width: 90, sortable: "true" },

            { field: "PackageTiming", title: "Timing", width: 80, sortable: "true" },

            { field: "PackageSent", title: "Sent", width: 55, sortable: "true" },

            { field: "PackagePending", title: "Pending", width: 55, sortable: "true" },

            { field: "PackageHold", title: "Hold", width: 50, template: "#= NotificationStatusHold(PackageHold) #", sortable: "true" },

            { field: "AsOfCan", title: "As Of/Can", width: 65, sortable: "true" },

            { field: "PackageErrors", title: "Errors", width: 50, template: "#= NotificationStatusError(PackageErrors) #", sortable: "true" },

            { field: "PackageLastRunDisplay", title: "Last Run Time", width: 120, template: "#= CheckIfColumnIsEmpty(PackageLastRunDisplay) #", sortable: "true", type: "date", format: "{0:dd MMM yyyy HH:mm}" },

            { field: "PackageNextRunDisplay", title: "Next Run Time", width: 120, template: "#= CheckIfColumnIsEmpty(PackageNextRunDisplay) #", sortable: "true", type: "date", format: "{0:dd MMM yyyy HH:mm}" }

                ]
            });

        });

}