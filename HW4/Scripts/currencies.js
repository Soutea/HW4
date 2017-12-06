$(document).on('ready', function () {
    //console.log("Hello bunny o.o");

    $.ajax({ // function that starts the HTTP request to the server
        "url": "/currency/list",
        "success": function (data) { //if the request is accepted, success function will run
            for (var i = 0; i < data.length; i++) {
                var tr = $("<tr></tr>");
                var td = $("<td></td>").text(data[i].Name);
                var td2 = $("<td></td>").text(data[i].ValueInEuros);
                tr.append(td).append(td2);
                $('#currencyTBody').append(tr);
            }
            console.log(data);
        },
        "error": function (error) { //if the request is not being accepted
            console.log(error);
        }
    });
});