getQuickFind();
    getQuickSort();
    getTableDetailTradeView();

    function intTradeView(columnDetailArray, aggregateList) {

        $("#gridTradeView").kendoGrid({
            dataSource: {
                type: "json",
                transport: {
                    read: {
                        url: GetTradeViewUrl(),
                        dataType: "json",
                        type: "POST"

                    },
                    parameterMap: function(options) {
                        //console.log(JSON.stringify(options));
                        return options;
                    }
                },
                pageSize: msieversion(),
                serverPaging: true,
                serverSorting: true,
                serverFiltering: true,
                aggregate: aggregateList,
                schema: {
                    model: {
                        id: "id"
                    },
                    data: "TradeList",
                    type: "json",
                    total: "Total"
                }
            },
            batch: true,
            pageable: {
                refresh: true,
                pageSizes: [15, 25, 50, 100],
                buttonCount: 5
            },
            filterable: true,
            selectable: "single",
            resizable: false,
            reorderable: false,
            sortable: {
                mode: "single",
                allowUnsort: false
            },
            majorGridLines: {
                step: 250,
                visible: true
            },
            height: $(window).height() - 150,
            columns: columnDetailArray,
            toolbar: [
                {
                    template: $("#tradeViewToolBar").html()
                }
            ],
            dataBound: function() {

                $(".myDDL").css("width", "300px");
                setIconState();
                var tempTradeIdList = "";
                $(".selectCheckBox").each(function() {
                    tempTradeIdList = tempTradeIdList + $(this).attr("id") + ",";
                });
                $("#tempTradeIdList").val(tempTradeIdList.substring(0, tempTradeIdList.length - 1));

            },
            change: function() {
                getGridIndex();
                var model = this.dataItem(this.select());
                tdTrade = model.tdTrade; //gets the value of the field "ID"
                window.openTradeDetail(tdTrade, $("#tempTradeIdList").val());
                //  window.openTradeDetail(tdTrade, this.dataSource.total(), );
            }
        });


    }

    function TradeListSearch() {
        window.location.href = GetTradeListSearchUrl();
    }


    function hover(element, strFileName) {
        element.setAttribute("src", GetImagePath() + strFileName);
    }

    function unhover(element, strFileName) {
        element.setAttribute("src", GetImagePath() + strFileName);
    }

    function TradeListToolNo(e) {
        // $.alert($("#tdToolno").attr("src"));
        if ($("#tdToolno").attr("src").indexOf("no.png") > -1) {
            var list = $("#tradeListId").val().split(",");

            for (var i = 0; i < $("#gridTradeView").data("kendoGrid").dataSource.view().length; i++) {
                if (list[0] == $("#gridTradeView").data("kendoGrid").dataSource.view()[i].tdTrade) {
                    if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].Deleted === "No") {
                        if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].Archived === 0) {
                            if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].History === 0) {
                                if ($("#tradeListId").val() !== "") {
                                    $.ajax({
                                        type: "GET",
                                        url: ArchiveTradeUrl(),
                                        data: {
                                            "selectedTrades": $("#tradeListId").val()

                                        },
                                        success: function(data) {
                                            $.alert(data.result);
                                            getTableDetailTradeView();
                                        },
                                        error: function(error) {
                                            $.alert(error);
                                        }
                                    });

                                }
                            }
                        }
                    }
                }
            }
        } else {
            console.log("Archive disabled.");
        }
    }

    function TradeListToolTick(e) {

        if ($("#tdToolTick").attr("src").indexOf("Tick.png") > -1) {
            var list = $("#tradeListId").val().split(",");

            for (var i = 0; i < $("#gridTradeView").data("kendoGrid").dataSource.view().length; i++) {
                if (list[0] == $("#gridTradeView").data("kendoGrid").dataSource.view()[i].tdTrade) {
                    if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].Deleted === "Yes") {
                        if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].Archived === 1) {
                            if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].History === 0) {
                                if ($("#tradeListId").val() !== "") {

                                    $.ajax({
                                        type: "GET",
                                        url: UnArchiveTrade(),
                                        data: {
                                            "selectedTrades": $("#tradeListId").val()

                                        },
                                        success: function(data) {
                                            $.alert(data.result);
                                            getTableDetailTradeView();
                                        },
                                        error: function(error) {
                                            $.alert(error);
                                        }
                                    });

                                }
                            }
                        }
                    }
                }
            }
        } else {
            console.log("Unarchive disabled");
        }
    }

    function openTradeDetail(tdTrade, tradeIdList) {

        $("#tradeSelectedId").val(tdTrade);
        $("#idPostTradeList").submit();

    }


    function getQuickFind() {
        $.getJSON(
           GetTradeFind(), {},
            function(myData) {
                myData.unshift(
                    { QuickfindID: 99999, Description: "Edit", LastUsed: false }
                );

                $("#searchSelect").kendoDropDownList({
                    dataTextField: "Description",
                    animation: false,
                    dataValueField: "QuickfindID",
                    dataSource: {
                        data: myData
                    }
                });

                var dropdownlistfind = $("#searchSelect").data("kendoDropDownList");
                dropdownlistfind.value(returnSelectedItem(myData, "Last Search"));
                dropdownlistfind.refresh();
            });
    }

    function getQuickSort() {
        $.getJSON(
            GetTradeSort(), {},
            function(myData) {
                myData.unshift(
                    { QuickSortID: 99999, Description: "Edit", LastUsed: false }
                );

                $("#sortSelect").kendoDropDownList({
                    animation: false,
                    dataTextField: "Description",
                    dataValueField: "QuickSortID",
                    dataSource: {
                        data: myData
                    }
                });
                var previous;

                var dropdownlist = $("#sortSelect").data("kendoDropDownList");
                dropdownlist.value(returnSelectedItemSort(myData, "Last Sort"));
                dropdownlist.refresh();

            });
    }

    function onQuickFindChange(e) {

        var findId = e.options[e.selectedIndex].value;
        if (findId === "99999" || findId === 99999) {
            loadQuickFindPopup();
        } else {
            $.post(GetTradeFindUrl(), { quickFindtId: findId }, function (json) {
                getTableDetailTradeView();
            }, "json");
        }

    }

    function onQuickSortChange(e) {
        var sortId = e.options[e.selectedIndex].value;
        if (sortId === "99999") {
            loadQuickSortPopup();
        } else {
            $.post(GetTradeSortUrl(), { quickSortId: sortId }, function (json) {
                getTableDetailTradeView();
            }, "json");
        }
    }

    function onRefresh(e) {
        loadQuickFindPopup();
    }

    function loadQuickFindPopup() {


        window.location.href = QuickFindUrl();
    }

//File Upload
    function loadFileUploadPopup() {
        if ($("#tdTooliconUpload").attr("src").indexOf("iconUpladOver.png") > -1) {
            //  $.alert($("#tradeListId").val());
            if ($("#tradeListId").val().length > 0) {
                $("#fileUpload").html("<div class='uploadFileDiv'>" +
                    "<form action='"+GetAttachmentUrl()+"' method='POST' enctype='multipart/form-data'>" +
                    "<input name='myFile' id='myFile' type='file' />" +
                    "<input name='hiddenInput' id='hiddenInput' type='hidden' value=" + $("#tradeListId").val() + " />" +
                    "<INPUT  onmouseover=\"javascript:this.className ='clsFloatButton'; \" onmouseout=\"javascript:this.className ='clsFloatButtonOver'; \" id=btn_uploadfile class=clsFloatButton  type='submit' value=\"Attach File to Selected Trades\" name=btn_uploadfile >" +
                    "</form>" +
                    "</div>");
                $("#fileUpload").show();
                $("#fileUpload").data("kendoWindow").center().open();
            } else {
                $.alert("No trades seleted.");
            }
        } else {
            console.log("Button Disabled Click");
        }

    }

    // Bulk Edit
    function loadBulkEditPopup() {

        if ($("#tdToolpencil").attr("src").indexOf("pencil.png") > -1) {
            if ($("#tradeListId").val().length > 0) {

                $("#BulkEdit").html("<div>Loading...</div>");
                $("#BulkEdit").show();
                $("#BulkEdit").data("kendoWindow").center().open();
                kendo.ui.progress($("#BulkEdit"), true);
                $.ajax({
                    type: "GET",
                    url: BulkEditTypeUrl(),
                    data: {
                        "source": "TradeBrowser"
                    },
                    success: function(data) {
                        //  $.alert(JSON.stringify(data));
                        $("#BulkEdit").html(data);
                        $("#BulkEdit").show();
                        $("#BulkEdit").data("kendoWindow").center().open();
                    }
                });
            } else {
                $.alert("No trades seleted.");
            }
        } else {
            console.log("Bulk Edit disabled.");
        }
    }

    function AttachFile() {
        var formData = new FormData($("form")[0]);
        $.alert(JSON.stringify(formData));
        $.ajax({
            url: GetAttachmentUrl(),
            type: "POST",
            xhr: function() { // Custom XMLHttpRequest
                var myXhr = $.ajaxSettings.xhr();
                if (myXhr.upload) { // Check if upload property exists
                }
                return myXhr;
            },
            //Ajax events
            // Form data
            //Options to tell jQuery not to process data or worry about content-type.
            cache: false,
            contentType: false,
            processData: false
        });

    }

    function loadQuickSortPopup() {
        $("#quickSortPopup").html("<div>Loading...</div>");
        $("#quickSortPopup").show();
        $("#quickSortPopup").data("kendoWindow").center().open();
        kendo.ui.progress($("#quickSortPopup"), true);
        $.ajax({
            type: "GET",
            url: QuickSortPageUrl(),
            data: {
                "source": "TradeBrowser"
            },
            success: function(data) {
                $("#quickSortPopup").html(data);
                $("#quickSortPopup").show();
                $("#quickSortPopup").data("kendoWindow").center().open();
            }
        });
    }


    function TradeListPrint() {

        $("#printTradeList").html("<div>Loading...</div>");
        $("#printTradeList").show();
        $("#printTradeList").data("kendoWindow").center().open();
        kendo.ui.progress($("#printTradeList"), true);
        $.ajax({
            type: "GET",
            url: TradePrintOptionsUrl(),
            data: {
                //"source": "TradeBrowser"

            },
            success: function(data) {
                $("#printTradeList").html(data);
                $("#printTradeList").show();
                $("#printTradeList").data("kendoWindow").center().open();
                eval(data);
            }
        });
    }

    function myFunction() {
        var kPopup = $("#ExportProfile").data("kendoWindow");
        kPopup.close();
    }

    function tradeListExport() {

        if ($("#tradeListId").val().length > 0) {
            if (confirm("Would you like to export?\r\n")) {
                $("#ExportProfile").html("<div>Loading...</div>");
                $("#ExportProfile").show();
                $("#ExportProfile").data("kendoWindow").center().open();

                $.getJSON(
                    PrintTradeViewSelectUrl()  + "?contactType=1&notifyType=1&comment=Comment&tradeList=js-tradeList&type=print".replace("js-tradeList", $("#tradeListId").val()),
                    function(myData) {


                        window.location.href = TradeListDownloadUrl() + + "?fileName=" + myData.items[0].fileName + "&filePath=" + myData.items[0].filePath;
                        var kPopup = $("#ExportProfile").data("kendoWindow");
                        kPopup.close();

                    });

            }
        } else {
            if (confirm("No Trades selected. Exporting more than 50  trades may take few minutes.\r\nContinue?")) {
                var tempIdList = "";
                $(".selectCheckBox").each(function() {
                    tempIdList = tempIdList + $(this).attr("id") + ",";
                });

                tempIdList = tempIdList.substring(0, tempIdList.length - 1);


                $.getJSON(
                    PrintTradeViewSelectUrl() + "?contactType=1&notifyType=1&comment=Comment&tradeList=js-tradeList&type=print".replace("js-tradeList", tempIdList),
                    function(myData) {


                        window.location.href = TradeListDownloadUrl()  + "?fileName=" + myData.items[0].fileName + "&filePath=" + myData.items[0].filePath;
                        var kPopup = $("#ExportProfile").data("kendoWindow");
                        kPopup.close();

                    });
            }
        }


    }


    function TDMSTradeResolution(e) {
        if ($("#tdToolwrench").attr("src").indexOf("wrench.gif") > -1) {
            $("#poopTDMSTradeResolution").html("<div>Loading...</div>");
            $("#poopTDMSTradeResolution").show();
            $("#poopTDMSTradeResolution").data("kendoWindow").center().open();
            kendo.ui.progress($("#poopTDMSTradeResolution"), true);
            $.ajax({
                type: "GET",
                url: GetTradeResolutionUrl(),
                data: {
                    //"source": "TradeBrowser"

                },
                success: function(data) {
                    $("#poopTDMSTradeResolution").html(data);
                    $("#poopTDMSTradeResolution").show();
                    $("#poopTDMSTradeResolution").data("kendoWindow").center().open();

                }
            });
        } else {
            console.log("Resolution disabled");
        }

    }

    function TDMSManualMatch(e) {

        if ($("#tdToolhammer").attr("src").indexOf("hammer-icon.png") > -1) {
            $("#poopTDMSManualMatch").html("<div>Loading...</div>");
            $("#poopTDMSManualMatch").show();
            $("#poopTDMSManualMatch").data("kendoWindow").center().open();
            kendo.ui.progress($("#poopTDMSManualMatch"), true);
            $.ajax({
                type: "GET",
                url: GetManualMatchUrl(),
                data: {
                    "idList": $("#tradeListId").val()

                },
                success: function(data) {
                    $("#poopTDMSManualMatch").html(data);
                    $("#poopTDMSManualMatch").show();
                    $("#poopTDMSManualMatch").data("kendoWindow").center().open();

                }
            });
        } else {
            console.log("Match disabled");
        }
    }

    function TradeListToolBroken(e) {
        // alert("implement2");
        if ($("#tdToolBroken").attr("src").indexOf("Broken.GIF") > -1) {
            if ($("#tradeListId").val() !== "") {

                $("#poopTDMSFailedTrades").html("<div>Loading...</div>");
                $("#poopTDMSFailedTrades").show();
                $("#poopTDMSFailedTrades").data("kendoWindow").center().open();
                kendo.ui.progress($("#poopTDMSFailedTrades"), true);
                $.ajax({
                    type: "GET",
                    url: GetFailedTradesUrl(),
                    data: {
                        "idList": $("#tradeListId").val()

                    },
                    success: function(data) {
                        $("#poopTDMSFailedTrades").html(data);
                        $("#poopTDMSFailedTrades").show();
                        $("#poopTDMSFailedTrades").data("kendoWindow").center().open();

                    }
                });


            } else {
                $.alert("No trades selected.");
            }
        } else {
            console.log("Broken disabled");
        }
        return false;
    }

    function getTableDetailTradeView() {
        //alert("I was called!");
        $.ajax({
            type: "GET",
            url: GetTableDetailUrl(),
            data: {
                "source": "TradeBrowser"

            },
            success: function(data) {
                var aggregateList = data[0].aggregateList;
                intTradeView(data, aggregateList);
            }
        });

    }


    function setIconState() {
        //console.log("setState" + $("#tradeListId").val());

        //Export	Always enabled
        //Search	Always enabled
        //Print	Always enabled tdToolprinter Content/Images/printer-icon.png
        // Default disable these icons
        $("#tdTooliconUpload").attr("src", GetImagePath() + "iconUplad.png");
        $("#tdToolhammer").attr("src", GetImagePath() + "hammer-icon_d.png");
        $("#tdToolwrench").attr("src", GetImagePath() + "wrench_d.gif");
        $("#tdToolBroken").attr("src", GetImagePath() + "Broken_d.GIF");
        $("#tdToolno").attr("src", GetImagePath() + "no_d.png");
        $("#tdToolTick").attr("src", GetImagePath() + "Tick_d.png");
        $("#tdToolpencil").attr("src", GetImagePath() + "pencil_d.png");

        try {


            var list = $("#tradeListId").val().split(",");
            if ($("#tradeListId").val() !== "") {
                for (var i = 0; i < $("#gridTradeView").data("kendoGrid").dataSource.view().length; i++) {
                    if (list[0] == $("#gridTradeView").data("kendoGrid").dataSource.view()[i].tdTrade) {

                        //Attach	Enable when Hist = No for top selected trade
                        //Bulk Edit	Enable when Hist = No for top selected trade tdToolpencil
                        if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].History === 0) {
                            $("#tdTooliconUpload").attr("src", GetImagePath() + "iconUpladOver.png");
                            $("#tdToolpencil").attr("src", GetImagePath() + "pencil.png");
                        }

                        if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].Deleted === "No") {
                            if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].History === 0) {
                                //Fail	Enable when Del and Hist = No for top selected trade
                                $("#tdToolBroken").attr("src", GetImagePath() + "Broken.GIF");
                                if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].Archived === 0) {
                                    if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].Status !== "Matched") {
                                        //Force Match	Enable when Del, Arch and Hist = No and Status <> Matched for top selected trade
                                        $("#tdToolhammer").attr("src", GetImagePath() + "hammer-icon.png");
                                        //Resolution	Enable when Del, Arch and Hist = No and Status <> Matched for top selected trade
                                        $("#tdToolwrench").attr("src", GetImagePath() + "wrench.gif");
                                        //Archive	Enable when Del, Arch and Hist = No and Status <> Matched for top selected trade
                                        $("#tdToolno").attr("src", GetImagePath() + "no.png");
                                    }

                                }
                            }
                        }

                        if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].Deleted === "Yes" || $("#gridTradeView").data("kendoGrid").dataSource.view()[i].Archived === 1) {
                            if ($("#gridTradeView").data("kendoGrid").dataSource.view()[i].History === 0) {

                                //Unarchive	Enable when Del or Arch = Yes and Hist = No for top selected trade
                                $("#tdToolTick").attr("src", GetImagePath() + "Tick.png");

                            }

                        }
                    }
                }
            }
        } catch (ex) {
            console.log(ex.Message);
        }
    }


    function fileUploadRefresh() {
    }

    function fileUploadClose() {
    }


    var jsonData;
    var tdTrade;

    $(document).ready(function() {


    });
    $(window).resize(function() {
        getTableDetailTradeView();
    });

    function msieversion() {

        var ua = window.navigator.userAgent;
        var msie = ua.indexOf("MSIE ");

        if (msie > 0 || !!navigator.userAgent.match(/Trident.*rv\:11\./)) // If Internet Explorer, return version number
            return 10;
        else // If another browser, return 0
            return 100;

    }

    function returnSelectedItemSort(myData, identifyMe) {

        var selectedItem = 99999;
        $.each(myData, function(i, item) {
            if (item.LastUsedToday === 1) {
                selectedItem = item.QuickSortID;
            } else if (selectedItem === 99999) {
                $.each(myData, function(i, item) {
                    if (item.Description === identifyMe) {
                        selectedItem = item.QuickSortID;
                    }
                });
            } else if (selectedItem === 99999) {
                $.each(myData, function(i, item) {
                    if (item.LastUsed === true) {
                        selectedItem = item.QuickSortID;
                    }
                });
            }
        });

        return selectedItem;
    }

    function returnSelectedItem(myData, identifyMe) {

        var selectedItem = 99999;
        $.each(myData, function(i, item) {
            if (item.LastUsedToday === 1 || item.LastUsedToday === true) {

                selectedItem = item.QuickfindID;
            }
        });
        if (selectedItem === 99999) {

            $.each(myData, function(i, item) {
                console.log("2" + item.LastUsedToday + item.QuickfindID);
                if (item.LastUsed === true || item.LastUsed === 1) {
                    selectedItem = item.QuickfindID;
                }
            });
        }
        if (selectedItem === 99999) {
            $.each(myData, function(i, item) {
                console.log("3" + item.LastUsedToday + item.QuickfindID);
                if (item.Description === identifyMe) {
                    selectedItem = item.QuickfindID;
                }
            });
        }
        console.log(selectedItem);
        //  alert(selectedItem);
        return selectedItem;
    }

    function bulkEditRefresh() {
    }

    function bulkEditClose() {
    }

    function exportClose() {
    }

    function getGridIndex() {
        var grid = $("#gridTradeView").data("kendoGrid");
        var dataRows = grid.items();
        var rowIndex = dataRows.index(grid.select());
    }

    function printClose() {

    }


    function uploadFile() {
        $.alert("Create Popup pass data");
    }

    var tdTableIds;

    function checkBoxTradeList(ids) {
        //console.log("click");
        checkIdList();
        setIconState();
    }

    function disabled() {
        return false;
    }

    function checkIdList() {
        var ids = "";
        $(".selectCheckBox").each(function() {
            if ($(this).is(":checked")) {

                ids = ids + $(this).attr("id") + ",";
            }

        });

        $("#tradeListId").val(ids.substring(0, ids.length - 1));

    }

    function tdmsTradeResolutionClose() {
    }

    function tdmsManualMatchClose() {
    }

    function failedTradesClose() {


    }