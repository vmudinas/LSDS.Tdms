/// MatchedStatus
/// <reference path="~/Scripts/jquery-2.0.3.intellisense.js" />
//function initMatchedStatusChart(typeC) {
//    var totals = $("#idTotals").is(':checked');
//    var txnSide = $("#idTxnSide").is(':checked');
//    var notifyType = $("#idNotifyType").is(':checked');

//$("#chartMatchedStatus").kendoChart({
////dataSource: {
////transport: {
////type: "json",
////read: {
////read: "Home/BrokerPerformance"
////}
////}
////},
//legend: {
//visible: false,
//position: "bottom"
//},
//seriesDefaults: {
//labels: {
//rotation: 0,
//visible: false,
//template: "#=category# ( #=value# )",
//background: "transparent",
//alignType: "circle",
//margin: {
//top: 0,
//left: 0,
//right: 0,
//bottom: 0
//},
//overflow: "visible"
//}
//},
//seriesColors: ["#4A799C", "#84CFEF", "#9de219", "#90cc38", "#068c35", "#006634", "#004d38", "#033939"],
//series: [{
//type: typeC,
//startAngle: 20,
//field: "Total",
//categoryField: "Description",
//padding: 0,
//explodeField: "explode",
//overlay: {
//gradient: "roundedBevel"
//}
//}
//],
//categoryAxis: [{
//template: "#=category# ( #=value# )",
//labels: {
//font: "7pt Arial Narrow bold",
//padding: {
//bottom: 1
//},
//rotation: 45
//}
//}
//],
//seriesClick: function (e) {
//},
//tooltip: {
//visible: true,
//template: "<div style='white-space: normal; max-width: 120px;overflow:visible;'>${ category } - ${ value }</div>"
//}
//                                        });
//    $('#chartMatchedStatus').data('kendoChart').dataSource.read();
//    $('#chartMatchedStatus').data('kendoChart').refresh();
//    $('#chartMatchedStatus').css('width', '100%');
//    $('#chartMatchedStatus').css('height', ($("#idTradeMatchStatus").height() - 50) + 'px');
//    $('#chartMatchedStatus').css('overflow', 'hidden');
//}
function NowrapTradeMatchStatus(value, id) {
    return "<div align='left' style='white-space:nowrap;'><a href='\TradeList.aspx?id=" + id + "' align='left' style='white-space:nowrap;' >" + value + "</a></div>";
}
//source, string userId, bool totals = true, bool txnSide = true, bool notifyType
function initMatchedStatusGrid() {
  //  $("gridMatchedStatus").css("visibility","visible");
   // $("chartMatchedStatus").css("visibility", "hidden");
    var userId = $("#userNameLable").val();
    $.getJSON(
       GetRepairStatusDataUrl(), { source: "TradeMatchStatusModule",  totals: $("#idTotals").is(':checked'), txnSide: $("#idTxnSide").is(':checked'), notifyType: $("#idNotifyType").is(':checked') },
        function(myData) {
           // var data = { "d": myData[0].TableData };
            var data = { "d": myData };

            $("#gridMatchedStatus").kendoGrid({
                dataSource: {
                    data: data,
                    schema: {
                        data: "d",
                        type: 'json',
                        model: {
                            id: "RepairTypeDataId",
                            fields: {
                                QuickfindId: { type: "string" },
                                Description: { type: "string" },
                                RepairType: { type: "string" },
                                Total: { type: "string" }
                            }
                        }
                    }
                },
                toolbar: kendo.template($("#tradeMatchToolBar").html()),
                height: 400,
                columns: [
                   {
                       field: 'Description', headerTemplate: "<div align='left' style='white-space:nowrap;'>Description</div>", height: 50, sortable: 'true'
                   },
                   { field: 'Total', title: 'Total', height: 50, sortable: 'true' }

                ]
            });

            //$("#gridMatchedStatus").kendoChart({
            //    dataSource: {
            //        data: data,
            //        schema: {
            //            data: "d",
            //            type: 'json',
            //            model: {
            //                id: "RepairTypeDataId",
            //                fields: {
            //                    QuickfindId: { type: "string" },
            //                    Description: { type: "string" },
            //                    RepairType: { type: "string" },
            //                    Total: { type: "string" }
            //                }
            //            }
            //        }
            //    },
            //    toolbar: kendo.template($("#tradeMatchToolBar").html()),
            //    height: 400,
            //    legend: {
            //        position: "top"
            //    },
            //    seriesDefaults: {
            //        labels: {
            //            rotation: 0,
            //            visible: false,
            //            template: "#=category# ( #=value# )",
            //            background: "transparent",
            //            alignType: "circle",
            //            margin: {
            //                top: 0,
            //                left: 0,
            //                right: 0,
            //                bottom: 0
            //            },
            //            overflow: "visible"
            //        }
            //    },
            //    seriesColors: ["#4A799C", "#84CFEF", "#9de219", "#90cc38", "#068c35", "#006634", "#004d38", "#033939"],
            //    series: [{
            //        type: "bar",
            //        startAngle: 0,
            //        field: "Total",
            //        categoryField: "Description",
            //        padding: 0,
            //        explodeField: "explode",
            //        overlay: {
            //            gradient: "roundedBevel"
            //        }
            //    }
            //    ],
            //    categoryAxis: [{
            //        template: "#=category# ( #=value# )",
            //        labels: {
            //            font: "7pt Arial Narrow bold",
            //            padding: {
            //                bottom: 1
            //            },
            //            rotation: 0
            //        }
            //    }
            //    ],
            //    seriesClick: function (e) {
            //    },
            //    tooltip: {
            //        visible: true,
            //        template: "<div style='white-space: normal; max-width: 120px;overflow:visible;'>${ category } - ${ value }</div>"
            //    }
            //});
        });
}
function initMatchedStatusChart() {
    $("chartMatchedStatus").css("visibility", "visible");
    $("gridMatchedStatus").css("visibility", "hidden");
    var userId = $("#userNameLable").val();
    $.getJSON(
        GetRepairStatusDataUrl(), { source: "TradeMatchStatusModule",  totals: $("#idTotals").is(':checked'), txnSide: $("#idTxnSide").is(':checked'), notifyType: $("#idNotifyType").is(':checked') },
        function (myData) {
            //var data = { "d": myData[0].TableData };
            var data = { "d": myData };
            $("#chartMatchedStatus").kendoChart({
                dataSource: {
                    data: data,
                    schema: {
                        data: "d",
                        type: 'json',
                        model: {
                            id: "RepairTypeDataId",
                            fields: {
                                QuickfindId: { type: "string" },
                                Description: { type: "string" },
                                RepairType: { type: "string" },
                                Total: { type: "string" }
                            }
                        }
                    }
                },
                legend: {
                    position: "top"
                },
                seriesDefaults: {
                    labels: {
                        rotation: 0,
                        visible: false,
                        template: "#=category# ( #=value# )",
                        background: "transparent",
                        alignType: "circle",
                        margin: {
                            top: 0,
                            left: 0,
                            right: 0,
                            bottom: 0
                        },
                        overflow: "visible"
                    }
                },
                seriesColors: ["#4A799C", "#84CFEF", "#9de219", "#90cc38", "#068c35", "#006634", "#004d38", "#033939"],
                series: [{
                    type: "bar",
                    startAngle: 0,
                    field: "Total",
                    categoryField: "Description",
                    padding: 0,
                    explodeField: "explode",
                    overlay: {
                        gradient: "roundedBevel"
                    }
                }
                ],
                categoryAxis: [{
                    template: "#=category# ( #=value# )",
                    labels: {
                        font: "7pt Arial Narrow bold",
                        padding: {
                            bottom: 1
                        },
                        rotation: 0
                    }
                }
                ],
                seriesClick: function (e) {
                },
                tooltip: {
                    visible: true,
                    template: "<div style='white-space: normal; max-width: 120px;overflow:visible;'>${ category } - ${ value }</div>"
                }
            });
        });
}