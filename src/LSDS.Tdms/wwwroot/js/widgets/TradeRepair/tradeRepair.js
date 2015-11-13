
///Trade Repair
function testMe(val1, val2) {
    //alert(val2);
    return "<div>" + "x" + "</div>";
}

function LeftNowrapRepair(value, id) {
    return "<div align='left' style='white-space:nowrap;'><a  href='TDMSTradeRepair.aspx?desc=" + id + "' align='left' style='white-space:nowrap;' >" + value + "</a></div>";
}

//Initialize Trade Repair
function initTradeRepairChart(typeC) {

    $("#chartTradeRepair").kendoChart({
        dataSource: {
            transport: {
                type: "json",
                read: {
                    read: GetBrokerPerformanceUrl() //"Home/BrokerPerformance"
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
            type: typeC,
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

    $("#chartTradeRepair").css("width", "100%");
    $("#chartTradeRepair").css("height", ($("#idTradeRepair").height() - 50) + 'px');
    $("#chartTradeRepair").css("overflow", "hidden");
    $("#chartTradeRepair").data("kendoChart").dataSource.read();
    $("#chartTradeRepair").data("kendoChart").refresh();
    
    
}
function initTradeRepairGrid() {


    var userId = $("#userNameLable").val();
    //alert(userId);
    $.getJSON(
        GetRepairStatusDataUrl(), { source: "TradeRepairStatusModule" },
        function (myData) {
            var data = { "d": myData };
           // var data = { "d": myData[0].TableData };
           // alert(JSON.stringify(myData[0].TableData));
            $("#gridTradeRepair").kendoGrid({
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
                toolbar: kendo.template($("#tradeRepairToolBar").html()),
                height: 400,
                columns: [
                     {
                         field: 'Description', headerTemplate: "<div align='left' style='white-space:nowrap;'>Description</div>",  height: 50, sortable: 'true'
                     },
                     { field: 'Total', title: 'Count', height: 50, sortable: 'true' }

                ]
            });
        });

    //template: '#= LeftNowrapRepair(Description,QuickfindId)#',

    //$("#gridTradeRepair").kendoGrid({
    //    dataSource: {
    //        transport: {
    //            type: "json",
    //            read: {
    //                read: "Home/BrokerPerformance"
    //            }
    //        }
    //    },
    //    columns: [
    //                {
    //                    field: 'Description', headerTemplate: "<div align='left' style='white-space:nowrap;'>Description</div>", template: '#= LeftNowrapRepair(Description,QuickfindId)#', height: 50, sortable: 'true'
    //                },
    //                { field: 'Total', title: 'Total', template: '#= CenterNowrap(Total) #', height: 50, sortable: 'true' },

    //    ]
    //});
    //$('#gridTradeRepair').css('width', '100%');
    //$('#gridTradeRepair').css('height', ($("#idTradeRepair").height() - 50) + 'px');
    //$('#gridTradeRepair').css('overflow', 'hidden');
    //$('#gridTradeRepair').data('kendoGrid').dataSource.read();
    //$('#gridTradeRepair').data('kendoGrid').refresh();
  
}

/// Trade Repair Status

//ReturnQuickfindData   TradeRepairStatusModule