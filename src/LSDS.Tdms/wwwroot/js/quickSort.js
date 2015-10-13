
$(document).ready(function() {

    var quickSortData;
    var userId = $("#userNameLable").val();
    $.getJSON(
        "/QuickSort/ReturnSortName", { userName: userId, source: "TradeBrowser" },
        function(myData) {
            var mySelect = $("#ddlSelectView");
            quickSortData = myData;
            $.each(myData, function() {
                if (this.Description !== "Last Sort") {
                    mySelect.append(
                        $("<option></option>").val(this.QuickSortID).html(this.Description)
                    );
                }
            });
        });


    $("#ddlSelectView").on("change", function() {
        $("#sortable").empty();

        $.each($("*"), function() {
            $(this).prop("checked", false);
        });
        if ($("#ddlSelectView option:selected").text() !== "Select Sort") {
            $("#idSaveQuickSort").val($("#ddlSelectView option:selected").text());
            $(".quickSortIdclass").val($("#ddlSelectView option:selected").val());

            $.each(quickSortData, function() {
                //alert(this.LastUsedToday);

                if (this.Description === $("#ddlSelectView option:selected").text()) {
                    // $(".defaultSortCheckbox").attr("checked", this.LastUsedToday);
                    if (this.LastUsedToday === 1) {
                        $(".defaultSortCheckbox").prop("checked", true);
                    } else {
                        $(".defaultSortCheckbox").prop("checked", false);
                    }
                    var arr = this.QuickSort_Query.split(",");
                    $.each(arr, function(number) {

                        var arrClass = arr[number].split(" ");
                        $("#" + arrClass[0]).attr("checked", "checked");
                        $.each($("." + arrClass[0]), function() {
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
        listItems.each(function(idx, li) {
            tempSortValue = tempSortValue + $(li).attr("id");
        });

        $("#idsortValues").val(tempSortValue);
    });
    $("#sortable").kendoSortable({

    });
    $("#quickFindCancel").on("click", function() {
        $("#quickFindPopup").data("kendoWindow").close();
    });
    $("#quickSortCancel").on("click", function() {
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


});

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