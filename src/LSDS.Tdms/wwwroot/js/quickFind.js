
$(document).ready(function() {
    /*
    var quickSortData;
    var userId = $("#userNameLable").val();
    $.getJSON(
          "/QuickSort/ReturnSortName", { userName: userId, source: "TradeBrowser" },
          function (myData) {
              var mySelect = $("#ddlSelectView");
              quickSortData = myData;
              $.each(myData, function () {
                  if (this.Description !== "Last Sort") {
                      mySelect.append(
                          $("<option></option>").val(this.QuickSortID).html(this.Description)
                      );
                  }
              });
          });


    $("#ddlSelectView").on("change", function () {
        $("#sortable").empty();
        
        $.each($("*"), function() {
            $(this).prop("checked", false);
            });
        if ($("#ddlSelectView option:selected").text() !== "Select Sort") {
            $("#idSaveQuickSort").val($("#ddlSelectView option:selected").text());
            $(".quickSortIdclass").val($("#ddlSelectView option:selected").val());

            $.each(quickSortData, function () {
                //alert(this.LastUsedToday);
                
                if (this.Description === $("#ddlSelectView option:selected").text()) {
                    // $(".defaultSortCheckbox").attr("checked", this.LastUsedToday);
                    if (this.LastUsedToday === 1) {
                        $(".defaultSortCheckbox").prop("checked", true);
                    } else {
                        $(".defaultSortCheckbox").prop("checked", false);
                    }
                    var arr = this.QuickSort_Query.split(",");
                    $.each(arr, function (number) {
                      
                        var arrClass = arr[number].split(' ');
                        $("#" + arrClass[0]).attr("checked", "checked");
                        $.each($("." + arrClass[0]), function () {
                            if (arrClass[1] === $(this).val()) {
                                $(this).prop("checked", true);
                                $("#sortable").append("<li id='" + arrClass[0] + arrClass[1] + "'>" + $(this).attr("name") + " " + arrClass[1] + "</li>");
                            }
                        });
                    });
                }
            });
        } else {
            $("#idSaveQuickSort").val("");
            $("#idSaveQuickSortID").val(-1);
           
        }
    });

    $("#idSaveQuickSortBtn").on("click", function() {
        var tempSortValue = "";
       
        var listItems = $("#sortable li");
        listItems.each(function (idx, li) {
            tempSortValue =  tempSortValue + $(li).attr("id");
        });
      
        $("#idsortValues").val(tempSortValue);
    });
    $("#sortable").kendoSortable({

    });
    $("#quickFindCancel").on("click", function() {
        $("#quickFindPopup").data("kendoWindow").close();
    });
    $("#quickSortCancel").on("click", function () {
        //$("#quickSortPopup").data("kendoWindow").close();
        if ($("#ddlSelectView option:selected").text() !== "Select Sort") {
            //var userId = $("#userNameLable").val();
            $.getJSON(
                "/QuickSort/DeleteSort", { sortId: $("#ddlSelectView option:selected").val() },
                function(myData) {
                    alert($("#ddlSelectView option:selected").text() + " deleted");
                    location.reload();
                });

          
        } else {
            alert("Please select sort to delete.");
        }


    });
    */
    var err;
    try {
        $(".firstDate").attr("width", "");
    } catch (err) {
        console.log(err.Message);

    }
    try {
        $(".firstDate").attr("css", "");
    } catch (er2R) {
        console.log(er2R.Message);
    }
    try {
        $(".rangeSelector").on("change", function(e) {
            if ($(this).val() === "Range") {

                $(".rangeHidden" + $(this).attr("id")).show();
            } else {
                $(".rangeHidden" + $(this).attr("id")).val("");
                $(".rangeHidden" + $(this).attr("id")).hide();
            }
        });
    } catch (err) {
        console.log(err.Message);
    }
    tryReturnTraded();
    tryReturnTradeDate();
    tryReturnSettlement();
    tryReturnTransactionLoadDate();
    tryReturnFunctionD();
});

function tryReturnTraded() {
    try {
        var start;
        var end;

        function startChange() {
            var startDate = start.value(),
                endDate = end.value();

            if (startDate) {
                startDate = new Date(startDate);
                startDate.setDate(startDate.getDate());
                end.min(startDate);
            } else if (endDate) {
                start.max(new Date(endDate));
            } else {
                endDate = new Date();
                start.max(endDate);
                end.min(endDate);
            }
        }

        start = $("#dateTraded").kendoDatePicker({
            change: startChange
        }).data("kendoDatePicker");

        function endChange() {
            var endDate = end.value(),
                startDate = start.value();

            if (endDate) {
                endDate = new Date(endDate);
                endDate.setDate(endDate.getDate());
                start.max(endDate);
            } else if (startDate) {
                end.min(new Date(startDate));
            } else {
                endDate = new Date();
                start.max(endDate);
                end.min(endDate);
            }
        }

        end = $("#TradedRange").kendoDatePicker({
            change: endChange
        }).data("kendoDatePicker");
        start.max(end.value());
        end.min(start.value());
    } catch (err) {
        console.log(err.Message);
    }
}

function tryReturnTradeDate() {
    try {
        var nTranDate;
        var tranDateRange;

        function startnTranDate() {
            var startDate = nTranDate.value(),
                endDate = tranDateRange.value();

            if (startDate) {
                startDate = new Date(startDate);
                startDate.setDate(startDate.getDate());
                tranDateRange.min(startDate);
            } else if (endDate) {
                nTranDate.max(new Date(endDate));
            } else {
                endDate = new Date();
                nTranDate.max(endDate);
                tranDateRange.min(endDate);
            }
        }

        nTranDate = $("#dateTranDate").kendoDatePicker({
            change: startnTranDate
        }).data("kendoDatePicker");

        function endTranDateRange() {
            var endDate = tranDateRange.value(),
                startDate = nTranDate.value();

            if (endDate) {
                endDate = new Date(endDate);
                endDate.setDate(endDate.getDate());
                nTranDate.max(endDate);
            } else if (startDate) {
                tranDateRange.min(new Date(startDate));
            } else {
                endDate = new Date();
                nTranDate.max(endDate);
                tranDateRange.min(endDate);
            }
        }

        tranDateRange = $("#TranDateRange").kendoDatePicker({
            change: endTranDateRange
        }).data("kendoDatePicker");
        nTranDate.max(tranDateRange.value());
        tranDateRange.min(nTranDate.value());
    } catch (err) {
        console.log(err.Message);
    }
}

function tryReturnSettlement() {

    try {
        var startnSettlement;
        var endnSettlement;

        function startChangenSettlement() {
            var startDate = startnSettlement.value(),
                endDate = endnSettlement.value();

            if (startDate) {
                startDate = new Date(startDate);
                startDate.setDate(startDate.getDate());
                endnSettlement.min(startDate);
            } else if (endDate) {
                startnSettlement.max(new Date(endDate));
            } else {
                endDate = new Date();
                startnSettlement.max(endDate);
                endnSettlement.min(endDate);
            }
        }

        startnSettlement = $("#dateSettlement").kendoDatePicker({
            change: startChangenSettlement
        }).data("kendoDatePicker");

        function endChangenSettlement() {
            var endDate = endnSettlement.value(),
                startDate = startnSettlement.value();

            if (endDate) {
                endDate = new Date(endDate);
                endDate.setDate(endDate.getDate());
                startnSettlement.max(endDate);
            } else if (startDate) {
                endnSettlement.min(new Date(startDate));
            } else {
                endDate = new Date();
                startnSettlement.max(endDate);
                endnSettlement.min(endDate);
            }
        }

        endnSettlement = $("#SettlementRange").kendoDatePicker({
            change: endChangenSettlement
        }).data("kendoDatePicker");
        startnSettlement.max(endnSettlement.value());
        endnSettlement.min(startnSettlement.value());
    } catch (err) {
        console.log(err.Message);
    }
}

function tryReturnTransactionLoadDate() {
    try {
        var nTransactionLoadDate;
        var TransactionLoadDateRange;

        function startTransactionLoadDate() {
            var startDate = nTransactionLoadDate.value(),
                endDate = TransactionLoadDateRange.value();

            if (startDate) {
                startDate = new Date(startDate);
                startDate.setDate(startDate.getDate());
                TransactionLoadDateRange.min(startDate);
            } else if (endDate) {
                nTransactionLoadDate.max(new Date(endDate));
            } else {
                endDate = new Date();
                nTransactionLoadDate.max(endDate);
                TransactionLoadDateRange.min(endDate);
            }
        }

        nTransactionLoadDate = $("#dateTransactionLoadDate").kendoDatePicker({
            change: startTransactionLoadDate
        }).data("kendoDatePicker");

        function endTransactionLoadDate() {
            var endDate = TransactionLoadDateRange.value(),
                startDate = nTransactionLoadDate.value();

            if (endDate) {
                endDate = new Date(endDate);
                endDate.setDate(endDate.getDate());
                nTransactionLoadDate.max(endDate);
            } else if (startDate) {
                TransactionLoadDateRange.min(new Date(startDate));
            } else {
                endDate = new Date();
                nTransactionLoadDate.max(endDate);
                TransactionLoadDateRange.min(endDate);
            }
        }

        TransactionLoadDateRange = $("#TransactionLoadDateRange").kendoDatePicker({
            change: endTransactionLoadDate
        }).data("kendoDatePicker");
        nTransactionLoadDate.max(TransactionLoadDateRange.value());
        TransactionLoadDateRange.min(nTransactionLoadDate.value()); //nTransactionLoadDate = $("#dateTransactionLoadDate").kendoDatePicker({
        //    change: startTransactionLoadDate
        //}).data("kendoDatePicker");
//TransactionLoadDateRange = $("#TransactionLoadRange").kendoDatePicker({
        //    change: endTransactionLoadDate
        //}).data("kendoDatePicker");
        //nTransactionLoadDate.max(TransactionLoadDateRange.value());
        //TransactionLoadDateRange.min(nTransactionLoadDate.value());
    } catch (err) {
        console.log(err.Message);
    }
}

function tryReturnFunctionD() {
    try {
        var nDateStamp;
        var endDate_StampRange;

        function nDateStampstartChange() {
            var startDate = nDateStamp.value(),
                endDate = endDate_StampRange.value();

            if (startDate) {
                startDate = new Date(startDate);
                startDate.setDate(startDate.getDate());
                endDate_StampRange.min(startDate);
            } else if (endDate) {
                nDateStamp.max(new Date(endDate));
            } else {
                endDate = new Date();
                nDateStamp.max(endDate);
                endDate_StampRange.min(endDate);
            }
        }

        nDateStamp = $("#dateDate_Stamp").kendoDatePicker({
            change: nDateStampstartChange
        }).data("kendoDatePicker");

        function stampRangeChange() {
            var endDate = endDate_StampRange.value(),
                startDate = nDateStamp.value();

            if (endDate) {
                endDate = new Date(endDate);
                endDate.setDate(endDate.getDate());
                nDateStamp.max(endDate);
            } else if (startDate) {
                endDate_StampRange.min(new Date(startDate));
            } else {
                endDate = new Date();
                nDateStamp.max(endDate);
                endDate_StampRange.min(endDate);
            }
        }

        endDate_StampRange = $("#Date_StampRange").kendoDatePicker({
            change: stampRangeChange
        }).data("kendoDatePicker");
        nDateStamp.max(endDate_StampRange.value());
        endDate_StampRange.min(nDateStamp.value());
    } catch (err) {
        console.log(err.Message);
    }
}

function tryStyle() {
    try {
        $(".dateStyleQuickFind").each(function() {
            $(this).attr("width", "");
            $(this).css("width", "");
        });

    } catch (er2R) {
        console.log(er2R.Message);
    }
}

function CheckBoxQuickSort(name, e, columnName) {
    if (e.checked) {
        var checkedV = "ASC";
        $("." + columnName).each(function() {
            $("#" + columnName + $(this).val()).remove();
            if (this.checked) {
                checkedV = $(this).val();
            }

        });
        $("." + columnName).each(function() {
            if ($(this).val() === checkedV) {
                $(this).prop("checked", true);
                $("#sortable").append("<li id='" + columnName + checkedV + "'>" + name + " " + checkedV + "</li>");
            }

        });
    } else {
        $("." + columnName).each(function() {
            $("#" + columnName + $(this).val()).remove();
        });
    }
}

function RadioQuickSort(name, value, oldValue, columnName) {
    $(".quickSortCheckBox").each(function() {
        try {
            if (this.checked) {
                $("#" + columnName + oldValue).text(name + " " + value);
                $("#" + columnName + oldValue).attr("id", columnName + value);
            }
        } catch (err) {
            var msgError = err.Message;
        }
    });
}