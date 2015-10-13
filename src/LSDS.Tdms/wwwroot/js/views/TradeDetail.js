$(function () {

    $('input[type=text]').each(function () {

        if ($(this).attr("data_bind")) {
            $(this).attr("readonly", "true");
            $(this).css("background-color", "#DEDEDE");
        }
        if ($(this).hasClass("classReadOnly")) {
            $(this).attr("readonly", "true");
        }
    });

    GetNotifyList(TradeNotifyListUrl());
    GetRepairTable(TradeRepairLogUrl());
});

function GetNotifyList(notifyUrl) {

    $.getJSON(
        notifyUrl, { tdTradet: $("#tdTrade").val() },
        function (myData) {

        }).done(function (myData) { SetNotifyListFromDB(myData) });


}
function GetRepairTable(TradeRepairLogUrl) {

    $.getJSON(
        TradeRepairLogUrl, { tdTradet: $("#tdTrade").val() },
        function (myData) {

        }).done(function (myData) { GetTradeRepairLog(myData) });


}
function GetTradeRepairLog(dTradeRepairLog) {
  
    $("#tradeHistoryGrid").kendoGrid({
        dataSource: {
            data: dTradeRepairLog,
            schema: {
                type: 'json',
                model: {
                    id: "tdTradeRepairLog",
                    fields: {
                        RepairType: { type: "string" },
                        RepairDescription: { type: "string" },
                        RepairedDate: { type: "string" },
                        RepairedBy: { type: "string" }
                    }
                }
            }
        },
        height: 200,
        columns: [
            { field: "RepairType", title: "Type", template: "<div>#= RepairType#</div>" },
            { field: "RepairDescription", title: "Description", template: "<div>#= RepairDescription#</div>" },
            { field: "RepairedDate", title: "Date", template: "<div>#= GetJsonDate(RepairedDate)#</div>" },
            { field: "RepairedBy", title: "User", template: "<div>#= RepairedBy#</div>" }
        ]
    });

}

function SetNotifyListFromDB(dataDb) {
    $("#notifyListView").kendoListView({
        dataSource: {
            data: dataDb,
            schema: {
                type: "json",
                model: {
                    id: "ShawPortNo",
                    fields: {
                        ContactTypeDesc: { type: "string" },
                        TransportDesc: { type: "string" },
                        date_time: { type: "date" }
                    }
                }
            }
        },
        template: '<div class="custNotifyClass"><div class="custStyle">#= ContactTypeDesc #</div>   <div class="classNotifyContactName">#=returnNoName(contact_name)#<div>   #= contact_company #  <div class="custNSentBy">  Sent By:' + GetLink("#= TransportDesc #", "#=Fax_File_Name_Local#", "#=iomessageLog#") + '  on: #= date_time # </div> </div>'
    });
}

function GetLink(name, strFileName, logId) {

    return "<a href='" + GetDownloadBlog() + "/?strFileName=" + strFileName + "&logId=" + logId + "'  download >" + name + "</a>";

}
function returnNoName(value) {

    if (value.trim().length > 0) {
        return value;
    }
    // console.log(value);
    return "No Contact Name Available";

}
var monthNames = [
    "January", "February", "March", "April", "May", "June",
    "July", "August", "September", "October", "November", "December"
];

function GetJsonDate(date) {
    if (date == null || date === "undefined" || date === "" || !date.trim()) {
        return "";
    }
    if (date.indexOf("Date") > -1) {
        console.log(date);
        try {
            var value = new Date
            (
                parseInt(date.replace(/(^.*\()|([+-].*$)/g, ''))
            );
            var dat = value.getDate() +
                1 +
                " " +
                monthNames[value.getMonth()] +
                " " +
                value.getFullYear();

            return dat;
        } catch (err) {
            //  console.log(err.Message);
        }

        return "";
    } else {
        console.log("a" + date);
        var d = convertToJSONDate(date);
        console.log(d);
        try {
            var valueD = new Date
            (
                parseInt(d.replace(/(^.*\()|([+-].*$)/g, ''))
            );
            var dateN = valueD.getDate() +
                1 +
                " " +
                monthNames[valueD.getMonth()] +
                " " +
                valueD.getFullYear();

            return dateN;
        } catch (err) {
            //  console.log(err.Message);
        }
    }


    return date;
}

function convertToJSONDate(strDate) {
    try {
        var splitted = strDate.split("/");
        var dt = new Date(splitted[2], splitted[0], splitted[1]);
        var newDate = new Date(Date.UTC(dt.getFullYear(), dt.getMonth(), dt.getDate(), dt.getHours(), dt.getMinutes(), dt.getSeconds(), dt.getMilliseconds()));
        return '/Date(' + newDate.getTime() + ')/';
    } catch (e) {

    }
    return strDate;
}
