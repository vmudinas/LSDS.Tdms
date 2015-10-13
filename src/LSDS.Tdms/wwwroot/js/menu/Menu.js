function onSelect(e) {
    var item = $(e.item),
        menuElement = item.closest(".k-menu"),
        dataItem = this.options.dataSource,
        index = item.parentsUntil(menuElement, ".k-item").map(function() {
            return $(this).index();
        }).get().reverse();

    index.push(item.index());

    for (var i = -1, len = index.length; ++i < len;) {
        dataItem = dataItem[index[i]];
        dataItem = i < len - 1 ? dataItem.items : dataItem;
    }
}

$(document).ready(function() {
    $.getJSON(
       GetMenuUrl(), {},
        function(myData) {

            $("#tdmsMenu").kendoMenu({ dataSource: myData }).data("kendoMenu");
        });
});