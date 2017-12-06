$(document).on('ready', function () {
    console.log("Hello bunny o.o");

    $.ajax({
        "url": "currency/list",
        "success": function (data) {
            console.log(data);
        },
        "error": function (error) {
            console.log(error);
        }
    })
    
});