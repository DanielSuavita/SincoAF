$(document).ready(function () {
    $("#ProductTable").DataTable({
        "ajax": '../../Product/Select',
        columns: [
            { title: "no" },
            { title: "name" },
            { title: "userName" },
            { title: "email" }
        ]
    });

    $("#ProductsForm").on("submit", function (e) {
        var dataString = $(this).serialize();
        alert("funciona " + dataString);

        $.ajax({
            type: "POST",
            url: "/Product/Create",
            data: dataString,
            success: function () {
                alert("Funciona");
            },
            error: function () {
                alert("No Funciona");
            }
        });

        e.preventDefault();
    });
});