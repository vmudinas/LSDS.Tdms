

function LeftNowrap(value, color, header) {

    if (value === "" || value === "0" || value === 0 || value == undefined || value === "undefined" || value.length === 0) {
        return "";
    }
    var strReturnB = "";
    var strReturnE = "";
    var strClass = "";
    if (header === "Port No" || header === "BCode") {
        //  strReturnB = '<a href="">';
        //  strReturnE = "</a>";
        if (header === "Port No") {
            strClass = " class='PortNo' ";
        }
        if (header === "BCode") {
            strClass = " class='BCode' ";
        }
    }
    return "<div " + strClass + "  align='center' style='padding:3px;white-space:nowrap;" + returnColorDB(value, color) + "'>" + strReturnB + value + strReturnE + "</div>";
}

function parseJsonDate(jsonDateString) {
    return new Date(parseInt(jsonDateString.replace("/Date(", "")));
}

function CenterNowrapDate(value, color, header) {
    if (value === "" || value === "0" || value === 0 || value == undefined || value === "undefined" || value.length === 0) {
        return "";
    }
    var strReturnB = "";
    var strReturnE = "";
    var strClass = "";
    if (header === "Port No" || header === "BCode") {
        //    strReturnB = '<a href="">';
        //   strReturnE = "</a>";
        if (header === "Port No") {
            strClass = " class='PortNo' ";
        }
        if (header === "BCode") {
            strClass = " class='BCode' ";
        }
    }

    try {

        if (value.indexOf("/Date(") !== "-1") {

            var formattedDate = parseJsonDate(value);
            var d = formattedDate.getDate();
            var m = formattedDate.getMonth();

            m += 1; // JavaScript months are 0-11
            var y = formattedDate.getFullYear();

            return "<div " + strClass + "  align='center' style='padding:3px;white-space:nowrap;" + returnColorDB(value, color) + "'>" + strReturnB + d + "/" + m + "/" + y + strReturnE + "</div>";
        }
    } catch (err) {
        return "<div  " + strClass + " align='center' style='padding:3px;white-space:nowrap;" + returnColorDB(value, color) + "'>" + strReturnB + value + strReturnE + "</div>";
    }
    return "<div " + strClass + "  align='center' style='padding:3px;white-space:nowrap;" + returnColorDB(value, color) + "'>" + strReturnB + value + strReturnE + "</div>";

}

function LeftNowrapDate(value, color, header) {
    if (value === "" || value === "0" || value === 0 || value == undefined || value === "undefined" || value.length === 0) {
        return "";
    }
    var strReturnB = "";
    var strReturnE = "";
    var strClass = "";
    if (header === "Port No" || header === "BCode") {

        if (header === "Port No") {
            strClass = " class='PortNo' ";
        }
        if (header === "BCode") {
            strClass = " class='BCode' ";
        }
    }
    try {

        if (value.indexOf("/Date(") !== -1) {

            var formattedDate = parseJsonDate(value);
            var d = formattedDate.getDate();
            var m = formattedDate.getMonth();

            m += 1; // JavaScript months are 0-11
            var y = formattedDate.getFullYear();

            return "<div  " + strClass + " align='left' style='padding:3px;white-space:nowrap;'>" + strReturnB + d + "/" + m + "/" + y + strReturnE + "</div>";
        }
    } catch (err) {
        return "<div " + strClass + "  align='left' style='padding:3px;white-space:nowrap;" + returnColorDB(value, color) + "'>" + strReturnB + value + strReturnE + "</div>";
    }
    return "<div " + strClass + "  align='left' style='padding:3px;white-space:nowrap;" + returnColorDB(value, color) + "'>" + strReturnB + value + strReturnE + "</div>";

}

function returnColorDB(value, color) {

    console.log(value + ":::" + color);

    try {
        if (value === "" || value === "0" || value === 0 || value == undefined || value === "undefined" || value.length === 0) {
            return "";
        }
        if ($.trim(color)) {
            return "";
        }
    } catch (e) {
        return "";
    }
    if (color === "" || color === "0" || color === 0 || color == undefined || color === "undefined" || color.length === 0) {
        return "";
    }
    var rtColor = color.split(";");

    for (var chunk in rtColor) {
        if (rtColor.hasOwnProperty(chunk)) {
            var arrayChunk = rtColor[chunk].split(":");
            for (var chunkValue in arrayChunk) {
                if (arrayChunk.hasOwnProperty(chunkValue)) {
                    try {
                        //console.log(value + "<>" + arrayChunk[0] + "<>" + arrayChunk[1]);
                        if (value === arrayChunk[0]) {
                            return "background-color:" + arrayChunk[1] + ";";
                        } else if ("0" === arrayChunk[0]) {
                            return "background-color:" + arrayChunk[1] + ";";
                        }
                    } catch (ex) {
                        return "";
                    }
                }
            }
        }
    }

    return "";
}

function CenterNowrap(value) {
    // alert(value);
    if (value === "" || value === "0" || value === 0 || value == undefined || value === "undefined" || value.length === 0) {
        return "";
    }
    var strReturnB = "";
    var strReturnE = "";
    var strClass = "";
    if (header === "Port No" || header === "BCode") {
        //    strReturnB = '<a href="">';
        //   strReturnE = "</a>";
        if (header === "Port No") {
            strClass = " class='PortNo' ";
        }
        if (header === "BCode") {
            strClass = " class='BCode' ";
        }
    }

    if (value === "null" || value === "undefined" || value === "") {
        return "<div " + strClass + " align='center' style='padding:3px;white-space:nowrap;'></div>";
    } else {
        return "<div  " + strClass + " align='center' style='padding:3px;white-space:nowrap;'>" + strReturnB + value + strReturnE + "</div>";
    }
}

function clickRepair(id) {
    //alert(id);
    // location = location.href.match(/^(http.+\/)[^\/]+$/)[1] + "TDMSPortal.aspx";
}

var myVar = setInterval(function() { myTimer() }, 30000);
var timeNow = 0;

function myTimer() {
    // alert(timeNow);

    timeNow = timeNow + 1;
    if (timeNow === 1) {
        runIntOnWidetControl(1);
    } else if (timeNow === 2) {
        runIntOnWidetControl(2);
    } else if (timeNow === 10) {
        runIntOnWidetControl(10);
    } else if (timeNow === 60) {
        runIntOnWidetControl(60);
    } else if (timeNow === 120) {
        runIntOnWidetControl(120);
        timeNow = 0;
    }
    //  var d = new Date();
    //  document.getElementById("demo").innerHTML = d.toLocaleTimeString();
}

function runIntOnWidetControl(intTime) {
    //    runInitOnWidget("savedReportsRefresh", intTime);
    //   runInitOnWidget("tradeMatchRefresh", intTime);
    // runInitOnWidget("idNotificationStatusRefresh", intTime);
    // runInitOnWidget("settlementStatusRefresh", intTime);
    // runInitOnWidget("tradeRepairRefresh", intTime);
    // runInitOnWidget("systemStatusRefresh", intTime);


}

function RefreshSave(id) {
    var reshreshId = "";
    switch (id) {
    case "idSystemStatus":
        reshreshId = "systemStatusRefresh";
        break;
    case "idTradeRepair":
        reshreshId = "tradeRepairRefresh";
        break;
    case "idTradeSettlementStatus":
        reshreshId = "settlementStatusRefresh";
        break;
    case "idNotificationJobStatus":
        reshreshId = "idNotificationStatusRefresh";
        break;
    case "idTradeMatchStatus":
        reshreshId = "tradeMatchRefresh";
        break;
    case "idSavedReports":
        reshreshId = "savedReportsRefresh";
        break;
    }

    return reshreshId;
}

function errorCatch(id, chartGrid) {
    try {
        var chartMatchedStatus = $("#" + id).data(chartGrid);
        chartMatchedStatus.refresh();
    } catch (err) {
        //  console.log(err.message);
    }

}

function runInitOnWidget(controlId, intTime) {


    if ($("#" + controlId).val() == intTime) {

        if (controlId === "systemStatusRefresh") {

            initSystemStatusGrid();
            //console.log("systemStatusRefresh");
        }
        if (controlId === "savedReportsRefresh") {
            initSavedReports();
            //console.log("savedReportsRefresh");
        }
        var chart;
        if (controlId === "tradeMatchRefresh") {
            initMatchedStatusGrid();
            var grid = $("#gridMatchedStatus").data("kendoGrid");
            grid.refresh();
            try {
                chart = $("#chartMatchedStatus").data("kendoChart");
                chart.refresh();
            } catch (err) {
                //console.log(err.message);
            }
            //console.log("tradeMatchRefresh");
        }
        if (controlId === "idNotificationStatusRefresh") {
            initNotificationJobStatusGrid();
            //console.log("idNotificationStatusRefresh");
        }
        if (controlId === "settlementStatusRefresh") {
            initSettlementStatus();
            try {
                chart = $("#chartSettlementStatus").data("kendoChart");
                chart.refresh();
            } catch (err) {
                //console.log(err.message);
            }

            // console.log("settlementStatusRefresh");
        }
        if (controlId === "tradeRepairRefresh") {
            initTradeRepairGrid();
            try {
                chart = $("#chartTradeRepair").data("kendoChart");
                chart.refresh();
            } catch (err) {
                //  console.log(err.message);
            }
            //  console.log("tradeRepairRefresh");
        }

    }

}

// });
function DateFormat(date) {
    //alert('data');
    if (date === "null" || date === undefined || date == null) {
        return "";
    } else {
        //   alert(date);
        return new Date(date);
    }
}

function hideEdits() {
    //widgetMatchStatusEdit
    $(".widgetEdithideMatchStatus").hide();
    $(".widgetEdithideSavedReports").hide();
    $(".widgetEdithideBrokerPerformance").hide();
    $(".widgetEdithideSystemStatus").hide();
    $(".widgetEdithideNotificationStatus").hide();
    $(".widgetEdithideImportSummary").hide();
    $(".widgetEdithidTradeSettlementStatus").hide();
    $(".widgetEdithideTradeRepairStatus").hide();
}

function hideEdit(classId, grid, chart, lable, ulId, pickerClass) {

    if ($("." + classId).is(":hidden")) {
        $("." + classId).show();
        $("#" + lable).text("close edit");
        $(".gridster ul").data("gridster").resize_widget($("#" + ulId), $("#" + ulId).attr("data-sizex"), 2);

        $("." + pickerClass).height($("." + pickerClass).height() + 200);
        $("#" + ulId + ".widgetTitle").toggleClass("widgetTitle widgetTitleExpended");

    } else {
        $("." + classId).hide();
        $("#" + lable).text("edit");
        $(".gridster ul").data("gridster").resize_widget($("#" + ulId), $("#" + ulId).attr("data-sizex"), 1);
        $("." + pickerClass).height($("." + pickerClass).height() - 200);
        $("#" + ulId + ".widgetTitleExpended").toggleClass("widgetTitleExpended widgetTitle");
    }

    try {
        var chartC = $("#" + chart).data("kendoChart");
        $("#" + chart).css("height", "45%");
        $("#" + chart).css("width", "95%");
        chartC.refresh();

    } catch (err) {
        var errMsg = err.message;
    }


}

function saveEdit(editSave) {
    //  UpdateControls();	    
    //InitAll controls
    initWidget(editSave);
}

function initWidget(widgetName) {
    //SystemStatus TradeRepairStatus
    //TradeSettlementStatus
    //BrokerPreformance
    //ImportSummary
    //NotificationStatus
    //MatchedStatus
    //SavedReport
    var chart;
    switch (widgetName) {
    case "SystemStatus":
        initSystemStatusGrid();

        break;
    case "TradeRepairStatus":
        initTradeRepairGrid();
        try {
            chart = $("#chartTradeRepair").data("kendoChart");
            chart.refresh();
        } catch (err) {
            //console.log(err.message);
        }

        break;
    case "TradeSettlementStatus":
        initSettlementStatus();
        try {
            chart = $("#chartSettlementStatus").data("kendoChart");
            chart.refresh();
        } catch (err) {
            //console.log(err.message);
        }
        break;
    case "BrokerPreformance":
        initBrokerPerformance();
        break;
    case "ImportSummary":
        initImportSummaryGrid();
        break;
    case "NotificationStatus":
        initNotificationJobStatusGrid();
        break;
    case "MatchedStatus":
        initMatchedStatusGrid();
        var grid = $("#gridMatchedStatus").data("kendoGrid");
        grid.refresh();
        try {
            //   var chart = $("#chartMatchedStatus").data("kendoChart");
            //  chart.refresh();
        } catch (err) {
            //console.log(err.message);
        }


        break;
    case "SavedReport":
        initSavedReports();
        break;

    }

}

function SaveWidgets() {
    $("#idSaveWidgets").text("Saving");
    //UpdateControls();
    $("#idSaveWidgets").hide();
    $("#idSaveWidgets").text("Save");
}

function checkBoxTotalSet(id, total, txnSide, notifyType) {
    //console.log("checkBoxTotalSet id:" + id + " total:" + total + " txnSide:" + txnSide + " notifyType: " + notifyType)
    if ("idTradeMatchStatus" === id) {
        $(".matchStatusTotals").prop("checked", total);
        $(".matchStatusTxnSide").prop("checked", txnSide);
        $(".matchStatusNofityType").prop("checked", notifyType);
    } else if ("idTradeSettlementStatus" === id) {
        $(".settlementTotal").prop("checked", total);
        $(".settlemenetTxtSide").prop("checked", txnSide);
        $(".settlementNotifyType").prop("checked", notifyType);
    }
}

function UpdateControlPosition(id, controlName, dataRow, dataCol, dataSizex, dataSizey, visible, widgetCheckBoxId, widgetRefreshRate, widgetDisplayId, widgetTotal, widgetTxnSide, widgetNotifyType, widgetTimePeriod) {


}

function ShowHideWidgetConfig() {

    // $('#idSaveWidgets').show();
    if ($("#WidgetsConfiguration").css("display") === "none") {
        $("#idShowWidgets").val("Hide Module List");
        $("#idshowwidgetsL").text("Hide Module List");

        $("#idShowWidgets").css("width", "120px");
        $("#WidgetsConfiguration").show();

        ///  UpdateControls();
        //  setControlFromDB();
    } else {
        $("#idShowWidgets").val("Add Modules");
        $("#idshowwidgetsL").text("Add Modules");
        $("#idShowWidgets").css("width", "85px");
        $("#WidgetsConfiguration").hide();
    }
    // UpdateControls();
}

function ShowHideWidget(idName, e) {
    $("#idSaveWidgets").show();
    if (e.checked) {
        $("#" + idName).css("visibility", "visible");
    } else {
        $("#" + idName).css("visibility", "hidden");
        $("." + idName).attr("checked", false);
    }
}

function SetSizeX(idName, size) {
    $("#" + idName).attr("data-sizex", size);
}

function UpdateList() {
    //setTimeout(function () {		 
    //    UpdateControls();
    //    setControlFromDB();
    //}, 500);
}

function UpdateControls() {
    //    //console.log('Enter update function');
    //    //  alert($("#chkTradeMatchStatus").is(':checked'));
    //    var tradeMatchStatusID = $('#idTradeMatchStatus').attr('data-id');
    //    var tradeMatchStatusR = $('#idTradeMatchStatus').attr('data-row');
    //    var tradeMatchStatusC = $('#idTradeMatchStatus').attr('data-col');
    //    var tradeMatchStatusX = $('#idTradeMatchStatus').attr('data-sizex');
    //    var tradeMatchStatusY = $('#idTradeMatchStatus').attr('data-sizey');
    //    var tradeMatchwidgetRefreshRate = $("#tradeMatchRefresh").val();
    //    var tradeMatchwidgetDisplayId = getIdImg("idTradeMatchStatus");
    //    var tradeMatchwidgetTotal = $(".matchStatusTotals").is(":checked");
    //    var tradeMatchwidgetTxnSide = $(".matchStatusTxnSide").is(":checked");
    //    var tradeMatchwidgetNotifyType = $(".matchStatusNofityType").is(":checked");
    //    var tradeMatchwidgetTimePeriod = 0;
    //    UpdateControlPosition(tradeMatchStatusID, 'idTradeMatchStatus', tradeMatchStatusR, tradeMatchStatusC, tradeMatchStatusX,
    //        tradeMatchStatusY, $(".idTradeMatchStatus").is(':checked'), 'chkTradeMatchStatus', tradeMatchwidgetRefreshRate, tradeMatchwidgetDisplayId,
    //        tradeMatchwidgetTotal, tradeMatchwidgetTxnSide, tradeMatchwidgetNotifyType, tradeMatchwidgetTimePeriod);
    //    //console.log('idTradeMatchStatus');
    //    var savedReportsID = $('#idSavedReports').attr('data-id');
    //    var savedReportsR = $('#idSavedReports').attr('data-row');
    //    var savedReportsC = $('#idSavedReports').attr('data-col');
    //    var savedReportsX = $('#idSavedReports').attr('data-sizex');
    //    var savedReportsY = $('#idSavedReports').attr('data-sizey');
    //    var savedReportswidgetRefreshRate = $("#savedReportsRefresh option:selected").val();
    //    var savedReportswidgetDisplayId = 'gridSavedReports';
    //    var savedReportswidgetTotal = false;
    //    var savedReportswidgetTxnSide = false;
    //    var savedReportswidgetNotifyType = false;
    //    var savedReportswidgetTimePeriod = 0;
    //    UpdateControlPosition(savedReportsID, 'idSavedReports', savedReportsR, savedReportsC, savedReportsX, savedReportsY, $(".idSavedReports").is(':checked'),
    //        'chkSavedReports', savedReportswidgetRefreshRate, savedReportswidgetDisplayId, savedReportswidgetTotal, savedReportswidgetTxnSide, savedReportswidgetNotifyType,
    //        savedReportswidgetTimePeriod);
    //    //console.log('idSavedReports');
    //    var notificationJobStatusID = $('#idNotificationJobStatus').attr('data-id');
    //    var notificationJobStatusR = $('#idNotificationJobStatus').attr('data-row');
    //    var notificationJobStatusC = $('#idNotificationJobStatus').attr('data-col');
    //    var notificationJobStatusX = $('#idNotificationJobStatus').attr('data-sizex');
    //    var notificationJobStatusY = $('#idNotificationJobStatus').attr('data-sizey');
    //    var notificationJobwidgetRefreshRate = $("#idNotificationStatusRefresh option:selected").val();
    //    var notificationJobwidgetDisplayId = 'gridNotificationJobStatus';
    //    var notificationJobwidgetTotal = false;
    //    var notificationJobwidgetTxnSide = false;
    //    var notificationJobwidgetNotifyType = false;
    //    var notificationJobwidgetTimePeriod = 0;
    //    UpdateControlPosition(notificationJobStatusID, 'idNotificationJobStatus', notificationJobStatusR, notificationJobStatusC, notificationJobStatusX,
    //        notificationJobStatusY, $(".idNotificationJobStatus").is(':checked'), 'chkNotificationStatus', notificationJobwidgetRefreshRate, notificationJobwidgetDisplayId,
    //        notificationJobwidgetTotal, notificationJobwidgetTxnSide, notificationJobwidgetNotifyType, notificationJobwidgetTimePeriod);
    //    //console.log('idNotificationJobStatus');
    //    var importSummaryID = $('#idImportSummary').attr('data-id');
    //    var importSummaryR = $('#idImportSummary').attr('data-row');
    //    var importSummaryC = $('#idImportSummary').attr('data-col');
    //    var importSummaryX = $('#idImportSummary').attr('data-sizex');
    //    var importSummaryY = $('#idImportSummary').attr('data-sizey');
    //    var importSummarywidgetRefreshRate = 999;
    //    var importSummarywidgetDisplayId = 'gridImportSummary';
    //    var importSummarywidgetTotal = false;
    //    var importSummarywidgetTxnSide = false;
    //    var importSummarywidgetNotifyType = false;
    //    var importSummarywidgetTimePeriod = $("#idImportDays option:selected").val();
    //    UpdateControlPosition(importSummaryID, 'idImportSummary', importSummaryR, importSummaryC, importSummaryX, importSummaryY,
    //        $(".idImportSummary").is(':checked'), 'chkImportSummary', importSummarywidgetRefreshRate, importSummarywidgetDisplayId, importSummarywidgetTotal,
    //       importSummarywidgetTxnSide, importSummarywidgetNotifyType, importSummarywidgetTimePeriod);
    //    //console.log('idImportSummary');
    //    var brokerPreformanceID = $('#idBrokerPreformance').attr('data-id');
    //    var brokerPreformanceR = $('#idBrokerPreformance').attr('data-row');
    //    var brokerPreformanceC = $('#idBrokerPreformance').attr('data-col');
    //    var brokerPreformanceX = $('#idBrokerPreformance').attr('data-sizex');
    //    var brokerPreformanceY = $('#idBrokerPreformance').attr('data-sizey');
    //    var brokerPreformancewidgetRefreshRate = $("#brokerPerformanceTimePeriodSelect option:selected").val();
    //    var brokerPreformancewidgetDisplayId = 'gridBrokerPerformance';
    //    var brokerPreformancewidgetTotal = false;
    //    var brokerPreformancewidgetTxnSide = false;
    //    var brokerPreformancewidgetNotifyType = false;
    //    var brokerPreformancewidgetTimePeriod = 0;
    //    UpdateControlPosition(brokerPreformanceID, 'idBrokerPreformance', brokerPreformanceR, brokerPreformanceC, brokerPreformanceX, brokerPreformanceY,
    //        $(".idBrokerPreformance").is(':checked'), 'chkBrokerPreformance', brokerPreformancewidgetRefreshRate, brokerPreformancewidgetDisplayId,
    //        brokerPreformancewidgetTotal, brokerPreformancewidgetTxnSide,brokerPreformancewidgetNotifyType,brokerPreformancewidgetTimePeriod);
    //    //console.log('idBrokerPreformance');
    //    var tradeSettlementStatusID = $('#idTradeSettlementStatus').attr('data-id');
    //    var tradeSettlementStatusR = $('#idTradeSettlementStatus').attr('data-row');
    //    var tradeSettlementStatusC = $('#idTradeSettlementStatus').attr('data-col');
    //    var tradeSettlementStatusX = $('#idTradeSettlementStatus').attr('data-sizex');
    //    var tradeSettlementStatusY = $('#idTradeSettlementStatus').attr('data-sizey');
    //    var tradeSettlementwidgetRefreshRate = $("#settlementStatusRefresh option:selected").val();
    //    var tradeSettlementwidgetDisplayId = getIdImg("idTradeSettlementStatus");
    //    var tradeSettlementwidgetTotal =  $(".settlementTotal").is(':checked');
    //    var tradeSettlementwidgetTxnSide = $(".settlemenetTxtSide").is(':checked');
    //    var tradeSettlementwidgetNotifyType =$(".settlementNotifyType").is(':checked');

    //    var tradeSettlementwidgetTimePeriod = 0;
    //    UpdateControlPosition(tradeSettlementStatusID, 'idTradeSettlementStatus', tradeSettlementStatusR, tradeSettlementStatusC, tradeSettlementStatusX,
    //        tradeSettlementStatusY, $(".idTradeSettlementStatus").is(':checked'), 'chkTradeSettlementStatus',tradeSettlementwidgetRefreshRate,tradeSettlementwidgetDisplayId,
    //       tradeSettlementwidgetTotal,tradeSettlementwidgetTxnSide,tradeSettlementwidgetNotifyType,tradeSettlementwidgetTimePeriod);
    //    //console.log('idTradeSettlementStatus');
    //    var tradeRepairID = $('#idTradeRepair').attr('data-id');
    //    var tradeRepairR = $('#idTradeRepair').attr('data-row');
    //    var tradeRepairC = $('#idTradeRepair').attr('data-col');
    //    var tradeRepairX = $('#idTradeRepair').attr('data-sizex');
    //    var tradeRepairY = $('#idTradeRepair').attr('data-sizey');
    //    var tradeRepairwidgetRefreshRate = $("#tradeRepairRefresh option:selected").val();
    //    var tradeRepairwidgetDisplayId = getIdImg("idTradeRepair");
    //    var tradeRepairwidgetTotal = false;
    //    var tradeRepairwidgetTxnSide = false;
    //    var tradeRepairwidgetNotifyType = false;
    //    var tradeRepairidgetTimePeriod = 0;
    //    UpdateControlPosition(tradeRepairID, 'idTradeRepair', tradeRepairR, tradeRepairC, tradeRepairX, tradeRepairY,
    //        $(".idTradeRepair").is(':checked'), 'chkTradeRepair', tradeRepairwidgetRefreshRate,
    //         tradeRepairwidgetDisplayId, tradeRepairwidgetTotal, tradeRepairwidgetTxnSide,
    //        tradeRepairwidgetNotifyType, tradeRepairidgetTimePeriod);


    //    //console.log('idTradeRepair' + tradeRepairID + 'idTradeRepair' + tradeRepairR + tradeRepairC + tradeRepairX + tradeRepairY + $(".idTradeRepair").is(':checked')
    //    //    + 'chkTradeRepair'+ tradeRepairwidgetRefreshRate+
    //     //   tradeRepairwidgetRefreshRate+tradeRepairwidgetDisplayId+tradeRepairwidgetTotal+tradeRepairwidgetTxnSide+tradeRepairwidgetNotifyType+tradeRepairidgetTimePeriod);

    //    var systemStatusID = $('#idSystemStatus').attr('data-id');
    //    var systemStatusR = $('#idSystemStatus').attr('data-row');
    //    var systemStatusC = $('#idSystemStatus').attr('data-col');
    //    var systemStatusX = $('#idSystemStatus').attr('data-sizex');
    //    var systemStatusY = $('#idSystemStatus').attr('data-sizey');
    //    var systemStatuswidgetRefreshRate = $("#systemStatusRefresh option:selected").val();
    //    var systemStatuswidgetDisplayId = 'gridSystemStatus';
    //    var systemStatuswidgetTotal = false;
    //    var systemStatuswidgetTxnSide = false;
    //    var systemStatuswidgetNotifyType = false;
    //    var systemStatusidgetTimePeriod = 0;
    //    UpdateControlPosition(systemStatusID, 'idSystemStatus', systemStatusR, systemStatusC, systemStatusX, systemStatusY, $(".idSystemStatus").is(':checked'),
    //        'chkSystemStatus',systemStatuswidgetRefreshRate,systemStatuswidgetDisplayId,systemStatuswidgetTotal,systemStatuswidgetTxnSide,systemStatuswidgetNotifyType,
    //        systemStatusidgetTimePeriod);
    //console.log('idSystemStatus' + systemStatuswidgetRefreshRate);
}

function getIdImg(id) {
    try {
        var pie = $("#" + id + "Pie").attr("src");
        var list = $("#" + id + "List").attr("src");
        var bar = $("#" + id + "Bar").attr("src");
        if (pie === "images/pie_off_20.png") {
            return "1";
        }
        if (list === "images/list_off_20.png") {
            return "2";
        }
        if (bar === "images/bar_off_20.png") {
            return "3";
        }
    } catch (err) {
        return "0";
    }
    return "";
}

function showChart(id, chartId, type) {
    try {
        $("#" + chartId).show();
        $("#" + id).hide();
        //var chart = $("#"+chartId).data("kendoChart");
        //// Change type for first serie
        //chart.options.series[0].type = type;
        //// Finally refresh chart
        //chart.refresh();
    } catch (err) {
        console.log(err.message);
    }
}

function showListChart(id, chartId) {
    // Finally refresh chart
    $("#" + chartId).hide();
    $("#" + id).show();
    //var grid = $("#"+id).data("kendoGrid");
    //// Change type for first serie
    //grid.refresh();
}

function getChartId(id) {
    if (id === "idTradeRepair") {
        return "chartTradeRepair";
    }
    if (id === "idTradeSettlementStatus") {
        return "chartSettlementStatus";
    }
    if (id === "idTradeMatchStatus") {
        return "chartMatchedStatus";
    }
    return "";
}

function getGridId(id) {
    if (id === "idTradeRepair") {
        return "gridTradeRepair";
    }
    if (id === "idTradeSettlementStatus") {
        return "gridSettlementStatus";
    }
    if (id === "idTradeMatchStatus") {
        return "gridMatchedStatus";
    }
    return "";
}

function initControlPie(id) {
    if (id === "idTradeRepair") {
        initTradeRepairChart("pie");
    }
    if (id === "idTradeSettlementStatus") {
        initSettlementStatusChart("pie");
    }
    if (id === "idTradeMatchStatus") {
        initMatchedStatusChart("pie");
    }
}

function initControlColumn(id) {
    if (id === "idTradeRepair") {
        initTradeRepairChart("column");
    }
    if (id === "idTradeSettlementStatus") {
        initSettlementStatusChart("column");
    }
    if (id === "idTradeMatchStatus") {
        initMatchedStatusChart("column");
    }
}

function initControlGrid(id) {
    if (id === "idTradeRepair") {
        initTradeRepairGrid();
    }
    if (id === "idTradeSettlementStatus") {
        initSettlementStatus();
    }
    if (id === "idTradeMatchStatus") {
        initMatchedStatusGrid();
    }
}

function resizeGridChart() {
    var err = "";
    var ex;
    try {
        $("#chartSettlementStatus").css("width", "100%");
        $("#chartSettlementStatus").css("height", "200px");
        $("#chartSettlementStatus").css("overflow", "hidden");
        var chartSettlementStatus = $("#chartSettlementStatus").data("kendoChart");
        chartSettlementStatus.refresh();
    } catch (ex) {
        err = ex.message;
    }
    try {
        $("#gridSettlementStatus").css("width", "100%");
        $("#gridSettlementStatus").css("height", "200px");
        $("#gridSettlementStatus").css("overflow", "hidden");
        var gridSettlementStatus = $("#gridSettlementStatus").data("kendoGrid");
        gridSettlementStatus.refresh();
    } catch (ex) {
        err = ex.message;
    }

    try {
        $("#chartMatchedStatus").css("width", "100%");
        $("#chartMatchedStatus").css("height", "200px");
        $("#chartMatchedStatus").css("overflow", "hidden");
        var chartMatchedStatus = $("#chartMatchedStatus").data("kendoChart");
        chartMatchedStatus.refresh();
    } catch (ex) {
        err = ex.message;
    }

    try {
        $("#gridMatchedStatus").css("width", "100%");
        $("#gridMatchedStatus").css("height", "200px");
        $("#gridMatchedStatus").css("overflow", "hidden");
        var gridMatchedStatus = $("#gridMatchedStatus").data("kendoGrid");
        gridMatchedStatus.refresh();
    } catch (ex) {
        err = ex.message;
    }
    try {
        $("#chartTradeRepair").css("width", "100%");
        $("#chartTradeRepair").css("height", "200px");
        $("#chartTradeRepair").css("overflow", "hidden");
        var chartTradeRepair = $("#chartTradeRepair").data("kendoChart");
        chartTradeRepair.refresh();
    } catch (ex) {
        err = ex.message;
    }
    try {
        $("#gridTradeRepair").css("width", "100%");
        $("#gridTradeRepair").css("height", "200px");
        $("#gridTradeRepair").css("overflow", "hidden");
        var gridTradeRepair = $("#gridTradeRepair").data("kendoGrid");
        gridTradeRepair.refresh();
    } catch (ex) {
        err = ex.message;
    }
}

//Table Detail Table Generator
var ColumnDetailArray;

function headerFormating() {

}

function preprocessData(data) {
    // iterate over all the data elements replacing the Date with a version
    // that Kendo can work with.
    $.each(data, function(index, item) {
        // item.Date = kendo.parseDate(item.Date, "yyyy-MM-dd");
        if (index === "TableDetail") {

            ColumnDetailArray = item;
        }

    });
    return data;
}

function ColorAttribute(value, colorControl) {
    value = NullToString(value);
    if (value.length > 0) {
        colorControl = NullToString(colorControl);
        if (colorControl.length > 0) {
            //alert("x");
            return ColorControl(value, colorControl);
        }
    }
    return "";
}

function Format(value, type, format, link, isCheckbox) {

    value = NullToString(value);
    type = NullToString(type);
    format = NullToString(format);
    link = NullToString(link);
    isCheckbox = NullToString(isCheckbox);
    // colorControl = NullToString(colorControl);

    if (value.length)
        if (type.toLowerCase() === "date") {
            if (format.length > 0) {
                var formatV = format.replace("{0:", "").replace("}", "");

                var dateobj = kendo.parseDate(value, formatV);
                value = kendo.toString(dateobj, formatV);
                //  alert("x24");
            } else {
                var dateobjDefault = kendo.parseDate(value, "yyyy/MM/dd");
                value = kendo.toString(dateobjDefault, "MM/dd/yyyy");
                // alert("1x24");
            }
        }
    if (type.toLowerCase() === "dec") {
        if (format.length > 0) {
            try {
                format = format.replace("{0:F", "");
                format = format.replace("}", "");
                // alert(value + format);
                value = parseFloat(value).toFixed(format);
            } catch (err) {
                console.log("Format function:" + err.Message);
            }
        }
    }
    if (link.length > 0) {
        return "<a id='myLink' href='#' onClick='" + link + ";'>" + value + "</a>";
    }
    // alert(isCheckbox);
    if (isCheckbox === "True" && (value === 0 || value === 1 || value === "Yes" || value === "No" || value === "1" || value === "0")) {
        return "<input id=" + value + " type='checkbox' class='selectCheckBoxAll' disabled='disabled'  />";
    }
    if (isCheckbox === "True" && (value !== 0 || value !== 1 || value !== "Yes" || value !== "No" || value !== "1" || value !== "0")) {
        return "<input id=" + value + " type='checkbox' class='selectCheckBox' onclick=\"checkBoxTradeList('" + value + "');\"  />";

    }
    return "<span>" + value + "</span>";
}

function ColorControl(value, colorControl) {

    var newColor = "";
    if (value === "" || colorControl === "") {
        return "";
    }
    try {
        var splitColorControl = colorControl.split(";");

        for (var i = 0, length = splitColorControl.length; i < length; i++) {
            var chunk = splitColorControl[i];
            var splitColorControlValue = chunk.split(":");
            if (value === splitColorControlValue[0]) {
                newColor = "background-color:" + NullToString(splitColorControlValue[1]);
            }
        }
    } catch (err) {

        return "";
    }
    return newColor;
}

function NullToString(value) {
    if (value === null || value === "null" || value === "NULL" || value === "undefined") {
        value = "";
    }
    return value;
}

function PortNumberLink() {
    alert("Implement prot Link");
    return false;
}

function BrokerLink() {
    alert("Implement BrokerLink Link");
    return false;
}