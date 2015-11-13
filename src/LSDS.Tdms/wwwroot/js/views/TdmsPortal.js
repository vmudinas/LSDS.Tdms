$("#WidgetsConfiguration").hide();
$("#idShowWidgets").val("Add Modules");


$(document).ready(function () {
    GetWidgetLocation(GetWigetsUrl());

});

function serialize(gridster) {
    var s = gridster.serialize();
   // alert(UpdateGridsterUrl() + "serialize" + window.CheckSecurityUrl);
    $.ajax({
        type: "POST",
        url: UpdateGridsterUrl(),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(s)
    });
}

function GetWidgetLocation(widgetLocationUrl) {
 
    $.getJSON(
          widgetLocationUrl, {},
          function (myData) {
             
          }).done(function (myData) { SetControlFromDB(myData) });

 
}

function SetControlFromDB(widgetLocation) {
  
    try {
        var errorMsg = "";
        var gridster = $(".gridster ul").gridster({
            widget_margins: [5, 5, 5, 5],
            widget_base_dimensions: [340, 310],
            draggable: {
                handle: ".title",
                stop: function (e, ui, $widget) {
                    serialize(gridster);
                }
            },
            resize: {
                enabled: true,
                start: function (e, ui, $widget) {
                    resizeGridChart();
                    serialize(gridster);
                },

                resize: function (e, ui, $widget) {
                    resizeGridChart();
                    serialize(gridster);
                },

                stop: function (e, ui, $widget) {
                    resizeGridChart();
                    serialize(gridster);
                }
            },
            min_cols: 3,
            max_cols: 4,
            max_rows: 8,
            serialize_params: function ($w, wgd) {
                return {
                    id: wgd.el[0].id,
                    col: wgd.col,
                    row: wgd.row,
                    size_x: wgd.size_x,
                    size_y: wgd.size_y,
                    htmlContent: $($w).html()
                }
            }

        }).data("gridster");


        if (typeof (widgetLocation) != "undefined" && widgetLocation != null) {
            if (widgetLocation.length > 0) {
                gridster.remove_all_widgets();

                $.each(widgetLocation, function (i, item) {
                    if (item != 'undefined') {
                        gridster.add_widget("<li>" + item.HtmlContent + "</li>", item.Size_x, item.Size_y, item.Col, item.Row);
                    }
                    else {

                        IntWidgets();
                        return false;
                    }
                });
            }
            else
            {
                IntWidgets();
            }
        } 
        else
        {

            IntWidgets();
        }

    } catch (error) {
        alert(error.message + "uuuu");
    }

}

function IntWidgets() {
    initBrokerPerformance();
    initNotificationJobStatusGrid();
    initSavedReports();
    initImportSummaryGrid();
    initTradeRepairGrid();
    initSystemStatusGrid();
    initSettlementStatus();
    initMatchedStatusGrid();
}

//$(document).on("click", "#idTradeMatchStatusList", function () {
//    EnabledDisableImg("#idTradeMatchStatusList", "#idTradeMatchStatusBar", "#idTradeMatchStatusPie");
//    initMatchedStatusGrid();
//});
//$(document).on("click", "#idTradeMatchStatusBar", function () {
//    EnabledDisableImg("#idTradeMatchStatusBar", "#idTradeMatchStatusPie", "#idTradeMatchStatusList");
//    initMatchedStatusGrid();
//});
//$(document).on("click", "#idTradeMatchStatusPie", function () {
//    EnabledDisableImg("#idTradeMatchStatusPie", "#idTradeMatchStatusList", "#idTradeMatchStatusBar");
//    initMatchedStatusGrid();
//});


//$(document).on("click", "#idTradeRepairList", function () {
//    EnabledDisableImg("#idTradeRepairList", "#idTradeRepairBar", "#idTradeRepairPie");
//});
//$(document).on("click", "#idTradeRepairBar", function () {
//    EnabledDisableImg("#idTradeRepairBar", "#idTradeRepairPie", "#idTradeRepairList");
//});
//$(document).on("click", "#idTradeRepairPie", function () {
//    EnabledDisableImg("#idTradeRepairPie", "#idTradeRepairBar", "#idTradeRepairList");
//});


//$(document).on("click", "#idTradeSettlementStatusList", function () {
//    EnabledDisableImg("#idTradeSettlementStatusList", "#idTradeSettlementStatusBar", "#idTradeSettlementStatusPie");
//});
//$(document).on("click", "#idTradeSettlementStatusBar", function () {
//    EnabledDisableImg("#idTradeSettlementStatusBar", "#idTradeSettlementStatusList", "#idTradeSettlementStatusPie");
//});
//$(document).on("click", "#idTradeSettlementStatusPie", function () {
//    EnabledDisableImg("#idTradeSettlementStatusPie", "#idTradeSettlementStatusBar", "#idTradeSettlementStatusList");
//});

function EnabledDisableImg(controlIdSelected, control2, control3) {
    $(controlIdSelected).attr("src", $(controlIdSelected).attr("src").replace("_on_", "_off_"));
    $(control2).attr("src", $(control2).attr("src").replace("_off_", "_on_"));
    $(control3).attr("src", $(control3).attr("src").replace("_off_", "_on_"));
}

//$("#brokerPerformanceTimePeriodSelect").change(function () {
//    initBrokerPerformance(this.value);

//});
//$("#brokerPerformancePreferableDaySelect").change(function () {
//    initBrokerPerformance($("#brokerPerformanceTimePeriodSelect option:selected").val());

//});

//// hideEdits();

//// setControlFromDB();

// alert("t");
// initBrokerPerformance($("#brokerPerformanceTimePeriodSelect option:selected").val());
// //initImportSummaryGrid($("#idImportDays option:selected").val());
// initNotificationJobStatusGrid();
// //initSavedReports();
// //initSettlementStatus();
// //initSystemStatusGrid();
// //initMatchedStatusGrid();
// //initTradeRepairGrid();

// $("#importSummaryEditLabel").click(function () {

//     hideEdit("widgetEdithideImportSummary", "gridImportSummary", "x", "importSummaryEditLabel", "idImportSummary", "pickerImportSummary");
// });

// $("#tradeRepairStatusEditLabel").click(function () {
//     hideEdit("widgetEdithideTradeRepairStatus", "gridTradeRepair", "chartTradeRepair", "tradeRepairStatusEditLabel", "idTradeRepair", "pickerTradeRepair");
//     resizeGridChart();
// });


// $("#idTradeRepairList").click(function () {
//     initTradeRepairGrid();
//     $("#idTradeRepairList").attr("src", "images/list_off_20.png");
//     $("#idTradeRepairBar").attr("src", "images/bar_on_20.png");
//     $("#idTradeRepairPie").attr("src", "images/pie_on_20.png");
//     $("#chartTradeRepair").hide();
//     $("#gridTradeRepair").show();
//     resizeGridChart();
// });
// $("#idTradeRepairBar").click(function () {
//     $("#gridTradeRepair").hide();
//     $("#idTradeRepairBar").attr("src", "images/bar_off_20.png");
//     $("#idTradeRepairList").attr("src", "images/list_on_20.png");
//     $("#idTradeRepairPie").attr("src", "images/pie_on_20.png");
//     $("#chartTradeRepair").show();
//     initTradeRepairChart("column");
//     resizeGridChart();

// });
// $("#idTradeRepairPie").click(function () {

//     //quickfindIds, totals, txnSide, notifyType
//     $("#gridTradeRepair").hide();
//     $("#idTradeRepairPie").attr("src", "images/pie_off_20.png");
//     $("#idTradeRepairBar").attr("src", "images/bar_on_20.png");
//     $("#idTradeRepairList").attr("src", "images/list_on_20.png");
//     $("#chartTradeRepair").show();
//     initTradeRepairChart("pie");
//     resizeGridChart();

// });


// $("#matchStatusEditLabel").click(function () {
//     hideEdit("widgetEdithideMatchStatus", "gridMatchedStatus", "chartMatchedStatus", "matchStatusEditLabel", "idTradeMatchStatus", "pickerTradeMatchStatus");
//     resizeGridChart();
// });

// $("#idTradeMatchStatusList").click(function () {
//     //  $("#chart").remove();
//     initMatchedStatusGrid();
//     $("#idTradeMatchStatusList").attr("src", "images/list_off_20.png");
//     $("#idTradeMatchStatusBar").attr("src", "images/bar_on_20.png");
//     $("#idTradeMatchStatusPie").attr("src", "images/pie_on_20.png");
//     $("#chartMatchedStatus").hide();
//     $("#gridMatchedStatus").show();

//     resizeGridChart();
// });
// $("#idTradeMatchStatusBar").click(function () {

//     initMatchedStatusChart("pie");

//     $("#idTradeMatchStatusBar").attr("src", "images/bar_off_20.png");
//     $("#idTradeMatchStatusList").attr("src", "images/list_on_20.png");
//     $("#idTradeMatchStatusPie").attr("src", "images/pie_on_20.png");

//     $("#chartMatchedStatus").show();
//     $("#gridMatchedStatus").hide();
//     var chart = $("#chartMatchedStatus").data("kendoChart");
//     // Change type for first serie
//     chart.options.series[0].type = "column";
//     // Finally refresh chart
//     resizeGridChart();

// });
// $("#idTradeMatchStatusPie").click(function () {
//     //quickfindIds, totals, txnSide, notifyType
//     initMatchedStatusChart("pie");

//     $("#idTradeMatchStatusPie").attr("src", "images/pie_off_20.png");
//     $("#idTradeMatchStatusBar").attr("src", "images/bar_on_20.png");
//     $("#idTradeMatchStatusList").attr("src", "images/list_on_20.png");
//     $("#chartMatchedStatus").show();
//     $("#gridMatchedStatus").hide();
//     resizeGridChart();

// });


// $("#systemStatusEditLabel").click(function () {
//     hideEdit("widgetEdithideSystemStatus", "gridSystemStatus", "btnRunNowSystemStaus", "systemStatusEditLabel", "idSystemStatus", "pickerSysStatus");
// });

// $(".MainChckSystemStatus").click(function () {
//     $(".systenStatusRun").each(function () {

//         if ($(".MainChckSystemStatus").is(":checked")) {
//             $(this).prop("checked", true);

//         } else {
//             $(this).prop("checked", false);

//         }

//     });

// });

// $("#tradeSettlementStatusEditLabel").click(function () {

//     hideEdit("widgetEdithidTradeSettlementStatus", "gridSettlementStatus", "chartSettlementStatus", "tradeSettlementStatusEditLabel", "idTradeSettlementStatus", "pickerSettlementStatus");

//     resizeGridChart();
// });


// $("#idTradeSettlementStatusList").click(function () {
//     initSettlementStatus();

//     $("#idTradeSettlementStatusList").attr("src", "images/list_off_20.png");
//     $("#idTradeSettlementStatusBar").attr("src", "images/bar_on_20.png");
//     $("#idTradeSettlementStatusPie").attr("src", "images/pie_on_20.png");
//     $("#chartSettlementStatus").hide();
//     $("#gridSettlementStatus").show();
//     resizeGridChart();
// });
// $("#idTradeSettlementStatusBar").click(function () {

//     $("#gridSettlementStatus").hide();
//     $("#idTradeSettlementStatusBar").attr("src", "images/bar_off_20.png");
//     $("#idTradeSettlementStatusList").attr("src", "images/list_on_20.png");
//     $("#idTradeSettlementStatusPie").attr("src", "images/pie_on_20.png");
//     $("#chartSettlementStatus").show();
//     initSettlementStatusChart("column");
//     resizeGridChart();
// });
// $("#idTradeSettlementStatusPie").click(function () {

//     //quickfindIds, totals, txnSide, notifyType
//     $("#gridSettlementStatus").hide();
//     $("#idTradeSettlementStatusPie").attr("src", "images/pie_off_20.png");
//     $("#idTradeSettlementStatusBar").attr("src", "images/bar_on_20.png");
//     $("#idTradeSettlementStatusList").attr("src", "images/list_on_20.png");
//     $("#chartSettlementStatus").show();
//     initSettlementStatusChart("pie");
//     resizeGridChart();
// });

// $("#savedReportEditLabel").click(function () {
//     hideEdit("widgetEdithideSavedReports", "gridSavedReports", "chartSavedReport", "savedReportEditLabel", "idSavedReports", "pickerSavedReports");
// });

// $("#notificationStatusEditLabel").click(function () {
//     hideEdit("widgetEdithideNotificationStatus", "gridNotificationJobStatus", "btnRunNowNotificationJobStatus", "notificationStatusEditLabel", "idNotificationJobStatus", "pickerNotificationJobStatus");
// });


// $("#brokerPerformanceEditLabel").click(function () {
//     hideEdit("widgetEdithideBrokerPerformance", "gridBrokerPerformance", "chartBrokerPerformance", "brokerPerformanceEditLabel", "idBrokerPreformance", "pickerBrokerPreformance");
// });

// $("#brokerPerformanceTimePeriodSelect").change(function () {
//     initBrokerPerformance(this.value);

// });
// $("#brokerPerformancePreferableDaySelect").change(function () {
//     initBrokerPerformance($("#brokerPerformanceTimePeriodSelect option:selected").val());

// });

// var ids = "";

// $(".MainChck").click(function () {

//     var mainCheckbox = $("#idNotificationJobStatusRunAllNow").attr("checked");
//     if (typeof mainCheckbox == "undefined") {
//         mainCheckbox = "";
//     }

//     ids = "";
//     var add = "";
//     $("[name="checkBoxNotif"]").each(function () {

//         add = this.id + ",";
//         $(this).attr("checked", mainCheckbox);
//         if (!mainCheckbox) {
//             ids = ids + add;
//         }
//         else { ids = ""; }
//     })
//     window.idsMain = ids;


// });

// $(".RunNowChck").click(function () {
//     var add = this.id + ",";
//     if (this.checked) {
//         ids = ids + add;
//     }
//     else {

//         ids = ids.replace(add, "");
//     }
//     window.idsMain = ids;
// });

// $(".k-grid-header").click(function () {
//     CheckBoxes(ids);
// });
// var tid = setInterval(mycode, 2000);
// function mycode() {
//     if (typeof (window.idsMain) != "undefined" && window.idsMain != null) {
//         CheckBoxes(window.idsMain);
//     }
//     else if (typeof (ids) != "undefined" && ids != null) {
//         CheckBoxes(ids);
//     }
// }

// $("idImportDays").change(function () {
//     initImportSummaryGrid(this.value);
// });
//});

function setIdImg(id, value) {


    if (id === "idTradeRepair" || id === "idTradeSettlementStatus" || id === "idTradeMatchStatus") {
        try {
            if (value === "1") {
                $("#" + id + "Pie").prop("src", window.contentImages + "pie_off_20.png");
                showChart(getGridId(id), getChartId(id), "pie");
                initControlPie(id);

            }
            if (value === "2") {
                $("#" + id + "List").prop("src", window.contentImages + "list_off_20.png");
                showListChart(getGridId(id), getChartId(id), "list");
                initControlGrid(id);

            }
            if (value === "3") {
                $("#" + id + "Bar").prop("src", window.contentImages + "bar_off_20.png");
                showChart(getGridId(id), getChartId(id), "column");
                initControlColumn(id);

            }
        }
        catch (err) {
            //console.log(err);
        }
    }
}