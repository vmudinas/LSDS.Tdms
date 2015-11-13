/// Broker Performance
/// <reference path="~/Scripts/jquery-2.1.4.js" />
function brokerChangeTime(value) {
   // alert();
    initBrokerPerformance($("#brokerPerformanceTimePeriodSelect :selected").val());
}
function brokerChangeDays(value) {
    // alert($('#brokerPerformancePreferableDaySelect :selected').text());
    initBrokerPerformance($("#brokerPerformanceTimePeriodSelect :selected").val());
    $("#gridBrokerPerformance").data('kendoGrid').refresh();
}

//Initiate Broker Performance grid
function initBrokerPerformance() {
    // Default timePeriod 12
    //var timePeriod = "12";
   // alert($('#brokerPerformanceTimePeriodSelect :selected').val());
                $.getJSON(
                GetBrokerPerformanceUrl(), { time: $('#brokerPerformanceTimePeriodSelect option:selected').val() },
                function (myData) {
            var data = { "d": myData };


                        $("#gridBrokerPerformance").kendoGrid({
                        dataSource: {
                            data: data,
                            schema: {
                                data: "d",
                                type: 'json',
                                model: {
                                    id: "tblBrokerPerformanceId",
                                    fields: {
                                        BrokerCode: { type: "string" },
                                        AccountNumber: { type: "string" },
                                        AvgDaysToMatch: { type: "string" },
                                        TotalTrades: { type: "string" }
                                    }
                                }
                            }
                        },
                        toolbar: kendo.template($("#brokerToolBar").html()),
                        height: 400,
                        columns: [
                            { field: "BrokerCode", title: "Broker Code", headerTemplate: "<div align='left' style='white-space:nowrap;'>Broker Code</div>", template: "#= LeftNowrap(brokerPreformancePreferableDays(BrokerCode,AvgDaysToMatch))#", sortable: 'true' },
                            { field: "AccountNumber", title: "Account", template: "#= brokerPreformancePreferableDays(AccountNumber,AvgDaysToMatch)#", sortable: "true" },
                            { field: "AvgDaysToMatch", title: "Avg Days to Match", template: "#= brokerPreformancePreferableDays(AvgDaysToMatch,AvgDaysToMatch)#", sortable: "true" },
                            { field: "TotalTrades", title: "Trades", template: "#= brokerPreformancePreferableDays(TotalTrades,AvgDaysToMatch)#", sortable: "true" }
                        ]
                        });

                });

        }


function BrokerPerformanceCheckBox(tblBrokerPerformanceId) {
    return "<div><input type=\'checkbox\'  style=\'text-align:center;\' id=\'idBrokerPerformance" + tblBrokerPerformanceId + "\' class=\'MainChckBrokerPerfornace\' /></div>";

}
function brokerPreformancePreferableDays(value, avgDays) {
   // alert(avgDays + $('#brokerPerformanceTimePeriodSelect :selected').val() + $('#brokerPerformancePreferableDaySelect :selected').val());
    if (avgDays > $('#brokerPerformancePreferableDaySelect :selected').val()) {
        return "<span style='color:red;'>" + value + "</span>";
    }
    else {
        return "<span style='color:green;'>" + value + "</span>";
    }
}
