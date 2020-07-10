$(document).ready(function () {
    $(".btn-comentarios").on("click", function () {
        $.ajax({
            url: 'Albums/comments',
            type: 'POST',
            data: {
                id = $(this).attr("id")
            },
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            error: function (xhr) {
                alert('Error: ' + xhr.statusText);
            },
            success: function (result) {
                CheckIfInvoiceFound(result);
            },
            async: true,
            processData: false
        });
    });
});