$(document).ready(function () {
    console.log();

    $.ajax({
        type: "POST",
        url: "../dbService.asmx/getAdvertById",
        contentType: "application/json; charset=utf-8",
        data: "{id:" + $(".brOglas").text()+"}",
        dataType: "json",
        success: function (r) {
            console.log(r);
            try {
                var array = jQuery.parseJSON(r.d);
                $.each(array, function () {
                    var fromdate = new Date(parseInt(this.fromDate.substr(6)));
                    fromdate = fromdate.toString().substr(0, 15);
                    var todate = new Date(parseInt(this.toDate.substr(6)));
                    todate = todate.toString().substr(0, 15);
                    $("#title").text(this.title);
                    $("#company").text(this.company);
                    $("#category").text(this.category);
                    $("#description").text(this.description);
                    $("#fromDate").text(fromdate);
                    $("#toDate").text(todate);
                });
            }
            catch (e) {
                console.log(e);
            }
        },
        error: function (r) {
            console.log(r);
        },
        failure: function (r) {
            console.log(r);
        }
    });
});