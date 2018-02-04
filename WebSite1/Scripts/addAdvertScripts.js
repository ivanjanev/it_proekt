$(document).ready(function () {
    $("#submitAdvert").click(function (event) {
        event.preventDefault();

        var company = $("#companyInput").val();
        var title = $("#titleInput").val();
        var description = $("#descriptionInput").val();
        var fromDate = $("#fromDateInput").val();
        var toDate = $("#toDateInput").val();
        var category = $('#categoryInput').find(":selected").text();
        
        $.ajax({
            type: "POST",
            url: "../dbService.asmx/addAdvert",
            contentType: "application/json; charset=utf-8",
            data: "{company:'" + company + "',title:'" + title + "',category:'" + category + "',description:'" + description + "',fromDate:'" + fromDate + "',toDate:'" + toDate + "'}",
            dataType: "json",
            success: function (r) {
                console.log(r);
                alert(r.d);
            },
            error: function (r) {
                console.log(r);
            },
            failure: function (r) {
                console.log(r);
            }
        });
        
    });
});