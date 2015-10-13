/// Settlement Status
//Initiate Settlement status grid
function initSettlementStatus() {
    
    var userId = $("#userNameLable").val();
    $.getJSON(
        "RepairStatusData", { source: "TradeSettlementStatusModule", userId: userId, totals: $(".settlementTotal").is(':checked'), txnSide: $(".settlemenetTxtSide").is(':checked'), notifyType: $(".settlementNotifyType").is(':checked') },
        function(myData) {
            //var data = { "d": myData[0].TableData };
            var data = { "d": myData };
            $("#gridSettlementStatus").kendoGrid({
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
                toolbar: kendo.template($("#tradeSettlemtToolBar").html()),
                height: 400,
                columns: [
                    {
                        field: 'Description', headerTemplate: "<div align='left' style='white-space:nowrap;'>Description</div>", height: 50, sortable: 'true'
                    },
                    { field: 'Total', title: 'Total', height: 50, sortable: 'true' }

                ]
            });
        });

}
function LeftNowrapSettlement(value,id) {
    return "<div align='left' style='white-space:nowrap;'><a href='\TradeList.aspx?id=" + id + "' align='left' style='white-space:nowrap;' >" + value + "</a></div>";
   }
function initSettlementStatusChart(chartType) {


    var totals = $(".settlementTotal").is(':checked');
    var txnSide = $(".settlemenetTxtSide").is(':checked');
    var notifyType = $(".settlementNotifyType").is(':checked');
    var quickfindIds = "1";
    $("#chartSettlementStatus").kendoChart({
        dataSource: {
            transport: {
                read: {
                    async: true,
                    url: "TDMS_AJAX_response.asmx/ReturnSettlementStatusJson?totals=" + totals + "&txnSide=" + txnSide + "&notifyType=" + notifyType,
                    dataType: "json"
                }
            }
        },
        legend: {
            visible: true,
            position: "bottom"
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
            type: chartType,
            startAngle: 20,
            field: "Total",
            categoryField: "Description",
            padding: 0,
            explodeField: "explode",
            overlay: {
                gradient: "roundedBevel"
            }
        }],
        categoryAxis: [{            
            template: "#=category# ( #=value# )",
            labels: {
                font: "7pt Arial Narrow bold",
                padding: {
                    bottom: 1
                },
                rotation: 45
            }
        }],
        seriesClick: function (e) {
            
        },
        tooltip: {
            visible: true,
            template: "<div style='white-space: normal; max-width: 120px;overflow:visible;'>${ category } - ${ value }</div>"
        }
    });

    $('#chartSettlementStatus').css('width', '100%');
    $('#chartSettlementStatus').css('height', ($("#idTradeSettlementStatus").height() - 50) + 'px');
    $('#chartSettlementStatus').css('overflow', 'hidden');
    $('#chartSettlementStatus').data('kendoChart').dataSource.read();
    $('#chartSettlementStatus').data('kendoChart').refresh();
}
