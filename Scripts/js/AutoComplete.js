$(document).ready(function () {
    $("#txtSearch").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: '../AutoComplete.asmx/GetCustomers',
                data: "{ 'searchWord': '" + request.term + "'}",
                dataType: "json",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    response($.map(data.d, function (item) {
                        return {
                            label: item.split(';')[0],
                            val: item.split(';')[1]
                        }
                    }))
                },
                error: function (response) {
                    alert(response.responseText);
                },
                failure: function (response) {
                    alert(response.responseText);
                }
            });
        },
        select: function (e, i) {
            $("#hfId").val(i.item.val);
        },
        minLength: 1
    });
});