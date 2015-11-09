$(document).ready(function() {


    //$("#responsive-panel").kendoResponsivePanel({
    //    breakpoint: 768,
    //    autoClose: false,
    //    orientation: "top"
    //});
   
   // CheckSecurity(GetCheckSecurityUrl(), GetTdmsPortalUrl());
    GetUserLocation(GetLocationListUrl());

});



function isDefined(variable) {
    if (variable === "" || variable === "undefined" || variable === undefined || variable === null) {
        return false;
    }
    return true;
}

function CheckSecurity(userLocationPath, home) {
   
    $.getJSON(
        userLocationPath, {  },
        function(myData) {
            if (!myData)
            if (myData.length !== 0) {
                var error = "";

                if (myData.result.length > 0) {

                    try {
                        if (myData.result[0].item_edit !== "" || myData.result[0].item_edit !== "undefined" || myData.result[0].item_edit !== undefined || myData.result[0].item_edit !== null) {

                            if (myData.result[0].item_view === 0) {
                                window.location = home;
                            }

                        }
                    } catch (err) {
                        error = err.Message;
                    }

                    try {
                        if (myData.result[0].item_edit !== "" || myData.result[0].item_edit !== "undefined" || myData.result[0].item_edit !== undefined || myData.result[0].item_edit !== null) {
                            if (myData.result[0].item_edit === 0) {
                                $(":input").attr("disabled", "disabled");
                            }

                        }
                    } catch (err) {
                        error = err.Message;
                    }
                }
            }
        });

}

function getFullUserName() {
    var userFullNamePath = window.GetUserFullName;
    $.getJSON(
        userFullNamePath, {},
        function(myData) {
            $("#userNameFull").text(myData[0].description);
        });
}

function getLastLogin() {
    //var userLastLoginPath = window.GetUserLastLogin;
    //$.getJSON(
    //    userLastLoginPath, {},
    //    function(myData) {
    //        $("#userLastLogin").text("Last Login: " + myData);
    //    });
}

function GetUserLocation(userLocationPath) {
    
    $.getJSON(
        userLocationPath, {},
        function(myData) {
            $.each(myData, function(i, value) {
                if (value.Selected) {
                    $("#headerLocationSelect").append($("<option selected >").text(value.User_Group_Description).attr("value", value.tdUserGroupID));
                } else {
                    $("#headerLocationSelect").append($("<option  >").text(value.User_Group_Description).attr("value", value.tdUserGroupID));
                }
            });
        });
}

function intHomeScreen() {
    initBrokerPerformance();
    initNotificationJobStatusGrid();
    initSavedReports();
    initImportSummaryGrid();
    initTradeRepairGrid();
    initSystemStatusGrid();
    initSettlementStatus();
    initMatchedStatusGrid();
}

function updateUserLocation() {
    var selectedValue = $("#headerLocationSelect option:selected").val();

    var userLocationPath = window.UpdateLocationList;
    $.getJSON(
        userLocationPath, { tdUserGroupId: selectedValue },
        function(myData) {

            if (window.location.pathname.indexOf("TradeList") > -1) {
                window.getTableDetailTradeView();
                alert("Location Changed to: " + $("#headerLocationSelect option:selected").text());
            } else if (window.location.pathname.indexOf("TdmsPortal") > -1) {
                intHomeScreen();
                alert("Location Changed to: " + $("#headerLocationSelect option:selected").text());
            } else {
                alert("Location is changed. Please make sure path is set correctly");
            }
        });
}

function onclick(e) {
    $("#responsive-panel").getKendoResponsivePanel().toggle();
}

function quickFindRefresh() {
    try {
        $("#quickFindPopup input").each(function() {

            $(this).val("");
        });
    } catch (err) {
    }
    var dropdownlistfind = $("#searchSelect").data("kendoDropDownList");
    dropdownlistfind.text("Last Search");
    dropdownlistfind.refresh();
}

function quickSortRefresh() {
    try {
        $("#quickSortPopup input").each(function() {

            $(this).val("");

        });
    } catch (err) {
    }
    var dropdownlist = $("#sortSelect").data("kendoDropDownList");
    dropdownlist.text("Select Sort");
    dropdownlist.refresh();
    $("#ddlSelectView").find("option[text=\"Select Sort\"]").val();

}

function quickFindClose() {
    var dropdownlistfind = $("#searchSelect").data("kendoDropDownList");
    dropdownlistfind.text("Last Search");
    dropdownlistfind.refresh();
}

function quickSortClose() {
    var dropdownlist = $("#sortSelect").data("kendoDropDownList");
    dropdownlist.text("Select Sort");
    dropdownlist.refresh();
    $("#ddlSelectView").find("option[text=\"Select Sort\"]").val();
}
