$(document).on('ready', function () {
    //console.log("Hello bunny o.o");

    $.ajax({ // function that starts the HTTP request to the server
        "url": "currency/list",
        "success": function (data) { //if the request is accepted, success function will run
            for (var i = 0; i < data.length; i++) {
                $('#currencySelect1').append($("<option></option>").attr("value", data[i].Id).text(data[i].Name));
                $('#currencySelect2').append($("<option></option>").attr("value", data[i].Id).text(data[i].Name));
            }
            console.log(data);
        },
        "error": function (error) { //if the request is not being accepted
            console.log(error);
        }
    });

    $('#convertButton').on('click', function () { //when you press the conversion button
        var c1 = $('#currencySelect1 option:selected').text(); // choosing the first currency
        var c2 = $('#currencySelect2 option:selected').text(); // choosing the second currency
        var amount = $('#currency1Amount').val();
        // console.log(c1, c2, amount);//show the chosen currencies

        $.ajax({
            "url": "currency/convert/" + c1 + "/" + c2 + "/" + amount,
            "success": function (data) {
                $('#currency2Amount').val(data);
            },
            "error": function (error) {
                console.log(error);
            }
        })

    });


    
});