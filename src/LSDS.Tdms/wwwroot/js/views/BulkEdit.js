$(document).ready(function() {

        var bulkData;

        $.getJSON(
            BulkEditTypeUrl(), {},
            function(myData) {
                bulkData = myData;
                $("#typeCommentBulk").kendoDropDownList({
                    dataTextField: "TargetColumn",
                    animation: false,
                    dataValueField: "tdxBulkCopy_ID",
                    dataSource: {
                        data: myData
                    }
                });
            });
        $("#typeCommentBulk").on("change", function() {
            $("#tdEditBulkComment").val("");
        });
        $("#tdEditBulkComment").on("input", function() {

            for (var i = 0; i < bulkData.length; i++) {
                if (bulkData[i].tdxBulkCopy_ID === $("#typeCommentBulk").val()) {
                    $("#tdEditBulkComment").attr("maxlength", bulkData[i].MaxLength);
                }

            }


        });


        $("#idBulkEditSave").on("click", function() {
            var window = $("#BulkEdit").data("kendoWindow");
            var selectedTrades = $("#tradeListId").val();
            var bulkComment = $("#tdEditBulkComment").val();
            var bulkCommentType = $("#typeCommentBulk option:selected").text();

            $("#BulkEdit").html("<div>Loading...</div>");
            $("#BulkEdit").show();

            $.ajax({
                type: "GET",
                url: BulkEditCommentExecuteUrl(),
                data: {
                    "selectedTrades": selectedTrades,
                    "bulkComment": bulkComment,
                    "bulkCommentType": bulkCommentType
                },
                success: function(data) {
                    var count = 0;

                    for (var j in data) if (data.hasOwnProperty(j)) count++;

                    alert(count + " trades Updated.");
                    window.close();
                    window.getTableDetailTradeView();
                }
            });

        });
    });