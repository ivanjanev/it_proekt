$(document).ready(function () {

    var cat = $(".advertCat").text();

    $.ajax({
        type: "POST",
        url: "../dbService.asmx/getAdvertByCategory",
        contentType: "application/json; charset=utf-8",
        data: "{category:'" + cat + "'}",
        dataType: "json",
        success: function (r) {
            console.log(" this is the json");
            console.log(r);
            try {
                var array = jQuery.parseJSON(r.d);
                $.each(array, function () {
                    var fromdate = new Date(parseInt(this.fromDate.substr(6)));
                    fromdate = fromdate.toString().substr(0, 15);
                    var todate = new Date(parseInt(this.toDate.substr(6)));
                    todate = todate.toString().substr(0, 15);
                    //var append = '<div class="col-md-3">title:' + this.title + '<br> category:' + this.category + '<br> desc:' + this.description + '<br> company:' + this.company + '<br> from-to:' + fromdate + '-' + todate + ' </div>';
                    var append = '<a href="OglasPreview.aspx?id=' + this.id + '"><div class="col-lg-4"><div class="card"><h4>' + this.title + '</h4><p>' + this.description + '</p><a href="OglasPreview.aspx?id=' + this.id + '" class="blue-button">Read More</a></div></div></a>';
                    $("#oglasiPoKatDiv").append(append);
                });
            }
            catch (e) {
                console.log("This is the json Error "+e);
            }
        },
        error: function (r) {
            console.log("this is the response error "+r);
        },
        failure: function (r) {
            console.log("this is a failure "+r);
        }
    });
});